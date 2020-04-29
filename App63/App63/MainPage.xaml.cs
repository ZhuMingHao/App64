using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App63
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private bool flag;
        private void Button_Clicked(object sender, EventArgs e)
        {
            flag = !flag;

            string pausefunctionString = @"var videos = document.querySelectorAll('video');  
                        [].forEach.call(videos, function(video) { video.pause(); });
                        ";
            string playfunctionString = @"var videos = document.querySelectorAll('video');  
                        [].forEach.call(videos, function(video) { video.play(); });
                        ";
            if (flag)
            {
                MyWebView.Eval(pausefunctionString);
            }
            else
            {
                MyWebView.Eval(playfunctionString);
            }
          

        }
    }
}
