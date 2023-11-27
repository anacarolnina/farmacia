using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace farmacia
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void correo_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void sexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iniciosesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 usuario = new Form2();
            usuario.Show();
            Hide();

        }

        private void registrarme_Click(object sender, EventArgs e)
        {
         
            if (string.IsNullOrEmpty(nombre.Text) ||
                string.IsNullOrEmpty(apellidos.Text) ||
                string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(email.Text) ||
                string.IsNullOrEmpty(telefono.Text) ||
                string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(ocupacion.Text))
            {
                MessageBox.Show("Asegurate de que hayas llenado todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("bien hecho", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form4 productos = new Form4();
                productos.Show();
                Hide();

            }

        }
    }
}
