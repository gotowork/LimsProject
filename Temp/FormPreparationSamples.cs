using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace LimsProject
{
    public partial class FormPreparationSamples : Form
    {
        public FormPreparationSamples()
        {
            InitializeComponent();
        }

        void Load_preparation_sample()
        {
            BindingList<CPreparationSamples> lstPreparationSample = new BindingList<CPreparationSamples>();
            lstPreparationSample.Add(new CPreparationSamples { Idpreparation_sample = 0, Id = 1, Parentid = 0, Name = "MN001", Name_node = "MN001", Title = "", Status_send_sample = 1, DH_input = DateTime.Now, Nro_view = 0, Chek_send = 1, Path_file_attach = @"\\LAS0020-PC\Compartido-LAS\2013\procedimientos de ensayo externos" });
            lstPreparationSample.Add(new CPreparationSamples { Idpreparation_sample = 0, Id = 2, Parentid = 1, Name = "501 Ag AA", Name_node = "501 Ag AA", Title = "", Status_send_sample = 0, DH_input = null, Nro_view = 0, Chek_send = 0, Path_file_attach = @"\\LAS0020-PC\Compartido-LAS\2013\procedimientos de ensayo externos" });
            lstPreparationSample.Add(new CPreparationSamples { Idpreparation_sample = 0, Id = 3, Parentid = 2, Name = "E-001.pdf", Name_node = "R-001", Title = "muestra con tal propiedad", Status_send_sample = 0, DH_input = DateTime.Now, Nro_view = 0, Chek_send = 0, Path_file_attach = @"\\LAS0020-PC\Compartido-LAS\2013\procedimientos de ensayo externos" });
            lstPreparationSample.Add(new CPreparationSamples { Idpreparation_sample = 0, Id = 4, Parentid = 2, Name = "M-001.pdf", Name_node = "T-001", Title = "especificacion1", Status_send_sample = 0, DH_input = null, Nro_view = 0, Chek_send = 0, Path_file_attach = @"\\LAS0020-PC\Compartido-LAS\2013\procedimientos de ensayo externos" });
            lstPreparationSample.Add(new CPreparationSamples { Idpreparation_sample = 0, Id = 5, Parentid = 2, Name = "M-002.pdf", Name_node = "T-002", Title = "especificacion2", Status_send_sample = 0, DH_input = null, Nro_view = 0, Chek_send = 0, Path_file_attach = @"\\LAS0020-PC\Compartido-LAS\2013\procedimientos de ensayo externos" });
            lstPreparationSample.Add(new CPreparationSamples { Idpreparation_sample = 0, Id = 6, Parentid = 2, Name = "M-003.pdf", Name_node = "T-003", Title = "especificacion3", Status_send_sample = 0, DH_input = null, Nro_view = 0, Chek_send = 0, Path_file_attach = @"\\LAS0020-PC\Compartido-LAS\2013\procedimientos de ensayo externos" });
            lstPreparationSample.Add(new CPreparationSamples { Idpreparation_sample = 0, Id = 7, Parentid = 1, Name = "502 Cu AA", Name_node = "502 Cu AA", Title = "", Status_send_sample = 0, DH_input = null, Nro_view = 0, Chek_send = 0, Path_file_attach = @"\\LAS0020-PC\Compartido-LAS\2013\procedimientos de ensayo externos" });
            lstPreparationSample.Add(new CPreparationSamples { Idpreparation_sample = 0, Id = 8, Parentid = 7, Name = "E-002", Name_node = "R-002", Title = "muestra con tal propiedad", Status_send_sample = 0, DH_input = null, Nro_view = 0, Chek_send = 0, Path_file_attach = @"\\LAS0020-PC\Compartido-LAS\2013\procedimientos de ensayo externos" });
            lstPreparationSample.Add(new CPreparationSamples { Idpreparation_sample = 0, Id = 9, Parentid = 7, Name = "M-004", Name_node = "T-001", Title = "especificacion1", Status_send_sample = 0, DH_input = null, Nro_view = 0, Chek_send = 0, Path_file_attach = @"\\LAS0020-PC\Compartido-LAS\2013\procedimientos de ensayo externos" });
            lstPreparationSample.Add(new CPreparationSamples { Idpreparation_sample = 0, Id = 10, Parentid = 0, Name_node = "MN002", Title = "", Status_send_sample = 1, DH_input = DateTime.Now, Nro_view = 0, Chek_send = 1, Path_file_attach = @"\\LAS0020-PC\Compartido-LAS\2013\procedimientos de ensayo externos" });

            treePreparationSample.DataSource = lstPreparationSample;
        }

        private void FormPreparationSamples_Load(object sender, EventArgs e)
        {
            Load_preparation_sample();
        }

        private void treePreparationSample_Click(object sender, EventArgs e)
        {
            DevExpress.XtraTreeList.TreeList treelist = sender as DevExpress.XtraTreeList.TreeList;
            if (treelist.State == DevExpress.XtraTreeList.TreeListState.NodePressed
                && treelist.FocusedColumn == trCol_Chek_send)
            {
                if (treelist.FocusedNode.ParentNode == null)
                {
                    int value = Convert.ToInt32(treelist.FocusedNode.GetValue("Chek_send"));
                    if (value == 1)
                        treelist.FocusedNode.SetValue("Chek_send", 2);
                    if (value == 2)
                        treelist.FocusedNode.SetValue("Chek_send", 1);                    
                }
            }
        }

        private void repAttach_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            // --- open document
            if (e.Button.Index == 0)
            {
                try
                {
                    string path = treePreparationSample.FocusedNode.GetValue("Path_file_attach").ToString();
                    string path_filename = System.IO.Path.Combine(path, treePreparationSample.FocusedNode.GetValue("Name").ToString());
                    Process.Start(path_filename);
                }
                catch //(Exception ex)
                {
                    //Comun.Send_message(this.Text, TypeMsg.error, ex.Message);
                }
            }
            // --- add description
            if (e.Button.Index == 1)
            {
                try
                {
                    FormAttachDescription fmAttachDescription = new FormAttachDescription();
                    if (fmAttachDescription.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        treePreparationSample.FocusedNode.SetValue("Title", fmAttachDescription.Description);
                }
                catch (Exception ex)
                {
                    Comun.Send_message(this.Text, TypeMsg.error, ex.Message);
                }
            }
        }

        private void repAttach_Enter(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.ButtonEdit button = sender as DevExpress.XtraEditors.ButtonEdit;
            if (treePreparationSample.FocusedNode.Level == 0)
            {
                button.Properties.Buttons[0].Visible = false;
                button.Properties.Buttons[1].Visible = true;
            }
            else if (treePreparationSample.FocusedNode.Level == 1)
            {
                button.Properties.Buttons[0].Visible = false;
                button.Properties.Buttons[1].Visible = false;
            }
            else if (treePreparationSample.FocusedNode.Level == 2)
            {
                button.Properties.Buttons[0].Visible = true;
                button.Properties.Buttons[1].Visible = false;
            }
        }
    }

    public class CPreparationSamples
    {
        public long Idpreparation_sample { get; set; }
        public long Idrecep_sample_elem { get; set; }
        public short Iduser { get; set; }
        public int Id { get; set; }
        public int Parentid { get; set; }
        public string Name_node { get; set; }
        public string Name { get; set; }
        public int Nro_view { get; set; }
        public string Title { get; set; }
        public int Status_send_sample { get; set; } // 0:recibido, 1: proceso, 2: terminado
        public DateTime? DH_input { get; set; }
        public DateTime? DH_output_reception { get; set; }
        public string Path_file_attach { get; set; }
        public int Chek_send { get; set; }        
        public bool Flag_description { get; set; }
        public bool Flag_attach_document { get; set; }
    }
}
