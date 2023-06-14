using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio.Interfaces.Repositorio;
using System.Threading.Tasks;
using Dominio.Modelo;
using Xunit;
using NUnit.Framework;
using System.Globalization;

namespace DomaintestUnit
{
    public class CateogoriaTest
    {
        [Fact]
        public void Categoria_Properties_InitializedCorrectly() {

            //Arranque
            int CategoriaId = 1;
            string NombreCategoria = "Granos";


            //Act
            ClsCategoriaDom clsCategoria = new ClsCategoriaDom
            {

                CategoriaID = CategoriaId,
                NombreCateg = NombreCategoria
            };


            //Assert
            Assert.Equals(CategoriaId, clsCategoria.CategoriaID);
            Assert.Equals(NombreCategoria, clsCategoria.NombreCateg);
        }
    }
    public class ProductoTest {

        [Fact]
        public void Producto_Properties_InitializedCorrectly() {

            //Arranque
            int ProductId = 1;
            string Articulo = "Arroz Blanquita la suprema";
            int CategoriaId = 1;
            double valor = 1200;

            //Act
            ClsProducotDom producotDom = new ClsProducotDom
            {

                ProductoID = ProductId,
                CateogriaID = CategoriaId,
                Descripcion = Articulo,
                Precio = valor
            };

            //Assert
            Assert.Equals(ProductId, producotDom.ProductoID);
            Assert.Equals(CategoriaId, producotDom.CateogriaID);
            Assert.Equals(Articulo, producotDom.Descripcion);
            Assert.Equals(valor, producotDom.Precio);
        }
    }
    public class EmpleadoTest {

        [Fact]
        public void Empleado_Properties_InitializedCorrectly() {

            //Arranque
            int EmpleadoId = 1;
            string Ndoc_Empleado = "1087194382";
            string Nombre = "Nestor Ivan Maquilon";
            string telefono = "1087194382";
            string Direccion = "calle 60 #97bis-46";

            //Act
            ClsEmpleadoDom Empleado = new ClsEmpleadoDom
            {

                EmpleadoID = EmpleadoId,
                DocumentoEmpleado = Ndoc_Empleado,
                NombreEmpleado = Nombre,
                DireccionEmpleado = Direccion,
                TelefonoEmpleado = telefono
            };

            //Assert
            Assert.Equals(EmpleadoId, Empleado.EmpleadoID);
            Assert.Equals(Ndoc_Empleado, Empleado.DocumentoEmpleado);
            Assert.Equals(Nombre, Empleado.NombreEmpleado);
            Assert.Equals(telefono, Empleado.TelefonoEmpleado);
            Assert.Equals(Direccion, Empleado.DireccionEmpleado);
        }
    }
    public class PedidoTest {

        [Fact]
        public void Pedido_Properties_InitializedCorrectly() {

            //Arranque
            int pedidoid = 1;
            string descripcion = "Bulto de Arroz La Suprema";
            int proveedorid = 1;
            int cantidad = 1;
            string estado = "Pendiente";
            DateTime FechaPedido = DateTime.Now;

            //Act
            ClsPedidoDom pedido = new ClsPedidoDom
            {

                PedidoID = pedidoid,
                Descripcion = descripcion,
                Estado = estado,
                FechPedido = FechaPedido,
                ProveedorID = proveedorid,
                NumTotal = cantidad
            };

            //Assert
            Assert.Equals(pedidoid, pedido.PedidoID);
            Assert.Equals(descripcion, pedido.Descripcion);
            Assert.Equals(estado, pedido.Estado);
            Assert.Equals(FechaPedido, pedido.FechPedido);
            Assert.Equals(proveedorid, pedido.ProveedorID);
            Assert.Equals(cantidad, pedido.NumTotal);

        }
        public class ProveedorTest {

            [Fact]
            public void Proveedor_Properties_InitializedCorrectl() {


                //Arranque
                int proveedorId = 1;
                string NombProveedor = "SurtiTienda";
                string Nit = "9082345066";
                string Telefono = "313457389";
                string Direccion = "call 60 #97bi-70";

                //Act
                ClsProveedorDom proveedores = new ClsProveedorDom
                {

                    ProveedorID = proveedorId,
                    RazonSocial = NombProveedor,
                    Nit = Nit,
                    DireccionProveedor = Direccion,
                    TelefonoProveedor = Telefono


                };

                //Assert
                Assert.Equals(proveedorId, proveedores.ProveedorID);
                Assert.Equals(NombProveedor, proveedores.RazonSocial);
                Assert.Equals(Nit, proveedores.Nit);
                Assert.Equals(Telefono, proveedores.TelefonoProveedor);
                Assert.Equals(Direccion, proveedores.DireccionProveedor);

            }

        }

    }
    public class PedidoDetll {

        [Fact]
        public void Pedidodll_Properties_InitializedCorrectl() {

            //Arranque
            int DtllPedidoId = 1;
            int PedidoId = 1;
            int ProductoId = 1;
            int Numtotal = 2;
            double Valor = 34000;

            //Act 

            ClsPedidoDetallDom Detalle = new ClsPedidoDetallDom
            {


                DetallPedidoID = DtllPedidoId,
                Cantidad = Numtotal,
                PedidoID = PedidoId,
                Precio = Valor,
                ProductoID = ProductoId
            };

            //Assert
            Assert.Equals(DtllPedidoId, Detalle.DetallPedidoID);
            Assert.Equals(Numtotal, Detalle.Cantidad);
            Assert.Equals(PedidoId, Detalle.PedidoID);
            Assert.Equals(Valor, Detalle.Precio);
            Assert.Equals(ProductoId, Detalle.ProductoID);
        }

    }
    public class ventaTest {

        [Fact]
        public void Venta_Properties_InitializedCorrectl() {


            //Arranque
            int VentaId = 1;
            string Articulo = "Libra de arroz";
            DateTime fecha = DateTime.Now;
            double Cantidad = 1;
            string estado = "Compra";

            //Act
            ClsVentaDom venta = new ClsVentaDom
            {

                VentaID = VentaId,
                Descripcion = Articulo,
                Estado = estado,
                NumTotal = Cantidad,
                FechaVenta = fecha
            };

            //Assert
            Assert.Equals(VentaId, venta.VentaID);
            Assert.Equals(Articulo, venta.Descripcion);
            Assert.Equals(estado, venta.Estado);
            Assert.Equals(Cantidad, venta.NumTotal);
            Assert.Equals(fecha, venta.FechaVenta);

        }
    }
    public class VentaDtllTest {

        [Fact]
        public void VentaDtll_Properties_InitializedCorrectl() {


            //Arranque
            int ventadtllid = 1;
            int ventaid = 1;
            int producto = 1;
            double cantidad = 2;
            double valor = 23000;


            //Act 
            ClsVentaDetallDom detall = new ClsVentaDetallDom
            {

                VentaDetallID = ventadtllid,
                Cantidad = cantidad,
                ProductoID = producto,
                Precio = valor,
                VentaID = ventaid

            };

            //Assert
            Assert.Equals(ventadtllid, detall.VentaDetallID);
            Assert.Equals(cantidad,detall.Cantidad);
            Assert.Equals(producto,detall.ProductoID);
            Assert.Equals(valor,detall.Precio);
            Assert.Equals(ventaid,detall.VentaID);
        }
    }
}
