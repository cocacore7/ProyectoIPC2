using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
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
        public static string archivo = "";
        BaseDatos bd = new BaseDatos();
        protected void Page_Load(object sender, EventArgs e)
        {
            archivo = partidas.Text;
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
                if (leer["pge"].Equals("."))
                {
                    entrada = Convert.ToString(leer["id_partida"]) + " ) partida: " + leer["tipo_partida"] + " - puntos: " + Convert.ToString(leer["puntos"]);
                    partidas.Items.Add(entrada);
                }
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
            if (archivo.Equals("Seleccionar Partida"))
            {
                Cuerpo.Text = "Por favor, Seleccione una partida";
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ventana,", "$('#ventana').modal();", true);
                panelModal.Update();
            }
            else {
                string[] archivo2 = archivo.Split();
                id_partida = Convert.ToInt32(archivo2[0]);
                string datos = "select * from partida where id_usuario=@id_usuario and id_partida=@id_partida";
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
                    Tablero.carga = 1;
                    Tablero.colorJ = Convert.ToString(leer["color"]);
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
                    Tablero.nombre = Convert.ToString(leer["nombre"] + ".xml");
                    Tablero.partida = Convert.ToString(leer["tipo_partida"]);
                    Response.Redirect("Tablero.aspx");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string fila, colum, color, partida = "";
                Tablero.nombre = FileUpload1.FileName;
                foreach (char letra in Tablero.nombre) {
                    if (letra.Equals('.'))
                    {
                        break;
                    }
                    else {
                        partida = partida + letra;
                    }
                }
                XDocument documento = XDocument.Load("C:\\Users\\usuario\\OneDrive\\Escritorio\\partidas\\" + Tablero.nombre);
                var archivos = from arch in documento.Descendants("tablero") select arch;
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
                string datos = "select * from partida where nombre=@nombre";
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
                Response.Redirect("Tablero.aspx");
            }
            else
            {
                Cuerpo.Text = "Por favor, Seleccione una partida";
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ventana,", "$('#ventana').modal();", true);
                panelModal.Update();
            }
        }
    }
}