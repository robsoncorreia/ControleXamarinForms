using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControleXamarinForms.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchBarPage : ContentPage
    {
        private List<string> empresas;

        public SearchBarPage()
        {
            InitializeComponent();
            empresas = new List<string>();
            empresas.Add("Microsoft");
            empresas.Add("Apple");
            empresas.Add("Oracle");
            empresas.Add("IBM");
            empresas.Add("SAP");
            empresas.Add("UBER");
            empresas.Add("99Taxi");
            Preencher(empresas);
        }

        private void Preencher(List<string> empresas)
        {
            ListResult.Children.Clear();

            foreach (var item in empresas)
            {
                ListResult.Children.Add(new Label { Text = item });
            }
        }

        private void Pesquisar(object sender, TextChangedEventArgs e)
        {
            var resultado = empresas.Where(a => a.ToLower().Contains(e.NewTextValue.ToLower())).ToList<string>();
            Preencher(resultado);
        }
    }
}