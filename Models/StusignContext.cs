using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Stusign.Models
{
    public partial class StusignContext : DbContext
    {
        public StusignContext()
        {
        }

        public StusignContext(DbContextOptions<StusignContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Stuinfo> Stuinfo { get; set; }
        public virtual DbSet<Systemset> Systemset { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stuinfo>(entity =>
            {
                entity.HasKey(e => e.身份证号);

                entity.ToTable("stuinfo");

                entity.Property(e => e.身份证号).HasMaxLength(18);

                entity.Property(e => e.五上体育).HasMaxLength(3);

                entity.Property(e => e.五上思品).HasMaxLength(3);

                entity.Property(e => e.五上数学).HasMaxLength(3);

                entity.Property(e => e.五上英语).HasMaxLength(3);

                entity.Property(e => e.五上语文).HasMaxLength(3);

                entity.Property(e => e.五下体育).HasMaxLength(3);

                entity.Property(e => e.五下思品).HasMaxLength(3);

                entity.Property(e => e.五下数学).HasMaxLength(3);

                entity.Property(e => e.五下英语).HasMaxLength(3);

                entity.Property(e => e.五下语文).HasMaxLength(3);

                entity.Property(e => e.五县三好).HasMaxLength(1).HasDefaultValue("0");

                entity.Property(e => e.五县优少).HasMaxLength(1).HasDefaultValue("0");

                entity.Property(e => e.五县优干).HasMaxLength(1).HasDefaultValue("0");

                entity.Property(e => e.五市三好).HasMaxLength(1).HasDefaultValue("0");

                entity.Property(e => e.五市优少).HasMaxLength(1).HasDefaultValue("0");

                entity.Property(e => e.五市优干).HasMaxLength(1).HasDefaultValue("0");

                entity.Property(e => e.五校三好).HasMaxLength(1).HasDefaultValue("0");

                entity.Property(e => e.五校优少).HasMaxLength(1).HasDefaultValue("0");

                entity.Property(e => e.五校优干).HasMaxLength(1).HasDefaultValue("0");

                entity.Property(e => e.住宅电话).HasMaxLength(11);

                entity.Property(e => e.入围方式).HasMaxLength(10);

                entity.Property(e => e.全国学籍号).HasMaxLength(19);

                entity.Property(e => e.六上体育).HasMaxLength(3);

                entity.Property(e => e.六上思品).HasMaxLength(3);

                entity.Property(e => e.六上数学).HasMaxLength(3);

                entity.Property(e => e.六上英语).HasMaxLength(3);

                entity.Property(e => e.六上语文).HasMaxLength(3);

                entity.Property(e => e.六县三好).HasMaxLength(1).HasDefaultValue("0");

                entity.Property(e => e.六县优少).HasMaxLength(1).HasDefaultValue("0");

                entity.Property(e => e.六县优干).HasMaxLength(1).HasDefaultValue("0");

                entity.Property(e => e.六市三好).HasMaxLength(1).HasDefaultValue("0");

                entity.Property(e => e.六市优少).HasMaxLength(1).HasDefaultValue("0");

                entity.Property(e => e.六市优干).HasMaxLength(1).HasDefaultValue("0");

                entity.Property(e => e.六校三好).HasMaxLength(1).HasDefaultValue("0");

                entity.Property(e => e.六校优少).HasMaxLength(1).HasDefaultValue("0");

                entity.Property(e => e.六校优干).HasMaxLength(1).HasDefaultValue("0");

                entity.Property(e => e.出生年月).HasMaxLength(20);

                entity.Property(e => e.姓名).HasMaxLength(8);

                entity.Property(e => e.兴趣爱好).HasMaxLength(20);

                entity.Property(e => e.县级以上荣誉).HasMaxLength(120);

                entity.Property(e => e.学生职务).HasMaxLength(20);

                entity.Property(e => e.学生实际住址).HasMaxLength(100);

                entity.Property(e => e.学生组别).HasMaxLength(1);

                entity.Property(e => e.审核人员).HasMaxLength(10);

                entity.Property(e => e.审核结果).HasDefaultValue(true);

                entity.Property(e => e.审核位置).HasMaxLength(10);

                entity.Property(e => e.开放状态)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.性别).HasMaxLength(2);

                entity.Property(e => e.户口所在地).HasMaxLength(50);

                entity.Property(e => e.打印人员).HasMaxLength(20);

                entity.Property(e => e.打印时间).HasColumnType("datetime");

                entity.Property(e => e.报读校区).HasMaxLength(1).HasDefaultValue("B");

                entity.Property(e => e.操作人员).HasMaxLength(10);

                entity.Property(e => e.操作状态)
                    .HasMaxLength(10)
                    .HasDefaultValue("2");

                entity.Property(e => e.母亲姓名).HasMaxLength(8);

                entity.Property(e => e.母亲学历).HasMaxLength(8);

                entity.Property(e => e.母亲工作单位).HasMaxLength(80);

                entity.Property(e => e.母亲职业类别).HasMaxLength(50);

                entity.Property(e => e.母亲电话).HasMaxLength(11);

                entity.Property(e => e.母亲职务).HasMaxLength(11);

                entity.Property(e => e.毕业学校).HasMaxLength(50);

                entity.Property(e => e.活动位置).HasMaxLength(10);

                entity.Property(e => e.父亲姓名).HasMaxLength(8);

                entity.Property(e => e.父亲学历).HasMaxLength(8);

                entity.Property(e => e.父亲工作单位).HasMaxLength(100);

                entity.Property(e => e.父亲职业类别).HasMaxLength(50);

                entity.Property(e => e.父亲电话).HasMaxLength(11);

                entity.Property(e => e.父亲职务).HasMaxLength(11);

                entity.Property(e => e.生源地).HasMaxLength(12);

                entity.Property(e => e.登记地址).HasMaxLength(20);

                entity.Property(e => e.登记时间)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.编号).ValueGeneratedOnAdd();

                entity.Property(e => e.卡片打印).HasDefaultValue(false);

                entity.Property(e => e.考场编号).HasMaxLength(10);

                entity.Property(e => e.门检时间).HasColumnType("datetime");
            });

            modelBuilder.Entity<Systemset>(entity =>
            {
                entity.ToTable("systemset");

                entity.Property(e => e.Id).HasColumnName("ID");


                entity.Property(e => e.验证码id)
                    .HasColumnName("验证码ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.验证码key)
                    .HasColumnName("验证码KEY")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
