using Microsoft.Playwright;

namespace TestAutoPlaywrightEconnexion.Drivers
{
    public class PlaywrightDriver
    {
        public IPage Page { get; private set; } = null!;

        private IBrowser _browser = null!;


        public async Task StartAsync()
        {
            var playwright = await Playwright.CreateAsync();

            _browser = await playwright.Chromium.LaunchAsync(
                new BrowserTypeLaunchOptions
                {
                    Headless = false
                });

            Page = await _browser.NewPageAsync();
        }


        public async Task StopAsync()
        {
            await _browser.CloseAsync();
        }
    }
}