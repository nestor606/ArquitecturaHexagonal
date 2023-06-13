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
    public class ConfigProveedor : IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> builder)
        {
            builder.HasKey(x => x.ProveedorID).HasName("PK_PROVEEDOR");
            builder.HasIndex(x => x.ProveedorID, "UNIQ_ID").IsUnique();

            builder.Property(x => x.ProveedorID).HasColumnName("Id");
            builder.Property(x => x.RazonSocial).HasColumnName("RazonSocial")
                .HasColumnType("varchar")
                .HasMaxLength(30);

            builder.Property(x => x.TelefonoProveedor).HasColumnName("TelefonoProveedor");
            builder.Property(x => x.DireccionProveedor).HasColumnName("DireccionProveedor")
                .HasColumnType("varchar")
                .HasMaxLength(30);


        }
    }
}
