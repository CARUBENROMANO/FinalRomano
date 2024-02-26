using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalRomano
{
    public partial class Cobranzas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           TextBox3.Text = GridView1.SelectedRow.Cells[2].Text;
            TextBox3.Text = GridView1.SelectedRow.Cells[4].Text;
            DropDownList1.SelectedValue = GridView1.SelectedRow.Cells[3].Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            SqlDataSource1.InsertParameters["fecha"].DefaultValue = TextBox1.Text;
            SqlDataSource1.InsertParameters["monto"].DefaultValue = TextBox2.Text;
            
            SqlDataSource1.InsertParameters["id"].DefaultValue = DropDownList1.SelectedValue;
            //// profe esta ultima linea me salio mal""

            int result = SqlDataSource1.Insert();
            if (result > 0)
            {
                Label1.Text = "Agregado " + result.ToString() + " registro.";
                TextBox1.Text = string.Empty;
                TextBox2.Text = string.Empty;

            }
            else
            {
                Label1.Text = "No se agregaron registros.";
            }

        }

        protected void Button3_Click(object sender, EventArgs e)  // modificar 

        {

            SqlDataSource1.UpdateParameters["fecha"].DefaultValue = TextBox1.Text;
            SqlDataSource1.UpdateParameters["monto"].DefaultValue = TextBox2.Text;

            SqlDataSource1.UpdateParameters["id"].DefaultValue = DropDownList1.SelectedValue;

            int result = SqlDataSource1.Update();
            if (result != 0)
            {
                Label1.Text = "Se ha Modificado" + result.ToString() + " registros";

            }
            else
            {
                Label1.Text = "NO se Modificado los registros";
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int result = SqlDataSource1.Delete();
            if (result > 0)
            {
                Label2.Text = "Se ha eliminado" + result.ToString() + " registros";
               
                TextBox1.Text = "";
                
            }
            else
            {
                Label2.Text = "NO se Eliminaro los registros";
            }


        }
    }

}
    

