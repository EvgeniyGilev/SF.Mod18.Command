using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.Mod18.Command
{
    /// <summary>
    /// Получатель команды
    /// </summary>
    class ReceiverCommand
    {
        public void GetVideoInfoComplete()
            {
                Console.WriteLine("Получили информацию о видео");
            }

            public void DownloadComplete()
            {
                Console.WriteLine("Загрузили видео");
            }
    }
}
