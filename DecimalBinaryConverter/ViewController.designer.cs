// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace DecimalBinaryConverter
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField inputLabel { get; set; }

		[Outlet]
		AppKit.NSTextField outputLabel { get; set; }

		[Action ("convertButton:")]
		partial void convertButton (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (inputLabel != null) {
				inputLabel.Dispose ();
				inputLabel = null;
			}

			if (outputLabel != null) {
				outputLabel.Dispose ();
				outputLabel = null;
			}
		}
	}
}
