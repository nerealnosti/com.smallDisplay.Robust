using com.smallDisplay.Robust.Classes;
using System;
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


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace com.smallDisplay.Robust
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FontEdit : Page
    {
        private char inputLetter;
        DispatcherTimer FontEditTimer = new DispatcherTimer();
        int [,] lettArr;
        private bool inputRecived;

        private readonly static Color solidBorderBlacks = Colors.CornflowerBlue;
        private static readonly SolidColorBrush solidBorderBlack = new SolidColorBrush(solidBorderBlacks);

        private readonly static Color solidBlacks = Colors.Black;
        private readonly static SolidColorBrush solidBlack = new SolidColorBrush(solidBlacks);

        int sizeOfRect = 50;
        Rectangle[,] rectangle;
        

        public FontEdit()
        {
            this.InitializeComponent();
            FontEditTimer.Interval = TimeSpan.FromMilliseconds(300);
            FontEditTimer.Tick += FontEditTimer_Tick;
            FontEditTimer.Start();
        }

        private void FontEditTimer_Tick(object sender, object e)
        {
            if (inputRecived)
            {
                
                rectangle = new Rectangle[lettArr.GetLength(0), lettArr.GetLength(1)];
                _ = new Board(rectangle, LetterArrayGrid, lettArr.GetLength(1), lettArr.GetLength(0), solidBlack, solidBorderBlack, sizeOfRect);
                inputRecived = false;
                insertExistedLetter(lettArr, this.rectangle);
            }
        }

        private void RegisterEnterFontEdit(object sender, KeyRoutedEventArgs e)
        {
            
            if (!string.IsNullOrEmpty(inputTextbox.Text) &&
                e.Key == Windows.System.VirtualKey.Enter)
            {
                inputLetter = char.Parse(inputTextbox.Text);
                inputTextbox.Text = "";
                inputRecived = true;
            }

            lettArr =  Letters.ReturnArrLetter(inputLetter);
            
        }

        private void insertExistedLetter(int[,] ArrLett,Rectangle[,] rect)
        {
            Color red = Colors.Red;
            Color black = Colors.Black;
            
                for (int i = 0; i < ArrLett.GetLength(1); i++)
                {
                    for (int j = 0; j < ArrLett.GetLength(0); j++)
                    {
                        if (ArrLett[i, j] == 1)
                        {
                            rect[j, i].Fill = new SolidColorBrush(red);
                        }
                    }
                } 
            
            
        }

        
    }
}
