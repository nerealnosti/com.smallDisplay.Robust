﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.smallDisplay.Robust.Classes
{
    class Letters
    {

        internal static int[,] A = new int[,] { { 0,0,0,1,1,1,2,0,0 },                      
                                                { 0,0,1,1,1,1,1,2,0 },                      
                                                { 0,1,1,1,1,1,1,1,2 },                      
                                                { 0,1,1,2,0,0,1,1,2 },                      
                                                { 0,1,1,2,0,0,1,1,2 },                      
                                                { 0,1,1,1,1,1,1,1,2 },                      
                                                { 0,1,1,2,0,0,1,1,2 },                      
                                                { 0,1,1,2,0,0,1,1,2 },                      
                                                { 0,1,1,2,0,0,1,1,2 } };

        internal static int[,] B = new int[,] { { 0,1,1,1,1,1,2,0,0 },
                                                { 0,1,1,1,1,1,1,2,0 },
                                                { 0,1,1,2,0,0,1,2,0 },
                                                { 0,1,1,1,1,1,1,2,0 },
                                                { 0,1,1,1,1,1,1,1,2 },
                                                { 0,1,1,2,0,0,1,1,2 },
                                                { 0,1,1,2,0,0,1,1,2 },
                                                { 0,1,1,1,1,1,1,1,2 },
                                                { 0,1,1,1,1,1,1,2,0 } };

        internal static int[,] C = new int[,] { { 0,0,1,1,1,1,1,2,0 },
                                                { 0,1,1,1,1,1,1,1,2 },
                                                { 0,1,1,2,0,0,1,1,2 },
                                                { 0,1,1,2,0,0,0,0,0 },
                                                { 0,1,1,2,0,0,0,0,0 },
                                                { 0,1,1,2,0,0,0,0,0 },
                                                { 0,1,1,2,0,0,1,1,2 },
                                                { 0,1,1,1,1,1,1,1,2 },
                                                { 0,0,1,1,1,1,1,2,0 } };

        internal static int[,] D = new int[,] { { 0,1,1,1,1,1,1,2,0 },
                                                { 0,1,1,1,1,1,1,1,2 },
                                                { 0,1,1,1,2,0,1,1,2 },
                                                { 0,1,1,1,2,0,1,1,2 },
                                                { 0,1,1,1,2,0,1,1,2 },
                                                { 0,1,1,1,2,0,1,1,2 },
                                                { 0,1,1,1,2,0,1,1,2 },
                                                { 0,1,1,1,1,1,1,1,2 },
                                                { 0,1,1,1,1,1,1,2,0 } };

        internal static int[,] E = new int[,]{  { 0,1,1,1,1,1,1,1,2 },
                                                { 0,1,1,1,1,1,1,1,2 },
                                                { 0,1,1,1,2,0,0,0,0 },
                                                { 0,1,1,1,1,1,1,2,0 },
                                                { 0,1,1,1,1,1,1,2,0 },
                                                { 0,1,1,1,1,1,1,2,0 },
                                                { 0,1,1,1,2,0,0,0,0 },
                                                { 0,1,1,1,1,1,1,1,2 },
                                                { 0,1,1,1,1,1,1,1,2 } };

        internal static int[,] F = new int[,] { { 0,1,1,1,1,1,1,1,2 },
                                                { 0,1,1,1,1,1,1,1,2 },
                                                { 0,1,1,2,0,0,0,0,0 },
                                                { 0,1,1,1,1,1,1,2,0 },
                                                { 0,1,1,1,1,1,1,2,0 },
                                                { 0,1,1,2,0,0,0,0,0 },
                                                { 0,1,1,2,0,0,0,0,0 },
                                                { 0,1,1,2,0,0,0,0,0 },
                                                { 0,1,1,2,0,0,0,0,0 } };

        internal static int[,] G = new int[,] { { 0,0,1,1,1,1,1,2,0 },
                                                { 0,1,1,1,1,1,1,1,2 },
                                                { 0,1,1,2,0,0,1,1,2 },
                                                { 0,1,1,2,0,0,0,0,0 },
                                                { 0,1,1,2,0,1,1,1,2 },
                                                { 0,1,1,2,0,1,1,1,2 },
                                                { 0,1,1,2,0,0,1,1,2 },
                                                { 0,1,1,1,1,1,1,1,2 },
                                                { 0,0,1,1,1,1,1,2,0 } };

        internal static int[,] H = new int[,] { { 0,1,1,1,2,0,1,1,2 },
                                                { 0,1,1,1,2,0,1,1,2 },
                                                { 0,1,1,1,2,0,1,1,2 },
                                                { 0,1,1,1,1,1,1,1,2 },
                                                { 0,1,1,1,1,1,1,1,2 },
                                                { 0,1,1,1,2,0,1,1,2 },
                                                { 0,1,1,1,2,0,1,1,2 },
                                                { 0,1,1,1,2,0,1,1,2 },
                                                { 0,1,1,1,2,0,1,1,2 } };

        internal static int[,] I = new int[,] { { 0,1,1,1,1,2,0,0,0},
                                                { 0,1,1,1,1,2,0,0,0},
                                                { 0,0,1,1,2,0,0,0,0},
                                                { 0,0,1,1,2,0,0,0,0},
                                                { 0,0,1,1,2,0,0,0,0},
                                                { 0,0,1,1,2,0,0,0,0},
                                                { 0,0,1,1,2,0,0,0,0},
                                                { 0,1,1,1,1,2,0,0,0},
                                                { 0,1,1,1,1,2,0,0,0} };

        internal static int[,] J = new int[,] { { 0,0,1,1,1,1,1,1,2 },
                                                { 0,0,1,1,1,1,1,1,2 },
                                                { 0,0,0,0,1,1,1,2,0 },
                                                { 0,0,0,0,1,1,1,2,0 },
                                                { 0,0,0,0,1,1,1,2,0 },
                                                { 0,1,2,0,1,1,1,2,0 },
                                                { 0,1,2,0,1,1,1,2,0 },
                                                { 0,1,1,1,1,1,1,2,0 },
                                                { 0,0,1,1,1,1,2,0,0 } };

        internal static int[,] K = new int[,] { { 0,1,1,1,2,0,1,1,2 },
                                                { 0,1,1,1,2,1,1,1,2 },
                                                { 0,1,1,1,2,1,1,2,0 },
                                                { 0,1,1,1,1,1,1,2,0 },
                                                { 0,1,1,1,1,1,2,0,0 },
                                                { 0,1,1,1,1,1,2,0,0 },
                                                { 0,1,1,1,1,1,1,2,0 },
                                                { 0,1,1,1,2,1,1,1,2 },
                                                { 0,1,1,1,2,0,1,1,2 } };

        internal static int[,] L = new int[,] { { 0,1,1,1,1,2,0,0,0 },
                                                { 0,1,1,1,1,2,0,0,0 },
                                                { 0,0,1,1,1,2,0,0,0 },
                                                { 0,0,1,1,1,2,0,0,0 },
                                                { 0,0,1,1,1,2,0,0,0 },
                                                { 0,0,1,1,1,2,0,0,0 },
                                                { 0,0,1,1,1,2,0,1,2 },
                                                { 0,1,1,1,1,1,1,1,2 },
                                                { 0,1,1,1,1,1,1,1,2 } };

        internal static int[,] M = new int[,] { { 0,1,1,2,0,0,1,1,2 },
                                                { 0,1,1,1,2,1,1,1,2 },
                                                { 0,1,1,1,1,1,1,1,2 },
                                                { 0,1,1,1,1,1,1,1,2 },
                                                { 0,1,1,1,1,1,1,1,2 },
                                                { 0,1,1,2,1,2,1,1,2 },
                                                { 0,1,1,2,0,0,1,1,2 },
                                                { 0,1,1,2,0,0,1,1,2 },
                                                { 0,1,1,2,0,0,1,1,2 } };

        internal static int[,] N = new int[,] { { 0,1,1,2,0,0,1,1,2 },
                                                { 0,1,1,1,2,0,1,1,2 },
                                                { 0,1,1,1,1,2,1,1,2 },
                                                { 0,1,1,1,1,1,1,1,2 },
                                                { 0,1,1,1,1,1,1,1,2 },
                                                { 0,1,1,2,1,1,1,1,2 },
                                                { 0,1,1,2,0,1,1,1,2 },
                                                { 0,1,1,2,0,0,1,1,2 },
                                                { 0,1,1,2,0,0,1,1,2 } };

        internal static int[,] O = new int[,] { { 0,0,1,1,1,1,1,2,0 },
                                                { 0,1,1,1,1,1,1,1,2 },
                                                { 0,1,1,1,2,0,1,1,2 },
                                                { 0,1,1,1,2,0,1,1,2 },
                                                { 0,1,1,1,2,0,1,1,2 },
                                                { 0,1,1,1,2,0,1,1,2 },
                                                { 0,1,1,1,2,0,1,1,2 },
                                                { 0,1,1,1,1,1,1,1,2 },
                                                { 0,0,1,1,1,1,1,2,0 } };

        internal static int[,] P = new int[,] { { 0,1,1,1,1,1,2,0,0 },
                                                { 0,1,1,1,1,1,1,1,2 },
                                                { 0,1,1,1,2,0,1,1,2 },
                                                { 0,1,1,1,2,0,1,1,2 },
                                                { 0,1,1,1,1,1,1,1,2 },
                                                { 0,1,1,1,1,1,2,0,0 },
                                                { 0,1,1,2,0,0,0,0,0 },
                                                { 0,1,1,2,0,0,0,0,0 },
                                                { 0,1,1,2,0,0,0,0,0 } };

        internal static int[,] Q = new int[,] { { 0,0,1,1,1,1,1,2,0 },
                                                { 0,1,1,1,1,1,1,1,2 },
                                                { 0,1,1,2,0,0,1,1,2 },
                                                { 0,1,1,2,0,0,1,1,2 },
                                                { 0,1,1,2,0,0,1,1,2 },
                                                { 0,1,1,2,0,0,1,1,2 },
                                                { 0,1,1,2,0,1,1,2,0 },
                                                { 0,0,1,1,1,1,1,1,2 },
                                                { 0,0,0,0,1,1,1,1,2 } };

        internal static int[,] R = new int[,] { { 0,1,1,1,1,1,2,0,0},
                                                { 0,1,1,1,1,1,1,2,0},
                                                { 0,1,1,2,0,1,1,2,0},
                                                { 0,1,1,2,0,1,1,2,0},
                                                { 0,1,1,1,1,1,1,2,0},
                                                { 0,1,1,1,1,1,2,0,0},
                                                { 0,1,1,2,0,1,1,2,0},
                                                { 0,1,1,2,0,1,1,2,0},
                                                { 0,1,1,2,0,1,1,2,0} };

        internal static int[,] S = new int[,] { { 0,0,1,1,1,1,1,1,2 },
                                                { 0,1,1,1,1,1,1,1,2 },
                                                { 0,1,1,1,1,1,1,1,2 },
                                                { 0,1,1,2,0,0,0,0,0 },
                                                { 0,1,1,1,1,1,1,2,0 },
                                                { 0,0,1,1,1,1,1,1,2 },
                                                { 0,0,0,0,0,1,1,1,2 },
                                                { 0,1,1,1,1,1,1,1,2 },
                                                { 0,1,1,1,1,1,1,2,0 } };

        internal static int[,] T = new int[,] { { 0,1,1,1,1,1,1,1,2 },
                                                { 0,1,1,1,1,1,1,1,2 },
                                                { 0,0,0,1,1,1,2,0,0 },
                                                { 0,0,0,1,1,1,2,0,0 },
                                                { 0,0,0,1,1,1,2,0,0 },
                                                { 0,0,0,1,1,1,2,0,0 },
                                                { 0,0,0,1,1,1,2,0,0 },
                                                { 0,0,0,1,1,1,2,0,0 },
                                                { 0,0,1,1,1,1,1,2,0 } };

        internal static int[,] U = new int[,] { { 0,1,1,1,2,0,1,1,2 },
                                                { 0,1,1,1,2,0,1,1,2 },
                                                { 0,1,1,1,2,0,1,1,2 },
                                                { 0,1,1,1,2,0,1,1,2 },
                                                { 0,1,1,1,2,0,1,1,2 },
                                                { 0,1,1,1,2,0,1,1,2 },
                                                { 0,1,1,1,2,0,1,1,2 },
                                                { 0,1,1,1,1,1,1,1,2 },
                                                { 0,0,1,1,1,1,1,2,0 } };

        internal static int[,] V = new int[,] { { 0,1,1,2,0,0,1,1,2 },
                                                { 0,1,1,2,0,0,1,1,2 },
                                                { 0,1,1,2,0,0,1,1,2 },
                                                { 0,1,1,2,0,0,1,1,2 },
                                                { 0,1,1,2,0,0,1,1,2 },
                                                { 0,1,1,1,2,1,1,1,2 },
                                                { 0,0,1,1,1,1,1,1,2 },
                                                { 0,0,0,1,1,1,2,0,0 },
                                                { 0,0,0,1,1,1,2,0,0 } };

        internal static int[,] W = new int[,] { { 0,1,1,2,0,0,1,1,2 },
                                                { 0,1,1,2,0,0,1,1,2 },
                                                { 0,1,1,2,0,0,1,1,2 },
                                                { 0,1,1,2,0,0,1,1,2 },
                                                { 0,1,1,2,0,0,1,1,2 },
                                                { 0,1,1,2,1,2,1,1,2 },
                                                { 0,1,1,2,1,2,1,1,2 },
                                                { 0,1,1,1,1,1,1,1,2 },
                                                { 0,0,1,2,0,0,1,2,0 } };

        internal static int[,] X = new int[,] { { 0,1,1,2,0,0,1,1,2 },
                                                { 0,1,1,2,0,0,1,1,2 },
                                                { 0,0,1,1,2,1,1,2,0 },
                                                { 0,0,0,1,1,1,2,0,0 },
                                                { 0,0,0,1,1,1,2,0,0 },
                                                { 0,0,0,1,1,1,2,0,0 },
                                                { 0,0,1,1,1,1,1,2,0 },
                                                { 0,1,1,2,0,0,1,1,2 },
                                                { 0,1,1,2,0,0,1,1,2 } };

        internal static int[,] Y = new int[,] { { 0,1,1,1,2,0,1,1,2 },
                                                { 0,1,1,1,2,0,1,1,2 },
                                                { 0,1,1,1,2,0,1,1,2 },
                                                { 0,1,1,1,2,0,1,1,2 },
                                                { 0,1,1,1,2,0,1,1,2 },
                                                { 0,0,1,1,1,1,1,0,0 },
                                                { 0,0,0,1,1,1,2,0,0 },
                                                { 0,0,0,1,1,1,2,0,0 },
                                                { 0,0,0,1,1,1,2,0,0 } };

        internal static int[,] Z = new int[,] { { 0,1,1,1,1,1,1,1,2 },
                                                { 0,1,1,1,1,1,1,1,2 },
                                                { 0,0,0,0,0,1,1,1,2 },
                                                { 0,0,0,0,1,1,1,2,0 },
                                                { 0,0,0,1,1,1,2,0,0 },
                                                { 0,0,1,1,1,2,0,0,0 },
                                                { 0,1,1,1,2,0,0,0,0 },
                                                { 0,1,1,1,1,1,1,1,2 },
                                                { 0,1,1,1,1,1,1,1,2 } };



        internal static int[,] DOT = new int[,]{   { 0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0},
                                                   { 0,0,0,0,0,0,0,0,0},
                                                   { 0,0,0,0,0,0,0,0,0},
                                                   { 0,0,0,0,0,0,0,0,0},
                                                   { 0,0,0,0,0,0,0,0,0},
                                                   { 0,0,0,0,0,0,0,0,0},
                                                   { 1,1,2,0,0,0,0,0,0},
                                                   { 1,1,2,0,0,0,0,0,0} };

        internal static int[,] POINT = new int[,]{ { 0,0,0,0,0,0,0,0,0},
                                                   { 0,0,0,0,0,0,0,0,0},
                                                   { 0,0,0,0,0,0,0,0,0},
                                                   { 0,0,0,0,0,0,0,0,0},
                                                   { 0,0,0,0,0,0,0,0,0},
                                                   { 0,0,0,0,0,0,0,0,0},
                                                   { 1,1,2,0,0,0,0,0,0},
                                                   { 1,1,2,0,0,0,0,0,0},
                                                   { 0,1,2,0,0,0,0,0,0} };


        internal static int[,] DANGER = new int[,]{ { 0,1,1,2,0,0,0,0,0 },
                                                    { 0,1,1,2,0,0,0,0,0 },
                                                    { 0,1,1,2,0,0,0,0,0 },
                                                    { 0,1,1,2,0,0,0,0,0 },
                                                    { 0,1,1,2,0,0,0,0,0 },
                                                    { 0,1,1,2,0,0,0,0,0 },
                                                    { 0,0,0,0,0,0,0,0,0 },
                                                    { 0,1,1,2,0,0,0,0,0 },
                                                    { 0,1,1,2,0,0,0,0,0 } };

        internal static int[,] QUESTIONMARK = new int[,] { { 0,0,1,1,1,1,1,2,0 },
                                                           { 0,1,1,1,1,1,1,1,2 },
                                                           { 0,1,0,0,0,0,1,1,2 },
                                                           { 0,0,0,0,1,1,1,1,2 },
                                                           { 0,0,0,0,1,1,1,2,0 },
                                                           { 0,0,0,1,1,1,2,0,0 },
                                                           { 0,0,0,0,0,0,0,0,0 },
                                                           { 0,0,0,1,1,2,0,0,0 },
                                                           { 0,0,0,1,1,2,0,0,0 } };

        internal static int[,] Space = new int[,]{ { 0,0,0,0,0,0,0,0,0},
                                                   { 0,0,0,0,0,0,0,0,0},
                                                   { 0,0,0,0,0,0,0,0,0},
                                                   { 0,0,0,0,0,0,0,0,0},
                                                   { 0,0,0,0,0,0,0,0,0},
                                                   { 0,0,0,0,0,0,0,0,0},
                                                   { 0,0,0,0,0,0,0,0,0},
                                                   { 0,0,0,0,0,0,0,0,0},
                                                   { 0,0,0,0,0,0,0,0,0} };


        internal static int[,] ONE = new int[,] { { 0,0,0,0,0,1,1,1,2 },
                                                  { 0,0,0,0,1,1,1,1,2 },
                                                  { 0,0,0,1,1,1,1,1,2 },
                                                  { 0,0,0,1,1,1,1,1,2 },
                                                  { 0,0,0,0,0,1,1,1,2 },
                                                  { 0,0,0,0,0,1,1,1,2 },
                                                  { 0,0,0,0,0,1,1,1,2 },
                                                  { 0,0,0,0,0,1,1,1,2 },
                                                  { 0,0,0,0,0,1,1,1,2 } };

        internal static int[,] TWO = new int[,] { { 0,0,1,1,1,1,1,2,0 },
                                                  { 0,1,1,1,1,1,1,1,2 },
                                                  { 0,0,0,0,0,1,1,1,2 },
                                                  { 0,0,0,0,1,1,1,2,0 },
                                                  { 0,0,0,1,1,1,2,0,0 },
                                                  { 0,0,1,1,1,2,0,0,0 },
                                                  { 0,1,1,1,2,0,0,0,0 },
                                                  { 0,1,1,1,1,1,1,1,2 },
                                                  { 0,1,1,1,1,1,1,1,2 } };

        internal static int[,] TREE = new int[,] { { 0,1,1,1,1,1,1,2,0 },
                                                   { 0,1,1,1,1,1,1,1,2 },
                                                   { 0,0,0,0,0,1,1,1,2 },
                                                   { 0,0,0,0,1,1,1,2,0 },
                                                   { 0,0,0,0,1,1,1,2,0 },
                                                   { 0,0,0,0,0,1,1,2,0 },
                                                   { 0,0,0,0,0,1,1,1,2 },
                                                   { 0,1,1,1,1,1,1,1,2 },
                                                   { 0,1,1,1,1,1,1,2,0 } };

        internal static int[,] FOUR = new int[,] { { 0,0,0,0,1,1,1,2,0 },
                                                   { 0,0,0,1,1,1,2,0,0 },
                                                   { 0,0,1,1,1,2,0,0,0 },
                                                   { 0,1,1,1,2,0,1,1,2 },
                                                   { 0,1,1,1,1,1,1,1,2 },
                                                   { 0,1,1,1,1,1,1,2,0 },
                                                   { 0,0,0,0,0,1,1,2,0 },
                                                   { 0,0,0,0,0,1,1,2,0 },
                                                   { 0,0,0,0,0,1,1,2,0 } };

        internal static int[,] FIVE = new int[,] { { 0,1,1,1,1,1,1,1,2 },
                                                   { 0,1,1,1,1,1,1,1,2 },
                                                   { 0,1,1,2,0,0,0,0,0 },
                                                   { 0,1,1,2,0,0,0,0,0 },
                                                   { 0,1,1,1,1,1,1,2,0 },
                                                   { 0,1,1,1,1,1,1,1,2 },
                                                   { 0,0,0,0,0,1,1,1,2 },
                                                   { 0,1,1,1,1,1,1,1,2 },
                                                   { 0,1,1,1,1,1,1,2,0 } };

        internal static int[,] SIX = new int[,] { { 0,0,1,1,1,1,1,2,0 },
                                                  { 0,1,1,1,1,1,1,2,0 },
                                                  { 0,1,1,2,0,0,0,0,0 },
                                                  { 0,1,1,1,1,1,2,0,0 },
                                                  { 0,1,1,1,1,1,1,2,0 },
                                                  { 0,1,1,1,1,1,1,1,2 },
                                                  { 0,1,1,1,0,0,1,1,2 },
                                                  { 0,1,1,1,1,1,1,1,2 },
                                                  { 0,0,1,1,1,1,1,2,0 } };

        internal static int[,] SEVEN = new int[,]{ { 0,1,1,1,1,1,1,1,2 },
                                                   { 0,1,1,1,1,1,1,1,2 },
                                                   { 0,0,0,0,0,1,1,1,2 },
                                                   { 0,0,0,0,0,1,1,1,2 },
                                                   { 0,0,0,0,1,1,1,2,0 },
                                                   { 0,0,0,0,1,1,2,0,0 },
                                                   { 0,0,0,1,1,1,2,0,0 },
                                                   { 0,0,1,1,1,2,0,0,0 },
                                                   { 0,0,1,1,1,2,0,0,0 } };

        internal static int[,] EIGHT = new int[,] { { 0,0,1,1,1,1,1,2,0 },
                                                    { 0,1,1,1,1,1,1,1,2 },
                                                    { 0,1,1,2,0,0,1,1,2 },
                                                    { 0,1,1,2,0,0,1,1,2 },
                                                    { 0,0,1,1,1,1,1,2,0 },
                                                    { 0,1,1,2,0,0,1,1,2 },
                                                    { 0,1,1,2,0,0,1,1,2 },
                                                    { 0,1,1,1,1,1,1,1,2 },
                                                    { 0,0,1,1,1,1,1,2,0 } };

        internal static int[,] NINE = new int[,] { { 0,0,1,1,1,1,1,2,0 },
                                                   { 0,1,1,1,1,1,1,1,2 },
                                                   { 0,1,1,2,0,0,1,1,2 },
                                                   { 0,1,1,2,0,0,1,1,2 },
                                                   { 0,0,1,1,1,1,1,1,2 },
                                                   { 0,0,0,0,0,0,1,1,2 },
                                                   { 0,0,0,0,0,0,1,1,2 },
                                                   { 0,0,1,1,1,1,1,1,2 },
                                                   { 0,0,1,1,1,1,1,2,0 } };

        internal static int[,] ZERO = new int[,] { { 0,0,1,1,1,1,1,2,0 },
                                                   { 0,1,1,1,1,1,1,1,2 },
                                                   { 0,1,1,2,0,0,1,1,2 },
                                                   { 0,1,1,2,1,1,1,1,2 },
                                                   { 0,1,1,1,1,2,1,1,2 },
                                                   { 0,1,1,1,2,0,1,1,2 },
                                                   { 0,1,1,2,0,0,1,1,2 },
                                                   { 0,1,1,1,1,1,1,1,2 },
                                                   { 0,0,1,1,1,1,1,2,0 } };









        internal static int[,] TwoDot = new int[,] { { 0,0,0,0,0,0,0,0,0 },
                                                     { 0,0,0,0,0,0,0,0,0 },
                                                     { 0,0,0,0,0,0,0,0,0 },
                                                     { 0,0,0,1,1,2,0,0,0 },
                                                     { 0,0,0,1,1,2,0,0,0 },
                                                     { 0,0,0,0,0,0,0,0,0 },
                                                     { 0,0,0,1,1,2,0,0,0 },
                                                     { 0,0,0,1,1,2,0,0,0 },
                                                     { 0,0,0,0,0,0,0,0,0 } };

        internal static int[,] Dash = new int[,] {   { 0,0,0,0,0,0,0,0,0 },
                                                     { 0,0,0,0,0,0,0,0,0 },
                                                     { 0,0,0,0,0,0,0,0,0 },
                                                     { 0,0,1,1,1,1,1,2,0 },
                                                     { 0,0,1,1,1,1,1,2,0 },
                                                     { 0,0,0,0,0,0,0,0,0 },
                                                     { 0,0,0,0,0,0,0,0,0 },
                                                     { 0,0,0,0,0,0,0,0,0 },
                                                     { 0,0,0,0,0,0,0,0,0 } };

        /// <summary>
        /// Return int Arr based on char input
        /// </summary>
        /// <param name="letter"></param>
        /// <returns></returns>
        internal static  int[,] ReturnArrLetter(char letter)
        {
            switch (letter)
            {
                case 'A':
                    return A;
                case 'B':
                    return B;
                case 'C':
                    return C;
                case 'D':
                    return D;
                case 'E':
                    return E;
                case 'F':
                    return F;
                case 'G':
                    return G;
                case 'H':
                    return H;
                case 'I':
                    return I;
                case 'J':
                    return J;
                case 'K':
                    return K;
                case 'L':
                    return L;
                case 'M':
                    return M;
                case 'N':
                    return N;
                case 'O':
                    return O;
                case 'P':
                    return P;
                case 'Q':
                    return Q;
                case 'R':
                    return R;
                case 'S':
                    return S;
                case 'T':
                    return T;
                case 'U':
                    return U;
                case 'V':
                    return V;
                case 'W':
                    return W;
                case 'X':
                    return X;
                case 'Y':
                    return Y;
                case 'Z':
                    return Z;
                case ' ':
                    return Space;
                case '.':
                    return DOT;
                case ',':
                    return POINT;
                case '!':
                    return DANGER;
                case '?':
                    return QUESTIONMARK;
                
                case '1':
                    return ONE;
                case '2':
                    return TWO;
                case '3':
                    return TREE;
                case '4':
                    return FOUR;
                case '5':
                    return FIVE;
                case '6':
                    return SIX;
                case '7':
                    return SEVEN;
                case '8':
                    return EIGHT;
                case '9':
                    return NINE;
                case '0':
                    return ZERO;
                case ':':
                    return TwoDot;
                case '-':
                    return Dash;
                default:
                    return Space;

            }
        }

    }
}
