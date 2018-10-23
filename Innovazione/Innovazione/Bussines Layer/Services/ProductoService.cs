using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Innovazione.Bussines_Layer;
using Innovazione.DataLayer;

namespace Innovazione.Bussines_Layer.Services
{
    public class ProductoService
    {
        private ProductoDao oProductoDao;
        public ProductoService()
        {
            oProductoDao = new ProductoDao();
        }

        public IList<Producto> getAll()
        {
            return oProductoDao.getAll();
        }

        public IList<Producto> getByFilters (List<object> @params)
        {
            return oProductoDao.getByFilters(@params);
        }

        public bool crearProducto(Producto oProducto)
        {
            return oProductoDao.create(oProducto);
        }

        public bool updateProducto (Producto oProducto)
        {
            return oProductoDao.update(oProducto);
        }
    }
}
