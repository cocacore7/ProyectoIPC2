using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto1IPC2
{
    public partial class Perfil : System.Web.UI.Page
    {
        BaseDatos bd = new BaseDatos();

        protected void Page_Load(object sender, EventArgs e)
        {
            int c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0;
            string datos = "select * from partida where id_usuario=@id_usuario";
            SqlCommand accion = new SqlCommand(datos, bd.registrar());
            accion.Parameters.AddWithValue("@id_usuario", InicioSesion.jugador);
            accion.ExecuteNonQuery();
            SqlDataReader leer = accion.ExecuteReader();
            while (leer.Read())
            {
                if (leer["pge"].Equals("Victoria")) { c1++; }
                if (leer["pge"].Equals("Empate")) { c2++; }
                if (leer["pge"].Equals("Perdido")) { c3++; }
            }
            leer.Close();
            string datos2 = "select * from partidax where id_usuario=@id_usuario";
            accion = new SqlCommand(datos2, bd.registrar());
            accion.Parameters.AddWithValue("@id_usuario", InicioSesion.jugador);
            accion.ExecuteNonQuery();
            leer = accion.ExecuteReader();
            while (leer.Read())
            {
                if (leer["pge"].Equals("Victoria")) { c4++; }
                if (leer["pge"].Equals("Empate")) { c5++; }
                if (leer["pge"].Equals("Perdido")) { c6++; }
            }
            datos2 = "select * from usuario where id_usuario=@id_usuario";
            string nombre = "No se Encontro";
            accion = new SqlCommand(datos2, bd.registrar());
            accion.Parameters.AddWithValue("@id_usuario", InicioSesion.jugador);
            accion.ExecuteNonQuery();
            leer = accion.ExecuteReader();
            if (leer.Read())
            {
                nombre = Convert.ToString(leer["usuario"]);
            }
            titulo.Text = "Perfil: " + nombre ;
            pag.Text = Convert.ToString(c1);
            pae.Text = Convert.ToString(c2);
            pap.Text = Convert.ToString(c3);
            paxg.Text = Convert.ToString(c4);
            paxe.Text = Convert.ToString(c5);
            paxp.Text = Convert.ToString(c6);
        }

        protected void regresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuPrincipal.aspx");
        }
    }
}