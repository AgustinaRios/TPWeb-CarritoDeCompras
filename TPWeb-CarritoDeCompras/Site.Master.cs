using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
namespace TPWeb_CarritoDeCompras
{ 
    
    public partial class SiteMaster : MasterPage
    {
         
        protected void Page_Load(object sender, EventArgs e)
        {

            string a = Convert.ToString(Session["items"]);
            if (a == "")
            {
                Int32 b;
                b = 0;
                Session.Add("a", b);

            }
            else
            {
                Int32 c = Convert.ToInt32(Session["items"]);
                Int32 d =Convert.ToInt32(Session["a"]);
                Int32 cantItems;
               cantItems= d+c;
                LblItems.Text = Convert.ToString(cantItems);
                Session.Add("a", cantItems);


            }

            
            
        }
    }
}