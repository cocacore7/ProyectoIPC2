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
            bool bandera = true, vacio1 = true, vacio2 = true;
            int contador = 0;

            for (int i = 0; i < Colores1.Items.Count; i++)
            {
                if (Colores1.Items[i].Selected == true)
                {
                    contador++;
                }
            }
            string[] col1 = new string[contador];
            if (contador != 0 && contador <= 5)
            {
                vacio1 = false;
                contador = 0;
                for (int i = 0; i < Colores1.Items.Count; i++)
                {
                    if (Colores1.Items[i].Selected == true)
                    {
                        col1[contador] = Colores1.Items[i].Value.ToString();
                        contador++;
                    }
                }
            }
            contador = 0;
            for (int i = 0; i < Colores2.Items.Count; i++)
            {
                if (Colores2.Items[i].Selected == true)
                {
                    contador++;
                }
            }
            string[] col2 = new string[contador];
            if (contador != 0 && contador <= 5)
            {
                vacio2 = false;
                contador = 0;
                for (int i = 0; i < Colores2.Items.Count; i++)
                {
                    if (Colores2.Items[i].Selected == true)
                    {
                        col2[contador] = Colores2.Items[i].Value.ToString();
                        contador++;
                    }
                }
            }
            contador = 0;

            if (!vacio1 && !vacio2) {
                foreach (string colores1 in col1)
                {
                    foreach (string colores2 in col2)
                    {
                        if (colores1.Equals(colores2)) { bandera = false; }
                    }
                }
                if (bandera)
                {
                    foreach (string colores1 in col1)
                    {
                        TableroX.color1.Add(colores1);
                    }
                    foreach (string colores2 in col2)
                    {
                        TableroX.color2.Add(colores2);
                    }
                    if (!TextBox1.Text.Equals("") && !TextBox2.Text.Equals(""))
                    {
                        int filas = Convert.ToInt16(TextBox1.Text);
                        int columnas = Convert.ToInt16(TextBox2.Text);
                        if (filas > 5 && filas <= 20 && columnas > 5 && columnas <= 20)
                        {
                            for (int i = 0; i <= filas; i++) {
                                TableroX.numeros.Add(fil[i]);
                            }
                            for (int i = 0; i <= columnas; i++)
                            {
                                TableroX.numeros.Add(colum[i]);
                            }
                            string per = Personalizar.SelectedItem.ToString();
                            string mod = modo.SelectedItem.ToString();
                            string tip = tipo.SelectedItem.ToString();
                            if (per.Equals("Personalizar Entrada") || mod.Equals("Seleccionar Modo De Juego") || tip.Equals("Seleccionar Tipo De Juego"))
                            {
                                Cuerpo.Text = "Por favor, Seleccione un Personalizacion, Modo y Tipo de juego disponible";
                                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ventana,", "$('#ventana').modal();", true);
                                panelModal.Update();
                            }
                            else
                            {
                                if (per.Equals("Si"))
                                {
                                    TableroX.tipo = tip;
                                    TableroX.partida = mod;
                                    TableroX.carga = 0;
                                    Response.Redirect("TableroX.aspx");
                                }
                                else
                                {
                                    TableroX.tipo = tip;
                                    TableroX.partida = mod;
                                    TableroX.carga = 0;
                                    Response.Redirect("TableroX.aspx");
                                }
                            }
                        }
                        else
                        {
                            Cuerpo.Text = "Por Favor, Ingrese Valores De Filas Y Columas Entre 6 y 20";
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