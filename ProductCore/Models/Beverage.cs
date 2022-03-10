using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCore.Models
{
    public class Beverage : Product
    {
        private bool carbonated;
        public Beverage(string caption, double content, string contentUnit, string ContainerType, int cost, int stock, bool carbonated) 
            : base(caption, content, contentUnit, ContainerType, cost, stock)
        {
            Carbonated = carbonated;
        }

        public bool Carbonated { get; set; }
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

