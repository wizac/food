using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaces;
using System.Data;
using Clases;
using System.Threading.Tasks;

namespace Datos
{
    public class ManejaCatcom: iMetodos
    {
         iBdMetodos manager;

       public ManejaCatcom()
       {
           manager=new BdMetodos();
       }
        public void Alta(IEntidad entidad)
        {

            clsCatCom rec = (clsCatCom)entidad;
            try
            {
                manager.ejecutar("Insert into catcomida(nombre,descripcion) values('"+rec.Nombre+ "','" + rec.Desc + "')");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Baja(IEntidad entidad)
        {
            clsCatCom rec = (clsCatCom)entidad;
            try
            {
                manager.ejecutar("delete catcomida where idcatcomida="+rec.Id+")");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificacion(IEntidad entidad)
        {

            clsCatCom rec = (clsCatCom)entidad;
            try
            {
                manager.ejecutar("update catcomida set nombre='"+rec.Nombre+"',descripcion='"+rec.Desc+"' where id=" + rec.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEntidad buscaPorId(int id)
        {
            DataTable aux = new DataTable();
            clsCatCom rec = new clsCatCom();
            try
            {
                aux = manager.consultar("select * from catcomida where idcatcomida=" + id );
                rec.Id = Convert.ToInt32(aux.Rows[0]["idcatcomida"]);
                rec.Nombre = aux.Rows[0]["nombre"].ToString();
                rec.Nombre = aux.Rows[0]["descripcion"].ToString();
                


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rec;
        
        }

        public DataTable Todo(int pagina)
        {
              DataTable aux = new DataTable();

            aux = manager.consultar("select * from catcomida");

            return aux;
        }
        
    }
}


