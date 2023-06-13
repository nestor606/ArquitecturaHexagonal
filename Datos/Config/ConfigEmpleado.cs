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
    public class ConfigEmpleado : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.HasKey(x => x.EmpleadoID).HasName("PK_EMPLEADO");
            builder.HasIndex(x => x.EmpleadoID, "UNIQ_ID").IsUnique();

            builder.Property(x => x.EmpleadoID).HasColumnName("Id");
            builder.Property(x => x.NombreEmpleado).HasColumnName("NombreEmp")
                .HasColumnType("varchar")
                .HasMaxLength(30);
            builder.Property(x => x.DocumentoEmpleado).HasColumnName("DocumntEmp")
                .HasColumnName("varchar")
                .HasMaxLength(15);
            builder.Property(x => x.TelefonoEmpleado).HasColumnName("TelefonoEmp")
                .HasColumnType("varchar")
                .HasMaxLength(20);
            builder.Property(x => x.DireccionEmpleado).HasColumnName("DireccionEmp")
                .HasColumnType("varchar")
                .HasMaxLength(30);
        }
    }
}
