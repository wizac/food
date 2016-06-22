using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Interfaces
{
    
   public interface iBdMetodos
    {
        int ejecutar(String sql);
        DataTable consultar(string sql);

    }
}
    

