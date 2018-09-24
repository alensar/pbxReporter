using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace pbxReporter.Data.Asteriskcdrdb
{
    public partial class asteriskcdrdbContext : DbContext
    {
        public asteriskcdrdbContext()
        {
        }

        public asteriskcdrdbContext(DbContextOptions<asteriskcdrdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cdr> Cdr { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cdr>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("cdr");

                entity.HasIndex(e => e.Uniqueid)
                    .HasName("IDX_UNIQUEID");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Accountcode)
                    .IsRequired()
                    .HasColumnName("accountcode")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Amaflags)
                    .HasColumnName("amaflags")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Billsec)
                    .HasColumnName("billsec")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Calldate)
                    .HasColumnName("calldate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasColumnName("channel")
                    .HasColumnType("varchar(80)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Clid)
                    .IsRequired()
                    .HasColumnName("clid")
                    .HasColumnType("varchar(80)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Cnam)
                    .IsRequired()
                    .HasColumnName("cnam")
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Cnum)
                    .IsRequired()
                    .HasColumnName("cnum")
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dcontext)
                    .IsRequired()
                    .HasColumnName("dcontext")
                    .HasColumnType("varchar(80)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Did)
                    .IsRequired()
                    .HasColumnName("did")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Disposition)
                    .IsRequired()
                    .HasColumnName("disposition")
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dst)
                    .IsRequired()
                    .HasColumnName("dst")
                    .HasColumnType("varchar(80)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DstCnam)
                    .IsRequired()
                    .HasColumnName("dst_cnam")
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dstchannel)
                    .IsRequired()
                    .HasColumnName("dstchannel")
                    .HasColumnType("varchar(80)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Duration)
                    .HasColumnName("duration")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Lastapp)
                    .IsRequired()
                    .HasColumnName("lastapp")
                    .HasColumnType("varchar(80)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Lastdata)
                    .IsRequired()
                    .HasColumnName("lastdata")
                    .HasColumnType("varchar(80)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OutboundCnam)
                    .IsRequired()
                    .HasColumnName("outbound_cnam")
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OutboundCnum)
                    .IsRequired()
                    .HasColumnName("outbound_cnum")
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Recordingfile)
                    .IsRequired()
                    .HasColumnName("recordingfile")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Src)
                    .IsRequired()
                    .HasColumnName("src")
                    .HasColumnType("varchar(80)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Uniqueid)
                    .IsRequired()
                    .HasColumnName("uniqueid")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Userfield)
                    .IsRequired()
                    .HasColumnName("userfield")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });
        }
    }
}
