using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ass_GD1_Bangntph30138.DomainClass;

[Table("Grade")]
public partial class Grade
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("maSV")]
    [StringLength(50)]
    public string? MaSv { get; set; }

    [Column("tiengAnh")]
    public int? TiengAnh { get; set; }

    [Column("tinHoc")]
    public int? TinHoc { get; set; }

    [Column("gdtc")]
    public int? Gdtc { get; set; }

    [ForeignKey("MaSv")]
    [InverseProperty("Grades")]
    public virtual Student? MaSvNavigation { get; set; }
}
