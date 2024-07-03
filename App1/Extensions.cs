using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public static class Extensions
    {
        public static Form SaveClose(this Form form, Form form1=null)
        {
            if (form1 == null) Environment.Exit(1);
            form.Hide();
            form1.Show();
            return form;
        }
    }
}
