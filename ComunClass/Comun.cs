using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Security.Cryptography;
using LimsProject.BusinessLayer;
using System.Text.RegularExpressions;

namespace LimsProject
{
    public enum TypeMsg
    {
        ok,
        error
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

    public delegate void ShowAction(string module, TypeMsg type_msg, string msg_action);
    
    public delegate void ShowUser(string user);

    public class CGenericData
    {
        public object id { get; set; }
        public object text { get; set; }
    }
   

    public static class Comun
    {
        #region attributes

        private static CListAnalysisType list_type_analysis = null;
        private static CListTypeRepetition list_type_repetition = null;
        private static CListTypeMr list_type_mr = null;
        private static CListaTypePost list_type_post = null;
        private static CListTypeMaterial list_type_material = null;
        private static CListStatusReport list_status_report = null;

        public static CUser_system User_system = null;
        public static Color ColorVerde = Color.FromArgb(173, 218, 140);
        public static Color ColorRojo = Color.FromArgb(234, 87, 96);
        public static Color ColorMorado = Color.FromArgb(158, 153, 230);
        public static Color ColorAmbar = Color.FromArgb(255, 191, 0);

        
        #endregion      
        
        public static event ShowAction Even_show_action;
        public static event ShowUser Even_show_user;

        ///qaqc_error = (
        ///0:sin errores,
        ///1:sin error con texto,
        ///2:sin error con reensayo,
        ///3:con error no aprobado,
        ///4:con error aprobado con observacion,
        ///5:con error aprobado con reensayo)
        public enum StatusErrorParity
        {
            WithoutError = 0,
            WithoutErrorWithText = 1,
            WithoutErrorWithRetest = 2,
            WithErrorNotApproved = 3,
            WithErrorApprovedWithText = 4,
            WithErrorApprovedWithRetest = 5
        }

        public enum CriteriaSort
        {
            BySample,
            ByDescription
        }

        public enum StatusWork
        {
            Waiting,
            Management,
            Saved
        }

        public enum SampleCameFrom
        {
            NewSample,
            QaqcSampleRetest,
            QaqcFullBatchRetest
        }

        public enum Save_type
        {
            Save,
            SaveAs,
            Cancel
        }

        public enum Status_result
        {
            Espera = 0,
            Incorrecto = 1,
            Plausible = 2,
            Aceptado = 3,
            IncorrectoPlausible = 4,
            EsperaReensayo = 5
        }

        public enum TypeControl
        { 
            TextEdit,
            ButtonEdit,
            ComboBox
        }

        public enum BussinesObject
        { 
            user,
            client,
            element,
            method,
            typeAnalysis,
            sample
        }

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
            fmCompound
        }

        public enum ReportStatus
        {
            EnCreacion = 0,
            Reportado = 1            
        }

        public enum AttachStatus
        {
            EnCreacion = 1,
            Adjuntado = 2
        }

        public enum WindowsTray
        {
            PendingApprove,
            PendingReview
        }

        public enum MethodSaveProperty
        {
            InspectionNewMethod = 1,
            InspectionNewVersion = 2,
            Nothing = 3,
            NewMethod = 4,
            PersistCopyMethod = 5
        }

        public enum TypeAnalysis
        {
            AbsorcionAtomica = '1',
            Volumetria = '2',
            Gravimetria = '3',
            NewmontAA = '4',
            NewmontGr = '5',
            Nothing = '0'
        }

        public enum TypeSample
        {
            Sample = 1,
            SampleControl = 2    // mri y blk
        }

        public static TypeAnalysis GetTypeAnalysis(char type_analysis)
        {
            if (type_analysis == '1')
                return TypeAnalysis.AbsorcionAtomica;
            if (type_analysis == '2')
                return TypeAnalysis.Volumetria;
            if (type_analysis == '3')
                return TypeAnalysis.Gravimetria;
            if (type_analysis == '4')
                return TypeAnalysis.NewmontAA;
            if (type_analysis == '5')
                return TypeAnalysis.NewmontGr;
            return TypeAnalysis.Nothing;
        }

