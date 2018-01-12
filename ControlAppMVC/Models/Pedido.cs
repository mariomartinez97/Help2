using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlAppMVC.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
    }
}