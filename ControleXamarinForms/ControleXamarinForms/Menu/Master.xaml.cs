using ControleXamarinForms.Controls;
using System;

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

        private void GoEntryEditorPage(object sender, EventArgs e)
        {
            Detail = new EntryEditorPage();
            IsPresented = false;
        }

        private void GoDatePickerPage(object sender, EventArgs e)
        {
            Detail = new DatePickerPage();
            IsPresented = false;
        }

        private void GoTimePickerPage(object sender, EventArgs e)
        {
            Detail = new TimePickerPage();
            IsPresented = false;
        }

        private void GoPickerPage(object sender, EventArgs e)
        {
            Detail = new PickerPage();
            IsPresented = false;
        }

        private void GoSearchBarPage(object sender, EventArgs e)
        {
            Detail = new SearchBarPage();
            IsPresented = false;
        }

        private void GoSliderStepperPage(object sender, EventArgs e)
        {
            Detail = new SliderStepperPage();
            IsPresented = false;
        }

        private void GoSwitchPage(object sender, EventArgs e)
        {
            Detail = new SwitchPage();
            IsPresented = false;
        }
    }
}