using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Proyecto1IPC2
{
    public partial class Tablero : System.Web.UI.Page
    {
        public static string partida = ".";
        public static string color = "negro";
        public static string gamperem = ".";
        public static int mov;
        public static int carga = 0;
        public static bool bandera = false;
        public static int id_partida = 0;
        public static List<int> vuelta = new List<int>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (carga == 1) {
                for (int i = 0; i <= 63; i++)
                {
                    if (MenuPrincipal.colum[i] == "A" && MenuPrincipal.fila[i] == "1")
                    {
                        A1.Enabled = false;
                        A1.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "B" && MenuPrincipal.fila[i] == "1")
                    {
                        B1.Enabled = false;
                        B1.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "C" && MenuPrincipal.fila[i] == "1")
                    {
                        C1.Enabled = false;
                        C1.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "D" && MenuPrincipal.fila[i] == "1")
                    {
                        D1.Enabled = false;
                        D1.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "E" && MenuPrincipal.fila[i] == "1")
                    {
                        E1.Enabled = false;
                        E1.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "F" && MenuPrincipal.fila[i] == "1")
                    {
                        F1.Enabled = false;
                        F1.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "G" && MenuPrincipal.fila[i] == "1")
                    {
                        G1.Enabled = false;
                        G1.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "H" && MenuPrincipal.fila[i] == "1")
                    {
                        H1.Enabled = false;
                        H1.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "A" && MenuPrincipal.fila[i] == "2")
                    {
                        A2.Enabled = false;
                        A2.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "B" && MenuPrincipal.fila[i] == "2")
                    {
                        B2.Enabled = false;
                        B2.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "C" && MenuPrincipal.fila[i] == "2")
                    {
                        C2.Enabled = false;
                        C2.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "D" && MenuPrincipal.fila[i] == "2")
                    {
                        D2.Enabled = false;
                        D2.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "E" && MenuPrincipal.fila[i] == "2")
                    {
                        E2.Enabled = false;
                        E2.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "F" && MenuPrincipal.fila[i] == "2")
                    {
                        F2.Enabled = false;
                        F2.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "G" && MenuPrincipal.fila[i] == "2")
                    {
                        G2.Enabled = false;
                        G2.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "H" && MenuPrincipal.fila[i] == "2")
                    {
                        H2.Enabled = false;
                        H2.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "A" && MenuPrincipal.fila[i] == "3")
                    {
                        A3.Enabled = false;
                        A3.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "B" && MenuPrincipal.fila[i] == "3")
                    {
                        B3.Enabled = false;
                        B3.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "C" && MenuPrincipal.fila[i] == "3")
                    {
                        C3.Enabled = false;
                        C3.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "D" && MenuPrincipal.fila[i] == "3")
                    {
                        D3.Enabled = false;
                        D3.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "E" && MenuPrincipal.fila[i] == "3")
                    {
                        E3.Enabled = false;
                        E3.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "F" && MenuPrincipal.fila[i] == "3")
                    {
                        F3.Enabled = false;
                        F3.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "G" && MenuPrincipal.fila[i] == "3")
                    {
                        G3.Enabled = false;
                        G3.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "H" && MenuPrincipal.fila[i] == "3")
                    {
                        H3.Enabled = false;
                        H3.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "A" && MenuPrincipal.fila[i] == "4")
                    {
                        A4.Enabled = false;
                        A4.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "B" && MenuPrincipal.fila[i] == "4")
                    {
                        B4.Enabled = false;
                        B4.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "C" && MenuPrincipal.fila[i] == "4")
                    {
                        C4.Enabled = false;
                        C4.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "D" && MenuPrincipal.fila[i] == "4")
                    {
                        D4.Enabled = false;
                        D4.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "E" && MenuPrincipal.fila[i] == "4")
                    {
                        E4.Enabled = false;
                        E4.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "F" && MenuPrincipal.fila[i] == "4")
                    {
                        F4.Enabled = false;
                        F4.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "G" && MenuPrincipal.fila[i] == "4")
                    {
                        G4.Enabled = false;
                        G4.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "H" && MenuPrincipal.fila[i] == "4")
                    {
                        H4.Enabled = false;
                        H4.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "A" && MenuPrincipal.fila[i] == "5")
                    {
                        A5.Enabled = false;
                        A5.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "B" && MenuPrincipal.fila[i] == "5")
                    {
                        B5.Enabled = false;
                        B5.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "C" && MenuPrincipal.fila[i] == "5")
                    {
                        C5.Enabled = false;
                        C5.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "D" && MenuPrincipal.fila[i] == "5")
                    {
                        D5.Enabled = false;
                        D5.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "E" && MenuPrincipal.fila[i] == "5")
                    {
                        E5.Enabled = false;
                        E5.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "F" && MenuPrincipal.fila[i] == "5")
                    {
                        F5.Enabled = false;
                        F5.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "G" && MenuPrincipal.fila[i] == "5")
                    {
                        G5.Enabled = false;
                        G5.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "H" && MenuPrincipal.fila[i] == "5")
                    {
                        H5.Enabled = false;
                        H5.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "A" && MenuPrincipal.fila[i] == "6")
                    {
                        A6.Enabled = false;
                        A6.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "B" && MenuPrincipal.fila[i] == "6")
                    {
                        B6.Enabled = false;
                        B6.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "C" && MenuPrincipal.fila[i] == "6")
                    {
                        C6.Enabled = false;
                        C6.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "D" && MenuPrincipal.fila[i] == "6")
                    {
                        D6.Enabled = false;
                        D6.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "E" && MenuPrincipal.fila[i] == "6")
                    {
                        E6.Enabled = false;
                        E6.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "F" && MenuPrincipal.fila[i] == "6")
                    {
                        F6.Enabled = false;
                        F6.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "G" && MenuPrincipal.fila[i] == "6")
                    {
                        G6.Enabled = false;
                        G6.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "H" && MenuPrincipal.fila[i] == "6")
                    {
                        H6.Enabled = false;
                        H6.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "A" && MenuPrincipal.fila[i] == "7")
                    {
                        A7.Enabled = false;
                        A7.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "B" && MenuPrincipal.fila[i] == "7")
                    {
                        B7.Enabled = false;
                        B7.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "C" && MenuPrincipal.fila[i] == "7")
                    {
                        C7.Enabled = false;
                        C7.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "D" && MenuPrincipal.fila[i] == "7")
                    {
                        D7.Enabled = false;
                        D7.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "E" && MenuPrincipal.fila[i] == "7")
                    {
                        E7.Enabled = false;
                        E7.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "F" && MenuPrincipal.fila[i] == "7")
                    {
                        F7.Enabled = false;
                        F7.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "G" && MenuPrincipal.fila[i] == "7")
                    {
                        G7.Enabled = false;
                        G7.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "H" && MenuPrincipal.fila[i] == "7")
                    {
                        H7.Enabled = false;
                        H7.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "A" && MenuPrincipal.fila[i] == "8")
                    {
                        A8.Enabled = false;
                        A8.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "B" && MenuPrincipal.fila[i] == "8")
                    {
                        B8.Enabled = false;
                        B8.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "C" && MenuPrincipal.fila[i] == "8")
                    {
                        C8.Enabled = false;
                        C8.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "D" && MenuPrincipal.fila[i] == "8")
                    {
                        D8.Enabled = false;
                        D8.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "E" && MenuPrincipal.fila[i] == "8")
                    {
                        E8.Enabled = false;
                        E8.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "F" && MenuPrincipal.fila[i] == "8")
                    {
                        F8.Enabled = false;
                        F8.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "G" && MenuPrincipal.fila[i] == "8")
                    {
                        G8.Enabled = false;
                        G8.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                    else if (MenuPrincipal.colum[i] == "H" && MenuPrincipal.fila[i] == "8")
                    {
                        H8.Enabled = false;
                        H8.ImageUrl = MenuPrincipal.colores[i] + ".png";
                    }
                }
                bandera = true;
                carga++;
                pivote();
            }
            if (carga == 0) {
                pivote();
                carga = 2;
            }
        }


        protected void A1_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                A1.ImageUrl = "negro.png";
                A1.Enabled = false;
                mov++;
                MenuPrincipal.colores[0] = "negro";
                MenuPrincipal.colum[0] = "A";
                MenuPrincipal.fila[0] = "1";
                obtenerV(0);
                color = "blanco";
                pivote();
            }
            else if(color == "blanco")
            {
                A1.ImageUrl = "blanco.png";
                A1.Enabled = false;
                mov++;
                MenuPrincipal.colores[0] = "blanco";
                MenuPrincipal.colum[0] = "A";
                MenuPrincipal.fila[0] = "1";
                obtenerV(0);
                color = "negro";
                pivote();
            }
        }

        protected void B1_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                B1.ImageUrl = "negro.png";
                B1.Enabled = false;
                mov++;
                MenuPrincipal.colores[1] = "negro";
                MenuPrincipal.colum[1] = "B";
                MenuPrincipal.fila[1] = "1";
                obtenerV(1);
                color = "blanco";
                pivote();
            }
            else
            {
                B1.ImageUrl = "blanco.png";
                B1.Enabled = false;
                mov++;
                MenuPrincipal.colores[1] = "blanco";
                MenuPrincipal.colum[1] = "B";
                MenuPrincipal.fila[1] = "1";
                obtenerV(1);
                color = "negro";
                pivote();
            }
        }

        protected void C1_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                C1.ImageUrl = "negro.png";
                C1.Enabled = false;
                
                mov++;
                MenuPrincipal.colores[2] = "negro";
                MenuPrincipal.colum[2] = "C";
                MenuPrincipal.fila[2] = "1";
                obtenerV(2);
                color = "blanco";
                pivote();
            }
            else
            {
                C1.ImageUrl = "blanco.png";
                C1.Enabled = false;
                mov++;
                MenuPrincipal.colores[2] = "blanco";
                MenuPrincipal.colum[2] = "C";
                MenuPrincipal.fila[2] = "1";
                obtenerV(2);
                color = "negro";
                pivote();
            }
        }

        protected void D1_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                D1.ImageUrl = "negro.png";
                D1.Enabled = false;
                mov++;
                MenuPrincipal.colores[3] = "negro";
                MenuPrincipal.colum[3] = "D";
                MenuPrincipal.fila[3] = "1";
                obtenerV(3);
                color = "blanco";
                pivote();
            }
            else
            {
                D1.ImageUrl = "blanco.png";
                D1.Enabled = false;
                mov++;
                MenuPrincipal.colores[3] = "blanco";
                MenuPrincipal.colum[3] = "D";
                MenuPrincipal.fila[3] = "1";
                obtenerV(3);
                color = "negro";
                pivote();
            }
        }

        protected void E1_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                E1.ImageUrl = "negro.png";
                E1.Enabled = false;
                mov++;
                MenuPrincipal.colores[4] = "negro";
                MenuPrincipal.colum[4] = "E";
                MenuPrincipal.fila[4] = "1";
                obtenerV(4);
                color = "blanco";
                pivote();
            }
            else
            {
                E1.ImageUrl = "blanco.png";
                E1.Enabled = false;
                mov++;
                MenuPrincipal.colores[4] = "blanco";
                MenuPrincipal.colum[4] = "E";
                MenuPrincipal.fila[4] = "1";
                obtenerV(4);
                color = "negro";
                pivote();
            }
        }

        protected void F1_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                F1.ImageUrl = "negro.png";
                F1.Enabled = false;
                mov++;
                MenuPrincipal.colores[5] = "negro";
                MenuPrincipal.colum[5] = "F";
                MenuPrincipal.fila[5] = "1";
                obtenerV(5);
                color = "blanco";
                pivote();
            }
            else
            {
                F1.ImageUrl = "blanco.png";
                F1.Enabled = false;
                mov++;
                MenuPrincipal.colores[5] = "blanco";
                MenuPrincipal.colum[5] = "F";
                MenuPrincipal.fila[5] = "1";
                obtenerV(5);
                color = "negro";
                pivote();
            }
        }

        protected void G1_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                G1.ImageUrl = "negro.png";
                G1.Enabled = false;
                mov++;
                MenuPrincipal.colores[6] = "negro";
                MenuPrincipal.colum[6] = "G";
                MenuPrincipal.fila[6] = "1";
                obtenerV(6);
                color = "blanco";
                pivote();
            }
            else
            {
                G1.ImageUrl = "blanco.png";
                G1.Enabled = false;
                mov++;
                MenuPrincipal.colores[6] = "blanco";
                MenuPrincipal.colum[6] = "G";
                MenuPrincipal.fila[6] = "1";
                obtenerV(6);
                color = "negro";
                pivote();
            }
        }

        protected void H1_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                H1.ImageUrl = "negro.png";
                H1.Enabled = false;
                mov++;
                MenuPrincipal.colores[7] = "negro";
                MenuPrincipal.colum[7] = "H";
                MenuPrincipal.fila[7] = "1";
                obtenerV(7);
                color = "blanco";
                pivote();
            }
            else
            {
                H1.ImageUrl = "blanco.png";
                H1.Enabled = false;
                mov++;
                MenuPrincipal.colores[7] = "blanco";
                MenuPrincipal.colum[7] = "H";
                MenuPrincipal.fila[7] = "1";
                obtenerV(7);
                color = "negro";
                pivote();
            }
        }

        protected void A2_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                A2.ImageUrl = "negro.png";
                A2.Enabled = false;
                mov++;
                MenuPrincipal.colores[8] = "negro";
                MenuPrincipal.colum[8] = "A";
                MenuPrincipal.fila[8] = "2";
                obtenerV(8);
                color = "blanco";
                pivote();
            }
            else
            {
                A2.ImageUrl = "blanco.png";
                A2.Enabled = false;
                mov++;
                MenuPrincipal.colores[8] = "blanco";
                MenuPrincipal.colum[8] = "A";
                MenuPrincipal.fila[8] = "2";
                obtenerV(8);
                color = "negro";
                pivote();
            }
        }

        protected void B2_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                B2.ImageUrl = "negro.png";
                B2.Enabled = false;
                mov++;
                MenuPrincipal.colores[9] = "negro";
                MenuPrincipal.colum[9] = "B";
                MenuPrincipal.fila[9] = "2";
                obtenerV(9);
                color = "blanco";
                pivote();
            }
            else
            {
                B2.ImageUrl = "blanco.png";
                B2.Enabled = false;
                mov++;
                MenuPrincipal.colores[9] = "blanco";
                MenuPrincipal.colum[9] = "B";
                MenuPrincipal.fila[9] = "2";
                obtenerV(9);
                color = "negro";
                pivote();
            }
        }

        protected void C2_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                C2.ImageUrl = "negro.png";
                C2.Enabled = false;
                mov++;
                MenuPrincipal.colores[10] = "negro";
                MenuPrincipal.colum[10] = "C";
                MenuPrincipal.fila[10] = "2";
                obtenerV(10);
                color = "blanco";
                pivote();
            }
            else
            {
                C2.ImageUrl = "blanco.png";
                C2.Enabled = false;
                mov++;
                MenuPrincipal.colores[10] = "blanco";
                MenuPrincipal.colum[10] = "C";
                MenuPrincipal.fila[10] = "2";
                obtenerV(10);
                color = "negro";
                pivote();
            }
        }

        protected void D2_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                D2.ImageUrl = "negro.png";
                D2.Enabled = false;
                mov++;
                MenuPrincipal.colores[11] = "negro";
                MenuPrincipal.colum[11] = "D";
                MenuPrincipal.fila[11] = "2";
                obtenerV(11);
                color = "blanco";
                pivote();
            }
            else
            {
                D2.ImageUrl = "blanco.png";
                D2.Enabled = false;
                mov++;
                MenuPrincipal.colores[11] = "blanco";
                MenuPrincipal.colum[11] = "D";
                MenuPrincipal.fila[11] = "2";
                obtenerV(11);
                color = "negro";
                pivote();
            }
        }

        protected void E2_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                E2.ImageUrl = "negro.png";
                E2.Enabled = false;
                mov++;
                MenuPrincipal.colores[12] = "negro";
                MenuPrincipal.colum[12] = "E";
                MenuPrincipal.fila[12] = "2";
                obtenerV(12);
                color = "blanco";
                pivote();
            }
            else
            {
                E2.ImageUrl = "blanco.png";
                E2.Enabled = false;
                mov++;
                MenuPrincipal.colores[12] = "blanco";
                MenuPrincipal.colum[12] = "E";
                MenuPrincipal.fila[12] = "2";
                obtenerV(12);
                color = "negro";
                pivote();
            }
        }

        protected void F2_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                F2.ImageUrl = "negro.png";
                F2.Enabled = false;
                mov++;
                MenuPrincipal.colores[13] = "negro";
                MenuPrincipal.colum[13] = "F";
                MenuPrincipal.fila[13] = "2";
                obtenerV(13);
                color = "blanco";
                pivote();
            }
            else
            {
                F2.ImageUrl = "blanco.png";
                F2.Enabled = false;
                mov++;
                MenuPrincipal.colores[13] = "blanco";
                MenuPrincipal.colum[13] = "F";
                MenuPrincipal.fila[13] = "2";
                obtenerV(13);
                color = "negro";
                pivote();
            }
        }

        protected void G2_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                G2.ImageUrl = "negro.png";
                G2.Enabled = false;
                mov++;
                MenuPrincipal.colores[14] = "negro";
                MenuPrincipal.colum[14] = "G";
                MenuPrincipal.fila[14] = "2";
                obtenerV(14);
                color = "blanco";
                pivote();
            }
            else
            {
                G2.ImageUrl = "blanco.png";
                G2.Enabled = false;
                mov++;
                MenuPrincipal.colores[14] = "blanco";
                MenuPrincipal.colum[14] = "G";
                MenuPrincipal.fila[14] = "2";
                obtenerV(14);
                color = "negro";
                pivote();
            }
        }

        protected void H2_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                H2.ImageUrl = "negro.png";
                H2.Enabled = false;
                mov++;
                MenuPrincipal.colores[15] = "negro";
                MenuPrincipal.colum[15] = "H";
                MenuPrincipal.fila[15] = "2";
                obtenerV(15);
                color = "blanco";
                pivote();
            }
            else
            {
                H2.ImageUrl = "blanco.png";
                H2.Enabled = false;
                mov++;
                MenuPrincipal.colores[15] = "blanco";
                MenuPrincipal.colum[15] = "H";
                MenuPrincipal.fila[15] = "2";
                obtenerV(15);
                color = "negro";
                pivote();
            }
        }

        protected void A3_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                A3.ImageUrl = "negro.png";
                A3.Enabled = false;
                mov++;
                MenuPrincipal.colores[16] = "negro";
                MenuPrincipal.colum[16] = "A";
                MenuPrincipal.fila[16] = "3";
                obtenerV(16);
                color = "blanco";
                pivote();
            }
            else
            {
                A3.ImageUrl = "blanco.png";
                A3.Enabled = false;
                mov++;
                MenuPrincipal.colores[16] = "blanco";
                MenuPrincipal.colum[16] = "A";
                MenuPrincipal.fila[16] = "3";
                obtenerV(16);
                color = "negro";
                pivote();
            }
        }

        protected void B3_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                B3.ImageUrl = "negro.png";
                B3.Enabled = false;
                mov++;
                MenuPrincipal.colores[17] = "negro";
                MenuPrincipal.colum[17] = "B";
                MenuPrincipal.fila[17] = "3";
                obtenerV(17);
                color = "blanco";
                pivote();
            }
            else
            {
                B3.ImageUrl = "blanco.png";
                B3.Enabled = false;
                mov++;
                MenuPrincipal.colores[17] = "blanco";
                MenuPrincipal.colum[17] = "B";
                MenuPrincipal.fila[17] = "3";
                obtenerV(17);
                color = "negro";
                pivote();
            }
        }

        protected void C3_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                C3.ImageUrl = "negro.png";
                C3.Enabled = false;
                mov++;
                MenuPrincipal.colores[18] = "negro";
                MenuPrincipal.colum[18] = "C";
                MenuPrincipal.fila[18] = "3";
                obtenerV(18);
                color = "blanco";
                pivote();
            }
            else
            {
                C3.ImageUrl = "blanco.png";
                C3.Enabled = false;
                mov++;
                MenuPrincipal.colores[18] = "blanco";
                MenuPrincipal.colum[18] = "C";
                MenuPrincipal.fila[18] = "3";
                obtenerV(18);
                color = "negro";
                pivote();
            }
        }

        protected void D3_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                D3.ImageUrl = "negro.png";
                D3.Enabled = false;
                mov++;
                MenuPrincipal.colores[19] = "negro";
                MenuPrincipal.colum[19] = "D";
                MenuPrincipal.fila[19] = "3";
                obtenerV(19);
                color = "blanco";
                pivote();
            }
            else
            {
                D3.ImageUrl = "blanco.png";
                D3.Enabled = false;
                mov++;
                MenuPrincipal.colores[19] = "blanco";
                MenuPrincipal.colum[19] = "D";
                MenuPrincipal.fila[19] = "3";
                obtenerV(19);
                color = "negro";
                pivote();
            }
        }

        protected void E3_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                E3.ImageUrl = "negro.png";
                E3.Enabled = false;
                mov++;
                MenuPrincipal.colores[20] = "negro";
                MenuPrincipal.colum[20] = "E";
                MenuPrincipal.fila[20] = "3";
                obtenerV(20);
                color = "blanco";
                pivote();
            }
            else
            {
                E3.ImageUrl = "blanco.png";
                E3.Enabled = false;
                mov++;
                MenuPrincipal.colores[20] = "blanco";
                MenuPrincipal.colum[20] = "E";
                MenuPrincipal.fila[20] = "3";
                obtenerV(20);
                color = "negro";
                pivote();
            }
        }

        protected void F3_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                F3.ImageUrl = "negro.png";
                F3.Enabled = false;
                mov++;
                MenuPrincipal.colores[21] = "negro";
                MenuPrincipal.colum[21] = "F";
                MenuPrincipal.fila[21] = "3";
                obtenerV(21);
                color = "blanco";
                pivote();
            }
            else
            {
                F3.ImageUrl = "blanco.png";
                F3.Enabled = false;
                mov++;
                MenuPrincipal.colores[21] = "blanco";
                MenuPrincipal.colum[21] = "F";
                MenuPrincipal.fila[21] = "3";
                obtenerV(21);
                color = "negro";
                pivote();
            }
        }

        protected void G3_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                G3.ImageUrl = "negro.png";
                G3.Enabled = false;
                mov++;
                MenuPrincipal.colores[22] = "negro";
                MenuPrincipal.colum[22] = "G";
                MenuPrincipal.fila[22] = "3";
                obtenerV(22);
                color = "blanco";
                pivote();
            }
            else
            {
                G3.ImageUrl = "blanco.png";
                G3.Enabled = false;
                mov++;
                MenuPrincipal.colores[22] = "blanco";
                MenuPrincipal.colum[22] = "G";
                MenuPrincipal.fila[22] = "3";
                obtenerV(22);
                color = "negro";
                pivote();
            }
        }

        protected void H3_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                H3.ImageUrl = "negro.png";
                H3.Enabled = false;
                mov++;
                MenuPrincipal.colores[23] = "negro";
                MenuPrincipal.colum[23] = "H";
                MenuPrincipal.fila[23] = "3";
                obtenerV(23);
                color = "blanco";
                pivote();
            }
            else
            {
                H3.ImageUrl = "blanco.png";
                H3.Enabled = false;
                mov++;
                MenuPrincipal.colores[23] = "blanco";
                MenuPrincipal.colum[23] = "H";
                MenuPrincipal.fila[23] = "3";
                obtenerV(23);
                color = "negro";
                pivote();
            }
        }

        protected void A4_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                A4.ImageUrl = "negro.png";
                A4.Enabled = false;
                mov++;
                MenuPrincipal.colores[24] = "negro";
                MenuPrincipal.colum[24] = "A";
                MenuPrincipal.fila[24] = "4";
                obtenerV(24);
                color = "blanco";
                pivote();
            }
            else
            {
                A4.ImageUrl = "blanco.png";
                A4.Enabled = false;
                mov++;
                MenuPrincipal.colores[24] = "blanco";
                MenuPrincipal.colum[24] = "A";
                MenuPrincipal.fila[24] = "4";
                obtenerV(24);
                color = "negro";
                pivote();
            }
        }

        protected void B4_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                B4.ImageUrl = "negro.png";
                B4.Enabled = false;
                mov++;
                MenuPrincipal.colores[25] = "negro";
                MenuPrincipal.colum[25] = "B";
                MenuPrincipal.fila[25] = "4";
                obtenerV(25);
                color = "blanco";
                pivote();
            }
            else
            {
                B4.ImageUrl = "blanco.png";
                B4.Enabled = false;
                mov++;
                MenuPrincipal.colores[25] = "blanco";
                MenuPrincipal.colum[25] = "B";
                MenuPrincipal.fila[25] = "4";
                obtenerV(25);
                color = "negro";
                pivote();
            }
        }

        protected void C4_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                C4.ImageUrl = "negro.png";
                C4.Enabled = false;
                mov++;
                MenuPrincipal.colores[26] = "negro";
                MenuPrincipal.colum[26] = "C";
                MenuPrincipal.fila[26] = "4";
                obtenerV(26);
                color = "blanco";
                pivote();
            }
            else
            {
                C4.ImageUrl = "blanco.png";
                C4.Enabled = false;
                mov++;
                MenuPrincipal.colores[26] = "blanco";
                MenuPrincipal.colum[26] = "C";
                MenuPrincipal.fila[26] = "4";
                obtenerV(26);
                color = "negro";
                pivote();
            }
        }

        protected void D4_Click(object sender, ImageClickEventArgs e)
        {
            
        }

        protected void E4_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void F4_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                F4.ImageUrl = "negro.png";
                F4.Enabled = false;
                mov++;
                MenuPrincipal.colores[29] = "negro";
                MenuPrincipal.colum[29] = "F";
                MenuPrincipal.fila[29] = "4";
                obtenerV(29);
                color = "blanco";
                pivote();
            }
            else
            {
                F4.ImageUrl = "blanco.png";
                F4.Enabled = false;
                mov++;
                MenuPrincipal.colores[29] = "blanco";
                MenuPrincipal.colum[29] = "F";
                MenuPrincipal.fila[29] = "4";
                obtenerV(29);
                color = "negro";
                pivote();
            }
        }

        protected void G4_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                G4.ImageUrl = "negro.png";
                G4.Enabled = false;
                mov++;
                MenuPrincipal.colores[30] = "negro";
                MenuPrincipal.colum[30] = "G";
                MenuPrincipal.fila[30] = "4";
                obtenerV(30);
                color = "blanco";
                pivote();
            }
            else
            {
                G4.ImageUrl = "blanco.png";
                G4.Enabled = false;
                mov++;
                MenuPrincipal.colores[30] = "blanco";
                MenuPrincipal.colum[30] = "G";
                MenuPrincipal.fila[30] = "4";
                obtenerV(30);
                color = "negro";
                pivote();
            }
        }

        protected void H4_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                H4.ImageUrl = "negro.png";
                H4.Enabled = false;
                mov++;
                MenuPrincipal.colores[31] = "negro";
                MenuPrincipal.colum[31] = "H";
                MenuPrincipal.fila[31] = "4";
                obtenerV(31);
                color = "blanco";
                pivote();
            }
            else
            {
                H4.ImageUrl = "blanco.png";
                H4.Enabled = false;
                mov++;
                MenuPrincipal.colores[31] = "blanco";
                MenuPrincipal.colum[31] = "H";
                MenuPrincipal.fila[31] = "4";
                obtenerV(31);
                color = "negro";
                pivote();
            }
        }

        protected void A5_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                A5.ImageUrl = "negro.png";
                A5.Enabled = false;
                mov++;
                MenuPrincipal.colores[32] = "negro";
                MenuPrincipal.colum[32] = "A";
                MenuPrincipal.fila[32] = "5";
                obtenerV(32);
                color = "blanco";
                pivote();
            }
            else
            {
                A5.ImageUrl = "blanco.png";
                A5.Enabled = false;
                mov++;
                MenuPrincipal.colores[32] = "blanco";
                MenuPrincipal.colum[32] = "A";
                MenuPrincipal.fila[32] = "5";
                obtenerV(32);
                color = "negro";
                pivote();
            }
        }

        protected void B5_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                B5.ImageUrl = "negro.png";
                B5.Enabled = false;
                mov++;
                MenuPrincipal.colores[33] = "negro";
                MenuPrincipal.colum[33] = "B";
                MenuPrincipal.fila[33] = "5";
                obtenerV(33);
                color = "blanco";
                pivote();
            }
            else
            {
                B5.ImageUrl = "blanco.png";
                B5.Enabled = false;
                mov++;
                MenuPrincipal.colores[33] = "blanco";
                MenuPrincipal.colum[33] = "B";
                MenuPrincipal.fila[33] = "5";
                obtenerV(33);
                color = "negro";
                pivote();
            }
        }

        protected void C5_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                C5.ImageUrl = "negro.png";
                C5.Enabled = false;
                mov++;
                MenuPrincipal.colores[34] = "negro";
                MenuPrincipal.colum[34] = "C";
                MenuPrincipal.fila[34] = "5";
                obtenerV(34);
                color = "blanco";
                pivote();
            }
            else
            {
                C5.ImageUrl = "blanco.png";
                C5.Enabled = false;
                mov++;
                MenuPrincipal.colores[34] = "blanco";
                MenuPrincipal.colum[34] = "C";
                MenuPrincipal.fila[34] = "5";
                obtenerV(34);
                color = "negro";
                pivote();
            }
        }

        protected void D5_Click(object sender, ImageClickEventArgs e)
        {
           
        }

        protected void E5_Click(object sender, ImageClickEventArgs e)
        {
            
        }

        protected void F5_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                F5.ImageUrl = "negro.png";
                F5.Enabled = false;
                mov++;
                MenuPrincipal.colores[37] = "negro";
                MenuPrincipal.colum[37] = "F";
                MenuPrincipal.fila[37] = "5";
                obtenerV(37);
                color = "blanco";
                pivote();
            }
            else
            {
                F5.ImageUrl = "blanco.png";
                F5.Enabled = false;
                mov++;
                MenuPrincipal.colores[37] = "blanco";
                MenuPrincipal.colum[37] = "F";
                MenuPrincipal.fila[37] = "5";
                obtenerV(37);
                color = "negro";
                pivote();
            }
        }

        protected void G5_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                G5.ImageUrl = "negro.png";
                G5.Enabled = false;
                mov++;
                MenuPrincipal.colores[38] = "negro";
                MenuPrincipal.colum[38] = "G";
                MenuPrincipal.fila[38] = "5";
                obtenerV(38);
                color = "blanco";
                pivote();
            }
            else
            {
                G5.ImageUrl = "blanco.png";
                G5.Enabled = false;
                mov++;
                MenuPrincipal.colores[38] = "blanco";
                MenuPrincipal.colum[38] = "G";
                MenuPrincipal.fila[38] = "5";
                obtenerV(38);
                color = "negro";
                pivote();
            }
        }

        protected void H5_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                H5.ImageUrl = "negro.png";
                H5.Enabled = false;
                mov++;
                MenuPrincipal.colores[39] = "negro";
                MenuPrincipal.colum[39] = "H";
                MenuPrincipal.fila[39] = "5";
                obtenerV(39);
                color = "blanco";
                pivote();
            }
            else
            {
                H5.ImageUrl = "blanco.png";
                H5.Enabled = false;
                mov++;
                MenuPrincipal.colores[39] = "blanco";
                MenuPrincipal.colum[39] = "H";
                MenuPrincipal.fila[39] = "5";
                obtenerV(39);
                color = "negro";
                pivote();
            }
        }

        protected void A6_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                A6.ImageUrl = "negro.png";
                A6.Enabled = false;
                mov++;
                MenuPrincipal.colores[40] = "negro";
                MenuPrincipal.colum[40] = "A";
                MenuPrincipal.fila[40] = "6";
                obtenerV(40);
                color = "blanco";
                pivote();
            }
            else
            {
                A6.ImageUrl = "blanco.png";
                A6.Enabled = false;
                mov++;
                MenuPrincipal.colores[40] = "blanco";
                MenuPrincipal.colum[40] = "A";
                MenuPrincipal.fila[40] = "6";
                obtenerV(40);
                color = "negro";
                pivote();
            }
        }

        protected void B6_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                B6.ImageUrl = "negro.png";
                B6.Enabled = false;
                mov++;
                MenuPrincipal.colores[41] = "negro";
                MenuPrincipal.colum[41] = "B";
                MenuPrincipal.fila[41] = "6";
                obtenerV(41);
                color = "blanco";
                pivote();
            }
            else
            {
                B6.ImageUrl = "blanco.png";
                B6.Enabled = false;
                mov++;
                MenuPrincipal.colores[41] = "blanco";
                MenuPrincipal.colum[41] = "B";
                MenuPrincipal.fila[41] = "6";
                obtenerV(41);
                color = "negro";
                pivote();
            }
        }

        protected void C6_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                C6.ImageUrl = "negro.png";
                C6.Enabled = false;
                mov++;
                MenuPrincipal.colores[42] = "negro";
                MenuPrincipal.colum[42] = "C";
                MenuPrincipal.fila[42] = "6";
                obtenerV(42);
                color = "blanco";
                pivote();
            }
            else
            {
                C6.ImageUrl = "blanco.png";
                C6.Enabled = false;
                mov++;
                MenuPrincipal.colores[42] = "blanco";
                MenuPrincipal.colum[42] = "C";
                MenuPrincipal.fila[42] = "6";
                obtenerV(42);
                color = "negro";
                pivote();
            }
        }

        protected void D6_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                D6.ImageUrl = "negro.png";
                D6.Enabled = false;
                mov++;
                MenuPrincipal.colores[43] = "negro";
                MenuPrincipal.colum[43] = "D";
                MenuPrincipal.fila[43] = "6";
                obtenerV(43);
                color = "blanco";
                pivote();
            }
            else
            {
                D6.ImageUrl = "blanco.png";
                D6.Enabled = false;
                mov++;
                MenuPrincipal.colores[43] = "blanco";
                MenuPrincipal.colum[43] = "D";
                MenuPrincipal.fila[43] = "6";
                obtenerV(43);
                color = "negro";
                pivote();
            }
        }

        protected void E6_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                E6.ImageUrl = "negro.png";
                E6.Enabled = false;
                mov++;
                MenuPrincipal.colores[44] = "negro";
                MenuPrincipal.colum[44] = "E";
                MenuPrincipal.fila[44] = "6";
                obtenerV(44);
                color = "blanco";
                pivote();
            }
            else
            {
                E6.ImageUrl = "blanco.png";
                E6.Enabled = false;
                mov++;
                MenuPrincipal.colores[44] = "blanco";
                MenuPrincipal.colum[44] = "E";
                MenuPrincipal.fila[44] = "6";
                obtenerV(44);
                color = "negro";
                pivote();
            }
        }

        protected void F6_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                F6.ImageUrl = "negro.png";
                F6.Enabled = false;
                mov++;
                MenuPrincipal.colores[45] = "negro";
                MenuPrincipal.colum[45] = "F";
                MenuPrincipal.fila[45] = "6";
                obtenerV(45);
                color = "blanco";
                pivote();
            }
            else
            {
                F6.ImageUrl = "blanco.png";
                F6.Enabled = false;
                mov++;
                MenuPrincipal.colores[45] = "blanco";
                MenuPrincipal.colum[45] = "F";
                MenuPrincipal.fila[45] = "6";
                obtenerV(45);
                color = "negro";
                pivote();
            }
        }

        protected void G6_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                G6.ImageUrl = "negro.png";
                G6.Enabled = false;
                mov++;
                MenuPrincipal.colores[46] = "negro";
                MenuPrincipal.colum[46] = "G";
                MenuPrincipal.fila[46] = "6";
                obtenerV(46);
                color = "blanco";
                pivote();
            }
            else
            {
                G6.ImageUrl = "blanco.png";
                G6.Enabled = false;
                mov++;
                MenuPrincipal.colores[46] = "blanco";
                MenuPrincipal.colum[46] = "G";
                MenuPrincipal.fila[46] = "6";
                obtenerV(46);
                color = "negro";
                pivote();
            }
        }

        protected void H6_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                H6.ImageUrl = "negro.png";
                H6.Enabled = false;
                mov++;
                MenuPrincipal.colores[47] = "negro";
                MenuPrincipal.colum[47] = "H";
                MenuPrincipal.fila[47] = "6";
                obtenerV(47);
                color = "blanco";
                pivote();
            }
            else
            {
                H6.ImageUrl = "blanco.png";
                H6.Enabled = false;
                mov++;
                MenuPrincipal.colores[47] = "blanco";
                MenuPrincipal.colum[47] = "H";
                MenuPrincipal.fila[47] = "6";
                obtenerV(47);
                color = "negro";
                pivote();
            }
        }

        protected void A7_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                A7.ImageUrl = "negro.png";
                A7.Enabled = false;
                mov++;
                MenuPrincipal.colores[48] = "negro";
                MenuPrincipal.colum[48] = "A";
                MenuPrincipal.fila[48] = "7";
                obtenerV(48);
                color = "blanco";
                pivote();
            }
            else
            {
                A7.ImageUrl = "blanco.png";
                A7.Enabled = false;
                mov++;
                MenuPrincipal.colores[48] = "blanco";
                MenuPrincipal.colum[48] = "A";
                MenuPrincipal.fila[48] = "7";
                obtenerV(48);
                color = "negro";
                pivote();
            }
        }

        protected void B7_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                B7.ImageUrl = "negro.png";
                B7.Enabled = false;
                mov++;
                MenuPrincipal.colores[49] = "negro";
                MenuPrincipal.colum[49] = "B";
                MenuPrincipal.fila[49] = "7";
                obtenerV(49);
                color = "blanco";
                pivote();
            }
            else
            {
                B7.ImageUrl = "blanco.png";
                B7.Enabled = false;
                mov++;
                MenuPrincipal.colores[49] = "blanco";
                MenuPrincipal.colum[49] = "B";
                MenuPrincipal.fila[49] = "7";
                obtenerV(49);
                color = "negro";
                pivote();
            }
        }

        protected void C7_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                C7.ImageUrl = "negro.png";
                C7.Enabled = false;
                mov++;
                MenuPrincipal.colores[50] = "negro";
                MenuPrincipal.colum[50] = "C";
                MenuPrincipal.fila[50] = "7";
                obtenerV(50);
                color = "blanco";
                pivote();
            }
            else
            {
                C7.ImageUrl = "blanco.png";
                C7.Enabled = false;
                mov++;
                MenuPrincipal.colores[50] = "blanco";
                MenuPrincipal.colum[50] = "C";
                MenuPrincipal.fila[50] = "7";
                obtenerV(50);
                color = "negro";
                pivote();
            }
        }

        protected void D7_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                D7.ImageUrl = "negro.png";
                D7.Enabled = false;
                mov++;
                MenuPrincipal.colores[51] = "negro";
                MenuPrincipal.colum[51] = "D";
                MenuPrincipal.fila[51] = "7";
                obtenerV(51);
                color = "blanco";
                pivote();
            }
            else
            {
                D7.ImageUrl = "blanco.png";
                D7.Enabled = false;
                mov++;
                MenuPrincipal.colores[51] = "blanco";
                MenuPrincipal.colum[51] = "D";
                MenuPrincipal.fila[51] = "7";
                obtenerV(51);
                color = "negro";
                pivote();
            }
        }

        protected void E7_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                E7.ImageUrl = "negro.png";
                E7.Enabled = false;
                mov++;
                MenuPrincipal.colores[52] = "negro";
                MenuPrincipal.colum[52] = "E";
                MenuPrincipal.fila[52] = "7";
                obtenerV(52);
                color = "blanco";
                pivote();
            }
            else
            {
                E7.ImageUrl = "blanco.png";
                E7.Enabled = false;
                mov++;
                MenuPrincipal.colores[52] = "blanco";
                MenuPrincipal.colum[52] = "E";
                MenuPrincipal.fila[52] = "7";
                obtenerV(52);
                color = "negro";
                pivote();
            }
        }

        protected void F7_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                F7.ImageUrl = "negro.png";
                F7.Enabled = false;
                mov++;
                MenuPrincipal.colores[53] = "negro";
                MenuPrincipal.colum[53] = "F";
                MenuPrincipal.fila[53] = "7";
                obtenerV(53);
                color = "blanco";
                pivote();
            }
            else
            {
                F7.ImageUrl = "blanco.png";
                F7.Enabled = false;
                mov++;
                MenuPrincipal.colores[53] = "blanco";
                MenuPrincipal.colum[53] = "F";
                MenuPrincipal.fila[53] = "7";
                obtenerV(53);
                color = "negro";
                pivote();
            }
        }

        protected void G7_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                G7.ImageUrl = "negro.png";
                G7.Enabled = false;
                mov++;
                MenuPrincipal.colores[54] = "negro";
                MenuPrincipal.colum[54] = "G";
                MenuPrincipal.fila[54] = "7";
                obtenerV(54);
                color = "blanco";
                pivote();
            }
            else
            {
                G7.ImageUrl = "blanco.png";
                G7.Enabled = false;
                mov++;
                MenuPrincipal.colores[54] = "blanco";
                MenuPrincipal.colum[54] = "G";
                MenuPrincipal.fila[54] = "7";
                obtenerV(54);
                color = "negro";
                pivote();
            }
        }

        protected void H7_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                H7.ImageUrl = "negro.png";
                H7.Enabled = false;
                mov++;
                MenuPrincipal.colores[55] = "negro";
                MenuPrincipal.colum[55] = "H";
                MenuPrincipal.fila[55] = "7";
                obtenerV(55);
                color = "blanco";
                pivote();
            }
            else
            {
                H7.ImageUrl = "blanco.png";
                H7.Enabled = false;
                mov++;
                MenuPrincipal.colores[55] = "blanco";
                MenuPrincipal.colum[55] = "H";
                MenuPrincipal.fila[55] = "7";
                obtenerV(55);
                color = "negro";
                pivote();
            }
        }

        protected void A8_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                A8.ImageUrl = "negro.png";
                A8.Enabled = false;
                mov++;
                MenuPrincipal.colores[56] = "negro";
                MenuPrincipal.colum[56] = "A";
                MenuPrincipal.fila[56] = "8";
                obtenerV(56);
                color = "blanco";
                pivote();
            }
            else
            {
                A8.ImageUrl = "blanco.png";
                A8.Enabled = false;
                mov++;
                MenuPrincipal.colores[56] = "blanco";
                MenuPrincipal.colum[56] = "A";
                MenuPrincipal.fila[56] = "8";
                obtenerV(56);
                color = "negro";
                pivote();
            }
        }

        protected void B8_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                B8.ImageUrl = "negro.png";
                B8.Enabled = false;
                mov++;
                MenuPrincipal.colores[57] = "negro";
                MenuPrincipal.colum[57] = "B";
                MenuPrincipal.fila[57] = "8";
                obtenerV(57);
                color = "blanco";
                pivote();
            }
            else
            {
                B8.ImageUrl = "blanco.png";
                B8.Enabled = false;
                mov++;
                MenuPrincipal.colores[57] = "blanco";
                MenuPrincipal.colum[57] = "B";
                MenuPrincipal.fila[57] = "8";
                obtenerV(57);
                color = "negro";
                pivote();
            }
        }

        protected void C8_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                C8.ImageUrl = "negro.png";
                C8.Enabled = false;
                mov++;
                MenuPrincipal.colores[58] = "negro";
                MenuPrincipal.colum[58] = "C";
                MenuPrincipal.fila[58] = "8";
                obtenerV(58);
                color = "blanco";
                pivote();
            }
            else
            {
                C8.ImageUrl = "blanco.png";
                C8.Enabled = false;
                mov++;
                MenuPrincipal.colores[58] = "blanco";
                MenuPrincipal.colum[58] = "C";
                MenuPrincipal.fila[58] = "8";
                obtenerV(58);
                color = "negro";
                pivote();
            }
        }

        protected void D8_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                D8.ImageUrl = "negro.png";
                D8.Enabled = false;
                mov++;
                MenuPrincipal.colores[59] = "negro";
                MenuPrincipal.colum[59] = "D";
                MenuPrincipal.fila[59] = "8";
                obtenerV(59);
                color = "blanco";
                pivote();
            }
            else
            {
                D8.ImageUrl = "blanco.png";
                D8.Enabled = false;
                mov++;
                MenuPrincipal.colores[59] = "blanco";
                MenuPrincipal.colum[59] = "D";
                MenuPrincipal.fila[59] = "8";
                obtenerV(59);
                color = "negro";
                pivote();
            }
        }
        
        protected void E8_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                E8.ImageUrl = "negro.png";
                E8.Enabled = false;
                mov++;
                MenuPrincipal.colores[60] = "negro";
                MenuPrincipal.colum[60] = "E";
                MenuPrincipal.fila[60] = "8";
                obtenerV(60);
                color = "blanco";
                pivote();
            }
            else
            {
                E8.ImageUrl = "blanco.png";
                E8.Enabled = false;
                mov++;
                MenuPrincipal.colores[60] = "blanco";
                MenuPrincipal.colum[60] = "E";
                MenuPrincipal.fila[60] = "8";
                obtenerV(60);
                color = "negro";
                pivote();
            }
        }

        protected void F8_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                F8.ImageUrl = "negro.png";
                F8.Enabled = false;
                mov++;
                MenuPrincipal.colores[61] = "negro";
                MenuPrincipal.colum[61] = "F";
                MenuPrincipal.fila[61] = "8";
                obtenerV(61);
                color = "blanco";
                pivote();
            }
            else
            {
                F8.ImageUrl = "blanco.png";
                F8.Enabled = false;
                mov++;
                MenuPrincipal.colores[61] = "blanco";
                MenuPrincipal.colum[61] = "F";
                MenuPrincipal.fila[61] = "8";
                obtenerV(61);
                color = "negro";
                pivote();
            }
        }

        protected void G8_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                G8.ImageUrl = "negro.png";
                G8.Enabled = false;
                mov++;
                MenuPrincipal.colores[62] = "negro";
                MenuPrincipal.colum[62] = "G";
                MenuPrincipal.fila[62] = "8";
                obtenerV(62);
                color = "blanco";
                pivote();
            }
            else
            {
                G8.ImageUrl = "blanco.png";
                G8.Enabled = false;
                mov++;
                MenuPrincipal.colores[62] = "blanco";
                MenuPrincipal.colum[62] = "G";
                MenuPrincipal.fila[62] = "8";
                obtenerV(62);
                color = "negro";
                pivote();
            }
        }

        protected void H8_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                H8.ImageUrl = "negro.png";
                H8.Enabled = false;
                mov++;
                MenuPrincipal.colores[63] = "negro";
                MenuPrincipal.colum[63] = "H";
                MenuPrincipal.fila[63] = "8";
                obtenerV(63);
                color = "blanco";
                pivote();
            }
            else
            {
                H8.ImageUrl = "blanco.png";
                H8.Enabled = false;
                mov++;
                MenuPrincipal.colores[63] = "blanco";
                MenuPrincipal.colum[63] = "H";
                MenuPrincipal.fila[63] = "8";
                obtenerV(63);
                color = "negro";
                pivote();
            }
        }
        
        protected void guardar_Click(object sender, EventArgs e)
        {
            XDocument archivo = new XDocument(new XDeclaration("1.0", "utf-8", null));
            XElement raiz = new XElement("tablero");
            raiz.RemoveAll();
            archivo.Add(raiz);
            for (int i = 0; i <= 63; i++)
            {
                if (!MenuPrincipal.colores[i].Equals("."))
                {
                    XElement ficha = new XElement("ficha");
                    ficha.Add(new XElement("color", MenuPrincipal.colores[i]));
                    ficha.Add(new XElement("columna", MenuPrincipal.colum[i]));
                    ficha.Add(new XElement("fila", MenuPrincipal.fila[i]));
                    raiz.Add(ficha);
                }
            }
            XElement siguientetiro = new XElement("siguienteTiro");
            if (color.Equals("negro"))
            {
                siguientetiro.Add(new XElement("color", "blanco"));
                raiz.Add(siguientetiro);
            }
            else if (color.Equals("blanco")) {
                siguientetiro.Add(new XElement("color", "negro"));
            }
            if (bandera == false)
            {
                BaseDatos bd = new BaseDatos();
                string datos = "insert into partida(partida_g,tipo_partida,movimientos,pge,id_usuario) values(@partida_g,@tipo_partida,@movimientos,@pge,@id_usuario)";
                SqlCommand accion = new SqlCommand(datos, bd.registrar());
                accion.Parameters.AddWithValue("@partida_g", archivo.ToString());
                accion.Parameters.AddWithValue("@tipo_partida", partida);
                accion.Parameters.AddWithValue("@movimientos", mov);
                accion.Parameters.AddWithValue("@pge", gamperem);
                accion.Parameters.AddWithValue("@id_usuario", InicioSesion.jugador);
                accion.ExecuteNonQuery();
                Response.Redirect("MenuPrincipal.aspx");
            }
            else {
                BaseDatos bd = new BaseDatos();
                string datos = "UPDATE partida SET partida_g = @partida_g, movimientos = @movimientos, pge = @pge WHERE id_usuario = @id_usuario and id_partida = @id_partida; ";
                SqlCommand accion = new SqlCommand(datos, bd.registrar());
                accion.Parameters.AddWithValue("@partida_g", archivo.ToString());
                accion.Parameters.AddWithValue("@movimientos", mov);
                accion.Parameters.AddWithValue("@pge", gamperem);
                accion.Parameters.AddWithValue("@id_usuario", InicioSesion.jugador);
                accion.Parameters.AddWithValue("@id_partida", Cargar.id_partida);
                accion.ExecuteNonQuery();
                Response.Redirect("MenuPrincipal.aspx");
            }
        }

        public void pivote() {
            for (int i = 0; i <= 63; i++)
            {
                if (MenuPrincipal.colores[i].Equals("pivote.png")) {
                    if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "1")
                    {
                        A1.Enabled = false;
                        A1.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "1")
                    {
                        B1.Enabled = false;
                        B1.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "1")
                    {
                        C1.Enabled = false;
                        C1.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "1")
                    {
                        D1.Enabled = false;
                        D1.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "1")
                    {
                        E1.Enabled = false;
                        E1.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "1")
                    {
                        F1.Enabled = false;
                        F1.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "1")
                    {
                        G1.Enabled = false;
                        G1.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "1")
                    {
                        H1.Enabled = false;
                        H1.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "2")
                    {
                        A2.Enabled = false;
                        A2.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "2")
                    {
                        B2.Enabled = false;
                        B2.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "2")
                    {
                        C2.Enabled = false;
                        C2.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "2")
                    {
                        D2.Enabled = false;
                        D2.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "2")
                    {
                        E2.Enabled = false;
                        E2.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "2")
                    {
                        F2.Enabled = false;
                        F2.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "2")
                    {
                        G2.Enabled = false;
                        G2.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "2")
                    {
                        H2.Enabled = false;
                        H2.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "3")
                    {
                        A3.Enabled = false;
                        A3.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "3")
                    {
                        B3.Enabled = false;
                        B3.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "3")
                    {
                        C3.Enabled = false;
                        C3.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "3")
                    {
                        D3.Enabled = false;
                        D3.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "3")
                    {
                        E3.Enabled = false;
                        E3.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "3")
                    {
                        F3.Enabled = false;
                        F3.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "3")
                    {
                        G3.Enabled = false;
                        G3.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "3")
                    {
                        H3.Enabled = false;
                        H3.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "4")
                    {
                        A4.Enabled = false;
                        A4.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "4")
                    {
                        B4.Enabled = false;
                        B4.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "4")
                    {
                        C4.Enabled = false;
                        C4.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "4")
                    {
                        D4.Enabled = false;
                        D4.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "4")
                    {
                        E4.Enabled = false;
                        E4.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "4")
                    {
                        F4.Enabled = false;
                        F4.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "4")
                    {
                        G4.Enabled = false;
                        G4.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "4")
                    {
                        H4.Enabled = false;
                        H4.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "5")
                    {
                        A5.Enabled = false;
                        A5.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "5")
                    {
                        B5.Enabled = false;
                        B5.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "5")
                    {
                        C5.Enabled = false;
                        C5.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "5")
                    {
                        D5.Enabled = false;
                        D5.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "5")
                    {
                        E5.Enabled = false;
                        E5.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "5")
                    {
                        F5.Enabled = false;
                        F5.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "5")
                    {
                        G5.Enabled = false;
                        G5.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "5")
                    {
                        H5.Enabled = false;
                        H5.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "6")
                    {
                        A6.Enabled = false;
                        A6.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "6")
                    {
                        B6.Enabled = false;
                        B6.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "6")
                    {
                        C6.Enabled = false;
                        C6.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "6")
                    {
                        D6.Enabled = false;
                        D6.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "6")
                    {
                        E6.Enabled = false;
                        E6.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "6")
                    {
                        F6.Enabled = false;
                        F6.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "6")
                    {
                        G6.Enabled = false;
                        G6.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "6")
                    {
                        H6.Enabled = false;
                        H6.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "7")
                    {
                        A7.Enabled = false;
                        A7.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "7")
                    {
                        B7.Enabled = false;
                        B7.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "7")
                    {
                        C7.Enabled = false;
                        C7.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "7")
                    {
                        D7.Enabled = false;
                        D7.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "7")
                    {
                        E7.Enabled = false;
                        E7.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "7")
                    {
                        F7.Enabled = false;
                        F7.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "7")
                    {
                        G7.Enabled = false;
                        G7.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "7")
                    {
                        H7.Enabled = false;
                        H7.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "8")
                    {
                        A8.Enabled = false;
                        A8.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "8")
                    {
                        B8.Enabled = false;
                        B8.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "8")
                    {
                        C8.Enabled = false;
                        C8.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "8")
                    {
                        D8.Enabled = false;
                        D8.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "8")
                    {
                        E8.Enabled = false;
                        E8.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "8")
                    {
                        F8.Enabled = false;
                        F8.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "8")
                    {
                        G8.Enabled = false;
                        G8.ImageUrl = "vacio.png";
                    }
                    else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "8")
                    {
                        H8.Enabled = false;
                        H8.ImageUrl = "vacio.png"
;
                    }
                }
            }

            for (int i = 0; i <= 63; i++) {
                if (color.Equals("negro"))
                {
                    if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        izn(i);
                    }
                }
                else if (color.Equals("blanco")) {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        izb(i);
                    }
                }
                    
            }
        }

        public void izn(int i) {
            bool tirovalido = false;
            while (i != 0) {
                if (i == 0 || i == 8 || i == 16 || i == 24 || i == 32 || i == 40 || i == 48 || i == 56)
                {
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals("blanco"))
                {
                    tirovalido = true;
                } 
                else if (MenuPrincipal.colores[i].Equals(".") && tirovalido == true) {
                    if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "1")
                    {
                        A1.Enabled = true;
                        A1.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "1")
                    {
                        B1.Enabled = true;
                        B1.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "1")
                    {
                        C1.Enabled = true;
                        C1.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "1")
                    {
                        D1.Enabled = true;
                        D1.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "1")
                    {
                        E1.Enabled = true;
                        E1.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "1")
                    {
                        F1.Enabled = true;
                        F1.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "1")
                    {
                        G1.Enabled = true;
                        G1.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "1")
                    {
                        H1.Enabled = true;
                        H1.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "2")
                    {
                        A2.Enabled = true;
                        A2.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "2")
                    {
                        B2.Enabled = true;
                        B2.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "2")
                    {
                        C2.Enabled = true;
                        C2.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "2")
                    {
                        D2.Enabled = true;
                        D2.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "2")
                    {
                        E2.Enabled = true;
                        E2.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "2")
                    {
                        F2.Enabled = true;
                        F2.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "2")
                    {
                        G2.Enabled = true;
                        G2.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "2")
                    {
                        H2.Enabled = true;
                        H2.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "3")
                    {
                        A3.Enabled = true;
                        A3.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "3")
                    {
                        B3.Enabled = true;
                        B3.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "3")
                    {
                        C3.Enabled = true;
                        C3.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "3")
                    {
                        D3.Enabled = true;
                        D3.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "3")
                    {
                        E3.Enabled = true;
                        E3.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "3")
                    {
                        F3.Enabled = true;
                        F3.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "3")
                    {
                        G3.Enabled = true;
                        G3.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "3")
                    {
                        H3.Enabled = true;
                        H3.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "4")
                    {
                        A4.Enabled = true;
                        A4.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "4")
                    {
                        B4.Enabled = true;
                        B4.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "4")
                    {
                        C4.Enabled = true;
                        C4.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "4")
                    {
                        D4.Enabled = true;
                        D4.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "4")
                    {
                        E4.Enabled = true;
                        E4.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "4")
                    {
                        F4.Enabled = true;
                        F4.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "4")
                    {
                        G4.Enabled = true;
                        G4.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "4")
                    {
                        H4.Enabled = true;
                        H4.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "5")
                    {
                        A5.Enabled = true;
                        A5.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "5")
                    {
                        B5.Enabled = true;
                        B5.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "5")
                    {
                        C5.Enabled = true;
                        C5.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "5")
                    {
                        D5.Enabled = true;
                        D5.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "5")
                    {
                        E5.Enabled = true;
                        E5.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "5")
                    {
                        F5.Enabled = true;
                        F5.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "5")
                    {
                        G5.Enabled = true;
                        G5.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "5")
                    {
                        H5.Enabled = true;
                        H5.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "6")
                    {
                        A6.Enabled = true;
                        A6.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "6")
                    {
                        B6.Enabled = true;
                        B6.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "6")
                    {
                        C6.Enabled = true;
                        C6.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "6")
                    {
                        D6.Enabled = true;
                        D6.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "6")
                    {
                        E6.Enabled = true;
                        E6.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "6")
                    {
                        F6.Enabled = true;
                        F6.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "6")
                    {
                        G6.Enabled = true;
                        G6.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "6")
                    {
                        H6.Enabled = true;
                        H6.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "7")
                    {
                        A7.Enabled = true;
                        A7.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "7")
                    {
                        B7.Enabled = true;
                        B7.ImageUrl = "pivote.png";
                        break;

                    }
                    else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "7")
                    {
                        C7.Enabled = true;
                        C7.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "7")
                    {
                        D7.Enabled = true;
                        D7.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "7")
                    {
                        E7.Enabled = true;
                        E7.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "7")
                    {
                        F7.Enabled = true;
                        F7.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "7")
                    {
                        G7.Enabled = true;
                        G7.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "7")
                    {
                        H7.Enabled = true;
                        H7.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "8")
                    {
                        A8.Enabled = true;
                        A8.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "8")
                    {
                        B8.Enabled = true;
                        B8.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "8")
                    {
                        C8.Enabled = true;
                        C8.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "8")
                    {
                        D8.Enabled = true;
                        D8.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "8")
                    {
                        E8.Enabled = true;
                        E8.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "8")
                    {
                        F8.Enabled = true;
                        F8.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "8")
                    {
                        G8.Enabled = true;
                        G8.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "8")
                    {
                        H8.Enabled = true;
                        H8.ImageUrl = "pivote.png";
                        break;
                    }
                }
                i = i - 1;
            }
        }

        public void izb(int i)
        {
            bool tirovalido = false;
            while (i != 0)
            {
                if (i == 0 || i == 8 || i == 16 || i == 24 || i == 32 || i == 40 || i == 48 || i == 56)
                {
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals("negro"))
                {
                    tirovalido = true;
                }
                else if (MenuPrincipal.colores[i].Equals(".") && tirovalido == true)
                {
                    if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "1")
                    {
                        A1.Enabled = true;
                        A1.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "1")
                    {
                        B1.Enabled = true;
                        B1.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "1")
                    {
                        C1.Enabled = true;
                        C1.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "1")
                    {
                        D1.Enabled = true;
                        D1.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "1")
                    {
                        E1.Enabled = true;
                        E1.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "1")
                    {
                        F1.Enabled = true;
                        F1.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "1")
                    {
                        G1.Enabled = true;
                        G1.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "1")
                    {
                        H1.Enabled = true;
                        H1.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "2")
                    {
                        A2.Enabled = true;
                        A2.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "2")
                    {
                        B2.Enabled = true;
                        B2.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "2")
                    {
                        C2.Enabled = true;
                        C2.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "2")
                    {
                        D2.Enabled = true;
                        D2.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "2")
                    {
                        E2.Enabled = true;
                        E2.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "2")
                    {
                        F2.Enabled = true;
                        F2.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "2")
                    {
                        G2.Enabled = true;
                        G2.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "2")
                    {
                        H2.Enabled = true;
                        H2.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "3")
                    {
                        A3.Enabled = true;
                        A3.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "3")
                    {
                        B3.Enabled = true;
                        B3.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "3")
                    {
                        C3.Enabled = true;
                        C3.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "3")
                    {
                        D3.Enabled = true;
                        D3.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "3")
                    {
                        E3.Enabled = true;
                        E3.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "3")
                    {
                        F3.Enabled = true;
                        F3.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "3")
                    {
                        G3.Enabled = true;
                        G3.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "3")
                    {
                        H3.Enabled = true;
                        H3.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "4")
                    {
                        A4.Enabled = true;
                        A4.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "4")
                    {
                        B4.Enabled = true;
                        B4.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "4")
                    {
                        C4.Enabled = true;
                        C4.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "4")
                    {
                        D4.Enabled = true;
                        D4.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "4")
                    {
                        E4.Enabled = true;
                        E4.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "4")
                    {
                        F4.Enabled = true;
                        F4.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "4")
                    {
                        G4.Enabled = true;
                        G4.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "4")
                    {
                        H4.Enabled = true;
                        H4.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "5")
                    {
                        A5.Enabled = true;
                        A5.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "5")
                    {
                        B5.Enabled = true;
                        B5.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "5")
                    {
                        C5.Enabled = true;
                        C5.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "5")
                    {
                        D5.Enabled = true;
                        D5.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "5")
                    {
                        E5.Enabled = true;
                        E5.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "5")
                    {
                        F5.Enabled = true;
                        F5.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "5")
                    {
                        G5.Enabled = true;
                        G5.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "5")
                    {
                        H5.Enabled = true;
                        H5.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "6")
                    {
                        A6.Enabled = true;
                        A6.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "6")
                    {
                        B6.Enabled = true;
                        B6.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "6")
                    {
                        C6.Enabled = true;
                        C6.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "6")
                    {
                        D6.Enabled = true;
                        D6.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "6")
                    {
                        E6.Enabled = true;
                        E6.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "6")
                    {
                        F6.Enabled = true;
                        F6.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "6")
                    {
                        G6.Enabled = true;
                        G6.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "6")
                    {
                        H6.Enabled = true;
                        H6.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "7")
                    {
                        A7.Enabled = true;
                        A7.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "7")
                    {
                        B7.Enabled = true;
                        B7.ImageUrl = "pivote.png";
                        break;

                    }
                    else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "7")
                    {
                        C7.Enabled = true;
                        C7.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "7")
                    {
                        D7.Enabled = true;
                        D7.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "7")
                    {
                        E7.Enabled = true;
                        E7.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "7")
                    {
                        F7.Enabled = true;
                        F7.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "7")
                    {
                        G7.Enabled = true;
                        G7.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "7")
                    {
                        H7.Enabled = true;
                        H7.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "8")
                    {
                        A8.Enabled = true;
                        A8.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "8")
                    {
                        B8.Enabled = true;
                        B8.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "8")
                    {
                        C8.Enabled = true;
                        C8.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "8")
                    {
                        D8.Enabled = true;
                        D8.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "8")
                    {
                        E8.Enabled = true;
                        E8.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "8")
                    {
                        F8.Enabled = true;
                        F8.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "8")
                    {
                        G8.Enabled = true;
                        G8.ImageUrl = "pivote.png";
                        break;
                    }
                    else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "8")
                    {
                        H8.Enabled = true;
                        H8.ImageUrl = "pivote.png";
                        break;
                    }
                }
                i = i - 1;
            }
        }

        public void obtenerV (int i) {
            vuelta.Clear();
            if (color.Equals("negro"))
            {
                //Voltear Hacia Izquierda del pivote
                int pos = i;
                int posaux;
                bool bandera = true;
                while (bandera)
                {
                    posaux = pos - 1;
                    if (pos == 0 || pos == 8 || pos == 16 || pos == 24 || pos == 32 || pos == 40 || pos == 48 || pos == 56)
                    {
                        break;
                    }
                    else
                    {
                        if (MenuPrincipal.colores[posaux].Equals("blanco"))
                        {
                            vuelta.Add(posaux);
                        }
                        else if (MenuPrincipal.colores[posaux].Equals("negro"))
                        {
                            voltear(vuelta);
                            vuelta.Clear();
                        }
                        else if (MenuPrincipal.colores[posaux].Equals("."))
                        {
                            break;
                        }
                    }
                    pos = pos - 1;
                }

                //Voltear Hacia Derecha del pivote
                pos = i;
                vuelta.Clear();
                while (bandera)
                {
                    posaux = pos + 1;
                    if (pos == 7 || pos == 15 || pos == 23 || pos == 31 || pos == 39 || pos == 47 || pos == 55 || pos == 63)
                    {
                        break;
                    }
                    else
                    {
                        if (MenuPrincipal.colores[posaux].Equals("blanco"))
                        {
                            vuelta.Add(posaux);
                        }
                        else if (MenuPrincipal.colores[posaux].Equals("negro"))
                        {
                            voltear(vuelta);
                            vuelta.Clear();
                        }
                        else if (MenuPrincipal.colores[posaux].Equals("."))
                        {
                            break;
                        }
                    }
                    pos = pos + 1;
                }
            }
            else {
                //Voltear Hacia Izquierda del pivote
                int pos = i;
                int posaux;
                bool bandera = true;
                while (bandera)
                {
                    posaux = pos - 1;
                    if (pos == 0 || pos == 8 || pos == 16 || pos == 24 || pos == 32 || pos == 40 || pos == 48 || pos == 56)
                    {
                        break;
                    }
                    else
                    {
                        if (MenuPrincipal.colores[posaux].Equals("negro"))
                        {
                            vuelta.Add(posaux);
                        }
                        else if (MenuPrincipal.colores[posaux].Equals("blanco"))
                        {
                            voltear(vuelta);
                            vuelta.Clear();
                        }
                        else if (MenuPrincipal.colores[posaux].Equals("."))
                        {
                            break;
                        }
                    }
                    pos = pos - 1;
                }

                //Voltear Hacia Derecha del pivote
                pos = i;
                vuelta.Clear();
                while (bandera)
                {
                    posaux = pos + 1;
                    if (pos == 7 || pos == 15 || pos == 23 || pos == 31 || pos == 39 || pos == 47 || pos == 55 || pos == 63)
                    {
                        break;
                    }
                    else
                    {
                        if (MenuPrincipal.colores[posaux].Equals("negro"))
                        {
                            vuelta.Add(posaux);
                        }
                        else if (MenuPrincipal.colores[posaux].Equals("blanco"))
                        {
                            voltear(vuelta);
                            vuelta.Clear();
                        }
                        else if (MenuPrincipal.colores[posaux].Equals("."))
                        {
                            break;
                        }
                    }
                    pos = pos + 1;
                }
            }
        }

        public void voltear(List<int> vuelta) {
            foreach (int i in vuelta)
            {
                if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "1")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        A1.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        A1.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "1")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        B1.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        B1.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "1")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        C1.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        C1.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "1")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        D1.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        D1.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "1")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        E1.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        E1.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "1")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        F1.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        F1.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "1")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        G1.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        G1.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "1")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        H1.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        H1.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "2")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        A2.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        A2.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "2")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        B2.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        B2.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "2")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        C2.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        C2.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "2")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        D2.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        D2.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "2")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        E2.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        E2.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "2")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        F2.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        F2.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "2")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        G2.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        G2.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "2")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        H2.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        H2.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "3")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        A3.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        A3.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "3")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        B3.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        B3.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "3")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        C3.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        C3.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "3")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        D3.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        D3.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "3")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        E3.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        E3.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "3")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        F3.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        F3.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "3")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        G3.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        G3.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "3")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        H3.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        H3.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "4")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        A4.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        A4.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "4")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        B4.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        B4.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "4")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        C4.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        C4.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "4")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        D4.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        D4.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "4")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        E4.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        E4.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "4")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        F4.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        F4.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "4")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        G4.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        G4.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "4")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        H4.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        H4.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "5")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        A5.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        A5.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "5")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        B5.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        B5.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "5")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        C5.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        C5.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "5")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        D5.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        D5.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "5")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        E5.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        E5.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "5")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        F5.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        F5.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "5")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        G5.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        G5.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "5")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        H5.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        H5.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "6")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        A6.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        A6.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "6")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        B6.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        B6.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "6")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        C6.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        C6.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "6")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        D6.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        D6.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "6")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        E6.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        E6.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "6")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        F6.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        F6.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "6")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        G6.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        G6.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "6")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        H6.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        H6.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "7")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        A7.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        A7.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "7")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        B7.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        B7.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }

                }
                else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "7")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        C7.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        C7.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "7")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        D7.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        D7.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "7")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        E7.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        E7.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "7")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        F7.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        F7.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "7")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        G7.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        G7.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "7")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        H7.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        H7.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "8")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        A8.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        A8.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "8")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        B8.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        B8.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "8")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        C8.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        C8.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "8")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        D8.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        D8.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "8")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        E8.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        E8.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "8")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        F8.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        F8.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "8")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        G8.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        G8.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
                else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "8")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        H8.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                        break;
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        H8.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                        break;
                    }
                }
            }
        }
    }
}