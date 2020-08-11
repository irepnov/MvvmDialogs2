namespace DCOM.WPF.MVVM.IDialogService
{
    using System.Windows;

    public partial class DialogWindow : Window, IDialog
    {
        public DialogWindow()
        {
            InitializeComponent();
        }
    }
}