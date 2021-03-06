﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.239
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace RapidCase.DeveloperStudio.Specifications.BasicFunctions
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class NewOpenAndSaveFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "NewOpenSave.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "New, Open and save", "The RapidCase Development Studio must have initial, save and open functionality f" +
                    "or the configuration", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "New, Open and save")))
            {
                RapidCase.DeveloperStudio.Specifications.BasicFunctions.NewOpenAndSaveFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
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
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("A initial file is loaded the first time I start the RapidCase Development Studio")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "New, Open and save")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("web")]
        public virtual void AInitialFileIsLoadedTheFirstTimeIStartTheRapidCaseDevelopmentStudio()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A initial file is loaded the first time I start the RapidCase Development Studio", new string[] {
                        "web"});
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
 testRunner.Given("It is the first time I start Developer studio");
#line 7
 testRunner.When("I log in as Administrator");
#line 8
 testRunner.Then("a initial configuration will be loaded in to the RapidCase Development Studio");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("When a push the save button the active object is saved")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "New, Open and save")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("web")]
        public virtual void WhenAPushTheSaveButtonTheActiveObjectIsSaved()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When a push the save button the active object is saved", new string[] {
                        "web"});
#line 11
this.ScenarioSetup(scenarioInfo);
#line 12
 testRunner.Given("I\'am loged in to the RapidCase Development Studio");
#line 13
 testRunner.And("I have made som changes");
#line 14
 testRunner.When("I press the save button");
#line 15
 testRunner.Then("my changes is saved to ?");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("When a log in to the RapidCase Development Studio the configuration is automaticl" +
            "y loaded")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "New, Open and save")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("web")]
        public virtual void WhenALogInToTheRapidCaseDevelopmentStudioTheConfigurationIsAutomaticlyLoaded()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When a log in to the RapidCase Development Studio the configuration is automaticl" +
                    "y loaded", new string[] {
                        "web"});
#line 18
this.ScenarioSetup(scenarioInfo);
#line 19
 testRunner.Given("it is not the first time I log in to the RapidCase Development Studio");
#line 20
 testRunner.When("I do a sussesful log in to the RapidCase Development Studio");
#line 21
 testRunner.Then("the configuration is loaded from ?");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
