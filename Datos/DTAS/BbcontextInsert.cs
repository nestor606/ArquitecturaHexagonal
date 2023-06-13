using Datos.Entidad;
using Microsoft.EntityFrameworkCore;
using Npgsql.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DTAS
{
    public static class BbcontextInsert
    {
        public static void iNSERT(this ModelBuilder modelBuilder) {

            var empleado = new List<Empleado> {

                new Empleado{

                    EmpleadoID = 1,
                    NombreEmpleado = "Nombre",
                    DocumentoEmpleado = "1087194382",
                    DireccionEmpleado = "calle 60 #97bis-46"
                }
            };
            modelBuilder.Entity<Empleado>().HasData(empleado);

            var categoria = new List<Categoria>
            {
                new Categoria {

                    CategoriaID = 1,
                    NombreCateg = "Granos"
                }
            };
            modelBuilder.Entity<Categoria>().HasData(categoria);

            var pedido = new List<Pedido> {

                new Pedido{
                    PedidoID = 1,
                    Descripcion = "bulto de arroz",
                    Estado = "cancelado",
                    ProveedorID = 1

                }
            };
            modelBuilder.Entity<Pedido>().HasData(pedido);

            var pedidoDetll = new List<PedidoDetall> {
                new PedidoDetall{

                    DetallPedidoID = 1,
                    Cantidad = 1,
                    Precio = 45000,
                    ProductoID = 1,
                    PedidoID = 1
                }
            };
            modelBuilder.Entity<PedidoDetall>().HasData(pedidoDetll);

            var producto = new List<Producto> {

                new Producto{

                    ProductoID = 1,
                    Descripcion = "Arroz Diana",
                    CategoriaID = 1,
                    Precio = 45000

                },
                new Producto{

                    ProductoID = 2,
                    Descripcion = "Arroz Diana",
                    CategoriaID = 1,
                    Precio = 1200

                }
            };
            modelBuilder.Entity<Producto>().HasData(producto);

            var proveedor = new List<Proveedor>() {

                new Proveedor{

                    ProveedorID = 1,
                    RazonSocial = "BaratoEconomico",
                    TelefonoProveedor = "313600300",
                    DireccionProveedor = "avenidad 9N carrera #12-45"
                }
            };
            modelBuilder.Entity<Proveedor>().HasData(proveedor);

            var venta = new List<Venta>() {
                new Venta {

                    VentaID = 1,
                    Descripcion = "Compra de arroz",
                    Estado = "Pagado"
                }
            };
            modelBuilder.Entity<Venta>().HasData(venta);

            var ventadtll = new List<VentaDetall>() {

                new VentaDetall{

                    VentaDetallID = 1,
                    VentaID = 1,
                    Cantidad  = 2,
                    Precio =  2400,
                    ProductoID = 2
                }
            };
            modelBuilder.Entity<VentaDetall>().HasData(ventadtll);
        }
    }
}
