using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XLabs.Forms;
using System.Collections.ObjectModel;
using System.Windows.Input;
using XLabs.Forms.Controls;

namespace XLabs.Sample.Pages.Controls
{	
	public partial class ExtendedPickerPage : ContentPage
	{
		public class DataClass
		{
			public string FirstName{get;set;}
			public string LastName{get;set;}
		}

		public ExtendedPickerPage ()
		{
			InitializeComponent ();
			BindingContext = this;
			myPicker = new ExtendedPicker (){DisplayProperty = "FirstName"};
			myPicker.SetBinding(ExtendedPicker.ItemsSourceProperty,new Binding("MyDataList",BindingMode.TwoWay));
			myPicker.SetBinding(ExtendedPicker.SelectedItemProperty,new Binding("TheChosenOne",BindingMode.TwoWay));
			myStackLayout.Children.Add (new Label{ Text = "Code Created:" });
			myStackLayout.Children.Add (myPicker);


			TheChosenOne = new DataClass(){ FirstName = "Jet", LastName = "Li" };
			MyDataList = new ObservableCollection<object> () {
				new DataClass(){FirstName="Jack",LastName="Doe"},
				TheChosenOne,
				new DataClass(){FirstName="Matt",LastName="Bar"},
				new DataClass(){FirstName="Mic",LastName="Jaggery"},
				new DataClass(){FirstName="Michael",LastName="Jackon"}
			};

		}
		public ICommand DoIt{ get; set; }

		private object chosenOne;
		public object TheChosenOne{ 
			get{ 
				return chosenOne; 
			} 
			set{
				chosenOne = value;
				OnPropertyChanged ("TheChosenOne");
			}
		}

		ObservableCollection<object> dataList; 
		public ObservableCollection<object> MyDataList {
			get{ return dataList; }
			set{
				dataList = value;
				OnPropertyChanged ("MyDataList");
			}
		}

	}
}

