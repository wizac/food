using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class clsUsuarioVoto
    {
        private int idUsuario;

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
        private int idReceta;

        public int IdReceta
        {
            get { return idReceta; }
            set { idReceta = value; }
        }
        private int voto;

        public int Voto
        {
            get { return voto; }
            set { voto = value; }
        }

        public clsUsuarioVoto()
        {

        }
        public clsUsuarioVoto(int idusu,int idrec,int vot)
        {
            idUsuario = idusu;
            idReceta = idrec;
            voto = vot;

        }
    }
}
