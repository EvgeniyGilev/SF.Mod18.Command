using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.Mod18.Command.Interfaces
{
    /// <summary>
    /// интерфейс команд асинхронные таски
    /// </summary>
    interface IActionAsync
    {
        /// <summary>
        /// запускаем команду
        /// </summary>
        Task Run();

        /// <summary>
        /// отменяем запуск команды при необходимости
        /// </summary>
        Task Cancel();

    }
}
