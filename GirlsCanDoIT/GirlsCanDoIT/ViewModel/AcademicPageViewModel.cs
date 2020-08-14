using System;
using System.Collections.Generic;
using System.Text;
using GirlsCanDoIT.View;
using GirlsCanDoIT.ViewModel;
using GirlsCanDoIT.Model;
using Xamarin.Forms;


namespace GirlsCanDoIT.ViewModel
{
	public class AcademicPageViewModel : ViewModelBase
	{
		public IList<College> Colleges { get { return CollegeData.Colleges; } }

		College selectedCollege;
		public College SelectedCollege
		{
			get { return selectedCollege; }
			set
			{
				if (selectedCollege != value)
				{
					selectedCollege = value;
					OnPropertyChanged();
				}
			}
		}
	}
}
