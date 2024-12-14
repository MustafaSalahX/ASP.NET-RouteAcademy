using EF.Entites;
using EFOne.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFOne.Configurations
{
    internal class InstructorConfigurations : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.Property(I => I.Address).HasDefaultValue("Alex");
            builder.Property(I => I.Salary).HasColumnType("decimal(18,3)");
            builder.Property(I => I.Bonus).HasColumnType("decimal(18,3)");

            builder.HasOne(I => I.ManageDepartment)
                .WithOne(D => D.Manger)
                .IsRequired(false)
                .HasForeignKey<Department>(D => D.MangerId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
