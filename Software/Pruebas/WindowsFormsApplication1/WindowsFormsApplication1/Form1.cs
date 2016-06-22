using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using datos;
using interfaces;
using Logica;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Archivo JPG|*.jpg";

            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(file.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            imagen asd = new imagen();

            asd.Nombre = textBox1.Text;
            asd.Foto = ConvertImage.ImageToByteArray(pictureBox1.Image);

            datos.Class1 Sub = new datos.Class1();

            Sub.subirimagen(asd);

            MessageBox.Show("subido");
           

           

            

            
        }

        private void button3_Click(object sender, EventArgs e)
        {


            imagen asd = new imagen();
            DataTable fuck = new DataTable();
            byte[] x;


            datos.Class1 Sub = new datos.Class1();

            fuck = Sub.traerImagen();

            MessageBox.Show(fuck.Columns.Count.ToString());
            foreach (DataRow row in fuck.Rows)
            {
                // Get the byte array from image file
                byte[] imgBytes = (byte[]) row["foto"];
                  // If you want convert to a bitmap file
                 TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
                 Bitmap MyBitmap = (Bitmap)tc.ConvertFrom(imgBytes);
                 string imgString = Convert.ToBase64String(imgBytes);
               //  imgLogoCompany.Src = String.Format("data:image/Bmp;base64,{0}\"", imgString);
                 pictureBox1.Image = MyBitmap;
            }
        }
       
    }
}
