using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tqtbaithigiuaky.Models
{
    public class TqtStudent
    {   
        [DisplayName("Tqt:Mã sinh viên")]
        [Required(ErrorMessage ="Tqt:Mã sinh viên không được để trống")]

        public uint TqtId { get; set; }

        [DisplayName("Tqt:Tên sinh viên")]
        [Required(ErrorMessage = "Tqt:Tên sinh viên không được để trống")]
        [RegularExpression(@"^[A-Za-z\s]{2,30}$", ErrorMessage = "Họ tên chỉ chứa ký tự A-Z a-z và khoảng trắng, tối thiểu 2 ký tự, tối đa 30 ký tự")]

        public String TqtFullname { get; set; }

        [DisplayName("Tqt:Email")]
        [Required(ErrorMessage = "Tqt:Email không được để trống ")]
        [RegularExpression(@"^[a-zA-z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2}",ErrorMessage = "Email chưa đúng định dạng ví dụ example@gmail.com")]
 
        public string TqtEmail { get; set; }

        [DisplayName("Tqt:Số điện thoại")]
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Số điện thoại phải có 10 chữ số")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Số điện thoại phải có đúng 10 chữ số")]
   
        public int TqtPhone { get; set; }
        [DisplayName("Tqt:Tuổi của sinh viên")]
        [Required(ErrorMessage = "Tqt:Không được để trống số tuổi" +
            "")]
        [Range(18,65,ErrorMessage ="số tuổi chưa đúng xin hãy nhập")]
  
        public int TqtTuoi { get; set; }

        [DisplayName("Tqt:Giới tính")]
        [Required(ErrorMessage = "Giới tính không được để trống")]
        [RegularExpression(@"^[01]$", ErrorMessage = "Giới tính chỉ được nhập 0 hoặc 1")]
        public int TqtGender { get; set; }   
    }
}