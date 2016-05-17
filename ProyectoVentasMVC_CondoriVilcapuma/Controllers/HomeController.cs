using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Modelo;

namespace ProyectoVentasMVC_CondoriVilcapuma
{
   public class HomeController : Controller
    {
        private CATEGORIA categoria = new CATEGORIA();//instancia la clase categoria
        private PRODUCTO producto = new PRODUCTO();//instancia la clase producto
        private USUARIO usuario = new USUARIO();//instancia la clase usuario
        private TIPO_USUARIO tipousuario = new TIPO_USUARIO();//instancia la clase tipo usuario
        private PEDIDO pedido = new PEDIDO();//instancia la clase pedido
        //GET: Home

        //CATEGORIAS ok
        public ActionResult Index()
        {
            return View(categoria.Listar());
        }

        public ActionResult Ver(int id)
        {
            return View(categoria.Obtener(id));
        }

        //PRODUCTOS ok
            public ActionResult Productos()
        {
            return View(producto.Listar());
        }

        public ActionResult VerProducto(int id)
        {
            return View(producto.Obtener(id));
        }

        //USUARIO ok
        public ActionResult Usuario()
        {
            return View(usuario.Listar());
        }

        public ActionResult VerUsuario(String id)
        {
            return View(usuario.Obtener(id));
        }

        //TIPO USUARIO ok
            public ActionResult TipoUsuario()
        {
            return View(tipousuario.Listar());
        }

        public ActionResult VerTipoUuario(int id)
        {
            return View(tipousuario.Obtener(id));
        }

        //PEDIDO ok
            public ActionResult Pedido()
        {
            return View(pedido.Listar());
        }

        public ActionResult VerPedido(int id)
        {
            return View(pedido.Obtener(id));
        }


    }
}
