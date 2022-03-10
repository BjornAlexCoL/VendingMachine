using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCore.Models
{
    class Snack : Product
    {
        public Snack(string caption, double content, string contentUnit, string ContainerType, int cost, int stock) : base(caption, content, contentUnit, ContainerType, cost, stock) { }

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
