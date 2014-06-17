using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSAdminApp.Clases
{
    public partial class Personas
    {
        public string NombreCompleto
        {
            get { return this.Nombre + " " + this.Apellido; }
        }
    }
}
