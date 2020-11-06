using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Proyecto1IPC2
{
    public partial class carga2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string fila = "", colum = "", color ="";
                TableroX.color1.Clear(); TableroX.color2.Clear(); TableroX.filas = 0; TableroX.columnas = 0; TableroX.inicial = true; TableroX.ini1 = true; TableroX.ini2 = true;
                TableroX.j1c1 = ""; TableroX.j1c2 = ""; TableroX.j1c3 = ""; TableroX.j1c4 = ""; TableroX.j1c5 = "";
                TableroX.j2c1 = ""; TableroX.j2c2 = ""; TableroX.j2c3 = ""; TableroX.j2c4 = ""; TableroX.j2c5 = "";
                TableroX.botones.Clear(); TableroX.modo = "Versus"; TableroX.per = ".";

                XDocument documento = XDocument.Load("C:\\Users\\usuario\\OneDrive\\Escritorio\\partidasX\\" + FileUpload1.FileName);
                var archivos = from arch in documento.Descendants("partida") select arch;
                foreach (XElement z in archivos.Elements("filas")) { TableroX.filas = Convert.ToInt16(z.Value); }
                foreach (XElement z in archivos.Elements("columnas")) { TableroX.columnas = Convert.ToInt16(z.Value); }
                foreach (XElement z in archivos.Elements("Modalidad")) { TableroX.tipo = z.Value; }
                var archivos2 = from arch in documento.Descendants("Jugador1") select arch;
                foreach (XElement z in archivos2.Elements("color"))
                {
                    if (TableroX.j1c1.Equals("")) { TableroX.j1c1 = Convert.ToString(z.Value); TableroX.color1.Add(Convert.ToString(z.Value)); }
                    else if (TableroX.j1c2.Equals("") && !Convert.ToString(z.Value).Equals(TableroX.j1c1)) { TableroX.j1c2 = Convert.ToString(z.Value); TableroX.color1.Add(Convert.ToString(z.Value)); }
                    else if (TableroX.j1c3.Equals("") && !Convert.ToString(z.Value).Equals(TableroX.j1c2) && !Convert.ToString(z.Value).Equals(TableroX.j1c1)) { TableroX.j1c3 = Convert.ToString(z.Value); TableroX.color1.Add(Convert.ToString(z.Value)); }
                    else if (TableroX.j1c4.Equals("") && !Convert.ToString(z.Value).Equals(TableroX.j1c3) && !Convert.ToString(z.Value).Equals(TableroX.j1c2) && !Convert.ToString(z.Value).Equals(TableroX.j1c1)) { TableroX.j1c4 = Convert.ToString(z.Value); TableroX.color1.Add(Convert.ToString(z.Value)); }
                    else if (TableroX.j1c5.Equals("") && !Convert.ToString(z.Value).Equals(TableroX.j1c4) && !Convert.ToString(z.Value).Equals(TableroX.j1c3) && !Convert.ToString(z.Value).Equals(TableroX.j1c2) && !Convert.ToString(z.Value).Equals(TableroX.j1c1)) { TableroX.j1c5 = Convert.ToString(z.Value); TableroX.color1.Add(Convert.ToString(z.Value)); }
                }
                var archivos3 = from arch in documento.Descendants("Jugador2") select arch;
                foreach (XElement z in archivos3.Elements("color"))
                {
                    if (TableroX.j2c1.Equals("")) { TableroX.j2c1 = Convert.ToString(z.Value); TableroX.color2.Add(Convert.ToString(z.Value)); }
                    else if (TableroX.j2c2.Equals("") && !Convert.ToString(z.Value).Equals(TableroX.j2c1)) { TableroX.j2c2 = Convert.ToString(z.Value); TableroX.color2.Add(Convert.ToString(z.Value)); }
                    else if (TableroX.j2c3.Equals("") && !Convert.ToString(z.Value).Equals(TableroX.j2c2) && !Convert.ToString(z.Value).Equals(TableroX.j2c1)) { TableroX.j2c3 = Convert.ToString(z.Value); TableroX.color2.Add(Convert.ToString(z.Value)); }
                    else if (TableroX.j2c4.Equals("") && !Convert.ToString(z.Value).Equals(TableroX.j2c3) && !Convert.ToString(z.Value).Equals(TableroX.j2c2) && !Convert.ToString(z.Value).Equals(TableroX.j2c1)) { TableroX.j2c4 = Convert.ToString(z.Value); TableroX.color2.Add(Convert.ToString(z.Value)); }
                    else if (TableroX.j2c5.Equals("") && !Convert.ToString(z.Value).Equals(TableroX.j2c4) && !Convert.ToString(z.Value).Equals(TableroX.j2c3) && !Convert.ToString(z.Value).Equals(TableroX.j2c2) && !Convert.ToString(z.Value).Equals(TableroX.j2c1)) { TableroX.j2c5 = Convert.ToString(z.Value); TableroX.color2.Add(Convert.ToString(z.Value)); }
                }
                var archivos4 = from arch in documento.Descendants("tablero") select arch;
                for (int i = 0; i < TableroX.filas * TableroX.columnas; i++)
                {
                    ImageButton boton = new ImageButton();
                    boton.Width = 40;
                    boton.Height = 40;
                    boton.ID = Convert.ToString(i);
                    boton.ImageUrl = "vacio.png";
                    boton.Enabled = false;
                    TableroX.botones.Add(boton);
                }
                TableroX.numeros = new List<string>(); TableroX.letras = new List<string>();
                for (int i = 0; i < TableroX.filas; i++) { TableroX.numeros.Add(SelecX.fil[i]); }
                for (int i = 0; i < TableroX.columnas; i++) { TableroX.letras.Add(SelecX.colum[i]); }
                foreach (XElement z in archivos4.Elements("ficha"))
                {
                    int contador = 0;
                    colum = z.Element("columna").Value;
                    fila = z.Element("fila").Value;
                    color = z.Element("color").Value;
                    foreach (string a in TableroX.numeros) {
                        foreach (string b in TableroX.letras)
                        {
                            if (a.Equals(fila) && b.Equals(colum))
                            {
                                if (TableroX.botones[contador].ImageUrl.Equals("vacio.png")) { TableroX.botones[contador].ImageUrl = color + ".png"; }
                            }
                            contador++;
                        }
                    }
                }
                foreach (XElement z in archivos4.Elements("siguienteTiro"))
                {
                    TableroX.actual = Convert.ToString(z.Element("color").Value);
                    if (TableroX.j1c1.Equals(TableroX.actual))
                    {
                        TableroX.j1 = TableroX.j1c1;
                        if (!TableroX.j2c5.Equals("")) { TableroX.j2 = TableroX.j2c5; }
                        else if (!TableroX.j2c4.Equals("")) { TableroX.j2 = TableroX.j2c4; }
                        else if (!TableroX.j2c3.Equals("")) { TableroX.j2 = TableroX.j2c3; }
                        else if (!TableroX.j2c2.Equals("")) { TableroX.j2 = TableroX.j2c2; }
                        else { TableroX.j2 = TableroX.j2c1; }
                        TableroX.turno = false;
                    }
                    else if (TableroX.j1c2.Equals(TableroX.actual))
                    {
                        TableroX.j1 = TableroX.j1c2;
                        TableroX.j2 = TableroX.j2c1; TableroX.turno = false;
                    }
                    else if (TableroX.j1c3.Equals(TableroX.actual))
                    {
                        TableroX.j1 = TableroX.j1c3;
                        if (!TableroX.j2c2.Equals("")) { TableroX.j2 = TableroX.j2c2; }
                        else { TableroX.j2 = TableroX.j2c1; }
                        TableroX.turno = false;
                    }
                    else if (TableroX.j1c4.Equals(TableroX.actual))
                    {
                        TableroX.j1 = TableroX.j1c4;
                        if (!TableroX.j2c3.Equals("")) { TableroX.j2 = TableroX.j2c3; }
                        else if (!TableroX.j2c2.Equals("")) { TableroX.j2 = TableroX.j2c2; }
                        else { TableroX.j2 = TableroX.j2c1; }
                        TableroX.turno = false;
                    }
                    else if (TableroX.j1c5.Equals(TableroX.actual))
                    {
                        TableroX.j1 = TableroX.j1c5;
                        if (!TableroX.j2c4.Equals("")) { TableroX.j2 = TableroX.j2c4; }
                        else if (!TableroX.j2c3.Equals("")) { TableroX.j2 = TableroX.j2c3; }
                        else if (!TableroX.j2c2.Equals("")) { TableroX.j2 = TableroX.j2c2; }
                        else { TableroX.j2 = TableroX.j2c1; };
                        TableroX.turno = false;
                    }
                    else if (TableroX.j2c1.Equals(TableroX.actual))
                    {
                        TableroX.turno = true;
                        TableroX.j1 = TableroX.j1c1;
                        TableroX.j2 = TableroX.j2c1;
                    }
                    else if (TableroX.j2c2.Equals(TableroX.actual))
                    {
                        TableroX.turno = true;
                        TableroX.j1 = TableroX.j1c2;
                        TableroX.j2 = TableroX.j2c2;
                    }
                    else if (TableroX.j2c3.Equals(TableroX.actual))
                    {
                        TableroX.turno = true;
                        TableroX.j1 = TableroX.j1c3;
                        TableroX.j2 = TableroX.j2c3;
                    }
                    else if (TableroX.j2c4.Equals(TableroX.actual))
                    {
                        TableroX.turno = true;
                        TableroX.j1 = TableroX.j1c4;
                        TableroX.j2 = TableroX.j2c4;
                    }
                    else if (TableroX.j2c5.Equals(TableroX.actual))
                    {
                        TableroX.turno = true;
                        TableroX.j1 = TableroX.j1c5;
                        TableroX.j2 = TableroX.j2c5;
                    }
                }
                if (TableroX.filas % 2 == 0 && TableroX.columnas % 2 == 0)
                {
                    if (TableroX.color1.Count < 6 && TableroX.color1.Count > 0 && TableroX.color2.Count < 6 && TableroX.color2.Count > 0)
                    {
                        if (TableroX.tipo.Equals("Normal") || TableroX.tipo.Equals("Inversa"))
                        {
                            Response.Redirect("TableroX.aspx");
                        }
                        else
                        {
                            Cuerpo.Text = "Modalidad Incorrecta";
                            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ventana,", "$('#ventana').modal();", true);
                            panelModal.Update();
                        }
                        
                    }
                    else
                    {
                        Cuerpo.Text = "Cantidad De Colores Por Jugador Incorrecto";
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ventana,", "$('#ventana').modal();", true);
                        panelModal.Update();
                    }
                }
                else {
                    Cuerpo.Text = "Valores de filas y columnas incorrectos";
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ventana,", "$('#ventana').modal();", true);
                    panelModal.Update();
                }
                
            }
            else
            {
                Cuerpo.Text = "Por favor, Seleccione una partida";
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