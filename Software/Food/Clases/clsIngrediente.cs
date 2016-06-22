using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaces;
using System.Threading.Tasks;

namespace Clases
{
    public class clsIngrediente: IEntidad
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private Byte[] foto;

        public Byte[] Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        public clsIngrediente ()
        {

        }
        public clsIngrediente (int id, string nombre,string desc,Byte[] foto)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = desc;
            this.foto = foto;
        }
        
    }
}
