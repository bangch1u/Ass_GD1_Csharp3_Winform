using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ass_GD1_Bangntph30138.DomainClass;

public partial class User
{
    [Key]
    [Column("userName")]
    [StringLength(50)]
    public string UserName { get; set; } = null!;

    [Column("passWord")]
    [StringLength(50)]
    public string? PassWord { get; set; }

    [Column("role")]
    [StringLength(50)]
    public string? Role { get; set; }
}
