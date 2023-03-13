using ApplicationControllerExample.View;
using System;
using System.Windows.Forms;

namespace ApplicationControllerExample.Forms
{
    public partial class ChildForm : Form, IChildFormView
    {
        ApplicationContext _context;

        public ChildForm(ApplicationContext context)
        {
            InitializeComponent();
            _context = context;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }
        private void Invoke(Action action)
        {
            if (action != null) action();
        }

        public string SomeClassArg { 
            get { return txtBoxSameArgument.Text; } 
            set { txtBoxSameArgument.Text = value; }
        }

    }
}
