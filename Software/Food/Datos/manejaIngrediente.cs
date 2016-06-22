using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaces;
using Clases;
using System.Threading.Tasks;
using System.Data;

namespace Datos
{
     public class ManejaIngrediente: iMetodos
    {
        
       iBdMetodos manager;

       public ManejaIngrediente()
       {
           manager=new BdMetodos();
       }

       public void Alta(IEntidad entidad)
        {
            clsIngrediente rec = (clsIngrediente)entidad;
            try
            {
                manager.ejecutar("Insert into ingrediente(idingrediente,nombre,imagen,descripcion) values("+rec.Id+",'"+rec.Nombre+"','"+rec.Foto+"','"+rec.Descripcion+"')");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       public void Baja(IEntidad entidad)
        {
            clsIngrediente rec = (clsIngrediente)entidad;
            try
            {
                manager.ejecutar("update ingrediente set activo=0 where id=" + rec.Id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

       public void Modificacion(IEntidad entidad)
        {
            clsIngrediente rec = (clsIngrediente)entidad;
            try
            {
                manager.ejecutar("update ingrediente set nombre='"+rec.Nombre+"', descripcion='"+rec.Descripcion+"', foto='"+rec.Foto+"' where id=" + rec.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       public IEntidad buscaPorId(int id)
        {
            DataTable aux = new DataTable();
            clsIngrediente rec = new clsIngrediente();
            try
            {
                //cuitcliente,numerofactura,tipofactura,razonsocial,numeroterminal,total,fecha,idusuario,cliente,pagoefectivo,pagotarjeta
                aux = manager.consultar("select * from ingrediente where idingrediente=" + id + " and activo=1");
                rec.Id = Convert.ToInt32(aux.Rows[0]["idingrediente"]);
                rec.Nombre = aux.Rows[0]["nombre"].ToString();
                rec.Descripcion = aux.Rows[0]["descripcion"].ToString();
              //  rec.Imagen =Convert.ToByte[](aux.Rows[0]["imagen"]); averiguar el manejo de imagenes
                


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rec;
        }

       public System.Data.DataTable Todo(int pagina)
        {
            DataTable aux = new DataTable();

            aux = manager.consultar("select * from ingrediente");

            return aux;
        }

       


      
    }
    
}
