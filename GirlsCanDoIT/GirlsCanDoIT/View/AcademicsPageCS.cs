using System;
using System.Collections.Generic;
using System.Text;
using GirlsCanDoIT.View;
using GirlsCanDoIT.ViewModel;
using GirlsCanDoIT.Model;
using Xamarin.Forms;


namespace GirlsCanDoIT.View
{
	public class AcademicsPageCS : ContentPage
	{
		public AcademicsPageCS()
		{
			var picker = new Picker { Title = "Select a College", TitleColor = Color.White };
			picker.SetBinding(Picker.ItemsSourceProperty, "Colleges");
			picker.SetBinding(Picker.SelectedItemProperty, "SelectedCollege");
			picker.ItemDisplayBinding = new Binding("Name");

			var nameLabel = new Label { HorizontalOptions = LayoutOptions.Center };
			nameLabel.SetBinding(Label.TextProperty, "SelectedCollege.Name");
			nameLabel.SetDynamicResource(VisualElement.StyleProperty, "TitleStyle");

			var locationLabel = new Label { FontAttributes = FontAttributes.Italic, HorizontalOptions = LayoutOptions.Center };
			locationLabel.SetBinding(Label.TextProperty, "SelectedCollege.Location");

			var image = new Image { HeightRequest = 200, WidthRequest = 200, HorizontalOptions = LayoutOptions.CenterAndExpand };
			image.SetBinding(Image.SourceProperty, "SelectedCollege.ImageUrl");

			var detailsLabel = new Label();
			detailsLabel.SetBinding(Label.TextProperty, "SelectedCollege.Details");
			detailsLabel.SetDynamicResource(VisualElement.StyleProperty, "BodyStyle");

			Content = new ScrollView
			{
				Content = new StackLayout
				{
					Margin = new Thickness(20, 35, 20, 20),
					Children =
					{
						new Label { Text = "Colleges", FontAttributes = FontAttributes.Bold, HorizontalOptions = LayoutOptions.Center },
						picker,
						nameLabel,
						locationLabel,
						image,
						detailsLabel
					}
				}
			};

			BindingContext = new AcademicPageViewModel();
		}
	}
}
