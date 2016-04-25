using ExaPhaser.WebForms;
using ExaPhaser.WebForms.Controls;
using SharpJS.Dom;
using SharpJS.Dom.Styles;
using System;
using SharpJS.System.IO.WebStorage;

namespace Labels
{
    //tutorial on labels
    public class MainForm : WebForm
    {
        private TextBox label; //declaration
        public MainForm()
        {
            label = new TextBox //making our new label
            {
                Text = "Hey this is an awesome label.",
            };
            Controls = new Layout() //this is where you actually put the elements onto the webpage
            {
                label,
            };
        }
    }
}