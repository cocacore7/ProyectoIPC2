using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto1IPC2
{
    public partial class SelecColor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void aceptar_Click(object sender, EventArgs e)
        {
            string color = Color.SelectedItem.ToString();
            if (color.Equals("Seleccionar Partida"))
            {
                Cuerpo.Text = "Por favor, Seleccione una partida";
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ventana,", "$('#ventana').modal();", true);
                panelModal.Update();
            }
            else if (color.Equals("Negro"))
            {
                Tablero.colorJ = "negro";
                Response.Redirect("Tablero.aspx");
            }
            else
            {
                Tablero.colorJ = "blanco";
                Response.Redirect("Tablero.aspx");
            }
        }

        protected void regresar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int color = rnd.Next(0, 1);
            if (color == 0)
            {
                Tablero.colorJ = "negro";
            }
            else {
                Tablero.colorJ = "blanco";
            }
            Response.Redirect("Tablero.aspx");
        }
    }
}