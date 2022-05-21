using System;
using System.Collections.Generic;

#nullable disable

namespace Shop.DataModels.Models
{
    public partial class FoodOrder
    {
        public int Id { get; set; }
        public string OrderId { get; set; }
        public string StarterName { get; set; }
        public string Sqty { get; set; }
        public string MainName { get; set; }
        public string Mqty { get; set; }
        public string DesertName { get; set; }
        public string Dqty { get; set; }
        public string DishType { get; set; }
    }
}
