using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class clsSigue
    {
        private int sigue;

        public int Sigue
        {
            get { return sigue; }
            set { sigue = value; }
        }
        private int seguido;

        public int Seguido
        {
            get { return seguido; }
            set { seguido = value; }
        }

        public clsSigue()
        {

        }
        public clsSigue(int sigu,int segui)
        {
            sigue = sigu;
            seguido = segui;
        }
    }
}
