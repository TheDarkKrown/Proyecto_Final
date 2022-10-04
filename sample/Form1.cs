using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample
{
    public partial class Menu : Form
    {
        double precio = 0;
        public Menu()
        {
            InitializeComponent();
        }

        bool Afir = false;
        private void Menu_Load(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Today.Date.ToString("d");
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
            List<Double> Precio = new List<Double>() {100, 120, 130, 110, 90, 80, 70, 60, 140};
     
               
                if (corte == ("High Fade")) precio = Precio[0];
                if (corte == ("Mid Fade")) precio = Precio[1];
                if (corte == ("Low Fade")) precio = Precio[2];
                if (corte == ("Taper Fade")) precio = Precio[3];
                if (corte == ("Buzz")) precio = Precio[4];
                if (corte == ("Militar")) precio = Precio[5];
                if (corte == ("High Mullet")) precio = Precio[6];
                if (corte == ("Mid Mullet")) precio = Precio[7];
                if (corte == ("Undercut")) precio = Precio[8];

                lblprecio.Text = precio.ToString("c");



            }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Afir = true;
            // validacion
            if (txtnombre.Text == "")
            { MessageBox.Show("Agrega tu nombre...!!!"); }
            if (cbocortes.SelectedIndex == -1)
                MessageBox.Show("Seleccione su corte...!!!");
            if (cbopersonal.SelectedIndex == -1)
                MessageBox.Show("Seleccione el barbero...!!!");
            else
            {
                //capturando datos 
                string corte = cbocortes.Text;
                string personal = cbopersonal.Text;

            }

        }

        private void btnMenor_Click(object sender, EventArgs e)
        {
            double descuento = precio * 0.75;
            lblprecio.Text = descuento.ToString("C");
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
            //list = new string[10];
            
            //label7.Text = dateTimePicker1.Text;
            //bool selected = false;
            //for (int i =0; i < list.Length; i++)
            //{
            //    if (list[i] == )
            }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombre = Convert.ToString(txtnombre), barbero = Convert.ToString(cbopersonal);
            string corte = Convert.ToString(cbocortes), Fecha = Convert.ToString(dateTimePicker1);
            string hora = Convert.ToString(cbohora), minuto = Convert.ToString(cbomin);

            if (nombre != "" & barbero != "" & corte != "" & Fecha != "" & hora != "" & minuto != "")
            {
                Console.WriteLine("Su cita se guardo para " + hora + ":" + minuto + " " + Fecha);
            }

            DateTime horaT = Convert.ToDateTime(hora + ":" + minuto);
           
            lbtabla.Items.Add(nombre + barbero + corte + Fecha + horaT);
            
               // if (Afir == true) { c.Show(); }

            lbtabla.Show();

        }


        private void cbopersonal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {

        }
    }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
  
        //}

        //private void label10_Click(object sender, EventArgs e)
        //{

        //}
    }
