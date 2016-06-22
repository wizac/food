using System;
using System.Data.SqlTypes;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class imagen
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private byte[] foto;

        public byte[] Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        public imagen()
        {
        }

        private System.Data.SqlTypes.SqlFileStream filestream;

        public System.Data.SqlTypes.SqlFileStream Filestream
        {
            get { return filestream; }
            set { filestream = value; }
        }



        private System.Data.SqlTypes.SqlBytes bytes;

        public System.Data.SqlTypes.SqlBytes Bytes
        {
            get { return bytes; }
            set { bytes = value; }
        } 
    }
}
