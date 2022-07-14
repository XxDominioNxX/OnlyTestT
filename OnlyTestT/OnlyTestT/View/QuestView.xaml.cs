using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlyTestT.Models;
using OnlyTestT.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OnlyTestT.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuestView : ContentPage
    {

        QuestViewModel Test;
        Survey s;
        public QuestView(Survey surv)
        {
            s = surv;
            Test = new QuestViewModel
            {
                Index = 0,
                List_questions = surv.Questions
            };
            Resources["test"] = Test;
            InitializeComponent();
            Show_answers();
            line.X1 = 10;
            line.X2 = Application.Current.MainPage.Width - 10;
            Button_back.IsVisible = false;

        }

        private void Next(object sender, EventArgs e)
        {
            Test.Index += 1;
            Show_answers();
            if (Test.Index <= s.Questions.Count - 2)
            {
                Button_back.IsVisible = true;
                Button_next.IsVisible = true;
            }
            else
            {
                Button_next.IsVisible = false;
                Button_back.IsVisible = true;
            }

     



        }

        private void Back(object sender, EventArgs e)
        {
            Test.Index -= 1;
            Show_answers();
            if (Test.Index != 0)
            {
                Button_back.IsVisible = true;
                Button_next.IsVisible = true; 
            }
            else
            {
                Button_back.IsVisible = false;
                Button_next.IsVisible = true;
            }
            var a = answers.Children[1];
        }

        private void Show_answers()
        {
            

            //----------------------Очистка и новое заполнение списка ответов-------------------
            answers.Children.Clear();
            Label _lb = new Label
            {
                Text = "Выберите ответ:",
                FontSize = 25
            };
            answers.Children.Add(_lb);

            for (int i = 0; i < s.Questions[Test.Index].answers.Count; i++)
            {
                RadioButton rad_but = new RadioButton
                {
                    Content = s.Questions[Test.Index].answers[i].text,
                    GroupName = "Answers",
                    Value = i
                };
                rad_but.CheckedChanged += changed;
                if (s.Questions[Test.Index].answers[i].selected == true)
                {
                    rad_but.IsChecked = true;

                }
                else
                {
                    rad_but.IsChecked = false;
                }
                answers.Children.Add(rad_but);
                //------------------------------------------------------------------------------
            }
        }

        private async void Happy_End(object sender, EventArgs e)
        {

            for (var counter = 1; counter < 2; counter++)
            {
                Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 2]);
            }
            await Navigation.PopAsync();

        }

        private void changed(object sender, CheckedChangedEventArgs e)
        {
            var a = (RadioButton)sender;
            if (a.IsChecked)
            {
                s.Questions[Test.Index].answers[(int)a.Value].selected = true;
            }
            for (int i = 0; i < answers.Children.Count - 1; i++)
            {
                if((int)a.Value != i)
                s.Questions[Test.Index].answers[i].selected = false;
            }
            
        }
    }
}