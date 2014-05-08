using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSAdminApp.Pantallas
{
    public partial class pPersonal : UserControl
    {
        // aux[] es utilizado para guardar temporalmente el Id de la persona en c/ pestaña
        private int[] aux = {0, 0, 0};
        protected Clases.Personas nuevaPersona;

        public pPersonal()
        {
            InitializeComponent();
        }


    }
}
