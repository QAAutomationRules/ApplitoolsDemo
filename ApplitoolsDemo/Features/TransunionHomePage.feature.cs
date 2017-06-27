﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace ApplitoolsDemo.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Transunion Home Page", Description="\tAs a Transunion Customer\r\n\tI want the Transunion Home Page to be Responsive \r\n\ts" +
        "o I can us the Website on Mobile and Desktop", SourceFile="Features\\TransunionHomePage.feature", SourceLine=0)]
    public partial class TransunionHomePageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "TransunionHomePage.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Transunion Home Page", "\tAs a Transunion Customer\r\n\tI want the Transunion Home Page to be Responsive \r\n\ts" +
                    "o I can us the Website on Mobile and Desktop", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 7
#line 8
 testRunner.Given("I navigate to the \"http://www.Transunion.com\" Home Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        public virtual void ViewTheHomePageAsAResponsiveWebsite(string browserSize, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Smoke"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("View the Home Page as a Responsive website", @__tags);
#line 11
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 12
 testRunner.Given(string.Format("the Transunion Home Page is displayed in a certain {0}", browserSize), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 13
 testRunner.When("the Base Home Page Image is Compared to the Current Home Page Image", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.Then("the Home Page images should match correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("View the Home Page as a Responsive website, Full", new string[] {
                "Smoke"}, SourceLine=18)]
        public virtual void ViewTheHomePageAsAResponsiveWebsite_Full()
        {
            this.ViewTheHomePageAsAResponsiveWebsite("Full", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("View the Home Page as a Responsive website, Half", new string[] {
                "Smoke"}, SourceLine=18)]
        public virtual void ViewTheHomePageAsAResponsiveWebsite_Half()
        {
            this.ViewTheHomePageAsAResponsiveWebsite("Half", ((string[])(null)));
#line hidden
        }
        
        public virtual void ViewTheHomePageInTheMobileBrowser(string mobileBrowser, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Smoke"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("View the Home Page in the Mobile Browser", @__tags);
#line 24
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 25
 testRunner.Given(string.Format("the Transunion Home Page is displayed correctly on mobile browsers {0}", mobileBrowser), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
 testRunner.When("the Base Mobile Home Page Image is Compared to the Current Home Page Image", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
 testRunner.Then("the Home Page images should match correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("View the Home Page in the Mobile Browser, Mobile Chrome Pixel Phone", new string[] {
                "Smoke"}, SourceLine=31)]
        public virtual void ViewTheHomePageInTheMobileBrowser_MobileChromePixelPhone()
        {
            this.ViewTheHomePageInTheMobileBrowser("Mobile Chrome Pixel Phone", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
