using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMI
{


        public partial class MainPage : ContentPage
        {
            public MainPage()
            {
                InitializeComponent();
                ButtonBMI.Clicked += ButtonBMIClickEvent;
                ButtonBMI2.Clicked += ButtonClickEvent2;
            }

            private void ButtonBMIClickEvent(object sender, EventArgs e)
            {

                float height = float.Parse(EntryHeight.Text);
                float weight = float.Parse(Entry.Text);
                LabelResult.Text = "" + weight / (height * height);

                if (height <= 50)
                {
                    LabelResult.Text = "" + weight / (height * height);
                }
                else
                {
                    height = height / 100;
                    LabelResult.Text = "" + weight / (height * height);
                }
            }
            private void ButtonClickEvent2(object sender, EventArgs e)
            {
                float height = float.Parse(EntryHeight.Text);
                float weight = float.Parse(Entry.Text);

                if (height <= 3)
                {
                    LabelResult.Text = "" + weight / (height * height);
                    float BMI = weight / (height * height);
                    Navigation.PushModalAsync(new NavigationPage(new Page1(BMI)));
                }
                else
                {
                    height = height / 100;
                    LabelResult.Text = "" + weight / (height * height);
                    float BMI = weight / (height * height);
                    Navigation.PushModalAsync(new NavigationPage(new Page1(BMI)));
                }
            }
            private void ButtonBmiEvent(object sender, EventArgs e)
            {

                float height = float.Parse(EntryHeight.Text);
                float weight = float.Parse(Entry.Text);

                if (height <= 50)
                {
                    LabelResult.Text = "" + weight / (height * height);
                }
                else
                {
                    height = height / 100;
                    LabelResult.Text = "" + weight / (height * height);
                }
            }
        }
    }