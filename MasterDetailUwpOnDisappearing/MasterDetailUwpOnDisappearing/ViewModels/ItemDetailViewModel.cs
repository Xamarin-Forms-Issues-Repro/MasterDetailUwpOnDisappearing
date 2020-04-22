using System;

using MasterDetailUwpOnDisappearing.Models;

namespace MasterDetailUwpOnDisappearing.ViewModels
{
	public class ItemDetailViewModel : BaseViewModel
	{
		public Item Item { get; set; }
		public ItemDetailViewModel(Item item = null)
		{
			Title = item?.Text;
			Item = item;
		}
	}
}
