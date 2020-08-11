namespace DCOM.WPF.MVVM.IDialogService.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using MVVM;

    [TestClass]
    public class MainWindowViewModelTests
    {
        private Mock<IDialogService> mock;
        private MainWindowViewModel viewModel;

        [TestInitialize]
        public void TestInitialize()
        {
            mock = new Mock<IDialogService>();
            viewModel = new MainWindowViewModel(mock.Object);
        }

        [TestMethod]
        public void DisplayMessageCommand_ShowsMessageDialog()
        {
            mock.Setup(p => p.ShowDialog(It.IsAny<DialogViewModel>())).Verifiable();
            
            viewModel.DisplayMessageCommand.Execute(null);
            
            mock.Verify();
        }
    }
}