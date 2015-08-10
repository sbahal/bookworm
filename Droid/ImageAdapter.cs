﻿using Android.Widget;
using Android.Content;
using Android.Views;
using System.Collections.Generic;

namespace Bookworm.Droid
{
	public class ImageAdapter : BaseAdapter
	{
		private readonly Context context;
		private readonly List<Book> books = new List<Book>();

		public ImageAdapter(Context c, List<Book> books)
		{
			context = c;
			this.books = books;
		}

		public override int Count {
			get { return books.Count; }
		}

		public override Java.Lang.Object GetItem(int position)
		{
			return null;
		}

		public override long GetItemId(int position)
		{
			return 0;
		}

		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			View customView;
			if (convertView == null) {
				var inflater = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);
				customView = inflater.Inflate(Resource.Layout.BookCell, null);

				var selectedBook = books[position];

				var imageView = customView.FindViewById<ImageView>(Resource.Id.imageView1);
				imageView.SetPadding(8, 8, 8, 8);
				imageView.SetImageResource((int)typeof(Resource.Drawable).GetField(selectedBook.Image).GetValue(null));

				var textView = customView.FindViewById<TextView>(Resource.Id.textView1);
				textView.Text = selectedBook.Name;
			} else {
				customView = (View)convertView;
			}

			return customView;
		}
	}
}

