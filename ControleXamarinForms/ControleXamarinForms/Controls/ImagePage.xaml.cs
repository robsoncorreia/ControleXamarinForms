using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControleXamarinForms.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();

            Image imgUsb = new Image();
            if (Device.RuntimePlatform == Device.UWP)
            {
                imgUsb.Source = ImageSource.FromFile("Imagem/usb.jpg");
            }
            else
            {
                imgUsb.Source = ImageSource.FromFile("usb.jpg");
            }
            Container.Children.Add(imgUsb);
        }
    }
}