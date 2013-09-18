using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibraryBasicForm;

namespace LimsProject
{
    public delegate void ShowForm(Comun.Formulario form);

    public delegate void CallMasterSearch();

    public partial class FormPrincipal : Form
    {
        public event CallMasterSearch onCallMasterSearch;

        public FormPrincipal()
        {
            InitializeComponent();            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            FormLogin fmLogin = new FormLogin();
            Comun.Even_show_user += Comun_Even_show_user;

            if (fmLogin.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Comun.Even_show_action += Comun_Even_show_action;

                expandablePanel1.Visible = true;
            }
        }

        void Comun_Even_show_user(string user)
        {
            barUsuario.Caption = user;
        }

        void Comun_Even_show_action(string module, TypeMsg type_msg, string msg_action)
        {
            if (type_msg == TypeMsg.error)
                MessageBox.Show(msg_action, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            baritemModulo.Caption = module;
            baritemAccion.Caption = msg_action;

            if (type_msg == TypeMsg.error)            
                baritemBoton.ImageIndex = 1;
            if (type_msg == TypeMsg.ok)
                baritemAccion.ImageIndex = 0;
        }

        void FormPrincipal_delegado(Comun.Formulario form)
        {
            throw new NotImplementedException();
        }        

        private void nbiMethod_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormMethod ofmMethod = new FormMethod();
            //ofmMethod.MdiParent = this;
            //ofmMethod.WindowState = FormWindowState.Maximized;
            ofmMethod.Show();
        }

        private void nbiDigestion_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Comun.OpenForm(Comun.Formulario.fmDigestion);
        }

        private void nbiElement_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Comun.OpenForm(Comun.Formulario.fmElement);
        }

        private void nbiTypeSample_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Comun.OpenForm(Comun.Formulario.fmTypeSample);
        }

        private void nbiReception_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormReception ofmReception = new FormReception(FormReception.typeModule.RegisterReception);
            //ofmReception.MdiParent = this;
            //ofmReception.WindowState = FormWindowState.Maximized;
            ofmReception.Show();
        }

        private void nbiPrice_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {            
            FormPrice ofmPrice = new FormPrice();
            //ofmPrice.MdiParent = this;
            //ofmPrice.WindowState = FormWindowState.Maximized;
            ofmPrice.Show();
        }

        private void nbiDescSample_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Comun.OpenForm(Comun.Formulario.fmDescriptionSample);
        }

        private void nbiClient_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Comun.OpenForm(Comun.Formulario.fmEmpresa);
        }

        private void nbiMeasurement_unit_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Comun.OpenForm(Comun.Formulario.fmMeasurementUnit);
        }

        private void nbiConvertUM_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Comun.OpenForm(Comun.Formulario.fmConvertionUM);
        }

        private void nbiCorrelative_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Comun.OpenForm(Comun.Formulario.fmCorrelative);
        }

        private void nbiMaterialReference_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormMaterialReference ofmMaterialReference = new FormMaterialReference();
            //ofmMaterialReference.MdiParent = this;
            //ofmMaterialReference.WindowState = FormWindowState.Maximized;
            ofmMaterialReference.Show();
        }

        private void nbiModuloQaQc_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormNewQaQc ofmQaQc = new FormNewQaQc();
            //ofmQaQc.MdiParent = this;
            //ofmQaQc.WindowState = FormWindowState.Maximized;
            ofmQaQc.Show();
        }

        private void nbiUsers_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Comun.OpenForm(Comun.Formulario.fmUser);
        }

        private void nbiSolution_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormSolInterm fmSolInterm = new FormSolInterm();
            //ofmSolutions.MdiParent = this;
            //ofmSolutions.WindowState = FormWindowState.Maximized;
            fmSolInterm.Show();
        }

        private void nbiTypeSolution_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Comun.OpenForm(Comun.Formulario.fmTypeSolution);
        }

        private void nbiAuthorizations_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormDocument ofmDocument = new FormDocument();
            //ofmDocument.MdiParent = this;
            //ofmDocument.WindowState = FormWindowState.Maximized;
            ofmDocument.Show();
        }

        private void nbiReactive_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Comun.OpenForm(Comun.Formulario.fmReactive);
        }

        private void btFind_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form fm = this.ActiveMdiChild;
            if (onCallMasterSearch != null)
                onCallMasterSearch();
        }

        private void btPrevius_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btNext_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void nbiItemMatrix_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Comun.OpenForm(Comun.Formulario.fmMatrixItem);
        }

        private void nbiGroupMatrix_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Comun.OpenForm(Comun.Formulario.fmMatrixGroup);
        }

        private void nbiDecrees_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Comun.OpenForm(Comun.Formulario.fmDecree);
        }

        private void nbiPrueba_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Comun.OpenForm(Comun.Formulario.fmPreparationSamples);
        }

        private void nbiCompuestos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Comun.OpenForm(Comun.Formulario.fmCompound);
        }

        private void nbiFactorEstequ_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Comun.OpenForm(Comun.Formulario.fmFactorEstequ);
        }

        

    }
}
