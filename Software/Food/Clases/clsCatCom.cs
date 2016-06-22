using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaces;
using System.Threading.Tasks;

namespace Clases
{
    public class clsCatCom: IEntidad
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string desc;

        public string Desc
        {
            get { return desc; }
            set { desc = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public clsCatCom()
        {

        }
        public clsCatCom(int id,string nom,string desc)
        {
            this.id = id;
            nombre = nom;
            this.desc = desc;
        }

    }
}