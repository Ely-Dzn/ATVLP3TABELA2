using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Myprojec.MODEL;
namespace Myproject.DAL.DBContext;

public partial class CUsersCcasmSourceReposAtvlp3tabela2MyprojectDalDatabaseDatabase1MdfContext : DbContext
{
    public CUsersCcasmSourceReposAtvlp3tabela2MyprojectDalDatabaseDatabase1MdfContext()
    {
    }

    public CUsersCcasmSourceReposAtvlp3tabela2MyprojectDalDatabaseDatabase1MdfContext(DbContextOptions<CUsersCcasmSourceReposAtvlp3tabela2MyprojectDalDatabaseDatabase1MdfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Projeto> Projetos { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ccasm\\source\\repos\\ATVLP3TABELA2\\Myproject.DAL\\database\\Database1.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Projeto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Projeto__3214EC0732F12DD1");

            entity.ToTable("Projeto");

            entity.Property(e => e.DatafimdoProjeto).HasColumnType("datetime");
            entity.Property(e => e.DatainiciodoProjeto).HasColumnType("datetime");
            entity.Property(e => e.NomedoGerentedoProjeto)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NomedoProjeto)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReseumodoProjeto)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.Projetos)
                .HasForeignKey(d => d.IdStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_idStatus");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Status__3214EC0791ADE3D6");

            entity.ToTable("Status");

            entity.Property(e => e.Status1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
