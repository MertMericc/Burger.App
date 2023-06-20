using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burger.App.Entity.Concrete
{
    public class Burger
    {
        public int BurgerId { get; set; }
        public string BurgerName { get; set; }
        public decimal BurgerPrice { get; set; }
        public bool Status { get; set; }
    }
}
