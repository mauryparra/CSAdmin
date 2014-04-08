using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSAdminApp.Clases
{
    class SampleIPrincipal : System.Security.Principal.IPrincipal
    {
        #region Miembros de IPrincipal

        public System.Security.Principal.IIdentity Identity
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsInRole(string role)
        {
            throw new NotImplementedException();
        }

        #endregion

        public SampleIPrincipal()
        {
        }
    }
}
