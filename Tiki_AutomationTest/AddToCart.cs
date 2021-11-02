/*
 * Created by Ranorex
 * User: PC
 * Date: 11/1/2021
 * Time: 7:00 PM
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
    /// Description of AddToCart.
    /// </summary>
    [TestModule("86210E0A-81F5-4DFB-BEDC-9C2A3B29D308", ModuleType.UserCode, 1)]
    public class AddToCart : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddToCart()
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
            ChooseProductMenu();
            ChooseProduct();
            AddProductToCart();
        }
        public void ChooseProductMenu()
        {
        	DivTag ProductMenu  = Tiki_AutomationTestRepository.Instance.AddToCart.ProductMenu;
        	ProductMenu.Click();
        }
        
        public void ChooseProduct()
        {
        	
        	SpanTag ProductItem = Tiki_AutomationTestRepository.Instance.AddToCart.ProductItem;
        	ProductItem.Click();
        	
        }
        public void AddProductToCart()
        {
        	Button btnAddToCart = Tiki_AutomationTestRepository.Instance.AddToCart.btnAddToCart;
        	btnAddToCart.Click();
        }
    }
}
