using System;
using UIKit;

namespace Bookworm.iOS.ViewControllers
{
	partial class BookDetailsViewController : UIViewController
	{
		public string Image { get; set; }

		public string BookName { get; set; }

		public BookDetailsViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);

			imgBook.Image = UIImage.FromBundle(Image);
			lblBookName.Text = BookName;
		}

		public override void ViewDidLayoutSubviews()
		{
			base.ViewDidLayoutSubviews();

			lblBookName.SizeToFit();
		}
	}
}
