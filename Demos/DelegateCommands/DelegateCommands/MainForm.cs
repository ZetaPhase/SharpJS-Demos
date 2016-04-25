using ExaPhaser.WebForms;
using ExaPhaser.WebForms.Controls;
using SharpJS.Dom;
using SharpJS.Dom.Styles;

namespace DelegateCommands
{
    //tutorial for delegate commands
    //used for event handling
    public class MainForm : WebForm
    {
        private Button alert; //declaration
        private Button helloWorld;
        private TextArea editArea;
        public MainForm()
        {
            editArea = new TextArea //rich text box
            {
                Text = "", // text of our rich text box
                FontStyle = new FontStyle() { // add a new font style
                    FontSize = 12 //change font size
                }
            };
            alert = new Button // define alert button
            {
                Text = "Alert Button", //text shown on button
                Command = new DelegateCommand(() => JSLibrary.Alert("You clicked the cool button")),// throw an alert when the alert button is clicked

            };
            helloWorld = new Button // define hello world button
            {
                Text = "Hello World", // text shown on the button
                Command = new DelegateCommand(() => OnHelloWorld())//run the OnHelloWorld method below when the hello world button is clicked.
            };
            Controls = new Layout() //this is where you actually put the elements onto the webpage
            {
                editArea, //rich textbox first
                alert, // alert button
                helloWorld, //helloWorld button
            };
        }
        private void OnHelloWorld() {
            //The Hello world button has been clicked
            editArea.Text = "Hello World!"; //change the text of the rich text box to 'Hello World!'
        }
    }
}