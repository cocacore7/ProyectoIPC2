using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
/*REFERENCIAS DE SITIOS
https://docs.microsoft.com/es-es/dotnet/api/system.web.ui.webcontrols.table?view=netframework-4.8
https://www.yunbitsoftware.com/blog/2017/12/14/selectores-y-pseudo-clases-css/
 
     */

namespace Proyecto1IPC2
{
    public partial class TableroX : System.Web.UI.Page
    {
        public static string nombre = "", modo = "", tipo = "", j1c1 = "", j1c2 = "", j1c3 = "", j1c4 = "", j1c5 = "", j2c1 = "", j2c2 = "", j2c3 = "", j2c4 = "", j2c5 = "", actual = "", j1 = "", j2 = "";
        public static int filas, columnas, posicion = 0;
        public static List<string> color1 = new List<string>(), color2 = new List<string>(), letras = new List<string>(), numeros = new List<string>();
        public static List<ImageButton> botones = new List<ImageButton>();
        public static bool turno = true, inicial = true, ini1 = false, ini2 = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (inicial) {
                Turno2.Enabled = false;
                Turno1.Enabled = false;
                Turno1.ImageUrl = actual + ".png";
                turno = false;
                inicial = false;
            }
            posicion = 0;
            int col, fil = 0;
            for (int i = 0; i < filas + 2; i++)
            {
                col = 0;
                TableRow row = new TableRow();
                for (int z = 0; z < columnas + 2; z++)
                {
                    if (i == 0 || i == filas + 1)
                    {
                        if (z != 0 && z != columnas + 1)
                        {
                            TableCell cell = new TableCell();
                            cell.Width = 60;
                            cell.Height = 60;
                            cell.CssClass = "columnaO";
                            cell.Text = Convert.ToString(letras[col]);
                            col++;
                            row.Cells.Add(cell);
                        }
                        else {
                            TableCell cell = new TableCell();
                            cell.Width = 60;
                            cell.Height = 60;
                            cell.CssClass = "columnaO";
                            row.Cells.Add(cell);
                        }
                    }
                    else {
                        if (z == 0 || z == columnas + 1)
                        {
                            TableCell cell = new TableCell();
                            cell.Width = 60;
                            cell.Height = 60;
                            cell.CssClass = "columnaO";
                            cell.Text = Convert.ToString(numeros[fil - 1]);
                            row.Cells.Add(cell);
                        }
                        else {
                            TableCell cell = new TableCell();
                            cell.Width = 60;
                            cell.Height = 60;
                            cell.CssClass = "columnaC";
                            botones[posicion].Click += new ImageClickEventHandler(Boton_Click);
                            cell.Controls.Add(botones[posicion]);
                            posicion++;
                            row.Cells.Add(cell);
                        }
                    }
                }
                fil++;
                Table1.Rows.Add(row);
            }
        }

        public void Boton_Click(Object sender, System.EventArgs e)
        {
            ImageButton bt = (ImageButton)sender;
            foreach (ImageButton i in botones) {
                if (i.ID.Equals(bt.ID)) {
                    i.ImageUrl = actual + ".png";
                    i.Enabled = false;
                    posicion = Convert.ToInt16(i.ID);
                }
            }
            cambiar();
        }

