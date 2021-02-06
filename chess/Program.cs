using System;
using chess.view;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using chess.model;
using chess.vm;

namespace chess
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Model model = new Model();
            Viewmodel vm = new Viewmodel(model);

            model.Add(vm);            
            
            Application.Run(new chess.view.MainMenu(vm));
        }
    }
}
