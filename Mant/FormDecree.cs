using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LimsProject.BusinessLayer.Modules;
using LimsProject.BusinessLayer;
using LibraryBasicForm;

namespace LimsProject
{
    public partial class FormDecree : LibraryBasicForm.FormBaseEmpty
    {
        public enum LoadData
        {
            Nothing,            // solo se ha aperturado el módulo            
            MasterSearchPrice,  // cuando se cargan datos desde un buscador en el registro de cotización            
            FromDecree_ToDecree    // cuando se cargan datos desde una cotización a nueva versión de cotización                                      
        }

        CDecree oDecree = new CDecree();
        string msgConclusion = "La muestra {MUESTRA}, {CONCLUSION} con los Parámetros indicados para ";
        LoadData loadData = LoadData.Nothing;

        public FormDecree()
        {
            InitializeComponent();
            Init();
        }

        public FormDecree(CDecree pDecree, LoadData ploadData)
        {
            InitializeComponent();
            Init();

            loadData = ploadData;

            if (loadData == LoadData.FromDecree_ToDecree)
            {
                oDecree = new CDecreeFactory().GetAll().Where(x => x.Iddecree == pDecree.Iddecree).FirstOrDefault();

                if (oDecree != null)
                {
                    Recuperar_Registro();

                    tbCode.Text = "";
                    oDecree.Iddecree = 0;
                }
            }
        }

        void Init()
        {
            List<CCriterio> lstCriterio = Comun.GetLstCriterio();

            repCriterio.DataSource = lstCriterio;
            repCriterio.ValueMember = "Idcriterio";
            repCriterio.DisplayMember = "Nombre_criterio";

            repMetodo.DataSource = new Reception().GetMethodsForDecree();
            repMetodo.ValueMember = "Code";
            repMetodo.DisplayMember = "Name";

            repUnidadMedida.DataSource = new CMeasurement_unitFactory().GetAll();
            repUnidadMedida.DisplayMember = "Name_unit";
            repUnidadMedida.ValueMember = "Idunit";

            gcDecree.DataSource = new BindingList<CDecree_detail>(new Reception().GetLstDecree_detail(0));

            ucGenerar1.InitItems(new List<string>() { "A Nuevo decreto" });
        }

