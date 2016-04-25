﻿using ExaPhaser.WebForms;
using ExaPhaser.WebForms.Controls;
using SharpJS.Dom;
using SharpJS.Dom.Styles;

namespace Labels
{
    /// <summary>
	/// Main WebForm
	/// </summary>
	public class MainForm : WebForm
    {
        public MainForm()
        {
            Controls = new Layout()
            {
                new TextBlock()
                {
                    Text = "ExaPhaser.WebForms Demo",
                    TextAlign = TextAlign.Center,
                    FontStyle = new FontStyle()
                    {
                        FontSize = 24,
                        FontWeight = FontWeight.Bold,
                    }
                },
                new TextBlock()
                {
                    Text = "A random TextBox is below",
                },
                new TextBox()
                {
                    Text = "Some text",
                },
                new Button()
                {
                    Text = "OK",
                    CommandParameter = null,
                    Command = new DelegateCommand(()=>JSLibrary.Alert("You clicked the button")),
                },
                new TextArea()
                {
                    Text = "Cool! TextArea is now supported!",
                    Rows = 20,
                },
            };
        }
    }
}