using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LimsProject.BusinessLayer;
using LimsProject.BusinessLayer.Modules;
using DevExpress.XtraTreeList.Nodes;

namespace LimsProject
{
    public partial class ucTreeSolution : UserControl
    {
        #region calibration's attributes

        DevExpress.XtraTreeList.Nodes.TreeListNode treeStdCalib;
        DevExpress.XtraTreeList.Nodes.TreeListNode treeSolInterm1;
        DevExpress.XtraTreeList.Nodes.TreeListNode treeSolInterm2;
        DevExpress.XtraTreeList.Nodes.TreeListNode treeStdVerif;
        DevExpress.XtraTreeList.Nodes.TreeListNode treeSolTitration;

        CGroup_solution group_solution = null;
        CTemplate_method_aa template_method_aa = null;
        public int TypeSolution;
        
        public enum typeSolution
        {
            StdCalib = 1,
            SolInterm1 = 2,
            SolInterm2 = 3,
            StdVerif = 4,
            SolTitration = 5
        }

        #endregion

        public ucTreeSolution()
        {
            InitializeComponent();
        }

        public void InitTree(typeSolution[] typeSol)
        {
            treeStdCalib = treeSolution.Nodes[0].Clone() as TreeListNode;
            treeSolInterm1 = treeSolution.Nodes[1].Clone() as TreeListNode;
            treeSolInterm2 = treeSolution.Nodes[2].Clone() as TreeListNode;
            treeStdVerif = treeSolution.Nodes[3].Clone() as TreeListNode;
            treeSolTitration = treeSolution.Nodes[4].Clone() as TreeListNode;

            // --- solutions            
            treeStdCalib.Tag = Convert.ToInt32(typeSolution.StdCalib);
            treeSolInterm1.Tag = Convert.ToInt32(typeSolution.SolInterm1);
            treeSolInterm2.Tag = Convert.ToInt32(typeSolution.SolInterm2);
            treeStdVerif.Tag = Convert.ToInt32(typeSolution.StdVerif);
            treeSolTitration.Tag = Convert.ToInt32(typeSolution.SolTitration);

            treeSolution.Nodes.Clear();            

            for (int i = 0; i < typeSol.Length; i++)
            {
                if (typeSol[i] == typeSolution.StdCalib)
                    treeSolution.Nodes.Add(treeStdCalib);
                else if (typeSol[i] == typeSolution.SolInterm1)
                    treeSolution.Nodes.Add(treeSolInterm1);
                else if (typeSol[i] == typeSolution.SolInterm2)
                    treeSolution.Nodes.Add(treeSolInterm2);
                else if (typeSol[i] == typeSolution.StdVerif)
                    treeSolution.Nodes.Add(treeStdVerif);
                else if (typeSol[i] == typeSolution.SolTitration)
                    treeSolution.Nodes.Add(treeSolTitration);
            }


            treeStdCalib["Nombre"] = "Estandar de Calibración";
            treeSolInterm1["Nombre"] = "Solución Intermedia 1";
            treeSolInterm2["Nombre"] = "Solución Intermedia 2";
            treeStdVerif["Nombre"] = "Estandar de Verificación";
            treeSolTitration["Nombre"] = "Soluciones Titulantes";
            

            // --- limpiar nodos constantes
            //treeStdCalib.Nodes.Clear();
            //treeSolInterm1.Nodes.Clear();
            //treeSolInterm2.Nodes.Clear();
            //treeStdVerif.Nodes.Clear();
            //treeSolTitration.Nodes.Clear();

            ModSolution oModSolution = new ModSolution();
            CGroup_solutionFactory faGroup_solution = new CGroup_solutionFactory();
            List<CGroup_solution> lstGroup_solution =
                faGroup_solution
                .GetAll()
                .Where(x => x.Type_solution == Convert.ToInt32(typeSolution.StdCalib)
                    || x.Type_solution == Convert.ToInt32(typeSolution.SolInterm1)
                    || x.Type_solution == Convert.ToInt32(typeSolution.SolInterm2)
                    || x.Type_solution == Convert.ToInt32(typeSolution.StdVerif)
                    || x.Type_solution == Convert.ToInt32(typeSolution.SolTitration)).ToList();

            // 1:SC, 2:SI-1, 3:SI-2, 4:EV, 5:ST
            foreach (var item in lstGroup_solution)
            {
                // solución de calibracion (SC)
                if (item.Type_solution == 1)
                {
                    object[] obj = { item.Cod_solution, item.Idgroup_solution, item.Idmr_detail /*, item.Idsolution_pattern*/ };
                    TreeListNode node = treeSolution.AppendNode(obj, treeStdCalib);
                    node.Tag = treeStdCalib.Tag;
                    node.ImageIndex = 1;
                    node.SelectImageIndex = 1;
                }
                // solución intermedia 1, 2 y estandar de verificación
                if (item.Type_solution == 2 || item.Type_solution == 3 || item.Type_solution == 4) // --- agregar filas de la tabla de soluciones (intermedias)
                {
                    // --- agregar soluciones intermedia-1
                    List<CSolution> lstSolInterm1 = oModSolution.GetLstSolInterm1ByGroup(item.Idgroup_solution);
                    foreach (CSolution solution in lstSolInterm1)
                    {
                        object[] obj = { solution.Cod_solution, solution.Idgroup_solution, item.Idmr_detail };
                        TreeListNode node = treeSolution.AppendNode(obj, treeSolInterm1);
                        node.Tag = treeSolInterm1.Tag;
                        node.ImageIndex = 1;
                        node.SelectImageIndex = 1;
                    }

                    // --- agregar soluciones intermedia-2
                    List<CSolution> lstSolInterm2 = oModSolution.GetLstSolInterm2ByGroup(item.Idgroup_solution);
                    foreach (CSolution solution in lstSolInterm2)
                    {
                        object[] obj = { solution.Cod_solution, solution.Idgroup_solution, item.Idmr_detail };
                        TreeListNode node = treeSolution.AppendNode(obj, treeSolInterm2);
                        node.Tag = treeSolInterm2.Tag;
                        node.ImageIndex = 1;
                        node.SelectImageIndex = 1;
                    }

                    // --- agregar estandares de verificación
                    List<CSolution> lstStdVerif = oModSolution.GetLstStdVerifByGroup(item.Idgroup_solution);

                    foreach (CSolution solution in lstStdVerif)
                    {
                        object[] obj = { solution.Cod_solution, solution.Idgroup_solution, item.Idmr_detail };
                        TreeListNode node = treeSolution.AppendNode(obj, treeStdVerif);
                        node.Tag = treeStdVerif.Tag;
                        node.ImageIndex = 2;
                        node.SelectImageIndex = 2;
                    }
                }
                if (item.Type_solution == 5)
                {
                    object[] obj = { item.Cod_solution, item.Idgroup_solution, item.Idmr_detail };
                    TreeListNode node = treeSolution.AppendNode(obj, treeSolTitration);
                    node.Tag = treeSolTitration.Tag;
                    node.ImageIndex = 1;
                    node.SelectImageIndex = 1;
                }
            }

            treeSolution.ExpandAll();
        }

        
    }
}
