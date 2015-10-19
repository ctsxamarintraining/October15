using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonHttpRequestDemo
{
    class Program
    {
        static int width = Console.LargestWindowWidth / 2;
        static int height = Console.LargestWindowHeight / 2;

        static int inputCurX;
        static int inputCurY;

        static int statusLineY = 0;

        static void Main(string[] args)
        {
            Console.SetWindowPosition(0, 0);
            Console.CursorVisible = true;

            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);
            
            Console.SetCursorPosition(0, height - 2);
            Console.Write("Enter url: ");
            inputCurX = Console.CursorLeft;
            inputCurY = Console.CursorTop;           
            
            while (true) {
                ClearCurrentConsoleLine();                
                string userInput = Console.ReadLine();
                statusLineY += 1;
                int msgY = statusLineY;
                PrintStatus(string.Format("{0} : {1}", userInput, "In Progress.."), msgY);
                
                NonBlockingHttp http = new NonBlockingHttp(userInput);                
                Task<string> getTask = http.Get();
                getTask.ContinueWith((t) => PrintStatus(string.Format("{0} : {1}", userInput, "Done!!"), msgY));
            }

            Console.ReadLine();
        }

        static void PrintStatus(string message, int lineNo)
        {
            Console.SetCursorPosition(0, lineNo);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, lineNo);
            Console.WriteLine(message);
            Console.SetCursorPosition(inputCurX, inputCurY);
        }

        static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(inputCurX, inputCurY);
            Console.Write(new string(' ', Console.WindowWidth-inputCurX));
            Console.SetCursorPosition(inputCurX, inputCurY);
        }
    }
}
