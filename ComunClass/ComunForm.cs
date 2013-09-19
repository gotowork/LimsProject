using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using LimsProject.BusinessLayer;

namespace LimsProject
{
    public delegate void ShowAction(string module, TypeMsg type_msg, string msg_action);

    public delegate void ShowUser(string user);

    public static class ComunForm
    {
        public static event ShowAction Even_show_action;
        public static event ShowUser Even_show_user;

        public enum Formulario
        {
            fmElement,
            fmTypeSample,
            fmDigestion,
            fmReception,
            fmDescriptionSample,
            fmEmpresa,
            fmMeasurementUnit,
            fmConvertionUM,
            fmCorrelative,
            fmMaterialReference,
            fmUser,
            fmPatternSolution,
            fmTypeSolution,
            fmReactive,
            fmMatrixGroup,
            fmMatrixItem,
            fmDecree,
            fmPreparationSamples,
            fmCompound,
            fmFactorEstequ
        }

        public static void Send_message(string module, TypeMsg type_msg, string msg)
        {
            Even_show_action(module, type_msg, msg);
        }

        public static void Send_user()
        {
            Even_show_user(Comun.User_system.Cod_user);
        }

        public static void OpenForm(Formulario form)
        {
            switch (form)
            {
                case Formulario.fmElement:
                    FormElement fmElement = new FormElement();
                    fmElement.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                    fmElement.Show();
                    break;
                case Formulario.fmTypeSample:
                    FormTypeSample fmTypeSample = new FormTypeSample();
                    fmTypeSample.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                    fmTypeSample.Show();
                    break;
                case Formulario.fmDigestion:
                    FormDigestion fmDigestion = new FormDigestion();
                    fmDigestion.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                    fmDigestion.Show();
                    break;
                case Formulario.fmReception:
                    FormReception fmReception = new FormReception();
                    fmReception.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                    fmReception.Show();
                    break;
                case Formulario.fmDescriptionSample:
                    FormDescription fmDescription = new FormDescription();
                    fmDescription.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                    fmDescription.Show();
                    break;
                case Formulario.fmEmpresa:
                    FormEmpresa fmClient = new FormEmpresa();
                    fmClient.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                    fmClient.Show();
                    break;
                case Formulario.fmMeasurementUnit:
                    FormUnitMeasure fmMeasurment_unit = new FormUnitMeasure();
                    fmMeasurment_unit.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                    fmMeasurment_unit.Show();
                    break;
                case Formulario.fmConvertionUM:
                    FormConvertUM fmConvertionUM = new FormConvertUM();
                    fmConvertionUM.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                    fmConvertionUM.Show();
                    break;
                case Formulario.fmCorrelative:
                    FormCorrelatives fmCorrelative = new FormCorrelatives();
                    fmCorrelative.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                    fmCorrelative.Show();
                    break;
                case Formulario.fmMaterialReference:
                    FormMaterialReference fmMaterialReference = new FormMaterialReference();
                    fmMaterialReference.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                    fmMaterialReference.Show();
                    break;
                case Formulario.fmUser:
                    FormUser fmUser = new FormUser();
                    fmUser.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                    fmUser.Show();
                    break;
                case Formulario.fmTypeSolution:
                    FormTypeSolution fmTypeSolution = new FormTypeSolution();
                    fmTypeSolution.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                    fmTypeSolution.Show();
                    break;
                case Formulario.fmReactive:
                    FormReactives fmReactives = new FormReactives();
                    fmReactives.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                    fmReactives.Show();
                    break;
                case Formulario.fmMatrixGroup:
                    FormGroupMatrix fmMatrizGroup = new FormGroupMatrix();
                    fmMatrizGroup.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                    fmMatrizGroup.Show();
                    break;
                case Formulario.fmMatrixItem:
                    FormMatrixItems fmMatrizItem = new FormMatrixItems();
                    fmMatrizItem.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                    fmMatrizItem.Show();
                    break;
                case Formulario.fmDecree:
                    FormDecree fmDecree = new FormDecree();
                    fmDecree.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                    fmDecree.Show();
                    break;
                case Formulario.fmPreparationSamples:
                    FormPrepSamples fmPreparationSamples = new FormPrepSamples();
                    fmPreparationSamples.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                    fmPreparationSamples.Show();
                    break;
                case Formulario.fmCompound:
                    FormCompound fmcompound = new FormCompound();
                    fmcompound.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                    fmcompound.Show();
                    break;
                case Formulario.fmFactorEstequ:
                    FormFactorEstequiometrico fmFactorEstequ = new FormFactorEstequiometrico();
                    fmFactorEstequ.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                    fmFactorEstequ.Show();
                    break;
            }
        }

        public static bool CopyAndSaveFile(string source_file_name, string destiny_path, string file_name)
        {
            try
            {
                System.IO.FileInfo fInfo = new System.IO.FileInfo(source_file_name);

                string destiny_file = System.IO.Path.Combine(destiny_path, file_name);

                if (!System.IO.Directory.Exists(destiny_path))
                    System.IO.Directory.CreateDirectory(destiny_path);

                // To copy a file to another location and
                // overwrite the destination file if it already exists.                
                System.IO.File.Copy(source_file_name, destiny_file, true);
                return true;
            }
            catch (Exception ex)
            {
                Send_message("Copiar y guardar archivo", TypeMsg.error, ex.Message);
                return false;
            }
        }
    }

    public class ImageValue
    {
        private Image _image;

        public Image Image
        {
            get
            {
                return _image;
            }
            set
            {
                _image = value;
            }
        }
        private string _text;

        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }

        public ImageValue(string text, Image image)
        {
            Image = image;
            Text = text;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
