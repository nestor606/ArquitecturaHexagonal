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
    public class ConfigProducto : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.HasKey(x => x.ProductoID).HasName("PK_PRODUCTO");
            builder.HasIndex(x => x.ProductoID, "UNIQ_ID").IsUnique();

            builder.Property(x => x.ProductoID).HasColumnName("Id");
            builder.Property(x => x.Descripcion).HasColumnName("Descripcion")
                .HasColumnType("varchar")
                .HasMaxLength(30);
            builder.Property(x => x.CategoriaID).HasColumnName("CategoriaID");
            builder.Property(x => x.Precio).HasColumnName("Precio");

            builder.HasOne(x => x.Categorias).WithMany().HasForeignKey(x => x.CategoriaID)
                .HasConstraintName("FK_CATEGORIA_PRODUCTO");

        }
    }
}
