using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.Products
{
    internal abstract class BakeryProduct
    {
        float Prise {  get; set; }
        int Calories { get; set; }
        float Margin { get; set; }
    }
}
