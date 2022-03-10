using System;
using System.Collections.Generic;
using System.Text;

namespace NutritionCore.Models

{
    class CarboHydrates : Nutrition
    {
        public CarboHydrates() : base("CarboHydrates", 4) { }
        public override string Info()
        {
            return "Carbohydrates, or carbs, are sugar molecules. Along with proteins " +
                "and fats, carbohydrates are one of three main nutrients found in " +
                "foods and drinks. Your body breaks down carbohydrates into glucose. " +
                "Glucose, or blood sugar, is the main source of energy for your body's " +
                "cells, tissues, and organs.";
        }
    }
}
