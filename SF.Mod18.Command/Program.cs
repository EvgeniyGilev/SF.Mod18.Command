using System;
using SF.Mod18.Command.Commands;

namespace SF.Mod18.Command
{
    class Program
    {
        static void Main(string[] args)
        {
            // создадим отправителя
            var sender = new SenderCommand();

            // создадим получателя
            var receiver = new ReceiverCommand();

            // создадим команду
            var commandOne = new GetVideoInfo(receiver);

            // инициализация команды
            sender.SetAction(commandOne);
            
            //  выполнение
            sender.Run();
            Console.ReadKey();

            // создадим команду на загрузку
            var commandTwo = new DownloadVideo(receiver);
            sender.SetAction(commandTwo);

            sender.Run();
            Console.ReadKey();
        }
    }
}
