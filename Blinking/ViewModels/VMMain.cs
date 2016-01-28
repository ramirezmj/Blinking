using System;
using System.Windows.Input;
using Blinking.ViewModels.Base;

namespace Blinking.ViewModels
{
	public class VMMain : VMBase
	{
		#region Properties

		#endregion

		public VMMain()
		{
			InitializeCommands();
		}

		private bool flag;
		public bool Flag
		{
			get
			{
				return flag;
			}

			set
			{
				flag = value;
				RaisePropertyChanged("Flag");
				buttonCommand.Value.RaiseCanExecuteChanged(this);
			}
		}


		#region Commands

		private Lazy<DelegateCommand<string>> accept;
		private Lazy<DelegateCommand<string>> cancel;
		private Lazy<DelegateCommand<string>> buttonCommand;

		#region Default Commands
		public ICommand Accept
		{
			get
			{
				return accept.Value;
			}
		}

		public ICommand Cancel
		{
			get
			{
				return cancel.Value;
			}
		}
		#endregion

		public ICommand ButtonCommand
		{
			get
			{
				return buttonCommand.Value;
			}
		}

		private void InitializeCommands()
		{
			#region Default Commands
			accept = new Lazy<DelegateCommand<string>>(
				() => new DelegateCommand<string>(AcceptCommandExecute,
												  AcceptCommandCanExecute));

			cancel = new Lazy<DelegateCommand<string>>(
				() => new DelegateCommand<string>(CancelCommandExecute,
												  CancelCommandCanExecute));
			#endregion
			buttonCommand = new Lazy<DelegateCommand<string>>(
				() => new DelegateCommand<string>(ButtonCommandExecute,
									  ButtonCommandCanExecute));

		}

		public void ButtonCommandExecute(string param)
		{
			if (flag)
			{
				flag = false;
			} else
			{
				flag = true;
			}
			RaisePropertyChanged("Flag");
		}

		public bool ButtonCommandCanExecute(object param)
		{
			return true;
		}

		#region Default Commands
		public void AcceptCommandExecute(string param)
		{

		}

		public bool AcceptCommandCanExecute(object param)
		{
			return true;
		}

		public void CancelCommandExecute(string param)
		{

		}

		public bool CancelCommandCanExecute(object param)
		{
			return true;
		}
		#endregion
#endregion
	}
}
