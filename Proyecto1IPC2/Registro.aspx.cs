using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto1IPC2
{
    public partial class Registro : Page
    {
        public void Page_Load(object sender, EventArgs e)
        {
            
        }

        public void registrar_Click(object sender, EventArgs e)
        {
            BaseDatos bd = new BaseDatos();
            string nombres = nombre.Text;
            string apellidos = apellido.Text;
            string usuario = nickname.Text;
            string contra = password.Text;
            string fechaNac = fecha.Text;
            string residencia = pais.Text;
            string correo = email.Text;
            if(residencia.Equals("Elegir Opcion") || nombre.Equals("") || apellidos.Equals("") || usuario.Equals("") || contra.Equals("") || fechaNac.Equals("") || residencia.Equals("") || correo.Equals(""))
            {
                Titulo.Text = "Error De Registro";
                Cuerpo.Text = "Campos Vacios, Por Favor Llenar todos los campos";
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ventana,", "$('#ventana').modal();", true);
                panelModal.Update();
                nombre.Text = "";
                apellido.Text = "";
                nickname.Text = "";
                password.Text = "";
                fecha.Text = "";
                pais.Text = "";
                email.Text = "";
            }
            else
            {
                SqlCommand accion;
                string buscar = "select usuario from usuario where usuario=@usuario";
                accion = new SqlCommand(buscar, bd.registrar());
                accion.Parameters.AddWithValue("@usuario", usuario);
                SqlDataReader leer = accion.ExecuteReader();
                if (leer.Read())
                {
                    Titulo.Text = "Error De Registro";
                    Cuerpo.Text = "Usuario ya Registrado";
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ventana,", "$('#ventana').modal();", true);
                    panelModal.Update();
                    nombre.Text = "";
                    apellido.Text = "";
                    nickname.Text = "";
                    password.Text = "";
                    fecha.Text = "";
                    pais.Text = "";
                    email.Text = "";
                }
                else
                {
                    string datos = "insert into usuario(nombres,apellidos,usuario,contra,fechaNac,pais,correo) values(@nombres,@apellidos,@usuario,@contra,@fechaNac,@residencia,@correo)";
                    accion = new SqlCommand(datos, bd.registrar());
                    accion.Parameters.AddWithValue("@nombres", nombres);
                    accion.Parameters.AddWithValue("@apellidos", apellidos);
                    accion.Parameters.AddWithValue("@usuario", usuario.ToLower());
                    accion.Parameters.AddWithValue("@contra", contra);
                    accion.Parameters.AddWithValue("@fechaNac", fechaNac);
                    accion.Parameters.AddWithValue("@residencia", residencia);
                    accion.Parameters.AddWithValue("@correo", correo.ToLower());
                    accion.ExecuteNonQuery();
                    nombre.Text = "";
                    apellido.Text = "";
                    nickname.Text = "";
                    password.Text = "";
                    fecha.Text = "";
                    pais.Text = "";
                    email.Text = "";
                    Response.Redirect("InicioSesion.aspx");
                }
            }
        }
    }
}