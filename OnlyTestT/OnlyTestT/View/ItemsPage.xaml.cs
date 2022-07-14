using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.ObjectModel;
using Xamarin.Essentials;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using OnlyTestT.Models;
using OnlyTestT.View;
using OnlyTestT.ViewModel;

namespace OnlyTestT.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsPage : ContentPage
    {
        Request m;
        ItemsViewModel _asd;
        Label network = new Label();

        public ItemsPage()
        {
            InitializeComponent();
            Title = "Анкеты";
            UpdateList();


            Device.StartTimer(TimeSpan.FromSeconds(5), () =>
            {
                var current = Connectivity.NetworkAccess;

                if (current != NetworkAccess.Internet)
                {
                    SurveyList.IsVisible = false;
                    //network.Text = "Интернет соединение отсутствует :(";
                    //stack.Children.Add(network);
                    DisplayAlert("Ошибка", "Интернет соединение отсутствует :(", "Повторить");
                }
                else
                {
                    SurveyList.IsVisible = true;
                }

                return true;
            });


        }

        private void clicka(object sender, EventArgs e)
        {

            string json = "{\"success\":true,\"payload\":{\"total\":1,\"surveys\":[{\"id\":\"61701871b3d55b2f41cfe125\",\"createdAt\":null,\"beginDate\":null,\"endDate\":null,\"title\":\"Заголовок от бога\",\"description\":\"dasdвввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввas213\",\"questions\":[{\"id\":\"1635277566564\",\"title\":\"123\",\"type\":\"multiple\",\"answers\":[{\"id\":\"1635282758697\",\"text\":\"12312\",\"code\":0,\"selected\":false,\"typedText\":\"\"}],\"required\":true},{\"id\":\"1635429412505\",\"title\":\"Gdhdj\",\"type\":\"multiple\",\"answers\":[{\"id\":\"1635429419480\",\"text\":\"Gshsh\",\"code\":123,\"selected\":false,\"typedText\":\"\"}],\"required\":false}],\"research\":null,\"position\":null}]}}";
            m = JsonConvert.DeserializeObject<Request>(json);

            _asd = new ItemsViewModel(m);
            BindingContext = _asd;
        }

        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        { 
            Navigation.PushAsync(new ItemDetailPage(m.payload.surveys[e.ItemIndex]));
        }

        private void UpdateList()
        {
            HttpConnect Request = new HttpConnect();
            string json = Request.Get("https://project-zero-0.herokuapp.com/api/v1.0/survey");
            m = JsonConvert.DeserializeObject<Request>(json);

            _asd = new ItemsViewModel(m);
            BindingContext = _asd;
        }

    }
}