        public static int GetStatusErrorParity(StatusErrorParity err)
        {
            return Convert.ToInt32(err);
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
            }
        }

        public static bool isDecimal(object test_number)
        {
            try
            {
                decimal num = Convert.ToDecimal(test_number);
                return true;
            }
            catch
            {
                return false;
            }
        }        

        public static List<ProviderType> ListTypeCompany()
        {
            List<ProviderType> lstTypeCompany = new List<ProviderType>();
            lstTypeCompany.Add(new ProviderType() { Id = 'C', Name = "Cliente" });
            lstTypeCompany.Add(new ProviderType() { Id = 'P', Name = "Proveedor" });            
            return lstTypeCompany;
        }

        public static void Send_message(string module, TypeMsg type_msg, string msg)
        {            
            Even_show_action(module, type_msg, msg);
        }

        public static void Send_user()
        {
            Even_show_user(User_system.Cod_user);
        }

        public static bool AreUserAndPwdRight(string user, string pwd)
        {
            List<CUser_system> lstUser = new CUser_systemFactory().GetAll();
            foreach (CUser_system oUsuario in lstUser)
            {
                if (user.Trim().ToUpper() == oUsuario.Cod_user.Trim().ToUpper())
                {
                    if (oUsuario.Pwd == Comun.EncriptarMD5(pwd))
                    {
                        Comun.User_system = oUsuario;
                        return true;
                    }
                }
            }
            return false;
        }
        
        public static CListTypeRepetition ListTypeRepetition
        {
            get
            {
                if (list_type_repetition == null)
                {
                    list_type_repetition = new CListTypeRepetition();                    
                    list_type_repetition.Add(new CRepetition { Cod_repetition = 1, Name_repetition = "Simple", Cost_Method = 0, Analisys_Time = 0, Next_idrepetition = "-" });
                    list_type_repetition.Add(new CRepetition { Cod_repetition = 2, Name_repetition = "Doble", Cost_Method = 0, Analisys_Time = 0, Next_idrepetition = "TT" });                    
                    list_type_repetition.Add(new CRepetition { Cod_repetition = 3, Name_repetition = "Triplicado", Cost_Method = 0, Analisys_Time = 0, Next_idrepetition = "LL" });
                    list_type_repetition.Add(new CRepetition { Cod_repetition = 4, Name_repetition = "Lote", Cost_Method = 0, Analisys_Time = 0, Next_idrepetition = "DR" });
                    list_type_repetition.Add(new CRepetition { Cod_repetition = 8, Name_repetition = "Dirimencia", Cost_Method = 0, Analisys_Time = 0, Next_idrepetition = "SS" });
                                        
                }
                return list_type_repetition;
            }
        }

