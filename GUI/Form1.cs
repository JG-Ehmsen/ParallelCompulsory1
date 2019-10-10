using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        Stopwatch sw;
        App app;

        double elapsedTime;

        public Form1()
        {
            InitializeComponent();
            app = new App();
            sw = new Stopwatch();
        }

        private void btnRunSeq_Click(object sender, System.EventArgs e)
        {
            Console.WriteLine("Clicked run Seq");

            long start;
            long end;

            if (!Int64.TryParse(txtStartingNumber.Text, out start))
                return;
            if (!Int64.TryParse(txtEndingNumber.Text, out end))
                return;
            sw.Restart();
            var primes = app.GetPrimesSequential(start, end);
            sw.Stop();
            lblElapsedTime.Text = (sw.ElapsedMilliseconds / 1000.0).ToString("F5");
            //listResults.Get
        }

        private void btnRunPar_Click(object sender, System.EventArgs e)
        {
            Task.Factory.StartNew(() => runParallel(), 
                CancellationToken.None, 
                TaskCreationOptions.None,
                TaskScheduler.FromCurrentSynchronizationContext());
            Console.WriteLine("Clicked run par");

            var wrk = new BackgroundWorker();
            wrk.DoWork += (s, ea) => runParallel();
            wrk.RunWorkerCompleted += (s, ea) =>
            {
                lblElapsedTime.Text = elapsedTime.ToString("F5");
            };
            wrk.RunWorkerAsync();
        }

        private void runParallel()
        {
            long start;
            long end;

            if (!Int64.TryParse(txtStartingNumber.Text, out start))
                return;
            if (!Int64.TryParse(txtEndingNumber.Text, out end))
                return;
            sw.Restart();
            var primes = app.GetPrimesParallel(start, end);
            sw.Stop();
            elapsedTime = (sw.ElapsedMilliseconds / 1000.0);
        }
    }
}
