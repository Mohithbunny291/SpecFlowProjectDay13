using TechTalk.SpecFlow;

namespace SpecFlowProjectDay13.Hooks
{
    [Binding]
    public sealed class TestInitialize
    {
        [BeforeTestRun] public static void InitializeTest() => Console.WriteLine("Before Test Run");

        [BeforeFeature] public static void BeforeFeatureTest() => Console.WriteLine("Before Feature Run");

        [BeforeScenario("@showtag")]
        public void BeforeScenarioWithTag() => Console.WriteLine("Before scenario run");

        [AfterScenario]
        public void AfterScenario() => Console.WriteLine("After scenario run");
    }
}