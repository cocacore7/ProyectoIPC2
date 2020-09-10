using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto1IPC2
{
    public partial class MenuPrincipal : Page
    {
        public static string[] colores = new string[64];
        public static string[] colum = new string[64];
        public static string[] fila = new string[64];
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void maquina_Click(object sender, EventArgs e)
        {
            
            Tablero.color = "negro";
            Tablero.partida = "Solitario";
            for (int i = 0; i <= 63; i++)
            {
                colores[i] = ".";
                colum[i] = ".";
                fila[i] = ".";
            }
            colores[27] = "blanco";
            colum[27] = "D";
            fila[27] = "4";
            colores[28] = "negro";
            colum[28] = "E";
            fila[28] = "4";
            colores[35] = "negro";
            colum[35] = "D";
            fila[35] = "5";
            colores[36] = "blanco";
            colum[36] = "E";
            fila[36] = "5";
            Response.Redirect("Tablero.aspx");
        }

        protected void versus_Click(object sender, EventArgs e)
        {
            Tablero.color = "negro";
            Tablero.partida = "Versus";
            for (int i = 0; i <= 63; i++)
            {
                colores[i] = ".";
                colum[i] = ".";
                fila[i] = ".";
            }
            colores[27] = "blanco";
            colum[27] = "D";
            fila[27] = "4";
            colores[28] = "negro";
            colum[28] = "E";
            fila[28] = "4";
            colores[35] = "negro";
            colum[35] = "D";
            fila[35] = "5";
            colores[36] = "blanco";
            colum[36] = "E";
            fila[36] = "5";
            Response.Redirect("Tablero.aspx");
        }

        protected void cargar_Click(object sender, EventArgs e)
        {
            
        }
    }
}