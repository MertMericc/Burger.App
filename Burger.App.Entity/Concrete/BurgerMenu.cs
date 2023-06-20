using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burger.App.Entity.Concrete
{
    public class BurgerMenu
    {
        public int BurgerMenuId { get; set; }
        public string BurgerMenuName { get; set; }
        public decimal BurgerMenuPrice { get; set; }
        public int BurgerMenuSize { get; set; }
    }
}
