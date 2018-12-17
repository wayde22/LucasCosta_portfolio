using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels
{
    public class AddMenuItemViewModel
    {
        [Required]
        [Display(Name = "CheeseId Name")]
        public int cheeseID { get; set; }

        [Required]
        [Display(Name = "MenuId Name")]
        public int menuID { get; set; }

        public Menu Menu { get; set; }
        public List<SelectListItem> Cheeses { get; set; }

        public AddMenuItemViewModel(){}

        public AddMenuItemViewModel(Menu Menu, IEnumerable<Cheese> cheese){
          Cheeses = [];
          Cheeses.Add(new SelectListItem
          {
              Value = cheese.ID.ToString(),
              Text = cheese.Name
          });
        }
    }
}
