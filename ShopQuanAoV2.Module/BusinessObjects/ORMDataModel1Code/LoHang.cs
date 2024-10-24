using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace ShopQuanAoV2.Module.BusinessObjects.ORMDataModel1
{

    public partial class LoHang
    {
        public LoHang(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction();
            if (Session.IsNewObject(this))
            {
                ngay_nhap = DateTime.Now;
                ngay_cap_nhat = DateTime.Now;
            }
        }
    }

}
