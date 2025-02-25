using System;
using System.Windows.Forms;
using WindowsFormsDI.Services.MyService;
using Microsoft.Extensions.DependencyInjection;

namespace WindowsFormsDI
{
    /// <summary>
    /// Main form of application
    /// </summary>
    public partial class MainForm: Form
    {
        private readonly IServiceProvider serviceProvider;

        /// <summary>
        /// Constructor.
        /// </summary>
        public MainForm(IServiceProvider serviceProvider, IMyService myService)
        {
            InitializeComponent();
            this.serviceProvider = serviceProvider;
        }

        private void btnOpenChild_Click(object sender, EventArgs e)
        {
            // get childForm DI container
            var childForm = serviceProvider.GetRequiredService<ChildForm>();
            childForm.Show();
        }

        private void btnOpenTabContainerForm_Click(object sender, EventArgs e)
        {
            var tabContainerForm = serviceProvider.GetRequiredService<TabContainerForm>();
            tabContainerForm.Show();
            this.Hide();
        }
    }
}
