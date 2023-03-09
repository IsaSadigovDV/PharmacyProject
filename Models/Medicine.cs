using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AptekProject.Models
{
    internal class Medicine
    {
        public string Name;
        public string Category;
        public double Price;


        public Medicine(string name, string category, double price)
        {
            Name = name;
            Category = category;
            Price = price;
        }
    }
}
