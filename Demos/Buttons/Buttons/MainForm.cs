using ExaPhaser.WebForms;
using ExaPhaser.WebForms.Controls;
using SharpJS.Dom;
using SharpJS.Dom.Styles;

namespace Buttons
{
    //tutorial buttons
    public class MainForm : WebForm
    {
        private Button button; //declaration
        public MainForm()
        {
            button = new Button
            {
                Text = "Cool Button.",
                Command = new DelegateCommand(() => JSLibrary.Alert("You clicked the cool button")),// what to do when button is clicked

            };
            Controls = new Layout() //this is where you actually put the elements onto the webpage
            {
                button,
            };
        }
    }
}