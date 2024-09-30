using System.Windows;

namespace KTodo;

internal static class RefMainWindow
{
    static RefMainWindow()
    {
        if (Application.Current.MainWindow != null &&
            Window.GetWindow(Application.Current.MainWindow) is MainWindow mw)
            AppMainWindow = mw;
        else
            AppMainWindow = null!;
    }

    public static MainWindow AppMainWindow { get; }
}