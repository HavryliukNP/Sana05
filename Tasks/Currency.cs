using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Currency
    {
        protected string name;
        protected double exRate;
        public string Name
        {
            get { return name; }
            protected set { name = value; }
        }
        public double ExRate
        {
            get { return exRate; }
            protected set { exRate = value; }
        }

        public Currency(string name, double exRate) 
        {
            Name = name;
            ExRate = exRate;
        }
        
    }
}
