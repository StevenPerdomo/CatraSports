using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatraSports.BL
{
    public class ProductosBL
    {
        public List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Cinta Kinesiológica";
            producto1.Precio = 150;

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Cuerda para saltar";
            producto2.Precio = 100;

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Playera deportiva para hombre";
            producto3.Precio = 200;

            var producto4 = new Producto();
            producto4.Id = 4;
            producto4.Descripcion = "Playera deportiva para mujer";
            producto4.Precio = 220;

            var listadeProductos = new List<Producto>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);
            listadeProductos.Add(producto4);

            return listadeProductos;
        }
    }
}
