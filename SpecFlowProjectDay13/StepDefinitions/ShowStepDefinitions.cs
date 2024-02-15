using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProjectDay13.StepDefinitions
{
    [Binding]
    public class ShowStepDefinitions
    {
        [Given(@"I input following numbers to the calculator")]
        public void GivenIInputFollowingNumbersToTheCalculator(Table table)
        {
            //var data = table.CreateSet<Calculation>();
            //foreach (var row in data)
            //{
            //    Console.WriteLine($"The number is {row.Numbers}");
            //}

            dynamic data = table.CreateDynamicSet();
            foreach (var item in data)
            {
                Console.WriteLine($"The numbers are {item.Numbers}");
            }

        }

        //public record Calculation
        //{
        //    public int Numbers { get; set; }
        //}

        [Then(@"I see the result and few more details")]
        public void ThenISeeTheResultAndFewMoreDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            Console.WriteLine($"The result is {data.Results} with {data.Logo}");
        }


        [Then(@"the result should ""([^""]*)""")]
        public void ThenTheResultShould(string passed)
        {
            Console.WriteLine(passed);
        }
    }
}
