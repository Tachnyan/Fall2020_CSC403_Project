﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code
{
    public static class Util
    {

        public static Random rand = new Random();
        public static  int GetRandomInt()
        {
            return rand.Next(-1, 2);
        }

        public static float GetRandomFloat()
        {
            return (float)rand.NextDouble();
        }

    }
}
