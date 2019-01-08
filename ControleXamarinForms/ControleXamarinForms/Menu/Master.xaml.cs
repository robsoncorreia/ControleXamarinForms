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
        }

        private void GoProgressBarPage(object sender, EventArgs e)
        {
            Detail = new ProgressBarPage();
        }

        private void GoBoxViewPage(object sender, EventArgs e)
        {
            Detail = new BoxViewPage();
        }

        private void GoLabelPage(object sender, EventArgs e)
        {
            Detail = new LabelPage();
        }
    }
}