﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
namespace ShopQuanAoV2.Module.BusinessObjects.ORMDataModel1
{

    [DefaultClassOptions]

    [DefaultProperty("so_luong")]
    public partial class ChiTietHoaDon : DevExpress.Persistent.BaseImpl.BaseObject
    {
        int fso_luong;
        public int so_luong
        {
            get { return fso_luong; }
            set { SetPropertyValue<int>(nameof(so_luong), ref fso_luong, value); }
        }
        decimal fdon_gia;
        public decimal don_gia
        {
            get { return fdon_gia; }
            set { SetPropertyValue<decimal>(nameof(don_gia), ref fdon_gia, value); }
        }
        [PersistentAlias("[don_gia] * ToDecimal([so_luong])")]
        public decimal thanh_tien
        {
            get { return (decimal)(EvaluateAlias(nameof(thanh_tien))); }
        }
        HoaDon fid_hoa_don;
        [Association(@"ChiTietHoaDonReferencesHoaDon")]
        public HoaDon id_hoa_don
        {
            get { return fid_hoa_don; }
            set { SetPropertyValue<HoaDon>(nameof(id_hoa_don), ref fid_hoa_don, value); }
        }
        LoHang fid_lo_hang;
        [Association(@"ChiTietHoaDonReferencesLoHang")]
        public LoHang id_lo_hang
        {
            get { return fid_lo_hang; }
            set
            {
                if (SetPropertyValue<LoHang>(nameof(id_lo_hang), ref fid_lo_hang, value)
                    && !IsLoading && !IsDeleted && value != null)
                {
                    don_gia = value.id_chi_tiet_san_pham.id_san_pham.gia_thanh;
                };
            }
        }
    }

}
