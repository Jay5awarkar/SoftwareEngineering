﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Userhome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        label2.Text = Session["uname"].ToString();
    }
}