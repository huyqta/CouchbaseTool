using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CouchbaseClientSDK2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormListClusters formListClusters = new FormListClusters();
            formListClusters.ShowInTaskbar = false;
            formListClusters.FormBorderStyle = FormBorderStyle.None;
            formListClusters.Dock = DockStyle.Fill;
            formListClusters.TopLevel = false;
            formListClusters.Visible = true;
            formListClusters.Text = "";
            formListClusters.ControlBox = false;
            splitContainer.Panel1.Controls.Add(formListClusters);
        }
    }
}
