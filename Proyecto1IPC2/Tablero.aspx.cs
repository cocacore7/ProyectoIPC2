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
        public static int mov = 1;


        protected void Page_Load(object sender, EventArgs e)
        {
        }


        protected void A1_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                A1.ImageUrl = "negro.png";
                A1.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[0] = "negro";
                MenuPrincipal.colum[0] = "A";
                MenuPrincipal.fila[0] = "1";
            }
            else if(color == "blanco")
            {
                A1.ImageUrl = "blanco.png";
                A1.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[0] = "blanco";
                MenuPrincipal.colum[0] = "A";
                MenuPrincipal.fila[0] = "1";
            }
        }

        protected void B1_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                B1.ImageUrl = "negro.png";
                B1.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[1] = "negro";
                MenuPrincipal.colum[1] = "B";
                MenuPrincipal.fila[1] = "1";
            }
            else
            {
                B1.ImageUrl = "blanco.png";
                B1.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[1] = "blanco";
                MenuPrincipal.colum[1] = "B";
                MenuPrincipal.fila[1] = "1";
            }
        }

        protected void C1_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                C1.ImageUrl = "negro.png";
                C1.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[2] = "negro";
                MenuPrincipal.colum[2] = "C";
                MenuPrincipal.fila[2] = "1";
            }
            else
            {
                C1.ImageUrl = "blanco.png";
                C1.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[2] = "blanco";
                MenuPrincipal.colum[2] = "C";
                MenuPrincipal.fila[2] = "1";
            }
        }

        protected void D1_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                D1.ImageUrl = "negro.png";
                D1.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[3] = "negro";
                MenuPrincipal.colum[3] = "D";
                MenuPrincipal.fila[3] = "1";
            }
            else
            {
                D1.ImageUrl = "blanco.png";
                D1.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[3] = "blanco";
                MenuPrincipal.colum[3] = "D";
                MenuPrincipal.fila[3] = "1";
            }
        }

        protected void E1_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                E1.ImageUrl = "negro.png";
                E1.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[4] = "negro";
                MenuPrincipal.colum[4] = "E";
                MenuPrincipal.fila[4] = "1";
            }
            else
            {
                E1.ImageUrl = "blanco.png";
                E1.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[4] = "blanco";
                MenuPrincipal.colum[4] = "E";
                MenuPrincipal.fila[4] = "1";
            }
        }

        protected void F1_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                F1.ImageUrl = "negro.png";
                F1.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[5] = "negro";
                MenuPrincipal.colum[5] = "F";
                MenuPrincipal.fila[5] = "1";
            }
            else
            {
                F1.ImageUrl = "blanco.png";
                F1.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[5] = "blanco";
                MenuPrincipal.colum[5] = "F";
                MenuPrincipal.fila[5] = "1";
            }
        }

        protected void G1_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                G1.ImageUrl = "negro.png";
                G1.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[6] = "negro";
                MenuPrincipal.colum[6] = "G";
                MenuPrincipal.fila[6] = "1";
            }
            else
            {
                G1.ImageUrl = "blanco.png";
                G1.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[6] = "blanco";
                MenuPrincipal.colum[6] = "G";
                MenuPrincipal.fila[6] = "1";
            }
        }

        protected void H1_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                H1.ImageUrl = "negro.png";
                H1.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[7] = "negro";
                MenuPrincipal.colum[7] = "H";
                MenuPrincipal.fila[7] = "1";
            }
            else
            {
                H1.ImageUrl = "blanco.png";
                H1.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[7] = "blanco";
                MenuPrincipal.colum[7] = "H";
                MenuPrincipal.fila[7] = "1";
            }
        }

        protected void A2_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                A2.ImageUrl = "negro.png";
                A2.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[8] = "negro";
                MenuPrincipal.colum[8] = "A";
                MenuPrincipal.fila[8] = "2";
            }
            else
            {
                A2.ImageUrl = "blanco.png";
                A2.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[8] = "blanco";
                MenuPrincipal.colum[8] = "A";
                MenuPrincipal.fila[8] = "2";
            }
        }

        protected void B2_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                B2.ImageUrl = "negro.png";
                B2.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[9] = "negro";
                MenuPrincipal.colum[9] = "B";
                MenuPrincipal.fila[9] = "2";
            }
            else
            {
                B2.ImageUrl = "blanco.png";
                B2.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[9] = "blanco";
                MenuPrincipal.colum[9] = "B";
                MenuPrincipal.fila[9] = "2";
            }
        }

        protected void C2_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                C2.ImageUrl = "negro.png";
                C2.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[10] = "negro";
                MenuPrincipal.colum[10] = "C";
                MenuPrincipal.fila[10] = "2";
            }
            else
            {
                C2.ImageUrl = "blanco.png";
                C2.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[10] = "blanco";
                MenuPrincipal.colum[10] = "C";
                MenuPrincipal.fila[10] = "2";
            }
        }

        protected void D2_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                D2.ImageUrl = "negro.png";
                D2.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[11] = "negro";
                MenuPrincipal.colum[11] = "D";
                MenuPrincipal.fila[11] = "2";
            }
            else
            {
                D2.ImageUrl = "blanco.png";
                D2.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[11] = "blanco";
                MenuPrincipal.colum[11] = "D";
                MenuPrincipal.fila[11] = "2";
            }
        }

        protected void E2_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                E2.ImageUrl = "negro.png";
                E2.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[12] = "negro";
                MenuPrincipal.colum[12] = "E";
                MenuPrincipal.fila[12] = "2";
            }
            else
            {
                E2.ImageUrl = "blanco.png";
                E2.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[12] = "blanco";
                MenuPrincipal.colum[12] = "E";
                MenuPrincipal.fila[12] = "2";
            }
        }

        protected void F2_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                F2.ImageUrl = "negro.png";
                F2.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[13] = "negro";
                MenuPrincipal.colum[13] = "F";
                MenuPrincipal.fila[13] = "2";
            }
            else
            {
                F2.ImageUrl = "blanco.png";
                F2.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[13] = "blanco";
                MenuPrincipal.colum[13] = "F";
                MenuPrincipal.fila[13] = "2";
            }
        }

        protected void G2_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                G2.ImageUrl = "negro.png";
                G2.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[14] = "negro";
                MenuPrincipal.colum[14] = "G";
                MenuPrincipal.fila[14] = "2";
            }
            else
            {
                G2.ImageUrl = "blanco.png";
                G2.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[14] = "blanco";
                MenuPrincipal.colum[14] = "G";
                MenuPrincipal.fila[14] = "2";
            }
        }

        protected void H2_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                H2.ImageUrl = "negro.png";
                H2.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[15] = "negro";
                MenuPrincipal.colum[15] = "H";
                MenuPrincipal.fila[15] = "2";
            }
            else
            {
                H2.ImageUrl = "blanco.png";
                H2.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[15] = "blanco";
                MenuPrincipal.colum[15] = "H";
                MenuPrincipal.fila[15] = "2";
            }
        }

        protected void A3_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                A3.ImageUrl = "negro.png";
                A3.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[16] = "negro";
                MenuPrincipal.colum[16] = "A";
                MenuPrincipal.fila[16] = "3";
            }
            else
            {
                A3.ImageUrl = "blanco.png";
                A3.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[16] = "blanco";
                MenuPrincipal.colum[16] = "A";
                MenuPrincipal.fila[16] = "3";
            }
        }

        protected void B3_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                B3.ImageUrl = "negro.png";
                B3.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[17] = "negro";
                MenuPrincipal.colum[17] = "B";
                MenuPrincipal.fila[17] = "3";
            }
            else
            {
                B3.ImageUrl = "blanco.png";
                B3.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[17] = "blanco";
                MenuPrincipal.colum[17] = "B";
                MenuPrincipal.fila[17] = "3";
            }
        }

        protected void C3_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                C3.ImageUrl = "negro.png";
                C3.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[18] = "negro";
                MenuPrincipal.colum[18] = "C";
                MenuPrincipal.fila[18] = "3";
            }
            else
            {
                C3.ImageUrl = "blanco.png";
                C3.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[18] = "blanco";
                MenuPrincipal.colum[18] = "C";
                MenuPrincipal.fila[18] = "3";
            }
        }

        protected void D3_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                D3.ImageUrl = "negro.png";
                D3.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[19] = "negro";
                MenuPrincipal.colum[19] = "D";
                MenuPrincipal.fila[19] = "3";
            }
            else
            {
                D3.ImageUrl = "blanco.png";
                D3.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[19] = "blanco";
                MenuPrincipal.colum[19] = "D";
                MenuPrincipal.fila[19] = "3";
            }
        }

        protected void E3_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                E3.ImageUrl = "negro.png";
                E3.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[20] = "negro";
                MenuPrincipal.colum[20] = "E";
                MenuPrincipal.fila[20] = "3";
            }
            else
            {
                E3.ImageUrl = "blanco.png";
                E3.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[20] = "blanco";
                MenuPrincipal.colum[20] = "E";
                MenuPrincipal.fila[20] = "3";
            }
        }

        protected void F3_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                F3.ImageUrl = "negro.png";
                F3.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[21] = "negro";
                MenuPrincipal.colum[21] = "F";
                MenuPrincipal.fila[21] = "3";
            }
            else
            {
                F3.ImageUrl = "blanco.png";
                F3.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[21] = "blanco";
                MenuPrincipal.colum[21] = "F";
                MenuPrincipal.fila[21] = "3";
            }
        }

        protected void G3_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                G3.ImageUrl = "negro.png";
                G3.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[22] = "negro";
                MenuPrincipal.colum[22] = "G";
                MenuPrincipal.fila[22] = "3";
            }
            else
            {
                G3.ImageUrl = "blanco.png";
                G3.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[22] = "blanco";
                MenuPrincipal.colum[22] = "G";
                MenuPrincipal.fila[22] = "3";
            }
        }

        protected void H3_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                H3.ImageUrl = "negro.png";
                H3.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[23] = "negro";
                MenuPrincipal.colum[23] = "H";
                MenuPrincipal.fila[23] = "3";
            }
            else
            {
                H3.ImageUrl = "blanco.png";
                H3.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[23] = "blanco";
                MenuPrincipal.colum[23] = "H";
                MenuPrincipal.fila[23] = "3";
            }
        }

        protected void A4_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                A4.ImageUrl = "negro.png";
                A4.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[24] = "negro";
                MenuPrincipal.colum[24] = "A";
                MenuPrincipal.fila[24] = "4";
            }
            else
            {
                A4.ImageUrl = "blanco.png";
                A4.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[24] = "blanco";
                MenuPrincipal.colum[24] = "A";
                MenuPrincipal.fila[24] = "4";
            }
        }

        protected void B4_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                B4.ImageUrl = "negro.png";
                B4.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[25] = "negro";
                MenuPrincipal.colum[25] = "B";
                MenuPrincipal.fila[25] = "4";
            }
            else
            {
                B4.ImageUrl = "blanco.png";
                B4.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[25] = "blanco";
                MenuPrincipal.colum[25] = "B";
                MenuPrincipal.fila[25] = "4";
            }
        }

        protected void C4_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                C4.ImageUrl = "negro.png";
                C4.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[26] = "negro";
                MenuPrincipal.colum[26] = "C";
                MenuPrincipal.fila[26] = "4";
            }
            else
            {
                C4.ImageUrl = "blanco.png";
                C4.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[26] = "blanco";
                MenuPrincipal.colum[26] = "C";
                MenuPrincipal.fila[26] = "4";
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
                color = "blanco";
                mov++;
                MenuPrincipal.colores[29] = "negro";
                MenuPrincipal.colum[29] = "F";
                MenuPrincipal.fila[29] = "4";
            }
            else
            {
                F4.ImageUrl = "blanco.png";
                F4.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[29] = "blanco";
                MenuPrincipal.colum[29] = "F";
                MenuPrincipal.fila[29] = "4";
            }
        }

        protected void G4_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                G4.ImageUrl = "negro.png";
                G4.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[30] = "negro";
                MenuPrincipal.colum[30] = "G";
                MenuPrincipal.fila[30] = "4";
            }
            else
            {
                G4.ImageUrl = "blanco.png";
                G4.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[30] = "blanco";
                MenuPrincipal.colum[30] = "G";
                MenuPrincipal.fila[30] = "4";
            }
        }

        protected void H4_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                H4.ImageUrl = "negro.png";
                H4.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[31] = "negro";
                MenuPrincipal.colum[31] = "H";
                MenuPrincipal.fila[31] = "4";
            }
            else
            {
                H4.ImageUrl = "blanco.png";
                H4.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[31] = "blanco";
                MenuPrincipal.colum[31] = "H";
                MenuPrincipal.fila[31] = "4";
            }
        }

        protected void A5_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                A5.ImageUrl = "negro.png";
                A5.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[32] = "negro";
                MenuPrincipal.colum[32] = "A";
                MenuPrincipal.fila[32] = "5";
            }
            else
            {
                A5.ImageUrl = "blanco.png";
                A5.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[32] = "blanco";
                MenuPrincipal.colum[32] = "A";
                MenuPrincipal.fila[32] = "5";
            }
        }

        protected void B5_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                B5.ImageUrl = "negro.png";
                B5.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[33] = "negro";
                MenuPrincipal.colum[33] = "B";
                MenuPrincipal.fila[33] = "5";
            }
            else
            {
                B5.ImageUrl = "blanco.png";
                B5.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[33] = "blanco";
                MenuPrincipal.colum[33] = "B";
                MenuPrincipal.fila[33] = "5";
            }
        }

        protected void C5_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                C5.ImageUrl = "negro.png";
                C5.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[34] = "negro";
                MenuPrincipal.colum[34] = "C";
                MenuPrincipal.fila[34] = "5";
            }
            else
            {
                C5.ImageUrl = "blanco.png";
                C5.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[34] = "blanco";
                MenuPrincipal.colum[34] = "C";
                MenuPrincipal.fila[34] = "5";
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
                color = "blanco";
                mov++;
                MenuPrincipal.colores[37] = "negro";
                MenuPrincipal.colum[37] = "F";
                MenuPrincipal.fila[37] = "5";
            }
            else
            {
                F5.ImageUrl = "blanco.png";
                F5.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[37] = "blanco";
                MenuPrincipal.colum[37] = "F";
                MenuPrincipal.fila[37] = "5";
            }
        }

        protected void G5_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                G5.ImageUrl = "negro.png";
                G5.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[38] = "negro";
                MenuPrincipal.colum[38] = "G";
                MenuPrincipal.fila[38] = "5";
            }
            else
            {
                G5.ImageUrl = "blanco.png";
                G5.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[38] = "blanco";
                MenuPrincipal.colum[38] = "G";
                MenuPrincipal.fila[38] = "5";
            }
        }

        protected void H5_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                H5.ImageUrl = "negro.png";
                H5.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[39] = "negro";
                MenuPrincipal.colum[39] = "H";
                MenuPrincipal.fila[39] = "5";
            }
            else
            {
                H5.ImageUrl = "blanco.png";
                H5.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[39] = "blanco";
                MenuPrincipal.colum[39] = "H";
                MenuPrincipal.fila[39] = "5";
            }
        }

        protected void A6_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                A6.ImageUrl = "negro.png";
                A6.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[40] = "negro";
                MenuPrincipal.colum[40] = "A";
                MenuPrincipal.fila[40] = "6";
            }
            else
            {
                A6.ImageUrl = "blanco.png";
                A6.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[40] = "blanco";
                MenuPrincipal.colum[40] = "A";
                MenuPrincipal.fila[40] = "6";
            }
        }

        protected void B6_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                B6.ImageUrl = "negro.png";
                B6.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[41] = "negro";
                MenuPrincipal.colum[41] = "B";
                MenuPrincipal.fila[41] = "6";
            }
            else
            {
                B6.ImageUrl = "blanco.png";
                B6.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[41] = "blanco";
                MenuPrincipal.colum[41] = "B";
                MenuPrincipal.fila[41] = "6";
            }
        }

        protected void C6_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                C6.ImageUrl = "negro.png";
                C6.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[42] = "negro";
                MenuPrincipal.colum[42] = "C";
                MenuPrincipal.fila[42] = "6";
            }
            else
            {
                C6.ImageUrl = "blanco.png";
                C6.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[42] = "blanco";
                MenuPrincipal.colum[42] = "C";
                MenuPrincipal.fila[42] = "6";
            }
        }

        protected void D6_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                D6.ImageUrl = "negro.png";
                D6.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[43] = "negro";
                MenuPrincipal.colum[43] = "D";
                MenuPrincipal.fila[43] = "6";
            }
            else
            {
                D6.ImageUrl = "blanco.png";
                D6.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[43] = "blanco";
                MenuPrincipal.colum[43] = "D";
                MenuPrincipal.fila[43] = "6";
            }
        }

        protected void E6_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                E6.ImageUrl = "negro.png";
                E6.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[44] = "negro";
                MenuPrincipal.colum[44] = "E";
                MenuPrincipal.fila[44] = "6";
            }
            else
            {
                E6.ImageUrl = "blanco.png";
                E6.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[44] = "blanco";
                MenuPrincipal.colum[44] = "E";
                MenuPrincipal.fila[44] = "6";
            }
        }

        protected void F6_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                F6.ImageUrl = "negro.png";
                F6.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[45] = "negro";
                MenuPrincipal.colum[45] = "F";
                MenuPrincipal.fila[45] = "6";
            }
            else
            {
                F6.ImageUrl = "blanco.png";
                F6.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[45] = "blanco";
                MenuPrincipal.colum[45] = "F";
                MenuPrincipal.fila[45] = "6";
            }
        }

        protected void G6_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                G6.ImageUrl = "negro.png";
                G6.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[46] = "negro";
                MenuPrincipal.colum[46] = "G";
                MenuPrincipal.fila[46] = "6";
            }
            else
            {
                G6.ImageUrl = "blanco.png";
                G6.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[46] = "blanco";
                MenuPrincipal.colum[46] = "G";
                MenuPrincipal.fila[46] = "6";
            }
        }

        protected void H6_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                H6.ImageUrl = "negro.png";
                H6.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[47] = "negro";
                MenuPrincipal.colum[47] = "H";
                MenuPrincipal.fila[47] = "6";
            }
            else
            {
                H6.ImageUrl = "blanco.png";
                H6.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[47] = "blanco";
                MenuPrincipal.colum[47] = "H";
                MenuPrincipal.fila[47] = "6";
            }
        }

        protected void A7_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                A7.ImageUrl = "negro.png";
                A7.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[48] = "negro";
                MenuPrincipal.colum[48] = "A";
                MenuPrincipal.fila[48] = "7";
            }
            else
            {
                A7.ImageUrl = "blanco.png";
                A7.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[48] = "blanco";
                MenuPrincipal.colum[48] = "A";
                MenuPrincipal.fila[48] = "7";
            }
        }

        protected void B7_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                B7.ImageUrl = "negro.png";
                B7.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[49] = "negro";
                MenuPrincipal.colum[49] = "B";
                MenuPrincipal.fila[49] = "7";
            }
            else
            {
                B7.ImageUrl = "blanco.png";
                B7.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[49] = "blanco";
                MenuPrincipal.colum[49] = "B";
                MenuPrincipal.fila[49] = "7";
            }
        }

        protected void C7_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                C7.ImageUrl = "negro.png";
                C7.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[50] = "negro";
                MenuPrincipal.colum[50] = "C";
                MenuPrincipal.fila[50] = "7";
            }
            else
            {
                C7.ImageUrl = "blanco.png";
                C7.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[50] = "blanco";
                MenuPrincipal.colum[50] = "C";
                MenuPrincipal.fila[50] = "7";
            }
        }

        protected void D7_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                D7.ImageUrl = "negro.png";
                D7.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[51] = "negro";
                MenuPrincipal.colum[51] = "D";
                MenuPrincipal.fila[51] = "7";
            }
            else
            {
                D7.ImageUrl = "blanco.png";
                D7.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[51] = "blanco";
                MenuPrincipal.colum[51] = "D";
                MenuPrincipal.fila[51] = "7";
            }
        }

        protected void E7_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                E7.ImageUrl = "negro.png";
                E7.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[52] = "negro";
                MenuPrincipal.colum[52] = "E";
                MenuPrincipal.fila[52] = "7";
            }
            else
            {
                E7.ImageUrl = "blanco.png";
                E7.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[52] = "blanco";
                MenuPrincipal.colum[52] = "E";
                MenuPrincipal.fila[52] = "7";
            }
        }

        protected void F7_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                F7.ImageUrl = "negro.png";
                F7.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[53] = "negro";
                MenuPrincipal.colum[53] = "F";
                MenuPrincipal.fila[53] = "7";
            }
            else
            {
                F7.ImageUrl = "blanco.png";
                F7.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[53] = "blanco";
                MenuPrincipal.colum[53] = "F";
                MenuPrincipal.fila[53] = "7";
            }
        }

        protected void G7_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                G7.ImageUrl = "negro.png";
                G7.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[54] = "negro";
                MenuPrincipal.colum[54] = "G";
                MenuPrincipal.fila[54] = "7";
            }
            else
            {
                G7.ImageUrl = "blanco.png";
                G7.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[54] = "blanco";
                MenuPrincipal.colum[54] = "G";
                MenuPrincipal.fila[54] = "7";
            }
        }

        protected void H7_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                H7.ImageUrl = "negro.png";
                H7.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[55] = "negro";
                MenuPrincipal.colum[55] = "H";
                MenuPrincipal.fila[55] = "7";
            }
            else
            {
                H7.ImageUrl = "blanco.png";
                H7.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[55] = "blanco";
                MenuPrincipal.colum[55] = "H";
                MenuPrincipal.fila[55] = "7";
            }
        }

        protected void A8_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                A8.ImageUrl = "negro.png";
                A8.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[56] = "negro";
                MenuPrincipal.colum[56] = "A";
                MenuPrincipal.fila[56] = "8";
            }
            else
            {
                A8.ImageUrl = "blanco.png";
                A8.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[56] = "blanco";
                MenuPrincipal.colum[56] = "A";
                MenuPrincipal.fila[56] = "8";
            }
        }

        protected void B8_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                B8.ImageUrl = "negro.png";
                B8.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[57] = "negro";
                MenuPrincipal.colum[57] = "B";
                MenuPrincipal.fila[57] = "8";
            }
            else
            {
                B8.ImageUrl = "blanco.png";
                B8.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[57] = "blanco";
                MenuPrincipal.colum[57] = "B";
                MenuPrincipal.fila[57] = "8";
            }
        }

        protected void C8_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                C8.ImageUrl = "negro.png";
                C8.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[58] = "negro";
                MenuPrincipal.colum[58] = "C";
                MenuPrincipal.fila[58] = "8";
            }
            else
            {
                C8.ImageUrl = "blanco.png";
                C8.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[58] = "blanco";
                MenuPrincipal.colum[58] = "C";
                MenuPrincipal.fila[58] = "8";
            }
        }

        protected void D8_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                D8.ImageUrl = "negro.png";
                D8.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[59] = "negro";
                MenuPrincipal.colum[59] = "D";
                MenuPrincipal.fila[59] = "8";
            }
            else
            {
                D8.ImageUrl = "blanco.png";
                D8.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[59] = "blanco";
                MenuPrincipal.colum[59] = "D";
                MenuPrincipal.fila[59] = "8";
            }
        }
        
        protected void E8_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                E8.ImageUrl = "negro.png";
                E8.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[60] = "negro";
                MenuPrincipal.colum[60] = "E";
                MenuPrincipal.fila[60] = "8";
            }
            else
            {
                E8.ImageUrl = "blanco.png";
                E8.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[60] = "blanco";
                MenuPrincipal.colum[60] = "E";
                MenuPrincipal.fila[60] = "8";
            }
        }

        protected void F8_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                F8.ImageUrl = "negro.png";
                F8.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[61] = "negro";
                MenuPrincipal.colum[61] = "F";
                MenuPrincipal.fila[61] = "8";
            }
            else
            {
                F8.ImageUrl = "blanco.png";
                F8.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[61] = "blanco";
                MenuPrincipal.colum[61] = "F";
                MenuPrincipal.fila[61] = "8";
            }
        }

        protected void G8_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                G8.ImageUrl = "negro.png";
                G8.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[62] = "negro";
                MenuPrincipal.colum[62] = "G";
                MenuPrincipal.fila[62] = "8";
            }
            else
            {
                G8.ImageUrl = "blanco.png";
                G8.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[62] = "blanco";
                MenuPrincipal.colum[62] = "G";
                MenuPrincipal.fila[62] = "8";
            }
        }

        protected void H8_Click(object sender, ImageClickEventArgs e)
        {
            if (color == "negro")
            {
                H8.ImageUrl = "negro.png";
                H8.Enabled = false;
                color = "blanco";
                mov++;
                MenuPrincipal.colores[63] = "negro";
                MenuPrincipal.colum[63] = "H";
                MenuPrincipal.fila[63] = "8";
            }
            else
            {
                H8.ImageUrl = "blanco.png";
                H8.Enabled = false;
                color = "negro";
                mov++;
                MenuPrincipal.colores[63] = "blanco";
                MenuPrincipal.colum[63] = "H";
                MenuPrincipal.fila[63] = "8";
            }
        }
        
        protected void guardar_Click(object sender, EventArgs e)
        {
            XDocument archivo = new XDocument(new XDeclaration("0.1", "utf-8", null));
            XElement raiz = new XElement("tablero");
            raiz.RemoveAll();
            archivo.Add(raiz);
            for (int i=0; i <= 63; i++)
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

            BaseDatos bd = new BaseDatos();
            string datos = "insert into partida(partida_g,tipo_partida,movimientos,pge) values(@partida_g,@tipo_partida,@movimientos,@pge)";
            SqlCommand accion = new SqlCommand(datos, bd.registrar());
            accion.Parameters.AddWithValue("@partida_g", archivo.ToString());
            accion.Parameters.AddWithValue("@tipo_partida", partida);
            accion.Parameters.AddWithValue("@movimientos", mov);
            accion.Parameters.AddWithValue("@pge", gamperem);
            accion.ExecuteNonQuery();
            bd.registrar();
            Response.Redirect("MenuPrincipal.aspx");
        }
    }
}