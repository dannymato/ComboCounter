using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboCounter.Classes
{
    class Session
    {

        public DateTime StartDate { get; private set; }
        public List<double> Forces { get; private set; }
        public List<double> Times { get; private set; }

        public void insertHit(double force, double time)
        {
            Forces.Add(force);
            Times.Add(time);
        }

        public Session(DateTime start)
        {
            StartDate = start;
            Forces = new List<double>();
            Times = new List<double>();
        }
    
    }
}
