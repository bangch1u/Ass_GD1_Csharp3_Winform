using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ass_GD1_Bangntph30138.DomainClass;

public partial class Student
{
    [Key]
    [Column("maSV")]
    [StringLength(50)]
    public string MaSv { get; set; } = null!;

    [Column("hoten")]
    [StringLength(50)]
    public string? Hoten { get; set; }

    [Column("email")]
    [StringLength(50)]
    public string? Email { get; set; }

    [Column("soDT")]
    [StringLength(15)]
    public string? SoDt { get; set; }

    [Column("gioiTinh")]
    public bool? GioiTinh { get; set; }

    [Column("diaChi")]
    [StringLength(50)]
    public string? DiaChi { get; set; }

    [Column("hinh")]
    [StringLength(50)]
    public string? Hinh { get; set; }

    [InverseProperty("MaSvNavigation")]
    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();
}
