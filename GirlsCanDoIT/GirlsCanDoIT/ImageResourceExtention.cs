using System;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GirlsCanDoIT
{
    [ContentProperty(nameof(Source))]
    internal class ImageResourceExtention : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
            {
                return null;
            }

            var imageSource = ImageSource.FromResource(Source, typeof(ImageResourceExtention).GetTypeInfo().Assembly);

            return imageSource;
        }
    }
}