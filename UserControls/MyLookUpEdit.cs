using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;
using System.ComponentModel;
using DevExpress.XtraEditors.ListControls;
using DevExpress.Data.Filtering;
using DevExpress.Data.Filtering.Helpers;

namespace LimsProject
{
    [UserRepositoryItem("RegisterCustomEdit")]
    public class RepositoryItemMyLookUpEdit : RepositoryItemLookUpEdit
    {
        public const string CustomEditName = "MyLookUpdit";

        static RepositoryItemMyLookUpEdit() { RegisterCustomEdit(); }

        public override string EditorTypeName { get { return CustomEditName; } }

        public static void RegisterCustomEdit()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName,
              typeof(MyLookUpEdit), typeof(RepositoryItemMyLookUpEdit),
              typeof(LookUpEditViewInfo), new ButtonEditPainter(), true, null));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemMyLookUpEdit source = (RepositoryItemMyLookUpEdit)item;
            }
            finally { EndUpdate(); }
        }

        protected override LookUpListDataAdapter CreateDataAdapter() { return new MyLookUpListDataAdapter(this); }
    }

    public class MyLookUpEdit : LookUpEdit
    {
        static MyLookUpEdit() { RepositoryItemMyLookUpEdit.RegisterCustomEdit(); }

        public override string EditorTypeName { get { return RepositoryItemMyLookUpEdit.CustomEditName; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemMyLookUpEdit Properties { get { return (RepositoryItemMyLookUpEdit)base.Properties; } }
    }

    public class MyLookUpListDataAdapter : LookUpListDataAdapter
    {
        public MyLookUpListDataAdapter(RepositoryItemMyLookUpEdit item) : base(item) { }

        protected override string CreateFilterExpression()
        {
            if (string.IsNullOrEmpty(FilterPrefix)) return string.Empty;
            //string likeClause = DevExpress.Data.Filtering.Helpers.LikeData.CreateStartsWithPattern(FilterPrefix);  // --- version 9
            string likeClause = DevExpress.Data.Filtering.Helpers.LikeData.Create(FilterPrefix).Pattern;
            return new BinaryOperator(FilterField, "%" + likeClause + "%", BinaryOperatorType.Like).ToString();
        }
    }
}
