using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nest;

namespace crashCourse
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        public static void Main()

        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            var local = new Uri("http://elastic.hackathon.cdlaws.co.uk");
            //was: local, null
            var settings = new ConnectionSettings(local = null);
            var client = new ElasticClient(settings);
            var searchResults = client.Search<Accident>(s => s
 .From(0)
 .Size(10)
 .Query(q => q
 .Term(p => p.age, "25")
   )
            );

        }

    }
}