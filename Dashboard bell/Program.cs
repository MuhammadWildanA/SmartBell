using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard_bell
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            licence activationForm = new licence();

            int verificationResult = activationForm.verifyKey();

            if (verificationResult == 2)
            {
                Application.Run(new dashboard());
            }
            else if(verificationResult == 0)
            {
                Application.Run(new licence());
            }
            else if(verificationResult == 1)
            {
                return;
            } 
        }
    }
}
