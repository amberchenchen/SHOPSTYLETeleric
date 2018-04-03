using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SHOPSTYLE
{
	public class ProductDetailViewModel
	{
		public List<Image> Images { get; set; }

		public ProductDetailViewModel()
		{
			this.Images = new List<Image>()
			{
				new Image() { Source = "backpack.png"},
				new Image() { Source = "backpack.png"},
				new Image() { Source = "backpack.png"},
			};
		}
	}
}
