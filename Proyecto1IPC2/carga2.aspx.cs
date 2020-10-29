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
                string fila, colum, color, filas, columnas, partida = "";
                
                TableroX.nombre = FileUpload1.FileName;
                foreach (char letra in Tablero.nombre)
                {
                    if (letra.Equals('.'))
                    {
                        break;
                    }
                    else
                    {
                        partida = partida + letra;
                    }
                }
                XDocument documento = XDocument.Load("C:\\Users\\usuario\\OneDrive\\Escritorio\\partidasX\\" + FileUpload1.FileName);
                var archivos = from arch in documento.Descendants("partida") select arch;
                foreach (XElement z in archivos.Elements("partida"))
                {
                    filas = Convert.ToString(z.Element("filas").Value);
                    columnas = Convert.ToString(z.Element("columnas").Value);
                    partida = Convert.ToString(z.Element("Modalidad").Value);
                }
                foreach (XElement z in archivos.Elements("Jugador1"))
                {
                    TableroX.color1.Add(Convert.ToString(z.Element("color").Value));
                }
                foreach (XElement z in archivos.Elements("Jugador2"))
                {
                    TableroX.color2.Add(Convert.ToString(z.Element("color").Value));
                }
                foreach (XElement i in archivos.Elements("ficha"))
                {
                    fila = i.Element("fila").Value;
                    colum = i.Element("columna").Value;
                    color = i.Element("color").Value;
                    for (int u = 0; u <= 63; u++)
                    {
                        if (MenuPrincipal.filaaux[u] == fila && MenuPrincipal.columaux[u] == colum && MenuPrincipal.colores[u].Equals("."))
                        {
                            MenuPrincipal.colores[u] = color;
                            MenuPrincipal.colum[u] = colum;
                            MenuPrincipal.fila[u] = fila;
                        }
                    }
                }
                foreach (XElement z in archivos.Elements("siguienteTiro"))
                {
                    Tablero.color = Convert.ToString(z.Element("color").Value);
                }
                /*string datos = "select * from partida where nombre=@nombre";
                SqlCommand accion = new SqlCommand(datos, bd.registrar());
                accion.Parameters.AddWithValue("@nombre", partida);
                SqlDataReader leer = accion.ExecuteReader();
                if (leer.Read())
                {
                    Tablero.colorJ = Convert.ToString(leer["color"]);
                    Tablero.partida = Convert.ToString(leer["tipo_partida"]);
                }
                else
                {
                    Tablero.colorJ = "negro";
                    Tablero.partida = "Versus";
                }
                Tablero.carga = 1;
                Tablero.puntosb = 0;
                Tablero.puntosn = 0;
                for (int i = 0; i <= 63; i++)
                {
                    if (MenuPrincipal.colores[i].Equals("negro"))
                    {
                        Tablero.puntosn++;
                    }
                    else if (MenuPrincipal.colores[i].Equals("blanco"))
                    {
                        Tablero.puntosb++;
                    }
                }
                Tablero.bandera = true;
                Response.Redirect("TableroX.aspx");*/
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