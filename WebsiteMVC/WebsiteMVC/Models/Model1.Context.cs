﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace WebsiteMVC.Models
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class HOUSEEntities : DbContext
{
    public HOUSEEntities()
        : base("name=HOUSEEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<AddressDuAn> AddressDuAns { get; set; }

    public virtual DbSet<AddressHouse> AddressHouses { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<DuAn> DuAns { get; set; }

    public virtual DbSet<House> Houses { get; set; }

    public virtual DbSet<ImageDuAn> ImageDuAns { get; set; }

    public virtual DbSet<ImageHouse> ImageHouses { get; set; }

    public virtual DbSet<InfoDuAn> InfoDuAns { get; set; }

    public virtual DbSet<InfoHouse> InfoHouses { get; set; }

    public virtual DbSet<Investor> Investors { get; set; }

    public virtual DbSet<Key> Keys { get; set; }

    public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

    public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

    public virtual DbSet<TinTuc> TinTucs { get; set; }

    public virtual DbSet<GiaDien> GiaDiens { get; set; }

}

}

