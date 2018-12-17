using System.Collections.Generic;

namespace CheeseMVC.Models
{
    public class CheeseCategory
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public IList<Cheese> Cheese { get; set; }
        public IList<CheeseMenu> CheeseMenus { get; set; }
    }
}
