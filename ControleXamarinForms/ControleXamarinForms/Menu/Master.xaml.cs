using ControleXamarinForms.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControleXamarinForms.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private void GoActivityIndicatorPage(object sender, EventArgs e)
        {
            Detail = new ActivityIndicatorPage();
            IsPresented = false;
        }

        private void GoProgressBarPage(object sender, EventArgs e)
        {
            Detail = new ProgressBarPage();
            IsPresented = false;
        }

        private void GoBoxViewPage(object sender, EventArgs e)
        {
            Detail = new BoxViewPage();
            IsPresented = false;
        }

        private void GoLabelPage(object sender, EventArgs e)
        {
            Detail = new LabelPage();
            IsPresented = false;
        }

        private void GoButtonPage(object sender, EventArgs e)
        {
            Detail = new ButtonPage();
            IsPresented = false;
        }
    }
}