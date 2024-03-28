using System;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace ePaymentRequest
{
    public class Program
    {


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}

