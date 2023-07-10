using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Today : System.Web.UI.Page
{
    protected void OutputDay()
    {
        Response.Write(DateTime.Now.ToString("D"));
    }

}