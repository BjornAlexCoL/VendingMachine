using System;
using System.Collections.Generic;
using System.Text;

namespace NutritionCore.Models
{
    public class DieteryFiber : Nutrition
    {
        public DieteryFiber() : base("DieteryFiber", 2) { }
        public override string Info()
        {
            return "Dietary fiber, also known as roughage or bulk, " +
                    "includes the parts of plant foods your body can't digest " +
                    "or absorb. Unlike other food components, such as fats, " +
                    "proteins or carbohydrates - which your body breaks down and " +
                    "absorbs - fiber isn't digested by your body.";
        }
    }
}