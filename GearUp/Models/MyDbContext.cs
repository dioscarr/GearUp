﻿using GearUp.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GearUp.Models
{
    public class MyDbContext:DbContext
    {
        public MyDbContext() : base("GearupCon")
        {

        }
        protected void OnMondelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MyDbContext, Configuration>());
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Make> make { get; set; }
        public virtual DbSet<Vehicle> vehicle { get; set; }

    }
}