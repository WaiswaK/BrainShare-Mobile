﻿using BrainShare.Core;
using BrainShare.ViewModels;

using Xamarin.Forms;

namespace BrainShare.Views
{
    public partial class PlayView : ContentPage
    {
        public PlayView(Models.VideoModel video)
        {
            InitializeComponent();
            BindingContext = new PlayViewModel(video);
            LoadFile(video.FilePath);          
        }
        private void LoadFile(string filePath)
        {
            if (DependencyService.Get<Interfaces.ITask>().IsInternetConnectionAvailable())
            {

                string newlink = CommonTask.newYouTubeLink(filePath);
                string Content = string.Format(@"<iframe width='{0}' height='{1}' src='{2}' frameborder='{3}'></iframe>", "560", "315", newlink, "0");
                //webView.Height = 640;
                //webView.Width = 640;
                //webView.NavigateToString(Content);
                Xamarin.Forms.HtmlWebViewSource temp = new Xamarin.Forms.HtmlWebViewSource();
                temp.Html = Content;
                webView.Source = temp;

            }
            else
            {

            }
        }
    }
}
