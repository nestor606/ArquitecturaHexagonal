using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Datos.Migraciones
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "varchar", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORIA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "empleados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    varchar = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    NombreEmp = table.Column<string>(type: "varchar", maxLength: 30, nullable: true),
                    TelefonoEmp = table.Column<string>(type: "varchar", maxLength: 20, nullable: true),
                    DireccionEmp = table.Column<string>(type: "varchar", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMPLEADO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "proveedors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nit = table.Column<string>(type: "text", nullable: true),
                    RazonSocial = table.Column<string>(type: "varchar", maxLength: 30, nullable: true),
                    TelefonoProveedor = table.Column<string>(type: "text", nullable: true),
                    DireccionProveedor = table.Column<string>(type: "varchar", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROVEEDOR", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ventas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "varchar", maxLength: 30, nullable: true),
                    FechaVenta = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Estado = table.Column<string>(type: "varchar", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VENTA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoriaID = table.Column<int>(type: "integer", nullable: false),
                    Cantidad = table.Column<double>(type: "double precision", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar", maxLength: 30, nullable: true),
                    Precio = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCTO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CATEGORIA_PRODUCTO",
                        column: x => x.CategoriaID,
                        principalTable: "categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProveedorID = table.Column<int>(type: "integer", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar", maxLength: 30, nullable: true),
                    FechaPedido = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    FechEntrega = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Estado = table.Column<string>(type: "varchar", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PEDIDO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PROVEEDOR_PEDIDO",
                        column: x => x.ProveedorID,
                        principalTable: "proveedors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ventaDetalls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VentaID = table.Column<int>(type: "integer", nullable: false),
                    ProductoID = table.Column<int>(type: "integer", nullable: false),
                    Cantidad = table.Column<double>(type: "double precision", nullable: false),
                    precio = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VENTADTLL", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PRODUCTO_VENTADTLL",
                        column: x => x.ProductoID,
                        principalTable: "productos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VENTAS_VENTDTLL",
                        column: x => x.VentaID,
                        principalTable: "ventas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "pedidoDetalls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PedidoID = table.Column<int>(type: "integer", nullable: false),
                    ProductoID = table.Column<int>(type: "integer", nullable: false),
                    Cantidad = table.Column<int>(type: "integer", nullable: false),
                    Precio = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PEDIDODTLL", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PEDIDO_PEDIDODETLL",
                        column: x => x.PedidoID,
                        principalTable: "pedidos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PRODUCTO_PEDIDODETLL",
                        column: x => x.ProductoID,
                        principalTable: "productos",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "categorias",
                columns: new[] { "Id", "Descripcion" },
                values: new object[] { 1, "Granos" });

            migrationBuilder.InsertData(
                table: "empleados",
                columns: new[] { "Id", "DireccionEmp", "varchar", "NombreEmp", "TelefonoEmp" },
                values: new object[] { 1, "calle 60 #97bis-46", "1087194382", "Nombre", null });

            migrationBuilder.InsertData(
                table: "proveedors",
                columns: new[] { "Id", "DireccionProveedor", "Nit", "RazonSocial", "TelefonoProveedor" },
                values: new object[] { 1, "avenidad 9N carrera #12-45", null, "BaratoEconomico", "313600300" });

            migrationBuilder.InsertData(
                table: "ventas",
                columns: new[] { "Id", "Descripcion", "Estado", "FechaVenta" },
                values: new object[] { 1, "Compra de arroz", "Pagado", null });

            migrationBuilder.InsertData(
                table: "pedidos",
                columns: new[] { "Id", "Descripcion", "Estado", "FechEntrega", "FechaPedido", "ProveedorID" },
                values: new object[] { 1, "bulto de arroz", "cancelado", null, null, 1 });

            migrationBuilder.InsertData(
                table: "productos",
                columns: new[] { "Id", "Cantidad", "CategoriaID", "Descripcion", "Precio" },
                values: new object[,]
                {
                    { 1, 1.0, 1, "Arroz Diana", 45000.0 },
                    { 2, 1.0, 1, "Arroz Diana", 1200.0 }
                });

            migrationBuilder.InsertData(
                table: "pedidoDetalls",
                columns: new[] { "Id", "Cantidad", "PedidoID", "Precio", "ProductoID" },
                values: new object[] { 1, 1, 1, 45000.0, 1 });

            migrationBuilder.InsertData(
                table: "ventaDetalls",
                columns: new[] { "Id", "Cantidad", "precio", "ProductoID", "VentaID" },
                values: new object[] { 1, 2.0, 2400.0, 2, 1 });

            migrationBuilder.CreateIndex(
                name: "UNIQ_ID",
                table: "categorias",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UNIQ_ID1",
                table: "empleados",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_pedidoDetalls_PedidoID",
                table: "pedidoDetalls",
                column: "PedidoID");

            migrationBuilder.CreateIndex(
                name: "IX_pedidoDetalls_ProductoID",
                table: "pedidoDetalls",
                column: "ProductoID");

            migrationBuilder.CreateIndex(
                name: "UNIQ_ID3",
                table: "pedidoDetalls",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_ProveedorID",
                table: "pedidos",
                column: "ProveedorID");

            migrationBuilder.CreateIndex(
                name: "UNIQ_ID2",
                table: "pedidos",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_productos_CategoriaID",
                table: "productos",
                column: "CategoriaID");

            migrationBuilder.CreateIndex(
                name: "UNIQ_ID4",
                table: "productos",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UNIQ_ID5",
                table: "proveedors",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ventaDetalls_ProductoID",
                table: "ventaDetalls",
                column: "ProductoID");

            migrationBuilder.CreateIndex(
                name: "IX_ventaDetalls_VentaID",
                table: "ventaDetalls",
                column: "VentaID");

            migrationBuilder.CreateIndex(
                name: "UNIQ_ID7",
                table: "ventaDetalls",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UNIQ_ID6",
                table: "ventas",
                column: "Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "empleados");

            migrationBuilder.DropTable(
                name: "pedidoDetalls");

            migrationBuilder.DropTable(
                name: "ventaDetalls");

            migrationBuilder.DropTable(
                name: "pedidos");

            migrationBuilder.DropTable(
                name: "productos");

            migrationBuilder.DropTable(
                name: "ventas");

            migrationBuilder.DropTable(
                name: "proveedors");

            migrationBuilder.DropTable(
                name: "categorias");
        }
    }
}
