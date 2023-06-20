using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burger.App.Entity.Concrete
{
    public class BurgerOrder
    {
        public int BurgerOrderId { get; set; }
        public int BurgerMenuId { get; set; }
        public int ExtraId { get; set; }
        public decimal TotalPrice { get; set; }
        public string Description { get; set; }
    }
}
