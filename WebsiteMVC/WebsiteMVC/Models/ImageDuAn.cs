
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
    
public partial class ImageDuAn
{

    public int IDImageDuAn { get; set; }

    public Nullable<int> IDDuAn { get; set; }

    public string Link { get; set; }

    public Nullable<int> Rank { get; set; }



    public virtual DuAn DuAn { get; set; }

}

}