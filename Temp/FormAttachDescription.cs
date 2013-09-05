using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LimsProject
{
    public partial class FormAttachDescription : LibraryBasicForm.FormConfirm
    {
        public string Description
        {
            get {
                return meDescription.Text;
            }
        }

        public FormAttachDescription()
        {
            InitializeComponent();
        }
    }
}
