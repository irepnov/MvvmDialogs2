namespace DCOM.WPF.MVVM.IDialogService
{
    using System.Windows;
    using MVVM;

    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            IDialogService dialogService = new DialogService(MainWindow);

            dialogService.Register<DialogViewModel, DialogWindow>();

            var viewModel = new MainWindowViewModel(dialogService);
            var view = new MainWindow { DataContext = viewModel };

            view.ShowDialog();
        }
    }
}