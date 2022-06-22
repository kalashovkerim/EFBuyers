using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFBuyers
{
    public class Buyer
    {
        public string? FullName { get; set; } = null!;
        public string? Gender {get; set;} = null!;
        public string? Email {get; set;} = null!;
        public string? Country { get; set;} = null!;

        public string? City { get; set; } = null!;
        public string? Section { get; set;} = null!;

        public override string ToString()
        {
            return $"Full Name: {FullName}\n" +
                   $"Gender: {Gender}\n" +
                   $"Email: {Email}\n" +
                   $"Country: {Country}\n" +
                   $"City: {City}\n" +
                   $"Section: {Section}";
                    

        }
    }
}
