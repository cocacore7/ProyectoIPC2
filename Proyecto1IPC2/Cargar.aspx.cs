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
    public partial class Cargar : System.Web.UI.Page
    {
        public static int id_partida = 0;
        BaseDatos bd = new BaseDatos();
        protected void Page_Load(object sender, EventArgs e)
        {
            string entrada = "";
            string datos = "select * from partida where id_usuario=@id_usuario";
            SqlCommand accion = new SqlCommand(datos, bd.registrar());
            accion.Parameters.AddWithValue("@id_usuario", InicioSesion.jugador);
            accion.ExecuteNonQuery();
            SqlDataReader leer = accion.ExecuteReader();
            partidas.Items.Clear();
            partidas.Items.Add("Seleccionar Partida");
            while (leer.Read())
            {
                entrada = Convert.ToString(leer["id_partida"]) + " ) partida: " + leer["tipo_partida"] + " - movimientos: " + Convert.ToString(leer["movimientos"]);
                partidas.Items.Add(entrada);
            }
        }

        protected void regresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuPrincipal.aspx");
        }

        protected void partidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void aceptar_Click(object sender, EventArgs e)
        {
            string archivo = partidas.SelectedItem.ToString();
            if (archivo.Equals("Seleccionar Partida"))
            {
                Titulo.Text = "Error de Carga";
                Cuerpo.Text = "Por favor, Seleccione una partida";
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ventana,", "$('#ventana').modal();", true);
                panelModal.Update();
            }
            else {
                string[] archivo2 = archivo.Split();
                id_partida = Convert.ToInt32(archivo2[0]);
                string datos = "select partida_g,movimientos from partida where id_usuario=@id_usuario and id_partida=@id_partida";
                SqlCommand accion = new SqlCommand(datos, bd.registrar());
                accion.Parameters.AddWithValue("@id_usuario", InicioSesion.jugador);
                accion.Parameters.AddWithValue("@id_partida", archivo2[0]);
                SqlDataReader leer = accion.ExecuteReader();
                string fila, colum, color;
                if (leer.Read())
                {
                    string cargar = leer["partida_g"].ToString();
                    XDocument documento = XDocument.Parse(cargar);
                    var archivos = from arch in documento.Descendants("tablero") select arch;
                    foreach (XElement i in archivos.Elements("ficha"))
                    {
                        fila = i.Element("fila").Value;
                        colum = i.Element("columna").Value;
                        color = i.Element("color").Value;
                        for (int u = 0; u <= 63; u++)
                        {
                            if (MenuPrincipal.filaaux[u] == fila && MenuPrincipal.columaux[u] == colum)
                            {
                                MenuPrincipal.colores[u] = color;
                                MenuPrincipal.colum[u] = colum;
                                MenuPrincipal.fila[u] = fila;
                            }
                        }
                    }
                    Tablero.carga = 1;
                    Tablero.mov = Convert.ToInt32(leer["movimientos"]);
                    Tablero.bandera = true;
                    Response.Redirect("Tablero.aspx");
                }
            }
        }
    }
}