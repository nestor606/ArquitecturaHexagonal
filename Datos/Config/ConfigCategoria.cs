using Datos.Contexto;
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
    public class ConfigCategoria : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(x => x.CategoriaID).HasName("PK_CATEGORIA");
            builder.HasIndex(x => x.CategoriaID, "UNIQ_ID").IsUnique();

            builder.Property(x => x.CategoriaID).HasColumnName("Id");
            builder.Property(x => x.NombreCateg).HasColumnName("Descripcion")
                .HasColumnType("varchar")
                .HasMaxLength(30);
            
        }
    }
}
