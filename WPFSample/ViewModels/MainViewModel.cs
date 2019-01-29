using System.Windows.Input;
using WPFSample.Commons;

namespace WPFSample.ViewModels
{
	internal class MainViewModel : BaseViewModel
	{
		#region Fields

		private string _textBoxText;

		private string _textBlockText;

		#endregion // Fields

		#region Properties

		public string TextBoxText
		{
			get { return this._textBoxText; }
			set
			{
				this._textBoxText = value;
				this.NotifyPropertyChanged("TextBoxText");
			}
		}

		public string TextBlockText
		{
			get { return this._textBlockText; }
			set
			{
				if (this._textBlockText != value)
				{
					this._textBlockText = value;
					this.NotifyPropertyChanged("TextBlockText");
				}
			}
		}

		#endregion // Properties

		#region Commands

		private ICommand _changeTextCommand;

		public ICommand ChangeTextCommand => this._changeTextCommand ?? (this._changeTextCommand = new RelayCommand(p => this.ChangeText()));

		#endregion // Commands

		#region Constructors

		public MainViewModel()
		{
			TextBoxText = string.Empty;
			TextBlockText = "start";
		}

		#endregion // Constructors

		#region Methods

		private void ChangeText()
		{
			TextBlockText = TextBoxText;
			TextBoxText = string.Empty;
		}

		#endregion // Methods
	}
}