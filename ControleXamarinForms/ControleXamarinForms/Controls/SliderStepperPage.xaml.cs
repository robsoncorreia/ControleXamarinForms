﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControleXamarinForms.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SliderStepperPage : ContentPage
    {
        public SliderStepperPage()
        {
            InitializeComponent();
        }

        private void ActionValorMudou(object sender, ValueChangedEventArgs e)
        {
            SliderResult.Text = e.NewValue.ToString();
        }

        private void ActionValorMudouStepper(object sender, ValueChangedEventArgs e)
        {
            SliderResult.Text = e.NewValue.ToString();
        }
    }
}