using OOPSWithCSharp.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSWithCSharp
{
    class Program
    {
        /// <summary>
        /// Entry point of the app.The process of starting up is called bootstrapping
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //This is an object of student class
            Student zee = new Student();
            zee.Name = "Zeeshan";
            zee.Age = 40;
            zee.Division = "4th Std";
        }
    }
}
