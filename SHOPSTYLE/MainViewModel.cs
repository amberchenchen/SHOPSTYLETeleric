using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace SHOPSTYLE
{
	public class MainViewModel : INotifyPropertyChanged
	{
		private ObservableCollection<Recipe> recipes;

		public ObservableCollection<Recipe> Recipes
		{
			get { return recipes; }
			set
			{
				recipes = value;
				this.OnPropertyChanged("Recipes");
			}
		}

		public List<string> Categories { get; set; }

		public MainViewModel()
		{
			this.Categories = new List<string>() { "Shop Products", "My Account", "My Cart", "Setting", "About" };

			this.Recipes = new ObservableCollection<Recipe>()
			{
				new Recipe("original.png", "Leather Bag", "$20000", "1"),
				new Recipe("clutch.png", "Clutch Bag", "$30000", "2"),
				new Recipe("clutchBlue.png", "Clutch Blue Bag", "$30000", "3"),
				new Recipe("weekender.png", "Weekender Bag", "$40000", "4"),
				new Recipe("weekenderBlack.png", "Weekender Black Bag", "$50000", "5"),
				new Recipe("messengerbag.png", "Messenger Bag", "$32000", "6"),
				new Recipe("backpack.png", "Back Pack", "$60000", "7"),
				new Recipe("documentholder.png", "Document Holder", "$70000", "8")
			};
		}

		internal void Load(string itemsToLoad)
		{
			switch (itemsToLoad)
			{
				default:
					this.Recipes = new ObservableCollection<Recipe>()
					{
						new Recipe("original.png", "Leather Bag", "$20000", "1"),
						new Recipe("clutch.png", "Clutch Bag", "$30000", "2"),
						new Recipe("clutchBlue.png", "Clutch Blue Bag", "$30000", "3"),
						new Recipe("weekender.png", "Weekender Bag", "$40000", "4"),
						new Recipe("weekenderBlack.png", "Weekender Black Bag", "$50000", "5"),
						new Recipe("messengerbag.png", "Messenger Bag", "$32000", "6"),
						new Recipe("backpack.png", "Back Pack", "$60000", "7"),
						new Recipe("documentholder.png", "Document Holder", "$70000", "8")
					};
					break;
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}

