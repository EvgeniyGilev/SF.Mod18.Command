using SF.Mod18.Command.Interfaces;

namespace SF.Mod18.Command
{
    /// <summary>
    /// Отправитель команды
    /// </summary>
    class SenderCommand
    {
        IActionAsync _action;

        /// <summary>
        ///  Инициализация команды
        /// </summary>
        public void SetAction(IActionAsync action)
        {
            _action = action;
        }

        // Выполнить
        public void Run()
        {
            _action.Run();
        }

        // Отменить
        public void Cancel()
        {
            _action.Cancel();
        }
    }
}
