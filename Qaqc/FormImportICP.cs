using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace LimsProject
{
    public partial class FormImportICP : LibraryBasicForm.FormBaseEmpty
    {
        public FormImportICP()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database namedDB = factory.Create("las2010");

            cbMethods.Properties.DataSource = namedDB.ExecuteDataSet(CommandType.Text, "spFindIcpMethods").Tables[0];
            cbMethods.Properties.DisplayMember = "Name";
            cbMethods.Properties.ValueMember = "MethodId";
            
            deDateIni.DateTime = DateTime.Now;
            deDateEnd.DateTime = DateTime.Now;
        }

        private void btShowSamples_Click(object sender, EventArgs e)
        {
            // Configure the DatabaseFactory to read its configuration from the .config file 
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database namedDB = factory.Create("las2010");

            StringBuilder sql = new StringBuilder("spFindIcpSamples @DateIni='{0}', @DateEnd='{1}', @MethodName='{2}'");
            string dateIni = deDateIni.DateTime.ToString("yyyyMMdd");
            string dateEnd = deDateEnd.DateTime.ToString("yyyyMMdd");
            string method = cbMethods.Text;

            gridControl1.DataSource = namedDB.ExecuteDataSet(CommandType.Text, string.Format(sql.ToString(), dateIni, dateEnd, method)).Tables[0];
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Columns.GridColumn column = ((DevExpress.XtraGrid.Views.Grid.GridView)sender).PressedColumn;
            if (column == gcCol_Sel)
            {
                if (column.ImageIndex == 0)
                {
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        gridView1.SetRowCellValue(i, column, true);
                        gridView1.UpdateCurrentRow();
                    }
                    column.ImageIndex = 1;
                }
                else
                {
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        gridView1.SetRowCellValue(i, column, false);
                        gridView1.UpdateCurrentRow();
                    }
                    column.ImageIndex = 0;
                }                
            }
        }

        private void btImportar_Click(object sender, EventArgs e)
        {
            //importar datos seleccionados
            //string SamplesSelected = (gridControl1.DataSource as DataTable).AsEnumerable().
            var lst = (from t in (gridControl1.DataSource as DataTable).AsEnumerable()
                       where t.Field<bool>("Sel") == true
                       select new
                       {
                           Id = t.Field<int>("SamplesId").ToString()
                       });
            string SamplesSelected = string.Join("|", lst.Select(x=> x.Id));

            // importar desde base de datos del icp (sql server)
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database namedDB = factory.Create("las2010");

            StringBuilder sql = new StringBuilder("spFindIcpAnalysis @DateIni='{0}', @DateEnd='{1}', @MethodName='{2}', @SamplesSelected='{3}'");
            string dateIni = deDateIni.DateTime.ToString("yyyyMMdd");
            string dateEnd = deDateEnd.DateTime.ToString("yyyyMMdd");
            string method = cbMethods.Text;

            DataTable dtImport = namedDB.ExecuteDataSet(CommandType.Text, string.Format(sql.ToString(), dateIni, dateEnd, method, SamplesSelected)).Tables[0];

            // guardar en la base de datos del lims postgresql
        }        
    }
}
