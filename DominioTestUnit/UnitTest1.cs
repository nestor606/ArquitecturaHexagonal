using Dominio.Modelo;


namespace DominioTestUnit
{
    public class UnitTest1
    {
        public class CateogoriaTest
        {
            [Fact]
            public void Categoria_Properties_InitializedCorrectly()
            {

                //Arranque
                int categoriaId = 1;
                string nombreCategoria = "Granos";


                //Act
                ClsCategoriaDom clsCategoria = new()
                {

                    CategoriaID = categoriaId,
                    NombreCateg = nombreCategoria
                };


                //Assert
                Assert.Equal(categoriaId, clsCategoria.CategoriaID);
                Assert.Equal(nombreCategoria, clsCategoria.NombreCateg);
            }
        }
        public class ProductoTest
        {

            [Fact]
            public void Producto_Properties_InitializedCorrectly()
            {

                //Arranque
                int productId = 1;
                string descripcion = "Arroz Blanquita la suprema";
                int categoriaId = 1;
                int precio = 1200;

                //Act
                ClsProducotDom clsProducot = new()
                {

                    ProductoID = productId,
                    CateogriaID = categoriaId,
                    Descripcion = descripcion,
                    Precio = precio
                };

                //Assert
                Assert.Equal(productId, clsProducot.ProductoID);
                Assert.Equal(categoriaId, clsProducot.CateogriaID);
                Assert.Equal(descripcion, clsProducot.Descripcion);
                Assert.Equal(precio, clsProducot.Precio);
            }
        }
        public class EmpleadoTest
        {

            [Fact]
            public void Empleado_Properties_InitializedCorrectly()
            {

                //Arranque
                int empleadoId = 1;
                string documentoEmpleado = "1087194382";
                string nombreEmpleado = "Nestor Ivan Maquilon";
                string telefonoEmpleado = "1087194382";
                string direccionEmpleado = "calle 60 #97bis-46";

                //Act
                ClsEmpleadoDom clsEmpleado = new()
                {

                    EmpleadoID = empleadoId,
                    DocumentoEmpleado = documentoEmpleado,
                    NombreEmpleado = nombreEmpleado,
                    DireccionEmpleado = direccionEmpleado,
                    TelefonoEmpleado = telefonoEmpleado
                };

                //Assert
                Assert.Equal(empleadoId, clsEmpleado.EmpleadoID);
                Assert.Equal(documentoEmpleado, clsEmpleado.DocumentoEmpleado);
                Assert.Equal(nombreEmpleado, clsEmpleado.NombreEmpleado);
                Assert.Equal(telefonoEmpleado, clsEmpleado.TelefonoEmpleado);
                Assert.Equal(direccionEmpleado, clsEmpleado.DireccionEmpleado);
            }
        }
        public class PedidoTest
        {

            [Fact]
            public void Pedido_Properties_InitializedCorrectly()
            {

                //Arranque
                int pedidoId = 1;
                string descripcion = "Bulto de Arroz La Suprema";
                int proveedorId = 1;
                int cantidad = 1;
                string estado = "Pendiente";
                string fechPedido = "01-02-2020";

                //Act
                ClsPedidoDom clsPedido = new()
                {

                    PedidoID = pedidoId,
                    Descripcion = descripcion,
                    Estado = estado,
                    FechPedido = fechPedido,
                    ProveedorID = proveedorId,
                    NumTotal = cantidad
                };

                //Assert
                Assert.Equal(pedidoId, clsPedido.PedidoID);
                Assert.Equal(descripcion, clsPedido.Descripcion);
                Assert.Equal(estado, clsPedido.Estado);
                Assert.Equal(fechPedido, clsPedido.FechPedido);
                Assert.Equal(proveedorId, clsPedido.ProveedorID);
                Assert.Equal(cantidad, clsPedido.NumTotal);

            }
            

        }
        public class ProveedorTest
        {