        public static CListTypeRepetition GetListTypeRepetition()
        {
            CListTypeRepetition lstTypeRepetition = new CListTypeRepetition();

            for (int i = 0; i < ListTypeRepetition.Count; i++)
            {
                CRepetition oRepetition = new CRepetition();
                oRepetition.Cod_repetition = ListTypeRepetition[i].Cod_repetition;
                oRepetition.Cod_repetition = ListTypeRepetition[i].Cod_repetition;
                oRepetition.Name_repetition = ListTypeRepetition[i].Name_repetition;
                oRepetition.Cost_Method = ListTypeRepetition[i].Cost_Method;
                oRepetition.Analisys_Time = ListTypeRepetition[i].Analisys_Time;
                oRepetition.Next_idrepetition = ListTypeRepetition[i].Next_idrepetition;

                lstTypeRepetition.Add(oRepetition);
            }

            return lstTypeRepetition;
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

        public static string FormatCorrelativeCode(string prefix, long num, int num_digits)
        {
            return prefix + num.ToString().PadLeft(num_digits, '0');
        }

        public static CListAnalysisType ListTypeAnalysis
        {
            get {
                if (list_type_analysis == null)
                {
                    list_type_analysis = new CListAnalysisType();
                    list_type_analysis.Add(new CAnalysisType { Type_analisys = '1', Den_Type_Analysis = "Absorción atómica" });
                    list_type_analysis.Add(new CAnalysisType { Type_analisys = '2', Den_Type_Analysis = "Volumetría" });
                    list_type_analysis.Add(new CAnalysisType { Type_analisys = '3', Den_Type_Analysis = "Gravimetría" });
                    list_type_analysis.Add(new CAnalysisType { Type_analisys = '4', Den_Type_Analysis = "Ipc" });
                    list_type_analysis.Add(new CAnalysisType { Type_analisys = '5', Den_Type_Analysis = "newmont-grav" });
                    list_type_analysis.Add(new CAnalysisType { Type_analisys = '6', Den_Type_Analysis = "Analisis de Humedad" });
                    
                }
                return list_type_analysis;
            }
        }

        public static CListTypeMr ListMr
        {
            get {
                if (list_type_mr == null)
                {
                    list_type_mr = new CListTypeMr();
                    list_type_mr.Add(new CTypeMr { IdTypeMr = 'C', Den_TypeMr = "MR Certificado" });
                    list_type_mr.Add(new CTypeMr { IdTypeMr = 'I', Den_TypeMr = "MR Interno" });
                    list_type_mr.Add(new CTypeMr { IdTypeMr = 'S', Den_TypeMr = "Solución Patrón" });
                    list_type_mr.Add(new CTypeMr { IdTypeMr = 'R', Den_TypeMr = "Sal Primaria" });
                    list_type_mr.Add(new CTypeMr { IdTypeMr = 'D', Den_TypeMr = "Sal Secundaria" });
                }
                return list_type_mr;
            }
        }        

        public static CListaTypePost ListTypePost
        {
            get {
                if (list_type_post == null)
                {
                    list_type_post = new CListaTypePost();
                    list_type_post.Add(new CTypePost { IDTypePost = 'P', Den_Type_Post = "Personal" });
                    list_type_post.Add(new CTypePost { IDTypePost = 'M', Den_Type_Post = "e - mail" });
                    list_type_post.Add(new CTypePost { IDTypePost = 'C', Den_Type_Post = "curier" });
                    list_type_post.Add(new CTypePost { IDTypePost = 'E', Den_Type_Post = "Emp. Transp" });
                    list_type_post.Add(new CTypePost { IDTypePost = 'F', Den_Type_Post = "FAX" });
                    list_type_post.Add(new CTypePost { IDTypePost = 'O', Den_Type_Post = "Otro" });
                }
                return list_type_post;
            }
        }

        public static CListTypeMaterial ListTypeMaterial
        {
            get {
                if (list_type_material == null)
                {
                    list_type_material = new CListTypeMaterial();
                    list_type_material.Add(new CTypeMaterial {  IdTypeMaterial = 'M', Description = "Mineral" });
                    list_type_material.Add(new CTypeMaterial { IdTypeMaterial = 'B', Description = "Carbon" });
                    list_type_material.Add(new CTypeMaterial { IdTypeMaterial = 'C', Description = "Concentrado" });
                    list_type_material.Add(new CTypeMaterial { IdTypeMaterial = 'S', Description = "Solución" });
                }
                return list_type_material;
            }
        }

        public static CListStatusReport ListStatusReport
        {
            get {
                if (list_status_report == null)
                {
                    list_status_report = new CListStatusReport();
                    list_status_report.Add(new CStatusReport { IdStatus = 0, Den_Status = "En Creación" });
                    list_status_report.Add(new CStatusReport { IdStatus = 1, Den_Status = "Reportado" });                    
                }
                return list_status_report;
            }
        }

        public static string GetUser()
        {
            if (User_system == null)
                return "admin";
            return User_system.Cod_user;
        }

        public static DateTime GetDate()
        {
            return DateTime.Now;
        }

        public static string EncriptarMD5(string originalPassword)
        {
            //Declarations
            string resultado, resultadoFinal = null;
            Byte[] originalBytes;
            Byte[] encodedBytes;
            MD5 md5;

            //Instantiate MD5CryptoServiceProvider, get bytes for original password and compute hash (encoded password)
            md5 = new MD5CryptoServiceProvider();
            originalBytes = ASCIIEncoding.Default.GetBytes(originalPassword);
            encodedBytes = md5.ComputeHash(originalBytes);

            //Convert encoded bytes back to a 'readable' string
            resultado = BitConverter.ToString(encodedBytes);
            for (int i = 0; i < resultado.Length; i++)
            {
                if (resultado[i] != 45)
                    resultadoFinal += resultado[i];
            }
            return resultadoFinal;
        }

        public static void Save_log(string txt)
        {
            string archive = System.IO.Directory.GetCurrentDirectory() + @"\log.txt";

            System.IO.StreamWriter sw = new System.IO.StreamWriter(archive);
            sw.WriteLine(txt);
            sw.Close();
        }

        public static bool ValidateMail(string mail)
        {
            string email = mail;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                return true;
            else
                return false;
        }

        public static List<CCriterio> GetLstCriterio()
        {
            List<CCriterio> lstCriterio = new List<CCriterio>();
            lstCriterio.Add(new CCriterio() { Idcriterio = 1, Nombre_criterio = "igual" });   //admite valor1
            lstCriterio.Add(new CCriterio() { Idcriterio = 2, Nombre_criterio = "diferente" });//admite valor1
            lstCriterio.Add(new CCriterio() { Idcriterio = 3, Nombre_criterio = "menor" });//admite valor1
            lstCriterio.Add(new CCriterio() { Idcriterio = 4, Nombre_criterio = "mayor" });//admite valor1
            lstCriterio.Add(new CCriterio() { Idcriterio = 5, Nombre_criterio = "mayor o igual" });//admite valor1
            lstCriterio.Add(new CCriterio() { Idcriterio = 6, Nombre_criterio = "menor o igual" });//admite valor1
            lstCriterio.Add(new CCriterio() { Idcriterio = 7, Nombre_criterio = "Entre" });//admite valor1 y valor2
            return lstCriterio;
        }
    }

