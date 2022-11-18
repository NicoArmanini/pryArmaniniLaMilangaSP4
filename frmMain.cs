using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArmaniniLaMilangaSP4
{
    public partial class frmMain : Form
    {
        //defino tamanio de vectores y matrices
        public int [] vecDatos = new int[10];
        public int[,] matDatos = new int[5,4];
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //pongo nombre de mozos y las filas correspondientes

            dgvTabla.Rows.Add("Julio");
            dgvTabla.Rows.Add("Esteban");
            dgvTabla.Rows.Add("Javier");
            dgvTabla.Rows.Add("Gonzalo");
            dgvTabla.Rows.Add("Alberto");

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            int i = 0;
            int f = 0;
            int c = 1;
            int cmat = 0;
            while (f <= 4)
            {
                while (c <= 4)
                {

                    if (dgvTabla.Rows[f].Cells[c].Value == null || dgvTabla.Rows[f].Cells[c].Value == "")
                    {
                        i++;
                    }
                    c++;
                }
                c = 1;
                f++;
            }

            if (i == 0)
            {

                btnMozoDelDia.Enabled = true;
                btnTotal.Enabled = true;

                f = 0;
                c = 1;

                while (f <= 4)
                {
                    while (c <= 4 && cmat <= matDatos.GetLength(1))
                    {
                        matDatos[f, cmat] = Convert.ToInt32(dgvTabla.Rows[f].Cells[c].Value);
                        c++;
                        cmat++;
                    }
                    c = 1;
                    cmat = 0;
                    f++;
                }
            }
            else
            {

                btnMozoDelDia.Enabled = false;
                btnTotal.Enabled = false;
                MessageBox.Show("Asegurese de ingresar valores numéricos.", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
