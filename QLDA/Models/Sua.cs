//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLDA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sua
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sua()
        {
            this.DatHang_ChiTiet = new HashSet<DatHang_ChiTiet>();
        }
    
        public int ID { get; set; }
        public Nullable<int> HangSX_ID { get; set; }
        public Nullable<int> LoaiSua_ID { get; set; }
        public string TenSua { get; set; }
        public Nullable<int> DonGia { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public string AnhMau { get; set; }
        public string MoTa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatHang_ChiTiet> DatHang_ChiTiet { get; set; }
        public virtual HangSX HangSX { get; set; }
        public virtual LoaiSua LoaiSua { get; set; }
    }
}
