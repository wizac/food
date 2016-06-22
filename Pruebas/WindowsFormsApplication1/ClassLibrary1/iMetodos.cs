using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface iMetodos
    {
        void Alta(IEntidad entidad);
        void Baja(IEntidad entidad);
        void Modificacion(IEntidad entidad);
        IEntidad buscaPorId(int id);
        /// <summary>
        /// Una variable que permite saber que traer de la base para no cargar una lista con todos los registros solo una parte
        /// </summary>
        /// <param name="pagina"></param>
        /// <returns></returns>
        DataTable Todo(int pagina);
    }
}
