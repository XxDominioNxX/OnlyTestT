using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using OnlyTestT.Models;
using Xamarin.Forms;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace OnlyTestT.ViewModel
{

    public class ItemsViewModel:INotifyPropertyChanged
    {
        public ObservableCollection<Survey> survey_list { get; private set; }
        private Request request;

        public ItemsViewModel()
        {
            survey_list = new ObservableCollection<Survey>();
        }

        public ItemsViewModel(Request req)
        {
                request = req;
            survey_list = new ObservableCollection<Survey>();

                foreach (var item in request.payload.surveys)
                {
                survey_list.Add(item);
                }
        }




        public ObservableCollection<Survey> Survey_List
        {
            get { return survey_list; }
            set
            {
                if (survey_list != value)
                {
                    survey_list = value;
                    OnPropertyChanged("Survey_List");
                }
            }
        }


        


        public event PropertyChangedEventHandler PropertyChanged;
            public void OnPropertyChanged(string prop = "")
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }




    }
}

