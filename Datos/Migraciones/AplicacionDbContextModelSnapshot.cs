﻿// <auto-generated />
using System;
using Datos.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Datos.Migraciones
{
    [DbContext(typeof(AplicacionDbContext))]
    partial class AplicacionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Datos.Entidad.Categoria", b =>
                {
                    b.Property<int>("CategoriaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CategoriaID"));

                    b.Property<string>("NombreCateg")
                        .HasMaxLength(30)
                        .HasColumnType("varchar")
                        .HasColumnName("Descripcion");

                    b.HasKey("CategoriaID")
                        .HasName("PK_CATEGORIA");

                    b.HasIndex(new[] { "CategoriaID" }, "UNIQ_ID")
                        .IsUnique();

                    b.ToTable("categorias");

                    b.HasData(
                        new
                        {
                            CategoriaID = 1,
                            NombreCateg = "Granos"
                        });
                });

            modelBuilder.Entity("Datos.Entidad.Empleado", b =>
                {
                    b.Property<int>("EmpleadoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("EmpleadoID"));

                    b.Property<string>("DireccionEmpleado")
                        .HasMaxLength(30)
                        .HasColumnType("varchar")
                        .HasColumnName("DireccionEmp");

                    b.Property<string>("DocumentoEmpleado")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasColumnName("varchar");

                    b.Property<string>("NombreEmpleado")
                        .HasMaxLength(30)
                        .HasColumnType("varchar")
                        .HasColumnName("NombreEmp");

                    b.Property<string>("TelefonoEmpleado")
                        .HasMaxLength(20)
                        .HasColumnType("varchar")
                        .HasColumnName("TelefonoEmp");

                    b.HasKey("EmpleadoID")
                        .HasName("PK_EMPLEADO");

                    b.HasIndex(new[] { "EmpleadoID" }, "UNIQ_ID")
                        .IsUnique()
                        .HasDatabaseName("UNIQ_ID1");

                    b.ToTable("empleados");

                    b.HasData(
                        new
                        {
                            EmpleadoID = 1,
                            DireccionEmpleado = "calle 60 #97bis-46",
                            DocumentoEmpleado = "1087194382",
                            NombreEmpleado = "Nombre"
                        });
                });

            modelBuilder.Entity("Datos.Entidad.Pedido", b =>
                {
                    b.Property<int>("PedidoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PedidoID"));

                    b.Property<string>("Descripcion")
                        .HasMaxLength(30)
                        .HasColumnType("varchar")
                        .HasColumnName("Descripcion");

                    b.Property<string>("Estado")
                        .HasMaxLength(10)
                        .HasColumnType("varchar")
                        .HasColumnName("Estado");

                    b.Property<DateTime?>("FechEntrega")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("FechEntrega");

                    b.Property<DateTime?>("FechPedido")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("FechaPedido");

                    b.Property<int>("ProveedorID")
                        .HasColumnType("integer")
                        .HasColumnName("ProveedorID");

                    b.HasKey("PedidoID")
                        .HasName("PK_PEDIDO");

                    b.HasIndex("ProveedorID");

                    b.HasIndex(new[] { "PedidoID" }, "UNIQ_ID")
                        .IsUnique()
                        .HasDatabaseName("UNIQ_ID2");

                    b.ToTable("pedidos");

                    b.HasData(
                        new
                        {
                            PedidoID = 1,
                            Descripcion = "bulto de arroz",
                            Estado = "cancelado",
                            ProveedorID = 1
                        });
                });

            modelBuilder.Entity("Datos.Entidad.PedidoDetall", b =>
                {
                    b.Property<int>("DetallPedidoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("DetallPedidoID"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("integer")
                        .HasColumnName("Cantidad");

                    b.Property<int>("PedidoID")
                        .HasColumnType("integer")
                        .HasColumnName("PedidoID");

                    b.Property<double>("Precio")
                        .HasColumnType("double precision")
                        .HasColumnName("Precio");

                    b.Property<int>("ProductoID")
                        .HasColumnType("integer")
                        .HasColumnName("ProductoID");

                    b.HasKey("DetallPedidoID")
                        .HasName("PK_PEDIDODTLL");

                    b.HasIndex("PedidoID");

                    b.HasIndex("ProductoID");

                    b.HasIndex(new[] { "DetallPedidoID" }, "UNIQ_ID")
                        .IsUnique()
                        .HasDatabaseName("UNIQ_ID3");

                    b.ToTable("pedidoDetalls");

                    b.HasData(
                        new
                        {
                            DetallPedidoID = 1,
                            Cantidad = 1,
                            PedidoID = 1,
                            Precio = 45000.0,
                            ProductoID = 1
                        });
                });

            modelBuilder.Entity("Datos.Entidad.Producto", b =>
                {
                    b.Property<int>("ProductoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ProductoID"));

                    b.Property<double>("Cantidad")
                        .HasColumnType("double precision")
                        .HasColumnName("Cantidad");

                    b.Property<int>("CategoriaID")
                        .HasColumnType("integer")
                        .HasColumnName("CategoriaID");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(30)
                        .HasColumnType("varchar")
                        .HasColumnName("Descripcion");

                    b.Property<double>("Precio")
                        .HasColumnType("double precision")
                        .HasColumnName("Precio");

                    b.HasKey("ProductoID")
                        .HasName("PK_PRODUCTO");

                    b.HasIndex("CategoriaID");

                    b.HasIndex(new[] { "ProductoID" }, "UNIQ_ID")
                        .IsUnique()
                        .HasDatabaseName("UNIQ_ID4");

                    b.ToTable("productos");

                    b.HasData(
                        new
                        {
                            ProductoID = 1,
                            Cantidad = 1.0,
                            CategoriaID = 1,
                            Descripcion = "Arroz Diana",
                            Precio = 45000.0
                        },
                        new
                        {
                            ProductoID = 2,
                            Cantidad = 1.0,
                            CategoriaID = 1,
                            Descripcion = "Arroz Diana",
                            Precio = 1200.0
                        });
                });

            modelBuilder.Entity("Datos.Entidad.Proveedor", b =>
                {
                    b.Property<int>("ProveedorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ProveedorID"));

                    b.Property<string>("DireccionProveedor")
                        .HasMaxLength(30)
                        .HasColumnType("varchar")
                        .HasColumnName("DireccionProveedor");

                    b.Property<string>("Nit")
                        .HasColumnType("text");

                    b.Property<string>("RazonSocial")
                        .HasMaxLength(30)
                        .HasColumnType("varchar")
                        .HasColumnName("RazonSocial");

                    b.Property<string>("TelefonoProveedor")
                        .HasColumnType("text")
                        .HasColumnName("TelefonoProveedor");

                    b.HasKey("ProveedorID")
                        .HasName("PK_PROVEEDOR");

                    b.HasIndex(new[] { "ProveedorID" }, "UNIQ_ID")
                        .IsUnique()
                        .HasDatabaseName("UNIQ_ID5");

                    b.ToTable("proveedors");

                    b.HasData(
                        new
                        {
                            ProveedorID = 1,
                            DireccionProveedor = "avenidad 9N carrera #12-45",
                            RazonSocial = "BaratoEconomico",
                            TelefonoProveedor = "313600300"
                        });
                });

            modelBuilder.Entity("Datos.Entidad.Venta", b =>
                {
                    b.Property<int>("VentaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("VentaID"));

                    b.Property<string>("Descripcion")
                        .HasMaxLength(30)
                        .HasColumnType("varchar")
                        .HasColumnName("Descripcion");

                    b.Property<string>("Estado")
                        .HasMaxLength(10)
                        .HasColumnType("varchar")
                        .HasColumnName("Estado");

                    b.Property<DateTime?>("FechaVenta")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("FechaVenta");

                    b.HasKey("VentaID")
                        .HasName("PK_VENTA");

                    b.HasIndex(new[] { "VentaID" }, "UNIQ_ID")
                        .IsUnique()
                        .HasDatabaseName("UNIQ_ID6");

                    b.ToTable("ventas");

                    b.HasData(
                        new
                        {
                            VentaID = 1,
                            Descripcion = "Compra de arroz",
                            Estado = "Pagado"
                        });
                });

            modelBuilder.Entity("Datos.Entidad.VentaDetall", b =>
                {
                    b.Property<int>("VentaDetallID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("VentaDetallID"));

                    b.Property<double>("Cantidad")
                        .HasColumnType("double precision");

                    b.Property<double>("Precio")
                        .HasColumnType("double precision")
                        .HasColumnName("precio");

                    b.Property<int>("ProductoID")
                        .HasColumnType("integer")
                        .HasColumnName("ProductoID");

                    b.Property<int>("VentaID")
                        .HasColumnType("integer")
                        .HasColumnName("VentaID");

                    b.HasKey("VentaDetallID")
                        .HasName("PK_VENTADTLL");

                    b.HasIndex("ProductoID");

                    b.HasIndex("VentaID");

                    b.HasIndex(new[] { "VentaDetallID" }, "UNIQ_ID")
                        .IsUnique()
                        .HasDatabaseName("UNIQ_ID7");

                    b.ToTable("ventaDetalls");

                    b.HasData(
                        new
                        {
                            VentaDetallID = 1,
                            Cantidad = 2.0,
                            Precio = 2400.0,
                            ProductoID = 2,
                            VentaID = 1
                        });
                });

            modelBuilder.Entity("Datos.Entidad.Pedido", b =>
                {
                    b.HasOne("Datos.Entidad.Proveedor", "Proveedores")
                        .WithMany()
                        .HasForeignKey("ProveedorID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_PROVEEDOR_PEDIDO");

                    b.Navigation("Proveedores");
                });

            modelBuilder.Entity("Datos.Entidad.PedidoDetall", b =>
                {
                    b.HasOne("Datos.Entidad.Pedido", "Pedidos")
                        .WithMany()
                        .HasForeignKey("PedidoID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_PEDIDO_PEDIDODETLL");

                    b.HasOne("Datos.Entidad.Producto", "Productos")
                        .WithMany()
                        .HasForeignKey("ProductoID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_PRODUCTO_PEDIDODETLL");

                    b.Navigation("Pedidos");

                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Datos.Entidad.Producto", b =>
                {
                    b.HasOne("Datos.Entidad.Categoria", "Categorias")
                        .WithMany()
                        .HasForeignKey("CategoriaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_CATEGORIA_PRODUCTO");

                    b.Navigation("Categorias");
                });

            modelBuilder.Entity("Datos.Entidad.VentaDetall", b =>
                {
                    b.HasOne("Datos.Entidad.Producto", "Productos")
                        .WithMany()
                        .HasForeignKey("ProductoID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_PRODUCTO_VENTADTLL");

                    b.HasOne("Datos.Entidad.Venta", "ventas")
                        .WithMany()
                        .HasForeignKey("VentaID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_VENTAS_VENTDTLL");

                    b.Navigation("Productos");

                    b.Navigation("ventas");
                });
#pragma warning restore 612, 618
        }
    }
}
