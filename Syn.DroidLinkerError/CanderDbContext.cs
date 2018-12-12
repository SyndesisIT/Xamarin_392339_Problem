using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Microsoft.EntityFrameworkCore;
using Unatec.SEOS.Discharges.Runnable.Droid.Model;

namespace Syn.DroidLinkerError
{
    class CanderDbContext
        : DbContext
    {
        private string DatabasePath { get; set; }

        public CanderDbContext(string dbPath)
        {
            DatabasePath = dbPath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={DatabasePath}");
        }

        public DbSet<Cander> Test { get; set; }
    }
}