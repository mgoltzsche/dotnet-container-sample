using System.Diagnostics;
using static System.Console;

// Variant of https://github.com/dotnet/core/tree/main/samples/dotnet-runtimeinfo
// Ascii text: https://ascii.co.uk/text (Univers font)


WriteLine("""
Running dotnet application that starts a process with arguments
""");

Process p = new Process();
p.StartInfo.FileName = "/printargs.sh";
p.StartInfo.Arguments = "arg1 \"arg 2\" \"arg \\\\ \\\" \\\\\"\" 3\" \"\"arg\"4\" arg5\\ arg6\\\" \"arg\n 7\" \"arg\\n 8\" \"\"\"arg 9\"\"\" \"arg 10\"\"\"x\" lastarg";
p.StartInfo.WorkingDirectory = ".";
p.StartInfo.UseShellExecute = false;
p.StartInfo.CreateNoWindow = true;
p.Start();
p.WaitForExit();
