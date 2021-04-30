using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AgendaWA
{
    public partial class Usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SqlDataSourceUsers_Inserted(object sender, SqlDataSourceStatusEventArgs e)
        {
            if (e.Exception != null)
            {
                LMsg.Text = "Inserido um registro duplicado ou com campos em branco.";
                e.ExceptionHandled = true;
            }
        }

        protected void SqlDataSourceUsers_Updated(object sender, SqlDataSourceStatusEventArgs e)
        {
            if (e.Exception != null)
            {
                LMsg.Text = "Alterando um registro sem informar todos os campos.";
                e.ExceptionHandled = true;
            }
        }
    }
}