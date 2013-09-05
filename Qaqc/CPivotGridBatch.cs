using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Columns;

using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors.Controls;

namespace LimsProject
{
    public class CPivotGridBatch
    {
        GridControl gridcontrol = new GridControl();
        BandedGridView gridview = new BandedGridView();

        // --- groups of columns
        Dictionary<string, string> dicGroups =
            new Dictionary<string, string>() 
            {                 
                { "Pesos", "weight" }, { "Lecturas", "reading" }, 
                { "Factores", "factor" }, { "Rango", "rank" }, { "Ley Parcial", "law" }
            };

        // --- captions of columns
        Dictionary<string, string> dicCaptions =
            new Dictionary<string, string>() 
            { 
                { "weight", "Peso-" }, { "volumen", "Vol-" }, { "reading", "Lec-" }, 
                { "flag_dila", "Dil N°" }, { "dilua", "2° Dil" },   
                { "flag_dilb", "Dil N°" }, { "dilub", "3° Dil" },
                { "factor", "Factor-" }, { "rank", "Rango" }, 
                { "law", "Ley-" }
            };

        // --- visibility of groups
        Dictionary<string, bool> dicVisibilityGroups =
            new Dictionary<string, bool>()
            {
                { "Pesos", true }, { "Lecturas", true },
                { "Factores", true }, { "Rango", false },
                { "Ley Parcial", true }
            };

        // --- visibility of columns
        Dictionary<string, bool> dicVisibilityColumns =
            new Dictionary<string, bool>()
            {
                { "weight", true }, { "reading", true },                
                { "factor", true }, { "rank", false }, 
                { "law", true }
            };

        public CPivotGridBatch(GridControl gc, BandedGridView bgv)
        {
            gridcontrol = gc;
            gridview = bgv;
            FormatColumns();
            FormatColumnConst();
            FormatRows();
        }

