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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void añadir_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow renglon = (DataGridViewRow)dataGridView1.Rows[0].Clone();

                renglon.Cells[0].Value = textBox1.Text;
                renglon.Cells[1].Value = textBox2.Text;
                renglon.Cells[2].Value = textBox3.Text;
                renglon.Cells[3].Value = textBox4.Text;
                renglon.Cells[4].Value = textBox5.Text;
                renglon.Cells[5].Value = textBox6.Text;
                renglon.Cells[6].Value = textBox7.Text;
                renglon.Cells[7].Value = textBox8.Text;

                dataGridView1.Rows.Add(renglon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregando producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Deseo eliminar el registro";
            string titulo = "eliminando el registro";

            if (!(dataGridView1.CurrentRow is null))
            {
                if (MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Estudiante Eliminado",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("debes seleccionar un rengoln", "Eliminado Estudiante",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("selecciona un renglon", "correciones", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells["codigos"].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells["dosis"].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells["precio"].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells["nombregenerico"].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells["laboratorio"].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells["recetamedica"].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells["tipodemedicamento"].Value.ToString();
                textBox8.Text = dataGridView1.CurrentRow.Cells["viaadministracion"].Value.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
