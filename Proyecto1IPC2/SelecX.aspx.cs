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
            TableroX.color = "negro";
            TableroX.carga = 0;
            TableroX.mov = 0;
            TableroX.movb = 0;
            TableroX.movn = 0;
            TableroX.bandera = false;
            if (col.Equals("Seleccionar Color") || mod.Equals("Seleccionar Modo De Juego") || tip.Equals("Seleccionar Tipo De Juego"))
            {
                Cuerpo.Text = "Por favor, Seleccione un Color, Modo y Tipo de juego disponible";
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ventana,", "$('#ventana').modal();", true);
                panelModal.Update();
            }
            else if (col.Equals("Negro"))
            {
                TableroX.tipo = tip;
                TableroX.colorJ = "negro";
                if (mod.Equals("Versus"))
                {
                    TableroX.partida = "Versus";
                    iniciar();
                }
                else if (mod.Equals("CPU"))
                {
                    TableroX.partida = "Maquina";
                    iniciar();
                }
            }
            else
            {
                TableroX.tipo = tip;
                TableroX.colorJ = "blanco";
                if (mod.Equals("Versus"))
                {
                    TableroX.partida = "Versus";
                    iniciar();
                }
                else if (mod.Equals("CPU"))
                {
                    TableroX.partida = "Maquina";
                    iniciar();
                }
            }
        }

        protected void regresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuPrincipal.aspx");
        }

        public void iniciar()
        {
            for (int i = 0; i <= 63; i++)
            {
                MenuPrincipal.colores[i] = ".";
                MenuPrincipal.colum[i] = ".";
                MenuPrincipal.fila[i] = ".";
            }
            MenuPrincipal.colores[27] = "blanco";
            MenuPrincipal.colum[27] = "D";
            MenuPrincipal.fila[27] = "4";
            MenuPrincipal.colores[28] = "negro";
            MenuPrincipal.colum[28] = "E";
            MenuPrincipal.fila[28] = "4";
            MenuPrincipal.colores[35] = "negro";
            MenuPrincipal.colum[35] = "D";
            MenuPrincipal.fila[35] = "5";
            MenuPrincipal.colores[36] = "blanco";
            MenuPrincipal.colum[36] = "E";
            MenuPrincipal.fila[36] = "5";
            MenuPrincipal.columaux = MenuPrincipal.colum2;
            MenuPrincipal.filaaux = MenuPrincipal.fila2;
            Response.Redirect("TableroX.aspx");
        }
    }
}