using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TestZooplaProject.Browsers;

namespace TestZooplaProject.Hooks
{
    [Binding]
    public sealed class Hook : BrowserManager
    {

        [BeforeScenario]
        public void BeforeScenario()
        {
            LaunchBrowser("Chrome");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            CloseBrowser();
        }
    }
}
