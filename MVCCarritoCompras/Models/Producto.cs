using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCCarritoCompras.Models
{
    [Table("Productos")]
    public class Producto
    {
       [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.None)]
       [Column("IdProducto")]
       public int IdProducto { get; set; }
       [Column("Nombre")]
       public String Nombre { get; set; }
       [Column("Precio")]
       public int Precio { get; set; }
       [Column("Imagen")]
       public String Imagen { get; set; }
    }
}