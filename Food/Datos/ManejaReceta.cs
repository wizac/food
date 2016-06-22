using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaces;
using Clases;
using System.Data;
using System.Threading.Tasks;

namespace Datos
{
   public class ManejaReceta : iMetodos
    {
       iBdMetodos manager;

       public ManejaReceta()
       {
           manager=new BdMetodos();
       }

       public void Alta(IEntidad entidad)
        {
            clsReceta rec = (clsReceta)entidad;
            try
            {
                manager.ejecutar("Insert into receta(idreceta,nombre,desripcion,rating,pendiente,tiempo,foto,porciones,idusuario,idcatcom) values("+rec.Id+",'"+rec.Nombre+"','"+rec.Descripcion+"',"+rec.Rating+","+rec.Pendiente+","+rec.Tiempo+","+rec.Imagen+","+rec.Porciones+","+rec.Idusuario+","+rec.Catcom+")");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       public void Baja(IEntidad entidad)
        {
            clsReceta rec = (clsReceta)entidad;
            try
            {
                manager.ejecutar("update receta set activo=0 where idreceta=" + rec.Id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

       public void Modificacion(IEntidad entidad)
        {
            clsReceta rec = (clsReceta)entidad;
            try
            {
                manager.ejecutar("update receta set nombre='"+rec.Nombre+"', descripcion='"+rec.Descripcion+"',rating="+rec.Rating+", tiempo="+rec.Tiempo+", foto"+rec.Imagen+", porciones="+rec.Porciones+", idcatcom="+rec.Catcom+" where idreceta=" + rec.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       public IEntidad buscaPorId(int id)
        {
            DataTable aux = new DataTable();
            clsReceta rec = new clsReceta();
            try
            {
                //cuitcliente,numerofactura,tipofactura,razonsocial,numeroterminal,total,fecha,idusuario,cliente,pagoefectivo,pagotarjeta
                aux = manager.consultar("select * from receta where idreceta=" + id + " and activo=1");
                rec.Id = Convert.ToInt32(aux.Rows[0]["idreceta"]);
                rec.Nombre = aux.Rows[0]["nombre"].ToString();
                rec.Descripcion = aux.Rows[0]["descripcion"].ToString();
                rec.Rating = Convert.ToInt32(aux.Rows[0]["rating"]);
                rec.Pendiente = Convert.ToInt32(aux.Rows[0]["pendiente"]);
                rec.Tiempo =aux.Rows[0]["tiempo"].ToString();
              //  rec.Imagen =Convert.ToByte[](aux.Rows[0]["imagen"]); averiguar el manejo de imagenes
                rec.Idusuario = Convert.ToInt32(aux.Rows[0]["idusuario"]);
                rec.Catcom = Convert.ToInt32(aux.Rows[0]["idcatcom"]);



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

            aux = manager.consultar("select * from receta");

            return aux;
        }

       public void dardealta(IEntidad entidad)
        {
            clsReceta rec = (clsReceta)entidad;
            try
            {
                manager.ejecutar("update receta set pendiente=1 where idreceta=" + rec.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


      
    }
}
