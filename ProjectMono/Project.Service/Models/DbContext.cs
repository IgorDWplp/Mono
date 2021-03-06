﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Project.Service.Models
{
   public class DbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext(DbContextOptions<DbContext> options): base(options){}
        public virtual DbSet<VehicleMake> vehicleMakes { get; set; }
        public virtual DbSet<VehicleModel> vehicleModels { get; set; }

        /// <summary>
        /// Kreiramo bazu i podatke koji su nam potrebni s time da overide virtual OnModelCreating
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedData();   
        }
    }
}
