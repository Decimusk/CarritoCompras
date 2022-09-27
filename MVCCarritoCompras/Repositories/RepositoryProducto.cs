using MVCCarritoCompras.Data;
using MVCCarritoCompras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCarritoCompras.Repositories
{
    public class RepositoryProducto
    {
        ContextoProducto contexto;
        public RepositoryProducto()
        {
            this.contexto = new ContextoProducto();
        }
        public List<Producto> GetProductos()
        {
            var consulta = from datos in contexto.Productos select datos;
            return consulta.ToList();
        }

        public List<Producto> BuscarProductos(List<int> id)
        {
            var consulta = from datos in contexto.Productos where id.Contains(datos.IdProducto) select datos;
            return consulta.ToList();
        }
    }
}