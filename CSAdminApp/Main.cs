using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CSAdminApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeCSAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe acerca = new AcercaDe("Acerca de CSAdmin", "http://mauryparra.com.ar/");
            acerca.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();


            Array wbirFields = Enum.GetValues(typeof(WindowsBuiltInRole));
            
            if (Thread.CurrentPrincipal.Identity.IsAuthenticated)
            {
                if (WindowsPrincipal.IsInRole((WindowsBuiltInRole)0x220)) // 0x220 = BUILTIN\Administrators
                {
                    this.Text += " [Admin]";
                }
                else
                {
                    this.Text += " [Usuaurio]";
                }
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
