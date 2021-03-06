﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagMyCoins.Domain.Entities;

namespace TagMyCoins.Infra.Data.EntityConfig
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasKey(u => u.UserId);

            //HasMany(u => u.Entries)
            //    .WithOptional()
            //    .WillCascadeOnDelete(false);

            //HasRequired(u => u.Tags)
            //    .WithMany()
            //    .WillCascadeOnDelete(false)
            //    ;

            ToTable("Users");
        }
    }
}
