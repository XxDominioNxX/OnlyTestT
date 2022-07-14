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
    
    public class ItemDetailViewModel : INotifyPropertyChanged
    {
        public Survey survey;
        private string title;
        private string description;
        public ItemDetailViewModel()
        {
            survey = new Survey();
        }
        public ItemDetailViewModel(Survey sur)
        {
            survey = sur;
            title = survey.title;
            description = survey.description;
        }

        public string Title
        {
            get { return title; }
            set
            {
                if (title != value)
                {
                    title = value;
                    OnPropertyChanged("Title");
                }
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (description != value)
                {
                    description = value;
                    OnPropertyChanged("Description");
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
