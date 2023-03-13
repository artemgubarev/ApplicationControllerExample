using ApplicationControllerExample.Model;
using ApplicationControllerExample.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationControllerExample.Forms
{
    public partial class MainForm : Form, IMainFormView
    {
        private readonly ApplicationContext _context;

        public MainForm(ApplicationContext context)
        {
            _context = context;

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            btnRunChildForm.Click += (sender, args) => Invoke(RunChildForm);

        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        public event Action RunChildForm;

        private void Invoke(Action action)
        {
            if (action != null) action();
        }

        public string SomeClassArg { 
            get { return txtboxSomeArgumentValue.Text; }
            set { txtboxSomeArgumentValue.Text = value;}
        }

        
    }
}
