/*
 * Created by Ranorex
 * User: PC
 * Date: 11/1/2021
 * Time: 12:20 PM
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
    /// Description of CreateAccount.
    /// </summary>
    [TestModule("2965417D-A882-4C42-B90E-E5422B2E28AA", ModuleType.UserCode, 1)]
    public class CreateAccount : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CreateAccount()
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
            OpenLoginbyEmailform();
            OpenCreateAccForm();
            RegisterFunction();
        }
          public void Open_RegisterForm()
        {
        	SpanTag Regist = Tiki_AutomationTestRepository.Instance.HomePage.btnRegiter;
        	Regist.Click();
        }
        
           public void OpenLoginbyEmailform()
           {
           	PTag Email = Tiki_AutomationTestRepository.Instance.Loginpopup.EmailRegist;
           	Email.Click();
           }
           
           public void OpenCreateAccForm()
           {
           	SpanTag CreateAcc = Tiki_AutomationTestRepository.Instance.CreateNewAccount.spanCreate;
           	CreateAcc.Click();
           }
          
           	 public void RegisterFunction()
        {
        	
        	InputTag txtPhone = Tiki_AutomationTestRepository.Instance.Loginpopup.txtPhone;
        	Button btnContinue = Tiki_AutomationTestRepository.Instance.Loginpopup.btnContinue;
        	
	       	txtPhone.PressKeys("0901535628");
        	btnContinue.Click();
			
			
        }
    }
}
