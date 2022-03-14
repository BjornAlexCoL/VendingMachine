using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCore.Models
{
    public class MicrowaveFood : Product
    {
        public MicrowaveFood(string caption, double content, string contentUnit, string ContainerType, int cost, int stock, int cookingTime) : base(caption, content, contentUnit, ContainerType, cost, stock)
        {

            CookingTime = cookingTime;
        }
        public int CookingTime { get; set; }
        public override string Examine()
        {
            throw new NotImplementedException();
        }

        public override string Use()
        {
            throw new NotImplementedException();
        }
    }
}
