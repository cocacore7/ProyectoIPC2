using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto1IPC2
{
    public partial class MenuPrincipal : Page
    {
        BaseDatos bd = new BaseDatos();
        public static string[] colores = new string[64];
        public static string[] colum = new string[64];
        public static string[] columaux = new string[64];
        public static string[] filaaux = new string[64];
        public static string[] colum2 = { "A", "B", "C", "D", "E", "F", "G", "H", "A", "B", "C", "D", "E", "F", "G", "H", "A", "B", "C", "D", "E", "F", "G", "H", "A", "B", "C", "D", "E", "F", "G", "H", "A", "B", "C", "D", "E", "F", "G", "H", "A", "B", "C", "D", "E", "F", "G", "H", "A", "B", "C", "D", "E", "F", "G", "H", "A", "B", "C", "D", "E", "F", "G", "H" };
        public static string[] fila2 = { "1", "1", "1", "1", "1", "1", "1", "1", "2","2", "2", "2", "2", "2", "2", "2", "3", "3", "3", "3", "3", "3", "3", "3", "4", "4", "4", "4", "4", "4", "4", "4", "5", "5", "5", "5", "5", "5", "5", "5", "6", "6", "6", "6", "6", "6", "6", "6", "7", "7", "7", "7", "7", "7", "7", "7", "8", "8", "8", "8", "8", "8", "8", "8" };
        public static string[] fila = new string[64];
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void maquina_Click(object sender, EventArgs e)
        {
            Tablero.mov = 4;
            Tablero.color = "negro";
            Tablero.partida = "Solitario";
            Tablero.bandera = false;
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
            Tablero.mov = 4;
            Tablero.color = "negro";
            Tablero.partida = "Versus";
            Tablero.bandera = false;
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
            columaux = colum2;
            filaaux = fila2;
            for (int i = 0; i <= 63; i++)
            {
                colores[i] = ".";
                colum[i] = ".";
                fila[i] = ".";
            }
            Response.Redirect("Cargar.aspx");
        }
    }
}