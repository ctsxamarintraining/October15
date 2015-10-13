
using System;

using Foundation;
using UIKit;

namespace partialDemo.iOS
{
	public partial class FirstView : UIViewController
	{
		public FirstView () : base ("FirstView", null)
		{
			
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			btnSave.TouchUpInside += (object sender, EventArgs e) => {
				btnSave.BackgroundColor = UIColor.Green;
			};
			// Perform any additional setup after loading the view, typically from a nib.
		}
	}
}

