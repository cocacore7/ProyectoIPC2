using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto1IPC2
{
    public partial class SelecX : System.Web.UI.Page
    {
        public static string[] colum = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T" };
        public static string[] fil = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" };
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void aceptar_Click(object sender, EventArgs e)
        {
            bool bandera = true;
            int primero = 0, segundo = 0;
            for (int i = 0; i < Colores1.Items.Count; i++) {
                if (Colores1.Items[i].Selected == true) {
                    primero++;
                }
                if (Colores2.Items[i].Selected == true)
                {
                    segundo++;
                }
            }

            if (primero > 0 && primero < 6 && segundo > 0 && segundo < 6) //CANTIDAD DE COLORES ACEPTADOS
            { 
                TableroX.color1 = new List<string>();
                TableroX.color2 = new List<string>();
                for (int i = 0; i < Colores1.Items.Count; i++)
                {
                    if (Colores1.Items[i].Selected == true)
                    {
                        TableroX.color1.Add(Colores1.Items[i].Value.ToString());
                    }
                }
                for (int i = 0; i < Colores2.Items.Count; i++)
                {
                    if (Colores2.Items[i].Selected == true)
                    {
                        TableroX.color2.Add(Colores2.Items[i].Value.ToString());
                    }
                }
                for (int i = 0; i < TableroX.color1.Count; i++)
                {
                    for (int z = 0; z < TableroX.color2.Count; z++)
                    {
                        if (Convert.ToString(TableroX.color1[i]).Equals(Convert.ToString(TableroX.color2[z]))) { bandera = false; }
                    }
                }
                if (bandera) //COLORES SIN REPETIR
                {
                    TableroX.j1 = ""; TableroX.j2 = ""; TableroX.ini1 = false; TableroX.ini2 = false; TableroX.inicial = false;
                    TableroX.j1c1 = ""; TableroX.j1c2 = ""; TableroX.j1c3 = ""; TableroX.j1c4 = ""; TableroX.j1c5 = "";
                    TableroX.j2c1 = ""; TableroX.j2c2 = ""; TableroX.j2c3 = ""; TableroX.j2c4 = ""; TableroX.j2c5 = "";
                    for (int i = 0; i < TableroX.color1.Count; i++)
                    {
                        if (TableroX.j1c1.Equals(""))
                        {
                            TableroX.j1c1 = Convert.ToString(TableroX.color1[i]);
                        }
                        else if (TableroX.j1c2.Equals(""))
                        {
                            TableroX.j1c2 = Convert.ToString(TableroX.color1[i]);
                        }
                        else if (TableroX.j1c3.Equals(""))
                        {
                            TableroX.j1c3 = Convert.ToString(TableroX.color1[i]);
                        }
                        else if (TableroX.j1c4.Equals(""))
                        {
                            TableroX.j1c4 = Convert.ToString(TableroX.color1[i]);
                        }
                        else if (TableroX.j1c5.Equals(""))
                        {
                            TableroX.j1c5 = Convert.ToString(TableroX.color1[i]);
                        }
                    }
                    for (int i = 0; i < TableroX.color2.Count; i++)
                    {
                        if (TableroX.j2c1.Equals(""))
                        {
                            TableroX.j2c1 = Convert.ToString(TableroX.color2[i]);
                        }
                        else if (TableroX.j2c2.Equals(""))
                        {
                            TableroX.j2c2 = Convert.ToString(TableroX.color2[i]);
                        }
                        else if (TableroX.j2c3.Equals(""))
                        {
                            TableroX.j2c3 = Convert.ToString(TableroX.color2[i]);
                        }
                        else if (TableroX.j2c4.Equals(""))
                        {
                            TableroX.j2c4 = Convert.ToString(TableroX.color2[i]);
                        }
                        else if (TableroX.j2c5.Equals(""))
                        {
                            TableroX.j2c5 = Convert.ToString(TableroX.color2[i]);
                        }
                    }
                    if (!TextBox1.Text.Equals("") && !TextBox2.Text.Equals("")) // FILAS Y COLUMNAS NO VACIAS
                    {
                        TableroX.filas = Convert.ToInt16(TextBox1.Text); TableroX.columnas = Convert.ToInt16(TextBox2.Text);
                        if (TableroX.filas > 5 && TableroX.filas <= 20 && TableroX.columnas > 5 && TableroX.columnas <= 20 && TableroX.filas % 2 == 0 && TableroX.columnas % 2 == 0) //Cantidad de Filas y Columas Aceptada
                        {
                            TableroX.numeros = new List<string>(); TableroX.letras = new List<string>();
                            for (int i = 0; i < TableroX.filas; i++) {
                                TableroX.numeros.Add(fil[i]);
                            }
                            for (int i = 0; i < TableroX.columnas; i++)
                            {
                                TableroX.letras.Add(colum[i]);
                            }
                            string mod = modo.SelectedItem.ToString();
                            string tip = tipo.SelectedItem.ToString();
                            string per = Personalizar.SelectedItem.ToString();
                            if (per.Equals("Personalizar Entrada") || mod.Equals("Seleccionar Modo De Juego") || tip.Equals("Seleccionar Tipo De Juego"))
                            {
                                Cuerpo.Text = "Por favor, Seleccione un Personalizacion, Modo y Tipo de juego disponible";
                                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ventana,", "$('#ventana').modal();", true);
                                panelModal.Update();
                            }
                            else
                            {
                                TableroX.botones = new List<ImageButton>(); TableroX.posicion = 0;
                                int filaux = 0, columaux = 0, posinicial = 0;
                                filaux = TableroX.filas / 2; columaux = TableroX.columnas / 2;
                                posinicial = (filaux * TableroX.columnas) - columaux - 1;
                                TableroX.tipo = tip;
                                TableroX.modo = mod;
                                TableroX.turno = true;
                                TableroX.inicial = true;
                                if (per.Equals("Si"))
                                {
                                    TableroX.per = "Si";
                                    TableroX.entrada = false;
                                    for (int i = 0; i < (TableroX.filas * TableroX.columnas); i++)
                                    {
                                        if (i == posinicial)
                                        {
                                            ImageButton boton = new ImageButton();
                                            boton.Width = 40;
                                            boton.Height = 40;
                                            boton.ID = Convert.ToString(TableroX.posicion);
                                            TableroX.posicion++;
                                            boton.ImageUrl = "pivote.png";
                                            boton.Enabled = true;
                                            TableroX.botones.Add(boton);
                                        }
                                        else if (i == posinicial + 1)
                                        {
                                            ImageButton boton = new ImageButton();
                                            boton.Width = 40;
                                            boton.Height = 40;
                                            boton.ID = Convert.ToString(TableroX.posicion);
                                            TableroX.posicion++;
                                            boton.ImageUrl = "pivote.png";
                                            boton.Enabled = true;
                                            TableroX.botones.Add(boton);
                                        }
                                        else if (i == posinicial + TableroX.columnas)
                                        {
                                            ImageButton boton = new ImageButton();
                                            boton.Width = 40;
                                            boton.Height = 40;
                                            boton.ID = Convert.ToString(TableroX.posicion);
                                            TableroX.posicion++;
                                            boton.ImageUrl = "pivote.png";
                                            boton.Enabled = true;
                                            TableroX.botones.Add(boton);
                                        }
                                        else if (i == posinicial + TableroX.columnas + 1)
                                        {
                                            ImageButton boton = new ImageButton();
                                            boton.Width = 40;
                                            boton.Height = 40;
                                            boton.ID = Convert.ToString(TableroX.posicion);
                                            TableroX.posicion++;
                                            boton.ImageUrl = "pivote.png";
                                            boton.Enabled = true;
                                            TableroX.botones.Add(boton);
                                        }
                                        else
                                        {
                                            ImageButton boton = new ImageButton();
                                            boton.Width = 40;
                                            boton.Height = 40;
                                            boton.ID = Convert.ToString(TableroX.posicion);
                                            TableroX.posicion++;
                                            boton.ImageUrl = "vacio.png";
                                            boton.Enabled = false;
                                            TableroX.botones.Add(boton);
                                        }
                                    }
                                    TableroX.actual = TableroX.j1c1;
                                    Response.Redirect("TableroX.aspx");
                                }
                                else
                                {
                                    TableroX.per = ".";
                                    TableroX.entrada = true;
                                    for (int i = 0; i < (TableroX.filas * TableroX.columnas); i++)
                                    {
                                        if (i == posinicial)
                                        {
                                            ImageButton boton = new ImageButton();
                                            boton.Width = 40;
                                            boton.Height = 40;
                                            boton.ID = Convert.ToString(TableroX.posicion);
                                            TableroX.posicion++;
                                            boton.ImageUrl = TableroX.j1c1 + ".png";
                                            boton.Enabled = false;
                                            TableroX.botones.Add(boton);
                                        }
                                        else if (i == posinicial + 1)
                                        {
                                            ImageButton boton = new ImageButton();
                                            boton.Width = 40;
                                            boton.Height = 40;
                                            boton.ID = Convert.ToString(TableroX.posicion);
                                            TableroX.posicion++;
                                            boton.ImageUrl = TableroX.j2c1 + ".png";
                                            boton.Enabled = false;
                                            TableroX.botones.Add(boton);
                                        }
                                        else if (i == posinicial + TableroX.columnas)
                                        {
                                            ImageButton boton = new ImageButton();
                                            boton.Width = 40;
                                            boton.Height = 40;
                                            boton.ID = Convert.ToString(TableroX.posicion);
                                            TableroX.posicion++;
                                            if (TableroX.j2c2.Equals("")) { boton.ImageUrl = TableroX.j2c1 + ".png"; }
                                            else { boton.ImageUrl = TableroX.j2c2 + ".png"; }
                                            boton.Enabled = false;
                                            TableroX.botones.Add(boton);
                                        }
                                        else if (i == posinicial + TableroX.columnas + 1)
                                        {
                                            ImageButton boton = new ImageButton();
                                            boton.Width = 40;
                                            boton.Height = 40;
                                            boton.ID = Convert.ToString(TableroX.posicion);
                                            TableroX.posicion++;
                                            if (TableroX.j1c2.Equals("")) { boton.ImageUrl = TableroX.j1c1 + ".png"; }
                                            else { boton.ImageUrl = TableroX.j1c2 + ".png"; }
                                            boton.Enabled = false;
                                            TableroX.botones.Add(boton);
                                        }
                                        else
                                        {
                                            ImageButton boton = new ImageButton();
                                            boton.Width = 40;
                                            boton.Height = 40;
                                            boton.ID = Convert.ToString(TableroX.posicion);
                                            TableroX.posicion++;
                                            boton.ImageUrl = "vacio.png";
                                            boton.Enabled = false;
                                            TableroX.botones.Add(boton);
                                        }
                                    }
                                    TableroX.ini1 = true;
                                    TableroX.ini2 = true;
                                    if (TableroX.j1c3.Equals(""))
                                    {
                                        TableroX.j1 = TableroX.j1c1;
                                        TableroX.actual = TableroX.j1c1;
                                    }
                                    else
                                    {
                                        TableroX.j1 = TableroX.j1c3;
                                        TableroX.j2 = TableroX.j2c2;
                                        TableroX.actual = TableroX.j1c3;
                                        
                                    }
                                    Response.Redirect("TableroX.aspx");
                                }
                            }
                        }
                        else
                        {
                            Cuerpo.Text = "Por Favor, Ingrese Valores De Filas Y Columas Entre 6 y 20, Y Solo Numeros Pares";
                            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ventana,", "$('#ventana').modal();", true);
                            panelModal.Update();
                        }
                    }
                    else {
                        Cuerpo.Text = "Por Favor, Ingrese Valores De Filas Y Columas Entre 1 y 20";
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ventana,", "$('#ventana').modal();", true);
                        panelModal.Update();
                    }
                }
                else
                {
                    Cuerpo.Text = "Por favor, Seleccione Colores Distintos Para Los Jugadores";
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ventana,", "$('#ventana').modal();", true);
                    panelModal.Update();
                }
            }
            else {
                Cuerpo.Text = "Por favor, Seleccione entre 1 y 5 colores por jugador";
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ventana,", "$('#ventana').modal();", true);
                panelModal.Update();
            }
        }

        protected void regresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuPrincipal.aspx");
        }
    }
}