using ClearMeasureDemo.Library;
using ClearMeasureDemo.Library.Models;
using System.ComponentModel.DataAnnotations;

namespace ClearMeasureDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customRules = new List<RuleModel>
            {
                new RuleModel { Input = 3, Output = "Three" },
                new RuleModel { Input = 4, Output = "Four" },
                new RuleModel { Input = 9, Output = "Nine" },
            };

            var rb = new RickyBobby(customRules);
            var result = rb.Execute(30);


            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}