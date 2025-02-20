using System;
using System.IO.Pipes;
using System.IO;
using System.Text;
using System.Threading;

class PipeCommunication
{
    private const string PipeName = "testPipe";

    public static void WriteDataToPipe()
    {
        try
        {
            using (NamedPipeServerStream pipeServer = new NamedPipeServerStream(PipeName, PipeDirection.Out))
            {
                Console.WriteLine("Writer: Waiting for the reader to connect...");
                pipeServer.WaitForConnection();
                Console.WriteLine("Writer: Connected to reader. Sending data...");

                string message = "Hello from the writer thread!";
                byte[] buffer = Encoding.UTF8.GetBytes(message);

                pipeServer.Write(buffer, 0, buffer.Length);
                Console.WriteLine("Writer: Data written to the pipe.");
            }
        }
        catch (IOException ioEx)
        {
            Console.WriteLine("I/O error occurred in writer thread: " + ioEx.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error occurred in writer thread: " + ex.Message);
        }
    }

    public static void ReadDataFromPipe()
    {
        try
        {
            using (NamedPipeClientStream pipeClient = new NamedPipeClientStream(PipeName))
            {
                Console.WriteLine("Reader: Connecting to the writer...");
                pipeClient.Connect();
                Console.WriteLine("Reader: Connected to writer. Reading data...");

                byte[] buffer = new byte[256];
                int bytesRead = pipeClient.Read(buffer, 0, buffer.Length);

                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Console.WriteLine("Reader: Received data: " + message);
            }
        }
        catch (IOException ioEx)
        {
            Console.WriteLine("I/O error occurred in reader thread: " + ioEx.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error occurred in reader thread: " + ex.Message);
        }
    }

    static void Main()
    {
        Thread writerThread = new Thread(WriteDataToPipe);
        writerThread.Start();

        Thread readerThread = new Thread(ReadDataFromPipe);
        readerThread.Start();

        writerThread.Join();
        readerThread.Join();

        Console.WriteLine("Communication completed.");
    }
}
