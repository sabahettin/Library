using Library.DataLayer.Configuration.Abstract;
using Library.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataLayer.Configuration.Concrete
{
    public class CategoryConfiguration:BaseConfiguration<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.categoryId);
            builder.Property(x => x.categoryCode).IsRequired();
            builder.Property(x => x.categoryName).IsRequired().HasMaxLength(50);
            base.Configure(builder);
        }
    }
}
