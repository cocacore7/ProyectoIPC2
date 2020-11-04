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
        public static int ci1 = 0, ci2 = 0, ci3 = 0, ci4 = 0, ci5 = 0, ci6 = 0, ci7 = 0, ci8 = 0, ci9 = 0, ci10 = 0, ci11 = 0, ci12 = 0, ci13 = 0, ci14 = 0, ci15 = 0, cd1 = columnas - 1, cd2 = columnas - 1, cd3 = columnas - 1, cd4 = columnas - 1, cd5 = columnas - 1, cd6 = columnas - 1, cd7 = columnas - 1, cd8 = columnas - 1, cd9 = columnas - 1, cd10 = columnas - 1, cd11 = columnas - 1, cd12 = columnas - 1, cd13 = columnas - 1, cd14 = columnas - 1, cd15 = columnas - 1;
        public static int ar1 = 0, ar2 = 0, ar3 = 0, ar4 = 0, ar5 = 0, ar6 = 0, ar7 = 0, ar8 = 0, ar9 = 0, ar10 = 0, ar11 = 0, ar12, ar13 = 0, ar14 = 0, ar15 = 0, ab1 = (filas*columnas) - 1, ab2 = (filas * columnas) - 1, ab3 = (filas * columnas) - 1, ab4 = (filas * columnas) - 1, ab5 = (filas * columnas) - 1, ab6 = (filas * columnas) - 1, ab7 = (filas * columnas) - 1, ab8 = (filas * columnas) - 1, ab9 = (filas * columnas) - 1, ab10 = (filas * columnas) - 1, ab11 = (filas * columnas) - 1, ab12 = (filas * columnas) - 1, ab13 = (filas * columnas) - 1, ab14 = (filas * columnas) - 1, ab15 = (filas * columnas) - 1;
        public static List<string> color1 = new List<string>(), color2 = new List<string>(), letras = new List<string>(), numeros = new List<string>();
        public static List<ImageButton> botones = new List<ImageButton>();
        public static List<int> vueltas = new List<int>();
        public static bool turno = true, inicial = true, ini1 = false, ini2 = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (inicial) {
                Turno2.Enabled = false;
                Turno1.Enabled = false;
                Turno1.ImageUrl = actual + ".png";
                turno = false;
                inicial = false;
                ci1 = 0; ci2 = 0; ci3 = 0; ci4 = 0; ci5 = 0; ci6 = 0; ci7 = 0; ci8 = 0; ci9 = 0; ci10 = 0; ci11 = 0; ci12 = 0; ci13 = 0; ci14 = 0; ci15 = 0; cd1 = columnas - 1; cd2 = columnas - 1; cd3 = columnas - 1; cd4 = columnas - 1; cd5 = columnas - 1; cd6 = columnas - 1; cd7 = columnas - 1; cd8 = columnas - 1; cd9 = columnas - 1; cd10 = columnas - 1; cd11 = columnas - 1; cd12 = columnas - 1; cd13 = columnas - 1; cd14 = columnas - 1; cd15 = columnas - 1;
                ar1 = 0; ar2 = 0; ar3 = 0; ar4 = 0; ar5 = 0; ar6 = 0; ar7 = 0; ar8 = 0; ar9 = 0; ar10 = 0; ar11 = 0; ar12 = 0; ar13 = 0; ar14 = 0; ar15 = 0; ab1 = (filas * columnas) - 1; ab2 = (filas * columnas) - 1; ab3 = (filas * columnas) - 1; ab4 = (filas * columnas) - 1; ab5 = (filas * columnas) - 1; ab6 = (filas * columnas) - 1; ab7 = (filas * columnas) - 1; ab8 = (filas * columnas) - 1; ab9 = (filas * columnas) - 1; ab10 = (filas * columnas) - 1; ab11 = (filas * columnas) - 1; ab12 = (filas * columnas) - 1; ab13 = (filas * columnas) - 1; ab14 = (filas * columnas) - 1; ab15 = (filas * columnas) - 1;
                int extra = 0;
                for (int i = 0; i < filas; i++) {
                    if (i == 0) { ci1 = 0; cd1 = columnas - 1; }
                    else if (i == 1) { ci2 = columnas; cd2 = (columnas * 2) - 1; }
                    else if (i == 2) { ci3 = columnas * 2; cd3 = (columnas * 3) - 1; }
                    else if (i == 3) { ci4 = columnas * 3; cd4 = (columnas * 4) - 1; }
                    else if (i == 4) { ci5 = columnas * 4; cd5 = (columnas * 5) - 1; }
                    else if (i == 5) { ci6 = columnas * 5; cd6 = (columnas * 6) - 1; }
                    else if (i == 6) { ci7 = columnas * 6; cd7 = (columnas * 7) - 1; }
                    else if (i == 7) { ci8 = columnas * 7; cd8 = (columnas * 8) - 1; }
                    else if (i == 8) { ci9 = columnas * 8; cd9 = (columnas * 9) - 1; }
                    else if (i == 9) { ci10 = columnas * 9; cd10 = (columnas * 10) - 1; }
                    else if (i == 10) { ci11 = columnas * 10; cd11 = (columnas * 11) - 1; }
                    else if (i == 11) { ci12 = columnas * 11; cd12 = (columnas * 12) - 1; }
                    else if (i == 12) { ci13 = columnas * 12; cd13 = (columnas * 13) - 1; }
                    else if (i == 13) { ci14 = columnas * 13; cd14 = (columnas * 14) - 1; }
                    else if (i == 14) { ci15 = columnas * 14; cd15 = (columnas * 15) - 1; }
                }
                extra = (filas * columnas) - columnas;
                for (int i = 0; i < columnas; i++)
                {
                    if (i == 0) { ar1 = 0; ab1 = extra; }
                    else if (i == 1) { ar2 = i; ab2 = extra + i; }
                    else if (i == 2) { ar3 = i; ab3 = extra + i; }
                    else if (i == 3) { ar4 = i; ab4 = extra + i; }
                    else if (i == 4) { ar5 = i; ab5 = extra + i; }
                    else if (i == 5) { ar6 = i; ab6 = extra + i; }
                    else if (i == 6) { ar7 = i; ab7 = extra + i; }
                    else if (i == 7) { ar8 = i; ab8 = extra + i; }
                    else if (i == 8) { ar9 = i; ab9 = extra + i; }
                    else if (i == 9) { ar10 = i; ab10 = extra + i; }
                    else if (i == 10) { ar11 = i; ab11 = extra + i; }
                    else if (i == 11) { ar12 = i; ab12 = extra + i; }
                    else if (i == 12) { ar13 = i; ab13 = extra + i; }
                    else if (i == 13) { ar14 = i; ab14 = extra + i; }
                    else if (i == 14) { ar15 = i; ab15 = extra + i; }
                }
                if (ini1 && ini2) { pivotes(); }
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
                    if (ini1 && ini2)
                    {
                        voltear(posicion);
                    }
                }
            }
            cambiar();
            if (ini1 && ini2)
            {
                pivotes();
            }
        }

        //Voltear Fichas
        public void voltear(int i) {
            int posaux = 0, izaux = 0, deraux = 0, ariz1 = 0, ariz2 = 0, arder1 = 0, arder2 = 0, abiz1 = 0, abiz2 = 0, abder1 = 0, abder2 = 0;
            int resta1 = 0, resta2 = 0, resta3 = 0, contador1 = 0, contador2 = 0;
            bool turno = false, bandera = false;
            List<int> obtener = new List<int>();
            vueltas = new List<int>();

            if (actual.Equals(j1c1) || actual.Equals(j1c2) || actual.Equals(j1c3) || actual.Equals(j1c4) || actual.Equals(j1c5)) { turno = true; } else { turno = false; }
            if (turno)
            {
                if (botones[i].ImageUrl.Equals(j1c1 + ".png") || botones[i].ImageUrl.Equals(j1c2 + ".png") || botones[i].ImageUrl.Equals(j1c3 + ".png") || botones[i].ImageUrl.Equals(j1c4 + ".png") || botones[i].ImageUrl.Equals(j1c5 + ".png"))
                {
                    posaux = i; int paso = 0; resta1 = 0; resta2 = 0; resta3 = 0; contador1 = 0; contador2 = 0;
                    while (posaux > columnas) // Obtener Posiciones Iniciales Arriba
                    {
                        posaux = posaux - columnas;
                        resta2 = resta2 + columnas;
                        contador1 = contador1 + 1;
                    }

                    resta1 = posaux * columnas;
                    deraux = columnas - posaux; izaux = columnas - deraux; posaux = i;
                    ariz1 = posaux - izaux - resta1; arder1 = posaux + deraux - resta1 - 1; ariz2 = posaux - resta2 - contador1; arder2 = posaux - resta2 + contador1;
                    while (posaux <= (filas * columnas) - columnas) //Obtener Posiciones Iniciales Abajo
                    {
                        posaux = posaux + columnas;
                        resta3 = resta3 + columnas;
                        contador2 = contador2 + 1;
                    }

                    posaux = i; obtener.Clear(); bandera = false;
                    abiz1 = posaux - izaux + resta1; abder1 = posaux + deraux + resta1 + columnas - 1; abiz2 = posaux + resta3 - contador2; abder2 = posaux + resta3 + contador2;
                    while (posaux > columnas) //Pivotear Arriba J1
                    {
                        if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                        {
                            if (posaux == ar1 || posaux == ar2 || posaux == ar3 || posaux == ar4 || posaux == ar5 || posaux == ar6 || posaux == ar7 || posaux == ar8 || posaux == ar9 || posaux == ar10 || posaux == ar11 || posaux == ar12 || posaux == ar13 || posaux == ar14 || posaux == ar15) { obtener.Clear(); bandera = false; break; } else { obtener.Add(posaux); bandera = true; }
                        }
                        else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                        {
                            if (paso == 0) { paso = 1; obtener.Add(posaux); } else { if (bandera) { obtener.Add(posaux); bandera = false; break; } else { obtener.Clear(); break; } }
                        }
                        else if (botones[posaux].ImageUrl.Equals("pivote.png")) { obtener.Clear(); break; }
                        else if (botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); break; }
                        posaux = posaux - columnas;
                    }
                    if (posaux < filas * columnas) { if (botones[posaux].ImageUrl.Equals("pivote.png") || botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); } } else { obtener.Clear(); }
                    foreach (int z in obtener) { vueltas.Add(z); }

                    posaux = i; paso = 0; obtener.Clear(); bandera = false;
                    while (posaux < (filas * columnas) - columnas) //Pivotear Abajo J1
                    {
                        if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                        {
                            if (posaux == ab1 || posaux == ab3 || posaux == ab4 || posaux == ab5 || posaux == ab6 || posaux == ab7 || posaux == ab8 || posaux == ab9 || posaux == ab10 || posaux == ab11 || posaux == ab12 || posaux == ab13 || posaux == ab14 || posaux == ab15) { obtener.Clear(); bandera = false; break; } else { obtener.Add(posaux); bandera = true; }
                        }
                        else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                        {
                            if (paso == 0) { paso = 1; obtener.Add(posaux); } else { if (bandera) { obtener.Add(posaux); bandera = false; break; } else { obtener.Clear(); break; } }
                        }
                        else if (botones[posaux].ImageUrl.Equals("pivote.png")) { obtener.Clear(); break; }
                        else if (botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); break; }
                        posaux = posaux + columnas;
                    }
                    if (posaux < filas * columnas) { if (botones[posaux].ImageUrl.Equals("pivote.png") || botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); } } else { obtener.Clear(); }
                    foreach (int z in obtener) { vueltas.Add(z); }

                    posaux = i; paso = 0; obtener.Clear(); bandera = false;
                    while (posaux > i - izaux) // Pivotear Izquierda J1
                    {
                        if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                        {
                            if (posaux == ci1 || posaux == ci2 || posaux == ci3 || posaux == ci4 || posaux == ci5 || posaux == ci6 || posaux == ci7 || posaux == ci8 || posaux == ci9 || posaux == ci10 || posaux == ci11 || posaux == ci12 || posaux == ci13 || posaux == ci14 || posaux == ci15) { obtener.Clear(); bandera = false; break; } else { obtener.Add(posaux); bandera = true; }
                        }
                        else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                        {
                            if (paso == 0) { paso = 1; obtener.Add(posaux); } else { if (bandera) { obtener.Add(posaux); bandera = false; break; } else { obtener.Clear(); break; } }
                        }
                        else if (botones[posaux].ImageUrl.Equals("pivote.png")) { obtener.Clear(); break; }
                        else if (botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); break; }
                        posaux = posaux - 1;
                    }
                    if (posaux < filas * columnas) { if (botones[posaux].ImageUrl.Equals("pivote.png") || botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); } } else { obtener.Clear(); }
                    foreach (int z in obtener) { vueltas.Add(z); }

                    posaux = i; paso = 0; obtener.Clear(); bandera = false;
                    if (posaux == ci1 || posaux == ci2 || posaux == ci3 || posaux == ci4 || posaux == ci5 || posaux == ci6 || posaux == ci7 || posaux == ci8 || posaux == ci9 || posaux == ci10 || posaux == ci11 || posaux == ci12 || posaux == ci13 || posaux == ci14 || posaux == ci15)
                    {
                        while (posaux < i + deraux - 1 + columnas) // Pivotear Derecha J1
                        {
                            if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                            {
                                if (posaux == cd1 || posaux == cd2 || posaux == cd3 || posaux == cd4 || posaux == cd5 || posaux == cd6 || posaux == cd7 || posaux == cd8 || posaux == cd9 || posaux == cd10 || posaux == cd11 || posaux == cd12 || posaux == cd13 || posaux == cd14 || posaux == cd15) { obtener.Clear(); bandera = false; break; } else { obtener.Add(posaux); bandera = true; }
                            }
                            else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                            {
                                if (paso == 0) { paso = 1; obtener.Add(posaux); } else { if (bandera) { obtener.Add(posaux); bandera = false; break; } else { obtener.Clear(); break; } }
                            }
                            else if (botones[posaux].ImageUrl.Equals("pivote.png")) { obtener.Clear(); break; }
                            else if (botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); break; }
                            posaux = posaux + 1;
                        }
                        if (posaux < filas * columnas) { if (botones[posaux].ImageUrl.Equals("pivote.png") || botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); } } else { obtener.Clear(); }
                    }
                    else {
                        while (posaux < i + deraux - 1) // Pivotear Derecha J1
                        {
                            if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                            {
                                if (posaux == cd1 || posaux == cd2 || posaux == cd3 || posaux == cd4 || posaux == cd5 || posaux == cd6 || posaux == cd7 || posaux == cd8 || posaux == cd9 || posaux == cd10 || posaux == cd11 || posaux == cd12 || posaux == cd13 || posaux == cd14 || posaux == cd15) { obtener.Clear(); bandera = false; break; } else { obtener.Add(posaux); bandera = true; }
                            }
                            else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                            {
                                if (paso == 0) { paso = 1; obtener.Add(posaux); } else { if (bandera) { obtener.Add(posaux); bandera = false; break; } else { obtener.Clear(); break; } }
                            }
                            else if (botones[posaux].ImageUrl.Equals("pivote.png")) { obtener.Clear(); break; }
                            else if (botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); break; }
                            posaux = posaux + 1;
                        }
                        if (posaux < filas * columnas) { if (botones[posaux].ImageUrl.Equals("pivote.png") || botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); } } else { obtener.Clear(); }
                    }
                    foreach (int z in obtener) { vueltas.Add(z); }

                    posaux = i; paso = 0; obtener.Clear(); bandera = false;
                    while (posaux != ariz1 && posaux != ariz2) // Pivtear Arriba Izquierda J2
                    {
                        if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                        {
                            if (posaux == ar1 || posaux == ar2 || posaux == ar3 || posaux == ar4 || posaux == ar5 || posaux == ar6 || posaux == ar7 || posaux == ar8 || posaux == ar9 || posaux == ar10 || posaux == ar11 || posaux == ar12 || posaux == ar13 || posaux == ar14 || posaux == ar15 || posaux == ci1 || posaux == ci2 || posaux == ci3 || posaux == ci4 || posaux == ci5 || posaux == ci6 || posaux == ci7 || posaux == ci8 || posaux == ci9 || posaux == ci10 || posaux == ci11 || posaux == ci12 || posaux == ci13 || posaux == ci14 || posaux == ci15) { obtener.Clear(); bandera = false; break; } else { obtener.Add(posaux); bandera = true; }
                        }
                        else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                        {
                            if (paso == 0) { paso = 1; obtener.Add(posaux); } else { if (bandera) { obtener.Add(posaux); bandera = false; break; } else { obtener.Clear(); break; } }
                        }
                        else if (botones[posaux].ImageUrl.Equals("pivote.png")) { obtener.Clear(); break; }
                        else if (botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); break; }
                        posaux = posaux - columnas - 1;
                    }
                    if (posaux < filas * columnas) { if (botones[posaux].ImageUrl.Equals("pivote.png") || botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); } } else { obtener.Clear(); }
                    foreach (int z in obtener) { vueltas.Add(z); }

                    posaux = i; paso = 0; obtener.Clear(); bandera = false;
                    while (posaux != arder1 && posaux != arder2) // Pivtear Arriba Derecha J2
                    {
                        if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                        {
                            if (posaux == ar1 || posaux == ar2 || posaux == ar3 || posaux == ar4 || posaux == ar5 || posaux == ar6 || posaux == ar7 || posaux == ar8 || posaux == ar9 || posaux == ar10 || posaux == ar11 || posaux == ar12 || posaux == ar13 || posaux == ar14 || posaux == ar15 || posaux == cd1 || posaux == cd2 || posaux == cd3 || posaux == cd4 || posaux == cd5 || posaux == cd6 || posaux == cd7 || posaux == cd8 || posaux == cd9 || posaux == cd10 || posaux == cd11 || posaux == cd12 || posaux == cd13 || posaux == cd14 || posaux == cd15) { obtener.Clear(); bandera = false; break; } else { obtener.Add(posaux); bandera = true; }
                        }
                        else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                        {
                            if (paso == 0) { paso = 1; obtener.Add(posaux); } else { if (bandera) { obtener.Add(posaux); bandera = false; break; } else { obtener.Clear(); break; } }
                        }
                        else if (botones[posaux].ImageUrl.Equals("pivote.png")) { obtener.Clear(); break; }
                        else if (botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); break; }
                        posaux = posaux - columnas + 1;
                    }
                    if (posaux < filas * columnas) { if (botones[posaux].ImageUrl.Equals("pivote.png") || botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); } } else { obtener.Clear(); }
                    foreach (int z in obtener) { vueltas.Add(z); }

                    posaux = i; paso = 0; obtener.Clear(); bandera = false;
                    while (posaux != abiz1 && posaux != abiz2) // Pivtear Abajo Izquierda J2
                    {
                        if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                        {
                            if (posaux == ab1 || posaux == ab2 || posaux == ab3 || posaux == ab4 || posaux == ab5 || posaux == ab6 || posaux == ab7 || posaux == ab8 || posaux == ab9 || posaux == ab10 || posaux == ab11 || posaux == ab12 || posaux == ab13 || posaux == ab14 || posaux == ab15 || posaux == ci1 || posaux == ci2 || posaux == ci3 || posaux == ci4 || posaux == ci5 || posaux == ci6 || posaux == ci7 || posaux == ci8 || posaux == ci9 || posaux == ci10 || posaux == ci11 || posaux == ci12 || posaux == ci13 || posaux == ci14 || posaux == ci15) { obtener.Clear(); bandera = false; break; } else { obtener.Add(posaux); bandera = true; }
                        }
                        else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                        {
                            if (paso == 0) { paso = 1; obtener.Add(posaux); } else { if (bandera) { obtener.Add(posaux); bandera = false; break; } else { obtener.Clear(); break; } }
                        }
                        else if (botones[posaux].ImageUrl.Equals("pivote.png")) { obtener.Clear(); break; }
                        else if (botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); break; }
                        posaux = posaux + columnas - 1;
                    }
                    if (posaux < filas * columnas) { if (botones[posaux].ImageUrl.Equals("pivote.png") || botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); } } else { obtener.Clear(); }
                    foreach (int z in obtener) { vueltas.Add(z); }

                    posaux = i; paso = 0; obtener.Clear(); bandera = false;
                    while (posaux != abder1 && posaux != abder2) // Pivtear Abajo Derecha J2
                    {
                        if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                        {
                            if (posaux == ab1 || posaux == ab2 || posaux == ab3 || posaux == ab4 || posaux == ab5 || posaux == ab6 || posaux == ab7 || posaux == ab8 || posaux == ab9 || posaux == ab10 || posaux == ab11 || posaux == ab12 || posaux == ab13 || posaux == ab14 || posaux == ab15 || posaux == cd1 || posaux == cd2 || posaux == cd3 || posaux == cd4 || posaux == cd5 || posaux == cd6 || posaux == cd7 || posaux == cd8 || posaux == cd9 || posaux == cd10 || posaux == cd11 || posaux == cd12 || posaux == cd13 || posaux == cd14 || posaux == cd15) { obtener.Clear(); bandera = false; break; } else { obtener.Add(posaux); bandera = true; }
                        }
                        else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                        {
                            if (paso == 0) { paso = 1; obtener.Add(posaux); } else { if (bandera) { obtener.Add(posaux); bandera = false; break; } else { obtener.Clear(); break; } }
                        }
                        else if (botones[posaux].ImageUrl.Equals("pivote.png")) { obtener.Clear(); break; }
                        else if (botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); break; }
                        posaux = posaux + columnas + 1;
                    }
                    if (posaux < filas * columnas) { if (botones[posaux].ImageUrl.Equals("pivote.png") || botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); } } else { obtener.Clear(); }
                    foreach (int z in obtener) { vueltas.Add(z); }

                    foreach (int z in vueltas) { botones[z].ImageUrl = actual + ".png"; }
                }
            }
            else
            {
                if (botones[i].ImageUrl.Equals(j2c1 + ".png") || botones[i].ImageUrl.Equals(j2c2 + ".png") || botones[i].ImageUrl.Equals(j2c3 + ".png") || botones[i].ImageUrl.Equals(j2c4 + ".png") || botones[i].ImageUrl.Equals(j2c5 + ".png"))
                {
                    posaux = i; int paso = 0; resta1 = 0; resta2 = 0; resta3 = 0; contador1 = 0; contador2 = 0;
                    while (posaux > columnas) // Obtener Posiciones Iniciales Arriba
                    {
                        posaux = posaux - columnas;
                        resta2 = resta2 + columnas;
                        contador1 = contador1 + 1;
                    }
                    resta1 = posaux * columnas;
                    deraux = columnas - posaux; izaux = columnas - deraux; posaux = i;
                    ariz1 = posaux - izaux - resta1; arder1 = posaux + deraux - resta1 - 1; ariz2 = posaux - resta2 - contador1; arder2 = posaux - resta2 + contador1;
                    while (posaux <= (filas * columnas) - columnas) //Obtener Posiciones Iniciales Abajo
                    {
                        posaux = posaux + columnas;
                        resta3 = resta3 + columnas;
                        contador2 = contador2 + 1;
                    }
                    posaux = i; obtener.Clear(); bandera = false;
                    abiz1 = posaux - izaux + resta1; abder1 = posaux + deraux + resta1 + columnas - 1; abiz2 = posaux + resta3 - contador2; abder2 = posaux + resta3 + contador2;
                    while (posaux > columnas)  //Pivotear Arriba J2
                    {
                        if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                        {
                            if (posaux == ar1 || posaux == ar2 || posaux == ar3 || posaux == ar4 || posaux == ar5 || posaux == ar6 || posaux == ar7 || posaux == ar8 || posaux == ar9 || posaux == ar10 || posaux == ar11 || posaux == ar12 || posaux == ar13 || posaux == ar14 || posaux == ar15) { obtener.Clear(); bandera = false; break; } else { obtener.Add(posaux); bandera = true; }
                        }
                        else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                        {
                            if (paso == 0) { paso = 1; obtener.Add(posaux); } else { if (bandera) { obtener.Add(posaux); bandera = false; break; } else { obtener.Clear(); break; } }
                        }
                        else if (botones[posaux].ImageUrl.Equals("pivote.png")) { obtener.Clear(); break; }
                        else if (botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); break; }
                        posaux = posaux - columnas;
                    }
                    if (posaux < filas * columnas) { if (botones[posaux].ImageUrl.Equals("pivote.png") || botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); } } else { obtener.Clear(); }
                    foreach (int z in obtener) { vueltas.Add(z); }

                    posaux = i; paso = 0; obtener.Clear(); bandera = false;
                    while (posaux < (filas * columnas) - columnas)  //Pivotear Abajo J2
                    {
                        if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                        {
                            if (posaux == ab1 || posaux == ab3 || posaux == ab4 || posaux == ab5 || posaux == ab6 || posaux == ab7 || posaux == ab8 || posaux == ab9 || posaux == ab10 || posaux == ab11 || posaux == ab12 || posaux == ab13 || posaux == ab14 || posaux == ab15) { obtener.Clear(); bandera = false; break; } else { obtener.Add(posaux); bandera = true; }
                        }
                        else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                        {
                            if (paso == 0) { paso = 1; obtener.Add(posaux); } else { if (bandera) { obtener.Add(posaux); bandera = false; break; } else { obtener.Clear(); break; } }
                        }
                        else if (botones[posaux].ImageUrl.Equals("pivote.png")) { obtener.Clear(); break; }
                        else if (botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); break; }
                        posaux = posaux + columnas;
                    }
                    if (posaux < filas * columnas) { if (botones[posaux].ImageUrl.Equals("pivote.png") || botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); } } else { obtener.Clear(); }
                    foreach (int z in obtener) { vueltas.Add(z); }

                    posaux = i; paso = 0; obtener.Clear(); bandera = false;
                    while (posaux > i - izaux) // Pvotear Izquierda J2
                    {
                        if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                        {
                            if (posaux == ci1 || posaux == ci2 || posaux == ci3 || posaux == ci4 || posaux == ci5 || posaux == ci6 || posaux == ci7 || posaux == ci8 || posaux == ci9 || posaux == ci10 || posaux == ci11 || posaux == ci12 || posaux == ci13 || posaux == ci14 || posaux == ci15) { obtener.Clear(); bandera = false; break; } else { obtener.Add(posaux); bandera = true; }
                        }
                        else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                        {
                            if (paso == 0) { paso = 1; obtener.Add(posaux); } else { if (bandera) { obtener.Add(posaux); bandera = false; break; } else { obtener.Clear(); break; } }
                        }
                        else if (botones[posaux].ImageUrl.Equals("pivote.png")) { obtener.Clear(); break; }
                        else if (botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); break; }
                        posaux = posaux - 1;
                    }
                    if (posaux < filas * columnas) { if (botones[posaux].ImageUrl.Equals("pivote.png") || botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); } } else { obtener.Clear(); }
                    foreach (int z in obtener) { vueltas.Add(z); }

                    posaux = i; paso = 0; obtener.Clear(); bandera = false;
                    if (posaux == ci1 || posaux == ci2 || posaux == ci3 || posaux == ci4 || posaux == ci5 || posaux == ci6 || posaux == ci7 || posaux == ci8 || posaux == ci9 || posaux == ci10 || posaux == ci11 || posaux == ci12 || posaux == ci13 || posaux == ci14 || posaux == ci15)
                    {
                        while (posaux < i + deraux - 1 + columnas) // Pivtear Derecha J2
                        {
                            if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                            {
                                if (posaux == cd1 || posaux == cd2 || posaux == cd3 || posaux == cd4 || posaux == cd5 || posaux == cd6 || posaux == cd7 || posaux == cd8 || posaux == cd9 || posaux == cd10 || posaux == cd11 || posaux == cd12 || posaux == cd13 || posaux == cd14 || posaux == cd15) { obtener.Clear(); bandera = false; break; } else { obtener.Add(posaux); bandera = true; }
                            }
                            else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                            {
                                if (paso == 0) { paso = 1; obtener.Add(posaux); } else { if (bandera) { obtener.Add(posaux); bandera = false; break; } else { obtener.Clear(); break; } }
                            }
                            else if (botones[posaux].ImageUrl.Equals("pivote.png")) { obtener.Clear(); break; }
                            else if (botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); break; }
                            posaux = posaux + 1;
                        }
                        if (posaux < filas * columnas) { if (botones[posaux].ImageUrl.Equals("pivote.png") || botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); } } else { obtener.Clear(); }
                    }
                    else {
                        while (posaux < i + deraux - 1) // Pivtear Derecha J2
                        {
                            if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                            {
                                if (posaux == cd1 || posaux == cd2 || posaux == cd3 || posaux == cd4 || posaux == cd5 || posaux == cd6 || posaux == cd7 || posaux == cd8 || posaux == cd9 || posaux == cd10 || posaux == cd11 || posaux == cd12 || posaux == cd13 || posaux == cd14 || posaux == cd15) { obtener.Clear(); bandera = false; break; } else { obtener.Add(posaux); bandera = true; }
                            }
                            else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                            {
                                if (paso == 0) { paso = 1; obtener.Add(posaux); } else { if (bandera) { obtener.Add(posaux); bandera = false; break; } else { obtener.Clear(); break; } }
                            }
                            else if (botones[posaux].ImageUrl.Equals("pivote.png")) { obtener.Clear(); break; }
                            else if (botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); break; }
                            posaux = posaux + 1;
                        }
                        if (posaux < filas * columnas) { if (botones[posaux].ImageUrl.Equals("pivote.png") || botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); } } else { obtener.Clear(); }
                    }
                    foreach (int z in obtener) { vueltas.Add(z); }

                    posaux = i; paso = 0; obtener.Clear(); bandera = false;
                    while (posaux != ariz1 && posaux != ariz2) // Pivtear Arriba Izquierda J2
                    {
                        if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                        {
                            if (posaux == ar1 || posaux == ar2 || posaux == ar3 || posaux == ar4 || posaux == ar5 || posaux == ar6 || posaux == ar7 || posaux == ar8 || posaux == ar9 || posaux == ar10 || posaux == ar11 || posaux == ar12 || posaux == ar13 || posaux == ar14 || posaux == ar15 || posaux == ci1 || posaux == ci2 || posaux == ci3 || posaux == ci4 || posaux == ci5 || posaux == ci6 || posaux == ci7 || posaux == ci8 || posaux == ci9 || posaux == ci10 || posaux == ci11 || posaux == ci12 || posaux == ci13 || posaux == ci14 || posaux == ci15) { obtener.Clear(); bandera = false; break; } else { obtener.Add(posaux); bandera = true; }
                        }
                        else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                        {
                            if (paso == 0) { paso = 1; obtener.Add(posaux); } else { if (bandera) { obtener.Add(posaux); bandera = false; break; } else { obtener.Clear(); break; } }
                        }
                        else if (botones[posaux].ImageUrl.Equals("pivote.png")) { obtener.Clear(); break; }
                        else if (botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); break; }
                        posaux = posaux - columnas - 1;
                    }
                    if (posaux < filas * columnas) { if (botones[posaux].ImageUrl.Equals("pivote.png") || botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); } } else { obtener.Clear(); }
                    foreach (int z in obtener) { vueltas.Add(z); }

                    posaux = i; paso = 0; obtener.Clear(); bandera = false;
                    while (posaux != arder1 && posaux != arder2) // Pivtear Arriba Derecha J2
                    {
                        if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                        {
                            if (posaux == ar1 || posaux == ar2 || posaux == ar3 || posaux == ar4 || posaux == ar5 || posaux == ar6 || posaux == ar7 || posaux == ar8 || posaux == ar9 || posaux == ar10 || posaux == ar11 || posaux == ar12 || posaux == ar13 || posaux == ar14 || posaux == ar15 || posaux == cd1 || posaux == cd2 || posaux == cd3 || posaux == cd4 || posaux == cd5 || posaux == cd6 || posaux == cd7 || posaux == cd8 || posaux == cd9 || posaux == cd10 || posaux == cd11 || posaux == cd12 || posaux == cd13 || posaux == cd14 || posaux == cd15) { obtener.Clear(); bandera = false; break; } else { obtener.Add(posaux); bandera = true; }
                        }
                        else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                        {
                            if (paso == 0) { paso = 1; obtener.Add(posaux); } else { if (bandera) { obtener.Add(posaux); bandera = false; break; } else { obtener.Clear(); break; } }
                        }
                        else if (botones[posaux].ImageUrl.Equals("pivote.png")) { obtener.Clear(); break; }
                        else if (botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); break; }
                        posaux = posaux - columnas + 1;
                    }
                    if (posaux < filas * columnas) { if (botones[posaux].ImageUrl.Equals("pivote.png") || botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); } } else { obtener.Clear(); }
                    foreach (int z in obtener) { vueltas.Add(z); }

                    posaux = i; paso = 0; obtener.Clear(); bandera = false;
                    while (posaux != abiz1 && posaux != abiz2) // Pivtear Abajo Izquierda J2
                    {
                        if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                        {
                            if (posaux == ab1 || posaux == ab2 || posaux == ab3 || posaux == ab4 || posaux == ab5 || posaux == ab6 || posaux == ab7 || posaux == ab8 || posaux == ab9 || posaux == ab10 || posaux == ab11 || posaux == ab12 || posaux == ab13 || posaux == ab14 || posaux == ab15 || posaux == ci1 || posaux == ci2 || posaux == ci3 || posaux == ci4 || posaux == ci5 || posaux == ci6 || posaux == ci7 || posaux == ci8 || posaux == ci9 || posaux == ci10 || posaux == ci11 || posaux == ci12 || posaux == ci13 || posaux == ci14 || posaux == ci15) { obtener.Clear(); bandera = false; break; } else { obtener.Add(posaux); bandera = true; }
                        }
                        else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                        {
                            if (paso == 0) { paso = 1; obtener.Add(posaux); } else { if (bandera) { obtener.Add(posaux); bandera = false; break; } else { obtener.Clear(); break; } }
                        }
                        else if (botones[posaux].ImageUrl.Equals("pivote.png")) { obtener.Clear(); break; }
                        else if (botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); break; }
                        posaux = posaux + columnas - 1;
                    }
                    if (posaux < filas * columnas) { if (botones[posaux].ImageUrl.Equals("pivote.png") || botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); } } else { obtener.Clear(); }
                    foreach (int z in obtener) { vueltas.Add(z); }

                    posaux = i; paso = 0; obtener.Clear(); bandera = false;
                    while (posaux != abder1 && posaux != abder2) // Pivtear Abajo Derecha J2
                    {
                        if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                        {
                            if (posaux == ab1 || posaux == ab2 || posaux == ab3 || posaux == ab4 || posaux == ab5 || posaux == ab6 || posaux == ab7 || posaux == ab8 || posaux == ab9 || posaux == ab10 || posaux == ab11 || posaux == ab12 || posaux == ab13 || posaux == ab14 || posaux == ab15 || posaux == cd1 || posaux == cd2 || posaux == cd3 || posaux == cd4 || posaux == cd5 || posaux == cd6 || posaux == cd7 || posaux == cd8 || posaux == cd9 || posaux == cd10 || posaux == cd11 || posaux == cd12 || posaux == cd13 || posaux == cd14 || posaux == cd15) { obtener.Clear(); bandera = false; break; } else { obtener.Add(posaux); bandera = true; }
                        }
                        else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                        {
                            if (paso == 0) { paso = 1; obtener.Add(posaux); } else { if (bandera) { obtener.Add(posaux); bandera = false; break; } else { obtener.Clear(); break; } }
                        }
                        else if (botones[posaux].ImageUrl.Equals("pivote.png")) { obtener.Clear(); break; }
                        else if (botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); break; }
                        posaux = posaux + columnas + 1;
                    }
                    if (posaux < filas * columnas) { if (botones[posaux].ImageUrl.Equals("pivote.png") || botones[posaux].ImageUrl.Equals("vacio.png")) { obtener.Clear(); } } else { obtener.Clear(); }
                    foreach (int z in obtener) { vueltas.Add(z); }

                    foreach (int z in vueltas) { botones[z].ImageUrl = actual + ".png"; }
                }
            }
        }
        //Verificar Funcionamiento

        //Cambiar de color para jugadores Y limpiar pivotes
        public void cambiar() {
            if (j1.Equals("")) { j1 = j1c1; }
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
                            if (j2c2.Equals("") && ini1) { ini2 = true; }
                            if (j2c3.Equals("") && ini1) { ini2 = true; }
                            if (j2c4.Equals("") && ini1) { ini2 = true; }
                            if (j2c5.Equals("") && ini1) { ini2 = true; }
                            if (!j2c5.Equals("") && ini1) { ini2 = true; }
                            ini1 = true;
                            actual = j1;
                            Turno1.ImageUrl = actual + ".png";
                            Turno2.ImageUrl = "vacio.png";
                            turno = false;
                        }
                        else {
                            j1 = j1c2; actual = j1;
                            Turno1.ImageUrl = actual + ".png";
                            Turno2.ImageUrl = "vacio.png";
                            turno = false;
                        }
                    }
                    else if (j1.Equals(j1c2))
                    {
                        if (j1c3.Equals(""))
                        {
                            j1 = j1c1;
                            if (j2c2.Equals("") && !ini1) { ini2 = true; }
                            if (j2c3.Equals("") && !ini1) { ini2 = true; }
                            ini1 = true;
                            actual = j1;
                            Turno1.ImageUrl = actual + ".png";
                            Turno2.ImageUrl = "vacio.png";
                            turno = false;
                        }
                        else {
                            j1 = j1c3; ini2 = true;
                            ini1 = true;
                            actual = j1;
                            Turno1.ImageUrl = actual + ".png";
                            Turno2.ImageUrl = "vacio.png";
                            turno = false;
                            pivotes();
                        }
                    }
                    
                }
                else
                {
                    if (j2.Equals("")) { j2 = j2c1; }
                    else if (j2.Equals(j2c1))
                    {
                        if (!j2c2.Equals("")) { j2 = j2c2; }
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
                    actual = j2;
                    Turno1.ImageUrl = "vacio.png";
                    Turno2.ImageUrl = actual + ".png";
                    turno = true;
                }
            }
        }

        //Insertar Pivotes
        public void pivotes() {
            int posaux = 0, izaux = 0, deraux = 0, ariz1 = 0, ariz2 = 0, arder1 = 0, arder2 = 0, abiz1 = 0, abiz2 = 0, abder1 = 0, abder2 = 0;
            int resta1 = 0, resta2 = 0, resta3 = 0, contador1 = 0, contador2 = 0;
            bool bandera = false, turno = false;

            if (actual.Equals(j1c1) || actual.Equals(j1c2) || actual.Equals(j1c3) || actual.Equals(j1c4) || actual.Equals(j1c5)) { turno = true; } else { turno = false; }
            for (int i = 0; i < botones.Count; i++) {
                if (turno)
                {
                    if (botones[i].ImageUrl.Equals(j1c1 + ".png") || botones[i].ImageUrl.Equals(j1c2 + ".png") || botones[i].ImageUrl.Equals(j1c3 + ".png") || botones[i].ImageUrl.Equals(j1c4 + ".png") || botones[i].ImageUrl.Equals(j1c5 + ".png"))
                    {
                        posaux = i; bandera = false; int paso = 0; resta1 = 0; resta2 = 0; resta3 = 0; contador1 = 0; contador2 = 0;
                        while (posaux > columnas) // Obtener Posiciones Iniciales Arriba
                        {
                            posaux = posaux - columnas;
                            resta2 = resta2 + columnas;
                            contador1 = contador1 + 1;
                        }

                        resta1 = posaux * columnas;
                        deraux = columnas - posaux; izaux = columnas - deraux; posaux = i; bandera = false;
                        ariz1 = posaux - izaux - resta1; arder1 = posaux + deraux - resta1 - 1; ariz2 = posaux - resta2 - contador1; arder2 = posaux - resta2 + contador1;
                        while (posaux <= (filas * columnas) - columnas) //Obtener Posiciones Iniciales Abajo
                        {
                            posaux = posaux + columnas;
                            resta3 = resta3 + columnas;
                            contador2 = contador2 + 1;
                        }

                        posaux = i; bandera = false;
                        abiz1 = posaux - izaux + resta1; abder1 = posaux + deraux + resta1 + columnas - 1; abiz2 = posaux + resta3 - contador2; abder2 = posaux + resta3 + contador2;
                        while (posaux > columnas) //Pivotear Arriba J1
                        {
                            if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                            {
                                bandera = true;
                            }
                            else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                            {
                                if (paso == 0) { paso = 1; } else { break; }
                            }
                            else if (botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                            else if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; break; } else { break; } }
                            posaux = posaux - columnas;
                        }
                        if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; } }

                        posaux = i; bandera = false; paso = 0;
                        while (posaux < (filas * columnas) - columnas) //Pivotear Abajo J1
                        {
                            if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                            {
                                bandera = true;
                            }
                            else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                            {
                                if (paso == 0) { paso = 1; } else { break; }
                            }
                            else if (botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                            else if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; break; } else { break; } }
                            posaux = posaux + columnas;
                        }
                        if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; } }

                        posaux = i; bandera = false; paso = 0;
                        while (posaux > i - izaux) // Pivotear Izquierda J1
                        {
                            if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                            {
                                bandera = true;
                            }
                            else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                            {
                                if (paso == 0) { paso = 1; } else { break; }
                            }
                            else if (botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                            else if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; break; } else { break; } }
                            posaux = posaux - 1;
                        }
                        if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; } }

                        posaux = i; bandera = false; paso = 0;
                        if (posaux == ci1 || posaux == ci2 || posaux == ci3 || posaux == ci4 || posaux == ci5 || posaux == ci6 || posaux == ci7 || posaux == ci8 || posaux == ci9 || posaux == ci10 || posaux == ci11 || posaux == ci12 || posaux == ci13 || posaux == ci14 || posaux == ci15)
                        {
                            while (posaux < i + deraux - 1 + columnas) // Pivotear Derecha J1
                            {
                                if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    bandera = true;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    if (paso == 0) { paso = 1; } else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; break; } else { break; } }
                                posaux = posaux + 1;
                            }
                            if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; } }
                        }
                        else {
                            while (posaux < i + deraux - 1) // Pivotear Derecha J1
                            {
                                if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    bandera = true;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    if (paso == 0) { paso = 1; } else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; break; } else { break; } }
                                posaux = posaux + 1;
                            }
                            if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; } }
                        }
                        

                        posaux = i; bandera = false; paso = 0;
                        while (posaux != ariz1 && posaux != ariz2) // Pivtear Arriba Izquierda J2
                        {
                            if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                            {
                                if (posaux == ar1 || posaux == ar2 || posaux == ar3 || posaux == ar4 || posaux == ar5 || posaux == ar6 || posaux == ar7 || posaux == ar8 || posaux == ar9 || posaux == ar10 || posaux == ar11 || posaux == ar12 || posaux == ar13 || posaux == ar14 || posaux == ar15 || posaux == ci1 || posaux == ci2 || posaux == ci3 || posaux == ci4 || posaux == ci5 || posaux == ci6 || posaux == ci7 || posaux == ci8 || posaux == ci9 || posaux == ci10 || posaux == ci11 || posaux == ci12 || posaux == ci13 || posaux == ci14 || posaux == ci15) { bandera = false; break; } else { bandera = true; }
                            }
                            else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                            {
                                if (paso == 0) { paso = 1; } else { break; }
                            }
                            else if (botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                            else if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; break; } else { break; } }
                            posaux = posaux - columnas - 1;
                        }
                        if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; } }

                        posaux = i; bandera = false; paso = 0;
                        while (posaux != arder1 && posaux != arder2) // Pivtear Arriba Derecha J2
                        {
                            if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                            {
                                if (posaux == ar1 || posaux == ar2 || posaux == ar3 || posaux == ar4 || posaux == ar5 || posaux == ar6 || posaux == ar7 || posaux == ar8 || posaux == ar9 || posaux == ar10 || posaux == ar11 || posaux == ar12 || posaux == ar13 || posaux == ar14 || posaux == ar15 || posaux == cd1 || posaux == cd2 || posaux == cd3 || posaux == cd4 || posaux == cd5 || posaux == cd6 || posaux == cd7 || posaux == cd8 || posaux == cd9 || posaux == cd10 || posaux == cd11 || posaux == cd12 || posaux == cd13 || posaux == cd14 || posaux == cd15) { bandera = false; break; } else { bandera = true; }
                            }
                            else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                            {
                                if (paso == 0) { paso = 1; } else { break; }
                            }
                            else if (botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                            else if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; break; } else { break; } }
                            posaux = posaux - columnas + 1;
                        }
                        if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; } }

                        posaux = i; bandera = false; paso = 0;
                        while (posaux != abiz1 && posaux != abiz2) // Pivtear Abajo Izquierda J2
                        {
                            if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                            {
                                if (posaux == ab1 || posaux == ab2 || posaux == ab3 || posaux == ab4 || posaux == ab5 || posaux == ab6 || posaux == ab7 || posaux == ab8 || posaux == ab9 || posaux == ab10 || posaux == ab11 || posaux == ab12 || posaux == ab13 || posaux == ab14 || posaux == ab15 || posaux == ci1 || posaux == ci2 || posaux == ci3 || posaux == ci4 || posaux == ci5 || posaux == ci6 || posaux == ci7 || posaux == ci8 || posaux == ci9 || posaux == ci10 || posaux == ci11 || posaux == ci12 || posaux == ci13 || posaux == ci14 || posaux == ci15) { bandera = false; break; } else { bandera = true; }
                            }
                            else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                            {
                                if (paso == 0) { paso = 1; } else { break; }
                            }
                            else if (botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                            else if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; break; } else { break; } }
                            posaux = posaux + columnas - 1;
                        }
                        if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; }}

                        posaux = i; bandera = false; paso = 0;
                        while (posaux != abder1 && posaux != abder2) // Pivtear Abajo Derecha J2
                        {
                            if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                            {
                                if (posaux == ab1 || posaux == ab2 || posaux == ab3 || posaux == ab4 || posaux == ab5 || posaux == ab6 || posaux == ab7 || posaux == ab8 || posaux == ab9 || posaux == ab10 || posaux == ab11 || posaux == ab12 || posaux == ab13 || posaux == ab14 || posaux == ab15 || posaux == cd1 || posaux == cd2 || posaux == cd3 || posaux == cd4 || posaux == cd5 || posaux == cd6 || posaux == cd7 || posaux == cd8 || posaux == cd9 || posaux == cd10 || posaux == cd11 || posaux == cd12 || posaux == cd13 || posaux == cd14 || posaux == cd15) { bandera = false; break; } else { bandera = true; }
                            }
                            else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                            {
                                if (paso == 0) { paso = 1; } else { break; }
                            }
                            else if (botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                            else if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; break; } else { break; } }
                            posaux = posaux + columnas + 1;
                        }
                        if (posaux < (filas * columnas)) { if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; } } }
                    }
                }
                else {
                    if (botones[i].ImageUrl.Equals(j2c1 + ".png") || botones[i].ImageUrl.Equals(j2c2 + ".png") || botones[i].ImageUrl.Equals(j2c3 + ".png") || botones[i].ImageUrl.Equals(j2c4 + ".png") || botones[i].ImageUrl.Equals(j2c5 + ".png"))
                    {
                        posaux = i; bandera = false; int paso = 0; resta1 = 0; resta2 = 0; resta3 = 0; contador1 = 0; contador2 = 0;
                        while (posaux > columnas) // Obtener Posiciones Iniciales Arriba
                        {
                            posaux = posaux - columnas;
                            resta2 = resta2 + columnas;
                            contador1 = contador1 + 1;
                        }
                        resta1 = posaux * columnas;
                        deraux = columnas - posaux; izaux = columnas - deraux; posaux = i; bandera = false;
                        ariz1 = posaux - izaux - resta1; arder1 = posaux + deraux - resta1 - 1; ariz2 = posaux - resta2 - contador1; arder2 = posaux - resta2 + contador1;
                        while (posaux <= (filas * columnas) - columnas) //Obtener Posiciones Iniciales Abajo
                        {
                            posaux = posaux + columnas;
                            resta3 = resta3 + columnas;
                            contador2 = contador2 + 1;
                        }
                        posaux = i; bandera = false;
                        abiz1 = posaux - izaux + resta1; abder1 = posaux + deraux + resta1 + columnas - 1; abiz2 = posaux + resta3 - contador2; abder2 = posaux + resta3 + contador2;
                        while (posaux > columnas)  //Pivotear Arriba J2
                        {
                            if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                            {
                                bandera = true;
                            }
                            else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                            {
                                if (paso == 0) { paso = 1; } else { break; }
                            }
                            else if (botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                            else if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; break; } else { break; } }
                            posaux = posaux - columnas;
                        }
                        if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; } }

                        posaux = i; bandera = false; paso = 0;
                        while (posaux < (filas * columnas) - columnas)  //Pivotear Abajo J2
                        {
                            if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                            {
                                bandera = true;
                            }
                            else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                            {
                                if (paso == 0) { paso = 1; } else { break; }
                            }
                            else if (botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                            else if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; break; } else { break; } }
                            posaux = posaux + columnas;
                        }
                        if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; } }

                        posaux = i; bandera = false; paso = 0;
                        while (posaux > i - izaux) // Pvotear Izquierda J2
                        {
                            if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                            {
                                bandera = true;
                            }
                            else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                            {
                                if (paso == 0) { paso = 1; } else { break; }
                            }
                            else if (botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                            else if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; break; } else { break; } }
                            posaux = posaux - 1;
                        }
                        if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; } }

                        posaux = i; bandera = false; paso = 0;
                        if (posaux == ci1 || posaux == ci2 || posaux == ci3 || posaux == ci4 || posaux == ci5 || posaux == ci6 || posaux == ci7 || posaux == ci8 || posaux == ci9 || posaux == ci10 || posaux == ci11 || posaux == ci12 || posaux == ci13 || posaux == ci14 || posaux == ci15)
                        {
                            while (posaux < i + deraux - 1 + columnas) // Pivtear Derecha J2
                            {
                                if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    bandera = true;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    if (paso == 0) { paso = 1; } else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; break; } else { break; } }
                                posaux = posaux + 1;
                            }
                            if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; } }
                        }
                        else {
                            while (posaux < i + deraux - 1) // Pivtear Derecha J2
                            {
                                if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    bandera = true;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    if (paso == 0) { paso = 1; } else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; break; } else { break; } }
                                posaux = posaux + 1;
                            }
                            if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; } }
                        }
                        

                        posaux = i; bandera = false; paso = 0;
                        while (posaux != ariz1 && posaux != ariz2) // Pivotear Arriba Izquierda J2
                        {
                            if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                            {
                                if (posaux == ar1 || posaux == ar2 || posaux == ar3 || posaux == ar4 || posaux == ar5 || posaux == ar6 || posaux == ar7 || posaux == ar8 || posaux == ar9 || posaux == ar10 || posaux == ar11 || posaux == ar12 || posaux == ar13 || posaux == ar14 || posaux == ar15 || posaux == ci1 || posaux == ci2 || posaux == ci3 || posaux == ci4 || posaux == ci5 || posaux == ci6 || posaux == ci7 || posaux == ci8 || posaux == ci9 || posaux == ci10 || posaux == ci11 || posaux == ci12 || posaux == ci13 || posaux == ci14 || posaux == ci15) { bandera = false; break; } else { bandera = true; }
                            }
                            else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                            {
                                if (paso == 0) { paso = 1; } else { break; }
                            }
                            else if (botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                            else if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; break; } else { break; } }
                            posaux = posaux - columnas - 1;
                        }
                        if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; } }

                        posaux = i; bandera = false; paso = 0;
                        while (posaux != arder1 && posaux != arder2) // Pivtear Arriba Derecha J2
                        {
                            if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                            {
                                if (posaux == ar1 || posaux == ar2 || posaux == ar3 || posaux == ar4 || posaux == ar5 || posaux == ar6 || posaux == ar7 || posaux == ar8 || posaux == ar9 || posaux == ar10 || posaux == ar11 || posaux == ar12 || posaux == ar13 || posaux == ar14 || posaux == ar15 || posaux == cd1 || posaux == cd2 || posaux == cd3 || posaux == cd4 || posaux == cd5 || posaux == cd6 || posaux == cd7 || posaux == cd8 || posaux == cd9 || posaux == cd10 || posaux == cd11 || posaux == cd12 || posaux == cd13 || posaux == cd14 || posaux == cd15) { bandera = false; break; } else { bandera = true; }
                            }
                            else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                            {
                                if (paso == 0) { paso = 1; } else { break; }
                            }
                            else if (botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                            else if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; break; } else { break; } }
                            posaux = posaux - columnas + 1;
                        }
                        if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; } }

                        posaux = i; bandera = false; paso = 0;
                        while (posaux != abiz1 && posaux != abiz2) // Pivtear Abajo Izquierda J2
                        {
                            if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                            {
                                if (posaux == ab1 || posaux == ab2 || posaux == ab3 || posaux == ab4 || posaux == ab5 || posaux == ab6 || posaux == ab7 || posaux == ab8 || posaux == ab9 || posaux == ab10 || posaux == ab11 || posaux == ab12 || posaux == ab13 || posaux == ab14 || posaux == ab15 || posaux == ci1 || posaux == ci2 || posaux == ci3 || posaux == ci4 || posaux == ci5 || posaux == ci6 || posaux == ci7 || posaux == ci8 || posaux == ci9 || posaux == ci10 || posaux == ci11 || posaux == ci12 || posaux == ci13 || posaux == ci14 || posaux == ci15) { bandera = false; break; } else { bandera = true; }
                            }
                            else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                            {
                                if (paso == 0) { paso = 1; } else { break; }
                            }
                            else if (botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                            else if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; break; } else { break; } }
                            posaux = posaux + columnas - 1;
                        }
                        if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; } }

                        posaux = i; bandera = false; paso = 0;
                        while (posaux != abder1 && posaux != abder2) // Pivtear Abajo Derecha J2
                        {
                            if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                            {
                                if (posaux == ab1 || posaux == ab2 || posaux == ab3 || posaux == ab4 || posaux == ab5 || posaux == ab6 || posaux == ab7 || posaux == ab8 || posaux == ab9 || posaux == ab10 || posaux == ab11 || posaux == ab12 || posaux == ab13 || posaux == ab14 || posaux == ab15 || posaux == cd1 || posaux == cd2 || posaux == cd3 || posaux == cd4 || posaux == cd5 || posaux == cd6 || posaux == cd7 || posaux == cd8 || posaux == cd9 || posaux == cd10 || posaux == cd11 || posaux == cd12 || posaux == cd13 || posaux == cd14 || posaux == cd15) { bandera = false; break; } else { bandera = true; }
                            }
                            else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                            {
                                if (paso == 0) { paso = 1; } else { break; }
                            }
                            else if (botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                            else if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; break; } else { break; } }
                            posaux = posaux + columnas + 1;
                        }
                        if (posaux < (filas * columnas)) { if (botones[posaux].ImageUrl.Equals("vacio.png")) { if (bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; } } }
                    }
                }
            }
        }
        //Verificar Funcionamiento

        //Guardar Partidas
        protected void guardar_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuPrincipal.aspx");
        }
    }
}