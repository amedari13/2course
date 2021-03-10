using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

/// Создать иерархию классов исключений (собственных) – 3 типа и более.
/*Сделать наследование пользовательских типов исключений от стандартных
классов .Net (например, Exception, IndexOutofRange).
Сгенерировать и обработать как минимум пять различных исключительных
ситуаций на основе своих и стандартных исключений. Например, не позволять при
инициализации объектов передавать неверные данные, обрабатывать ошибки при
работе с памятью и ошибки работы с файлами, деление на ноль, неверный индекс,
нулевой указатель и т. д.
В конце поставить универсальный обработчик catch.
Обработку исключений вынести в main. При обработке выводить
специфическую информацию о месте, диагностику и причине исключения.
Последним должен быть блок, который отлавливает все исключения (finally).
Добавьте код в одной из функций макрос Assert. Объясните что он проверяет, как
будет выполняться программа в случае не выполнения условия. Объясните
назначение Assert. 
*/
namespace _5lab
{
    class DeveloperExceptions : Exception
    {
        public DeveloperExceptions(string message)
        : base(message)
        { }
        public string message = "You can not work while you are under 18!";
        public string howToAvoid = "Grown up! And work harder";
    }


    class SoftwareExceptions : Exception
    {
        public SoftwareExceptions(string message)
        : base(message)
        { }
        public string message = "The version of your software is too old!!";
        public string howToAvoid = "Install the latest version";
    }

    class CommonException : ApplicationException
    {
        public CommonException(string str) : base(str) { }
        public override string ToString()
        {
            return Message;
        }
    }
}
