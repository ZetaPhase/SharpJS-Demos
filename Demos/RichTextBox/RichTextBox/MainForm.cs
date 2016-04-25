using ExaPhaser.WebForms;
using ExaPhaser.WebForms.Controls;
using SharpJS.Dom;
using SharpJS.Dom.Styles;

namespace RichTextBox
{
    //tutorial on rich text boxes
    public class MainForm : WebForm
    {
        private TextArea richTextBox; //declaration
        public MainForm()
        {
            richTextBox = new TextArea
            {
                Text = "This is a very cool rich text box."
            };
            Controls = new Layout() //this is where you actually put the elements onto the webpage
            {
                richTextBox,
            };
        }
    }
}