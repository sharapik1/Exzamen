using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    public class Pokupateli
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Summapokupok { get; set; }
        public DateTime Data { get; set; }
        public string City { get; set; }
        public string Magazin { get; set; }

        public string DateString
        {
            get
            {
                return Data.ToShortDateString();
            }
        }

    }


}
