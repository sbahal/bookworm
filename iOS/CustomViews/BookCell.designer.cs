// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Bookworm.iOS.CustomViews
{
	[Register ("BookCell")]
	partial class BookCell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView imgBook { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (imgBook != null) {
				imgBook.Dispose ();
				imgBook = null;
			}
		}
	}
}
