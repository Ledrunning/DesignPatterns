﻿using System;
using Command.Microwave;
using Command.Tv;

namespace Command
{
    /// <summary>
    ///     Паттерн "Команда" (Command) позволяет инкапсулировать запрос на выполнение определенного действия в виде отдельного
    ///     объекта.
    ///     Этот объект запроса на действие и называется командой. При этом объекты, инициирующие запросы на выполнение
    ///     действия,
    ///     отделяются от объектов, которые выполняют это действие.
    ///     Команды могут использовать параметры, которые передают ассоциированную с командой информацию.Кроме того,
    ///     команды могут ставиться в очередь и также могут быть отменены.
    ///     Когда использовать команды?
    ///     Когда надо передавать в качестве параметров определенные действия, вызываемые в ответ на другие действия.
    ///     То есть когда необходимы функции обратного действия в ответ на определенные действия.
    ///     Когда необходимо обеспечить выполнение очереди запросов, а также их возможную отмену.
    ///     Когда надо поддерживать логгирование изменений в результате запросов. Использование логов может помочь восстановить
    ///     состояние системы
    ///     - для этого необходимо будет использовать последовательность запротоколированных команд.
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Command";

            var remoteControl = new RemoteControl();
            var tv = new TV();
            remoteControl.SetCommand(new TVOnCommand(tv));
            remoteControl.PressButton();
            remoteControl.PressUndo();

            var microwave = new Microwave.Microwave();
            // 5000 - время нагрева пищи
            remoteControl.SetCommand(new MicrowaveCommand(microwave, 5000));
            remoteControl.PressButton();

            Console.ReadKey();
        }
    }
}