﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using NextStar.Library.AspNetCore.SessionDbModels;

namespace NextStar.Library.AspNetCore.DbContexts
{
    public partial class SessionDbContext : DbContext
    {
        public SessionDbContext()
        {
        }

        public SessionDbContext(DbContextOptions<SessionDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<UserSession> UserSessions { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<UserSession>(entity =>
            {
                entity.HasKey(e => e.SessionId)
                    .HasName("UserSession_pk");

                entity.ToTable("UserSession");

                entity.HasIndex(e => e.SessionId, "UserSession_SessionId_uindex")
                    .IsUnique();

                entity.Property(e => e.SessionId).HasDefaultValueSql("(newsequentialid())");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
