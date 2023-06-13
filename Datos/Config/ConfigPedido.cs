using Datos.Entidad;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Config
{
    public class ConfigPedido : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(x => x.PedidoID).HasName("PK_PEDIDO");
            builder.HasIndex(x => x.PedidoID, "UNIQ_ID").IsUnique();

            builder.Property(x => x.PedidoID).HasColumnName("Id");
            builder.Property(x => x.Descripcion).HasColumnName("Descripcion")
                .HasColumnType("varchar")
                .HasMaxLength(30);
            builder.Property(x => x.Estado).HasColumnName("Estado")
                .HasColumnType("varchar")
                .HasMaxLength(10);
            builder.Property(x => x.ProveedorID).HasColumnName("ProveedorID");
            builder.Property(x => x.FechEntrega).HasColumnName("FechEntrega");
            builder.Property(x => x.FechPedido).HasColumnName("FechaPedido");

            builder.HasOne(x => x.Proveedores).WithMany().HasForeignKey(x => x.ProveedorID)
                .HasConstraintName("FK_PROVEEDOR_PEDIDO")
                .OnDelete(DeleteBehavior.NoAction);
            
        }
    }
}
