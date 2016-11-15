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
    public partial class Form1 : Form
    {
        almacen alma;
        clientes cli;
        ventas vent;
        vendedores vend;

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void almacenM_Click(object sender, EventArgs e)
        {
           
            if (alma==null)
            {
                alma = new almacen();
                alma.MdiParent = this;
                alma.FormClosed += new FormClosedEventHandler(almacerrar);
                alma.Show();
            }
            else
            {
                alma.Activate();
            }
        }

        private void clientesM_Click(object sender, EventArgs e)
        {
            if (cli == null)
            {
                cli = new clientes();
                cli.MdiParent = this;
                cli.FormClosed += new FormClosedEventHandler(almacerrar);
                cli.Show();
            }
            else
            {
                cli.Activate();
            }
        }

        private void ventasM_Click(object sender, EventArgs e)
        {
            if (vent == null)
            {
                vent = new ventas();
                vent.MdiParent = this;
                vent.FormClosed += new FormClosedEventHandler(almacerrar);
                vent.Show();
            }
            else
            {
                vent.Activate();
            }
        }

        private void vendedoresM_Click(object sender, EventArgs e)
        {
            if (vend == null)
            {
                vend = new vendedores();
                vend.MdiParent = this;
                vend.FormClosed += new FormClosedEventHandler(almacerrar);
                vend.Show();
            }
            else
            {
                vend.Activate();
            }
        }


        void almacerrar(object sender, EventArgs e)
        {
            alma = null;
        }

        void clicerrar(object sender, EventArgs e)
        {
            cli = null;
        }

        void ventcerrar(object sender, EventArgs e)
        {
            vent = null;
        }

        void vendcerrar(object sender, EventArgs e)
        {
            vend = null;
        }
    }
}
