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
            names.RemoveRange(names.Count - 3,3) ;

            foreach (var name in names)
            {
                Console.WriteLine($"current name is {name}");
            }


            //-------------
            var symptoms = new Dictionary<string, string> ();

            /*add single items*/
            symptoms.Add("COVID-19","Dry cough,fever, respiratory problems");
            symptoms.Add("Ebola", "fever, headache, muscle pain, and chills");
            symptoms.Add("Spanish Flu", " fever, a dry cough, fatigue and difficulty breathing");
            symptoms.Add("SARS", "Fever, dry cough, headache, muscle aches, and difficulty breathing");
            symptoms.Add("Rabies", "Symptoms include fever, headache, excess salivation, muscle spasms, paralysis, and mental confusion.");

            /*get single thing*/
            var covidSymptons = symptoms["COVID-19"];

            /*remove single thing*/
            symptoms.Remove("Ebola");

            /*collection initializer*
             */

            var otherDictionary = new Dictionary<string, int> { { "nathan", 33 }, { "martin", 36 } };

            foreach (var (virus,symptom) in symptoms)
            {
                Console.WriteLine($"The {virus} virus has the following symptoms: {symptom}");
            }

            foreach (var name in names)
            {
                Console.WriteLine($"The {name} virus has the following symptoms:{symptoms[name]}");
            }

            /*Queues*/
            var diseasesToCure = new Queue<string>();
            diseasesToCure.Enqueue("SARS");
            diseasesToCure.Enqueue("COVID-19");

            diseasesToCure.Dequeue();


            /*Hashset*/
        }
    }
}
