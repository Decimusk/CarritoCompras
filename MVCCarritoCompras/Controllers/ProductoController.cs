using MVCCarritoCompras.Models;
using MVCCarritoCompras.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCarritoCompras.Controllers
{
    public class ProductoController : Controller
    {
        RepositoryProducto repo;
        public ProductoController()
        {
            repo = new RepositoryProducto();
        }
        // GET: Producto
        public ActionResult ListaProductos(int? id)
        {
            if(id != null)
            {
                List<int> codigosProductos;
                if (Session["PRODUCTOS"] == null)
                {
                    codigosProductos = new List<int>();
                }
                else
                {
                    codigosProductos = Session["PRODUCTOS"] as List<int>;
                }
                codigosProductos.Add(id.Value);
                Session["PRODUCTOS"] = codigosProductos;
                ViewBag.Mensaje = "Productos en el carrito: " + codigosProductos.Count();
            }
            ViewBag.Carrito = Session["PRODUCTOS"];
            List<Producto> prod = this.repo.GetProductos();
            return View(prod);
        }

        public ActionResult ProductosCarrito(int? id)
        {
            if(id != null)
            {
                List<int> lista = (List<int>)Session["PRODUCTOS"];
                lista.Remove(id.GetValueOrDefault());
                if (lista.Count() == 0)
                {
                    Session["PRODUCTOS"] = null;
                }
                else
                {
                    Session["PRODUCTOS"] = lista;
                }
            }
            if (Session["PRODUCTOS"] == null)
            {
                return View();
            }
            else
            {
                List<int> lista = (List<int>)Session["PRODUCTOS"];
                List<Producto> prod = this.repo.BuscarProductos(lista);
                return View(prod);
            }
        }
    }
}