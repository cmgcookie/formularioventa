using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ropa
{
    public partial class vendedores : Form
    {
        public static String a = "", b = "", c = "", d = "", e1 = "";

        public vendedores()
        {
            InitializeComponent();
        }

        private void textBox6_KeyUp(object sender, KeyEventArgs e)
        {
            conexion con = new conexion();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            String sql = "";
            sql = "select * from vendedores where rfcv like '" + textBox6.Text + "%'";
            con.consulta(sql, "vendedores");
            dataGridView1.DataSource = con.ds;
            dataGridView1.DataMember = "vendedores";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion vende = new conexion();
            String scnn = "";
            scnn = "Data Source = Localhost; Initial Catalog = ropa; Integrated Security = True";


            String agregar = "insert into vendedores values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            if (vende.insertar(agregar))
            {
                MessageBox.Show("Datos agregados correctamente");
            }

            else
            {
                MessageBox.Show("Error al agregar datos");
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            String sql = "";
            sql = "select * from vendedores";
            vende.consulta(sql, "vendedores");
            dataGridView1.DataSource = vende.ds;
            dataGridView1.DataMember = "vendedores";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion vende = new conexion();
            String scnn = "";
            scnn = "Data Source = Localhost; Initial Catalog = ropa; Integrated Security = True";


            //String modifica = "update proveedor set id = " + textid.Text + " nombre = " + textnombre.Text + " direccion = " + textdir.Text + " telefono = " + texttel.Text;
            //String modifica = "update proveedor set id='{0}', nombre='{1}', direccion='{2}', telefono='{3}'", ;
            String camposp = " nombre = '" + textBox2.Text + "' , direccion = '" + textBox3.Text + "' , telefono = '" + textBox4.Text + "' , correo = '" + textBox5.Text + "'";
            if (vende.modificar("vendedores", camposp, " rfcv = '" + textBox1.Text + "'"))
            {
                MessageBox.Show("Datos modificados correctamente");
            }

            else
            {
                MessageBox.Show("Error al modificar datos");
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            String sql = "";
            sql = "select * from vendedores";
            vende.consulta(sql, "vendedores");
            dataGridView1.DataSource = vende.ds;
            dataGridView1.DataMember = "vendedores";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexion vende = new conexion();
            String scnn = "";
            scnn = "Data Source = Localhost; Initial Catalog = ropa; Integrated Security = True";


            if (vende.eliminar("vendedores", "rfcv = '" + textBox1.Text + "'"))
            {
                MessageBox.Show("Datos eliminados correctamente");
            }

            else
            {
                MessageBox.Show("Error al eliminar datos");
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            String sql = "";
            sql = "select * from vendedores";
            vende.consulta(sql, "vendedores");
            dataGridView1.DataSource = vende.ds;
            dataGridView1.DataMember = "vendedores";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int valor = Convert.ToInt32(dataGridView1.CurrentRow.Index.ToString());

            a = Convert.ToString(dataGridView1.Rows[valor].Cells[0].Value);
            b = Convert.ToString(dataGridView1.Rows[valor].Cells[1].Value);
            c = Convert.ToString(dataGridView1.Rows[valor].Cells[2].Value);
            d = Convert.ToString(dataGridView1.Rows[valor].Cells[3].Value);
            actualizvendedor();
        }

        public void actualizvendedor()
        {
            textBox1.Text = a;
            textBox2.Text = b;
            textBox3.Text = c;
            textBox4.Text = d;
            textBox5.Text = d;
        }
    }
}
