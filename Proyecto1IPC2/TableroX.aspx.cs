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
        public static string modo = "", tipo = "", j1c1 = "", j1c2 = "", j1c3 = "", j1c4 = "", j1c5 = "", j2c1 = "", j2c2 = "", j2c3 = "", j2c4 = "", j2c5 = "", actual = "", j1 = "", j2 = "", per, gamperem;
        public static int filas, columnas, posicion = 0, segundos1 = 0, segundos2 = 0, minutos1 = 0, minutos2 = 0, puntos1 = 0, puntos2 = 0;
        public static int ci1 = 0, ci2 = 0, ci3 = 0, ci4 = 0, ci5 = 0, ci6 = 0, ci7 = 0, ci8 = 0, ci9 = 0, ci10 = 0, ci11 = 0, ci12 = 0, ci13 = 0, ci14 = 0, ci15 = 0, cd1 = columnas - 1, cd2 = columnas - 1, cd3 = columnas - 1, cd4 = columnas - 1, cd5 = columnas - 1, cd6 = columnas - 1, cd7 = columnas - 1, cd8 = columnas - 1, cd9 = columnas - 1, cd10 = columnas - 1, cd11 = columnas - 1, cd12 = columnas - 1, cd13 = columnas - 1, cd14 = columnas - 1, cd15 = columnas - 1;
        public static int ar1 = 0, ar2 = 0, ar3 = 0, ar4 = 0, ar5 = 0, ar6 = 0, ar7 = 0, ar8 = 0, ar9 = 0, ar10 = 0, ar11 = 0, ar12, ar13 = 0, ar14 = 0, ar15 = 0, ab1 = (filas*columnas) - 1, ab2 = (filas * columnas) - 1, ab3 = (filas * columnas) - 1, ab4 = (filas * columnas) - 1, ab5 = (filas * columnas) - 1, ab6 = (filas * columnas) - 1, ab7 = (filas * columnas) - 1, ab8 = (filas * columnas) - 1, ab9 = (filas * columnas) - 1, ab10 = (filas * columnas) - 1, ab11 = (filas * columnas) - 1, ab12 = (filas * columnas) - 1, ab13 = (filas * columnas) - 1, ab14 = (filas * columnas) - 1, ab15 = (filas * columnas) - 1;
        public static List<string> color1 = new List<string>(), color2 = new List<string>(), letras = new List<string>(), numeros = new List<string>();
        public static List<ImageButton> botones = new List<ImageButton>();
        public static List<int> vueltas = new List<int>();
        public static List<int> pivoteM = new List<int>();
        public static List<int> tirosM = new List<int>();
        public static bool turno = true, inicial = true, ini1 = false, ini2 = false, entrada = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                segundos1 = 0;
                segundos2 = 0;
                minutos1 = 1;
                minutos2 = 1;
            }
            if (inicial) {
                Turno2.Enabled = false;
                Turno1.Enabled = false;
                if (actual.Equals(j1c1) || actual.Equals(j1c2) || actual.Equals(j1c3) || actual.Equals(j1c4) || actual.Equals(j1c5)) { Turno1.ImageUrl = actual + ".png"; turno = false; }
                else { Turno2.ImageUrl = actual + ".png"; turno = true; }
                inicial = false;
                ci1 = 0; ci2 = 0; ci3 = 0; ci4 = 0; ci5 = 0; ci6 = 0; ci7 = 0; ci8 = 0; ci9 = 0; ci10 = 0; ci11 = 0; ci12 = 0; ci13 = 0; ci14 = 0; ci15 = 0; cd1 = columnas - 1; cd2 = columnas - 1; cd3 = columnas - 1; cd4 = columnas - 1; cd5 = columnas - 1; cd6 = columnas - 1; cd7 = columnas - 1; cd8 = columnas - 1; cd9 = columnas - 1; cd10 = columnas - 1; cd11 = columnas - 1; cd12 = columnas - 1; cd13 = columnas - 1; cd14 = columnas - 1; cd15 = columnas - 1;
                ar1 = 0; ar2 = 0; ar3 = 0; ar4 = 0; ar5 = 0; ar6 = 0; ar7 = 0; ar8 = 0; ar9 = 0; ar10 = 0; ar11 = 0; ar12 = 0; ar13 = 0; ar14 = 0; ar15 = 0; ab1 = (filas * columnas) - 1; ab2 = (filas * columnas) - 1; ab3 = (filas * columnas) - 1; ab4 = (filas * columnas) - 1; ab5 = (filas * columnas) - 1; ab6 = (filas * columnas) - 1; ab7 = (filas * columnas) - 1; ab8 = (filas * columnas) - 1; ab9 = (filas * columnas) - 1; ab10 = (filas * columnas) - 1; ab11 = (filas * columnas) - 1; ab12 = (filas * columnas) - 1; ab13 = (filas * columnas) - 1; ab14 = (filas * columnas) - 1; ab15 = (filas * columnas) - 1;
                int extra = 0;
                for (int i = 0; i < filas; i++)
                {
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
                if (actual.Equals(j1c1) || actual.Equals(j1c2) || actual.Equals(j1c3) || actual.Equals(j1c4) || actual.Equals(j1c5)) { crono1(); } else { crono2(); }
                if (ini1 && ini2) { pivotes(); }
                Jug1.Text = "Jugador1";
                Jug2.Text = "Jugador2";
                puntos1 = 0;
                puntos2 = 0;
                foreach (ImageButton i in botones)
                {
                    if (i.ImageUrl.Equals(j1c1 + ".png") || i.ImageUrl.Equals(j1c2 + ".png") || i.ImageUrl.Equals(j1c3 + ".png") || i.ImageUrl.Equals(j1c4 + ".png") || i.ImageUrl.Equals(j1c5 + ".png")) { puntos1++; }
                    else if (i.ImageUrl.Equals(j2c1 + ".png") || i.ImageUrl.Equals(j2c2 + ".png") || i.ImageUrl.Equals(j2c3 + ".png") || i.ImageUrl.Equals(j2c4 + ".png") || i.ImageUrl.Equals(j2c5 + ".png")) { puntos2++; }
                }
                Pun1.Text = Convert.ToString(puntos1); Pun2.Text = Convert.ToString(puntos2);
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
                    if (ini1 && ini2) { voltear(posicion); }
                }
            }
            cambiar();
            if (actual.Equals(j1c1) || actual.Equals(j1c2) || actual.Equals(j1c3) || actual.Equals(j1c4) || actual.Equals(j1c5)) { crono1(); } else { crono2(); }
            puntos1 = 0; puntos2 = 0;
            foreach (ImageButton boton in botones)
            {
                if (boton.ImageUrl.Equals(j1c1 + ".png") || boton.ImageUrl.Equals(j1c2 + ".png") || boton.ImageUrl.Equals(j1c3 + ".png") || boton.ImageUrl.Equals(j1c4 + ".png") || boton.ImageUrl.Equals(j1c5 + ".png"))
                {
                    puntos1++;
                }
                else if (boton.ImageUrl.Equals(j2c1 + ".png") || boton.ImageUrl.Equals(j2c2 + ".png") || boton.ImageUrl.Equals(j2c3 + ".png") || boton.ImageUrl.Equals(j2c4 + ".png") || boton.ImageUrl.Equals(j2c5 + ".png"))
                {
                    puntos2++;
                }
            }
            Pun1.Text = "Puntos: " + Convert.ToString(puntos1);
            Pun2.Text = "Puntos: " + Convert.ToString(puntos2);
            if (ini1 && ini2) { pivotes(); siguiente(); if (modo.Equals("CPU") && entrada) { Maquina(); } if (per.Equals("Si")) { entrada = true; } }
        }
        
        //Maquina
        public void Maquina()
        {
            pivoteM.Clear();
            foreach (ImageButton boton in botones)
            {
                if(boton.ImageUrl.Equals("pivote.png"))
                {
                    pivoteM.Add(Convert.ToInt32(boton.ID));
                }
            }
            siguienteM(pivoteM);
            cambiar();
            pivotes();
        }
        
        //Tiro o Saltar Turno Maquina
        public void siguienteM(List<int> pivotes)
        {
            tirosM.Clear();
            if (pivotes.Count != 0)
            {
                foreach (int i in pivotes)
                {
                    int cantidad = 0;
                    if (actual.Equals(j1c1) || actual.Equals(j1c2) || actual.Equals(j1c3) || actual.Equals(j1c4) || actual.Equals(j1c5))
                    {
                        //Pivotear Arriba J1
                        int posaux = i; bool bandera = true;
                        while (bandera)
                        {
                            posaux = posaux - columnas;
                            if (posaux >= 0)
                            {
                                if (posaux == ar1 || posaux == ar2 || posaux == ar3 || posaux == ar4 || posaux == ar5 || posaux == ar6 || posaux == ar7 || posaux == ar8 || posaux == ar9 || posaux == ar10 || posaux == ar11 || posaux == ar12 || posaux == ar13 || posaux == ar14 || posaux == ar15)
                                {
                                    if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                    {
                                        break;
                                    }
                                    else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    break;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    cantidad++;
                                }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") || botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                            }
                            else { break; }
                        }

                        //Pivotear Abajo J1
                        posaux = i;
                        while (bandera)
                        {
                            posaux = posaux + columnas;
                            if (posaux < columnas * filas)
                            {
                                if (posaux == ab1 || posaux == ab2 || posaux == ab3 || posaux == ab4 || posaux == ab5 || posaux == ab6 || posaux == ab7 || posaux == ab8 || posaux == ab9 || posaux == ab10 || posaux == ab11 || posaux == ab12 || posaux == ab13 || posaux == ab14 || posaux == ab15)
                                {
                                    if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                    {
                                        break;
                                    }
                                    else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    break;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    cantidad++;
                                }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") || botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                            }
                            else { break; }
                        }

                        // Pivotear Izquierda J1
                        posaux = i;
                        while (bandera)
                        {
                            posaux = posaux - 1;
                            if (posaux >= 0)
                            {
                                if (posaux == ci1 || posaux == ci2 || posaux == ci3 || posaux == ci4 || posaux == ci5 || posaux == ci6 || posaux == ci7 || posaux == ci8 || posaux == ci9 || posaux == ci10 || posaux == ci11 || posaux == ci12 || posaux == ci13 || posaux == ci14 || posaux == ci15)
                                {
                                    if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                    {
                                        break;
                                    }
                                    else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    break;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    cantidad++;
                                }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") || botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                            }
                            else { break; }
                        }

                        // Pivotear Derecha J1
                        posaux = i;
                        while (bandera)
                        {
                            posaux = posaux + 1;
                            if (posaux < filas * columnas)
                            {
                                if (posaux == cd1 || posaux == cd2 || posaux == cd3 || posaux == cd4 || posaux == cd5 || posaux == cd6 || posaux == cd7 || posaux == cd8 || posaux == cd9 || posaux == cd10 || posaux == cd11 || posaux == cd12 || posaux == cd13 || posaux == cd14 || posaux == cd15)
                                {
                                    if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                    {
                                        break;
                                    }
                                    else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    break;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    cantidad++;
                                }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") || botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                            }
                            else { break; }
                        }

                        // Pivtear Arriba Izquierda J1
                        posaux = i;
                        while (bandera)
                        {
                            posaux = posaux - columnas - 1;
                            if (posaux >= 0)
                            {
                                if (posaux == ar1 || posaux == ar2 || posaux == ar3 || posaux == ar4 || posaux == ar5 || posaux == ar6 || posaux == ar7 || posaux == ar8 || posaux == ar9 || posaux == ar10 || posaux == ar11 || posaux == ar12 || posaux == ar13 || posaux == ar14 || posaux == ar15 || posaux == ci1 || posaux == ci2 || posaux == ci3 || posaux == ci4 || posaux == ci5 || posaux == ci6 || posaux == ci7 || posaux == ci8 || posaux == ci9 || posaux == ci10 || posaux == ci11 || posaux == ci12 || posaux == ci13 || posaux == ci14 || posaux == ci15)
                                {
                                    if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                    {
                                        break;
                                    }
                                    else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    break;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    cantidad++;
                                }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") || botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                            }
                            else { break; }
                        }

                        // Pivtear Arriba Derecha J1
                        posaux = i; vueltas.Clear();
                        while (bandera)
                        {
                            posaux = posaux - columnas + 1;
                            if (posaux >= 0)
                            {
                                if (posaux == ar1 || posaux == ar2 || posaux == ar3 || posaux == ar4 || posaux == ar5 || posaux == ar6 || posaux == ar7 || posaux == ar8 || posaux == ar9 || posaux == ar10 || posaux == ar11 || posaux == ar12 || posaux == ar13 || posaux == ar14 || posaux == ar15 || posaux == cd1 || posaux == cd2 || posaux == cd3 || posaux == cd4 || posaux == cd5 || posaux == cd6 || posaux == cd7 || posaux == cd8 || posaux == cd9 || posaux == cd10 || posaux == cd11 || posaux == cd12 || posaux == cd13 || posaux == cd14 || posaux == cd15)
                                {
                                    if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                    {
                                        break;
                                    }
                                    else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    break;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    cantidad++;
                                }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") || botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                            }
                            else { break; }
                        }

                        // Pivtear Abajo Izquierda J1
                        posaux = i; vueltas.Clear();
                        while (bandera)
                        {
                            posaux = posaux + columnas - 1;
                            if (posaux < filas * columnas)
                            {
                                if (posaux == ab1 || posaux == ab2 || posaux == ab3 || posaux == ab4 || posaux == ab5 || posaux == ab6 || posaux == ab7 || posaux == ab8 || posaux == ab9 || posaux == ab10 || posaux == ab11 || posaux == ab12 || posaux == ab13 || posaux == ab14 || posaux == ab15 || posaux == ci1 || posaux == ci2 || posaux == ci3 || posaux == ci4 || posaux == ci5 || posaux == ci6 || posaux == ci7 || posaux == ci8 || posaux == ci9 || posaux == ci10 || posaux == ci11 || posaux == ci12 || posaux == ci13 || posaux == ci14 || posaux == ci15)
                                {
                                    if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                    {
                                        break;
                                    }
                                    else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                   break;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    cantidad++;
                                }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") || botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                            }
                            else { break; }
                        }

                        // Pivotear Abajo Derecha J1
                        posaux = i; vueltas.Clear();
                        while (bandera)
                        {
                            posaux = posaux + columnas + 1;
                            if (posaux < filas * columnas)
                            {
                                if (posaux == ab1 || posaux == ab2 || posaux == ab3 || posaux == ab4 || posaux == ab5 || posaux == ab6 || posaux == ab7 || posaux == ab8 || posaux == ab9 || posaux == ab10 || posaux == ab11 || posaux == ab12 || posaux == ab13 || posaux == ab14 || posaux == ab15 || posaux == cd1 || posaux == cd2 || posaux == cd3 || posaux == cd4 || posaux == cd5 || posaux == cd6 || posaux == cd7 || posaux == cd8 || posaux == cd9 || posaux == cd10 || posaux == cd11 || posaux == cd12 || posaux == cd13 || posaux == cd14 || posaux == cd15)
                                {
                                    if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                    {
                                        break;
                                    }
                                    else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    break;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    cantidad++;
                                }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") || botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                            }
                            else { break; }
                        }
                    }
                    else
                    {
                        //Pivotear Arriba J2
                        int posaux = i; vueltas.Clear(); bool bandera = true;
                        while (bandera)
                        {
                            posaux = posaux - columnas;
                            if (posaux >= 0)
                            {
                                if (posaux == ar1 || posaux == ar2 || posaux == ar3 || posaux == ar4 || posaux == ar5 || posaux == ar6 || posaux == ar7 || posaux == ar8 || posaux == ar9 || posaux == ar10 || posaux == ar11 || posaux == ar12 || posaux == ar13 || posaux == ar14 || posaux == ar15)
                                {
                                    if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                    {
                                        break;
                                    }
                                    else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    cantidad++;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    break;
                                }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") || botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                            }
                            else { break; }
                        }

                        //Pivotear Abajo J2
                        posaux = i; vueltas.Clear();
                        while (bandera)
                        {
                            posaux = posaux + columnas;
                            if (posaux < columnas * filas)
                            {
                                if (posaux == ab1 || posaux == ab2 || posaux == ab3 || posaux == ab4 || posaux == ab5 || posaux == ab6 || posaux == ab7 || posaux == ab8 || posaux == ab9 || posaux == ab10 || posaux == ab11 || posaux == ab12 || posaux == ab13 || posaux == ab14 || posaux == ab15)
                                {
                                    if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                    {
                                        break;
                                    }
                                    else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    cantidad++; 
                                }
                                else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    break;
                                }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") || botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                            }
                            else { break; }
                        }

                        // Pivotear Izquierda J2
                        posaux = i; vueltas.Clear();
                        while (bandera)
                        {
                            posaux = posaux - 1;
                            if (posaux >= 0)
                            {
                                if (posaux == ci1 || posaux == ci2 || posaux == ci3 || posaux == ci4 || posaux == ci5 || posaux == ci6 || posaux == ci7 || posaux == ci8 || posaux == ci9 || posaux == ci10 || posaux == ci11 || posaux == ci12 || posaux == ci13 || posaux == ci14 || posaux == ci15)
                                {
                                    if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                    {
                                        break;
                                    }
                                    else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    cantidad++;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    break;
                                }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") || botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                            }
                            else { break; }
                        }

                        // Pivotear Derecha J2
                        posaux = i; vueltas.Clear();
                        while (bandera)
                        {
                            posaux = posaux + 1;
                            if (posaux < filas * columnas)
                            {
                                if (posaux == cd1 || posaux == cd2 || posaux == cd3 || posaux == cd4 || posaux == cd5 || posaux == cd6 || posaux == cd7 || posaux == cd8 || posaux == cd9 || posaux == cd10 || posaux == cd11 || posaux == cd12 || posaux == cd13 || posaux == cd14 || posaux == cd15)
                                {
                                    if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                    {
                                        break;
                                    }
                                    else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    cantidad++;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    break;
                                }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") || botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                            }
                            else { break; }
                        }

                        // Pivtear Arriba Izquierda J2
                        posaux = i; vueltas.Clear();
                        while (bandera)
                        {
                            posaux = posaux - columnas - 1;
                            if (posaux >= 0)
                            {
                                if (posaux == ar1 || posaux == ar2 || posaux == ar3 || posaux == ar4 || posaux == ar5 || posaux == ar6 || posaux == ar7 || posaux == ar8 || posaux == ar9 || posaux == ar10 || posaux == ar11 || posaux == ar12 || posaux == ar13 || posaux == ar14 || posaux == ar15 || posaux == ci1 || posaux == ci2 || posaux == ci3 || posaux == ci4 || posaux == ci5 || posaux == ci6 || posaux == ci7 || posaux == ci8 || posaux == ci9 || posaux == ci10 || posaux == ci11 || posaux == ci12 || posaux == ci13 || posaux == ci14 || posaux == ci15)
                                {
                                    if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                    {
                                        break;
                                    }
                                    else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    cantidad++;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    break;
                                }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") || botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                            }
                            else { break; }
                        }

                        // Pivtear Arriba Derecha J2
                        posaux = i; vueltas.Clear();
                        while (bandera)
                        {
                            posaux = posaux - columnas + 1;
                            if (posaux >= 0)
                            {
                                if (posaux == ar1 || posaux == ar2 || posaux == ar3 || posaux == ar4 || posaux == ar5 || posaux == ar6 || posaux == ar7 || posaux == ar8 || posaux == ar9 || posaux == ar10 || posaux == ar11 || posaux == ar12 || posaux == ar13 || posaux == ar14 || posaux == ar15 || posaux == cd1 || posaux == cd2 || posaux == cd3 || posaux == cd4 || posaux == cd5 || posaux == cd6 || posaux == cd7 || posaux == cd8 || posaux == cd9 || posaux == cd10 || posaux == cd11 || posaux == cd12 || posaux == cd13 || posaux == cd14 || posaux == cd15)
                                {
                                    if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                    {
                                        break;
                                    }
                                    else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    cantidad++;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    break;
                                }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") || botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                            }
                            else { break; }
                        }

                        // Pivtear Abajo Izquierda J2
                        posaux = i; vueltas.Clear();
                        while (bandera)
                        {
                            posaux = posaux + columnas - 1;
                            if (posaux < filas * columnas)
                            {
                                if (posaux == ab1 || posaux == ab2 || posaux == ab3 || posaux == ab4 || posaux == ab5 || posaux == ab6 || posaux == ab7 || posaux == ab8 || posaux == ab9 || posaux == ab10 || posaux == ab11 || posaux == ab12 || posaux == ab13 || posaux == ab14 || posaux == ab15 || posaux == ci1 || posaux == ci2 || posaux == ci3 || posaux == ci4 || posaux == ci5 || posaux == ci6 || posaux == ci7 || posaux == ci8 || posaux == ci9 || posaux == ci10 || posaux == ci11 || posaux == ci12 || posaux == ci13 || posaux == ci14 || posaux == ci15)
                                {
                                    if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                    {
                                        break;
                                    }
                                    else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    cantidad++;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    break;
                                }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") || botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                            }
                            else { break; }
                        }

                        // Pivtear Abajo Derecha J2
                        posaux = i; vueltas.Clear();
                        while (bandera)
                        {
                            posaux = posaux + columnas + 1;
                            if (posaux < filas * columnas)
                            {
                                if (posaux == ab1 || posaux == ab2 || posaux == ab3 || posaux == ab4 || posaux == ab5 || posaux == ab6 || posaux == ab7 || posaux == ab8 || posaux == ab9 || posaux == ab10 || posaux == ab11 || posaux == ab12 || posaux == ab13 || posaux == ab14 || posaux == ab15 || posaux == cd1 || posaux == cd2 || posaux == cd3 || posaux == cd4 || posaux == cd5 || posaux == cd6 || posaux == cd7 || posaux == cd8 || posaux == cd9 || posaux == cd10 || posaux == cd11 || posaux == cd12 || posaux == cd13 || posaux == cd14 || posaux == cd15)
                                {
                                    if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                    {
                                        break;
                                    }
                                    else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    cantidad++;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    break;
                                }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") || botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                            }
                            else { break; }
                        }
                    }
                    tirosM.Add(cantidad);
                }
                int maximo = tirosM.Max();
                int posicion = 0;
                foreach (int i in tirosM)
                {
                    if (maximo == i)
                    {
                        break;
                    }
                    else { posicion++; }
                }
                int tiro = pivotes[posicion];
                voltear(tiro);
            }
            else
            {
                siguiente();
            }
        }

        //Voltear Fichas
        public void voltear(int i) {
            vueltas.Clear();

            if (actual.Equals(j1c1) || actual.Equals(j1c2) || actual.Equals(j1c3) || actual.Equals(j1c4) || actual.Equals(j1c5))
            {
                //Pivotear Arriba J1
                int posaux = i; vueltas.Clear(); vueltas.Add(i); bool bandera = true;
                while (bandera) 
                {
                    posaux = posaux - columnas;
                    if (posaux >= 0)
                    {
                        if (posaux == ar1 || posaux == ar2 || posaux == ar3 || posaux == ar4 || posaux == ar5 || posaux == ar6 || posaux == ar7 || posaux == ar8 || posaux == ar9 || posaux == ar10 || posaux == ar11 || posaux == ar12 || posaux == ar13 || posaux == ar14 || posaux == ar15) {
                            if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                            {
                                foreach (int z in vueltas) { botones[z].ImageUrl = actual + ".png"; }
                                vueltas.Clear(); break;
                            } else { break; }
                        }
                        else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                        {
                            foreach (int z in vueltas) { botones[z].ImageUrl = actual + ".png"; }
                            vueltas.Clear(); break;
                        }
                        else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                        {
                            vueltas.Add(posaux);
                        }
                        else if (botones[posaux].ImageUrl.Equals("vacio.png") || botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                    }
                    else { break; }
                }
                
                //Pivotear Abajo J1
                posaux = i; vueltas.Clear(); vueltas.Add(i);
                while (bandera) 
                {
                    posaux = posaux + columnas;
                    if (posaux < columnas * filas)
                    {
                        if (posaux == ab1 || posaux == ab2 || posaux == ab3 || posaux == ab4 || posaux == ab5 || posaux == ab6 || posaux == ab7 || posaux == ab8 || posaux == ab9 || posaux == ab10 || posaux == ab11 || posaux == ab12 || posaux == ab13 || posaux == ab14 || posaux == ab15) {
                            if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                            {
                                foreach (int z in vueltas) { botones[z].ImageUrl = actual + ".png"; }
                                vueltas.Clear(); break;
                            } else { break; } }
                        else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                        {
                            foreach (int z in vueltas) { botones[z].ImageUrl = actual + ".png"; }
                            vueltas.Clear(); break;
                        }
                        else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                        {
                            vueltas.Add(posaux);
                        }
                        else if (botones[posaux].ImageUrl.Equals("vacio.png") || botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                    }
                    else { break; }
                }

                // Pivotear Izquierda J1
                posaux = i; vueltas.Clear(); vueltas.Add(i);
                while (bandera) 
                {
                    posaux = posaux - 1;
                    if (posaux >= 0)
                    {
                        if (posaux == ci1 || posaux == ci2 || posaux == ci3 || posaux == ci4 || posaux == ci5 || posaux == ci6 || posaux == ci7 || posaux == ci8 || posaux == ci9 || posaux == ci10 || posaux == ci11 || posaux == ci12 || posaux == ci13 || posaux == ci14 || posaux == ci15) {
                            if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                            {
                                foreach (int z in vueltas) { botones[z].ImageUrl = actual + ".png"; }
                                vueltas.Clear(); break;
                            } else { break; } }
                        else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                        {
                            foreach (int z in vueltas) { botones[z].ImageUrl = actual + ".png"; }
                            vueltas.Clear(); break;
                        }
                        else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                        {
                            vueltas.Add(posaux);
                        }
                        else if (botones[posaux].ImageUrl.Equals("vacio.png") || botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                    }
                    else { break; }
                }

                // Pivotear Derecha J1
                posaux = i; vueltas.Clear(); vueltas.Add(i);
                while (bandera)
                {
                    posaux = posaux + 1;
                    if (posaux < filas * columnas)
                    {
                        if (posaux == cd1 || posaux == cd2 || posaux == cd3 || posaux == cd4 || posaux == cd5 || posaux == cd6 || posaux == cd7 || posaux == cd8 || posaux == cd9 || posaux == cd10 || posaux == cd11 || posaux == cd12 || posaux == cd13 || posaux == cd14 || posaux == cd15) {
                            if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                            {
                                foreach (int z in vueltas) { botones[z].ImageUrl = actual + ".png"; }
                                vueltas.Clear(); break;
                            } else { break; }
                        }
                        else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                        {
                            foreach (int z in vueltas) { botones[z].ImageUrl = actual + ".png"; }
                            vueltas.Clear(); break;
                        }
                        else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                        {
                            vueltas.Add(posaux);
                        }
                        else if (botones[posaux].ImageUrl.Equals("vacio.png") || botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                    }
                    else { break; }
                }

                // Pivtear Arriba Izquierda J1
                posaux = i; vueltas.Clear(); vueltas.Add(i);
                while (bandera) 
                {
                    posaux = posaux - columnas - 1;
                    if (posaux >= 0)
                    {
                        if (posaux == ar1 || posaux == ar2 || posaux == ar3 || posaux == ar4 || posaux == ar5 || posaux == ar6 || posaux == ar7 || posaux == ar8 || posaux == ar9 || posaux == ar10 || posaux == ar11 || posaux == ar12 || posaux == ar13 || posaux == ar14 || posaux == ar15 || posaux == ci1 || posaux == ci2 || posaux == ci3 || posaux == ci4 || posaux == ci5 || posaux == ci6 || posaux == ci7 || posaux == ci8 || posaux == ci9 || posaux == ci10 || posaux == ci11 || posaux == ci12 || posaux == ci13 || posaux == ci14 || posaux == ci15) {
                            if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                            {
                                foreach (int z in vueltas) { botones[z].ImageUrl = actual + ".png"; }
                                vueltas.Clear(); break;
                            }
                            else { break; }
                        }
                        else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                        {
                            foreach (int z in vueltas) { botones[z].ImageUrl = actual + ".png"; }
                            vueltas.Clear(); break;
                        }
                        else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                        {
                            vueltas.Add(posaux);
                        }
                        else if (botones[posaux].ImageUrl.Equals("vacio.png") || botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                    }
                    else { break; }
                }

                // Pivtear Arriba Derecha J1
                posaux = i; vueltas.Clear(); vueltas.Add(i);
                while (bandera) 
                {
                    posaux = posaux - columnas + 1;
                    if (posaux >= 0)
                    {
                        if (posaux == ar1 || posaux == ar2 || posaux == ar3 || posaux == ar4 || posaux == ar5 || posaux == ar6 || posaux == ar7 || posaux == ar8 || posaux == ar9 || posaux == ar10 || posaux == ar11 || posaux == ar12 || posaux == ar13 || posaux == ar14 || posaux == ar15 || posaux == cd1 || posaux == cd2 || posaux == cd3 || posaux == cd4 || posaux == cd5 || posaux == cd6 || posaux == cd7 || posaux == cd8 || posaux == cd9 || posaux == cd10 || posaux == cd11 || posaux == cd12 || posaux == cd13 || posaux == cd14 || posaux == cd15) {
                            if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                            {
                                foreach (int z in vueltas) { botones[z].ImageUrl = actual + ".png"; }
                                vueltas.Clear(); break;
                            }
                            else { break; }
                        }
                        else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                        {
                            foreach (int z in vueltas) { botones[z].ImageUrl = actual + ".png"; }
                            vueltas.Clear(); break;
                        }
                        else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                        {
                            vueltas.Add(posaux);
                        }
                        else if (botones[posaux].ImageUrl.Equals("vacio.png") || botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                    }
                    else { break; }
                }

                // Pivtear Abajo Izquierda J1
                posaux = i; vueltas.Clear(); vueltas.Add(i);
                while (bandera) 
                {
                    posaux = posaux + columnas - 1;
                    if (posaux < filas * columnas)
                    {
                        if (posaux == ab1 || posaux == ab2 || posaux == ab3 || posaux == ab4 || posaux == ab5 || posaux == ab6 || posaux == ab7 || posaux == ab8 || posaux == ab9 || posaux == ab10 || posaux == ab11 || posaux == ab12 || posaux == ab13 || posaux == ab14 || posaux == ab15 || posaux == ci1 || posaux == ci2 || posaux == ci3 || posaux == ci4 || posaux == ci5 || posaux == ci6 || posaux == ci7 || posaux == ci8 || posaux == ci9 || posaux == ci10 || posaux == ci11 || posaux == ci12 || posaux == ci13 || posaux == ci14 || posaux == ci15) {
                            if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                            {
                                foreach (int z in vueltas) { botones[z].ImageUrl = actual + ".png"; }
                                vueltas.Clear(); break;
                            }
                            else { break; }
                        }
                        else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                        {
                            foreach (int z in vueltas) { botones[z].ImageUrl = actual + ".png"; }
                            vueltas.Clear(); break;
                        }
                        else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                        {
                            vueltas.Add(posaux);
                        }
                        else if (botones[posaux].ImageUrl.Equals("vacio.png") || botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                    }
                    else { break; }
                }

                // Pivotear Abajo Derecha J1
                posaux = i; vueltas.Clear(); vueltas.Add(i);
                while (bandera) 
                {
                    posaux = posaux + columnas + 1;
                    if (posaux < filas * columnas)
                    {
                        if (posaux == ab1 || posaux == ab2 || posaux == ab3 || posaux == ab4 || posaux == ab5 || posaux == ab6 || posaux == ab7 || posaux == ab8 || posaux == ab9 || posaux == ab10 || posaux == ab11 || posaux == ab12 || posaux == ab13 || posaux == ab14 || posaux == ab15 || posaux == cd1 || posaux == cd2 || posaux == cd3 || posaux == cd4 || posaux == cd5 || posaux == cd6 || posaux == cd7 || posaux == cd8 || posaux == cd9 || posaux == cd10 || posaux == cd11 || posaux == cd12 || posaux == cd13 || posaux == cd14 || posaux == cd15) {
                            if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                            {
                                foreach (int z in vueltas) { botones[z].ImageUrl = actual + ".png"; }
                                vueltas.Clear(); break;
                            } else { break; }
                        }
                        else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                        {
                            foreach (int z in vueltas) { botones[z].ImageUrl = actual + ".png"; }
                            vueltas.Clear(); break;
                        }
                        else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                        {
                            vueltas.Add(posaux);
                        }
                        else if (botones[posaux].ImageUrl.Equals("vacio.png") || botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                    }
                    else { break; }
                }

            } else {
                //Pivotear Arriba J2
                int posaux = i; vueltas.Clear(); vueltas.Add(i); bool bandera = true;
                while (bandera)
                {
                    posaux = posaux - columnas;
                    if (posaux >= 0 )
                    {
                        if (posaux == ar1 || posaux == ar2 || posaux == ar3 || posaux == ar4 || posaux == ar5 || posaux == ar6 || posaux == ar7 || posaux == ar8 || posaux == ar9 || posaux == ar10 || posaux == ar11 || posaux == ar12 || posaux == ar13 || posaux == ar14 || posaux == ar15) {
                            if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                            {
                                foreach (int z in vueltas) { botones[z].ImageUrl = actual + ".png"; }
                                vueltas.Clear(); break;
                            }
                            else { break; }
                        }
                        else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                        {
                            vueltas.Add(posaux);
                        }
                        else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                        {
                            foreach (int z in vueltas) { botones[z].ImageUrl = actual + ".png"; }
                            vueltas.Clear(); break;
                        }
                        else if (botones[posaux].ImageUrl.Equals("vacio.png") || botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                    }
                    else { break; }
                }
                
                //Pivotear Abajo J2
                posaux = i; vueltas.Clear(); vueltas.Add(i);
                while (bandera)
                {
                    posaux = posaux + columnas;
                    if (posaux < columnas * filas)
                    {
                        if (posaux == ab1 || posaux == ab2 || posaux == ab3 || posaux == ab4 || posaux == ab5 || posaux == ab6 || posaux == ab7 || posaux == ab8 || posaux == ab9 || posaux == ab10 || posaux == ab11 || posaux == ab12 || posaux == ab13 || posaux == ab14 || posaux == ab15) {
                            if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                            {
                                foreach (int z in vueltas) { botones[z].ImageUrl = actual + ".png"; }
                                vueltas.Clear(); break;
                            }
                            else { break; }
                        }
                        else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                        {
                            vueltas.Add(posaux);
                        }
                        else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                        {
                            foreach (int z in vueltas) { botones[z].ImageUrl = actual + ".png"; }
                            vueltas.Clear(); break;
                        }
                        else if (botones[posaux].ImageUrl.Equals("vacio.png") || botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                    }
                    else { break; }
                }

                // Pivotear Izquierda J2
                posaux = i; vueltas.Clear(); vueltas.Add(i);
                while (bandera)
                {
                    posaux = posaux - 1;
                    if (posaux >= 0)
                    {
                        if (posaux == ci1 || posaux == ci2 || posaux == ci3 || posaux == ci4 || posaux == ci5 || posaux == ci6 || posaux == ci7 || posaux == ci8 || posaux == ci9 || posaux == ci10 || posaux == ci11 || posaux == ci12 || posaux == ci13 || posaux == ci14 || posaux == ci15) {
                            if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                            {
                                foreach (int z in vueltas) { botones[z].ImageUrl = actual + ".png"; }
                                vueltas.Clear(); break;
                            }
                            else { break; }
                        }
                        else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                        {
                            vueltas.Add(posaux);
                        }
                        else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                        {
                            foreach (int z in vueltas) { botones[z].ImageUrl = actual + ".png"; }
                            vueltas.Clear(); break;
                        }
                        else if (botones[posaux].ImageUrl.Equals("vacio.png") || botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                    }
                    else { break; }
                }

                // Pivotear Derecha J2
                posaux = i; vueltas.Clear(); vueltas.Add(i);
                while (bandera)
                {
                    posaux = posaux + 1;
                    if (posaux < filas * columnas)
                    {
                        if (posaux == cd1 || posaux == cd2 || posaux == cd3 || posaux == cd4 || posaux == cd5 || posaux == cd6 || posaux == cd7 || posaux == cd8 || posaux == cd9 || posaux == cd10 || posaux == cd11 || posaux == cd12 || posaux == cd13 || posaux == cd14 || posaux == cd15) {
                            if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                            {
                                foreach (int z in vueltas) { botones[z].ImageUrl = actual + ".png"; }
                                vueltas.Clear(); break;
                            }
                            else { break; }
                        }
                        else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                        {
                            vueltas.Add(posaux);
                        }
                        else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                        {
                            foreach (int z in vueltas) { botones[z].ImageUrl = actual + ".png"; }
                            vueltas.Clear(); break;
                        }
                        else if (botones[posaux].ImageUrl.Equals("vacio.png") || botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                    }
                    else { break; }
                }

                // Pivtear Arriba Izquierda J2
                posaux = i; vueltas.Clear(); vueltas.Add(i);
                while (bandera)
                {
                    posaux = posaux - columnas - 1;
                    if (posaux >= 0)
                    {
                        if (posaux == ar1 || posaux == ar2 || posaux == ar3 || posaux == ar4 || posaux == ar5 || posaux == ar6 || posaux == ar7 || posaux == ar8 || posaux == ar9 || posaux == ar10 || posaux == ar11 || posaux == ar12 || posaux == ar13 || posaux == ar14 || posaux == ar15 || posaux == ci1 || posaux == ci2 || posaux == ci3 || posaux == ci4 || posaux == ci5 || posaux == ci6 || posaux == ci7 || posaux == ci8 || posaux == ci9 || posaux == ci10 || posaux == ci11 || posaux == ci12 || posaux == ci13 || posaux == ci14 || posaux == ci15) {
                            if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                            {
                                foreach (int z in vueltas) { botones[z].ImageUrl = actual + ".png"; }
                                vueltas.Clear(); break;
                            }
                            else { break; }
                        }
                        else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                        {
                            vueltas.Add(posaux);
                        }
                        else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                        {
                            foreach (int z in vueltas) { botones[z].ImageUrl = actual + ".png"; }
                            vueltas.Clear(); break;
                        }
                        else if (botones[posaux].ImageUrl.Equals("vacio.png") || botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                    } else { break; }
                }

                // Pivtear Arriba Derecha J2
                posaux = i; vueltas.Clear(); vueltas.Add(i);
                while (bandera) 
                {
                    posaux = posaux - columnas + 1;
                    if (posaux >= 0)
                    {
                        if (posaux == ar1 || posaux == ar2 || posaux == ar3 || posaux == ar4 || posaux == ar5 || posaux == ar6 || posaux == ar7 || posaux == ar8 || posaux == ar9 || posaux == ar10 || posaux == ar11 || posaux == ar12 || posaux == ar13 || posaux == ar14 || posaux == ar15 || posaux == cd1 || posaux == cd2 || posaux == cd3 || posaux == cd4 || posaux == cd5 || posaux == cd6 || posaux == cd7 || posaux == cd8 || posaux == cd9 || posaux == cd10 || posaux == cd11 || posaux == cd12 || posaux == cd13 || posaux == cd14 || posaux == cd15) {
                            if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                            {
                                foreach (int z in vueltas) { botones[z].ImageUrl = actual + ".png"; }
                                vueltas.Clear(); break;
                            }
                            else { break; }
                        }
                        else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                        {
                            vueltas.Add(posaux);
                        }
                        else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                        {
                            foreach (int z in vueltas) { botones[z].ImageUrl = actual + ".png"; }
                            vueltas.Clear(); break;
                        }
                        else if (botones[posaux].ImageUrl.Equals("vacio.png") || botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                    }
                    else { break; }
                }

                // Pivtear Abajo Izquierda J2
                posaux = i; vueltas.Clear(); vueltas.Add(i);
                while (bandera) 
                {
                    posaux = posaux + columnas - 1;
                    if (posaux < filas * columnas)
                    {
                        if (posaux == ab1 || posaux == ab2 || posaux == ab3 || posaux == ab4 || posaux == ab5 || posaux == ab6 || posaux == ab7 || posaux == ab8 || posaux == ab9 || posaux == ab10 || posaux == ab11 || posaux == ab12 || posaux == ab13 || posaux == ab14 || posaux == ab15 || posaux == ci1 || posaux == ci2 || posaux == ci3 || posaux == ci4 || posaux == ci5 || posaux == ci6 || posaux == ci7 || posaux == ci8 || posaux == ci9 || posaux == ci10 || posaux == ci11 || posaux == ci12 || posaux == ci13 || posaux == ci14 || posaux == ci15) {
                            if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                            {
                                foreach (int z in vueltas) { botones[z].ImageUrl = actual + ".png"; }
                                vueltas.Clear(); break;
                            }
                            else { break; }
                        }
                        else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                        {
                            vueltas.Add(posaux);
                        }
                        else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                        {
                            foreach (int z in vueltas) { botones[z].ImageUrl = actual + ".png"; }
                            vueltas.Clear(); break;
                        }
                        else if (botones[posaux].ImageUrl.Equals("vacio.png") || botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                    }
                    else { break; }
                }

                // Pivtear Abajo Derecha J2
                posaux = i; vueltas.Clear(); vueltas.Add(i);
                while (bandera) 
                {
                    posaux = posaux + columnas + 1;
                    if (posaux < filas * columnas)
                    {
                        if (posaux == ab1 || posaux == ab2 || posaux == ab3 || posaux == ab4 || posaux == ab5 || posaux == ab6 || posaux == ab7 || posaux == ab8 || posaux == ab9 || posaux == ab10 || posaux == ab11 || posaux == ab12 || posaux == ab13 || posaux == ab14 || posaux == ab15 || posaux == cd1 || posaux == cd2 || posaux == cd3 || posaux == cd4 || posaux == cd5 || posaux == cd6 || posaux == cd7 || posaux == cd8 || posaux == cd9 || posaux == cd10 || posaux == cd11 || posaux == cd12 || posaux == cd13 || posaux == cd14 || posaux == cd15) {
                            if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                            {
                                foreach (int z in vueltas) { botones[z].ImageUrl = actual + ".png"; }
                                vueltas.Clear(); break;
                            }
                            else { break; }
                        }
                        else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                        {
                            vueltas.Add(posaux);
                        }
                        else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                        {
                            foreach (int z in vueltas) { botones[z].ImageUrl = actual + ".png"; }
                            vueltas.Clear(); break;
                        }
                        else if (botones[posaux].ImageUrl.Equals("vacio.png") || botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                    }
                    else { break; }
                }
            }
        }

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
            bool turno = false;

            if (actual.Equals(j1c1) || actual.Equals(j1c2) || actual.Equals(j1c3) || actual.Equals(j1c4) || actual.Equals(j1c5)) { turno = true; } else { turno = false; }
            for (int i = 0; i < botones.Count; i++) {
                if (turno)
                {
                    if (botones[i].ImageUrl.Equals(j1c1 + ".png") || botones[i].ImageUrl.Equals(j1c2 + ".png") || botones[i].ImageUrl.Equals(j1c3 + ".png") || botones[i].ImageUrl.Equals(j1c4 + ".png") || botones[i].ImageUrl.Equals(j1c5 + ".png"))
                    {
                        //Pivotear Arriba J1
                        int posaux = i; bool bandera = false; int paso = 0;
                        while (posaux != 0) 
                        {
                            if (posaux >= 0) {
                                if (posaux == ar1 || posaux == ar2 || posaux == ar3 || posaux == ar4 || posaux == ar5 || posaux == ar6 || posaux == ar7 || posaux == ar8 || posaux == ar9 || posaux == ar10 || posaux == ar11 || posaux == ar12 || posaux == ar13 || posaux == ar14 || posaux == ar15)
                                {
                                    if (bandera && botones[posaux].ImageUrl.Equals("vacio.png")) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; }
                                    break;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    if (paso == 0) { paso = 1; } else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    bandera = true;
                                }
                                else if (botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") && bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") && !bandera) { break; }
                            }
                            else { break; }
                            posaux = posaux - columnas;
                        }
                        
                        //Pivotear Abajo J1
                        posaux = i; bandera = false; paso = 0;
                        while (posaux != (filas*columnas) - 1) 
                        {
                            if (posaux < filas * columnas) {
                                if (posaux == ab1 || posaux == ab2 || posaux == ab3 || posaux == ab4 || posaux == ab5 || posaux == ab6 || posaux == ab7 || posaux == ab8 || posaux == ab9 || posaux == ab10 || posaux == ab11 || posaux == ab12 || posaux == ab13 || posaux == ab14 || posaux == ab15)
                                {
                                    if (bandera && botones[posaux].ImageUrl.Equals("vacio.png")) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; }
                                    break;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    if (paso == 0) { paso = 1; } else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    bandera = true;
                                }
                                else if (botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") && bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") && !bandera) { break; }
                            } else { break; }
                            posaux = posaux + columnas;
                        }
                        
                        // Pivotear Izquierda J1
                        posaux = i; bandera = false; paso = 0;
                        while (posaux != 0) 
                        {
                            if (posaux >= 0) {
                                if (posaux == ci1 || posaux == ci2 || posaux == ci3 || posaux == ci4 || posaux == ci5 || posaux == ci6 || posaux == ci7 || posaux == ci8 || posaux == ci9 || posaux == ci10 || posaux == ci11 || posaux == ci12 || posaux == ci13 || posaux == ci14 || posaux == ci15)
                                {
                                    if (bandera && botones[posaux].ImageUrl.Equals("vacio.png")) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; }
                                    break;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    if (paso == 0) { paso = 1; } else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    bandera = true;
                                }
                                else if (botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") && bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") && !bandera) { break; }
                            } else { break; }
                            posaux = posaux - 1;
                        }
                        
                        // Pivotear Derecha J1
                        posaux = i; bandera = false; paso = 0;
                        while (posaux != (filas * columnas) - 1)
                        {
                            if (posaux < filas * columnas) {
                                if (posaux == cd1 || posaux == cd2 || posaux == cd3 || posaux == cd4 || posaux == cd5 || posaux == cd6 || posaux == cd7 || posaux == cd8 || posaux == cd9 || posaux == cd10 || posaux == cd11 || posaux == cd12 || posaux == cd13 || posaux == cd14 || posaux == cd15)
                                {
                                    if (bandera && botones[posaux].ImageUrl.Equals("vacio.png")) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; }
                                    break;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    if (paso == 0) { paso = 1; } else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    bandera = true;
                                }
                                else if (botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") && bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") && !bandera) { break; }
                            } else { break; }
                            posaux = posaux + 1;
                        }

                        // Pivotear Arriba Izquierda J2
                        posaux = i; bandera = false; paso = 0;
                        while (posaux != columnas - 1 && posaux != (filas*columnas) - columnas) 
                        {
                            if (posaux >= 0) {
                                if (posaux == ar1 || posaux == ar2 || posaux == ar3 || posaux == ar4 || posaux == ar5 || posaux == ar6 || posaux == ar7 || posaux == ar8 || posaux == ar9 || posaux == ar10 || posaux == ar11 || posaux == ar12 || posaux == ar13 || posaux == ar14 || posaux == ar15 || posaux == ci1 || posaux == ci2 || posaux == ci3 || posaux == ci4 || posaux == ci5 || posaux == ci6 || posaux == ci7 || posaux == ci8 || posaux == ci9 || posaux == ci10 || posaux == ci11 || posaux == ci12 || posaux == ci13 || posaux == ci14 || posaux == ci15)
                                {
                                    if (bandera && botones[posaux].ImageUrl.Equals("vacio.png")) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; }
                                    break;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    if (paso == 0) { paso = 1; } else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    bandera = true;
                                }
                                else if (botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") && bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") && !bandera) { break; }
                            } else { break; }
                            posaux = posaux - columnas - 1;
                        }

                        // Pivtear Arriba Derecha J2
                        posaux = i; bandera = false; paso = 0;
                        while (posaux != 0 && posaux != (filas * columnas) - 1) 
                        {
                            if (posaux >= 0) {
                                if (posaux == ar1 || posaux == ar2 || posaux == ar3 || posaux == ar4 || posaux == ar5 || posaux == ar6 || posaux == ar7 || posaux == ar8 || posaux == ar9 || posaux == ar10 || posaux == ar11 || posaux == ar12 || posaux == ar13 || posaux == ar14 || posaux == ar15 || posaux == cd1 || posaux == cd2 || posaux == cd3 || posaux == cd4 || posaux == cd5 || posaux == cd6 || posaux == cd7 || posaux == cd8 || posaux == cd9 || posaux == cd10 || posaux == cd11 || posaux == cd12 || posaux == cd13 || posaux == cd14 || posaux == cd15)
                                {
                                    if (bandera && botones[posaux].ImageUrl.Equals("vacio.png")) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; }
                                    break;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    if (paso == 0) { paso = 1; } else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    bandera = true;
                                }
                                else if (botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") && bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") && !bandera) { break; }
                            } else { break; }
                            posaux = posaux - columnas + 1;
                        }

                        // Pivtear Abajo Izquierda J2
                        posaux = i; bandera = false; paso = 0;
                        while (posaux != 0 && posaux != (filas * columnas) - 1) 
                        {
                            if (posaux < filas * columnas) {
                                if (posaux == ab1 || posaux == ab2 || posaux == ab3 || posaux == ab4 || posaux == ab5 || posaux == ab6 || posaux == ab7 || posaux == ab8 || posaux == ab9 || posaux == ab10 || posaux == ab11 || posaux == ab12 || posaux == ab13 || posaux == ab14 || posaux == ab15 || posaux == ci1 || posaux == ci2 || posaux == ci3 || posaux == ci4 || posaux == ci5 || posaux == ci6 || posaux == ci7 || posaux == ci8 || posaux == ci9 || posaux == ci10 || posaux == ci11 || posaux == ci12 || posaux == ci13 || posaux == ci14 || posaux == ci15)
                                {
                                    if (bandera && botones[posaux].ImageUrl.Equals("vacio.png")) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; }
                                    break;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    if (paso == 0) { paso = 1; } else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    bandera = true;
                                }
                                else if (botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") && bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") && !bandera) { break; }
                            } else { break; }
                            posaux = posaux + columnas - 1;
                        }

                        // Pivtear Abajo Derecha J2
                        posaux = i; bandera = false; paso = 0;
                        while (posaux != columnas - 1 && posaux != (filas * columnas) - columnas) 
                        {
                            if (posaux < filas * columnas) {
                                if (posaux == ab1 || posaux == ab2 || posaux == ab3 || posaux == ab4 || posaux == ab5 || posaux == ab6 || posaux == ab7 || posaux == ab8 || posaux == ab9 || posaux == ab10 || posaux == ab11 || posaux == ab12 || posaux == ab13 || posaux == ab14 || posaux == ab15 || posaux == ci1 || posaux == ci2 || posaux == ci3 || posaux == ci4 || posaux == ci5 || posaux == ci6 || posaux == ci7 || posaux == ci8 || posaux == ci9 || posaux == ci10 || posaux == ci11 || posaux == ci12 || posaux == ci13 || posaux == ci14 || posaux == ci15)
                                {
                                    if (bandera && botones[posaux].ImageUrl.Equals("vacio.png")) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; }
                                    break;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    if (paso == 0) { paso = 1; } else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    bandera = true;
                                }
                                else if (botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") && bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") && !bandera) { break; }
                            } else { break; }
                            posaux = posaux + columnas + 1;
                        }
                    }
                }
                else {
                    if (botones[i].ImageUrl.Equals(j2c1 + ".png") || botones[i].ImageUrl.Equals(j2c2 + ".png") || botones[i].ImageUrl.Equals(j2c3 + ".png") || botones[i].ImageUrl.Equals(j2c4 + ".png") || botones[i].ImageUrl.Equals(j2c5 + ".png"))
                    {
                        //Pivotear Arriba J1
                        int posaux = i; bool bandera = false; int paso = 0;
                        while (posaux != 0)
                        {
                            if (posaux >= 0) {
                                if (posaux == ar1 || posaux == ar2 || posaux == ar3 || posaux == ar4 || posaux == ar5 || posaux == ar6 || posaux == ar7 || posaux == ar8 || posaux == ar9 || posaux == ar10 || posaux == ar11 || posaux == ar12 || posaux == ar13 || posaux == ar14 || posaux == ar15)
                                {
                                    if (bandera && botones[posaux].ImageUrl.Equals("vacio.png")) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; }
                                    break;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    bandera = true;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    if (paso == 0) { paso = 1; } else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") && bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") && !bandera) { break; }
                            } else { break; }
                            posaux = posaux - columnas;
                        }

                        //Pivotear Abajo J1
                        posaux = i; bandera = false; paso = 0;
                        while (posaux != (filas * columnas) - 1)
                        {
                            if (posaux < filas * columnas) {
                                if (posaux == ab1 || posaux == ab2 || posaux == ab3 || posaux == ab4 || posaux == ab5 || posaux == ab6 || posaux == ab7 || posaux == ab8 || posaux == ab9 || posaux == ab10 || posaux == ab11 || posaux == ab12 || posaux == ab13 || posaux == ab14 || posaux == ab15)
                                {
                                    if (bandera && botones[posaux].ImageUrl.Equals("vacio.png")) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; }
                                    break;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    bandera = true;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    if (paso == 0) { paso = 1; } else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") && bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") && !bandera) { break; }
                            } else { break; }
                            posaux = posaux + columnas;
                        }

                        // Pivotear Izquierda J1
                        posaux = i; bandera = false; paso = 0;
                        while (posaux != 0)
                        {
                            if (posaux >= 0) {
                                if (posaux == ci1 || posaux == ci2 || posaux == ci3 || posaux == ci4 || posaux == ci5 || posaux == ci6 || posaux == ci7 || posaux == ci8 || posaux == ci9 || posaux == ci10 || posaux == ci11 || posaux == ci12 || posaux == ci13 || posaux == ci14 || posaux == ci15)
                                {
                                    if (bandera && botones[posaux].ImageUrl.Equals("vacio.png")) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; }
                                    break;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    bandera = true;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    if (paso == 0) { paso = 1; } else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") && bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") && !bandera) { break; }
                            } else { break; }
                            posaux = posaux - 1;
                        }

                        // Pivotear Derecha J1
                        posaux = i; bandera = false; paso = 0;
                        while (posaux != (filas * columnas) - 1)
                        {
                            if (posaux < filas * columnas) {
                                if (posaux == cd1 || posaux == cd2 || posaux == cd3 || posaux == cd4 || posaux == cd5 || posaux == cd6 || posaux == cd7 || posaux == cd8 || posaux == cd9 || posaux == cd10 || posaux == cd11 || posaux == cd12 || posaux == cd13 || posaux == cd14 || posaux == cd15)
                                {
                                    if (bandera && botones[posaux].ImageUrl.Equals("vacio.png")) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; }
                                    break;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    bandera = true;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    if (paso == 0) { paso = 1; } else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") && bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") && !bandera) { break; }
                            } else { break; }
                            posaux = posaux + 1;
                        }

                        // Pivotear Arriba Izquierda J2
                        posaux = i; bandera = false; paso = 0;
                        while (posaux != columnas - 1 && posaux != (filas * columnas) - columnas)
                        {
                            if (posaux >= 0) {
                                if (posaux == ar1 || posaux == ar2 || posaux == ar3 || posaux == ar4 || posaux == ar5 || posaux == ar6 || posaux == ar7 || posaux == ar8 || posaux == ar9 || posaux == ar10 || posaux == ar11 || posaux == ar12 || posaux == ar13 || posaux == ar14 || posaux == ar15 || posaux == ci1 || posaux == ci2 || posaux == ci3 || posaux == ci4 || posaux == ci5 || posaux == ci6 || posaux == ci7 || posaux == ci8 || posaux == ci9 || posaux == ci10 || posaux == ci11 || posaux == ci12 || posaux == ci13 || posaux == ci14 || posaux == ci15)
                                {
                                    if (bandera && botones[posaux].ImageUrl.Equals("vacio.png")) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; }
                                    break;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    bandera = true;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    if (paso == 0) { paso = 1; } else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") && bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") && !bandera) { break; }
                            } else { break; }
                            posaux = posaux - columnas - 1;
                        }

                        // Pivtear Arriba Derecha J2
                        posaux = i; bandera = false; paso = 0;
                        while (posaux != 0 && posaux != (filas * columnas) - 1)
                        {
                            if (posaux >= 0) {
                                if (posaux == ar1 || posaux == ar2 || posaux == ar3 || posaux == ar4 || posaux == ar5 || posaux == ar6 || posaux == ar7 || posaux == ar8 || posaux == ar9 || posaux == ar10 || posaux == ar11 || posaux == ar12 || posaux == ar13 || posaux == ar14 || posaux == ar15 || posaux == cd1 || posaux == cd2 || posaux == cd3 || posaux == cd4 || posaux == cd5 || posaux == cd6 || posaux == cd7 || posaux == cd8 || posaux == cd9 || posaux == cd10 || posaux == cd11 || posaux == cd12 || posaux == cd13 || posaux == cd14 || posaux == cd15)
                                {
                                    if (bandera && botones[posaux].ImageUrl.Equals("vacio.png")) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; }
                                    break;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    bandera = true;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    if (paso == 0) { paso = 1; } else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") && bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") && !bandera) { break; }
                            } else { break; }
                            posaux = posaux - columnas + 1;
                        }

                        // Pivtear Abajo Izquierda J2
                        posaux = i; bandera = false; paso = 0;
                        while (posaux != 0 && posaux != (filas * columnas) - 1)
                        {
                            if (posaux < filas * columnas) {
                                if (posaux == ab1 || posaux == ab2 || posaux == ab3 || posaux == ab4 || posaux == ab5 || posaux == ab6 || posaux == ab7 || posaux == ab8 || posaux == ab9 || posaux == ab10 || posaux == ab11 || posaux == ab12 || posaux == ab13 || posaux == ab14 || posaux == ab15 || posaux == ci1 || posaux == ci2 || posaux == ci3 || posaux == ci4 || posaux == ci5 || posaux == ci6 || posaux == ci7 || posaux == ci8 || posaux == ci9 || posaux == ci10 || posaux == ci11 || posaux == ci12 || posaux == ci13 || posaux == ci14 || posaux == ci15)
                                {
                                    if (bandera && botones[posaux].ImageUrl.Equals("vacio.png")) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; }
                                    break;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    bandera = true;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    if (paso == 0) { paso = 1; } else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") && bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") && !bandera) { break; }
                            } else { break; }
                            posaux = posaux + columnas - 1;
                        }

                        // Pivtear Abajo Derecha J2
                        posaux = i; bandera = false; paso = 0;
                        while (posaux != columnas - 1 && posaux != (filas * columnas) - columnas)
                        {
                            if (posaux < filas * columnas) {
                                if (posaux == ab1 || posaux == ab2 || posaux == ab3 || posaux == ab4 || posaux == ab5 || posaux == ab6 || posaux == ab7 || posaux == ab8 || posaux == ab9 || posaux == ab10 || posaux == ab11 || posaux == ab12 || posaux == ab13 || posaux == ab14 || posaux == ab15 || posaux == ci1 || posaux == ci2 || posaux == ci3 || posaux == ci4 || posaux == ci5 || posaux == ci6 || posaux == ci7 || posaux == ci8 || posaux == ci9 || posaux == ci10 || posaux == ci11 || posaux == ci12 || posaux == ci13 || posaux == ci14 || posaux == ci15)
                                {
                                    if (bandera && botones[posaux].ImageUrl.Equals("vacio.png")) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; }
                                    break;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j1c1 + ".png") || botones[posaux].ImageUrl.Equals(j1c2 + ".png") || botones[posaux].ImageUrl.Equals(j1c3 + ".png") || botones[posaux].ImageUrl.Equals(j1c4 + ".png") || botones[posaux].ImageUrl.Equals(j1c5 + ".png"))
                                {
                                    bandera = true;
                                }
                                else if (botones[posaux].ImageUrl.Equals(j2c1 + ".png") || botones[posaux].ImageUrl.Equals(j2c2 + ".png") || botones[posaux].ImageUrl.Equals(j2c3 + ".png") || botones[posaux].ImageUrl.Equals(j2c4 + ".png") || botones[posaux].ImageUrl.Equals(j2c5 + ".png"))
                                {
                                    if (paso == 0) { paso = 1; } else { break; }
                                }
                                else if (botones[posaux].ImageUrl.Equals("pivote.png")) { break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") && bandera) { botones[posaux].ImageUrl = "pivote.png"; botones[posaux].Enabled = true; break; }
                                else if (botones[posaux].ImageUrl.Equals("vacio.png") && !bandera) { break; }
                            } else { break; }
                            posaux = posaux + columnas + 1;
                        }
                    }
                }
            }
        }

        //Guardar Partidas
        protected void guardar_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuPrincipal.aspx");
        }

        //Estado Finalizado. Ganado, Perdido, Empatado
        public void terminar()
        {
            puntos1 = 0;
            puntos2 = 0;
            foreach (ImageButton i in botones)
            {
                if (i.ImageUrl.Equals(j1c1 + ".png") || i.ImageUrl.Equals(j1c2 + ".png") || i.ImageUrl.Equals(j1c3 + ".png") || i.ImageUrl.Equals(j1c4 + ".png") || i.ImageUrl.Equals(j1c5 + ".png")) { puntos1++; }
                else if (i.ImageUrl.Equals(j2c1 + ".png") || i.ImageUrl.Equals(j2c2 + ".png") || i.ImageUrl.Equals(j2c3 + ".png") || i.ImageUrl.Equals(j2c4 + ".png") || i.ImageUrl.Equals(j2c5 + ".png")) { puntos2++; }
            }
            if (tipo.Equals("Normal"))
            {
                if (puntos2 < puntos1)
                {
                    gamperem = "Victoria";
                }
                else if (puntos2 > puntos1)
                {
                    gamperem = "Perdido";
                }
                else if (puntos2 == puntos1)
                {
                    gamperem = "Empate";
                }
            }
            else {
                if (puntos2 < puntos1)
                {
                    gamperem = "Perdido";
                }
                else if (puntos2 > puntos1)
                {
                    gamperem = "Victoria";
                }
                else if (puntos2 == puntos1)
                {
                    gamperem = "Empate";
                }
            }
        }

        //Terminar Partida o saltar turno
        public void siguiente()
        {
            if (actual.Equals(j1c1) || actual.Equals(j1c2) || actual.Equals(j1c3) || actual.Equals(j1c4) || actual.Equals(j1c5))
            {
                int turno = 0;
                foreach (ImageButton i in botones) { if (i.ImageUrl.Equals("pivote.png")) { turno++; } }
                if (turno == 0)
                {
                    cambiar(); pivotes(); turno = 0;
                    foreach (ImageButton i in botones) { if (i.ImageUrl.Equals("pivote.png")) { turno++; } }
                    if (turno == 0)
                    {
                        terminar();
                        BaseDatos bd = new BaseDatos();
                        string datos = "insert into partidax(puntos,pge,id_usuario) values(@puntos,@pge,@id_usuario)";
                        SqlCommand accion = new SqlCommand(datos, bd.registrar());
                        if (actual.Equals(j1c1) || actual.Equals(j1c2) || actual.Equals(j1c3) || actual.Equals(j1c4) || actual.Equals(j1c5)) { accion.Parameters.AddWithValue("@puntos", puntos1); } else { accion.Parameters.AddWithValue("@puntos", puntos2); }
                        accion.Parameters.AddWithValue("@pge", gamperem);
                        accion.Parameters.AddWithValue("@id_usuario", InicioSesion.jugador);
                        accion.ExecuteNonQuery();
                        Titulo.Text = "Partida Finalizada" + gamperem;
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ventana,", "$('#ventana').modal();", true);
                        panelModal.Update();
                    }
                    else
                    {
                        Titulo.Text = "No hay tiros posibles, turno saltado";
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ventana,", "$('#ventana').modal();", true);
                        panelModal.Update();
                    }
                }
            }
            else
            {
                int turno = 0;
                foreach (ImageButton i in botones) { if (i.ImageUrl.Equals("pivote.png")) { turno++; } }
                if (turno == 0)
                {
                    cambiar(); pivotes(); turno = 0;
                    foreach (ImageButton i in botones) { if (i.ImageUrl.Equals("pivote.png")) { turno++; } }
                    if (turno == 0)
                    {
                        terminar();
                        BaseDatos bd = new BaseDatos();
                        string datos = "insert into partidax(puntos,pge,id_usuario) values(@puntos,@pge,@id_usuario)";
                        SqlCommand accion = new SqlCommand(datos, bd.registrar());
                        if (actual.Equals(j1c1) || actual.Equals(j1c2) || actual.Equals(j1c3) || actual.Equals(j1c4) || actual.Equals(j1c5)) { accion.Parameters.AddWithValue("@puntos", puntos1); } else { accion.Parameters.AddWithValue("@puntos", puntos2); }
                        accion.Parameters.AddWithValue("@pge", gamperem);
                        accion.Parameters.AddWithValue("@id_usuario", InicioSesion.jugador);
                        accion.ExecuteNonQuery();
                        Titulo.Text = "Partida Finalizada" + gamperem;
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ventana,", "$('#ventana').modal();", true);
                        panelModal.Update();
                    }
                    else
                    {
                        Titulo.Text = "No hay tiros posibles, turno saltado";
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ventana,", "$('#ventana').modal();", true);
                        panelModal.Update();
                    }
                }
            }
        }
        
        //Cronometro 1
        public void crono1()
        {
            Timer1.Enabled = true;
            Timer2.Enabled = false;
        }

        //Cronometro 2
        public void crono2()
        {
            Timer1.Enabled = false;
            Timer2.Enabled = true;
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            segundos1++;
            Seg1.Text = segundos1.ToString() + " seg";
            if (segundos1 == 60)
            {
                segundos1 = 0;
                Min1.Text = Convert.ToString(minutos1++) + " min";
            }
        }
      
        protected void Timer2_Tick(object sender, EventArgs e)
        {
            segundos2++;
            Seg2.Text = segundos2.ToString() + " seg";
            if (segundos2 == 60)
            {
                segundos2 = 0;
                Min2.Text = Convert.ToString(minutos2++) + " min";
            }
        }
    }
}