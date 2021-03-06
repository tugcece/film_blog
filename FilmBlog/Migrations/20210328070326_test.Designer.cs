// <auto-generated />
using FilmBlog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FilmBlog.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210328070326_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("FilmBlog.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BlogDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogImage1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogImage2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogImage3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogImage4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogImage5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogYazi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Blogs");
                });
#pragma warning restore 612, 618
        }
    }
}
