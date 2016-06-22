using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;
using System.Windows.Forms;

namespace Vista
{
    public partial class recetaViewer : UserControl
    {
        private string receta;

        public string Receta
        {
            get { return receta; }
            set { receta = value; }
        }
        private string tipocom;

        public string Tipocom
        {
            get { return tipocom; }
            set { tipocom = value; }
        }
        private string desc;

        public string Desc
        {
            get { return desc; }
            set { desc = value; }
        }
        private Bitmap img;

        public Bitmap Img
        {
            get { return img; }
            set { img = value; }
        }
        public recetaViewer(string nombre,string descrip,string tipo,Bitmap im)
        {
            InitializeComponent();
            Receta = nombre;
            desc = descrip;
            tipocom = tipo;
            img = im;
            this.Visible = false;
            
        }

        private void recetaViewer_MouseClick(object sender, MouseEventArgs e)
        {
           //funcionalidad para Entrar en la receta
        }

        private void recetaViewer_Load(object sender, EventArgs e)
        {
            if (receta!=null)
            {
                this.Visible = true;
                lbldesc.Text = desc;
                lblNombreRec.Text = receta;
                lbltipocom.Text = tipocom;
                pbReceta.Image = img;
            }
        }
    }
}
