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
    public class ConfigVentaDetall : IEntityTypeConfiguration<VentaDetall>
    {
        public void Configure(EntityTypeBuilder<VentaDetall> builder)
        {
            builder.HasKey(x => x.VentaDetallID).HasName("PK_VENTADTLL");
            builder.HasIndex(X => X.VentaDetallID, "UNIQ_ID").IsUnique();

            builder.Property(x => x.VentaDetallID).HasColumnName("Id");
            builder.Property(x => x.VentaID).HasColumnName("VentaID");
            builder.Property(x => x.ProductoID).HasColumnName("ProductoID");
            builder.Property(x => x.Precio).HasColumnName("precio");

            builder.HasOne(x => x.ventas).WithMany().HasForeignKey(x => x.VentaID)
                .HasConstraintName("FK_VENTAS_VENTDTLL")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Productos).WithMany().HasForeignKey(x => x.ProductoID)
                .HasConstraintName("FK_PRODUCTO_VENTADTLL")
                .OnDelete(DeleteBehavior.NoAction);


        }
    }
}
