﻿using System;

namespace BuildingMobileWebSites
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write(TextBox1a.Value);
        }
    }
}