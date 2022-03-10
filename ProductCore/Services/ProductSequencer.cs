﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCore.Services
{
    class ProductSequencer
    {
        private static int idCounter = 0;

        public static int NextProductId()
        {
            return ++idCounter;
        }

        public static void Clear()
        {
            idCounter = 0;
        }
    }
}
