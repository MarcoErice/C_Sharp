using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonNumberLib
{
    public class PersonNumber
    {
        string number;
        public string LastDigit
        {
            get
            {
                return number;
            }
        }

        public void Process(string number)
        {
            
            var times = 0;
            List<int> multiplied = new List<int>();
            // this.number = "9";
            for (int i = 0; i < number.Length; i++)
            {
                if (i % 2 == 0)
                {
                    times = int.Parse(number.Substring(i, 1)) * 2;
                    if (times > 9)
                    {
                        times -= 9;
                    }
                }
                else
                {
                    times = int.Parse(number.Substring(i, 1)) * 1;
                }

                multiplied.Add(times);
            }

            this.number = Convert.ToString(10 - (multiplied.Sum() % 10));
            
        }
    }
}





