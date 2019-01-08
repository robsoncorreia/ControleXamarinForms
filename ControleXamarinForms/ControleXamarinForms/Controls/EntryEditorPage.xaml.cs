using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControleXamarinForms.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryEditorPage : ContentPage
    {
        public EntryEditorPage()
        {
            InitializeComponent();

            TxtIdade.TextChanged += delegate (object sender, TextChangedEventArgs eventArgs)
            {
                LblDublicado.Text = eventArgs.NewTextValue;
            };

            TxtComentario.Completed += delegate (object sender, EventArgs eventArgs)
            {
                LblQuantidadeCaracteres.Text = TxtComentario.Text.Length.ToString();
            };
        }
    }
}