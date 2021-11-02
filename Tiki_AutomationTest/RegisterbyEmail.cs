/*
 * Created by Ranorex
 * User: PC
 * Date: 11/1/2021
 * Time: 11:43 AM
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
    /// Description of RegisterbyEmail.
    /// </summary>
    [TestModule("1F69E99D-4683-417F-AABA-44C061CEFCA6", ModuleType.UserCode, 1)]
   
    public class RegisterbyEmail : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RegisterbyEmail()
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
            Open_RegisterForm();
            OpenLoginbyEmailForm();
            LoginbyEmailFunction();
        }
        
           public void Open_RegisterForm()
        {
        	SpanTag Regist = Tiki_AutomationTestRepository.Instance.HomePage.btnRegiter;
        	Regist.Click();
        }
        
           public void OpenLoginbyEmailForm()
           {
           	PTag Email = Tiki_AutomationTestRepository.Instance.Loginpopup.EmailRegist;
           	Email.Click();
           }
        	
        public void LoginbyEmailFunction()
        {
        	
        	InputTag txtEmail  = Tiki_AutomationTestRepository.Instance.RegisterByEmail.txtEmail;
        	InputTag txtPassword = Tiki_AutomationTestRepository.Instance.RegisterByEmail.txtpassword;
        	Button btnLogin = Tiki_AutomationTestRepository.Instance.RegisterByEmail.btnLogin;
        	
	       	txtEmail.PressKeys("haimt99it@gmail.com");
	       	txtPassword.Click();
	       	txtPassword.PressKeys("01696403101a");
        	btnLogin.Click();
			
			
        }
    }
}
