﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using PIN_WOWRaids.Models;
using System;

namespace PIN_WOWRaids.Migrations
{
    [DbContext(typeof(PIN_WOWRaidsContext))]
    [Migration("20180215161842_id05")]
    partial class id05
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PIN_WOWRaids.Models.Member", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MainRole");

                    b.Property<string>("MainSpec");

                    b.Property<string>("NickName");

                    b.Property<string>("NumAttended");

                    b.Property<string>("OffRole");

                    b.Property<string>("OffSpec");

                    b.HasKey("Id");

                    b.ToTable("Member");
                });

            modelBuilder.Entity("PIN_WOWRaids.Models.RaidDays", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PeopleAttended");

                    b.Property<DateTime>("RaidDate");

                    b.Property<string>("RaidName");

                    b.HasKey("Id");

                    b.ToTable("RaidDays");
                });
#pragma warning restore 612, 618
        }
    }
}
