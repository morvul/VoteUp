using System.Windows;

namespace VoteUp {
    public class ShellViewModel : Caliburn.Micro.PropertyChangedBase, IShell
    {
        private string _message;

        public string Message {
            get { return _message; }
            set { Set(ref _message, value); }
        }

        public void SendMessage()
        {
            MessageBox.Show(Message);
        }

    }
}