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
            if (!IsPostBack)
            {
                
                if (Session["ItemCount"] == null)
                {
                    Session["ItemCount"] = 0;
                }
            }

            string a = Convert.ToString(Session["items"]);
            if (string.IsNullOrEmpty(a))
            {
                Session["a"] = 0;
            }
            else
            {
                int c = Convert.ToInt32(Session["items"]);
                int d = Convert.ToInt32(Session["a"]);
                int cantItems = d + c;

                
                if (c > 0)
                {
                    if (Session["ItemCount"] != null)
                    {
                        int itemCount;
                        if (int.TryParse(Session["ItemCount"].ToString(), out itemCount))
                        {
                            itemCount += c;
                            Session["ItemCount"] = itemCount;
                        }
                        else
                        {
                            // Manejo del error de conversión
                        }
                    }
                    else
                    {
                        Session["ItemCount"] = c;
                    }
                    Session["items"] = 0;
                }

                LblItems.Text = Session["ItemCount"].ToString();
                Session["a"] = cantItems;
            }
        }
    }


}