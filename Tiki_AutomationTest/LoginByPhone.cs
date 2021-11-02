/*
 * Created by Ranorex
 * User: PC
 * Date: 11/1/2021
 * Time: 2:13 PM
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
    /// Description of LoginByPhone.
    /// </summary>
    [TestModule("88CEEDC0-DBF9-4ACC-A6DD-4455F8FDB0A5", ModuleType.UserCode, 1)]
    public class LoginByPhone : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LoginByPhone()
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
            Open_LoginForm();
            InputPhoneNumber();
            InputPassword();
        }
        public void Open_LoginForm()
        {
        	SpanTag LoginForm = Tiki_AutomationTestRepository.Instance.HomePage.btnRegiter;
        	LoginForm.Click();
        }
        public void InputPhoneNumber()
        {
        	
        	InputTag txtPhone = Tiki_AutomationTestRepository.Instance.Loginpopup.txtPhone;
        	Button btnContinue = Tiki_AutomationTestRepository.Instance.Loginpopup.btnContinue;
        	
	       	txtPhone.PressKeys("0867771906");
	       	Keyboard.Press("{ENTER}");
        }
        public void InputPassword()
        {
        	InputTag txtPasword = Tiki_AutomationTestRepository.Instance.Loginpopup.txtPassWord;
        	Button btnLogin = Tiki_AutomationTestRepository.Instance.Loginpopup.btnLogin;
        	
        	txtPasword.PressKeys("01696403101a");
        	btnLogin.Click();
        }
    }
}
