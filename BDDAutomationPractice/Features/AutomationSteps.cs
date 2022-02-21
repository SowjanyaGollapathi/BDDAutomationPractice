using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace BDDAutomationPractice.Features
{
    [Binding]
    public class AutomationSteps
    {
        //create reference for webdriver
        IWebDriver driver = new ChromeDriver();

        [Given(@"user navigate the url")]
        public void GivenUserNavigateTheUrl()
        {
            //Navigate or open the url 
            driver.Navigate().GoToUrl("http://automationpractice.com");
        }
        
        [When(@"user search for the word ""(.*)""")]
        public void WhenUserSearchForTheWord(string p0)
        {
            //search for word dress
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(By.XPath("//input[@id='search_query_top']")).SendKeys("dress");
        }
        
        [When(@"user click on the search button")]
        public void WhenUserClickOnTheSearchButton()
        {
            //click on the search button
            driver.FindElement(By.Name("submit_search")).Click();
        }
        
        [When(@"user click on '(.*)' drop down, choose '(.*)'")]
        public void WhenUserClickOnDropDownChoose(string p0, string p1)
        {
            //In 'Sort By' drop down, choose 'Price: Lowest First'
            SelectElement dd = new SelectElement(driver.FindElement(By.Id("selectProductSort")));
            dd.SelectByIndex(1);
        }

        [When(@"user Click on the ‘More’ Button")]
        public void WhenUserClickOnTheMoreButton()
        {
            //Click on the ‘More’ Button. It should open the details page. 
            driver.FindElement(By.XPath("//body/div[@id='page']/div[2]/div[1]/div[3]/div[2]/ul[1]/li[1]/div[1]/div[2]/div[2]/a[2]")).Click();
        }

        [When(@"user Click '(.*)' button")]
        public void WhenUserClickButton(string p0)
        {
            //Click 'Add to Cart' button 
            driver.FindElement(By.XPath("//span[contains(text(),'Add to cart')]")).Click();
        }

        [When(@"user Take a screenshot of the product page")]
        public void WhenUserTakeAScreenshotOfTheProductPage()
        {
            //Take a screenshot of the product page
            Screenshot ss2 = ((ITakesScreenshot)driver).GetScreenshot();
            ss2.SaveAsFile("C:\\Users\\Dileep\\Desktop\\SSS\\Scrn2.png", ScreenshotImageFormat.Png);

        }

        [When(@"user Click on proceed to checkout")]
        public void WhenUserClickOnProceedToCheckout()
        {
            //Click on proceed to checkout
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(By.XPath("//header/div[3]/div[1]/div[1]/div[4]/div[1]/div[2]/div[4]/a[1]/span[1]/i[1]")).Click();
        }
        
        [When(@"user in signin page Click Proceed to checkout")]
        public void WhenUserInSigninPageClickProceedToCheckout()
        {
            //Click Proceed to checkout 
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(By.XPath("//body[1]/div[1]/div[2]/div[1]/div[3]/div[1]/p[2]/a[1]/span[1]")).Click();

        }

        [When(@"user enter a registered email address")]
        public void WhenUserEnterARegisteredEmailAddress()
        {
            //enter a registered email address
            driver.FindElement(By.Name("email")).SendKeys("sowjanyagollapathi17@gmail.com");
        }
        
        [When(@"user enter a valid password")]
        public void WhenUserEnterAValidPassword()
        {
            //enter a valid password
            driver.FindElement(By.Name("passwd")).SendKeys("sowjanya@17");
        }
        
        [When(@"user click on signin button")]
        public void WhenUserClickOnSigninButton()
        {
            //click on signin button
            driver.FindElement(By.Name("SubmitLogin")).Click();
        }
        
        [When(@"user in address page, '(.*)'")]
        public void WhenUserInAddressPage(string p0)
        {
            //Click on address page, 'Click Proceed to checkout' 
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(By.XPath("//body[1]/div[1]/div[2]/div[1]/div[3]/div[1]/form[1]/p[1]/button[1]/span[1]")).Click();


        }

        [When(@"user Click on Agree terms of service and Click '(.*)'")]
        public void WhenUserClickOnAgreeTermsOfServiceAndClick(string p0)
        {
            //Click on Agree terms of service and Click 'Proceed to checkout'             
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(By.Id("cgv")).Click();
            driver.FindElement(By.XPath("//body[1]/div[1]/div[2]/div[1]/div[3]/div[1]/div[1]/form[1]/p[1]/button[1]/span[1]")).Click();
        }
        
        [When(@"user Click on Confirm my order")]
        public void WhenUserClickOnConfirmMyOrder()
        {
            //Click on Confirm my order
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(By.XPath("//body/div[@id='page']/div[2]/div[1]/div[3]/div[1]/div[1]/div[3]/div[2]/div[1]/p[1]/a[1]")).Click();

            //Display the message"Your order on My Store is complete"
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(By.XPath("//body[1]/div[1]/div[2]/div[1]/div[3]/div[1]/form[1]/p[1]/button[1]/span[1]")).Click();

        }

        [Then(@"user click on signout button")]
        public void ThenUserClickOnSignoutButton()
        {
            //Click on signout button
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(By.XPath("//header/div[2]/div[1]/div[1]/nav[1]/div[2]/a[1]")).Click();

            //Close all the opened browsers
            //driver.Quit();

        }
    }
}
