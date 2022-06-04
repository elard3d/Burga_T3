using Burga_T3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Burga_T3.ConexionDB
{
    public class RegistroMap: IEntityTypeConfiguration<Registro>
    {
        public void Configure(EntityTypeBuilder<Registro> builder)
        {
            builder.ToTable("Registro");
            builder.HasKey(o => o.Id);

         

        }
    }
}
