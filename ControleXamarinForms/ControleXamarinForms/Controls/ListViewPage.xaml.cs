using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleXamarinForms.Modelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControleXamarinForms.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();

            List<Pessoa> pessoas = new List<Pessoa>();

            pessoas.Add(new Pessoa
            {
                Idade = "20",
                Nome = "José"
            });
            pessoas.Add(new Pessoa
            {
                Idade = "24",
                Nome = "Maria"
            });
            pessoas.Add(new Pessoa
            {
                Idade = "28",
                Nome = "Paulo"
            });

            ListView.ItemsSource = pessoas;
        }
    }
}