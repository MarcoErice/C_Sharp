using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtbildningLib
{
    public class Utbildning
    {
        private string name;
        private int hours;
        public bool IsSummary { get; set; }

        public Utbildning(string name, int hours, bool isSummary)
        {
            this.name = name;
            this.hours = hours;
            this.IsSummary = isSummary;
            Children = new List<Utbildning>();
        }

        public int TotalHours
        {
            get
            {
                if (IsSummary)
                    return Children.Sum(child => child.TotalHours);
                return this.hours;

            }
        }
        
        public List<Utbildning> Children { get; set; }
    }
}
