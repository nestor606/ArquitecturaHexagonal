using Datos.Config;
using Datos.DTAS;
using Datos.Entidad;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Contexto
{
    public class AplicacionDbContext : DbContext
    {
        
        public AplicacionDbContext(DbContextOptions<AplicacionDbContext> options) : base(options)
        {
        }

        public DbSet<Categoria> categorias { get; set; }
        public DbSet<Producto> productos { get; set; }
        public DbSet<Pedido> pedidos { get; set; }
        public DbSet<Empleado> empleados { get; set; }
        public DbSet<PedidoDetall> pedidoDetalls { get; set; }
        public DbSet<Proveedor> proveedors { get; set; }
        public DbSet<Venta> ventas { get; set; }
        public DbSet<VentaDetall> ventaDetalls { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ConfigCategoria());

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AplicacionDbContext).Assembly);
            modelBuilder.iNSERT();
            base.OnModelCreating(modelBuilder);


        }
    }
}
