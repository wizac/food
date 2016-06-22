using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaces;
using System.Threading.Tasks;

namespace Clases
{
    public class clsReceta :IEntidad
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
        private int rating;

        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }
        private int pendiente;

        public int Pendiente
        {
            get { return pendiente; }
            set { pendiente = value; }
        }
        private string tiempo;

        public string Tiempo
        {
            get { return tiempo; }
            set { tiempo = value; }
        }
        private int porciones;

        public int Porciones
        {
            get { return porciones; }
            set { porciones = value; }
        }

        private int idusuario;

        public int Idusuario
        {
            get { return idusuario; }
            set { idusuario = value; }
        }

        private int catcom;

        public int Catcom
        {
            get { return catcom; }
            set { catcom = value; }
        }
        private int activo;

        public int Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        private Byte[] imagen;
        public Byte[] Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }

        public clsReceta()
        {

        }
        public clsReceta(int id,string nombre,string desc,int rating,int pend,string tiempo,int porciones,int activo,int idusu,int idcatcom,Byte[] foto)
        {
            this.id = id;
            this.nombre = nombre;
            this.imagen = foto;
            descripcion = desc;
            this.rating = rating;
            pendiente = pend;
            this.tiempo = tiempo;
            this.porciones = porciones;
            this.activo = activo;
            idusuario = idusu;
            catcom = idcatcom;
        }
    }
}
