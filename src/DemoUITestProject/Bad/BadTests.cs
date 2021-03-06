﻿using NUnit.Framework;
using Xamarin.UITest;

namespace UITestDemo.UITest
{
    public class BadTests : Setup.BaseTests
    {
        public BadTests(Platform p) : base(p)
        {
        }

        [Test]
        public void ValidLoginTest()
        {                                                         
            app.WaitForElement("inputemail");
            app.EnterText("inputemail", "email@onmicrosoft.com");
            app.DismissKeyboard();
            app.Tap("inputpassword");// Tap password 
            app.EnterText("password");//Enter password
            app.DismissKeyboard();
            app.Tap("signinbutton"); // Tap Sign in
            app.Tap("1");
            app.Tap("2");
            app.Tap("3");
            app.Tap("4");
            app.WaitForElement(c => c.Marked("Confirm 4 digit passcode"));
            app.Tap("1");
            app.Tap("2");
            app.Tap("3");
            app.Tap("4");
            app.WaitForNoElement("inputemail");
            app.WaitForElement("Menu");
            app.Tap("Menu");
            app.WaitForElement("CurrentUser");
            app.WaitForElement("email@onmicrosoft.com");
        }

        [Test]
        public void InvalidEmailFormat()
        {
            app.WaitForElement("inputemail");
            app.EnterText("inputemail", "email@onmicrosoft@com"); 
            app.DismissKeyboard();
            app.Tap("inputpassword");// Tap password 
            app.EnterText("password");//Enter password
            app.DismissKeyboard();
            app.Tap("signinbutton"); // Tap Sign in
            app.WaitForElement(ft => ft.Property("text").Contains("Please check you entered your username and password correctly and try again."));
            app.WaitForElement("inputemail");
            app.EnterText("inputemail", "email@onmicrosoft.com"); //Enter Office 365 login
            app.DismissKeyboard();
            app.Tap("inputpassword");// Tap password 
            app.EnterText("password");//Enter password
            app.DismissKeyboard();
            app.Tap("signinbutton"); // Tap Sign in
            app.Tap("1");
            app.Tap("2");
            app.Tap("3");
            app.Tap("4");
            app.WaitForElement(c => c.Marked("Confirm 4 digit passcode"));
            app.Tap("1");
            app.Tap("2");
            app.Tap("3");
            app.Tap("4");
            app.WaitForNoElement("inputemail");
            app.WaitForElement("Menu");
            app.Tap("Menu");
            app.WaitForElement("CurrentUser");
            app.WaitForElement("email@onmicrosoft.com");
        }

        [Test]
        public void InvalidPassword()
        {
            app.WaitForElement("inputemail");
            app.EnterText("inputemail", "email@onmicrosoft@com"); 
            app.DismissKeyboard();
            app.Tap("inputpassword");// Tap password 
            app.EnterText("Invalidpassword");//Enter password
            app.DismissKeyboard();
            app.Tap("signinbutton"); // Tap Sign in
            app.WaitForElement(ft => ft.Property("text").Contains("Please check you entered your username and password correctly and try again."));
            app.WaitForElement("inputemail");
            app.EnterText("inputemail", "email@onmicrosoft.com"); 
            app.DismissKeyboard();
            app.Tap("inputpassword");// Tap password 
            app.EnterText("password");//Enter password
            app.DismissKeyboard();
            app.Tap("signinbutton"); // Tap Sign in
            app.Tap("1");
            app.Tap("2");
            app.Tap("3");
            app.Tap("4");
            app.WaitForElement(c => c.Marked("Confirm 4 digit passcode"));
            app.Tap("1");
            app.Tap("2");
            app.Tap("3");
            app.Tap("4");
            app.WaitForNoElement("inputemail");
            app.WaitForElement("Menu");
            app.Tap("Menu");
            app.WaitForElement("CurrentUser");
            app.WaitForElement("email@onmicrosoft.com");
        }
    }
}
