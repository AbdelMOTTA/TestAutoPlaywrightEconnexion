using Microsoft.Playwright;
using Reqnroll;
using TestAutoPlaywrightEconnexion.Drivers;


namespace TestAutoPlaywrightEconnexion.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private readonly PlaywrightDriver _driver;


        public LoginStepDefinitions(PlaywrightDriver driver)
        {
            _driver = driver;
        }


        [Given("je suis sur la page de login")]
        public async Task GivenJeSuisSurLaPageDeLogin()
        {
            await _driver.Page.GotoAsync(
                "https://qualite-phoenix.econnection.fr/Authentification/Login/STM/DataBase");
        }


        [When("je me connecte avec {string} et {string}")]
        public async Task WhenJeMeConnecteAvecEt(
            string admin,
            string password)
        {
            await _driver.Page.FillAsync(
                "#Login",
                admin);

            await _driver.Page.FillAsync(
                "#Password",
                password);

            await _driver.Page.ClickAsync(
                "#btnlogin");
        }


        [Then("je vois la page d'accueil")]
        public async Task ThenJeVoisLaPageDaccueil()
        {
            await Assertions.Expect(
                _driver.Page)
                .ToHaveURLAsync(
                    "https://qualite-phoenix.econnection.fr/");
        }
    }
}