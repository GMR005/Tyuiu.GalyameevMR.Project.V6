using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.GalyameevMR.Project.V6
{
    public partial class FormChangeBase : Form
    {
        FormMain fmain;
        public FormChangeBase(FormMain fm)
        {
            InitializeComponent();
            this.fmain = fm;
        }
    }
}
