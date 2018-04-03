using System;
using System.Diagnostics;
using Telerik.XamarinForms.DataControls;
using Telerik.XamarinForms.DataControls.ListView;
using Xamarin.Forms;

namespace SHOPSTYLE
{
	public partial class SHOPSTYLEPage : ContentPage
	{
		MainViewModel vm;
		public SHOPSTYLEPage()
		{
			InitializeComponent();

			this.BindingContext = vm = new MainViewModel();

			NavigationPage.SetHasNavigationBar(this, false);

			var backClicked = new TapGestureRecognizer();
			backClicked.Tapped += backClicked_Tapped;

			this.drawerOpener.GestureRecognizers.Add(backClicked);

			this.list.LayoutDefinition = null;
			this.list.LayoutDefinition = new ListViewGridLayout() { GroupHeaderLength = 34, HorizontalItemSpacing = 2, VerticalItemSpacing = 2, Orientation = Telerik.XamarinForms.Common.Orientation.Vertical, SpanCount = 2, ItemLength = 190 };
		}

		void backClicked_Tapped(object sender, EventArgs e)
		{
			this.drawer.IsOpen = !drawer.IsOpen;
		}

		void drawerList_SelectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
			{
				switch (e.NewItems[0].ToString())
				{
					case "Sandwitch": vm.Load("Sandwitch"); break;
					case "Desserts": vm.Load("Desserts"); break;
					case "Paleo": vm.Load("Paleo"); break;
					case "Cocktails": vm.Load("Cocktails"); break;
					default: vm.Load("Breakfast"); break;
				}
				this.drawer.IsOpen = false;
			}
		}

		void item_SelectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
			{
				var group = "";
				if ((((RadListView)sender).SelectedItem) != null)
				{
					group = ((Recipe)(((RadListView)sender).SelectedItem)).Group;
					Debug.WriteLine(((Recipe)(((RadListView)sender).SelectedItem)).Group);
				}
				Navigation.PushAsync(new ProductDetail(group));
			}
		}
	}
}
