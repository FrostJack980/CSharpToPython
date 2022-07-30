using System.Diagnostics;

namespace CSharpToPython
{
    class Program
    {
        static void Main(string[] args)
        {
            Process process = new Process(); // Create a new process
            process.StartInfo.FileName = "python.exe"; 
            process.StartInfo.Arguments = @""; //Insert path to python file here
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true; //Required to redirect output
            process.Start(); //Start the process
            string output = process.StandardOutput.ReadToEnd(); //Read the output
            process.WaitForExit(); //Wait for the process to exit
            process.Close(); //Close the process
            System.Console.WriteLine(output); //Print the output
        }
    }
}
