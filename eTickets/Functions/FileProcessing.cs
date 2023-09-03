using Microsoft.Extensions.Hosting.Internal;
using System;
using File = System.IO.File;

namespace eTickets.Functions
{
    public static class FileProcessing
    {
        public static bool log_Error_Message(string content)
        {
            //string file_path = HttpContext.Current.Server.MapPath("~/Errors/messages.txt");
                try
            {
                string file_path = "errorMessages.txt";
                // Check if the file exists and write content to it
                if (!File.Exists(file_path))
                {
                    File.WriteAllText(file_path, content);
                    return true;
                }
                else
                {
                    File.AppendAllText(file_path, content);
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
