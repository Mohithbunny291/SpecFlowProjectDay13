using AutoFixture;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectDay13.StepDefinitions
{
    [Binding]
    public class UserStepDefinitions
    {
        [Given(@"I enter a random user data")]
        public void GivenIEnterARandomUserData()
        {
            var person = new Fixture().Create<User>();
            Console.WriteLine("Name is "+person.Name+" Mail "+person.Mail+" Phone "+person.Phone+" Address "+person.Address);
        }

        public record User()
        {
            public string Name { get; init; }
            public string Mail { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }

        }
    }
}
