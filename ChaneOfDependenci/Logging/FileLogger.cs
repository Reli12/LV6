using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaneOfDependenci.Logging
{
    class FileLogger : AbstractLogger
    {
        private string filePath;
        public FileLogger(MessageType messageType, string filePath) : base(messageType)
        {
            this.filePath = filePath;
        }
        protected override void WriteMessage(string message, MessageType type)
        {
           using (StreamWriter writer=new StreamWriter(filePath, true))
            {
                writer.WriteLine($"[{DateTime.Now}]:{message}");
            }
        }
    }

}
