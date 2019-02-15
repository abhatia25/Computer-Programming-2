using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Class
{
    class Car
    {
        private string name;

        public Car(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public string start { get; set; }

        public void Start()
        {
            Console.WriteLine("Car started!");
        }
    }
}