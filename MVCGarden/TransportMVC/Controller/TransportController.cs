using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportMVC.Model;
using TransportMVC.View;

namespace TransportMVC.Controller
{
    public class TransportController
    {
        private Display display;
        private TransportController transport;

        public TransportController()
        {
            Display display = new Display();
            Transport transport = new Transport(display.Km, display.TimeOfDay);
            display.TotalPrice = transport.CalculatePrice();
            display.ShowResult();
        }


    }
}
