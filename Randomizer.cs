﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using System;
using System.Drawing;


namespace PentelescuClaudiu3132A
{
    class Randomizer
    {
        private Random myRandom;

        //private const int LOW_INT_VAL = -25;
        //private const int HIGH_INT_VAL = 25;
        //private const int LOW_COORD_VAL = -50;
        //private const int HIGH_COORD_VAL = 50;

        /// <summary>
        /// Standard constructor. Initialised with the system clock for seed.
        /// </summary>
        public Randomizer()
        {
            myRandom = new Random();
        }

        /// <summary>
        /// This method returns a random Color when requested.
        /// </summary>
        /// <returns>the Color, randomly generated!</returns>
        public Color RandomColor()
        {
            int genR = myRandom.Next(0, 255);
            int genG = myRandom.Next(0, 255);
            int genB = myRandom.Next(0, 255);

            Color col = Color.FromArgb(genR, genG, genB);

            return col;
        }

        /// <summary>
        /// This method returns a random 3D coordinate. Values are ranged (0-centered).
        /// </summary>
        /// <returns>the 3D point's coordinates, randomly generated!</returns>
        //public Vector3 Random3DPoint()
        //{
        //    int genA = myRandom.Next(LOW_COORD_VAL, HIGH_COORD_VAL);
        //    int genB = myRandom.Next(LOW_COORD_VAL, HIGH_COORD_VAL);
        //    int genC = myRandom.Next(LOW_COORD_VAL, HIGH_COORD_VAL);

        //    Vector3 vec = new Vector3(genA, genB, genC);

        //    return vec;
        //}

        /// <summary>
        /// This method returns a random int when required. The value is ranged between predefined values (symmetrical over zero).
        /// </summary>
        /// <returns>random int;</returns>
        //public int RandomInt()
        //{
        //    int i = myRandom.Next(LOW_INT_VAL, HIGH_INT_VAL);

        //    return i;
        //}
    }
}
