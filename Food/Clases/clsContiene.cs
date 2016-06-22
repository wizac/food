using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class clsContiene
    {
        private int idreceta;

        public int Idreceta
        {
            get { return idreceta; }
            set { idreceta = value; }
        }
        private int idingrediente;

        public int Idingrediente
        {
            get { return idingrediente; }
            set { idingrediente = value; }
        }
        private float cantidad;

        public float Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        private int idumedida;

        public int Idumedida
        {
            get { return idumedida; }
            set { idumedida = value; }
        }
        public clsContiene ()
        {

        }

        public clsContiene(int idrec,int iding,float cant,int idu)
        {
            this.idingrediente = iding;
            this.idreceta = idrec;
            this.idumedida = idu;
            this.cantidad = cant;
        }
        
    }
}
