using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iRecipt
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReciptPage : ContentPage
    {
        Image image;

        public ReciptPage()
        {
            InitializeComponent();

            ChooseRecipt.Clicked += OnPickPhotoButtonClicked;

            
        }

        async void OnPickPhotoButtonClicked(object sender, EventArgs e)
        {
            (sender as Button).IsEnabled = false;

            Stream stream = await DependencyService.Get<ImageUpload>().GetImageStreamAsync();
            if (stream != null)
            {
                image.Source = ImageSource.FromStream(() => stream);
            }

                (sender as Button).IsEnabled = true;
        }
    }
}