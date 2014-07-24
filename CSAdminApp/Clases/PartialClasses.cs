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
            get { return string.Format("{0} {1}", Nombre, Apellido); }
        }

        public override string ToString()
        {
            return NombreCompleto;
        }
    }
}
