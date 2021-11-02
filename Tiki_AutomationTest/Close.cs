/*
 * Created by Ranorex
 * User: PC
 * Date: 11/1/2021
 * Time: 9:01 AM
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
    /// Description of Close.
    /// </summary>
    [TestModule("0BEB31D7-1256-45E1-B5CF-38B54541D674", ModuleType.UserCode, 1)]
    public class Close : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Close()
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
            closeAllBrowserTabs();
        }
        
          public void closeAllBrowserTabs()
        {
        	
			
			IList<Ranorex.WebDocument> webList = Host.Local.Find<Ranorex.WebDocument>("/dom[@dom='tiki.vn']");
			foreach (Ranorex.WebDocument webdoc in webList)
			{  
			    webdoc.Close();
			}
        	
        	Delay.Milliseconds(500);
        }
    }
}
