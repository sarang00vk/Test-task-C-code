

namespace Processmonitor1
{
    using System.Diagnostics;
    using System.Threading;
    public class Program
    {
        public static void Main(string[] args)
        {
            var processStartInfo = new ProcessStartInfo
            {
                FileName = "sample.txt",
                WindowStyle = ProcessWindowStyle.Maximized
            };

            using (var process = Process.Start(processStartInfo))
            {
                Thread.Sleep(30000);

                process?.Kill();
            }
        }


    }
}
