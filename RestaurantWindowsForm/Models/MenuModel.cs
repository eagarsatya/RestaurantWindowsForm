using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantWindowsForm.Models
{
    public class MenuModel
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; } = string.Empty;
        public string RestaurantName { get; set; } = string.Empty;
        public string FoodTheme { get; set; } = string.Empty;
        public bool IsAvailable { get; set; }
    }

    public class MenuInputModel
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; } = string.Empty;
        public int RestaurantId { get; set; }
        public string FoodTheme { get; set; } = string.Empty;
        public bool IsAvailable { get; set; }
    }
}
