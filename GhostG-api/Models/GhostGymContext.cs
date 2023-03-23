using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GhostG_api.Models;

public partial class GhostGymContext : DbContext
{
    public GhostGymContext()
    {
    }

    public GhostGymContext(DbContextOptions<GhostGymContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categorium> Categoria { get; set; }

    public virtual DbSet<DetEjercicio> DetEjercicios { get; set; }

    public virtual DbSet<Horario> Horarios { get; set; }

    public virtual DbSet<Instructor> Instructors { get; set; }

    public virtual DbSet<Monitoreo1> Monitoreo1s { get; set; }

    public virtual DbSet<Rutina> Rutinas { get; set; }

    public virtual DbSet<Suscripcion> Suscripcions { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Vista1> Vista1s { get; set; }

    public virtual DbSet<Vista2> Vista2s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-0P5K4OSO\\MSSQLSERVER01; DataBase=GhostGym;Integrated Security=true;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categorium>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).HasName("PK__Categori__CB90334957885E84");

            entity.Property(e => e.IdCategoria).HasColumnName("Id_Categoria");
            entity.Property(e => e.Duracion)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DetEjercicio>(entity =>
        {
            entity.HasKey(e => e.IdDetalle).HasName("PK__DetEjerc__9274780B7B34EE2B");

            entity.ToTable("DetEjercicio");

            entity.Property(e => e.IdDetalle).HasColumnName("Id_Detalle");

            entity.HasOne(d => d.IdCategoria1Navigation).WithMany(p => p.DetEjercicios)
                .HasForeignKey(d => d.IdCategoria1)
                .HasConstraintName("FK_IdCategoria1");

            entity.HasOne(d => d.IdInstructor1Navigation).WithMany(p => p.DetEjercicios)
                .HasForeignKey(d => d.IdInstructor1)
                .HasConstraintName("FK_IdInstructor1");

            entity.HasOne(d => d.IdRutina1Navigation).WithMany(p => p.DetEjercicios)
                .HasForeignKey(d => d.IdRutina1)
                .HasConstraintName("FK_IdRutina1");
        });

        modelBuilder.Entity<Horario>(entity =>
        {
            entity.HasKey(e => e.IdHorario).HasName("PK__Horario__AD7A4DD3BBBA6423");

            entity.ToTable("Horario");

            entity.Property(e => e.IdHorario).HasColumnName("Id_Horario");
            entity.Property(e => e.Turno)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Instructor>(entity =>
        {
            entity.HasKey(e => e.IdInstructor).HasName("PK__Instruct__A2D73E60EC6772E7");

            entity.ToTable("Instructor");

            entity.Property(e => e.IdInstructor).HasColumnName("Id_Instructor");
            entity.Property(e => e.ApellidoI)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.NombreI)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.IdHorarioNavigation).WithMany(p => p.Instructors)
                .HasForeignKey(d => d.IdHorario)
                .HasConstraintName("FK_IdHorario");
        });

        modelBuilder.Entity<Monitoreo1>(entity =>
        {
            entity.HasKey(e => e.RowNumber).HasName("PK__Monitore__AAAC09D883EC660D");

            entity.ToTable("Monitoreo1");

            entity.Property(e => e.ApplicationName).HasMaxLength(128);
            entity.Property(e => e.BinaryData).HasColumnType("image");
            entity.Property(e => e.ClientProcessId).HasColumnName("ClientProcessID");
            entity.Property(e => e.Cpu).HasColumnName("CPU");
            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.LoginName).HasMaxLength(128);
            entity.Property(e => e.NtuserName)
                .HasMaxLength(128)
                .HasColumnName("NTUserName");
            entity.Property(e => e.Spid).HasColumnName("SPID");
            entity.Property(e => e.StartTime).HasColumnType("datetime");
            entity.Property(e => e.TextData).HasColumnType("ntext");
        });

        modelBuilder.Entity<Rutina>(entity =>
        {
            entity.HasKey(e => e.IdRutina).HasName("PK__Rutinas__7C95EE40F45A84AC");

            entity.Property(e => e.IdRutina).HasColumnName("Id_Rutina");
            entity.Property(e => e.Enfoque)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Nivel)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Suscripcion>(entity =>
        {
            entity.HasKey(e => e.IdSuscripcion).HasName("PK__Suscripc__C0583DB09F51A3CD");

            entity.ToTable("Suscripcion");

            entity.Property(e => e.IdSuscripcion).HasColumnName("Id_Suscripcion");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Suscripcions)
                .HasForeignKey(d => d.IdCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IdCategoria");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Suscripcions)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IdUsuario");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuario__63C76BE2CB3FFD7B");

            entity.ToTable("Usuario");

            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.Apellido)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Contra).HasMaxLength(255);
            entity.Property(e => e.Correo)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Vista1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vista_1");

            entity.Property(e => e.Apellido)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Vista2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vista_2");

            entity.Property(e => e.Enfoque)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Horario)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Nivel)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
