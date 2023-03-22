using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectInstance
{
    internal class Human
    {
        public string Name;
        public int Age;
        public float Cm;
        public double Kg;
        public bool Had;

        public Human()
        {

        }

        public void PR()
        {
            Console.WriteLine($"{this.Name}씨는 나이가 {this.Age}살, 키가 {this.Cm}cm, 몸무게가 {this.Kg}KG,  {this.Had}");
        }
    }
}
