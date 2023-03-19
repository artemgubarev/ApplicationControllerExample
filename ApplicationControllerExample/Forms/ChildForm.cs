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
        }

        private void ChildForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            if (this.txtBoxSameArgument.IsHandleCreated)
            {
                this.txtBoxSameArgument.TextChanged += (s, args)
                    => SameArgTextChange.Invoke(txtBoxSameArgument.Text);
            }
        }

        public event Action<string> SameArgTextChange;

        private new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }
        private void Invoke(Action action)
        { 
            if (action != null) action();
        }

        public string SomeClassArg 
        { 
            get { return txtBoxSameArgument.Text; } 
            set { txtBoxSameArgument.Text = value; }
        }
    }
}
