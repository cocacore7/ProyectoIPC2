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
            string modo = tipo.SelectedItem.ToString();
            Tablero.color = "negro";
            Tablero.carga = 0;
            Tablero.bandera = false;

            if (color.Equals("Seleccionar Color") || modo.Equals("Seleccionar Modo De Juego"))
            {
                Cuerpo.Text = "Por favor, Seleccione un Color y Modo disponible";
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ventana,", "$('#ventana').modal();", true);
                panelModal.Update();
            }
            else if (color.Equals("Negro"))
            {
                Tablero.colorJ = "negro";
                if (modo.Equals("Versus"))
                {
                    Tablero.partida = "Versus";
                    iniciar();
                }
                else if (modo.Equals("CPU")) {
                    Tablero.partida = "Maquina";
                    iniciar();
                }
            }
            else
            {
                Tablero.colorJ = "blanco";
                if (modo.Equals("Versus"))
                {
                    Tablero.partida = "Versus";
                    iniciar();
                }
                else if (modo.Equals("CPU"))
                {
                    Tablero.partida = "Maquina";
                    iniciar();
                }
            }
        }

        protected void regresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuPrincipal.aspx");
        }

        protected void Random_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int color = rnd.Next(0, 1);
            Tablero.color = "negro";
            Tablero.carga = 0;
            Tablero.bandera = false;
            if (color == 0)
            {
                Tablero.colorJ = "negro";
                Tablero.partida = "Versus";
                iniciar();
            }
            else
            {
                Tablero.colorJ = "blanco";
                Tablero.partida = "Maquina";
                iniciar();
            }
        }

        public void iniciar() {
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
            Response.Redirect("Tablero.aspx");
        }
    }
}