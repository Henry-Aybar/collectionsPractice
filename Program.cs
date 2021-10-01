using System;
using System.Collections.Generic;

namespace collectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] numArray = {0,1,2,3,4,6,7,8,9};

            // string[] names = new string[] { "Tim", "Martin", "Nikki", "Sara"};

            // string[] truefalse = new string[] { "True", "False", "True", "False", "True", "False", "True", "False", "True", "False"};


            List<string> faveIceCreams = new List<string>();
            faveIceCreams.Add("pistachio");
            faveIceCreams.Add("cookie dough");
            faveIceCreams.Add("amricone dream");
            faveIceCreams.Add("vanilla");
            faveIceCreams.Add("chocolate");
            Console.WriteLine(faveIceCreams.Count);
            faveIceCreams.Remove("amricone dream");
            Console.WriteLine(faveIceCreams.Count);

            Random rand = new Random();
            Dictionary<string, string> iceCream = new Dictionary<string, string>();
            iceCream.Add("Tim", "vanilla");
            iceCream.Add("Martin", "cookie dough");
            iceCream.Add("Nikki", "pistachio");
            iceCream.Add("Sara", "pistachio");
            

            foreach (KeyValuePair<string, string> name in iceCream)
            {
                Console.WriteLine(name.Key +" has chosen to eat " + name.Value + " icecream!");
            }
            
            // for (int i = 0; i < faveIceCreams.Count; i++)
            //     {
            //         Console.WriteLine(faveIceCreams[i]);
            //     }
        }
    }
}
