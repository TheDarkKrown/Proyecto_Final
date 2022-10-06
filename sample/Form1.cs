using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace sample
{
    public partial class Menu : Form
    {
        double precio, vPrecio; int Carlos = 0, Samuel = 0, Luis = 0, Enger = 0;
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lblfecha.Text = "Fecha" + DateTime.Today.Date.ToString("d");
            txtcorreo.Text = (" ").ToString();
            txtnombre.Text = (" ").ToString();
            lblprecio.Text = (0).ToString("c");
            //Int16.Parse(textBox2.Text);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbocortes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string corte = cbocortes.Text;
            List<Double> Precio = new List<Double>() { 100, 120, 130, 110, 90, 80, 70, 60, 140 };


            if (corte == ("High Fade")) precio = Precio[0];
            if (corte == ("Mid Fade")) precio = Precio[1];
            if (corte == ("Low Fade")) precio = Precio[2];
            if (corte == ("Taper Fade")) precio = Precio[3];
            if (corte == ("Buzz")) precio = Precio[4];
            if (corte == ("Militar")) precio = Precio[5];
            if (corte == ("High Mullet")) precio = Precio[6];
            if (corte == ("Mid Mullet")) precio = Precio[7];
            if (corte == ("Undercut")) precio = Precio[8];

            vPrecio += precio;

            lblprecio.Text = precio.ToString("c");



        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // validacion

            int LaHora = Convert.ToInt16(cbohora.Text);

            if (cbopersonal.Text == "Carlos" & Carlos == 8)
            {
                MessageBox.Show("Cupo de este barbero esta lleno Favor seleccione otro ...!!!");
                cbopersonal.Text = "";
            }

            else if (cbopersonal.Text == "Carlos" & LaHora < 11)
            {
                MessageBox.Show("Este barbero no labora a esta hora Favor seleccione otro ...!!!");
                cbopersonal.Text = "";
            }

            if (cbopersonal.Text == "Samuel" & Samuel == 8)
            {
                MessageBox.Show("Cupo de este barbero esta lleno Favor seleccione otro ...!!!");
                cbopersonal.Text = "";
            }

            else if (cbopersonal.Text == "Samuel" & LaHora > 10 & LaHora < 14)
            {
                MessageBox.Show("Este barbero no labora a esta hora Favor seleccione otro ...!!!");
                cbopersonal.Text = "";
            }

            if (cbopersonal.Text == "Enger" & Enger == 8)
            {
                MessageBox.Show("Cupo de este barbero esta lleno Favor seleccione otro ...!!!");
                cbopersonal.Text = "";
            }


            else if (cbopersonal.Text == "Enger" & LaHora > 13 & LaHora < 18)
            {
                MessageBox.Show("Este barbero no labora a esta hora Favor seleccione otro ...!!!");
                cbopersonal.Text = "";
            }

            if (cbopersonal.Text == "Luis" & Luis == 8)
            {
                MessageBox.Show("Cupo de este barbero esta lleno Favor seleccione otro ...!!!");
                cbopersonal.Text = "";
            }


            else if (cbopersonal.Text == "Luis" & LaHora > 17 & LaHora < 22)
            {
                MessageBox.Show("Este barbero no labora a esta hora Favor seleccione otro ...!!!");
                cbopersonal.Text = "";
            }

            if (txtnombre.Text == "")
            { MessageBox.Show("Agrega tu nombre...!!!"); }
            else if (cbocortes.SelectedIndex == -1)
                MessageBox.Show("Seleccione su corte...!!!");
            else if (cbopersonal.SelectedIndex == -1)
                MessageBox.Show("Seleccione el barbero...!!!");
            else if (cbohora.SelectedIndex == -1)
                MessageBox.Show("Seleccione hora para su cita...!!!");
            else if (cbomin.SelectedIndex == -1)
                MessageBox.Show("Seleccione minuto de su cita...!!!");
            else if (cbomin.SelectedIndex == -1)
                MessageBox.Show("Seleccione minuto de su cita...!!!");
            else if (cbomin.SelectedIndex == -1)
                MessageBox.Show("Seleccione minuto de su cita...!!!");
            else if (cbomin.SelectedIndex == -1)
                MessageBox.Show("Seleccione minuto de su cita...!!!");

            else
            {
                //capturando datos 
                string corte = cbocortes.Text;
                string personal = cbopersonal.Text;
                LblNombre.Text = "Gracias por elegirnos señor " + txtnombre.Text + " su cita fue registrada con exito!";
                LblBarbero.Text = cbopersonal.Text + " estara esperandolo a la fecha y hora a continuacion...";
                Lbfecha.Text = "Fecha: " + Calendar.Text + "        Hora: " + cbohora.Text + ":" + cbomin.Text;
                Lbprecio.Text = "Valor de pago realizado: " + lblprecio.Text;
                btnreiniciar.Text = "Hacer otra cita";
                btnRegistrar.Visible = false;
                btnRegistrar.Enabled = false;

            }


        }


        private void btnMenor_Click(object sender, EventArgs e)
        {
            double descuento = precio * 0.75;
            lblprecio.Text = descuento.ToString("C");
            btnMenor.Enabled = false;
            btnMenor.Visible = false;
            btnmayor.Enabled = true;
            btnmayor.Visible = true;
        }

        private void txtedad_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblprecio_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void cbopersonal_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> Barberos = new List<string>() { "Carlos", "Samuel", "Enger", "Luis" };

            if (Barberos[0] == cbopersonal.Text)
            {
                Carlos += 1;
            }

            if (Barberos[1] == cbopersonal.Text)
            {
                Samuel += 1;
            }

            if (Barberos[2] == cbopersonal.Text)
            {
                Enger += 1;
            }

            if (Barberos[3] == cbopersonal.Text)
            {
                Luis += 1;
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtnombre.Text = "";
            cbocortes.SelectedIndex = -1;
            cbopersonal.SelectedIndex = -1;
            cbohora.SelectedIndex = -1;
            cbomin.SelectedIndex = -1;
            LblNombre.Text = "";
            LblBarbero.Text = "";
            Lbfecha.Text = "";
            Lbprecio.Text = "";

            while (btnreiniciar.Text == "Hacer otra cita")
            {
                btnreiniciar.Text = "Reiniciar";
                btnRegistrar.Enabled = true;
                btnRegistrar.Visible = true;
            }

        }

        private void lblfecha_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnmayor_Click(object sender, EventArgs e)
        {
            lblprecio.Text = Convert.ToString(vPrecio);
        }

        private void lblfecha_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1_TextChanged(sender, e);
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblNombre_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double descuento = precio * 1.25;
            lblprecio.Text = vPrecio.ToString("C");
            btnMenor.Enabled = true;
            btnMenor.Visible = true;
            btnmayor.Enabled = false;
            btnmayor.Visible = false;

        }
    }
}