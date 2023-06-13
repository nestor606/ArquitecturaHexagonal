using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio.Interfaces.Repositorio;
using System.Threading.Tasks;
using Dominio.Modelo;
using Xunit;

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

            String estado = "Pendiente";
            
        }
    }
}
