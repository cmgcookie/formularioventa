using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows;
using System.Data;
using System.Windows.Forms;

namespace Ropa
{
    class conexion
    {
        public SqlConnection con = new SqlConnection("Data Source = Localhost; Initial Catalog = ropa; Integrated Security = True");
        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand comando;


        public void conectar()
        {
            try
            {
                con.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("error " + e);
            }
        }

        public Boolean insertar(String sql)
        {
            con.Open();
            comando = new SqlCommand(sql, con);
            int i = comando.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void consulta(String sql, String tabla)
        {
            con.Open();
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, con);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);
            con.Close();
        }

        public Boolean eliminar(String tabla, String condicion)
        {
            con.Open();
            String elimina = " delete from " + tabla + " where " + condicion;
            comando = new SqlCommand(elimina, con);
            int i = comando.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean modificar(String tabla, String campos, String condicion)
        {
            con.Open();
            String modifica = " update " + tabla + " set " + campos + " where " + condicion;
            comando = new SqlCommand(modifica, con);
            int i = comando.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
