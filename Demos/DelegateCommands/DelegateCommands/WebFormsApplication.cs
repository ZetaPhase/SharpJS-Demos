using ExaPhaser.WebForms;
using ExaPhaser.WebForms.Themes;

namespace DelegateCommands
{
    public class WebFormsApplication
    {
        public static void Main(string[] args)
        {
            //Run the application
            new WebApplication(new CSSUITheme(CSSFramework.Kubism)).Run(new MainForm(), "webform-container");
        }
    }
}