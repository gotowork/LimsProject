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
    public partial class FormMessage : LibraryBasicForm.FormConfirm
    {
        public string Title
        {
            set {
                laTitle.Text = value;
            }
        }

        public string Message
        {
            set {
                laMessage.Text = value;
            }
        }

        public bool ShowOk
        {
            set {
                btOk.Visible = value;
            }
        }

        public bool ShowCancel
        {
            set {
                btCancel.Visible = value;
            }
        }

        public FormMessage(string title, string message, bool showOk, bool showCancel)
        {           
            InitializeComponent();

            laTitle.Text = title;
            laMessage.Text = message;
            btOk.Visible = showOk;
            btCancel.Visible = showCancel;
        }

        public FormMessage(string title, string message, bool showOk, bool showCancel, string textOk, string textCancel)
        {
            InitializeComponent();

            laTitle.Text = title;
            laMessage.Text = message;
            btOk.Visible = showOk;
            btCancel.Visible = showCancel;
        }

        public FormMessage()
        {
            InitializeComponent();
        }
    }
}
