using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Principal;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;

namespace CSAdminApp.Clases
{
    class SampleIIdentity : IIdentity
    {
        #region Campos de IIdentity

        private string nameValue;
        private bool authenticatedValue;
        private WindowsBuiltInRole roleValue;

        #endregion

        #region Propiedades de IIdentity

        public string AuthenticationType
        {
            get { return "Custom Authentication"; }
        }

        public bool IsAuthenticated
        {
            get { return this.authenticatedValue; }
        }

        public string Name
        {
            get { return this.nameValue; }
        }

        public WindowsBuiltInRole Role
        {
            get { return this.roleValue; }
        }

        #endregion

        #region Métodos de IIdentity

        public SampleIIdentity(string name, string pass)
        {
            if (this.IsValidNameAndPassword(name, pass))
            {
                this.nameValue = name;
                this.authenticatedValue = true;
            }
            else
            {
                this.nameValue = "";
                this.authenticatedValue = false;
                this.roleValue = WindowsBuiltInRole.Guest;
            }
        }

        private bool IsValidNameAndPassword(string name, string pass)
        {
            CSAdminBDEntities dataContext = new CSAdminBDEntities();
            var usuariosQ = dataContext.Usuarios
                                       .Where(u => u.Usuario == name && u.Contra == pass );

            if (usuariosQ.Any())
            {
                switch (usuariosQ.First().Rol)
                {
                    case "ADM":
                        roleValue = WindowsBuiltInRole.Administrator;
                        break;

                    case "USR":
                        roleValue = WindowsBuiltInRole.User;
                        break;

                    default:
                        roleValue = WindowsBuiltInRole.Guest;
                        break;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
