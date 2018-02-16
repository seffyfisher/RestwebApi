using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using webApiValidation.Attributes;

namespace webApiValidation.Models
{
    public class Restaurant
    {
        [PostiveNumber]
        public int ID { get; set; }

        [Range(5, 150)]
        public int AvgDishPrice { get; set; }

        public bool IsKosher { get; set; }

        [Range(0, 24)]
        public int OpeningHour { get; set; }

        [Range(0,24)]
        public  int ClosingHour { get; set; }

        [MaxLength(20),MinLength(5)]
        public string Name { get; set; }
    }
}