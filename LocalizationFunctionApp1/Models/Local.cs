using System.Collections.Generic;

namespace LocalizationFunctionApp1.Models
{
    public class Local
    {
        public string Id { get; set; }
        public string Country { get; set; }

        public static List<Local> GenerateList()
        {
            return new List<Local>
            {
                new Local {Id= "1", Country= "Australia" },
                new Local {Id= "2", Country= "UK" },
                new Local {Id= "3", Country= "Germany" }
            };
        }
    }
}