using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class clsUmedida
    {
        private int idumedida;

        public int Idumedida
        {
            get { return idumedida; }
            set { idumedida = value; }
        }
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public clsUmedida()
        {

        }
        public clsUmedida(int idu,string desc)
        {
            idumedida = idu;
            descripcion = desc;
        }
    }
}
