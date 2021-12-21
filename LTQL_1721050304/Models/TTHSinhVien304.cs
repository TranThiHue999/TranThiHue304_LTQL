using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL_1721050304.Models
{
    public class TTHSinhVien304
    {
        [Key]
        [Display(Name = "Mã Sinh Viên")]
        [StringLength(20)]
        public string MaSinhVien { get; set; }
        [Display(Name = "Họ và tên")]
        [StringLength(50)]
        public string HoTen { get; set; }
        public int MaLop { get; set; }
        [ForeignKey("MaLop")]
        public virtual LopHoc304 LopHoc304s { get; set; }
    }
}