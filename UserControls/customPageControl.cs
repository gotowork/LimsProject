using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimsProject
{
    public partial class customPageControl : DevExpress.XtraTab.XtraTabControl
    {
        public customPageControl()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Init();
        }

        void Init()
        {
            this.PaintStyleName = "PropertyView";
            this.AppearancePage.Header.BackColor = System.Drawing.Color.FromArgb(209, 222, 243);
            this.AppearancePage.Header.BorderColor = System.Drawing.Color.White;
            this.AppearancePage.Header.Options.UseBackColor = true;
            this.AppearancePage.Header.Options.UseBorderColor = true;
            this.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.LightSteelBlue;
            this.AppearancePage.HeaderActive.BorderColor = System.Drawing.Color.Gainsboro;
            this.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.AppearancePage.HeaderActive.Options.UseBorderColor = true;
            this.AppearancePage.PageClient.BorderColor = System.Drawing.Color.Gainsboro;
            this.AppearancePage.PageClient.Options.UseBorderColor = true;
        }
    }
}
