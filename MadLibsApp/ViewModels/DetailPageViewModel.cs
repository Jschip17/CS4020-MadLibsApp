using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Common;
using Template10.Mvvm;
using Template10.Services.NavigationService;
using Windows.UI.Xaml.Navigation;

namespace MadLibsApp.ViewModels
{
    public class DetailPageViewModel : ViewModelBase
    {
        public DetailPageViewModel()
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                TitleAndText = "Designtime value";
            }
        }

        private const char m_delimiter= '|';
        private string m_titleAndText = "Default";
        private string m_title = "Title";
        private string m_text = "Text";
        private string m_image = "ms-appx:///Assets/StoreLogo.png";
        private string m_url = "default";

        public string TitleAndText { get { return m_titleAndText; } set { Set(ref m_titleAndText, value); } }
        public string Title { get { return m_title; } set { Set(ref m_title, value); } }
        public string Text { get { return m_text; } set { Set(ref m_text, value); } }
        public string Image { get { return m_image; } set { Set(ref m_image, value); } }
        public string URL { get { return m_url; } set { Set(ref m_url, value); } }

        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> suspensionState)
        {
            TitleAndText = (suspensionState.ContainsKey(nameof(TitleAndText))) ? suspensionState[nameof(TitleAndText)]?.ToString() : parameter?.ToString();
            string[] titleAndText = TitleAndText.Split(m_delimiter);
            Title = titleAndText[0];
            Text = titleAndText[1];

            switch (Title)
            {
                case "A Day at the Zoo!":
                    Image = "ms-appx:///Assets/DayAtZooImage.JPG";
                    URL = "http://www.teach-nology.com/worksheets/language_arts/madlibs/1/";
                    break;
                case "Make Me A Video Game!":
                    Image = "ms-appx:///Assets/MakeVideoGameImage.jpg";
                    URL = "http://www.teach-nology.com/worksheets/language_arts/madlibs/6/";
                    break;
                default:
                    Image = "ms-appx:///Assets/StoreLogo.png";
                    URL = "http://www.teach-nology.com/";
                    break;
            }

            await Task.CompletedTask;
        }

        public override async Task OnNavigatedFromAsync(IDictionary<string, object> suspensionState, bool suspending)
        {
            if (suspending)
            {
                suspensionState[nameof(TitleAndText)] = TitleAndText;
                suspensionState[nameof(Title)] = Title;
                suspensionState[nameof(Text)] = Text;
            }
            await Task.CompletedTask;
        }

        public override async Task OnNavigatingFromAsync(NavigatingEventArgs args)
        {
            args.Cancel = false;
            await Task.CompletedTask;
        }
    }
}
