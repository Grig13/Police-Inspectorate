﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PoliceInspectorate.Context;

#nullable disable

namespace Police_Inspectorate.Migrations
{
    [DbContext(typeof(PoliceInspectorateContext))]
    partial class PoliceInspectorateContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CaseSuspect", b =>
                {
                    b.Property<Guid>("CasesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SuspectsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CasesId", "SuspectsId");

                    b.HasIndex("SuspectsId");

                    b.ToTable("CaseSuspect");
                });

            modelBuilder.Entity("MeetingPoliceAgent", b =>
                {
                    b.Property<Guid>("AgentsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MeetingsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AgentsId", "MeetingsId");

                    b.HasIndex("MeetingsId");

                    b.ToTable("MeetingPoliceAgent");
                });

            modelBuilder.Entity("Police_Inspectorate.Models.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("Police_Inspectorate.Models.Case", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BeginDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Cases");
                });

            modelBuilder.Entity("Police_Inspectorate.Models.InspectorateChief", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("InspectorateChief");
                });

            modelBuilder.Entity("Police_Inspectorate.Models.Meeting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Meetings");
                });

            modelBuilder.Entity("Police_Inspectorate.Models.PoliceAgent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<Guid?>("CaseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("StationChief")
                        .HasColumnType("bit");

                    b.Property<Guid?>("StationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("StationNumber")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CaseId");

                    b.HasIndex("StationId");

                    b.ToTable("PoliceAgents");
                });

            modelBuilder.Entity("Police_Inspectorate.Models.Request", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PoliceAgentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Response")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("PoliceAgentId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("Police_Inspectorate.Models.Station", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stations");
                });

            modelBuilder.Entity("Police_Inspectorate.Models.Suspect", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LastName")
                        .HasColumnType("int");

                    b.Property<string>("Record")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Suspects");
                });

            modelBuilder.Entity("CaseSuspect", b =>
                {
                    b.HasOne("Police_Inspectorate.Models.Case", null)
                        .WithMany()
                        .HasForeignKey("CasesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Police_Inspectorate.Models.Suspect", null)
                        .WithMany()
                        .HasForeignKey("SuspectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MeetingPoliceAgent", b =>
                {
                    b.HasOne("Police_Inspectorate.Models.PoliceAgent", null)
                        .WithMany()
                        .HasForeignKey("AgentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Police_Inspectorate.Models.Meeting", null)
                        .WithMany()
                        .HasForeignKey("MeetingsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Police_Inspectorate.Models.PoliceAgent", b =>
                {
                    b.HasOne("Police_Inspectorate.Models.Case", null)
                        .WithMany("Agents")
                        .HasForeignKey("CaseId");

                    b.HasOne("Police_Inspectorate.Models.Station", null)
                        .WithMany("Agents")
                        .HasForeignKey("StationId");
                });

            modelBuilder.Entity("Police_Inspectorate.Models.Request", b =>
                {
                    b.HasOne("Police_Inspectorate.Models.PoliceAgent", null)
                        .WithMany("Requests")
                        .HasForeignKey("PoliceAgentId");
                });

            modelBuilder.Entity("Police_Inspectorate.Models.Case", b =>
                {
                    b.Navigation("Agents");
                });

            modelBuilder.Entity("Police_Inspectorate.Models.PoliceAgent", b =>
                {
                    b.Navigation("Requests");
                });

            modelBuilder.Entity("Police_Inspectorate.Models.Station", b =>
                {
                    b.Navigation("Agents");
                });
#pragma warning restore 612, 618
        }
    }
}
