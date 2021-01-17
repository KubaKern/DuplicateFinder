using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace DuplicateFinder
{
    static class Program
    {
        public static Form[] formsList;
        public class MultiFormContext : ApplicationContext
        {
            private int openForms;
            public MultiFormContext(params Form[] forms)
            {
                int c = 0;
                openForms = forms.Length;

                foreach (var form in forms)
                {
                    form.FormClosed += (s, args) =>
                    {
                        if (Interlocked.Decrement(ref openForms) == 0)
                            ExitThread();
                    };
                    form.Show();
                    if (c != 0)
                    {
                        form.Hide();
                    }
                    c++;
                }
            }
        }
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formsList = new Form[] { new FormMain(), new Forms.FormFile(), new Forms.FormPartition(), new Forms.FormSettings(), new Forms.FormAbout() };
            Application.Run(new MultiFormContext(formsList));
        }
    }
}
