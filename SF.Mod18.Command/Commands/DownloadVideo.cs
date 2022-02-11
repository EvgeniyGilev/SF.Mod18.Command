using System;
using System.Threading.Tasks;
using SF.Mod18.Command.Interfaces;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace SF.Mod18.Command.Commands
{
    /// <summary>
    /// Команда загрузки видео
    /// </summary>
    class DownloadVideo : IActionAsync
    {
        private ReceiverCommand receiverCommand;

        public DownloadVideo(ReceiverCommand receiver)
        {
            this.receiverCommand = receiver;
        }

        Task IActionAsync.Cancel()
        {
            throw new NotImplementedException();
        }

        async Task IActionAsync.Run()
        {
            Console.WriteLine("Команда загрузки видео отправлена");

            try
            {
                var youtube = new YoutubeClient();

                await youtube.Videos.DownloadAsync("https://www.youtube.com/watch?v=MNbM4tA_MmU", "video.mp4", builder => builder.SetPreset(ConversionPreset.UltraFast));

                receiverCommand.DownloadComplete();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
