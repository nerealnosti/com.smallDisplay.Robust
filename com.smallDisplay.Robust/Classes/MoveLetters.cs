using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace com.smallDisplay.Robust.Classes
{

    /// <summary>
    /// Class that moves text on display
    /// </summary>
    static class MoveLetters
    {


        /// <summary>
        /// Set all int arr values to zero
        /// </summary>
        /// <param name="arr"></param>
        public static void SetIntArrToNum(int[,] arr,int num)
        {

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = num;
                }
            }
        }

        /// <summary>
        /// Check if all num in int arr are zero
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool CheckForZero(int[,] arr)
        {

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] != 0) return false;
                    
                }
            }

            return true;
        }

        /// <summary>
        /// Paint rect if int Array have other number then 0 on same place
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="rect"></param>
        /// <param name="ocupied"></param>
        /// <param name="empty"></param>
        public static void ColorOcupiedLabels(int[,] arr, Rectangle[,] rect, SolidColorBrush ocupied, SolidColorBrush empty,SolidColorBrush border)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == 1)
                    {
                        rect[i, j].Fill = ocupied;

                    }
                    else if (arr[i, j] == 2)
                    {
                        rect[i, j].Fill = border;
                    }
                    else
                    {
                        rect[i, j].Fill = empty;
                    }
                }
            }
        }

        /// <summary>
        /// Move int Array Col one row up and set firstline to 0 that can be ready recive next line
        /// <param name="arr"></param>
        /// <param name="Rows"></param>
        /// <param name="Cols"></param>
        /// <param name="EmpClr"></param>
        /// <param name="OcupClr"></param>

        internal static void MoveDisplayUp(int[,] arr, int Rows, int Cols, SolidColorBrush EmpClr, SolidColorBrush OcupClr)
        
        {

            for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= arr.GetLength(1) - 1; j++)
                {
                    if (arr[i + 1, j] == 0)
                    {
                        arr[i, j] = 0;
                    }
                    else if (arr[i + 1, j] == 2)
                    {
                        arr[i, j] = 2;

                    }
                    else
                    {
                        arr[i, j] = 1;

                    }
                }
            }


            for (int i = 0; i < arr.GetLength(1); i++)
            {
                arr[arr.GetLength(0) - 1, i] = 0;
            }
        }

        /// <summary>
        /// insert one line of letter array in first line of int array
        /// </summary>
        /// <param name="MainArr"></param>
        /// <param name="LetterArr"></param>
        /// <param name="lineCounter"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        internal static void InsertLine(int[,] MainArr, int [,] LetterArr, ref short lineCounter,ref bool charPrinted)
        {
            if (lineCounter < LetterArr.GetLength(1))
            {
                // centrira slovo u main Arr
                // ukupna duzina minus slovo /2 je pocetni rectangle 
                int v = (MainArr.GetLength(1) - LetterArr.GetLength(0)) / 2;
                for (int i = 0; i < LetterArr.GetLength(0); i++)
                {
                    if (LetterArr[i, lineCounter] == 1)
                    {
                        MainArr[MainArr.GetLength(0) - 1, i + v] = 1;
                    }
                    else if (LetterArr[i, lineCounter] == 2)
                    {
                        MainArr[MainArr.GetLength(0) - 1, i + v] = 2;

                    }
                }

                lineCounter++;
            }
            else
            {
                lineCounter = 0;
                charPrinted = true;
            }

        }


        internal static  bool CheckForSecChar(char specChar, char equalityCheckChar)
        {

            return specChar == equalityCheckChar ? true : false;

        }

        internal static void CheckForSecCharNext(char specChar,ref bool date,ref bool time)
        {

            if (specChar == 'D')
            {
                date = true;
                time = false;
            }
            else if (specChar == 'T')
            {
                date = false;
                time = true;
            }

        }

        internal static void InsertTextToMiddle(int [,] Arr,int row, int col,bool Time, bool Date, string str,bool trueORfalse)
        {
            if (trueORfalse)
            {
                SetIntArrToNum(Arr, 0); 
            }
            string time = "";
            string date = "";

            Queue TimeOrDate = new Queue();
            int t = 0;
            if (Time)
            {
                time = DateTime.Now.ToString("HH:mm:ss");
                TimeOrDate = time.ToQueue();
                t = TimeOrDate.Count;
            }else if (Date)
            {
                date = DateTime.Now.ToString("dd-MMM-yy").ToUpper();
                TimeOrDate = date.ToQueue();
                t = TimeOrDate.Count;
            }
            else
            {
                TimeOrDate = str.ToUpper().ToQueue();
                t = TimeOrDate.Count;
            }

            


            int n = 0;
            // mozda metod koji ce brojati koliko redova slova ukuono imaju
            var sirina = ((row - t * 9) / 2)-1;
            var visina = (col - 9) / 2;


            for (int i = 0; i < t; i++)
            {

                var letter = (char) TimeOrDate.Dequeue();
                var ArrLetter = Letters.ReturnArrLetter(letter);
                

                for (int j = 0; j < ArrLetter.GetLength(0); j++)
                {
                    for (int k = 0; k < ArrLetter.GetLength(1); k++)
                    {
                        if (ArrLetter[k,j] == 1)
                        {
                            Arr[j+n+sirina, k + visina] = 1;
                        }
                        else if (ArrLetter[k, j] == 2)
                        {
                            Arr[j + n + sirina, k + visina] = 2;
                        }

                        
                    }

                   
                }

                n += ArrLetter.GetLength(0);

            }
        }

        /// <summary>
        ///  extension method that return char array from string to queue list 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static Queue ToQueue(this string str)
        {
            return new Queue (str.ToCharArray());
        }

        public static Queue AddAtFrontOfQueue(this Queue que,char td)
        {

            Queue ques = new Queue();
            ques = (Queue) que.Clone();
            que.Clear();
            string str = "";
                
            if (td == 'D')
            {
                 str = DateTime.Now.ToString("\tdd-MMM-yyyy\t").ToUpper();

            }
            else if (td == 'T')
            {
                str = DateTime.Now.ToString("\t HH:mm\t");
            }
            
            
            que = str.ToQueue();
            foreach (var item in ques)
            {
                que.Enqueue((char)item);
            }

            return que;
        }


    }
}
