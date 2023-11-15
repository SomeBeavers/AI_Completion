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
            
            //TODO: show a dialog with ability to update Name
            
        }
        
        
        //public string GetName
        //{
        //    return Name;
        //}
    }
}