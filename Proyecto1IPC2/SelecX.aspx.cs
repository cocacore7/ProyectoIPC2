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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void aceptar_Click(object sender, EventArgs e)
        {
            bool bandera = true;
            bool vacio1 = true;
            bool vacio2 = true;
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
                    if (!TextBox1.Text.Equals("") && !TextBox2.Text.Equals(""))
                    {
                        int filas = Convert.ToInt16(TextBox1.Text);
                        int columnas = Convert.ToInt16(TextBox2.Text);
                        if (filas > 0 && filas <= 20 && columnas > 0 && columnas <= 20)
                        {
                            string per = Personalizar.SelectedItem.ToString();
                            string mod = modo.SelectedItem.ToString();
                            string tip = tipo.SelectedItem.ToString();
                            TableroX.color = "negro";
                            TableroX.carga = 0;
                            TableroX.mov = 0;
                            TableroX.movb = 0;
                            TableroX.movn = 0;
                            TableroX.bandera = false;
                            if (per.Equals("Personalizar Entrada") || mod.Equals("Seleccionar Modo De Juego") || tip.Equals("Seleccionar Tipo De Juego"))
                            {
                                Cuerpo.Text = "Por favor, Seleccione un Personalizacion, Modo y Tipo de juego disponible";
                                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ventana,", "$('#ventana').modal();", true);
                                panelModal.Update();
                            }
                            else if (per.Equals("Si"))
                            {
                                TableroX.tipo = tip;
                                TableroX.colorJ = "negro";
                                if (mod.Equals("Versus"))
                                {
                                    TableroX.partida = "Versus";
                                    iniciar();
                                }
                                else if (mod.Equals("CPU"))
                                {
                                    TableroX.partida = "Maquina";
                                    iniciar();
                                }
                            }
                            else
                            {
                                TableroX.tipo = tip;
                                TableroX.colorJ = "blanco";
                                if (mod.Equals("Versus"))
                                {
                                    TableroX.partida = "Versus";
                                    iniciar();
                                }
                                else if (mod.Equals("CPU"))
                                {
                                    TableroX.partida = "Maquina";
                                    iniciar();
                                }
                            }
                        }
                        else
                        {
                            Cuerpo.Text = "Por Favor, Ingrese Valores De Filas Y Columas Entre 1 y 20";
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

        public void iniciar()
        {
            for (int i = 0; i <= 63; i++)
            {
                MenuPrincipal.colores[i] = ".";
                MenuPrincipal.colum[i] = ".";
                MenuPrincipal.fila[i] = ".";
            }
            MenuPrincipal.colores[27] = "blanco";
            MenuPrincipal.colum[27] = "D";
            MenuPrincipal.fila[27] = "4";
            MenuPrincipal.colores[28] = "negro";
            MenuPrincipal.colum[28] = "E";
            MenuPrincipal.fila[28] = "4";
            MenuPrincipal.colores[35] = "negro";
            MenuPrincipal.colum[35] = "D";
            MenuPrincipal.fila[35] = "5";
            MenuPrincipal.colores[36] = "blanco";
            MenuPrincipal.colum[36] = "E";
            MenuPrincipal.fila[36] = "5";
            MenuPrincipal.columaux = MenuPrincipal.colum2;
            MenuPrincipal.filaaux = MenuPrincipal.fila2;
            Response.Redirect("TableroX.aspx");
        }
    }
}