using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MiraiSharp.Desktop.Controllers
{
    class Command
    {
        private Process _p;

        public Action<string> DataRecieve { set; get; }

        private void ActionOnRecieve(string s)
        {
            DataRecieve.Invoke(s);
        }

        public bool IsNull()
        {
            return _p is null;
        }

        public void Kill()
        {
            if (_p != null)
                _p.Kill();
        }

        public void StartProgram(string filename, string commandLine)
        => Task.Run(() =>
        {
            var info = new ProcessStartInfo();
            info.FileName = filename;
            info.Arguments = commandLine;

            info.UseShellExecute = false;
            info.RedirectStandardOutput = true;
            info.RedirectStandardError = true;
            info.CreateNoWindow = true;

            _p = new Process
            {
                StartInfo = info,
                EnableRaisingEvents = true
            };

            _p.OutputDataReceived += (s, o) =>
            {
                ActionOnRecieve(o.Data);
            };
            _p.ErrorDataReceived += (s, o) =>
            {
                ActionOnRecieve(o.Data);
            };
            _p.Start();
            _p.BeginOutputReadLine();
            _p.BeginErrorReadLine();
            _p.WaitForExit();
        });
    }
}
