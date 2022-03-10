using System;
using System.Collections.Generic;
using System.Text;

namespace NutritionCore.Models
{
    public class Fat : Nutrition
    {
        public Fat(string caption, double energy) : base(caption, energy) { }
        public Fat() : base("Fat", 9) { }
        public override string Info()
        {
            return "A small amount of fat is an essential part of a healthy, balanced diet. " +
                "Fat is a source of essential fatty acids, which the body cannot make itself.\n" +
                "Fat helps the body absorb vitamin A, vitamin D and vitamin E.These vitamins " +
                "are fat-soluble, which means they can only be absorbed with the help of fats.\n" +
                "Any fat that's not used by your body's cells or turned into energy is converted " +
                "into body fat. Likewise, unused carbohydrates and proteins are also converted " +
                "into body fat.";
        }
    }
}
