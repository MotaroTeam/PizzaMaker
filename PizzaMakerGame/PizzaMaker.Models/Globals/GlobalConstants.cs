﻿namespace PizzaMaker.Models.Globals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GlobalConstants
    {
        // All constant values are represented in grams/ml PER SERVING!
        public const int VEGETABLES_QUANTITY = 60;   

        public const int MEAT_QUANTITY = 40;

        public const int SPICE_QUANTITY = 5;

        public const int CHEESE_QUANTITY = 40;

        public const int FRUIT_QUANTITY = 50;

        public const int SAUCE_QUANTITY = 30;

        public const decimal SAUCE_PRICE = 0.02m; // Per grams.

        public static string SmallSeparator = new string('=', 30);

        public static string BiggerSeparator = new string('-', 90);

        public static int ProductCategoryCount = 6;
    }
}
