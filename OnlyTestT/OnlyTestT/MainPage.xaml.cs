using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using OnlyTestT.Models;
using System.Collections.ObjectModel;
using OnlyTestT.View;

namespace OnlyTestT
{
    public partial class MainPage : Shell
    {
        
        public MainPage()
        {
            
            InitializeComponent();
    
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Current.GoToAsync("//LoginPage");
        }
    }
}
