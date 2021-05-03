using System.Windows.Input;

namespace _7lab
{
    public static class MyCommand
    {
        static MyCommand()
        {
            InputGestureCollection gestureCollection = new InputGestureCollection//связывание сочетания клавиш с выполнением комманды
            {
                new KeyGesture(Key.Enter)
            };

            myCommand = new RoutedUICommand("MyCommand", "MyCommand", typeof(MyCommand), gestureCollection);
        }
        public static RoutedUICommand myCommand { get; private set; }
    }
}
