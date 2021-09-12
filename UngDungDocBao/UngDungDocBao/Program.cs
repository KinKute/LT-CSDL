using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UngDungDocBao.IO;
using UngDungDocBao.RssFeed;

namespace UngDungDocBao
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            INewsRepository repository = new NewsRepository();
            NewsParse parser = new NewsParse();
            RssReader reader = new RssReader(parser);
            var manager = new NewsFeedManager(repository, reader);

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Mainform(manager));
        }
    }
}
