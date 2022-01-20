using System;
using System.Collections.Generic;
using System.Text;

namespace TelegramBot
{
    public class MyCommand : AbstractCommand, IChatTextCommand
    {
        public MyCommand()
        {
            CommandText = "/saymegoodbye";
        }

        public string ReturnText()
        {
            return "пока";
        }

    }
}
