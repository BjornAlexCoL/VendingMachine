using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCore.Models
{
    public class Fruit : Product
    {

        public Fruit(string caption,string latinFamily,string latinSpiecemen, double content, string contentUnit, string ContainerType, int cost, int stock) 
            : base(caption, content, contentUnit, ContainerType, cost, stock)
        {
            LatinFamily = latinFamily;
            LatinSpiecemen = latinSpiecemen;
        }

        public string LatinFamily { get; set; }
        public string LatinSpiecemen { get; set; }
        public string LatinName { get {return $"{LatinFamily} {LatinSpiecemen}"; }  }
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

