using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto1IPC2
{
    public partial class SelecX : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void aceptar_Click(object sender, EventArgs e)
        {
            string col = color.SelectedItem.ToString();
            string mod = modo.SelectedItem.ToString();
            string tip = tipo.SelectedItem.ToString();
            if (col.Equals("Seleccionar Color") || mod.Equals("Seleccionar Modo De Juego") || tip.Equals("Seleccionar Tipo De Juego"))
            {
                Cuerpo.Text = "Por favor, Seleccione un Color, Modo y Tipo de juego disponible";
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ventana,", "$('#ventana').modal();", true);
                panelModal.Update();
            }
        }

        protected void regresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuPrincipal.aspx");
        }
    }
}