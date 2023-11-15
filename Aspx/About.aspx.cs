using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Aspx
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string Name { get; set; }
        

        protected void Button_Click(object sender, EventArgs e)
        {
            // Click on button to display floating window
            // Display a message box with the value of the Name property
            MessageBox.Show(Name);
            
            var dialog = new NameDialog();
            dialog.ShowDialog();
            Name = dialog.Name;
            
            //TODO: show a dialog with ability to update Name
            
        }
        
        
        //public string GetName
        //{
        //    return Name;
        //}
    }

    public class NameDialog
    {
        public string Name { get; set; }

        public void ShowDialog()
        {
            // Here you can add code to display the dialog to the user and get the name.
            // This is just a placeholder as the actual implementation will depend on the UI framework you are using.
        }
    }
    
    
}