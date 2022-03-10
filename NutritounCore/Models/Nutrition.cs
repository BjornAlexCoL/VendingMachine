using System;
using System.Collections.Generic;
using System.Text;

namespace NutritionCore.Models
{
    public abstract class Nutrition
    {
        private readonly double energy = 0;
        private readonly string caption = "";

        public Nutrition(string caption, double energy)
        {
            this.energy = energy;
            this.caption = caption;

        }
        public Nutrition(string caption, double energy,double quantity):this (caption,energy)
        {
  
            Quantity = quantity;

        }
        public double Energy{get;}
        public string Caption{get;}

        public double Quantity { set; get; }
        public abstract string Info();

        public string EnergyDeclaration()
        {
            return $"{Caption} {EnergyValue()} kCal";
        }
        public double EnergyValue()
        {
            return Quantity * energy;
        }
    }
}
