using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
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
        List<string> _primes;

        public Form1()
        {
            InitializeComponent();
            app = new App();
            sw = new Stopwatch();
        }

        private void UpdateTable(string[] primes)
        {
            listResults.Items.Clear();
            listResults.Items.AddRange(primes);
        }

        private void btn_Click(object sender, System.EventArgs e)
        {
            bool parallel = sender.Equals(btnRunPar);

            var wrk = new BackgroundWorker();
            wrk.DoWork += (s, ea) => runGetPrimes(parallel);
            wrk.RunWorkerCompleted += (s, ea) =>
            {
                lblElapsedTime.Text = elapsedTime.ToString("F5");
                UpdateTable(_primes.ToArray());
            };
            wrk.RunWorkerAsync();
        }

        private void runGetPrimes(bool parallel)
        {
            long start;
            long end;

            if (!Int64.TryParse(txtStartingNumber.Text, out start))
                return;
            if (!Int64.TryParse(txtEndingNumber.Text, out end))
                return;

            List<string> primes;
            sw.Restart();
            if (parallel)
            {
                primes = app.GetPrimesParallel(start, end);
            } else
            {
                primes = app.GetPrimesSequential(start, end);
            }
            _primes = primes;
            sw.Stop();
            elapsedTime = (sw.ElapsedMilliseconds / 1000.0);
        }
    }
}
