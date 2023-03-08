using ApplicationControllerExample.View;
using System;
using System.Windows.Forms;

namespace ApplicationControllerExample.Forms
{
    public partial class StartForm : Form, IStartFormView
    {
        private readonly ApplicationContext _context;

        public StartForm(ApplicationContext context)
        {
            _context = context;

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            btnRunMainForm.Click += (sender, args) => Invoke(RunMainForm);
        }

        public new void Show()
        {
            _context.MainForm = this;
            Application.Run(_context);
        }

        public event Action RunMainForm;

        private void Invoke(Action action)
        {
            if (action != null) action();
        }
    }
}
