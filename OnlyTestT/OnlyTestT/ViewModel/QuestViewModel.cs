using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using OnlyTestT.Models;
using OnlyTestT.View;

namespace OnlyTestT.ViewModel
{
    class QuestViewModel : INotifyPropertyChanged
    {
        //-------------------------------------------


        private int _index;
        public List<Question> List_questions;
        public Survey L;
        

        

        public string Questions
        {
            get { return List_questions[_index].title; }
            set
            {
                if (List_questions[_index].title != value)
                {
                    List_questions[_index].title = value;

                }
            }
        }

        public int Index
        {
            get { return _index; }
            set
            {
                if (_index != value)
                {
                    _index = value;
                    OnPropertyChanged("Index");
                    OnPropertyChanged("Questions");
                    OnPropertyChanged("Index_view");
                }
            }
        }

        public int Index_view
        {
            get { return _index + 1; }
            set
            {
                if (_index + 1 != value)
                {
                    _index = value + 1;
                    OnPropertyChanged("Index_view");
                    OnPropertyChanged("Questions");
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
