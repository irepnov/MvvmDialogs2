namespace DCOM.WPF.MVVM.IDialogService
{
    using MVVM;
    using System.Windows.Input;

    public class MainWindowViewModel
    {
        private readonly IDialogService dialogService;

        public MainWindowViewModel(IDialogService dialogService)
        {
            this.dialogService = dialogService;
            DisplayMessageCommand = new ActionCommand(p => DisplayMessage());
        }

        public ICommand DisplayMessageCommand { get; }

        private void DisplayMessage()
        {
            var viewModel = new DialogViewModel("Hello!");

            bool? result = dialogService.ShowDialog(viewModel);
            
            if (result.HasValue)
            {
                if (result.Value)
                {
                    // Accepted
                }
                else
                {
                    // Cancelled
                }
            }
        }
    }
}