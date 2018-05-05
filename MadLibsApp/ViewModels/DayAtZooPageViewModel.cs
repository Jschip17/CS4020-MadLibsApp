using Template10.Mvvm;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Template10.Services.NavigationService;
using Windows.UI.Xaml.Navigation;

namespace MadLibsApp.ViewModels
{
    public class DayAtZooPageViewModel : ViewModelBase
    {
        public DayAtZooPageViewModel()
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                Value1 = "Designtime value";
                Value2 = "Designtime value";
                Value3 = "Designtime value";
                Value4 = "Designtime value";
                Value5 = "Designtime value";
                Value6 = "Designtime value";
                Value7 = "Designtime value";
                Value8 = "Designtime value";
                Value9 = "Designtime value";
                Value10 = "Designtime value";
                Value11 = "Designtime value";
                Value12 = "Designtime value";
            }
        }

        private const char m_delimiter = '|';
        private const string m_title = "A Day at the Zoo!";
        private const string m_text = "Today I went to the zoo. " +
                                "I saw a {0} {1} jumping up and down in its tree. " +
                                "He {2} {3} through the large tunnel that led to its {4} {5}. " +
                                "I got some peanuts and passed them through the cage to a gigantic gray {6} towering over my head. " +
                                "Feeding that animal made me hungry. " +
                                "I went to get a {7} scoop of ice cream. " +
                                "It filled my stomach. " +
                                "Afterwards I had to {8} {9} to catch our bus. " +
                                "When I got home I {10} my mom for a {11} day at the zoo.";

        private Boolean m_allEntered = false;

        private string m_value1 = string.Empty;
        private string m_value2 = string.Empty;
        private string m_value3 = string.Empty;
        private string m_value4 = string.Empty;
        private string m_value5 = string.Empty;
        private string m_value6 = string.Empty;
        private string m_value7 = string.Empty;
        private string m_value8 = string.Empty;
        private string m_value9 = string.Empty;
        private string m_value10 = string.Empty;
        private string m_value11 = string.Empty;
        private string m_value12 = string.Empty;
        
        public Boolean AllEntered { get { return m_allEntered; } set { Set(ref m_allEntered, value); } }
        public string Value1 { get { return m_value1; } set { Set(ref m_value1, value); CheckAllValuesEntered(); } }
        public string Value2 { get { return m_value2; } set { Set(ref m_value2, value); CheckAllValuesEntered(); } }
        public string Value3 { get { return m_value3; } set { Set(ref m_value3, value); CheckAllValuesEntered(); } }
        public string Value4 { get { return m_value4; } set { Set(ref m_value4, value); CheckAllValuesEntered(); } }
        public string Value5 { get { return m_value5; } set { Set(ref m_value5, value); CheckAllValuesEntered(); } }
        public string Value6 { get { return m_value6; } set { Set(ref m_value6, value); CheckAllValuesEntered(); } }
        public string Value7 { get { return m_value7; } set { Set(ref m_value7, value); CheckAllValuesEntered(); } }
        public string Value8 { get { return m_value8; } set { Set(ref m_value8, value); CheckAllValuesEntered(); } }
        public string Value9 { get { return m_value9; } set { Set(ref m_value9, value); CheckAllValuesEntered(); } }
        public string Value10 { get { return m_value10; } set { Set(ref m_value10, value); CheckAllValuesEntered(); } }
        public string Value11 { get { return m_value11; } set { Set(ref m_value11, value); CheckAllValuesEntered(); } }
        public string Value12 { get { return m_value12; } set { Set(ref m_value12, value); CheckAllValuesEntered(); } }

        private void CheckAllValuesEntered()
        {
            if (Value1 != String.Empty & Value2 != String.Empty & Value3 != String.Empty & Value4 != String.Empty & 
                Value5 != String.Empty & Value6 != String.Empty & Value7 != String.Empty & Value8 != String.Empty & 
                Value9 != String.Empty & Value10 != String.Empty & Value11 != String.Empty & Value12 != String.Empty)
            {
                AllEntered = true;
            }
            else
            {
                AllEntered = false;
            }

        }

        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> suspensionState)
        {
            if (suspensionState.Any())
            {
                Value1 = suspensionState[nameof(Value1)]?.ToString();
                Value2 = suspensionState[nameof(Value2)]?.ToString();
                Value3 = suspensionState[nameof(Value3)]?.ToString();
                Value4 = suspensionState[nameof(Value4)]?.ToString();
                Value5 = suspensionState[nameof(Value5)]?.ToString();
                Value6 = suspensionState[nameof(Value6)]?.ToString();
                Value7 = suspensionState[nameof(Value7)]?.ToString();
                Value8 = suspensionState[nameof(Value8)]?.ToString();
                Value9 = suspensionState[nameof(Value9)]?.ToString();
                Value10 = suspensionState[nameof(Value10)]?.ToString();
                Value11 = suspensionState[nameof(Value11)]?.ToString();
                Value12 = suspensionState[nameof(Value12)]?.ToString();
            }
            await Task.CompletedTask;
        }

        public override async Task OnNavigatedFromAsync(IDictionary<string, object> suspensionState, bool suspending)
        {
            if (suspending)
            {
                suspensionState[nameof(Value1)] = Value1;
                suspensionState[nameof(Value2)] = Value2;
                suspensionState[nameof(Value3)] = Value3;
                suspensionState[nameof(Value4)] = Value4;
                suspensionState[nameof(Value5)] = Value5;
                suspensionState[nameof(Value6)] = Value6;
                suspensionState[nameof(Value7)] = Value7;
                suspensionState[nameof(Value8)] = Value8;
                suspensionState[nameof(Value9)] = Value9;
                suspensionState[nameof(Value10)] = Value10;
                suspensionState[nameof(Value11)] = Value11;
                suspensionState[nameof(Value12)] = Value12;
            }
            await Task.CompletedTask;
        }

        public override async Task OnNavigatingFromAsync(NavigatingEventArgs args)
        {
            args.Cancel = false;
            await Task.CompletedTask;
        }

        public void GotoDetailsPage()
        {
            if (AllEntered)
            {
                string zooText = String.Format(m_text, Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9, Value10, Value11, Value12);
                string titleAndText = m_title + m_delimiter + zooText;              

                NavigationService.Navigate(typeof(Views.DetailPage), titleAndText);
            }
        }

    }
}
