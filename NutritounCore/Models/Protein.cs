using System;
using System.Collections.Generic;
using System.Text;

namespace NutritionCore.Models
{
    class Protein:Nutrition
    {
        public Protein() : base("Protein",4 ) { }
        public override string Info()
        {
            return "Proteins are large, complex molecules that play many critical roles in the" +
                " body. They do most of the work in cells and are required for the structure, " +
                "function, and regulation of the body's tissues and organs.";
                
        }
    }
}
