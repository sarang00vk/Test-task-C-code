using NUnit.Framework;
using System;
using System.Diagnostics;

namespace TestProject1
{
    public class Tests
    {
        private Process? _process;
        private bool _isRunning;
        private ProcessStartInfo startInfo;
        private string _cmdLine;
        private string _args;

        [SetUp]
        public void Setup()
        {
            if (!_isRunning)
            {
                var startInfo = new ProcessStartInfo()
                {
                    CreateNoWindow = true,
                    UseShellExecute = true,

                    FileName = _cmdLine,
                    Arguments = _args,

                };
                _process = Process.Start(startInfo);
                _isRunning = true;
            }
            else
            {
                throw new InvalidOperationException("Process already started");


            }
        }
    
}

        
}