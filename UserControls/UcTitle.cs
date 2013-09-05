using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LimsProject
{
    public partial class UcTitle : UserControl
    {
        public enum ColorTitle
        {
            BlueSky,
            Orange
        }


        /*
         fondo color naranja : BackColor
        -------------------
        NavajoWhite

        letra color rojo : ForeColor
        ----------------
        OrangeRed


        fondo color celeste : BackColor
        -------------------
        LightSteelBlue


        letra color azul : ForeColor
        ----------------
        51, 105, 170
         */ 
         
        public string Title
        {
            get {
                return laTitle.Text;
            }
            set {
                laTitle.Text = value;
            }
        }

        public UcTitle()
        {
            InitializeComponent();            
        }

        public void SetColor(ColorTitle color)
        {
            switch (color)
            {
                case ColorTitle.BlueSky:
                    laTitle.BackColor = Color.LightSteelBlue;
                    laTitle.ForeColor = Color.FromArgb(51, 105, 170);
                break;
                case ColorTitle.Orange:
                    laTitle.BackColor = Color.NavajoWhite;
                    laTitle.ForeColor = Color.OrangeRed;
                break;
            }
        }
    }
}
