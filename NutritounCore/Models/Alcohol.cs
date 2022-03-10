using System;
using System.Collections.Generic;
using System.Text;

namespace NutritionCore.Models
{
    class Alcohol:Nutrition
    {
        public Alcohol() : base("Alcohol", 7) { }
        public override string Info()
        {
            return "Alcohol (ethanol or ethyl alcohol) is the ingredient found in beer, " +
                "wine and spirits that causes drunkenness.\nAlcohol is formed when yeast " +
                "ferments(breaks down without oxygen) the sugars in different food. For " +
                "example, wine is made from the sugar in grapes, beer from the sugar " +
                "in malted barley(a type of grain), cider from the sugar in apples, vodka " +
                "from the sugar in potatoes, beets or other plants.\nAlcohol is classed " +
                "as a ‘sedative hypnotic’ drug, which means it acts to depress the " +
                "central nervous system at high doses.At lower doses, alcohol can act " +
                "as a stimulant, inducing feelings of euphoria and talkativeness, but " +
                "drinking too much alcohol at one session can lead to drowsiness, " +
                "respiratory depression(where breathing becomes slow, shallow or stops " +
                "entirely), coma or even death.\nAs well as its acute and potentially " +
                "lethal sedative effect at high doses, alcohol has effects on every organ " +
                "in the body and these effects depend on the blood alcohol concentration(BAC) " +
                "over time. ";
        }
    }
}
