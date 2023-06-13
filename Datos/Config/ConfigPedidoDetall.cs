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
    public class ConfigPedidoDetall : IEntityTypeConfiguration<PedidoDetall>
    {
        public void Configure(EntityTypeBuilder<PedidoDetall> builder)
        {
            builder.HasKey(x => x.DetallPedidoID).HasName("PK_PEDIDODTLL");
            builder.HasIndex(x => x.DetallPedidoID, "UNIQ_ID").IsUnique();

            builder.Property(x => x.DetallPedidoID).HasColumnName("Id");
            builder.Property(x => x.Cantidad).HasColumnName("Cantidad");
            builder.Property(x => x.Precio).HasColumnName("Precio");
            builder.Property(x => x.ProductoID).HasColumnName("ProductoID");
            builder.Property(x => x.PedidoID).HasColumnName("PedidoID");

            builder.HasOne(x => x.Pedidos).WithMany().HasForeignKey(x => x.PedidoID)
                .HasConstraintName("FK_PEDIDO_PEDIDODETLL")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Productos).WithMany().HasForeignKey(x => x.ProductoID)
                .HasConstraintName("FK_PRODUCTO_PEDIDODETLL")
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
