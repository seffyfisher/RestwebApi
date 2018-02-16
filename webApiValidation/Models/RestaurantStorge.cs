using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webApiValidation.Models
{
    public static class RestaurantStorge
    {
        public static List<Restaurant> LocalRests { get; set; } = new List<Restaurant>();
        
        private static void Seed()
        {


            Restaurant[] tempArr = new Restaurant[]
            {
                new Restaurant{ID=0,AvgDishPrice=60,IsKosher=true,OpeningHour =14
                ,ClosingHour=21,Name="Uzeria" },

                new Restaurant{ID=1,AvgDishPrice=100,IsKosher=false,OpeningHour = 13,
                    ClosingHour =22,Name="Mizlala" },

                new Restaurant{ID=2,AvgDishPrice=30,IsKosher=true,OpeningHour =15,
                    ClosingHour =23,Name="Reelcaos" },new Restaurant

                    { ID=3,AvgDishPrice=20,IsKosher=false,OpeningHour=9
                ,ClosingHour=20,Name="IceCreamPalace" }
            };
            LocalRests.AddRange(tempArr);
        }

        static RestaurantStorge()
        {
            Seed();
        }

        
    }
}