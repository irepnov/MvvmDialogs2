namespace DCOM.WPF.MVVM.IDialogService
{
    using System;
    using System.Windows.Input;

    public class DialogViewModel : IDialogRequestClose
    {
        public DialogViewModel(string message)
        {
            Message       = message;
            OkCommand     = new ActionCommand(p => CloseRequested?.Invoke(this, new DialogCloseRequestedEventArgs(true)));
            CancelCommand = new ActionCommand(p => CloseRequested?.Invoke(this, new DialogCloseRequestedEventArgs(false)));
        }

        public event EventHandler<DialogCloseRequestedEventArgs> CloseRequested;
        public string Message { get; }
        public ICommand OkCommand { get; }
        public ICommand CancelCommand { get; }
    }
}