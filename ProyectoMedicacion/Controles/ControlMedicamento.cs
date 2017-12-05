using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProyectoMedicacion.Controles
{
    public class ControlMedicamento
    {
        
        public static void InsertarMedicamento(string NomMedic, string fechaEx, string Indica, string dosis, string Contenedor)
        {
            try
            {
                Data_Persistance.Conexion.CerrarConexion();
                Data_Persistance.Conexion.AbrirConexion();

                SqlCommand cmd = new SqlCommand("AgregarMedicamentoConRetorno", Data_Persistance.Conexion.conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Nombre_Medicamento", NomMedic));
                cmd.Parameters.Add(new SqlParameter(@"Fecha_Expiracion",fechaEx));
                cmd.Parameters.Add(new SqlParameter(@"Indicacion", Indica));
                cmd.Parameters.Add(new SqlParameter(@"Dosis", dosis));
                cmd.Parameters.Add(new SqlParameter(@"Contenedor_Medicamento", Contenedor));
                ///proceso para poder obtener ID DEL MEDICAMENTO//
                SqlParameter ReturnValue = new SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int);
                ReturnValue.Direction = System.Data.ParameterDirection.ReturnValue;
                ///FIN///
                cmd.Parameters.Add(ReturnValue);
                
                cmd.ExecuteNonQuery();

               Clases.Medicamento.IdMedicamento = (int)cmd.Parameters["@RETURN_VALUE"].Value;

             
            }
            catch (Exception)
            {

                throw;
            }
            finally { Data_Persistance.Conexion.CerrarConexion(); }
        }

        public static void LlenarTablaMedicamentos(DataGridView TablaMedicamentos)
        {
             Data_Persistance.Conexion.CerrarConexion();
            Data_Persistance.Conexion.AbrirConexion();

            string cmd = "SELECT Id_Medicamento, Nombre_Medicamento, Fecha_Expiracion, Contenedor_Medicamento FROM Medicamento";
            SqlCommand cm = new SqlCommand(cmd, Data_Persistance.Conexion.conn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);

            TablaMedicamentos.DataSource = dt;
            Data_Persistance.Conexion.CerrarConexion();
        }

        public static void LlenarTablaComponenteXMedicamento(DataGridView TablaComponente, string idmedi)
        {
            Data_Persistance.Conexion.CerrarConexion();
            Data_Persistance.Conexion.AbrirConexion();

            string cmd = " SELECT Componente.Componente FROM Componente JOIN Composicion_Medicamento ON Composicion_Medicamento.Id_Componente = Componente.Id_Componente JOIN Medicamento ON Composicion_Medicamento.Id_Medicamento = Medicamento.Id_Medicamento WHERE Medicamento.Id_Medicamento = "+idmedi+";";
            SqlCommand cm = new SqlCommand(cmd, Data_Persistance.Conexion.conn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);

            TablaComponente.DataSource = dt;
            Data_Persistance.Conexion.CerrarConexion();
        }

        public static void LlenarTablasSintomaXMedicamento(DataGridView TablaSintoma, string idmedi)
        {
            Data_Persistance.Conexion.CerrarConexion();
            Data_Persistance.Conexion.AbrirConexion();

            string cmd = " SELECT Sintoma.Nombre_Sintoma FROM Sintoma JOIN Sintoma_Medicamento ON Sintoma_Medicamento.Id_Sintoma = Sintoma.Id_Sintoma JOIN Medicamento ON Sintoma_Medicamento.Id_Medicamento = Medicamento.Id_Medicamento WHERE Medicamento.Id_Medicamento = " + idmedi + ";";

            SqlCommand cm = new SqlCommand(cmd, Data_Persistance.Conexion.conn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);

            TablaSintoma.DataSource = dt;
            Data_Persistance.Conexion.CerrarConexion();
        }

    }
}
