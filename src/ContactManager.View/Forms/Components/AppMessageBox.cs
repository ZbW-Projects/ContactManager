using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*===========================================================
 * 
 * Mehr unter:
 * https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.messagebox?view=windowsdesktop-9.0
 * 
 *=============================================================*/


namespace ContactManager.View.Forms.Components
{
    #region Validierungsboxmelder
    public class InputBox
    {
        public static void Error(string message)
        {
            MessageBox.Show(message, "System Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Warning(string message)
        {
            MessageBox.Show(message, "Eingabe Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Info(string message)
        {
            MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    #endregion
}
