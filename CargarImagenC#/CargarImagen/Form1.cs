using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CargarImagen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void cargar()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = Datos.Cargar();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = 100;
                DataRowView rows = row.DataBoundItem as DataRowView;
                row.Cells["Foto"].Value = ConvertImage.ByteArrayToImage((byte[])rows["Foto"]); 
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Archivo JPG|*.jpg";

            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(file.FileName);
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Datos.Insert(txtnombre.Text,txtapellido.Text,ConvertImage.ImageToByteArray(pictureBox1.Image));
            cargar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
