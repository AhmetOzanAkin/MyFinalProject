﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework;

// Context : Db tabloları ile proje classlarını bağlamak
public class NorthwindContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        
    }
    public DbSet<Product> Products { get; set; } // bendeki Product'u Products Tablosuna bağla
    public DbSet<Category> Categories { get; set; }
    public DbSet<Customer> Customers { get; set; }

}