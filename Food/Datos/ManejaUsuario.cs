using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Interfaces;
using Clases;
using System.Threading.Tasks;

namespace Datos
{
     public class ManejaUsuario: iMetodos
    {
         iBdMetodos manager;

       public ManejaUsuario()
       {
           manager=new BdMetodos();
       }
        public void Alta(IEntidad entidad)
        {
            clsUsuario rec = (clsUsuario)entidad;
            try
            {
                manager.ejecutar("Insert into usuario(nombre,perfil,foto,usser,pass,fechainicio,nivelseg) values('" + rec.Nombre + "','" + rec.Descripcion + "','" + rec.Foto + "','" + rec.User + "','"+rec.Pass+"','"+rec.Fecha+"','"+rec.Nivel+"')");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Baja(IEntidad entidad)
        {
            clsUsuario rec = (clsUsuario)entidad;
            try
            {
                manager.ejecutar("update usuario set activo=0 where id=" + rec.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificacion(IEntidad entidad)
        {
            clsUsuario rec = (clsUsuario)entidad;
            try
            {                                                                       
                manager.ejecutar("update usuario set nombre='" + rec.Nombre + "', perfil='" + rec.Descripcion + "', foto='" + rec.Foto + "',usser='"+rec.User+"',pass='"+rec.Pass+"' where id=" + rec.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEntidad buscaPorId(int id)
        {

            DataTable aux = new DataTable();
            clsUsuario rec = new clsUsuario();
            try
            {
                //cuitcliente,numerofactura,tipofactura,razonsocial,numeroterminal,total,fecha,idusuario,cliente,pagoefectivo,pagotarjeta
                aux = manager.consultar("select * from usuario where idusuario=" + id + " and activo=1");
                rec.Id = Convert.ToInt32(aux.Rows[0]["idusuario"]);
                rec.Nombre = aux.Rows[0]["nombre"].ToString();
                rec.User = aux.Rows[0]["usser"].ToString();
                rec.Pass = aux.Rows[0]["pass"].ToString();
                rec.Fecha = Convert.ToDateTime(aux.Rows[0]["fechainicio"]);
                rec.Nivel = aux.Rows[0]["nivelseg"].ToString();
                //  rec.Imagen =Convert.ToByte[](aux.Rows[0]["imagen"]); averiguar el manejo de imagenes



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

            aux = manager.consultar("select * from usuario");

            return aux;
        }
    }
}
