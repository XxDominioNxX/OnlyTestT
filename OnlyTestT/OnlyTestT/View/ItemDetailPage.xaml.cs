using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using OnlyTestT.ViewModel;
using OnlyTestT.Models;
using OnlyTestT.View;

namespace OnlyTestT.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel _itm;
        Survey sur;
        public ItemDetailPage(Survey survey)
        {
            InitializeComponent();
            _itm = new ItemDetailViewModel(survey);
            sur = survey;
            BindingContext = _itm;




        }

        private void StartTest(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QuestView(sur));
        }
    }
}