        public void cambiar() {
            if (j1.Equals("")) { j1 = j1c1; }
            if (j2.Equals("")) { j2 = j2c1; }
            if (ini1 && ini2)
            {
                if (turno)
                {
                    if (j1.Equals(j1c1))
                    {
                        if (!j1c2.Equals(""))
                        {
                            j1 = j1c2;
                        }
                    }
                    else if (j1.Equals(j1c2))
                    {
                        if (j1c3.Equals(""))
                        {
                            j1 = j1c1;
                        }
                        else { j1 = j1c3; }
                    }
                    else if (j1.Equals(j1c3))
                    {
                        if (j1c4.Equals(""))
                        {
                            j1 = j1c1;
                        }
                        else { j1 = j1c4; }
                    }
                    else if (j1.Equals(j1c4))
                    {
                        if (j1c5.Equals(""))
                        {
                            j1 = j1c1;
                        }
                        else { j1 = j1c5; }
                    }
                    else if (j1.Equals(j1c5))
                    {
                        j1 = j1c1;
                    }
                    actual = j1;
                    Turno1.ImageUrl = actual + ".png";
                    Turno2.ImageUrl = "vacio.png";
                    turno = false;
                }
                else
                {
                    if (j2.Equals(j2c1))
                    {
                        if (!j2c2.Equals(""))
                        {
                            j2 = j2c2;
                        }
                    }
                    else if (j2.Equals(j2c2))
                    {
                        if (j2c3.Equals(""))
                        {
                            j2 = j2c1;
                        }
                        else { j2 = j2c3; }
                    }
                    else if (j2.Equals(j2c3))
                    {
                        if (j2c4.Equals(""))
                        {
                            j2 = j2c1;
                        }
                        else { j2 = j2c4; }
                    }
                    else if (j2.Equals(j2c4))
                    {
                        if (j2c5.Equals(""))
                        {
                            j2 = j2c1;
                        }
                        else { j2 = j2c5; }
                    }
                    else if (j2.Equals(j2c5))
                    {
                        j2 = j2c1;
                    }
                    actual = j2;
                    Turno1.ImageUrl = "vacio.png";
                    Turno2.ImageUrl = actual + ".png";
                    turno = true;
                }
                for (int i = 0; i < botones.Count; i++) {
                    if (botones[i].ImageUrl.Equals("pivote.png")) {
                        botones[i].ImageUrl = "vacio.png";
                        botones[i].Enabled = false;
                    }
                }
            }
            else
            {
                if (turno)
                {
                    if (j1.Equals(j1c1))
                    {
                        if (j1c2.Equals(""))
                        {
                            ini1 = true;
                        }
                        else { j1 = j1c2; }
                    }
                    else if (j1.Equals(j1c2))
                    {
                        if (j1c3.Equals(""))
                        {
                            j1 = j1c1;
                            if (!j2c3.Equals("") && !ini1) { llenarInicial(); }
                            ini1 = true;
                        }
                        else { j1 = j1c3; llenarInicial(); }
                    }
                    else if (j1.Equals(j1c3))
                    {
                        if (j1c4.Equals(""))
                        {
                            j1 = j1c1;
                            ini1 = true;
                        }
                        else { j1 = j1c4; }
                    }
                    else if (j1.Equals(j1c4))
                    {
                        if (j1c5.Equals(""))
                        {
                            j1 = j1c1;
                            ini1 = true;
                        }
                        else { j1 = j1c5; }
                    }
                    else if (j1.Equals(j1c5))
                    {
                        j1 = j1c1;
                        ini2 = true;
                        ini1 = true;
                    }
                    actual = j1;
                    Turno1.ImageUrl = actual + ".png";
                    Turno2.ImageUrl = "vacio.png";
                    turno = false;
                }
                else
                {
                    if (j2.Equals(j2c1))
                    {
                        if (j2c2.Equals(""))
                        {
                            ini2 = true;
                        }
                        else { j2 = j2c2; }
                    }
                    else if (j2.Equals(j2c2))
                    {
                        if (j2c3.Equals(""))
                        {
                            j2 = j2c1;
                            ini2 = true;
                        }
                        else { j2 = j2c3; }
                    }
                    else if (j2.Equals(j2c3))
                    {
                        if (j2c4.Equals(""))
                        {
                            j2 = j2c1;
                            ini2 = true;
                        }
                        else
                        {
                            j2 = j2c4;
                        }
                    }
                    else if (j2.Equals(j2c4))
                    {
                        if (j2c5.Equals(""))
                        {
                            j2 = j2c1;
                            ini2 = true;
                        }
                        else { j2 = j2c5; }
                    }
                    else if (j2.Equals(j2c5))
                    {
                        j2 = j2c1;
                        ini2 = true;
                    }
                    actual = j2;
                    Turno1.ImageUrl = "vacio.png";
                    Turno2.ImageUrl = actual + ".png";
                    turno = true;
                }
            }
        }
        public void llenarInicial() {
            int filaux = 0, columaux = 0, posinicial = 0, posaux = 0, posfinal = 0;
            if (filas % 2 == 0)
            {
                filaux = filas / 2;
            }
            else
            {
                filaux = filas - 1; filaux = filaux / 2;
            }
            if (columnas % 2 == 0)
            {
                columaux = columnas / 2;
            }
            else
            {
                columaux = columnas - 1; columaux = columaux / 2;
            }
            if (filas % 2 == 0)
            {
                if (columnas % 2 == 0)
                {
                    posinicial = (filaux * columnas) - columaux - 2 - filas;
                }
                else { posinicial = (filaux * columnas) - columaux - 3 - filas; }
            }
            else
            {
                if (TableroX.columnas % 2 == 0)
                {
                    posinicial = (filaux * columnas) - columaux - 2 - filas;
                }
                else { posinicial = (filaux * columnas) - columaux - 3 - filas; }
            }
            botones[posinicial].ImageUrl = "pivote.png"; botones[posinicial].Enabled = true;
            botones[posinicial + 1].ImageUrl = "pivote.png"; botones[posinicial + 1].Enabled = true;
            botones[posinicial + 2].ImageUrl = "pivote.png"; botones[posinicial + 2].Enabled = true;
            botones[posinicial + 3].ImageUrl = "pivote.png"; botones[posinicial + 3].Enabled = true;
            botones[posinicial + filas].ImageUrl = "pivote.png"; botones[posinicial + filas].Enabled = true;
            botones[posinicial + filas + 3].ImageUrl = "pivote.png"; botones[posinicial + filas + 3].Enabled = true;
            botones[posinicial + filas + filas].ImageUrl = "pivote.png"; botones[posinicial + filas + filas].Enabled = true;
            botones[posinicial + filas + filas + 3].ImageUrl = "pivote.png"; botones[posinicial + filas + filas + 3].Enabled = true;
            botones[posinicial + filas + filas + filas].ImageUrl = "pivote.png"; botones[posinicial + filas + filas + filas].Enabled = true;
            botones[posinicial + filas + filas + filas + 1].ImageUrl = "pivote.png"; botones[posinicial + filas + filas + filas + 1].Enabled = true;
            botones[posinicial + filas + filas + filas + 2].ImageUrl = "pivote.png"; botones[posinicial + filas + filas + filas + 2].Enabled = true;
            botones[posinicial + filas + filas + filas + 3].ImageUrl = "pivote.png"; botones[posinicial + filas + filas + filas + 3].Enabled = true;
        }

        //Guardar Partidas
        protected void guardar_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuPrincipal.aspx");
        }
    }
}