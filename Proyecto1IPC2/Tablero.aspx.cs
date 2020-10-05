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
        public static string colorJ;
        public static string jugadorN;
        public static string jugadorB;
        public static int mov = 0;
        public static int movn = 0;
        public static int movb = 0;
        public static int puntosn;
        public static int puntosb;
        public static int carga = 0;
        public static bool bandera = false;
        public static int id_partida = 0;
        public static List<int> vuelta = new List<int>();
        public static List<int> pivoteM = new List<int>();
        public static List<int> tirosM = new List<int>();

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
                if (colorJ.Equals("negro"))
                {
                    JugN.Text = MenuPrincipal.jugador;
                    JugB.Text = "Invitado";
                    MovN.Text = "Movimientos: " + Convert.ToString(movn);
                    MovB.Text = "Movimientos: " + Convert.ToString(movb);
                    PunN.Text = "Puntos: " + Convert.ToString(puntosn);
                    PunB.Text = "Puntos: " + Convert.ToString(puntosb);
                    if (color.Equals("negro"))
                    {
                        TurnoNegro.ImageUrl = "negro.png";
                        TurnoBlanco.ImageUrl = "vacio.png";
                    }
                    else
                    {
                        TurnoNegro.ImageUrl = "vacio.png";
                        TurnoBlanco.ImageUrl = "blanco.png";
                    }
                }
                else
                {
                    JugB.Text = MenuPrincipal.jugador;
                    JugN.Text = "Invitado";
                    MovN.Text = "Movimientos: " + Convert.ToString(movn);
                    MovB.Text = "Movimientos: " + Convert.ToString(movb);
                    PunN.Text = "Puntos: " + Convert.ToString(puntosn);
                    PunB.Text = "Puntos: " + Convert.ToString(puntosb);
                    if (color.Equals("negro"))
                    {
                        TurnoNegro.ImageUrl = "negro.png";
                        TurnoBlanco.ImageUrl = "vacio.png";
                    }
                    else
                    {
                        TurnoNegro.ImageUrl = "vacio.png";
                        TurnoBlanco.ImageUrl = "blanco.png";
                    }
                }
                siguiente();
                carga = 2;
            }
            if (carga == 0) {
                pivote();
                if (colorJ.Equals("negro"))
                {
                    JugN.Text = MenuPrincipal.jugador;
                    JugB.Text = "Invitado";
                    MovN.Text = "Movimientos: " + Convert.ToString(movn);
                    MovB.Text = "Movimientos: " + Convert.ToString(movb);
                    PunN.Text = "Puntos: " + Convert.ToString(puntosn);
                    PunB.Text = "Puntos: " + Convert.ToString(puntosb);
                    if (color.Equals("negro"))
                    {
                        TurnoNegro.ImageUrl = "negro.png";
                        TurnoBlanco.ImageUrl = "vacio.png";
                    }
                    else
                    {
                        TurnoNegro.ImageUrl = "vacio.png";
                        TurnoBlanco.ImageUrl = "blanco.png";
                    }
                }
                else {
                    JugB.Text = MenuPrincipal.jugador;
                    JugN.Text = "Invitado";
                    MovN.Text = "Movimientos: " + Convert.ToString(movn);
                    MovB.Text = "Movimientos: " + Convert.ToString(movb);
                    PunN.Text = "Puntos: " + Convert.ToString(puntosn);
                    PunB.Text = "Puntos: " + Convert.ToString(puntosb);
                    if (partida.Equals("Maquina"))
                    {
                        for (int z = 0; z <= 63; z++)
                        {
                            if (MenuPrincipal.colores[z].Equals("pivote"))
                            {
                                pivoteM.Add(z);
                            }
                        }
                        siguienteM(pivoteM);
                        if (color.Equals("negro"))
                        {
                            TurnoNegro.ImageUrl = "negro.png";
                            TurnoBlanco.ImageUrl = "vacio.png";
                        }
                        else
                        {
                            TurnoNegro.ImageUrl = "vacio.png";
                            TurnoBlanco.ImageUrl = "blanco.png";
                        }
                    }
                    else
                    {
                        if (color.Equals("negro"))
                        {
                            TurnoNegro.ImageUrl = "negro.png";
                            TurnoBlanco.ImageUrl = "vacio.png";
                        }
                        else
                        {
                            TurnoNegro.ImageUrl = "vacio.png";
                            TurnoBlanco.ImageUrl = "blanco.png";
                        }
                    }
                }
                carga = 2;
            }
        }

        protected void A1_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(A1, 0);
            }
            else
            {
                Maquina(A1, 0);
            }
        }

        protected void B1_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(B1, 1);
            }
            else
            {
                Maquina(B1, 1);
            }
        }

        protected void C1_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(C1, 2);
            }
            else
            {
                Maquina(C1, 2);
            }
        }

        protected void D1_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(D1, 3);
            }
            else
            {
                Maquina(D1, 3);
            }
        }

        protected void E1_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(E1, 4);
            }
            else
            {
                Maquina(E1, 4);
            }
        }

        protected void F1_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(F1, 5);
            }
            else
            {
                Maquina(F1, 5);
            }
        }

        protected void G1_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(G1, 6);
            }
            else
            {
                Maquina(G1, 6);
            }
        }

        protected void H1_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(H1, 7);
            }
            else
            {
                Maquina(H1, 7);
            }
        }

        protected void A2_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(A2, 8);
            }
            else
            {
                Maquina(A2, 8);
            }
        }

        protected void B2_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(B2, 9);
            }
            else
            {
                Maquina(B2, 9);
            }
        }

        protected void C2_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(C2, 10);
            }
            else
            {
                Maquina(C2, 10);
            }
        }

        protected void D2_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(D2, 11);
            }
            else
            {
                Maquina(D2, 11);
            }
        }

        protected void E2_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(E2, 12);
            }
            else
            {
                Maquina(E2, 12);
            }
        }

        protected void F2_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(F2, 13);
            }
            else
            {
                Maquina(F2, 13);
            }
        }

        protected void G2_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(G2, 14);
            }
            else
            {
                Maquina(G2, 14);
            }
        }

        protected void H2_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(H2, 15);
            }
            else
            {
                Maquina(H2, 15);
            }
        }

        protected void A3_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(A3, 16);
            }
            else
            {
                Maquina(A3, 16);
            }
        }

        protected void B3_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(B3, 17);
            }
            else
            {
                Maquina(B3, 17);
            }
        }

        protected void C3_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(C3, 18);
            }
            else
            {
                Maquina(C3, 18);
            }
        }

        protected void D3_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(D3, 19);
            }
            else
            {
                Maquina(D3, 19);
            }
        }

        protected void E3_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(E3, 20);
            }
            else
            {
                Maquina(E3, 20);
            }
        }

        protected void F3_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(F3, 21);
            }
            else
            {
                Maquina(F3, 21);
            }
        }

        protected void G3_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(G3, 22);
            }
            else
            {
                Maquina(G3, 22);
            }
        }

        protected void H3_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(H3, 23);
            }
            else
            {
                Maquina(H3, 23);
            }
        }

        protected void A4_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(A4, 24);
            }
            else
            {
                Maquina(A4, 24);
            }
        }

        protected void B4_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(B4, 25);
            }
            else
            {
                Maquina(B4, 25);
            }
        }

        protected void C4_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(C4, 26);
            }
            else
            {
                Maquina(C4, 26);
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
            if (partida.Equals("Versus"))
            {
                boton(F4, 29);
            }
            else
            {
                Maquina(F4, 29);
            }
        }

        protected void G4_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(G4, 30);
            }
            else
            {
                Maquina(G4, 30);
            }
        }

        protected void H4_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(H4, 31);
            }
            else
            {
                Maquina(H4, 31);
            }
        }

        protected void A5_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(A5, 32);
            }
            else
            {
                Maquina(A5, 32);
            }
        }

        protected void B5_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(B5, 33);
            }
            else
            {
                Maquina(B5, 33);
            }
        }

        protected void C5_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(C5, 34);
            }
            else
            {
                Maquina(C5, 34);
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
            if (partida.Equals("Versus"))
            {
                boton(F5, 37);
            }
            else
            {
                Maquina(F5, 37);
            }
        }

        protected void G5_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(G5, 38);
            }
            else
            {
                Maquina(G5, 38);
            }
        }

        protected void H5_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(H5, 39);
            }
            else
            {
                Maquina(H5, 39);
            }
        }

        protected void A6_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(A6, 40);
            }
            else
            {
                Maquina(A6, 40);
            }
        }

        protected void B6_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(B6, 41);
            }
            else
            {
                Maquina(B6, 41);
            }
        }

        protected void C6_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(C6, 42);
            }
            else
            {
                Maquina(C6, 42);
            }
        }

        protected void D6_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(D6, 43);
            }
            else
            {
                Maquina(D6, 43);
            }
        }

        protected void E6_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(E6, 44);
            }
            else
            {
                Maquina(E6, 44);
            }
        }

        protected void F6_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(F6, 45);
            }
            else
            {
                Maquina(F6, 45);
            }
        }

        protected void G6_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(G6, 46);
            }
            else
            {
                Maquina(G6, 46);
            }
        }

        protected void H6_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(H6, 47);
            }
            else
            {
                Maquina(H6, 47);
            }
        }

        protected void A7_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(A7, 48);
            }
            else
            {
                Maquina(A7, 48);
            }
        }

        protected void B7_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(B7, 49);
            }
            else
            {
                Maquina(B7, 49);
            }
        }

        protected void C7_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(C7, 50);
            }
            else
            {
                Maquina(C7, 50);
            }
        }

        protected void D7_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(D7, 51);
            }
            else
            {
                Maquina(D7, 51);
            }
        }

        protected void E7_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(E7, 52);
            }
            else
            {
                Maquina(E7, 52);
            }
        }

        protected void F7_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(F7, 53);
            }
            else
            {
                Maquina(F7, 53);
            }
        }

        protected void G7_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(G7, 54);
            }
            else
            {
                Maquina(G7, 54);
            }
        }

        protected void H7_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(H7, 55);
            }
            else
            {
                Maquina(H7, 55);
            }
        }

        protected void A8_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(A8, 56);
            }
            else
            {
                Maquina(A8, 56);
            }
        }

        protected void B8_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(B8, 57);
            }
            else
            {
                Maquina(B8, 57);
            }
        }

        protected void C8_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(C8, 58);
            }
            else
            {
                Maquina(C8, 58);
            }
        }

        protected void D8_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(D8, 59);
            }
            else
            {
                Maquina(D8, 59);
            }
        }

        protected void E8_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(E8, 60);
            }
            else
            {
                Maquina(E8, 60);
            }
        }

        protected void F8_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(F8, 61);
            }
            else
            {
                Maquina(F8, 61);
            }
        }

        protected void G8_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(G8, 62);
            }
            else
            {
                Maquina(G8, 62);
            }
        }

        protected void H8_Click(object sender, ImageClickEventArgs e)
        {
            if (partida.Equals("Versus"))
            {
                boton(H8, 63);
            }
            else
            {
                Maquina(H8, 63);
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
                if (!MenuPrincipal.colores[i].Equals(".") && !MenuPrincipal.colores[i].Equals("pivote"))
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
                siguientetiro.Add(new XElement("color", "negro"));
                raiz.Add(siguientetiro);
            }
            else if (color.Equals("blanco")) {
                siguientetiro.Add(new XElement("color", "blanco"));
            }
            if (bandera == false)
            {
                BaseDatos bd = new BaseDatos();
                string datos = "insert into partida(partida_g,tipo_partida,color,movimientos,pge,id_usuario) values(@partida_g,@tipo_partida,@color,@movimientos,@pge,@id_usuario)";
                SqlCommand accion = new SqlCommand(datos, bd.registrar());
                accion.Parameters.AddWithValue("@partida_g", archivo.ToString());
                accion.Parameters.AddWithValue("@tipo_partida", partida);
                accion.Parameters.AddWithValue("@color", colorJ);
                if (colorJ.Equals("negro"))
                {
                    accion.Parameters.AddWithValue("@movimientos", movn);
                }
                else if (colorJ.Equals("blanco"))
                {
                    accion.Parameters.AddWithValue("@movimientos", movb);
                }
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
                if (colorJ.Equals("negro"))
                {
                    accion.Parameters.AddWithValue("@movimientos", movn);
                }
                else if (colorJ.Equals("blanco"))
                {
                    accion.Parameters.AddWithValue("@movimientos", movb);
                }
                accion.Parameters.AddWithValue("@pge", gamperem);
                accion.Parameters.AddWithValue("@id_usuario", InicioSesion.jugador);
                accion.Parameters.AddWithValue("@id_partida", Cargar.id_partida);
                accion.ExecuteNonQuery();
                Response.Redirect("MenuPrincipal.aspx");
            }
        }

        //Valida posible pivote
        public void pivote() {
            for (int i = 0; i <= 63; i++)
            {
                if (MenuPrincipal.colores[i].Equals("pivote")) {
                    MenuPrincipal.colores[i] = ".";
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
                        dern(i);
                        arrn(i);
                        aban(i);
                        abdern(i);
                        abizn(i);
                        ardern(i);
                        arizn(i);
                    }
                }
                else if (color.Equals("blanco")) {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        izb(i);
                        derb(i);
                        arrb(i);
                        abab(i);
                        abderb(i);
                        abizb(i);
                        arderb(i);
                        arizb(i);
                    }
                }

            }
        }

        //Genera pivote en tablero
        public void crearPivote(int i)
        {
            MenuPrincipal.colores[i] = "pivote";
            if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "1")
            {
                A1.Enabled = true;
                A1.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "1")
            {
                B1.Enabled = true;
                B1.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "1")
            {
                C1.Enabled = true;
                C1.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "1")
            {
                D1.Enabled = true;
                D1.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "1")
            {
                E1.Enabled = true;
                E1.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "1")
            {
                F1.Enabled = true;
                F1.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "1")
            {
                G1.Enabled = true;
                G1.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "1")
            {
                H1.Enabled = true;
                H1.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "2")
            {
                A2.Enabled = true;
                A2.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "2")
            {
                B2.Enabled = true;
                B2.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "2")
            {
                C2.Enabled = true;
                C2.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "2")
            {
                D2.Enabled = true;
                D2.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "2")
            {
                E2.Enabled = true;
                E2.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "2")
            {
                F2.Enabled = true;
                F2.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "2")
            {
                G2.Enabled = true;
                G2.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "2")
            {
                H2.Enabled = true;
                H2.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "3")
            {
                A3.Enabled = true;
                A3.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "3")
            {
                B3.Enabled = true;
                B3.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "3")
            {
                C3.Enabled = true;
                C3.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "3")
            {
                D3.Enabled = true;
                D3.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "3")
            {
                E3.Enabled = true;
                E3.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "3")
            {
                F3.Enabled = true;
                F3.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "3")
            {
                G3.Enabled = true;
                G3.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "3")
            {
                H3.Enabled = true;
                H3.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "4")
            {
                A4.Enabled = true;
                A4.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "4")
            {
                B4.Enabled = true;
                B4.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "4")
            {
                C4.Enabled = true;
                C4.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "4")
            {
                D4.Enabled = true;
                D4.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "4")
            {
                E4.Enabled = true;
                E4.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "4")
            {
                F4.Enabled = true;
                F4.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "4")
            {
                G4.Enabled = true;
                G4.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "4")
            {
                H4.Enabled = true;
                H4.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "5")
            {
                A5.Enabled = true;
                A5.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "5")
            {
                B5.Enabled = true;
                B5.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "5")
            {
                C5.Enabled = true;
                C5.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "5")
            {
                D5.Enabled = true;
                D5.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "5")
            {
                E5.Enabled = true;
                E5.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "5")
            {
                F5.Enabled = true;
                F5.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "5")
            {
                G5.Enabled = true;
                G5.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "5")
            {
                H5.Enabled = true;
                H5.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "6")
            {
                A6.Enabled = true;
                A6.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "6")
            {
                B6.Enabled = true;
                B6.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "6")
            {
                C6.Enabled = true;
                C6.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "6")
            {
                D6.Enabled = true;
                D6.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "6")
            {
                E6.Enabled = true;
                E6.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "6")
            {
                F6.Enabled = true;
                F6.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "6")
            {
                G6.Enabled = true;
                G6.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "6")
            {
                H6.Enabled = true;
                H6.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "7")
            {
                A7.Enabled = true;
                A7.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "7")
            {
                B7.Enabled = true;
                B7.ImageUrl = "pivote.png";

            }
            else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "7")
            {
                C7.Enabled = true;
                C7.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "7")
            {
                D7.Enabled = true;
                D7.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "7")
            {
                E7.Enabled = true;
                E7.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "7")
            {
                F7.Enabled = true;
                F7.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "7")
            {
                G7.Enabled = true;
                G7.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "7")
            {
                H7.Enabled = true;
                H7.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "8")
            {
                A8.Enabled = true;
                A8.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "8")
            {
                B8.Enabled = true;
                B8.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "8")
            {
                C8.Enabled = true;
                C8.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "8")
            {
                D8.Enabled = true;
                D8.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "8")
            {
                E8.Enabled = true;
                E8.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "8")
            {
                F8.Enabled = true;
                F8.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "8")
            {
                G8.Enabled = true;
                G8.ImageUrl = "pivote.png";
            }
            else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "8")
            {
                H8.Enabled = true;
                H8.ImageUrl = "pivote.png";
            }
        }

        //Pivote Izquierda Negro
        public void izn(int i) {
            bool tirovalido = false;
            int contador = 0;
            while (i != 0) {
                if (i == 0 || i == 8 || i == 16 || i == 24 || i == 32 || i == 40 || i == 48 || i == 56)
                {
                    if (tirovalido == true && MenuPrincipal.colores[i].Equals("."))
                    {
                        crearPivote(i);
                    }
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals("negro"))
                {
                    if (contador == 0) { contador = 1; } else { break; }
                }
                else if (MenuPrincipal.colores[i].Equals("blanco"))
                {
                    tirovalido = true;
                }
                else if (MenuPrincipal.colores[i].Equals("pivote")) {
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals(".") && tirovalido == true)
                {
                    crearPivote(i);
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals(".") && tirovalido == false)
                {
                    break;
                }
                i = i - 1;
            }
        }

        //Pivote Izquierda Blanco
        public void izb(int i)
        {
            bool tirovalido = false;
            int contador = 0;
            while (i != 0)
            {
                if (i == 0 || i == 8 || i == 16 || i == 24 || i == 32 || i == 40 || i == 48 || i == 56)
                {
                    if (tirovalido == true && MenuPrincipal.colores[i].Equals("."))
                    {
                        crearPivote(i);
                    }
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals("blanco"))
                {
                    if (contador == 0) { contador = 1; } else { break; }
                }
                else if (MenuPrincipal.colores[i].Equals("pivote"))
                {
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals("negro"))
                {
                    tirovalido = true;
                }
                else if (MenuPrincipal.colores[i].Equals(".") && tirovalido == true)
                {
                    crearPivote(i);
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals(".") && tirovalido == false)
                {
                    break;
                }
                i = i - 1;
            }
        }

        //Pivote Derecha Negro
        public void dern(int i)
        {
            bool tirovalido = false;
            int contador = 0;
            while (i != 63)
            {
                if (i == 7 || i == 15 || i == 23 || i == 31 || i == 39 || i == 47 || i == 55 || i == 63)
                {
                    if (tirovalido == true && MenuPrincipal.colores[i].Equals("."))
                    {
                        crearPivote(i);
                    }
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals("negro"))
                {
                    if (contador == 0) { contador = 1; } else { break; }
                }
                else if (MenuPrincipal.colores[i].Equals("pivote"))
                {
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals("blanco"))
                {
                    tirovalido = true;
                }
                else if (MenuPrincipal.colores[i].Equals(".") && tirovalido == true)
                {
                    crearPivote(i);
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals(".") && tirovalido == false)
                {
                    break;
                }
                i = i + 1;
            }
        }

        //Pivote Derecha Blanco
        public void derb(int i)
        {
            bool tirovalido = false;
            int contador = 0;
            while (i != 63)
            {
                if (i == 7 || i == 15 || i == 23 || i == 31 || i == 39 || i == 47 || i == 55 || i == 63)
                {
                    if (tirovalido == true && MenuPrincipal.colores[i].Equals("."))
                    {
                        crearPivote(i);
                    }
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals("blanco"))
                {
                    if (contador == 0) { contador = 1; } else { break; }
                }
                else if (MenuPrincipal.colores[i].Equals("negro"))
                {
                    tirovalido = true;
                }
                else if (MenuPrincipal.colores[i].Equals("pivote"))
                {
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals(".") && tirovalido == true)
                {
                    crearPivote(i);
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals(".") && tirovalido == false)
                {
                    break;
                }
                i = i + 1;
            }
        }

        //Pivote Arriba Negro
        public void arrn(int i)
        {
            bool tirovalido = false;
            int contador = 0;
            while (i != 0)
            {
                if (i == 0 || i == 1 || i == 2 || i == 3 || i == 4 || i == 5 || i == 6 || i == 7)
                {
                    if (tirovalido == true && MenuPrincipal.colores[i].Equals("."))
                    {
                        crearPivote(i);
                    }
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals("negro"))
                {
                    if (contador == 0) { contador = 1; } else { break; }
                }
                else if (MenuPrincipal.colores[i].Equals("pivote"))
                {
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals("blanco"))
                {
                    tirovalido = true;
                }
                else if (MenuPrincipal.colores[i].Equals(".") && tirovalido == true)
                {
                    crearPivote(i);
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals(".") && tirovalido == false)
                {
                    break;
                }
                i = i - 8;
            }
        }

        //Pivote Arriba Blanco
        public void arrb(int i)
        {
            bool tirovalido = false;
            int contador = 0;
            while (i != 0)
            {
                if (i == 0 || i == 1 || i == 2 || i == 3 || i == 4 || i == 5 || i == 6 || i == 7)
                {
                    if (tirovalido == true && MenuPrincipal.colores[i].Equals("."))
                    {
                        crearPivote(i);
                    }
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals("blanco"))
                {
                    if (contador == 0) { contador = 1; } else { break; }
                }
                else if (MenuPrincipal.colores[i].Equals("pivote"))
                {
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals("negro"))
                {
                    tirovalido = true;
                }
                else if (MenuPrincipal.colores[i].Equals(".") && tirovalido == true)
                {
                    crearPivote(i);
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals(".") && tirovalido == false)
                {
                    break;
                }
                i = i - 8;
            }
        }

        //Pivote Abajo Negro
        public void aban(int i)
        {
            bool tirovalido = false;
            int contador = 0;
            while (i != 63)
            {
                if (i == 56 || i == 57 || i == 58 || i == 59 || i == 60 || i == 61 || i == 62 || i == 63)
                {
                    if (tirovalido == true && MenuPrincipal.colores[i].Equals("."))
                    {
                        crearPivote(i);
                    }
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals("negro"))
                {
                    if (contador == 0) { contador = 1; } else { break; }
                }
                else if (MenuPrincipal.colores[i].Equals("pivote"))
                {
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals("blanco"))
                {
                    tirovalido = true;
                }
                else if (MenuPrincipal.colores[i].Equals(".") && tirovalido == true)
                {
                    crearPivote(i);
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals(".") && tirovalido == false)
                {
                    break;
                }
                i = i + 8;
            }
        }

        //Pivote Abajo Blanco
        public void abab(int i)
        {
            bool tirovalido = false;
            int contador = 0;
            while (i != 63)
            {
                if (i == 56 || i == 57 || i == 58 || i == 59 || i == 60 || i == 61 || i == 62 || i == 63)
                {
                    if (tirovalido == true && MenuPrincipal.colores[i].Equals("."))
                    {
                        crearPivote(i);
                    }
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals("blanco"))
                {
                    if (contador == 0) { contador = 1; } else { break; }
                }
                else if (MenuPrincipal.colores[i].Equals("pivote"))
                {
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals("negro"))
                {
                    tirovalido = true;
                }
                else if (MenuPrincipal.colores[i].Equals(".") && tirovalido == true)
                {
                    crearPivote(i);
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals(".") && tirovalido == false)
                {
                    break;
                }
                i = i + 8;
            }
        }

        //Pivote Abajo Derecha Negro
        public void abdern(int i)
        {
            bool tirovalido = false;
            int contador = 0;
            while (i != 7 && i != 56)
            {
                if (i == 7 || i == 15 || i == 23 || i == 31 || i == 39 || i == 47 || i == 55 || i == 63 || i == 62 || i == 61 || i == 60 || i == 59 || i == 58 || i == 57 || i == 56)
                {
                    if (tirovalido == true && MenuPrincipal.colores[i].Equals("."))
                    {
                        crearPivote(i);
                    }
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals("negro"))
                {
                    if (contador == 0) { contador = 1; } else { break; }
                }
                else if (MenuPrincipal.colores[i].Equals("pivote"))
                {
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals("blanco"))
                {
                    tirovalido = true;
                }
                else if (MenuPrincipal.colores[i].Equals(".") && tirovalido == true)
                {
                    crearPivote(i);
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals(".") && tirovalido == false) {
                    break;
                }
                i = i + 9;
            }
        }

        //Pivote Abajo Derecha Blanco
        public void abderb(int i)
        {
            bool tirovalido = false;
            int contador = 0;
            while (i != 7 && i != 56)
            {
                if (i == 7 || i == 15 || i == 23 || i == 31 || i == 39 || i == 47 || i == 55 || i == 63 || i == 62 || i == 61 || i == 60 || i == 59 || i == 58 || i == 57 || i == 56)
                {
                    if (tirovalido == true && MenuPrincipal.colores[i].Equals("."))
                    {
                        crearPivote(i);
                    }
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals("blanco"))
                {
                    if (contador == 0) { contador = 1; } else { break; }
                }
                else if (MenuPrincipal.colores[i].Equals("pivote"))
                {
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals("negro"))
                {
                    tirovalido = true;
                }
                else if (MenuPrincipal.colores[i].Equals(".") && tirovalido == true)
                {
                    crearPivote(i);
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals(".") && tirovalido == false)
                {
                    break;
                }
                i = i + 9;
            }
        }

        //Pivote Abajo Izquierda Negro
        public void abizn(int i)
        {
            bool tirovalido = false;
            int contador = 0;
            while (i != 0 && i != 63)
            {
                if (i == 0 || i == 8 || i == 16 || i == 24 || i == 32 || i == 40 || i == 48 || i == 63 || i == 62 || i == 61 || i == 60 || i == 59 || i == 58 || i == 57 || i == 56)
                {
                    if (tirovalido == true && MenuPrincipal.colores[i].Equals("."))
                    {
                        crearPivote(i);
                    }
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals("negro"))
                {
                    if (contador == 0) { contador = 1; } else { break; }
                }
                else if (MenuPrincipal.colores[i].Equals("pivote"))
                {
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals("blanco"))
                {
                    tirovalido = true;
                }
                else if (MenuPrincipal.colores[i].Equals(".") && tirovalido == true)
                {
                    crearPivote(i);
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals(".") && tirovalido == false)
                {
                    break;
                }
                i = i + 7;
            }
        }

        //Pivote Abajo Izquierda Blanco
        public void abizb(int i)
        {
            bool tirovalido = false;
            int contador = 0;
            while (i != 0 && i != 63)
            {
                if (i == 0 || i == 8 || i == 16 || i == 24 || i == 32 || i == 40 || i == 48 || i == 63 || i == 62 || i == 61 || i == 60 || i == 59 || i == 58 || i == 57 || i == 56)
                {
                    if (tirovalido == true && MenuPrincipal.colores[i].Equals("."))
                    {
                        crearPivote(i);
                    }
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals("blanco"))
                {
                    if (contador == 0) { contador = 1; } else { break; }
                }
                else if (MenuPrincipal.colores[i].Equals("pivote"))
                {
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals("negro"))
                {
                    tirovalido = true;
                }
                else if (MenuPrincipal.colores[i].Equals(".") && tirovalido == true)
                {
                    crearPivote(i);
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals(".") && tirovalido == false)
                {
                    break;
                }
                i = i + 7;
            }
        }

        //Pivote Arriba Derecha Negro
        public void ardern(int i)
        {
            bool tirovalido = false;
            int contador = 0;
            while (i != 0 && i != 63)
            {
                if (i == 7 || i == 15 || i == 23 || i == 31 || i == 39 || i == 47 || i == 55 || i == 63 || i == 6 || i == 5 || i == 4 || i == 3 || i == 2 || i == 1 || i == 0)
                {
                    if (tirovalido == true && MenuPrincipal.colores[i].Equals("."))
                    {
                        crearPivote(i);
                    }
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals("negro"))
                {
                    if (contador == 0) { contador = 1; } else { break; }
                }
                else if (MenuPrincipal.colores[i].Equals("pivote"))
                {
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals("blanco"))
                {
                    tirovalido = true;
                }
                else if (MenuPrincipal.colores[i].Equals(".") && tirovalido == true)
                {
                    crearPivote(i);
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals(".") && tirovalido == false)
                {
                    break;
                }
                i = i - 7;
            }
        }

        //Pivote Arriba Derecha Blanco
        public void arderb(int i)
        {
            bool tirovalido = false;
            int contador = 0;
            while (i != 0 && i != 63)
            {
                if (i == 7 || i == 15 || i == 23 || i == 31 || i == 39 || i == 47 || i == 55 || i == 63 || i == 6 || i == 5 || i == 4 || i == 3 || i == 2 || i == 1 || i == 0)
                {
                    if (tirovalido == true && MenuPrincipal.colores[i].Equals("."))
                    {
                        crearPivote(i);
                    }
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals("blanco"))
                {
                    if (contador == 0) { contador = 1; } else { break; }
                }
                else if (MenuPrincipal.colores[i].Equals("pivote"))
                {
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals("negro"))
                {
                    tirovalido = true;
                }
                else if (MenuPrincipal.colores[i].Equals(".") && tirovalido == true)
                {
                    crearPivote(i);
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals(".") && tirovalido == false)
                {
                    break;
                }
                i = i - 7;
            }
        }

        //Pivote Arriba Izquierda Negro
        public void arizn(int i)
        {
            bool tirovalido = false;
            int contador = 0;
            while (i != 7 && i != 56)
            {
                if (i == 0 || i == 8 || i == 16 || i == 24 || i == 32 || i == 40 || i == 48 || i == 56 || i == 1 || i == 2 || i == 3 || i == 4 || i == 5 || i == 6 || i == 7)
                {
                    if (tirovalido == true && MenuPrincipal.colores[i].Equals("."))
                    {
                        crearPivote(i);
                    }
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals("negro"))
                {
                    if (contador == 0) { contador = 1; } else { break; }
                }
                else if (MenuPrincipal.colores[i].Equals("pivote"))
                {
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals("blanco"))
                {
                    tirovalido = true;
                }
                else if (MenuPrincipal.colores[i].Equals(".") && tirovalido == true)
                {
                    crearPivote(i);
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals(".") && tirovalido == false)
                {
                    break;
                }
                i = i - 9;
            }
        }

        //Pivote Arriba Izquierda Blanco
        public void arizb(int i)
        {
            bool tirovalido = false;
            int contador = 0;
            while (i != 7 && i != 56)
            {
                if (i == 0 || i == 8 || i == 16 || i == 24 || i == 32 || i == 40 || i == 48 || i == 56 || i == 1 || i == 2 || i == 3 || i == 4 || i == 5 || i == 6 || i == 7)
                {
                    if (tirovalido == true && MenuPrincipal.colores[i].Equals("."))
                    {
                        crearPivote(i);
                    }
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals("blanco"))
                {
                    if (contador == 0) { contador = 1; } else { break; }
                }
                else if (MenuPrincipal.colores[i].Equals("pivote"))
                {
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals("negro"))
                {
                    tirovalido = true;
                }
                else if (MenuPrincipal.colores[i].Equals(".") && tirovalido == true)
                {
                    crearPivote(i);
                    break;
                }
                else if (MenuPrincipal.colores[i].Equals(".") && tirovalido == false)
                {
                    break;
                }
                i = i - 9;
            }
        }

        //Obtiene Posiciones a voltear
        public void obtenerV(int i) {
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
                            break;
                        }
                        else if (MenuPrincipal.colores[posaux].Equals(".") || MenuPrincipal.colores[posaux].Equals("pivote"))
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
                            break;
                        }
                        else if (MenuPrincipal.colores[posaux].Equals(".") || MenuPrincipal.colores[posaux].Equals("pivote"))
                        {
                            break;
                        }
                    }
                    pos = pos + 1;
                }

                //Voltear Hacia Arriba del Pivote
                pos = i;
                vuelta.Clear();
                while (bandera)
                {
                    posaux = pos - 8;
                    if (pos == 0 || pos == 1 || pos == 2 || pos == 3 || pos == 4 || pos == 5 || pos == 6 || pos == 7)
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
                            break;
                        }
                        else if (MenuPrincipal.colores[posaux].Equals(".") || MenuPrincipal.colores[posaux].Equals("pivote"))
                        {
                            break;
                        }
                    }
                    pos = pos - 8;
                }

                //Voltear Hacia Abajo del Pivote
                pos = i;
                vuelta.Clear();
                while (bandera)
                {
                    posaux = pos + 8;
                    if (pos == 56 || pos == 57 || pos == 58 || pos == 59 || pos == 60 || pos == 61 || pos == 62 || pos == 63)
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
                            break;
                        }
                        else if (MenuPrincipal.colores[posaux].Equals(".") || MenuPrincipal.colores[posaux].Equals("pivote"))
                        {
                            break;
                        }
                    }
                    pos = pos + 8;
                }

                //Voltear Hacia Abajo Derecha del Pivote
                pos = i;
                vuelta.Clear();
                while (bandera)
                {
                    posaux = pos + 9;
                    if (pos == 7 || pos == 15 || pos == 23 || pos == 31 || pos == 39 || pos == 47 || pos == 55 || pos == 63 || pos == 62 || pos == 61 || pos == 60 || pos == 59 || pos == 58 || pos == 57 || pos == 56)
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
                            break;
                        }
                        else if (MenuPrincipal.colores[posaux].Equals(".") || MenuPrincipal.colores[posaux].Equals("pivote"))
                        {
                            break;
                        }
                    }
                    pos = pos + 9;
                }

                //Voltear Hacia Abajo Izquierda del Pivote
                pos = i;
                vuelta.Clear();
                while (bandera)
                {
                    posaux = pos + 7;
                    if (pos == 0 || pos == 8 || pos == 16 || pos == 24 || pos == 32 || pos == 40 || pos == 48 || pos == 63 || pos == 62 || pos == 61 || pos == 60 || pos == 59 || pos == 58 || pos == 57 || pos == 56)
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
                            break;
                        }
                        else if (MenuPrincipal.colores[posaux].Equals(".") || MenuPrincipal.colores[posaux].Equals("pivote"))
                        {
                            break;
                        }
                    }
                    pos = pos + 7;
                }

                //Voltear Hacia Arriba Derecha del Pivote
                pos = i;
                vuelta.Clear();
                while (bandera)
                {
                    posaux = pos - 7;
                    if (pos == 7 || pos == 15 || pos == 23 || pos == 31 || pos == 39 || pos == 47 || pos == 55 || pos == 63 || pos == 6 || pos == 5 || pos == 4 || pos == 3 || pos == 2 || pos == 1 || pos == 0)
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
                            break;
                        }
                        else if (MenuPrincipal.colores[posaux].Equals(".") || MenuPrincipal.colores[posaux].Equals("pivote"))
                        {
                            break;
                        }
                    }
                    pos = pos - 7;
                }

                //Voltear Hacia Arriba Izquierda del Pivote
                pos = i;
                vuelta.Clear();
                while (bandera)
                {
                    posaux = pos - 9;
                    if (pos == 0 || pos == 8 || pos == 16 || pos == 24 || pos == 32 || pos == 40 || pos == 48 || pos == 56 || pos == 1 || pos == 2 || pos == 3 || pos == 4 || pos == 5 || pos == 6 || pos == 7)
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
                            break;
                        }
                        else if (MenuPrincipal.colores[posaux].Equals(".") || MenuPrincipal.colores[posaux].Equals("pivote"))
                        {
                            break;
                        }
                    }
                    pos = pos - 9;
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
                            break;
                        }
                        else if (MenuPrincipal.colores[posaux].Equals(".") || MenuPrincipal.colores[posaux].Equals("pivote"))
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
                            break;
                        }
                        else if (MenuPrincipal.colores[posaux].Equals(".") || MenuPrincipal.colores[posaux].Equals("pivote"))
                        {
                            break;
                        }
                    }
                    pos = pos + 1;
                }

                //Voltear Hacia Arriba del Pivote
                pos = i;
                vuelta.Clear();
                while (bandera)
                {
                    posaux = pos - 8;
                    if (pos == 0 || pos == 1 || pos == 2 || pos == 3 || pos == 4 || pos == 5 || pos == 6 || pos == 7)
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
                            break;
                        }
                        else if (MenuPrincipal.colores[posaux].Equals(".") || MenuPrincipal.colores[posaux].Equals("pivote"))
                        {
                            break;
                        }
                    }
                    pos = pos - 8;
                }

                //Voltear Hacia Abajo del Pivote
                pos = i;
                vuelta.Clear();
                while (bandera)
                {
                    posaux = pos + 8;
                    if (pos == 56 || pos == 57 || pos == 58 || pos == 59 || pos == 60 || pos == 61 || pos == 62 || pos == 63)
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
                            break;
                        }
                        else if (MenuPrincipal.colores[posaux].Equals(".") || MenuPrincipal.colores[posaux].Equals("pivote"))
                        {
                            break;
                        }
                    }
                    pos = pos + 8;
                }

                //Voltear Hacia Abajo Derecha del Pivote
                pos = i;
                vuelta.Clear();
                while (bandera)
                {
                    posaux = pos + 9;
                    if (pos == 7 || pos == 15 || pos == 23 || pos == 31 || pos == 39 || pos == 47 || pos == 55 || pos == 63 || pos == 62 || pos == 61 || pos == 60 || pos == 59 || pos == 58 || pos == 57 || pos == 56)
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
                            break;
                        }
                        else if (MenuPrincipal.colores[posaux].Equals(".") || MenuPrincipal.colores[posaux].Equals("pivote"))
                        {
                            break;
                        }
                    }
                    pos = pos + 9;
                }

                //Voltear Hacia Abajo Izquierda del Pivote
                pos = i;
                vuelta.Clear();
                while (bandera)
                {
                    posaux = pos + 7;
                    if (pos == 0 || pos == 8 || pos == 16 || pos == 24 || pos == 32 || pos == 40 || pos == 48 || pos == 63 || pos == 62 || pos == 61 || pos == 60 || pos == 59 || pos == 58 || pos == 57 || pos == 56)
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
                            break;
                        }
                        else if (MenuPrincipal.colores[posaux].Equals(".") || MenuPrincipal.colores[posaux].Equals("pivote"))
                        {
                            break;
                        }
                    }
                    pos = pos + 7;
                }

                //Voltear Hacia Arriba Derecha del Pivote
                pos = i;
                vuelta.Clear();
                while (bandera)
                {
                    posaux = pos - 7;
                    if (pos == 7 || pos == 15 || pos == 23 || pos == 31 || pos == 39 || pos == 47 || pos == 55 || pos == 63 || pos == 6 || pos == 5 || pos == 4 || pos == 3 || pos == 2 || pos == 1 || pos == 0)
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
                            break;
                        }
                        else if (MenuPrincipal.colores[posaux].Equals(".") || MenuPrincipal.colores[posaux].Equals("pivote"))
                        {
                            break;
                        }
                    }
                    pos = pos - 7;
                }

                //Voltear Hacia Arriba Izquierda del Pivote
                pos = i;
                vuelta.Clear();
                while (bandera)
                {
                    posaux = pos - 9;
                    if (pos == 0 || pos == 8 || pos == 16 || pos == 24 || pos == 32 || pos == 40 || pos == 48 || pos == 56 || pos == 1 || pos == 2 || pos == 3 || pos == 4 || pos == 5 || pos == 6 || pos == 7)
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
                            break;
                        }
                        else if (MenuPrincipal.colores[posaux].Equals(".") || MenuPrincipal.colores[posaux].Equals("pivote"))
                        {
                            break;
                        }
                    }
                    pos = pos - 9;
                }
            }
        }

        // Voltea posiciones
        public void voltear(List<int> vuelta) {
            foreach (int i in vuelta)
            {
                if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "1")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        A1.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        A1.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "1")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        B1.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        B1.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "1")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        C1.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        C1.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "1")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        D1.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        D1.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "1")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        E1.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        E1.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "1")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        F1.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        F1.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "1")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        G1.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        G1.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "1")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        H1.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        H1.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "2")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        A2.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        A2.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "2")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        B2.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        B2.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "2")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        C2.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        C2.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "2")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        D2.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        D2.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "2")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        E2.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        E2.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "2")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        F2.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        F2.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "2")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        G2.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        G2.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "2")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        H2.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        H2.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "3")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        A3.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        A3.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "3")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        B3.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        B3.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "3")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        C3.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        C3.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "3")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        D3.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        D3.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "3")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        E3.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        E3.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "3")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        F3.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        F3.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "3")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        G3.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        G3.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "3")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        H3.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        H3.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "4")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        A4.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        A4.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "4")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        B4.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        B4.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "4")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        C4.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        C4.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "4")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        D4.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        D4.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "4")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        E4.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        E4.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "4")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        F4.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        F4.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "4")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        G4.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        G4.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "4")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        H4.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        H4.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "5")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        A5.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        A5.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "5")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        B5.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        B5.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "5")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        C5.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        C5.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "5")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        D5.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        D5.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "5")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        E5.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        E5.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "5")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        F5.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        F5.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "5")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        G5.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        G5.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "5")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        H5.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        H5.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "6")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        A6.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        A6.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "6")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        B6.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        B6.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "6")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        C6.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        C6.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "6")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        D6.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        D6.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "6")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        E6.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        E6.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "6")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        F6.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        F6.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "6")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        G6.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        G6.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "6")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        H6.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        H6.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "7")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        A7.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        A7.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "7")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        B7.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        B7.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }

                }
                else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "7")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        C7.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        C7.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "7")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        D7.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        D7.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "7")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        E7.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        E7.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "7")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        F7.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        F7.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "7")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        G7.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        G7.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "7")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        H7.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        H7.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "A" && MenuPrincipal.filaaux[i] == "8")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        A8.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        A8.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "B" && MenuPrincipal.filaaux[i] == "8")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        B8.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        B8.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "C" && MenuPrincipal.filaaux[i] == "8")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        C8.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        C8.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "D" && MenuPrincipal.filaaux[i] == "8")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        D8.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        D8.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "E" && MenuPrincipal.filaaux[i] == "8")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        E8.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        E8.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "F" && MenuPrincipal.filaaux[i] == "8")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        F8.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        F8.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "G" && MenuPrincipal.filaaux[i] == "8")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        G8.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        G8.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
                else if (MenuPrincipal.columaux[i] == "H" && MenuPrincipal.filaaux[i] == "8")
                {
                    if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        H8.ImageUrl = "negro.png";
                        MenuPrincipal.colores[i] = "negro";
                    }
                    else if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        H8.ImageUrl = "blanco.png";
                        MenuPrincipal.colores[i] = "blanco";
                    }
                }
            }
        }

        //Terminar Partida o saltar turno
        public void siguiente() {
            if (color.Equals("blanco"))
            {
                int turno = validar();
                if (turno == 0)
                {
                    color = "negro";
                    pivote();
                    turno = validar();
                    if (turno == 0)
                    {
                        //Se acabo el juego
                        XDocument archivo = new XDocument(new XDeclaration("1.0", "utf-8", null));
                        XElement raiz = new XElement("tablero");
                        raiz.RemoveAll();
                        archivo.Add(raiz);
                        for (int i = 0; i <= 63; i++)
                        {
                            if (!MenuPrincipal.colores[i].Equals(".") && !MenuPrincipal.colores[i].Equals("pivote"))
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
                            siguientetiro.Add(new XElement("color", "negro"));
                            raiz.Add(siguientetiro);
                        }
                        else if (color.Equals("blanco"))
                        {
                            siguientetiro.Add(new XElement("color", "blanco"));
                        }
                        if (bandera == false)
                        {
                            BaseDatos bd = new BaseDatos();
                            string datos = "insert into partida(partida_g,tipo_partida,color,movimientos,pge,id_usuario) values(@partida_g,@tipo_partida,@color,@movimientos,@pge,@id_usuario)";
                            SqlCommand accion = new SqlCommand(datos, bd.registrar());
                            accion.Parameters.AddWithValue("@partida_g", archivo.ToString());
                            accion.Parameters.AddWithValue("@tipo_partida", partida);
                            accion.Parameters.AddWithValue("@color", colorJ);
                            if (colorJ.Equals("negro"))
                            {
                                accion.Parameters.AddWithValue("@movimientos", movn);
                            }
                            else if (colorJ.Equals("blanco"))
                            {
                                accion.Parameters.AddWithValue("@movimientos", movb);
                            }
                            accion.Parameters.AddWithValue("@pge", gamperem);
                            accion.Parameters.AddWithValue("@id_usuario", InicioSesion.jugador);
                            accion.ExecuteNonQuery();
                            Titulo.Text = "Partida Finalizada";
                            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ventana,", "$('#ventana').modal();", true);
                            panelModal.Update();
                        }
                        else
                        {
                            BaseDatos bd = new BaseDatos();
                            string datos = "UPDATE partida SET partida_g = @partida_g, movimientos = @movimientos, pge = @pge WHERE id_usuario = @id_usuario and id_partida = @id_partida; ";
                            SqlCommand accion = new SqlCommand(datos, bd.registrar());
                            accion.Parameters.AddWithValue("@partida_g", archivo.ToString());
                            if (colorJ.Equals("negro")) {
                                accion.Parameters.AddWithValue("@movimientos", movn);
                            }
                            else if (colorJ.Equals("blanco"))
                            {
                                accion.Parameters.AddWithValue("@movimientos", movb);
                            }
                            accion.Parameters.AddWithValue("@pge", gamperem);
                            accion.Parameters.AddWithValue("@id_usuario", InicioSesion.jugador);
                            accion.Parameters.AddWithValue("@id_partida", Cargar.id_partida);
                            accion.ExecuteNonQuery();
                            Titulo.Text = "Partida Finalizada";
                            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ventana,", "$('#ventana').modal();", true);
                            panelModal.Update();
                        }
                    }
                    else
                    {
                        Titulo.Text = "No hay tiros posibles, turno saltado";
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ventana,", "$('#ventana').modal();", true);
                        panelModal.Update();
                    }
                }
            }
            else {
                int turno = validar();
                if (turno == 0)
                {
                    color = "blanco";
                    pivote();
                    turno = validar();
                    if (turno == 0)
                    {
                        //Se acabo el juego
                        XDocument archivo = new XDocument(new XDeclaration("1.0", "utf-8", null));
                        XElement raiz = new XElement("tablero");
                        raiz.RemoveAll();
                        archivo.Add(raiz);
                        for (int i = 0; i <= 63; i++)
                        {
                            if (!MenuPrincipal.colores[i].Equals(".") && !MenuPrincipal.colores[i].Equals("pivote"))
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
                            siguientetiro.Add(new XElement("color", "negro"));
                            raiz.Add(siguientetiro);
                        }
                        else if (color.Equals("blanco"))
                        {
                            siguientetiro.Add(new XElement("color", "blanco"));
                        }
                        if (bandera == false)
                        {
                            movn = 0;
                            movb = 0;
                            for (int i = 0; i <= 63; i++) {
                                if (MenuPrincipal.colores[i].Equals("negro")) { movn++; }
                                else { movb++; }
                            }
                            if (colorJ.Equals("negro"))
                            {
                                if (movb < movn)
                                {
                                    gamperem = "Victoria";
                                }
                                else if (movb > movn)
                                {
                                    gamperem = "Perdido";
                                }
                                else if (movb == movn)
                                {
                                    gamperem = "Empate";
                                }
                            }
                            else
                            {
                                if (movb < movn)
                                {
                                    gamperem = "Perdido";
                                }
                                else if (movb > movn)
                                {
                                    gamperem = "Victoria";
                                }
                                else if (movb == movn)
                                {
                                    gamperem = "Empate";
                                }
                            }
                            
                            BaseDatos bd = new BaseDatos();
                            string datos = "insert into partida(partida_g,tipo_partida,color,movimientos,pge,id_usuario) values(@partida_g,@tipo_partida,@color,@movimientos,@pge,@id_usuario)";
                            SqlCommand accion = new SqlCommand(datos, bd.registrar());
                            accion.Parameters.AddWithValue("@partida_g", archivo.ToString());
                            accion.Parameters.AddWithValue("@tipo_partida", partida);
                            accion.Parameters.AddWithValue("@color", colorJ);
                            if (colorJ.Equals("negro"))
                            {
                                accion.Parameters.AddWithValue("@movimientos", movn);
                            }
                            else if (colorJ.Equals("blanco"))
                            {
                                accion.Parameters.AddWithValue("@movimientos", movb);
                            }
                            accion.Parameters.AddWithValue("@pge", gamperem);
                            accion.Parameters.AddWithValue("@id_usuario", InicioSesion.jugador);
                            accion.ExecuteNonQuery();
                            Titulo.Text = "Partida Finalizada";
                            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ventana,", "$('#ventana').modal();", true);
                            panelModal.Update();
                        }
                        else
                        {
                            if (colorJ.Equals("negro"))
                            {
                                if (movb < movn)
                                {
                                    gamperem = "Victoria";
                                }
                                else if (movb > movn)
                                {
                                    gamperem = "Perdido";
                                }
                                else if (movb == movn)
                                {
                                    gamperem = "Empate";
                                }
                            }
                            else
                            {
                                if (movb < movn)
                                {
                                    gamperem = "Perdido";
                                }
                                else if (movb > movn)
                                {
                                    gamperem = "Victoria";
                                }
                                else if (movb == movn)
                                {
                                    gamperem = "Empate";
                                }
                            }
                            BaseDatos bd = new BaseDatos();
                            string datos = "UPDATE partida SET partida_g = @partida_g, movimientos = @movimientos, pge = @pge WHERE id_usuario = @id_usuario and id_partida = @id_partida; ";
                            SqlCommand accion = new SqlCommand(datos, bd.registrar());
                            accion.Parameters.AddWithValue("@partida_g", archivo.ToString());
                            if (colorJ.Equals("negro"))
                            {
                                accion.Parameters.AddWithValue("@movimientos", movn);
                            }
                            else if (colorJ.Equals("blanco"))
                            {
                                accion.Parameters.AddWithValue("@movimientos", movb);
                            }
                            accion.Parameters.AddWithValue("@pge", gamperem);
                            accion.Parameters.AddWithValue("@id_usuario", InicioSesion.jugador);
                            accion.Parameters.AddWithValue("@id_partida", Cargar.id_partida);
                            accion.ExecuteNonQuery();
                            Titulo.Text = "Partida Finalizada";
                            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ventana,", "$('#ventana').modal();", true);
                            panelModal.Update();
                        }
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

        //Validar turno
        public int validar() {
            int contador = 0;
            for (int i = 0; i <= 63; i++) {
                if (MenuPrincipal.colores[i].Equals("pivote")) {
                    contador++;
                }
            }
            return contador;
        }

        //Jugador
        public void boton(ImageButton tiro, int  i) {
            if (color.Equals("negro"))
            {
                tiro.ImageUrl = "negro.png";
                tiro.Enabled = false;
                mov++;
                movn++;
                MenuPrincipal.colores[i] = "negro";
                MenuPrincipal.colum[i] = MenuPrincipal.columaux[i];
                MenuPrincipal.fila[i] = MenuPrincipal.filaaux[i]; ;
                obtenerV(i);
                puntosb = 0;
                puntosn = 0;
                for (int z = 0; z <= 63; z++) {
                    if (MenuPrincipal.colores[z].Equals("negro")) {
                        puntosn++;
                    }
                    else if (MenuPrincipal.colores[z].Equals("blanco"))
                    {
                        puntosb++;
                    }
                }
                color = "blanco";
                pivote();
                MovN.Text = "Movimientos: " + Convert.ToString(movn);
                MovB.Text = "Movimientos: " + Convert.ToString(movb);
                PunN.Text = "Puntos: " + Convert.ToString(puntosn);
                PunB.Text = "Puntos: " + Convert.ToString(puntosb);
                TurnoNegro.ImageUrl = "vacio.png";
                TurnoBlanco.ImageUrl = "blanco.png";
                siguiente();
            }
            else {
                tiro.ImageUrl = "blanco.png";
                tiro.Enabled = false;
                mov++;
                movb++;
                MenuPrincipal.colores[i] = "blanco";
                MenuPrincipal.colum[i] = MenuPrincipal.columaux[i];
                MenuPrincipal.fila[i] = MenuPrincipal.filaaux[i]; ;
                obtenerV(i);
                puntosb = 0;
                puntosn = 0;
                for (int z = 0; z <= 63; z++)
                {
                    if (MenuPrincipal.colores[z].Equals("negro"))
                    {
                        puntosn++;
                    }
                    else if (MenuPrincipal.colores[z].Equals("blanco"))
                    {
                        puntosb++;
                    }
                }
                color = "negro";
                pivote();
                MovN.Text = "Movimientos: " + Convert.ToString(movn);
                MovB.Text = "Movimientos: " + Convert.ToString(movb);
                PunN.Text = "Puntos: " + Convert.ToString(puntosn);
                PunB.Text = "Puntos: " + Convert.ToString(puntosb);
                TurnoNegro.ImageUrl = "negro.png";
                TurnoBlanco.ImageUrl = "vacio.png";
                siguiente();
            }
        }

        //Maquina
        public void Maquina(ImageButton tiro, int i) {
            pivoteM.Clear();
            if (colorJ.Equals("negro"))
            {
                tiro.ImageUrl = "negro.png";
                tiro.Enabled = false;
                mov++;
                movn++;
                MenuPrincipal.colores[i] = "negro";
                MenuPrincipal.colum[i] = MenuPrincipal.columaux[i];
                MenuPrincipal.fila[i] = MenuPrincipal.filaaux[i]; 
                obtenerV(i);
                color = "blanco";
                pivote();
                for (int z = 0; z <= 63; z++)
                {
                    if (MenuPrincipal.colores[z].Equals("pivote")) {
                        pivoteM.Add(z);
                    }
                }
                siguienteM(pivoteM);
            }
            else
            {
                tiro.ImageUrl = "blanco.png";
                tiro.Enabled = false;
                mov++;
                movb++;
                MenuPrincipal.colores[i] = "blanco";
                MenuPrincipal.colum[i] = MenuPrincipal.columaux[i];
                MenuPrincipal.fila[i] = MenuPrincipal.filaaux[i];
                obtenerV(i);
                color = "negro";
                pivote();
                for (int z = 0; z <= 63; z++)
                {
                    if (MenuPrincipal.colores[z].Equals("pivote"))
                    {
                        pivoteM.Add(z);
                    }
                }
                siguienteM(pivoteM);
            
            }
        }

        //Tiro o Saltar Turno Maquina
        public void siguienteM(List<int> pivotes) {
            tirosM.Clear();
            if (pivotes.Count != 0)
            {
                foreach (int i in pivotes)
                {
                    int cantidad = 0;
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
                                    cantidad++;
                                }
                                else if (MenuPrincipal.colores[posaux].Equals("negro"))
                                {
                                    break;
                                }
                                else if (MenuPrincipal.colores[posaux].Equals(".") || MenuPrincipal.colores[posaux].Equals("pivote"))
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
                                    cantidad++;
                                }
                                else if (MenuPrincipal.colores[posaux].Equals("negro"))
                                {
                                    break;
                                }
                                else if (MenuPrincipal.colores[posaux].Equals(".") || MenuPrincipal.colores[posaux].Equals("pivote"))
                                {
                                    break;
                                }
                            }
                            pos = pos + 1;
                        }

                        //Voltear Hacia Arriba del Pivote
                        pos = i;
                        vuelta.Clear();
                        while (bandera)
                        {
                            posaux = pos - 8;
                            if (pos == 0 || pos == 1 || pos == 2 || pos == 3 || pos == 4 || pos == 5 || pos == 6 || pos == 7)
                            {
                                break;
                            }
                            else
                            {
                                if (MenuPrincipal.colores[posaux].Equals("blanco"))
                                {
                                    cantidad++;
                                }
                                else if (MenuPrincipal.colores[posaux].Equals("negro"))
                                {
                                    break;
                                }
                                else if (MenuPrincipal.colores[posaux].Equals(".") || MenuPrincipal.colores[posaux].Equals("pivote"))
                                {
                                    break;
                                }
                            }
                            pos = pos - 8;
                        }

                        //Voltear Hacia Abajo del Pivote
                        pos = i;
                        vuelta.Clear();
                        while (bandera)
                        {
                            posaux = pos + 8;
                            if (pos == 56 || pos == 57 || pos == 58 || pos == 59 || pos == 60 || pos == 61 || pos == 62 || pos == 63)
                            {
                                break;
                            }
                            else
                            {
                                if (MenuPrincipal.colores[posaux].Equals("blanco"))
                                {
                                    cantidad++;
                                }
                                else if (MenuPrincipal.colores[posaux].Equals("negro"))
                                {
                                    break;
                                }
                                else if (MenuPrincipal.colores[posaux].Equals(".") || MenuPrincipal.colores[posaux].Equals("pivote"))
                                {
                                    break;
                                }
                            }
                            pos = pos + 8;
                        }

                        //Voltear Hacia Abajo Derecha del Pivote
                        pos = i;
                        vuelta.Clear();
                        while (bandera)
                        {
                            posaux = pos + 9;
                            if (pos == 7 || pos == 15 || pos == 23 || pos == 31 || pos == 39 || pos == 47 || pos == 55 || pos == 63 || pos == 62 || pos == 61 || pos == 60 || pos == 59 || pos == 58 || pos == 57 || pos == 56)
                            {
                                break;
                            }
                            else
                            {
                                if (MenuPrincipal.colores[posaux].Equals("blanco"))
                                {
                                    cantidad++;
                                }
                                else if (MenuPrincipal.colores[posaux].Equals("negro"))
                                {
                                    break;
                                }
                                else if (MenuPrincipal.colores[posaux].Equals(".") || MenuPrincipal.colores[posaux].Equals("pivote"))
                                {
                                    break;
                                }
                            }
                            pos = pos + 9;
                        }

                        //Voltear Hacia Abajo Izquierda del Pivote
                        pos = i;
                        vuelta.Clear();
                        while (bandera)
                        {
                            posaux = pos + 7;
                            if (pos == 0 || pos == 8 || pos == 16 || pos == 24 || pos == 32 || pos == 40 || pos == 48 || pos == 63 || pos == 62 || pos == 61 || pos == 60 || pos == 59 || pos == 58 || pos == 57 || pos == 56)
                            {
                                break;
                            }
                            else
                            {
                                if (MenuPrincipal.colores[posaux].Equals("blanco"))
                                {
                                    cantidad++;
                                }
                                else if (MenuPrincipal.colores[posaux].Equals("negro"))
                                {
                                    break;
                                }
                                else if (MenuPrincipal.colores[posaux].Equals(".") || MenuPrincipal.colores[posaux].Equals("pivote"))
                                {
                                    break;
                                }
                            }
                            pos = pos + 7;
                        }

                        //Voltear Hacia Arriba Derecha del Pivote
                        pos = i;
                        vuelta.Clear();
                        while (bandera)
                        {
                            posaux = pos - 7;
                            if (pos == 7 || pos == 15 || pos == 23 || pos == 31 || pos == 39 || pos == 47 || pos == 55 || pos == 63 || pos == 6 || pos == 5 || pos == 4 || pos == 3 || pos == 2 || pos == 1 || pos == 0)
                            {
                                break;
                            }
                            else
                            {
                                if (MenuPrincipal.colores[posaux].Equals("blanco"))
                                {
                                    cantidad++;
                                }
                                else if (MenuPrincipal.colores[posaux].Equals("negro"))
                                {
                                    break;
                                }
                                else if (MenuPrincipal.colores[posaux].Equals(".") || MenuPrincipal.colores[posaux].Equals("pivote"))
                                {
                                    break;
                                }
                            }
                            pos = pos - 7;
                        }

                        //Voltear Hacia Arriba Izquierda del Pivote
                        pos = i;
                        vuelta.Clear();
                        while (bandera)
                        {
                            posaux = pos - 9;
                            if (pos == 0 || pos == 8 || pos == 16 || pos == 24 || pos == 32 || pos == 40 || pos == 48 || pos == 56 || pos == 1 || pos == 2 || pos == 3 || pos == 4 || pos == 5 || pos == 6 || pos == 7)
                            {
                                break;
                            }
                            else
                            {
                                if (MenuPrincipal.colores[posaux].Equals("blanco"))
                                {
                                    cantidad++;
                                }
                                else if (MenuPrincipal.colores[posaux].Equals("negro"))
                                {
                                    break;
                                }
                                else if (MenuPrincipal.colores[posaux].Equals(".") || MenuPrincipal.colores[posaux].Equals("pivote"))
                                {
                                    break;
                                }
                            }
                            pos = pos - 9;
                        }
                    }
                    else
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
                                if (MenuPrincipal.colores[posaux].Equals("negro"))
                                {
                                    cantidad++;
                                }
                                else if (MenuPrincipal.colores[posaux].Equals("blanco"))
                                {
                                    break;
                                }
                                else if (MenuPrincipal.colores[posaux].Equals(".") || MenuPrincipal.colores[posaux].Equals("pivote"))
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
                                    cantidad++;
                                }
                                else if (MenuPrincipal.colores[posaux].Equals("blanco"))
                                {
                                    break;
                                }
                                else if (MenuPrincipal.colores[posaux].Equals(".") || MenuPrincipal.colores[posaux].Equals("pivote"))
                                {
                                    break;
                                }
                            }
                            pos = pos + 1;
                        }

                        //Voltear Hacia Arriba del Pivote
                        pos = i;
                        vuelta.Clear();
                        while (bandera)
                        {
                            posaux = pos - 8;
                            if (pos == 0 || pos == 1 || pos == 2 || pos == 3 || pos == 4 || pos == 5 || pos == 6 || pos == 7)
                            {
                                break;
                            }
                            else
                            {
                                if (MenuPrincipal.colores[posaux].Equals("negro"))
                                {
                                    cantidad++;
                                }
                                else if (MenuPrincipal.colores[posaux].Equals("blanco"))
                                {
                                    break;
                                }
                                else if (MenuPrincipal.colores[posaux].Equals(".") || MenuPrincipal.colores[posaux].Equals("pivote"))
                                {
                                    break;
                                }
                            }
                            pos = pos - 8;
                        }

                        //Voltear Hacia Abajo del Pivote
                        pos = i;
                        vuelta.Clear();
                        while (bandera)
                        {
                            posaux = pos + 8;
                            if (pos == 56 || pos == 57 || pos == 58 || pos == 59 || pos == 60 || pos == 61 || pos == 62 || pos == 63)
                            {
                                break;
                            }
                            else
                            {
                                if (MenuPrincipal.colores[posaux].Equals("negro"))
                                {
                                    cantidad++;
                                }
                                else if (MenuPrincipal.colores[posaux].Equals("blanco"))
                                {
                                    break;
                                }
                                else if (MenuPrincipal.colores[posaux].Equals(".") || MenuPrincipal.colores[posaux].Equals("pivote"))
                                {
                                    break;
                                }
                            }
                            pos = pos + 8;
                        }

                        //Voltear Hacia Abajo Derecha del Pivote
                        pos = i;
                        vuelta.Clear();
                        while (bandera)
                        {
                            posaux = pos + 9;
                            if (pos == 7 || pos == 15 || pos == 23 || pos == 31 || pos == 39 || pos == 47 || pos == 55 || pos == 63 || pos == 62 || pos == 61 || pos == 60 || pos == 59 || pos == 58 || pos == 57 || pos == 56)
                            {
                                break;
                            }
                            else
                            {
                                if (MenuPrincipal.colores[posaux].Equals("negro"))
                                {
                                    cantidad++;
                                }
                                else if (MenuPrincipal.colores[posaux].Equals("blanco"))
                                {
                                    break;
                                }
                                else if (MenuPrincipal.colores[posaux].Equals(".") || MenuPrincipal.colores[posaux].Equals("pivote"))
                                {
                                    break;
                                }
                            }
                            pos = pos + 9;
                        }

                        //Voltear Hacia Abajo Izquierda del Pivote
                        pos = i;
                        vuelta.Clear();
                        while (bandera)
                        {
                            posaux = pos + 7;
                            if (pos == 0 || pos == 8 || pos == 16 || pos == 24 || pos == 32 || pos == 40 || pos == 48 || pos == 63 || pos == 62 || pos == 61 || pos == 60 || pos == 59 || pos == 58 || pos == 57 || pos == 56)
                            {
                                break;
                            }
                            else
                            {
                                if (MenuPrincipal.colores[posaux].Equals("negro"))
                                {
                                    cantidad++;
                                }
                                else if (MenuPrincipal.colores[posaux].Equals("blanco"))
                                {
                                    break;
                                }
                                else if (MenuPrincipal.colores[posaux].Equals(".") || MenuPrincipal.colores[posaux].Equals("pivote"))
                                {
                                    break;
                                }
                            }
                            pos = pos + 7;
                        }

                        //Voltear Hacia Arriba Derecha del Pivote
                        pos = i;
                        vuelta.Clear();
                        while (bandera)
                        {
                            posaux = pos - 7;
                            if (pos == 7 || pos == 15 || pos == 23 || pos == 31 || pos == 39 || pos == 47 || pos == 55 || pos == 63 || pos == 6 || pos == 5 || pos == 4 || pos == 3 || pos == 2 || pos == 1 || pos == 0)
                            {
                                break;
                            }
                            else
                            {
                                if (MenuPrincipal.colores[posaux].Equals("negro"))
                                {
                                    cantidad++;
                                }
                                else if (MenuPrincipal.colores[posaux].Equals("blanco"))
                                {
                                    break;
                                }
                                else if (MenuPrincipal.colores[posaux].Equals(".") || MenuPrincipal.colores[posaux].Equals("pivote"))
                                {
                                    break;
                                }
                            }
                            pos = pos - 7;
                        }

                        //Voltear Hacia Arriba Izquierda del Pivote
                        pos = i;
                        vuelta.Clear();
                        while (bandera)
                        {
                            posaux = pos - 9;
                            if (pos == 0 || pos == 8 || pos == 16 || pos == 24 || pos == 32 || pos == 40 || pos == 48 || pos == 56 || pos == 1 || pos == 2 || pos == 3 || pos == 4 || pos == 5 || pos == 6 || pos == 7)
                            {
                                break;
                            }
                            else
                            {
                                if (MenuPrincipal.colores[posaux].Equals("negro"))
                                {
                                    cantidad++;
                                }
                                else if (MenuPrincipal.colores[posaux].Equals("blanco"))
                                {
                                    break;
                                }
                                else if (MenuPrincipal.colores[posaux].Equals(".") || MenuPrincipal.colores[posaux].Equals("pivote"))
                                {
                                    break;
                                }
                            }
                            pos = pos - 9;
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
                if (MenuPrincipal.columaux[tiro] == "A" && MenuPrincipal.filaaux[tiro] == "1")
                {
                    boton(A1, 0);
                }
                else if (MenuPrincipal.columaux[tiro] == "B" && MenuPrincipal.filaaux[tiro] == "1")
                {
                    boton(B1, 1);
                }
                else if (MenuPrincipal.columaux[tiro] == "C" && MenuPrincipal.filaaux[tiro] == "1")
                {
                    boton(C1, 2);
                }
                else if (MenuPrincipal.columaux[tiro] == "D" && MenuPrincipal.filaaux[tiro] == "1")
                {
                    boton(D1, 3);
                }
                else if (MenuPrincipal.columaux[tiro] == "E" && MenuPrincipal.filaaux[tiro] == "1")
                {
                    boton(E1, 4);
                }
                else if (MenuPrincipal.columaux[tiro] == "F" && MenuPrincipal.filaaux[tiro] == "1")
                {
                    boton(F1, 5);
                }
                else if (MenuPrincipal.columaux[tiro] == "G" && MenuPrincipal.filaaux[tiro] == "1")
                {
                    boton(G1, 6);
                }
                else if (MenuPrincipal.columaux[tiro] == "H" && MenuPrincipal.filaaux[tiro] == "1")
                {
                    boton(H1, 7);
                }
                else if (MenuPrincipal.columaux[tiro] == "A" && MenuPrincipal.filaaux[tiro] == "2")
                {
                    boton(A2, 8);
                }
                else if (MenuPrincipal.columaux[tiro] == "B" && MenuPrincipal.filaaux[tiro] == "2")
                {
                    boton(B2, 9);
                }
                else if (MenuPrincipal.columaux[tiro] == "C" && MenuPrincipal.filaaux[tiro] == "2")
                {
                    boton(C2, 10);
                }
                else if (MenuPrincipal.columaux[tiro] == "D" && MenuPrincipal.filaaux[tiro] == "2")
                {
                    boton(D2, 11);
                }
                else if (MenuPrincipal.columaux[tiro] == "E" && MenuPrincipal.filaaux[tiro] == "2")
                {
                    boton(E2, 12);
                }
                else if (MenuPrincipal.columaux[tiro] == "F" && MenuPrincipal.filaaux[tiro] == "2")
                {
                    boton(F2, 13);
                }
                else if (MenuPrincipal.columaux[tiro] == "G" && MenuPrincipal.filaaux[tiro] == "2")
                {
                    boton(G2, 14);
                }
                else if (MenuPrincipal.columaux[tiro] == "H" && MenuPrincipal.filaaux[tiro] == "2")
                {
                    boton(H2, 15);
                }
                else if (MenuPrincipal.columaux[tiro] == "A" && MenuPrincipal.filaaux[tiro] == "3")
                {
                    boton(A3, 16);
                }
                else if (MenuPrincipal.columaux[tiro] == "B" && MenuPrincipal.filaaux[tiro] == "3")
                {
                    boton(B3, 17);
                }
                else if (MenuPrincipal.columaux[tiro] == "C" && MenuPrincipal.filaaux[tiro] == "3")
                {
                    boton(C3, 18);
                }
                else if (MenuPrincipal.columaux[tiro] == "D" && MenuPrincipal.filaaux[tiro] == "3")
                {
                    boton(D3, 19);
                }
                else if (MenuPrincipal.columaux[tiro] == "E" && MenuPrincipal.filaaux[tiro] == "3")
                {
                    boton(E3, 20);
                }
                else if (MenuPrincipal.columaux[tiro] == "F" && MenuPrincipal.filaaux[tiro] == "3")
                {
                    boton(F3, 21);
                }
                else if (MenuPrincipal.columaux[tiro] == "G" && MenuPrincipal.filaaux[tiro] == "3")
                {
                    boton(G3, 22);
                }
                else if (MenuPrincipal.columaux[tiro] == "H" && MenuPrincipal.filaaux[tiro] == "3")
                {
                    boton(H3, 23);
                }
                else if (MenuPrincipal.columaux[tiro] == "A" && MenuPrincipal.filaaux[tiro] == "4")
                {
                    boton(A4, 24);
                }
                else if (MenuPrincipal.columaux[tiro] == "B" && MenuPrincipal.filaaux[tiro] == "4")
                {
                    boton(B4, 25);
                }
                else if (MenuPrincipal.columaux[tiro] == "C" && MenuPrincipal.filaaux[tiro] == "4")
                {
                    boton(C4, 26);
                }
                else if (MenuPrincipal.columaux[tiro] == "D" && MenuPrincipal.filaaux[tiro] == "4")
                {
                    boton(D4, 27);
                }
                else if (MenuPrincipal.columaux[tiro] == "E" && MenuPrincipal.filaaux[tiro] == "4")
                {
                    boton(E4, 28);
                }
                else if (MenuPrincipal.columaux[tiro] == "F" && MenuPrincipal.filaaux[tiro] == "4")
                {
                    boton(F4, 29);
                }
                else if (MenuPrincipal.columaux[tiro] == "G" && MenuPrincipal.filaaux[tiro] == "4")
                {
                    boton(G4, 30);
                }
                else if (MenuPrincipal.columaux[tiro] == "H" && MenuPrincipal.filaaux[tiro] == "4")
                {
                    boton(H4, 31);
                }
                else if (MenuPrincipal.columaux[tiro] == "A" && MenuPrincipal.filaaux[tiro] == "5")
                {
                    boton(A5, 32);
                }
                else if (MenuPrincipal.columaux[tiro] == "B" && MenuPrincipal.filaaux[tiro] == "5")
                {
                    boton(B5, 33);
                }
                else if (MenuPrincipal.columaux[tiro] == "C" && MenuPrincipal.filaaux[tiro] == "5")
                {
                    boton(C5, 34);
                }
                else if (MenuPrincipal.columaux[tiro] == "D" && MenuPrincipal.filaaux[tiro] == "5")
                {
                    boton(D5, 35);
                }
                else if (MenuPrincipal.columaux[tiro] == "E" && MenuPrincipal.filaaux[tiro] == "5")
                {
                    boton(E5, 36);
                }
                else if (MenuPrincipal.columaux[tiro] == "F" && MenuPrincipal.filaaux[tiro] == "5")
                {
                    boton(F5, 37);
                }
                else if (MenuPrincipal.columaux[tiro] == "G" && MenuPrincipal.filaaux[tiro] == "5")
                {
                    boton(G5, 38);
                }
                else if (MenuPrincipal.columaux[tiro] == "H" && MenuPrincipal.filaaux[tiro] == "5")
                {
                    boton(H5, 39);
                }
                else if (MenuPrincipal.columaux[tiro] == "A" && MenuPrincipal.filaaux[tiro] == "6")
                {
                    boton(A6, 40);
                }
                else if (MenuPrincipal.columaux[tiro] == "B" && MenuPrincipal.filaaux[tiro] == "6")
                {
                    boton(B6, 41);
                }
                else if (MenuPrincipal.columaux[tiro] == "C" && MenuPrincipal.filaaux[tiro] == "6")
                {
                    boton(C6, 42);
                }
                else if (MenuPrincipal.columaux[tiro] == "D" && MenuPrincipal.filaaux[tiro] == "6")
                {
                    boton(D6, 43);
                }
                else if (MenuPrincipal.columaux[tiro] == "E" && MenuPrincipal.filaaux[tiro] == "6")
                {
                    boton(E6, 44);
                }
                else if (MenuPrincipal.columaux[tiro] == "F" && MenuPrincipal.filaaux[tiro] == "6")
                {
                    boton(F6, 45);
                }
                else if (MenuPrincipal.columaux[tiro] == "G" && MenuPrincipal.filaaux[tiro] == "6")
                {
                    boton(G6, 46);
                }
                else if (MenuPrincipal.columaux[tiro] == "H" && MenuPrincipal.filaaux[tiro] == "6")
                {
                    boton(H6, 47);
                }
                else if (MenuPrincipal.columaux[tiro] == "A" && MenuPrincipal.filaaux[tiro] == "7")
                {
                    boton(A7, 48);
                }
                else if (MenuPrincipal.columaux[tiro] == "B" && MenuPrincipal.filaaux[tiro] == "7")
                {
                    boton(B7, 49);

                }
                else if (MenuPrincipal.columaux[tiro] == "C" && MenuPrincipal.filaaux[tiro] == "7")
                {
                    boton(C7, 50);
                }
                else if (MenuPrincipal.columaux[tiro] == "D" && MenuPrincipal.filaaux[tiro] == "7")
                {
                    boton(D7, 51);
                }
                else if (MenuPrincipal.columaux[tiro] == "E" && MenuPrincipal.filaaux[tiro] == "7")
                {
                    boton(E7, 52);
                }
                else if (MenuPrincipal.columaux[tiro] == "F" && MenuPrincipal.filaaux[tiro] == "7")
                {
                    boton(F7, 53);
                }
                else if (MenuPrincipal.columaux[tiro] == "G" && MenuPrincipal.filaaux[tiro] == "7")
                {
                    boton(G7, 54);
                }
                else if (MenuPrincipal.columaux[tiro] == "H" && MenuPrincipal.filaaux[tiro] == "7")
                {
                    boton(H7, 55);
                }
                else if (MenuPrincipal.columaux[tiro] == "A" && MenuPrincipal.filaaux[tiro] == "8")
                {
                    boton(A8, 56);
                }
                else if (MenuPrincipal.columaux[tiro] == "B" && MenuPrincipal.filaaux[tiro] == "8")
                {
                    boton(B8, 57);
                }
                else if (MenuPrincipal.columaux[tiro] == "C" && MenuPrincipal.filaaux[tiro] == "8")
                {
                    boton(C8, 58);
                }
                else if (MenuPrincipal.columaux[tiro] == "D" && MenuPrincipal.filaaux[tiro] == "8")
                {
                    boton(D8, 59);
                }
                else if (MenuPrincipal.columaux[tiro] == "E" && MenuPrincipal.filaaux[tiro] == "8")
                {
                    boton(E8, 60);
                }
                else if (MenuPrincipal.columaux[tiro] == "F" && MenuPrincipal.filaaux[tiro] == "8")
                {
                    boton(F8, 61);
                }
                else if (MenuPrincipal.columaux[tiro] == "G" && MenuPrincipal.filaaux[tiro] == "8")
                {
                    boton(G8, 62);
                }
                else if (MenuPrincipal.columaux[tiro] == "H" && MenuPrincipal.filaaux[tiro] == "8")
                {
                    boton(H8, 63);
                }
            }
            else
            {
                siguiente();
            }
        }
    }
}