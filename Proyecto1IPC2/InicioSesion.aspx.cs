using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto1IPC2
{
    public partial class InicioSesion : Page
    {
        public static string jugador = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {
            BaseDatos bd = new BaseDatos();
            string usuario = nickname.Text;
            string contra = password.Text;
            if(usuario.Equals("") || contra.Equals(""))
            {
                Titulo.Text = "Error De Registro";
                Cuerpo.Text = "Campos Vacios, Por Favor Llenar todos los campos";
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ventana,", "$('#ventana').modal();", true);
                panelModal.Update();
                nickname.Text = "";
                password.Text = "";
            }
            else
            {
                SqlCommand accion;
                string buscar = "select id_usuario from usuario where usuario=@usuario and contra=@contra";
                accion = new SqlCommand(buscar, bd.registrar());
                accion.Parameters.AddWithValue("@usuario", usuario);
                accion.Parameters.AddWithValue("@contra", contra);
                SqlDataReader leer = accion.ExecuteReader();
                if (leer.Read())
                {
                    jugador = Convert.ToString(leer["id_usuario"]);
                    MenuPrincipal.jugador = usuario;
                    Response.Redirect("MenuPrincipal.aspx");
                }
                else
                {
                    Titulo.Text = "Error De Registro";
                    Cuerpo.Text = "Usuario No Valido";
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ventana,", "$('#ventana').modal();", true);
                    panelModal.Update();
                    nickname.Text = "";
                    password.Text = "";
                }
            }
        }
    }
}