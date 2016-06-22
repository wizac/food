using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class clsFavoritos
    {
        private int idusu;

        public int Idusu
        {
            get { return idusu; }
            set { idusu = value; }
        }
        private int idrec;

        public int Idrec
        {
            get { return idrec; }
            set { idrec = value; }
        }
        public clsFavoritos()
        {

        }
        public clsFavoritos (int idus,int idre )
        {
           idusu=idus;
            idrec=idre;
        }
    }

}