        protected override bool Son_Datos_Correctos()
        {
            if (tbName.Text.Trim().Length == 0)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Debe especificar un nombre al decreto.");
                return false;
            }
            if (meDescription.Text.Trim().Length == 0)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Debe especificar una descripción al decreto.");
                return false;
            }
            if (tbCumple.Text.Trim().Length == 0)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Debe especificar un texto para el campo \"cumple\"");
                return false;
            }
            if (tbNoCumple.Text.Trim().Length == 0)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Debe especificar un texto para el campo \"no cumple\"");
                return false;
            }
            if (tbCumpleOnlytest.Text.Trim().Length == 0)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Debe especificar un texto para el campo \"cumple solo los ensayos\"");
                return false;
            }
            if (meConclusion.Text.Trim().Length == 0)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Debe especificar un texto para el campo \"conclusión\"");
                return false;
            }
            foreach (CDecree_detail item in gcDecree.DataSource as BindingList<CDecree_detail>)
            {
                if (item.Idcondition == null)
                {
                    ComunForm.Send_message(this.Text, TypeMsg.error, "En el detalle: falta especificar la columna condición.");
                    return false;
                }
                if (item.Idtemplate_method == null)
                {
                    ComunForm.Send_message(this.Text, TypeMsg.error, "En el detalle: falta especificar la columna método.");
                    return false;
                }
                if (item.Idunit == null)
                {
                    ComunForm.Send_message(this.Text, TypeMsg.error, "En el detalle: falta especificar la columna unidad de medida.");
                    return false;
                }
                if (item.Parameter.Trim().Length == 0)
                {
                    ComunForm.Send_message(this.Text, TypeMsg.error, "En el detalle: falta especificar la columna parámetro.");
                    return false;
                }
                if (item.Idcondition <= 6 && item.Valor1.Trim().Length == 0)
                {
                    ComunForm.Send_message(this.Text, TypeMsg.error, "En el detalle: falta especificar la columna valor");
                    return false;
                }
                if (item.Idcondition == 7 && !(item.Valor1 != null && item.Valor2 != null && item.Valor1.Trim().Length != 0 && item.Valor2.Trim().Length != 0))
                {
                    decimal v1, v2;

                    if (!(decimal.TryParse(item.Valor1, out v1) && decimal.TryParse(item.Valor2, out v2)))
                    {
                        ComunForm.Send_message(this.Text, TypeMsg.error, "En el detalle: falta especificar correctamente en los campos para la condición \"entre\"");
                        return false;
                    }
                }
            }
            return true;
        }

        protected override void Limpiar_Campos()
        {
            tbCode.Text = "";
            tbName.Text = "";
            meDescription.Text = "";
            tbCumple.Text = "CUMPLE";
            tbNoCumple.Text = "CUMPLE";
            tbCumpleOnlytest.Text = "CUMPLE";
            meConclusion.Text = msgConclusion;

            gcDecree.DataSource = new BindingList<CDecree_detail>(new Reception().GetLstDecree_detail(0));
        }

        protected override void Recuperar_Registro()
        {
            tbCode.Text = oDecree.Cod_decree;
            tbName.Text = oDecree.Name_decree;
            meDescription.Text = oDecree.Description;
            tbCumple.Text = oDecree.Cumple;
            tbNoCumple.Text = oDecree.Nocumple;
            tbCumpleOnlytest.Text = oDecree.Cumple_onlytest;
            meConclusion.Text = oDecree.Conclusion;

            gcDecree.DataSource = new BindingList<CDecree_detail>(new Reception().GetLstDecree_detail(oDecree.Iddecree).Where(x=> x.Status == true).ToList());
        }

        protected override bool Grabar_Registro()
        {
            oDecree = oDecree == null ? new CDecree() : oDecree;

            oDecree.Name_decree = tbName.Text;
            oDecree.Description = meDescription.Text;
            oDecree.Cumple = tbCumple.Text;
            oDecree.Nocumple = tbNoCumple.Text;
            oDecree.Cumple_onlytest = tbCumpleOnlytest.Text;
            oDecree.Conclusion = meConclusion.Text;
            oDecree.Status = true;

            if (new CDecreeFactory().Update(oDecree))
            { 
                //eliminar todo
                foreach (CDecree_detail item in new CDecree_detailFactory().GetAll().Where(x => x.Status == true))
                {
                    item.Status = false;
                    new CDecree_detailFactory().Update(item);
                }

                //guardar items
                foreach (CDecree_detail item in gcDecree.DataSource as BindingList<CDecree_detail>)
                {
                    item.Iddecree = oDecree.Iddecree;
                    item.Status = true;
                    if (!new CDecree_detailFactory().Update(item))
                        new CDecree_detailFactory().Insert(item);
                }
            }
            else
            {
                if (new CDecreeFactory().Insert(oDecree))
                {
                    oDecree.Cod_decree = new ModCorrelatives().GetCorrelative(ModCorrelatives.Correlative.Decree);
                    new CDecreeFactory().Update(oDecree);

                    //guardar items
                    foreach (CDecree_detail item in gcDecree.DataSource as BindingList<CDecree_detail>)
                    {
                        item.Status = true;
                        item.Iddecree = oDecree.Iddecree;
                        new CDecree_detailFactory().Insert(item);
                    }
                }
            }
            return true;
        }

        private void ucToolStrip1_onFind()
        {            
            FormMasterSearch fmBusqueda = new FormMasterSearch();
            fmBusqueda.BindGrid(new ModMasterSearch().GetDecrees());

            fmBusqueda.ShowDialog();

            Dictionary<string, string> keys = fmBusqueda.getKeyValues();

            if (keys != null)
            {
                Limpiar_Campos();
                
                oDecree = new CDecreeFactory().GetAll().Where(x => x.Iddecree == Convert.ToInt32(keys["Iddecree"])).FirstOrDefault();

                Recuperar_Registro();
            }
        }

        private void ucSign1_OnSign(bool login)
        {
            if (login)
            {
                if (Son_Datos_Correctos())
                {
                    if (Grabar_Registro())
                    {
                        ucSign1.Clear();

                        FormMessage fmMessage = new FormMessage();
                        fmMessage.Title = "Guardado correctamente";
                        fmMessage.ShowDialog();

                        loadData = LoadData.MasterSearchPrice;

                        Recuperar_Registro();
                    }
                }
                else
                    ucSign1.Clear();
            }            
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Limpiar_Campos();
        }

        private void ucToolStrip1_onNew()
        {
            Limpiar_Campos();
        }

        private void ucGenerar1_onSelectedIndex(int index)
        {
            if (index == 0)
            {
                // nueva versión                
                FormDecree fmDecree = new FormDecree(oDecree, LoadData.FromDecree_ToDecree);
                fmDecree.ShowDialog();
            }            
        }
    }

    
}
