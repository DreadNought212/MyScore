using MyScore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyScore.Data
{
    public class SampleData
    {
        public static void Initialize(Context context)
        {
            if (!context.Countries.Any())
            {
                context.Countries.AddRange(
                    new Country
                    {
                        Name = "Russia"
                    },
                    new Country
                    {
                        Name = "Brazil"
                    },
                    new Country
                    {
                        Name = "Japan"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