    public class CCriterio
    {
        public int Idcriterio { get; set; }
        public string Nombre_criterio { get; set; }
    }

    public class CListTypeRepetition : List<CRepetition>
    { 
    }

    public class CTagInfoMethod
    {
        public short IDMeasurement_Unit { get; set; }
        public short IDElement { get; set; }
        public string Name_Measurement_Unit { get; set; }
        public int IDTemplate_method { get; set; }
        public short Percent_repetition { get; set; }
        public decimal Analysis_Time { get; set; }
        public decimal Cost_Method { get; set; }
        public string Cod_template_method { get; set; }
    }

    public class CRepetition
    {
        public short Cod_repetition { get; set; }        
        public string Name_repetition { get; set; }
        public decimal Cost_Method { get; set; }
        public string Function { get; set; }        
        public short Analisys_Time { get; set; }
        public string Next_idrepetition { get; set; }
    }

    public class CListAnalysisType : List<CAnalysisType>
    { 
    }

    public class CListStatusReport: List<CStatusReport>
    {
    }

    public class CAnalysisType
    {
        public char Type_analisys { get; set; }
        public string Den_Type_Analysis { get; set; }
    }

    public class CListTypeMr : List<CTypeMr>
    { 
    }

    public class CTypeMr
    {
        public char IdTypeMr { get; set; }
        public string Den_TypeMr { get; set; }
    }

    public class CStatusReport
    {
        public int IdStatus { get; set; }
        public string Den_Status { get; set; }
    }

    public class CListTypeMaterial : List<CTypeMaterial>
    { 
    }

    public class CTypeMaterial
    {
        public char IdTypeMaterial { get; set; }
        public string Description { get; set; }
    }

    public class CListaTypePost : List<CTypePost>
    { 
    }

    public class CTypePost
    {
        public char IDTypePost { get; set; }
        public string Den_Type_Post { get; set; }
    }
}
