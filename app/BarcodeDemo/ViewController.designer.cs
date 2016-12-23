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

namespace BarcodeDemo
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton button_read { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView qrimage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel text { get; set; }

        [Action ("Button_read_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Button_read_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton16_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton16_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (button_read != null) {
                button_read.Dispose ();
                button_read = null;
            }

            if (qrimage != null) {
                qrimage.Dispose ();
                qrimage = null;
            }

            if (text != null) {
                text.Dispose ();
                text = null;
            }
        }
    }
}