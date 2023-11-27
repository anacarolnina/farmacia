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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void salir_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(usuarioo.Text) ||
                string.IsNullOrEmpty(contraseñaa.Text) ||
                string.IsNullOrEmpty(textBox6.Text) ||
                string.IsNullOrEmpty(textBox5.Text) ||
                string.IsNullOrEmpty(textBox4.Text) ||
                string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text))
            {

                MessageBox.Show("Todos los campos son obligatorios. Por favor, llene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Registro exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                Form4 productos = new Form4();
                productos.Show();
            }

        }

        private void registro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 forma3 = new Form3();
            forma3.Show();
            Hide();
        }

        private void entrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
