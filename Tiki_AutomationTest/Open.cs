/*
 * Created by Ranorex
 * User: PC
 * Date: 11/1/2021
 * Time: 8:59 AM
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
    /// Description of Open.
    /// </summary>
    [TestModule("4BA87730-5346-49D5-B4D6-0EA1FBA62EB0", ModuleType.UserCode, 1)]
    public class Open : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Open()
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
            OpenBrowser ();
        }
        public void OpenBrowser()
        {
        	 Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://tiki.vn/' with browser 'chrome' in normal mode.");
            Host.Current.OpenBrowser("https://tiki.vn/", "chrome", "", false, false, false, false, false, false, false, true);
            
        }
    }
}
