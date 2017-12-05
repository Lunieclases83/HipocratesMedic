using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMedicacion.Controles
{
    public class ControlPersona : ProyectoMedicacion.Clases.Persona
    {
        
        public static void LlenarTablaPersonaEnAlergias(DataGridView TablaPersona)
        {
            Data_Persistance.Conexion.CerrarConexion();
            Data_Persistance.Conexion.AbrirConexion();

            string cmd = "SELECT * FROM Persona";
            SqlCommand cm = new SqlCommand(cmd, Data_Persistance.Conexion.conn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);

            TablaPersona.DataSource = dt;
            Data_Persistance.Conexion.CerrarConexion();

        }

        public static void GuardarNuevaPersona (string nom, string ape, string edad, string tipo, string sexo, string cedu)
        {
            try
            {
                ProyectoMedicacion.Data_Persistance.Conexion.ejecutaProcedure("Insertar_Persona",
               new List<System.Data.SqlClient.SqlParameter>(){
               new System.Data.SqlClient.SqlParameter("@Nombre",nom),
               new System.Data.SqlClient.SqlParameter("@Apellido",ape),
               new System.Data.SqlClient.SqlParameter("@Edad",edad),
               new System.Data.SqlClient.SqlParameter("@Tipo",tipo),
               new System.Data.SqlClient.SqlParameter("@Sexo",sexo),
               new System.Data.SqlClient.SqlParameter("@Cedula",cedu)

          });
            }
            catch (System.Data.SqlClient.SqlException sqlex)
            {
                throw sqlex;
            }
            finally { Data_Persistance.Conexion.CerrarConexion(); }
        }

        public static void ActualizarPersona(string id, string nom, string ape, string edad, string tipo, string sexo, string cedu)
        {
            try
            {
                ProyectoMedicacion.Data_Persistance.Conexion.ejecutaProcedure("ActualizarPersona",
               new List<System.Data.SqlClient.SqlParameter>(){
               new System.Data.SqlClient.SqlParameter("@Id",id),
               new System.Data.SqlClient.SqlParameter("@Nombre",nom),
               new System.Data.SqlClient.SqlParameter("@Apellido",ape),
               new System.Data.SqlClient.SqlParameter("@Edad",edad),
               new System.Data.SqlClient.SqlParameter("@Tipo",tipo),
               new System.Data.SqlClient.SqlParameter("@Sexo",sexo),
               new System.Data.SqlClient.SqlParameter("@Cedula",cedu)

          });
            }
            catch (System.Data.SqlClient.SqlException sqlex)
            {
                throw sqlex;
            }
            finally { Data_Persistance.Conexion.CerrarConexion(); }
        }

    }
}