            [Fact]
            public void Proveedor_Properties_InitializedCorrectl()
            {


                //Arranque
                int proveedorId = 1;
                string razonSocial = "SurtiTienda";
                string nit = "9082345066";
                string telefonoProveedor = "313457389";
                string direccionProvedor = "call 60 #97bi-70";

                //Act
                ClsProveedorDom clsProveedor = new()
                {

                    ProveedorID = proveedorId,
                    RazonSocial = razonSocial,
                    Nit = nit,
                    DireccionProveedor = direccionProvedor,
                    TelefonoProveedor = telefonoProveedor


                };

                //Assert
                Assert.Equal(proveedorId, clsProveedor.ProveedorID);
                Assert.Equal(razonSocial, clsProveedor.RazonSocial);
                Assert.Equal(nit, clsProveedor.Nit);
                Assert.Equal(telefonoProveedor, clsProveedor.TelefonoProveedor);
                Assert.Equal(direccionProvedor, clsProveedor.DireccionProveedor);

            }

        }
        public class PedidoDetll
        {

            [Fact]
            public void Pedidodll_Properties_InitializedCorrectl()
            {

                //Arranque
                int detallPedidoId = 1;
                int pedidoId = 1;
                int productoId = 1;
                int cantidad = 2;
                int precio = 34000;

                //Act 

                ClsPedidoDetallDom clsPedidoDetall = new()
                {


                    DetallPedidoID = detallPedidoId,
                    Cantidad = cantidad,
                    PedidoID = pedidoId,
                    Precio = precio,
                    ProductoID = productoId
                };

                //Assert
                Assert.Equal(detallPedidoId, clsPedidoDetall.DetallPedidoID);
                Assert.Equal(cantidad, clsPedidoDetall.Cantidad);
                Assert.Equal(pedidoId, clsPedidoDetall.PedidoID);
                Assert.Equal(precio, clsPedidoDetall.Precio);
                Assert.Equal(productoId, clsPedidoDetall.ProductoID);
            }

        }
        public class VentaTest
        {

            [Fact]
            public void Venta_Properties_InitializedCorrectl()
            {


                //Arranque
                int ventaId = 1;
                string descripcion = "Libra de arroz";
                string fechaVenta = "01-02-2022";
                int numTotal = 1;
                string estado = "Compra";

                //Act
                ClsVentaDom clsVenta = new()
                {

                    VentaID = ventaId,
                    Descripcion = descripcion,
                    Estado = estado,
                    NumTotal = numTotal,
                    FechaVenta = fechaVenta
                };

                //Assert
                Assert.Equal(ventaId, clsVenta.VentaID);
                Assert.Equal(descripcion, clsVenta.Descripcion);
                Assert.Equal(estado, clsVenta.Estado);
                Assert.Equal(numTotal, clsVenta.NumTotal);
                Assert.Equal(fechaVenta, clsVenta.FechaVenta);

            }
        }
        public class VentaDtllTest
        {

            [Fact]
            public void VentaDtll_Properties_InitializedCorrectl()
            {


                //Arranque
                int ventaDetallId = 1;
                int ventaId = 1;
                int productoId = 1;
                int cantidad = 2;
                int precio = 23000;


                //Act 
                ClsVentaDetallDom clsVentaDetall = new()
                {

                    VentaDetallID = ventaDetallId,
                    Cantidad = cantidad,
                    ProductoID = productoId,
                    Precio = precio,
                    VentaID = ventaId

                };

                //Assert
                Assert.Equal(ventaDetallId, clsVentaDetall.VentaDetallID);
                Assert.Equal(cantidad, clsVentaDetall.Cantidad);
                Assert.Equal(productoId, clsVentaDetall.ProductoID);
                Assert.Equal(precio, clsVentaDetall.Precio);
                Assert.Equal(ventaId, clsVentaDetall.VentaID);
            }
        }
    }
}