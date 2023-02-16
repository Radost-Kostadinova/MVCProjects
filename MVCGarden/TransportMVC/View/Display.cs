using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportMVC.View
{
    public class Display
    {
        
        public Display()
        {
            this.Km = 0;
            this.TimeOfDay = string.Empty;
            //string->string.Empty za prazen string
            this.TotalPrice = 0;
            this.GetValues();
        }
        //alt za this

        public int Km { get; set; }
        public string TimeOfDay { get; set; }
        public double TotalPrice { get; set; }
        

        //za vuvejdane na danni
        public void GetValues()
        {
            this.Km = int.Parse(Console.ReadLine());
            this.TimeOfDay = Console.ReadLine();
        }
        
        //za izvejdane na resultat
        public void ShowResult()
        {
            Console.WriteLine($"{this.TotalPrice:f2}");
        }



    }
}
