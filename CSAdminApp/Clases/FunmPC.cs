using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSAdminApp.Clases
{
    class FunmPC
    {
        public static void limpiarForm(Control control)
        {
            var t = control.Controls.OfType<TextBoxBase>().AsEnumerable<TextBoxBase>();
            foreach (TextBoxBase item in t)
            {
                item.Text = "";
            }

        }

        public static void readOnlyForm(Control control, Boolean estado)
        {
            var t = control.Controls.OfType<TextBoxBase>().AsEnumerable<TextBoxBase>();
            foreach (TextBoxBase item in t)
            {
                item.ReadOnly = estado;
            }
        }

        /// <summary>
        /// Compara 2 fechas.
        /// Devuelve true si date2 es mayor o igual que date1.
        /// </summary>
        public static bool compareDates(DateTime date1, DateTime date2)
        {
            return (date2.Date >= date1.Date);
        }
    }
}
