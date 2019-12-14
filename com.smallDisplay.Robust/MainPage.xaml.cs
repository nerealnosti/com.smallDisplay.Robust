using com.smallDisplay.Robust.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace com.smallDisplay.Robust
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page 
    {


        private readonly static Color solidBlacks = Colors.Black;
        private readonly static SolidColorBrush solidBlack = new SolidColorBrush(solidBlacks);


        private readonly static Color solidBorderBlacks = Color.FromArgb(255, 10, 10, 10);
        private static readonly SolidColorBrush solidBorderBlack = new SolidColorBrush(solidBorderBlacks);

        private static Color ColorOfLetters = Colors.Red;
        private static  SolidColorBrush ColorofLetters = new SolidColorBrush(ColorOfLetters);

        private static Color LetterBorder = Colors.Yellow;
        private static  SolidColorBrush LetterBorrders = new SolidColorBrush(LetterBorder);

        internal const short row = 100;
        internal const short col = 20;
        private readonly sbyte sizeOfRect = 6;
        private readonly Rectangle[,] rectangle = new Rectangle[row, col];
        private readonly int[,] Arr = new int[row, col]; 
        private readonly DispatcherTimer dtimer = new DispatcherTimer();
        private Queue str = new Queue();
        short counter = 0;
        private bool WordInput = false;
        private bool CharPrinted = true;
        private int[,] LetterArr;
        private string stringtoRepeat = "";
        private static int countToClearScreen = 0;
        private bool countinious = false;
        bool text = false, shadow = false;
        bool dateTime = false;
        bool date, time;
        
        

        public MainPage()
        {
            this.InitializeComponent();
            dtimer.Tick += Dtimer_Tick;
            dtimer.Interval = TimeSpan.FromMilliseconds(1);
            _ = new Board(rectangle, inside, row, col, solidBlack, solidBorderBlack, sizeOfRect);
            dtimer.Start();
            MoveLetters.SetIntArrToNum(Arr,0);
            InputStringToDisplay.Focus(FocusState.Pointer);


            
        }

        private void Dtimer_Tick(object sender, object e)
        {

            if (!dateTime)
            {
                MoveLetters.MoveDisplayUp(Arr, row, col, solidBlack, ColorofLetters);
                MoveLetters.ColorOcupiedLabels(Arr, rectangle, ColorofLetters, solidBlack, LetterBorrders);

                if (Repeat.IsChecked == false)
                {
                    RepeatNOtChecked();
                }
                else if (Repeat.IsChecked == true)
                {
                    RepeatString();
                }


                if (counter == 10) counter = 0;
            }
            else
            {
                MoveLetters.ColorOcupiedLabels(Arr, rectangle, ColorofLetters, solidBlack, LetterBorrders);
                MoveLetters.InsertTextToMiddle(Arr, row, col, time, date,"");
                

            }


        }


        private void RepeatString()
        {
            if (WordInput)
            {
                
                if (CharPrinted)
                {
                    
                    var nextLetter = (char)str.Dequeue();
                    nextLetter = ChecksForSpecChar(nextLetter);
                    LetterArr = Letters.ReturnArrLetter(nextLetter);
                    CharPrinted = false;
                }

                

                if (CharPrinted == false )
                {
                    MoveLetters.InsertLine(Arr, LetterArr, ref counter, ref CharPrinted); 
                }

                if(str.Count == 0 && CharPrinted == true)
                {
                    
                    WordInput = false;
                    return;
                }

                
            }

            

            if (str.Count == 0 && !string.IsNullOrEmpty(stringtoRepeat))
            {
                countToClearScreen++;

                if (countToClearScreen == row + 10)
                {
                    str = stringtoRepeat.ToQueue();
                    WordInput = true;
                    CharPrinted = true;
                    countToClearScreen = 0;

                }

            }
            

            
        }

        /// <summary>
        /// No repeat one time pass string
        /// </summary>
        private void RepeatNOtChecked()
        {
            if (WordInput)
            {
               
                if (CharPrinted)
                {

                    if (str.Count > 0)
                    {

                        var nextLetter = (char)str.Dequeue();
                        nextLetter = ChecksForSpecChar(nextLetter);
                        LetterArr = Letters.ReturnArrLetter(nextLetter);
                        CharPrinted = false;

                    }
                    else
                    {
                        WordInput = false;
                        return;

                    }


                }

                MoveLetters.InsertLine(Arr, LetterArr, ref counter, ref CharPrinted);

            }
        }

        private char ChecksForSpecChar(char nextLetter)
        {
            if (MoveLetters.CheckForSecChar(nextLetter, '|'))
            {
                nextLetter = (char)str.Dequeue();
                if (MoveLetters.CheckForSecChar(nextLetter, 'D'))
                {
                    str = str.AddAtFrontOfQueue('D');
                    nextLetter = (char)str.Dequeue();
                }
                else if (MoveLetters.CheckForSecChar(nextLetter, 'T'))
                {
                    str = str.AddAtFrontOfQueue('T');
                    nextLetter = (char)str.Dequeue();
                }

            }

            return nextLetter;
        }

        /// <summary>
        /// Register a Enter key if text box has input string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterEnter(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                dateTime = false;
                date = false;
                time = false;

                if (!string.IsNullOrEmpty(InputStringToDisplay.Text) ||
                    !string.IsNullOrWhiteSpace(InputStringToDisplay.Text))
                {
                    if (!countinious)
                    {
                        if (!WordInput && !MoveLetters.CheckForZero(Arr))
                        {
                            Clear();
                        }
                        else if (WordInput)
                        {
                            counter = 10;
                            Clear();

                        }

                    }

                    if (countinious && str.Count !=0)
                    {
                        var temp = InputStringToDisplay.Text.ToUpper().ToCharArray();
                        stringtoRepeat.Concat(InputStringToDisplay.Text.ToString());
                        foreach (var item in temp) 
                        {
                            str.Enqueue(item);
                        }

                        InputStringToDisplay.Text = "";
                        
                    }
                    else if (Repeat.IsChecked == true && !countinious)
                    {
                        stringtoRepeat = InputStringToDisplay.Text.ToUpper();
                        str = stringtoRepeat.ToQueue();
                        countToClearScreen = 0;
                    }
                    else if (Repeat.IsChecked == true && countinious)
                    {
                        stringtoRepeat = String.Concat(stringtoRepeat, InputStringToDisplay.Text.ToUpper());
                        str = stringtoRepeat.ToQueue();
                        countToClearScreen = 0;
                    }
                    else
                    {
                        str = InputStringToDisplay.Text.ToUpper().ToQueue();
                        stringtoRepeat = InputStringToDisplay.Text.ToUpper();
                    }
                    

                       
                        
                    
                    

                    
                     

                    InputStringToDisplay.Text = "";
                    WordInput = true; 
                }
            }
        }
        /// <summary>
        /// sends black color of button to text color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
            


        private void Repeat_Checked(object sender, RoutedEventArgs e)
        {
            
            str.Clear();
            stringtoRepeat = "";
            if (!MoveLetters.CheckForZero(Arr))
            {
                MoveLetters.SetIntArrToNum(Arr, 1);
            }
            counter = 10;
            /*MoveLetters.SetIntArrToNum(Arr, 0);*/


        }

        private void Repeat_Unchecked(object sender, RoutedEventArgs e)
        {
            InputStringToDisplay.MaxLength = 0;

        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            
            
                stringtoRepeat = "";
                str.Clear();
                MoveLetters.SetIntArrToNum(Arr, 1);
                counter = 10;
            


        }

        private void Clear() {

            stringtoRepeat = "";
            str.Clear();
            MoveLetters.SetIntArrToNum(Arr, 0);
        }

        private void ContinuousWordPPrint_Checked(object sender, RoutedEventArgs e)
        {
            countinious = true;
        }

        private void ContinuousWordPPrint_Unchecked(object sender, RoutedEventArgs e)
        {
            countinious = false;
        }

        private void ShadowColor_Click(object sender, RoutedEventArgs e)
        {
            SelectColorPanel.Visibility = Visibility.Visible;
            shadow = true;
            text = false;
        }

        private void TextColor_Click(object sender, RoutedEventArgs e)
        {

            SelectColorPanel.Visibility = Visibility.Visible;
            text = true;
            shadow = false;
        }

        private void SelectColor_Click(object sender, RoutedEventArgs e)
        {

            SelectColorPanel.Visibility = Visibility.Collapsed;
            shadow = false;
            text = false;
        }

        private void TimeButton_Click(object sender, RoutedEventArgs e)
        {
            dateTime = true;
            time = true;
            date = false;
        }

        private void NextPage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(FontEdit));
        }

        private void DateButton_Click(object sender, RoutedEventArgs e)
        {
            dateTime = true;
            date = true;
            time = false;
        }

        private void ColorSelecter_Copy_ColorChanged(ColorPicker sender, ColorChangedEventArgs args)
        {
            if (text)
            {
                var color = (ColorPicker)sender;
                ColorofLetters = new SolidColorBrush(color.Color); 
            }
            else if (shadow)
            {
                var color = (ColorPicker)sender;
                LetterBorrders = new SolidColorBrush(color.Color);
            }
            
        }


    }
}
