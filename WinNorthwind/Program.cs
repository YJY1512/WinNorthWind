using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;


[assembly: log4net.Config.XmlConfigurator(ConfigFile = "My.config", Watch = true)]

namespace WinNorthwind
{
    static class Program
    {
        private static ILog log = LogManager.GetLogger("Program");
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            log.Debug("Main() started");
            log.Info("My Info");
            log.Warn("My Warning");
            log.Error("My Error");
            log.Fatal("My Fatal Error");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmEmployee());
        }

       

    }
}
