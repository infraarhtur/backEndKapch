using System;
using Microsoft.EntityFrameworkCore;
using Modelos;
using System.Collections.Generic;
using System.Text;

namespace Datos.EF
{
    public class TraficoContexto : DbContext
    {
        public TraficoContexto(DbContextOptions<TraficoContexto> options) : base(options)
        {

        }

        public DbSet<OperadorModel> operadorItems { get; set; }



        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    modelBuilder.Entity<Modelos.OperadorModel>(entity =>
        //        {
        //            entity.ToTable("Operador");
        //            entity.Property(e => e.Id)
        //             .HasColumnName("Id")
        //             .IsRequired()
        //             .IsUnicode(true);

        //            entity.Property(e => e.CodigoOperador)
        //            .HasColumnName("CodigoOperador")
        //            .IsRequired()
        //            .IsUnicode(false);

        //            entity.Property(e => e.Placa)
        //            .HasColumnName("Placa")
        //            .IsRequired()
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //            entity.Property(e => e.Tid)
        //            .HasColumnName("Tid")
        //            .IsRequired()
        //            .HasMaxLength(100)
        //            .IsUnicode(false);

        //            entity.Property(e => e.Epc)
        //            .HasColumnName("Epc")
        //            .IsRequired()
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //            entity.Property(e => e.Estado)
        //            .HasColumnName("Estado")
        //            .IsRequired()
        //            .IsUnicode(false);


        //            entity.Property(e => e.EstadoSaldo)
        //          .HasColumnName("EstadoSaldo")
        //          .IsRequired()
        //          .IsUnicode(false);

        //            entity.Property(e => e.Saldo)
        //          .HasColumnName("Saldo")
        //          .IsRequired()
        //          .IsUnicode(false);

        //            entity.Property(e => e.SaldoBajo)
        //      .HasColumnName("SaldoBajo")
        //      .IsRequired()
        //      .IsUnicode(false);

        //            entity.Property(e => e.NumeroCliente)
        //      .HasColumnName("NumeroCliente")
        //      .IsRequired()
        //      .IsUnicode(false);

        //            entity.Property(e => e.Modalidad)
        //                     .HasColumnName("Modalidad")
        //                     .IsRequired()
        //                     .HasMaxLength(50)
        //                     .IsUnicode(false);

        //            entity.Property(e => e.Version)
        //                 .HasColumnName("Version")
        //                 .IsRequired()
        //                 .HasMaxLength(50)
        //                 .IsUnicode(false);

        //        });


        //}
    }
}
