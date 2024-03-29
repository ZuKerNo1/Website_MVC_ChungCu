
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
    using System.Collections.Generic;
    
public partial class TaiKhoan
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public TaiKhoan()
    {

        this.DuAns = new HashSet<DuAn>();

        this.Houses = new HashSet<House>();

        this.TinTucs = new HashSet<TinTuc>();

        this.GiaDiens = new HashSet<GiaDien>();

    }


    public int IDTaiKhoan { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public string Avatar { get; set; }

    public string FullName { get; set; }

    public Nullable<System.DateTime> Birthday { get; set; }

    public string Adress { get; set; }

    public string Phone { get; set; }

    public string Email { get; set; }

    public string POSITION { get; set; }

    public Nullable<byte> State { get; set; }

    public string Description { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<DuAn> DuAns { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<House> Houses { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<TinTuc> TinTucs { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<GiaDien> GiaDiens { get; set; }

}

}
