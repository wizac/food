using System;
using System.Collections.Generic;
using System.Linq;
using Interfaces;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class clsUsuario: IEntidad
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
        private string user;

        public string User
        {
            get { return user; }
            set { user = value; }
        }
        private string pass;

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private string nivel;

        public string Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }
        private int activo;

        public int Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        public clsUsuario()
        {

        }

        public clsUsuario(int id,string nombre,string desc,Byte[] foto,string user,string pass,DateTime feha,string nivel,int activo)
        {
           
            this.id=id;
            this.nombre = nombre;
            descripcion = desc;
            this.foto = foto;
            this.user = user;
            this.pass = pass;
            fecha = feha;
            this.nivel = nivel;
            this.activo = activo;
        }
    }
}
