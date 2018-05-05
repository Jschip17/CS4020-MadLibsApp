using Template10.Mvvm;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Template10.Services.NavigationService;
using Windows.UI.Xaml.Navigation;

namespace MadLibsApp.ViewModels
{
    public class MakeVideoGamePageViewModel : ViewModelBase
    {
        public MakeVideoGamePageViewModel()
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
                Value13 = "Designtime value";
                Value14 = "Designtime value";
                Value15 = "Designtime value";
                Value16 = "Designtime value";
                Value17 = "Designtime value";
                Value18 = "Designtime value";
                Value19 = "Designtime value";
                Value20 = "Designtime value";
                Value21 = "Designtime value";
            }
        }

        private const char m_delimiter = '|';
        private const string m_title = "Make Me A Video Game!";
        private const string m_text = "I the {0} and {1} {2} has {3} {4}'s {5} sister and plans to steal her {6} {7}! " +
                                    "What are a {8} and backpacking {9} to do? " + 
                                    "Before you can help {10}, you'll have to collect the {11} {12} and {13} {14} that open up the {15} worlds connected to A {16}'s Lair. " + 
                                    "There are {17} {18} and {19} {20} in the game, along with hundreds of other goodies for you to find.";

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
        private string m_value13 = string.Empty;
        private string m_value14 = string.Empty;
        private string m_value15 = string.Empty;
        private string m_value16 = string.Empty;
        private string m_value17 = string.Empty;
        private string m_value18 = string.Empty;
        private string m_value19 = string.Empty;
        private string m_value20 = string.Empty;
        private string m_value21 = string.Empty;

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
        public string Value13 { get { return m_value13; } set { Set(ref m_value13, value); CheckAllValuesEntered(); } }
        public string Value14 { get { return m_value14; } set { Set(ref m_value14, value); CheckAllValuesEntered(); } }
        public string Value15 { get { return m_value15; } set { Set(ref m_value15, value); CheckAllValuesEntered(); } }
        public string Value16 { get { return m_value16; } set { Set(ref m_value16, value); CheckAllValuesEntered(); } }
        public string Value17 { get { return m_value17; } set { Set(ref m_value17, value); CheckAllValuesEntered(); } }
        public string Value18 { get { return m_value18; } set { Set(ref m_value18, value); CheckAllValuesEntered(); } }
        public string Value19 { get { return m_value19; } set { Set(ref m_value19, value); CheckAllValuesEntered(); } }
        public string Value20 { get { return m_value20; } set { Set(ref m_value20, value); CheckAllValuesEntered(); } }
        public string Value21 { get { return m_value21; } set { Set(ref m_value21, value); CheckAllValuesEntered(); } }

        private void CheckAllValuesEntered()
        {
            if (Value1 != String.Empty & Value2 != String.Empty & Value3 != String.Empty & Value4 != String.Empty & 
                Value5 != String.Empty & Value6 != String.Empty & Value7 != String.Empty & Value8 != String.Empty & 
                Value9 != String.Empty & Value10 != String.Empty & Value11 != String.Empty & Value12 != String.Empty &
                Value13 != String.Empty & Value14 != String.Empty & Value15 != String.Empty & Value16 != String.Empty &
                Value17 != String.Empty & Value18 != String.Empty & Value19 != String.Empty & Value20 != String.Empty &
                Value21 != String.Empty)
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
                Value13 = suspensionState[nameof(Value13)]?.ToString();
                Value14 = suspensionState[nameof(Value14)]?.ToString();
                Value15 = suspensionState[nameof(Value15)]?.ToString();
                Value16 = suspensionState[nameof(Value16)]?.ToString();
                Value17 = suspensionState[nameof(Value17)]?.ToString();
                Value18 = suspensionState[nameof(Value18)]?.ToString();
                Value19 = suspensionState[nameof(Value19)]?.ToString();
                Value20 = suspensionState[nameof(Value20)]?.ToString();
                Value21 = suspensionState[nameof(Value21)]?.ToString();
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
                suspensionState[nameof(Value13)] = Value13;
                suspensionState[nameof(Value14)] = Value14;
                suspensionState[nameof(Value15)] = Value15;
                suspensionState[nameof(Value16)] = Value16;
                suspensionState[nameof(Value17)] = Value17;
                suspensionState[nameof(Value18)] = Value18;
                suspensionState[nameof(Value19)] = Value19;
                suspensionState[nameof(Value20)] = Value20;
                suspensionState[nameof(Value21)] = Value21;
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
                string zooText = String.Format(m_text, Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9, Value10, Value11, Value12, Value13, Value14, Value15, Value16, Value17, Value18, Value19, Value20, Value21);
                string titleAndText = m_title + m_delimiter + zooText;              

                NavigationService.Navigate(typeof(Views.DetailPage), titleAndText);
            }
        }

    }
}
