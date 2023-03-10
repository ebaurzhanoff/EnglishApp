// <auto-generated />
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230305204030_AddGrammarGroups")]
    partial class AddGrammarGroups
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("application")
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.CourseBoundaryModel.Course", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<int>("SortOrder")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Courses", "application");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "Grammar",
                            SortOrder = 1
                        },
                        new
                        {
                            Id = 2L,
                            Name = "Vocabulary",
                            SortOrder = 2
                        },
                        new
                        {
                            Id = 3L,
                            Name = "Listening",
                            SortOrder = 3
                        },
                        new
                        {
                            Id = 4L,
                            Name = "Speaking",
                            SortOrder = 4
                        });
                });

            modelBuilder.Entity("Domain.CourseBoundaryModel.Group", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("CourseId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<int>("SortOrder")
                        .HasColumnType("integer");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("Token")
                        .IsUnique();

                    b.ToTable("Groups", "application");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CourseId = 1L,
                            Name = "Present simple",
                            SortOrder = 1,
                            Token = "Grammar_PresentSimple"
                        },
                        new
                        {
                            Id = 2L,
                            CourseId = 1L,
                            Name = "Present continuous",
                            SortOrder = 2,
                            Token = "Grammar_PresentContinuous"
                        },
                        new
                        {
                            Id = 3L,
                            CourseId = 1L,
                            Name = "Present simple or present continuous",
                            SortOrder = 3,
                            Token = "Grammar_PresentSimpleOrPresentContinuous"
                        },
                        new
                        {
                            Id = 4L,
                            CourseId = 1L,
                            Name = "Past simple",
                            SortOrder = 4,
                            Token = "Grammar_PastSimple"
                        },
                        new
                        {
                            Id = 5L,
                            CourseId = 1L,
                            Name = "Present perfect",
                            SortOrder = 5,
                            Token = "Grammar_PresentPerfect"
                        },
                        new
                        {
                            Id = 6L,
                            CourseId = 1L,
                            Name = "Past simple or Present perfect",
                            SortOrder = 6,
                            Token = "Grammar_PastSimpleOrPresentPerfect"
                        },
                        new
                        {
                            Id = 7L,
                            CourseId = 1L,
                            Name = "Past continuous",
                            SortOrder = 7,
                            Token = "Grammar_PastContinuous"
                        },
                        new
                        {
                            Id = 8L,
                            CourseId = 1L,
                            Name = "Future simple",
                            SortOrder = 8,
                            Token = "Grammar_FutureSimple"
                        },
                        new
                        {
                            Id = 9L,
                            CourseId = 1L,
                            Name = "Future forms",
                            SortOrder = 9,
                            Token = "Grammar_FutureForms"
                        },
                        new
                        {
                            Id = 10L,
                            CourseId = 1L,
                            Name = "Modal verbs",
                            SortOrder = 10,
                            Token = "Grammar_ModalVerbs"
                        });
                });

            modelBuilder.Entity("Domain.LessonBoundaryModel.Lesson", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("GroupToken")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SortOrder")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .HasMaxLength(1024)
                        .HasColumnType("character varying(1024)");

                    b.HasKey("Id");

                    b.HasIndex("GroupToken", "SortOrder");

                    b.ToTable("Lessons", "application");
                });

            modelBuilder.Entity("Domain.LessonBoundaryModel.Unit", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("LessonId")
                        .HasColumnType("bigint");

                    b.Property<int>("SortOrder")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("LessonId");

                    b.ToTable("Units", "application");
                });

            modelBuilder.Entity("Domain.CourseBoundaryModel.Group", b =>
                {
                    b.HasOne("Domain.CourseBoundaryModel.Course", "Course")
                        .WithMany("Groups")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Domain.LessonBoundaryModel.Unit", b =>
                {
                    b.HasOne("Domain.LessonBoundaryModel.Lesson", "Lesson")
                        .WithMany("Units")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsMany("Domain.LessonBoundaryModel.Source", "Sources", b1 =>
                        {
                            b1.Property<long>("UnitId")
                                .HasColumnType("bigint");

                            b1.Property<long>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("bigint");

                            NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b1.Property<long>("Id"));

                            b1.Property<string>("Content")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<int>("SortOrder")
                                .HasColumnType("integer");

                            b1.HasKey("UnitId", "Id");

                            b1.ToTable("Sources", "application");

                            b1.WithOwner()
                                .HasForeignKey("UnitId");
                        });

                    b.OwnsOne("Domain.LessonBoundaryModel.UnitTask", "Task", b1 =>
                        {
                            b1.Property<long>("UnitId")
                                .HasColumnType("bigint");

                            b1.Property<long>("Id")
                                .HasColumnType("bigint");

                            b1.Property<string>("ImageUrl")
                                .HasColumnType("text");

                            b1.Property<string>("Text")
                                .HasColumnType("text");

                            b1.Property<string>("Title")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.HasKey("UnitId");

                            b1.ToTable("Tasks", "application");

                            b1.WithOwner()
                                .HasForeignKey("UnitId");
                        });

                    b.Navigation("Lesson");

                    b.Navigation("Sources");

                    b.Navigation("Task");
                });

            modelBuilder.Entity("Domain.CourseBoundaryModel.Course", b =>
                {
                    b.Navigation("Groups");
                });

            modelBuilder.Entity("Domain.LessonBoundaryModel.Lesson", b =>
                {
                    b.Navigation("Units");
                });
#pragma warning restore 612, 618
        }
    }
}
