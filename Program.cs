using System;
using System.Collections.Generic;

namespace VirusSuck
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();


            /*add items to the list one at a time*/
            names.Add("COVID-19");
            names.Add("Ebola");
            names.Add("Spanish Flu");
            names.Add("SARS");
            names.Add("Rabies");
            names.Add("Stupidity");
            names.Insert(0, "Shebola");

            /*remove items to the list one at a time*/

            names.Remove("Stupidity");
            names.RemoveAt(3);

            /*add multiple items*/
            var peeps = new List<string> { "Nathan", "Martin", "Randy's Kid" };
            names.AddRange(peeps);

            /*add multiple items Second way*/

            /*remove multiple items*/
            names.RemoveRange(names.Count - 4,3) ;




        }
    }
}
