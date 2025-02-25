using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace WindowsFormsDI
{
    /// <summary>
    /// Tab container form to demo tab control DI other Form
    /// </summary>
    public partial class TabContainerForm : Form
    {
        private readonly IServiceProvider serviceProvider;

        /// <summary>
        /// Constructor.
        /// </summary>
        public TabContainerForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.serviceProvider = serviceProvider;
        }

        /// <summary>
        /// Demo add form to tab page
        /// </summary>
        private void AddFormToTabPage<T>(string tabTitle) where T : Form
        {
            var form = serviceProvider.GetRequiredService<T>();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            var tabPage = new TabPage(tabTitle);
            tabPage.Controls.Add(form);
            tabControlContainer.TabPages.Add(tabPage);

            form.Show();
        }

        private void TabContainerForm_Load_1(object sender, EventArgs e)
        {
            AddFormToTabPage<ChildForm>("Tab ChildForm");
            AddFormToTabPage<MainForm>("Tab MainForm");
        }
    }
}
