using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Wild_Farm
{
    internal abstract class Food
    {
        private int quantity;

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        public Food(int quantity) 
        {
            this.Quantity = quantity;
        }
    }
}
