﻿using System;
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
             string cant =Convert.ToString(Session["items"]);
            LblItems.Text = cant;
        }
    }
}