using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 11001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }

            this.webBrowser1.Navigate("c:\\temp\\example.html");
            this.webBrowser1.DocumentCompleted += new
                WebBrowserDocumentCompletedEventHandler(this.WebBrowser1__DocumentCompleted);
        }

        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webBrowser = (WebBrowser)sender;
            HtmlElementCollection htmlElementCollection = webBrowser.Document.GetElementsByTagName("h2");
            HtmlElement htmlElement;

            htmlElement = webBrowser.Document.GetElementsByTagName("h1")[0];

            htmlElement.InnerText = "My UFO Page";
            htmlElementCollection[0].InnerText = "My UFO Info";
            htmlElementCollection[1].InnerText = "My UFO Pictures";
            htmlElementCollection[2].InnerText = "";

            htmlElement = webBrowser.Document.Body;
            htmlElement.Style += "font-family: sans-serif; color: #F08080;";

            htmlElement = webBrowser.Document.GetElementsByTagName("p")[0];
            htmlElement.InnerHtml = "Report your UFO sightings here: <a href='http://www.nuforc.org'>http://www.nuforc.org</a>";
            htmlElement.Style += "color: #007500; font-weight: bold; font-size: 2em; text-transform: uppercase; text-shadow: 3px 2px #A44;";

            htmlElement = webBrowser.Document.GetElementsByTagName("p")[1];
            htmlElement.InnerText = "";

            htmlElement = webBrowser.Document.CreateElement("img");
            htmlElement.SetAttribute("src", "https://alien-ufo-sightings.com/wp-content/uploads/2017/09/ad_238449976.jpg");

            webBrowser.Document.GetElementById("lastParagraph").InsertAdjacentElement(HtmlElementInsertionOrientation.BeforeBegin, htmlElement);

            htmlElement = webBrowser1.Document.CreateElement("footer");
            htmlElement.InnerHtml = "(&copy;) 2020 Phillip Da Gama Paes";
            webBrowser1.Document.Body.AppendChild(htmlElement);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
