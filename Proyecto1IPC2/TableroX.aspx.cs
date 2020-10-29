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
    public partial class TableroX : System.Web.UI.Page
    {
        public static string nombre = "", tipo = "", partida = "";
        public static int filas = 0, columnas = 0, segundosN, segundosB, MinutosN, MinutosB, carga, contador = 0;
        public static List<string> color1 = new List<string>(), color2 = new List<string>(), letras = new List<string>(), numeros = new List<string>();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                segundosN = 0;
                segundosB = 0;
                MinutosN = 1;
                MinutosB = 1;
            }
            if (carga == 0) {
                TableRow row;
                TableCell cell;
                ImageButton boton;
                Label texto;
                int filaaux = 0, colaux = 0;
                for (int i = 0; i <= filas; i++)
                {
                    if (colaux == columnas - 1) {colaux = 0;}
                    row = new TableRow();
                    for (int z = 0; z <= columnas; z++)
                    {
                        if (i == 0)
                        {
                            if (z == 0)
                            {
                                cell = new TableCell();
                                row.Cells.Add(cell);
                            }
                            else if (z == columnas)
                            {
                                cell = new TableCell();
                                texto = new Label();
                                texto.Text = letras[colaux];
                                colaux++;
                                texto.Font.Size = 10;
                                cell.Controls.Add(texto);
                                row.Cells.Add(cell);
                            }
                            else {
                                cell = new TableCell();
                                row.Cells.Add(cell);
                            }
                        }
                        else if (i == columnas) {
                            if (z == 0)
                            {
                                cell = new TableCell();
                                row.Cells.Add(cell);
                            }
                            else if (z == columnas)
                            {
                                cell = new TableCell();
                                texto = new Label();
                                texto.Text = letras[colaux];
                                colaux++;
                                texto.Font.Size = 10;
                                cell.Width = 60;
                                cell.Height = 60;
                                cell.Controls.Add(texto);
                                row.Cells.Add(cell);
                            }
                            else
                            {
                                cell = new TableCell();
                                row.Cells.Add(cell);
                            }
                        }
                        else
                        {
                            cell = new TableCell();
                            boton = new ImageButton();
                            boton.ID = contador.ToString();
                            contador++;
                            boton.ImageUrl = "vacio.png";
                            boton.Click += new ImageClickEventHandler(presionar);

                            cell.Controls.Add(boton);
                        }
                    }
                }
                carga = 2;
            }
            
        }
        
        public void presionar(object sender, System.EventArgs e)
        {
            
        }

        //Guardar Partidas
        protected void guardar_Click(object sender, EventArgs e)
        {
            if (carga == 2)
            {
                
            }
            else
            {
                Response.Redirect("MenuPrincipal.aspx");
            }
        }

        //Cronometro Negro
        public void cronoN()
        {
            Timer1.Enabled = true;
            Timer2.Enabled = false;
        }

        //Cronometro Blanco
        public void cronoB()
        {
            Timer1.Enabled = false;
            Timer2.Enabled = true;
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            segundosN++;
            SegN.Text = segundosN.ToString() + " seg";
            if (segundosN == 60)
            {
                segundosN = 0;
                MinN.Text = Convert.ToString(MinutosN++) + " min";
            }
        }

        protected void Timer2_Tick1(object sender, EventArgs e)
        {
            segundosB++;
            SegB.Text = segundosB.ToString() + " seg";
            if (segundosB == 60)
            {
                segundosB = 0;
                MinB.Text = Convert.ToString(MinutosB++) + " min";
            }
        }
    }
}