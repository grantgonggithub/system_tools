using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CRM.Model
{
    public partial class my_system_dataContext : DbContext
    {
        public my_system_dataContext()
        {
        }

        public my_system_dataContext(DbContextOptions<my_system_dataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Verificationcode> Verificationcode { get; set; }
        public virtual DbSet<Userbuyproducts> Userbuyproducts { get; set; }
        public virtual DbSet<Userinfo> Userinfo { get; set; }
        public virtual DbSet<Userloginlog> Userloginlog { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Userbuyproducts>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("userbuyproducts");

                entity.HasComment("购买产品表");

                entity.HasIndex(e => e.Id)
                    .HasName("Id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasComment("购买时间");

                entity.Property(e => e.ExpiresDate)
                    .HasColumnType("datetime")
                    .HasComment("到期时间");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PaySeqNo)
                    .HasColumnType("varchar(50)")
                    .HasComment("支付流水号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayStatus)
                    .HasColumnType("int(1)")
                    .HasComment("支付状态：1、未支付；2、已支付；3、已取消；4、已退款");

                entity.Property(e => e.ProductId)
                    .HasColumnType("int(10)")
                    .HasComment("产品Id");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasComment("产品名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductPrice)
                    .HasColumnType("int(10)")
                    .HasComment("价格");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasComment("更新时间");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10)")
                    .HasComment("用户Id");
            });

            modelBuilder.Entity<Userinfo>(entity =>
            {
                entity.HasKey(e => e.Tel)
                    .HasName("PRIMARY");

                entity.ToTable("userinfo");

                entity.HasComment("用户注册表");

                entity.HasIndex(e => e.Id)
                    .HasName("Id");

                entity.Property(e => e.Tel)
                    .HasColumnType("varchar(15)")
                    .HasComment("手机号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.DeviceInfo)
                    .IsRequired()
                    .HasColumnType("varchar(500)")
                    .HasComment("测试时的设备信息")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DeviceNo)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("根据设备信息生成的唯一码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("注册时的Ip")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PassWord)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasComment("密码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasComment("更新时间");
            });

            modelBuilder.Entity<Userloginlog>(entity =>
            {
                entity.ToTable("userloginlog");

                entity.HasIndex(e => e.Id)
                    .HasName("Id");

                entity.Property(e => e.Id).HasColumnType("int(10)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeviceInfo)
                    .HasColumnType("varchar(500)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ip)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LoginDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnType("int(10)");
            });

            modelBuilder.Entity<Verificationcode>(entity =>
            {
                entity.HasKey(e => new { e.Tel, e.VerificationCode1 })
                    .HasName("PRIMARY");

                entity.ToTable("verificationcode");

                entity.HasIndex(e => e.Id)
                    .HasName("Id");

                entity.Property(e => e.Tel)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VerificationCode1)
                    .HasColumnName("VerificationCode")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10)")
                    .ValueGeneratedOnAdd();
            });


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
