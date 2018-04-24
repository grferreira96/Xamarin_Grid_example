using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Images_app
{
    
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageExercise : ContentPage
    {
        private int currentImage = 1;
        public ImageExercise()
        {
            InitializeComponent();
            currentImage = 1;
            LoadImage();
        }
        void LoadImage()
        {
            image.Source = new UriImageSource
            {
                Uri = new Uri(String.Format("http://lorempixel.com/1920/1080/city/{0}", currentImage)),
                CachingEnabled=false
            };
        }
        void Previous_Clicked(object sender, System.EventArgs e)
        {
            currentImage--;
            if (currentImage == 0)
                currentImage = 10;
            LoadImage();

        }
        void Next_Clicked(object sender, System.EventArgs e)
        {
            currentImage++;
            if (currentImage == 11)
                currentImage = 1;
            LoadImage();
        }
    }
}