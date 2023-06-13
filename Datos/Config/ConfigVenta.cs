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
    public class ConfigVenta : IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> builder)
        {
            builder.HasKey(x => x.VentaID).HasName("PK_VENTA");
            builder.HasIndex(x => x.VentaID, "UNIQ_ID").IsUnique();

            builder.Property(x => x.VentaID).HasColumnName("Id");
            builder.Property(x => x.Descripcion).HasColumnName("Descripcion")
                .HasColumnType("varchar")
                .HasMaxLength(30);
            builder.Property(x => x.Estado).HasColumnName("Estado").
                HasColumnType("varchar")
                .HasMaxLength(10);
            builder.Property(x => x.FechaVenta).HasColumnName("FechaVenta");

        }
    }
}
