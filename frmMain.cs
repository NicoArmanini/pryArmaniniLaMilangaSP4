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
            int i = 0;

            for (i = 0; i <= 4; i++)
            {
                dgvTabla.Rows.Add();
            }
            //Asigno nombres a la primer columna
            dgvTabla.Rows[0].Cells[0].Value = "Julio";
            dgvTabla.Rows[1].Cells[0].Value = "Esteban";
            dgvTabla.Rows[2].Cells[0].Value = "Javier";
            dgvTabla.Rows[3].Cells[0].Value = "Gonzalo";
            dgvTabla.Rows[4].Cells[0].Value = "Alberto";
            //Todas las celdas de la columna cero "Mozo" son ineditables
            dgvTabla.Columns[0].ReadOnly = true;
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

        private void btnMozoDelDia_Click(object sender, EventArgs e)
        {
           
            int c = 0;
            int f = 0;
            int Suma = 0;
            int Mayor = 0;
            int Posicion = 0;
            while (f < matDatos.GetLength(0))
            {
                while (c < matDatos.GetLength(1))
                {
                    Suma = Suma + matDatos[f, c];
                    c++;
                }
                vecDatos[f] = Suma;
                c = 0;
                f++;
                Suma = 0;
            }

            f = 0;
            Mayor = vecDatos[0];
            while (f <= 4)
            {
                if (vecDatos[f] >= Mayor)
                {
                    Mayor = vecDatos[f];
                    Posicion = f;
                }
                f++;
            }

            if (Posicion == 0)
            {
                txtMozo.Text = "Julio";
                txtTotal.Text = Mayor.ToString();
            }
            if (Posicion == 1)
            {
                txtMozo.Text = "Esteban";
                txtTotal.Text = Mayor.ToString();
            }
            if (Posicion == 2)
            {
                txtMozo.Text = "Javier";
                txtTotal.Text = Mayor.ToString();
            }
            if (Posicion == 3)
            {
                txtMozo.Text = "Gonzalo";
                txtTotal.Text = Mayor.ToString();
            }
            if (Posicion == 4)
            {
                txtMozo.Text = "Alberto";
                txtTotal.Text = Mayor.ToString();
            }

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int f = 0;
            int c = 0;
            int i = 5;
            int Suma = 0;
            int Total = 0;

            while (c < matDatos.GetLength(1) && i <= 9)
            {
                Suma = 0;
                while (f < matDatos.GetLength(0))
                {
                    Suma = Suma + matDatos[f, c];
                    f++;
                }
                vecDatos[i] = Suma;
                Total = Total + Suma;
                f = 0;
                c++;
                i++;
            }

            vecDatos[9] = Total;

            txtComidas.Text = Convert.ToString(vecDatos[5]);
            txtBebidasSA.Text = Convert.ToString(vecDatos[6]);
            txtBebidasCA.Text = Convert.ToString(vecDatos[7]);
            txtPostres.Text = Convert.ToString(vecDatos[8]);
            txtTotalFinal.Text = Convert.ToString(vecDatos[9]);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
