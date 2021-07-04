﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Dominio
{
    public class Producto
    {
        public long EAN { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public TipoProducto TipoProducto { get; set; }
        public Marca Marca { get; set; }
        public Proveedor Proveedor { get; set; }
        public string FechaCompra { get; set; }
        public string FechaVencimiento { get; set; }
        public decimal Costo { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public bool Estado { get; set; }
    }
}
