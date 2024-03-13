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
        public bool IsSpicy { get; set; }
        public int FoodTypeId { get; set; }
    }

    public class FoodTypeModel
    {
        public int FoodTypeId { get; set; }
        public string FoodTypeName { get; set; } = string.Empty;
    }
}
