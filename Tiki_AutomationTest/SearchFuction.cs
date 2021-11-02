/*
 * Created by Ranorex
 * User: PC
 * Date: 11/1/2021
 * Time: 3:08 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace Tiki_AutomationTest
{
    /// <summary>
    /// Description of SearchFuction.
    /// </summary>
    [TestModule("AD492366-DABF-47E9-88DE-A98F1A1109DD", ModuleType.UserCode, 1)]
    public class SearchFuction : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SearchFuction()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            SearchProduct();
        }
        
        public void SearchProduct()
        {
        	InputTag txtsearch = Tiki_AutomationTestRepository.Instance.HomePage.txtSearch;
        	Button btnsearch = Tiki_AutomationTestRepository.Instance.HomePage.btnSearch;
        	
        	txtsearch.PressKeys(" ");
        	btnsearch.Click();
        }
    }
}
