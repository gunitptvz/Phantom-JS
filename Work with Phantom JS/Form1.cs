using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;

namespace Work_with_Phantom_JS
{

    public partial class Form1 : Form
    {
        IWebDriver phantom;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            phantom = new PhantomJSDriver();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            phantom.Quit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            phantom.Navigate().GoToUrl("https://www.google.ru/");

            File.WriteAllText("D:\\Загрузки\\Программирование C#\\GitHub_VS\\Work with Phantom JS\\Work with Phantom JS\\page.txt", phantom.PageSource);
            (phantom as PhantomJSDriver).GetScreenshot().SaveAsFile("D:\\Загрузки\\Программирование C#\\GitHub_VS\\Work with Phantom JS\\Work with Phantom JS\\page1.jpg", ScreenshotImageFormat.Jpeg);

            IWebElement search = phantom.FindElement(By.Name("q"));
            search.SendKeys("как вырастить грибы");
            search.SendKeys(OpenQA.Selenium.Keys.Return);
            (phantom as PhantomJSDriver).GetScreenshot().SaveAsFile("D:\\Загрузки\\Программирование C#\\GitHub_VS\\Work with Phantom JS\\Work with Phantom JS\\page2.jpg", ScreenshotImageFormat.Jpeg);

        }
    }
}
