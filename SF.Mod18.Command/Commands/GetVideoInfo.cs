using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Browser;
using SF.Mod18.Command.Iinterfaces;
using YoutubeExplode;
using YoutubeExplode.Videos;



namespace SF.Mod18.Command.Commands
{
    /// <summary>
    /// Команда получения информации о видео
    /// </summary>
    class GetVideoInfo : IActionAsync
    {
        private ReceiverCommand receiverCommand;

        public GetVideoInfo(ReceiverCommand receiver)
        {
            this.receiverCommand = receiver;
        }

        async Task IActionAsync.Cancel()
        {
            throw new NotImplementedException();
        }

        async Task IActionAsync.Run()
        {
            Console.WriteLine("Команда отправлена запроса информации о видео отправлена");
            //реализация команды

            try
            {
                var youtube = new YoutubeClient();

                var video = await youtube.Videos.GetAsync("https://www.youtube.com/watch?v=MNbM4tA_MmU");

                Console.WriteLine($"Название: {video.Title}");
                Console.WriteLine($"Продолжительность: {video.Duration}");
                Console.WriteLine($"Автор: {video.Author}");

                receiverCommand.GetVideoInfoComplete();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
