﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WcfCrudUsers.Entities;

namespace WcfCrudUsers.EF
{
    // Code first from database
    public class UserContext : DbContext
    {
        public UserContext()
           : base("name=UserContext")
        {
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }
    }
}