using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CEntidades;

namespace CDatos
{
    public class CDatMascota
    {
        CConexion objconexion = new CConexion();
        SqlCommand cmd = new SqlCommand();

        public bool guardar_mascota(CEntMascotas oentmascotas)
        {
            try
            {
                cmd.Connection = objconexion.conectar("dbveterinaria");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_guardar_mascota";
                cmd.Parameters.Add("@pcod_mascota", oentmascotas.Cod_mascota);
                cmd.Parameters.Add("@pnom_mascota", oentmascotas.Nom_mascota);
                cmd.Parameters.Add("@pnom_propietario", oentmascotas.Nom_propietario);
                cmd.Parameters.Add("@pfecha_nacimiento_mascota", oentmascotas.Fecha_nacimiento_mascota);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception error)
            {
                throw new Exception(error.Message);
            }
        }

        public bool anular_mascota(CEntMascotas oentmascotas)
        {
            try
            {
                cmd.Connection = objconexion.conectar("dbveterinaria");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_anular_mascota";
                cmd.Parameters.Add("@pcod_mascota", oentmascotas.Cod_mascota);
                cmd.Parameters.Add("@ptipo", oentmascotas.Tipo);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception error)
            {
                throw new Exception(error.Message);
            }
        }

        public DataSet consultar_mascota(CEntMascotas oentmascotas)
        {
            try
            {
                cmd.Connection = objconexion.conectar("dbveterinaria");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_consultar_mascota";
                cmd.Parameters.Add("@pcod_mascota", oentmascotas.Cod_mascota);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }
    }
}
