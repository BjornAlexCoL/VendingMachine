using System;
using System.Collections.Generic;
using System.Text;
using NutritionCore.Models;

namespace NutritionCore.Services
{
    public interface INutritionUtils
    {
        public string EnergyDeclaration();
        public double EnergyValue();

        public bool isNutritionInlist(Nutrition searchNutrition);
        //Create
        Nutrition AddIfNotExist(Nutrition nutrition);

        List<Nutrition> GetAll();

    }
}
