using Reqnroll;
using TestAutoPlaywrightEconnexion.Drivers;


namespace TestAutoPlaywrightEconnexion.Support
{
    [Binding]
    public class Hooks
    {
        private readonly PlaywrightDriver _driver;


        public Hooks(PlaywrightDriver driver)
        {
            _driver = driver;
        }


        [BeforeScenario]
        public async Task BeforeScenario()
        {
            await _driver.StartAsync();
        }


        [AfterScenario]
        public async Task AfterScenario()
        {
            await _driver.StopAsync();
        }
    }
}