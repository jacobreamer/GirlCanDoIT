using System;
using System.Collections.Generic;
using System.Text;
using GirlsCanDoIT.View;
using GirlsCanDoIT.ViewModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using GirlsCanDoIT.Model;
using Xamarin.Forms;

namespace GirlsCanDoIT.ViewModel
{
	public class ViewModelBase : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null)
			{
				handler(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
