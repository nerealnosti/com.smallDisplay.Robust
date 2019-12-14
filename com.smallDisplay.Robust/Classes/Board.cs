using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using System.Windows;
using Windows.UI.Xaml.Shapes;
using Windows.UI;

namespace com.smallDisplay.Robust.Classes
{
    /// <summary>
    /// Create Grid or Rectangle and set event PointerExited to every Rect that change color when mouse leaves area of 
    /// rectangle
    /// </summary>
    class Board 
    {
        /// <summary>
        ///  Create Grid or Rectangle and set event PointerExited to every Rect that change color when mouse leaves area of 
        ///  rectangle
        /// </summary>
        /// <param name="rects"></param>
        /// <param name="mainGrid"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="colorOfLabels"></param>
        /// <param name="colorOfBorder"></param>
        /// <param name="labSize"></param>
        public Board(Rectangle[,] rects, Grid mainGrid, int row, int col, Brush colorOfLabels, Brush colorOfBorder,
              int labSize)
        {





            for (int i = 0; i < row; i++)
            {
                mainGrid.ColumnDefinitions.Add(new ColumnDefinition());
                mainGrid.ColumnDefinitions[i].Width = new GridLength(labSize);

                for (int j = 0; j < col; j++)
                {
                    mainGrid.RowDefinitions.Add(new RowDefinition());
                    mainGrid.RowDefinitions[j].Height = new GridLength(labSize);
                }
            }


            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {

                    rects[i, j] = new Rectangle
                    {
                        Height = labSize,
                        Width = labSize,
                        Fill = colorOfLabels,
                        Stroke = colorOfBorder,
                        StrokeThickness = 1
                    };

                    rects[i, j].PointerPressed += Board_PointerPressed; ;
                    Grid.SetRow(rects[i, j], j);
                    Grid.SetColumn(rects[i, j], i);
                    mainGrid.Children.Add(rects[i, j]);
                }



            }


        }

        

        private void Board_PointerPressed(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            var temp = (Rectangle)sender;
            Color red = Colors.Red;
            Color black = Colors.Black;
            var B = new SolidColorBrush(black);
            var C = new SolidColorBrush(red);
            SolidColorBrush CurrColor = (SolidColorBrush)temp.Fill;

            if (CurrColor.Color == C.Color)
            {
                temp.Fill = new SolidColorBrush(black);
            }
            else if (CurrColor.Color == B.Color)
            {
                temp.Fill = new SolidColorBrush(red);
            }
        }

            
        

        

       
    }
}
