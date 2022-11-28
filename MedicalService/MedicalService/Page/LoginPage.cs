﻿using MedicalService.NewFolder;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalService.Page
{
    public class LoginPage
    {
        public IWebDriver driver = WebDrivers.Instance;
        public IWebElement AppMedic => driver.FindElement(By.Id("btn-make-appointment"));
        public IWebElement Username => driver.FindElement(By.Id("txt-username"));
        public IWebElement Password => driver.FindElement(By.Id("txt-password"));
        public IWebElement LoginButton => driver.FindElement(By.Id("btn-login"));
        public void Login(string user, string pass)
        {
            Username.SendKeys(user);
            Password.SendKeys(pass);
            LoginButton.Submit();
        }
    }
}
