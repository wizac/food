using System;
using System.Collections.Generic;
using System.Linq;
using Interfaces;
using System.Text;
using System.Data.SqlClient;
using datos;
using System.Data;
using Logica;


namespace datos
{
    public class Class1 : iMetodos
    {
        iBdMetodos manager;

        public Class1()
        {
            manager = new BdMetodos();
        }


        void iMetodos.Alta(IEntidad entidad)
        {
            throw new NotImplementedException();
        }

        void iMetodos.Baja(IEntidad entidad)
        {
            throw new NotImplementedException();
        }

        void iMetodos.Modificacion(IEntidad entidad)
        {
            throw new NotImplementedException();
        }

        IEntidad iMetodos.buscaPorId(int id)
        {
            throw new NotImplementedException();
        }

        System.Data.DataTable iMetodos.Todo(int pagina)
        {
            throw new NotImplementedException();
        }

        public void subirimagen(imagen img)
        {
            imagen asd = img;
            manager.ejecutar("insert into pru(nombre,foto) values('otra cosa','" + asd.Foto + "')");
        }

        public DataTable traerImagen()
        {
            byte[] x;
            imagen pls = new imagen();
            DataTable asd= new DataTable();
            
            asd= manager.consultar("select * from pru");
            pls.Foto =(byte[])asd.Rows[0]["foto"];
            
           
            return asd;
        }
    }
}


