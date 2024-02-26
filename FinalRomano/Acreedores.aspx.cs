using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalRomano
{
    public partial class Clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

        protected void actualizarLabel()
        {
            //Label2.Text = "";
            //DataView dv = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
            //foreach (DataRowView dr in dv)
            //{
            //    DataRow row = dr.Row;
            //    Label2.Text += row["nombreCategoria"].ToString() + " - ";

            //}
        }





        protected void Button2_Click(object sender, EventArgs e)  // insertar
        {
            int result = SqlDataSource1.Insert();
            if (result != 0)
            {
                Label4.Text = "Se ha agregado" + result.ToString() + " registros";
                //actualizarLabel();
                TextBox1.Text = "";
                TextBox2.Text = "";
            }
            else
            {
                Label1.Text = "NO se agregaron registros";
            }
        }

    }

}