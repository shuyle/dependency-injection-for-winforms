using System;
using System.Windows.Forms;
using WindowsFormsDI.Services.MyService;

namespace WindowsFormsDI
{
    /// <summary>
    /// Child form of application
    /// For demo other service DI
    /// </summary>
    public partial class ChildForm: Form
    {
        private readonly IMyService myService;
        public ChildForm(IServiceProvider serviceProvider, IMyService myService)
        {
            this.myService = myService;
            InitializeComponent();
        }

        private void btnRunService_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myService.GetMessage());
        }
    }
}
