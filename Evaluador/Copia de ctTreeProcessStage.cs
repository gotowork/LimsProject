using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LimsProject.BusinessLayer;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

namespace LimsProject
{
    public partial class ctTreeProcessStage : UserControl
    {

        #region attributes
        
        BindingList<CTemplate_method_process_stage> lst_process_stage = new BindingList<CTemplate_method_process_stage>();

        public int IDTemplate_Method
        {
            get;
            set;
        }

        #endregion

        #region constructor

        public ctTreeProcessStage()
        {
            InitializeComponent();
        }

        #endregion         

        #region events

        public void Recuperate_process_stage(int idtemplate_method)
        {
            IDTemplate_Method = idtemplate_method;
            lst_process_stage = new BindingList<CTemplate_method_process_stage>(
                new CTemplate_method_process_stageFactory().GetByForeignKey(IDTemplate_Method)
                );
            treeProcessStage.DataSource = lst_process_stage;
            assignIcons();
        }

        public void Save_process_stage()
        {
            CTemplate_method_process_stageFactory faTemplate_method_process_stage = new CTemplate_method_process_stageFactory();
            for (int i = 0; i < lst_process_stage.Count; i++)
            {
                lst_process_stage[i].Order_process_stage = Convert.ToInt16(i);

                if (lst_process_stage[i].Idprocess == 0)
                    lst_process_stage[i].Idprocess = null;
                if (lst_process_stage[i].Idprocess_stage == 0)
                    lst_process_stage[i].Idprocess_stage = null;


                if (!faTemplate_method_process_stage.Update(lst_process_stage[i]))
                    faTemplate_method_process_stage.Insert(lst_process_stage[i]);
            }
        }

        public void InitCombos()
        {
            CProcessFactory faProcess = new CProcessFactory();
            var ProcessQuery = from table in faProcess.GetAll()
                          select new CItemGenericCombo
                          {
                              codigo = table.Idprocess.ToString(),
                              descripcion = table.Name_process
                          };
            cbProcess.AssignData(new List<CItemGenericCombo>(ProcessQuery));
            cbProcess.Refresh();
            //cbUnidadMedida1.FormAbout = Comun.Formulario.fmMeasurementUnit;
            //cbUnidadMedida1.EventShowForm += Comun.OpenForm;

            CProcess_stageFactory faProcess_stage = new CProcess_stageFactory();
            var StageQuery = from table in faProcess_stage.GetAll()
                          select new CItemGenericCombo
                          {
                              codigo = table.Idprocess_stage.ToString(),
                              descripcion = table.Name_process_stage
                          };
            cbStage.AssignData(new List<CItemGenericCombo>(StageQuery));
            cbStage.Refresh();
        }

        #endregion

        private void treeProcessStage_DragDrop(object sender, DragEventArgs e)
        {
            TreeListNode dragNode, targetNode;
            TreeList tl = sender as TreeList;
            Point p = tl.PointToClient(new Point(e.X, e.Y));

            dragNode = e.Data.GetData(typeof(TreeListNode)) as TreeListNode;           
            targetNode = tl.CalcHitInfo(p).Node;            

            tl.SetNodeIndex(dragNode, tl.GetNodeIndex(targetNode));            
            e.Effect = DragDropEffects.None;
        }

        private void btUpProcess_Click(object sender, EventArgs e)
        {
            AddProcessNode();
        }

        private void btUpStage_Click(object sender, EventArgs e)
        {
            AddStageNode();
        }

        void AddProcessNode()
        {
            // --- this method add a son node for one node selected
            lst_process_stage.Add(
                    new CTemplate_method_process_stage
                    {                                                
                        Idprocess = Convert.ToInt16(cbProcess.EditValue),
                        Idprocess_stage = 0,
                        Name_process_stage = cbProcess.EditText,
                        Idtemplate_method = IDTemplate_Method,
                        Id = GetNewIdNode(),
                        Parentid = 0
                    });
            treeProcessStage.DataSource = lst_process_stage;
            assignIcons();
        }

        void AddStageNode()
        {
            TreeListNode nodo = treeProcessStage.FocusedNode;
            if (nodo.ParentNode == null)
            {
                // --- this method add a son node for one node selected
                lst_process_stage.Add(
                        new CTemplate_method_process_stage
                        {
                            Idprocess = GetParentIdProcess(),
                            Idprocess_stage = Convert.ToInt16(cbStage.EditValue),
                            Name_process_stage = cbStage.EditText,
                            Idtemplate_method = IDTemplate_Method,
                            Id = GetNewIdNode(),
                            Parentid = GetParentIdNode()
                        });                
            }
            treeProcessStage.DataSource = lst_process_stage;
            assignIcons();
        }

        short GetNewIdNode()
        {
            // --- this method return a new node
            int? result;
            if ((result = lst_process_stage.Max(c => c.Id)) == null)
                result = 1;
            else
                result++;

            return Convert.ToInt16(result);
        }

        short GetParentIdNode()
        {
            // --- this method return the parent node
            int? result;
            if (lst_process_stage.Count == 0)
                result = 0;
            else
                result = Convert.ToInt32(treeProcessStage.FocusedNode["Id"]);

            return Convert.ToInt16(result);
        }

        short GetParentIdProcess()
        {
            int? result;
            if (lst_process_stage.Count == 0)
                result = 0;
            else
                result = Convert.ToInt32(treeProcessStage.FocusedNode["Idprocess"]);

            return Convert.ToInt16(result);
        }

        void assignIcons()
        {
            foreach (TreeListNode node in treeProcessStage.Nodes)
            {
                if (node.ParentNode == null)
                {
                    node.ImageIndex = 2;
                    node.SelectImageIndex = 4;
                    foreach (TreeListNode child in node.Nodes)
                    {
                        child.ImageIndex = 3;
                        child.SelectImageIndex = 4;
                    }
                }
            }
        }

    }
}
