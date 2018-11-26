using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BMI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        private float BMI;

        public Page1()
        {
            InitializeComponent();
            buttonBack.Clicked += buttonBackClicked;
        }

        public Page1(float BMI)
        {
            InitializeComponent();
            this.BMI = BMI;
            labelBMI.Text = "BMI=" + BMI;
            buttonBack.Clicked += buttonBackClicked;
        }


        private void buttonBackClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}