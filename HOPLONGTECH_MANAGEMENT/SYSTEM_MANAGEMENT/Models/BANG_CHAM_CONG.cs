//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SYSTEM_MANAGEMENT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BANG_CHAM_CONG
    {
        public int CHAM_CONG_ID { get; set; }
        public int USER_ID { get; set; }
        public string NGAY_CHUAN { get; set; }
        public string GIO_DI_MUON { get; set; }
        public string GIO_VE_SOM { get; set; }
        public string TANG_CA_NGAY_THUONG { get; set; }
        public string TANG_CA_NGAY_LE { get; set; }
        public string SO_LAN_QUEN_CHAM { get; set; }
        public string SO_NGAY_NGHI { get; set; }
        public string CONG_THUC_TE { get; set; }
        public string UNG_LUONG { get; set; }
        public string GHI_CHU { get; set; }
        public string THANG_CHAM_CONG { get; set; }
    
        public virtual USER USER { get; set; }
    }
}
