using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista;

namespace Vista
{
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
            

        }
        Vista.recetaViewer prueba = new Vista.recetaViewer("text","text","text");
        private void button1_Click(object sender, EventArgs e)
        {
           // this.Close();

            prueba.Location = new Point(100, 100);
            this.Controls.Add(prueba);
            

        }
    }
}