        public void FormatColumnConst()
        {
            #region --- field muestra

            gridview.Columns["Qaqc_blk"].Caption = "Blk";
            gridview.Columns["Qaqc_par"].Caption = "Par";
            gridview.Columns["Qaqc_mr"].Caption = "Mr";
            gridview.Columns["Cod_sample"].Caption = "Cod.Muestra";
            gridview.Columns["Qaqc_observation"].Caption = "#";
            gridview.Columns["Qaqc_error"].Caption = ".";
            gridview.Columns["Qaqc_approve"].Caption = "aprobar";
            gridview.Columns["Qaqc_review"].Caption = "revisar";
            gridview.Columns["Qaqc_status_result"].Caption = ".";

            // --- Width
            gridview.Columns["Cod_sample"].Width = 90;
            gridview.Columns["Qaqc_par"].Width = 40;
            gridview.Columns["Qaqc_observation"].Width = 25;
            gridview.Columns["Qaqc_error"].Width = 25;
            gridview.Columns["Qaqc_approve"].Width = 80;
            gridview.Columns["Qaqc_review"].Width = 80;
            gridview.Columns["Qaqc_status_result"].Width = 25;

            // --- visibility            
            gridview.Columns["Idrecep_sample_detail"].Visible = false;
            gridview.Columns["Idrecep_sample_detail_elem"].Visible = false;
            gridview.Columns["Cod_sample"].Visible = true;
            gridview.Columns["Flag_mri"].Visible = false;
            gridview.Columns["Qaqc_blk"].Visible = false;
            gridview.Columns["Qaqc_par"].Visible = true;
            gridview.Columns["Qaqc_mr"].Visible = false;
            gridview.Columns["Qaqc_approve"].Visible = true;
            gridview.Columns["Qaqc_review"].Visible = false;
            gridview.Columns["Qaqc_observation"].Visible = true;
            gridview.Columns["Qaqc_text_obs"].Visible = false;
            gridview.Columns["Qaqc_idretest"].Visible = false;
            gridview.Columns["Qaqc_error"].Visible = true;
            gridview.Columns["Qaqc_status_result"].Visible = false;

            // --- readonly
            gridview.Columns["Qaqc_par"].OptionsColumn.AllowEdit = false;
            gridview.Columns["Qaqc_error"].OptionsColumn.AllowEdit = false;
            gridview.Columns["Qaqc_status_result"].OptionsColumn.AllowEdit = false;

            // --- add columns to muestra band
            GridBand gbMuestra = new GridBand();
            gbMuestra.Caption = "Muestra";
            gbMuestra.Columns.Add(gridview.Columns["Idrecep_sample_detail"]);
            gbMuestra.Columns.Add(gridview.Columns["Idrecep_sample_detail_elem"]);
            gbMuestra.Columns.Add(gridview.Columns["Cod_sample"]);
            gbMuestra.Columns.Add(gridview.Columns["Flag_mri"]);

            // --- add columns to qaqc band
            GridBand gbQaqc = new GridBand();
            gbQaqc.Caption = "Qaqc";
            gbQaqc.Columns.Add(gridview.Columns["Qaqc_blk"]);
            gbQaqc.Columns.Add(gridview.Columns["Qaqc_par"]);
            gbQaqc.Columns.Add(gridview.Columns["Qaqc_mr"]);
            gbQaqc.Columns.Add(gridview.Columns["Qaqc_approve"]);
            gbQaqc.Columns.Add(gridview.Columns["Qaqc_review"]);
            gbQaqc.Columns.Add(gridview.Columns["Qaqc_observation"]);
            gbQaqc.Columns.Add(gridview.Columns["Qaqc_text_obs"]);
            gbQaqc.Columns.Add(gridview.Columns["Qaqc_idretest"]);
            gbQaqc.Columns.Add(gridview.Columns["Qaqc_error"]);
            gbQaqc.Columns.Add(gridview.Columns["Qaqc_status_result"]);

            //gridview.Bands.Add(gb);
            gridview.Bands.Insert(0, gbMuestra);
            gridview.Bands.Add(gbQaqc);


            #endregion

            #region --- field volumen

            GridBand gbVolumen = new GridBand();
            gbVolumen.Caption = "Volumen";

            // --- visibility
            gridview.Columns["volumen1"].Visible = true;

            // --- add columns
            gbVolumen.Columns.Add(gridview.Columns["volumen1"]);


            //gridview.Bands.Add(gb);
            gridview.Bands.Insert(2, gbVolumen);

            #endregion

            #region --- dilution columns

            GridBand gbDilucion = new GridBand();
            gbDilucion.Caption = "Dilución";

            gbDilucion.Columns.Add(gridview.Columns["flag_dila1"]);
            gbDilucion.Columns.Add(gridview.Columns["dilua1"]);
            gbDilucion.Columns.Add(gridview.Columns["flag_dilb1"]);
            gbDilucion.Columns.Add(gridview.Columns["dilub1"]);

            // --- column dilution 1
            gridview.Columns["flag_dila1"].Visible = true;
            gridview.Columns["flag_dila1"].Width = 50;
            gridview.Columns["dilua1"].Visible = true;
            gridview.Columns["dilua1"].Width = 60;

            // --- column dilution 2
            gridview.Columns["flag_dilb1"].Visible = true;
            gridview.Columns["flag_dilb1"].Width = 50;
            gridview.Columns["dilub1"].Visible = true;
            gridview.Columns["dilub1"].Width = 60;

            gridview.Bands.Insert(3, gbDilucion);

            #endregion

            #region --- law columns

            GridBand gbLaw = new GridBand();
            gbLaw.Caption = "Ley";

            gbLaw.Columns.Add(gridview.Columns["Str_result_analysis"]);

            // --- column dilution 1
            gridview.Columns["Str_result_analysis"].Visible = true;
            gridview.Columns["Str_result_analysis"].Width = 60;
            gridview.Columns["Str_result_analysis"].Caption = "Ley";

            gridview.Bands.Add(gbLaw);

            #endregion

            #region fixed band

            gbMuestra.Fixed = FixedStyle.Left;
            gbQaqc.Fixed = FixedStyle.Right;
            gbLaw.Fixed = FixedStyle.Right;

            #endregion

            #region format alignment

            gridview.Columns["dilua1"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            gridview.Columns["dilub1"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            gridview.Columns["Str_result_analysis"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;

            #endregion

            #region images

            gridview.Columns["Qaqc_approve"].ImageIndex = 0;
            gridview.Columns["Qaqc_review"].ImageIndex = 0;

            #endregion

            #region contents

            gridview.Columns["Qaqc_par"].ColumnEdit = gridcontrol.RepositoryItems[0];
            gridview.Columns["Qaqc_observation"].ColumnEdit = gridcontrol.RepositoryItems[1];
            gridview.Columns["Qaqc_error"].ColumnEdit = gridcontrol.RepositoryItems[2];
            gridview.Columns["Qaqc_approve"].ColumnEdit = gridcontrol.RepositoryItems[3];
            gridview.Columns["Qaqc_review"].ColumnEdit = gridcontrol.RepositoryItems[3];
            gridview.Columns["Qaqc_status_result"].ColumnEdit = gridcontrol.RepositoryItems[4];

            #endregion

            #region status column

            gridview.Columns["Qaqc_approve"].OptionsColumn.AllowSort = DefaultBoolean.False;
            gridview.Columns["Qaqc_review"].OptionsColumn.AllowSort = DefaultBoolean.False;

            #endregion

        }

        public void FormatRows()
        {
            // --- style mri
            StyleFormatCondition style = new StyleFormatCondition();
            style.Column = gridview.Columns["Flag_mri"];
            style.ApplyToRow = true;
            style.Value1 = 1;
            style.Condition = FormatConditionEnum.Equal;
            style.Appearance.BackColor = Color.Orange;
            style.Appearance.Options.UseBackColor = true;
            gridview.FormatConditions.Add(style);
        }

        public void FormatColumns()
        {
            // --- set groups
            if (gridview.RowCount > 0)
            {
                // --- set groups with columns
                foreach (KeyValuePair<string, string> kvp in dicGroups)
                {
                    GridBand gb = new GridBand();
                    gb.Caption = kvp.Key;

                    for (int col = 0; col < gridview.Columns.Count; col++)
                    {
                        if (gridview.Columns[col].FieldName.Contains(kvp.Value))
                            gb.Columns.Add(gridview.Columns[col]);
                    }

                    gridview.Bands.Add(gb);
                }


                for (int col = 0; col < gridview.Columns.Count; col++)
                    gridview.Columns[col].Caption = gridview.Columns[col].FieldName;

                // --- set captions in columns
                foreach (KeyValuePair<string, string> kvp in dicCaptions)
                {
                    for (int col = 0; col < gridview.Columns.Count; col++)
                    {
                        if (gridview.Columns[col].Caption.Contains(kvp.Key))
                            gridview.Columns[col].Caption = gridview.Columns[col].Caption.Replace(kvp.Key, kvp.Value);
                    }
                }

                // --- set visible bands
                if (gridview.RowCount > 0)
                {
                    foreach (KeyValuePair<string, bool> kvp in dicVisibilityGroups)
                    {
                        for (int ban = 0; ban < gridview.Bands.Count; ban++)
                        {
                            if (gridview.Bands[ban].Caption.Contains(kvp.Key))
                                gridview.Bands[ban].Visible = kvp.Value;
                        }
                    }
                }

                // --- set visible columns
                for (int col = 0; col < gridview.Columns.Count; col++)
                {
                    foreach (KeyValuePair<string, bool> kvp in dicVisibilityColumns)
                    {
                        if (gridview.Columns[col].Name.Contains(kvp.Key))
                            gridview.Columns[col].Visible = kvp.Value;
                    }
                }

                // --- visibility in columns
                for (int col = 0; col < gridview.Columns.Count; col++)
                {
                    foreach (KeyValuePair<string, bool> kvp in dicVisibilityColumns)
                    {
                        if (gridview.Columns[col].Name.Contains(kvp.Key))
                            gridview.Columns[col].Visible = kvp.Value;
                    }
                }

                // --- set columns's width
                for (int col = 0; col < gridview.Columns.Count; col++)
                {
                    gridview.Columns[col].Width = 60;
                }

                // --- set far alignment (right)
                foreach (KeyValuePair<string, string> kvp in dicGroups)
                {
                    for (int col = 0; col < gridview.Columns.Count; col++)
                    {
                        if (gridview.Columns[col].FieldName.Contains(kvp.Value))
                            gridview.Columns[col].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                    }
                }
            }
        }
    }
}
