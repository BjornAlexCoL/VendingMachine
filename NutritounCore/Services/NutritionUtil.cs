using System;
using System.Collections.Generic;
using System.Text;
using NutritionCore.Models;


namespace NutritionCore.Services
{
    class NutritionUtil:INutritionUtils
    {
        List<Nutrition> nutritionList = new List<Nutrition>();

        public NutritionUtil()
        {
        }

        public Nutrition AddIfNotExist(Nutrition nutrition)
        {
            Nutrition newNutrition=null;
            if (!isNutritionInlist(nutrition))
            {
                nutritionList.Add(nutrition);
            }
            
            return newNutrition;

        }

          public string EnergyDeclaration()
        {
            string energyContent = "";
            for (int index = 0; index < nutritionList.Count;index++)
            {
                energyContent = energyContent + nutritionList[index].EnergyDeclaration()+((index<(nutritionList.Count-1))?", ":"");

            }
            return energyContent;
        }

        public double EnergyValue()
        {
            double energyValue =0;
            foreach (Nutrition nutrition in nutritionList)
            {
                energyValue += nutrition.EnergyValue();

            }
            return energyValue;
        }

        public List<Nutrition> GetAll()
        {
            return nutritionList;
        }

        public bool isNutritionInlist(Nutrition searchNutrition)
        {
            foreach (Nutrition nutrition in nutritionList)
            {
                if (nutrition.GetType().Equals(searchNutrition.GetType()))
                {
                    return true;
                }
            }
        return false;

        }



        /*public string EnergyContent()
        {
        }*/
    }
}
