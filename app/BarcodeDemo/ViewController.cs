using System;

using UIKit;
using DBRiOS;

namespace BarcodeDemo
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void Button_read_TouchUpInside(UIButton sender)
        {
            BarcodeReader barcodeReader = new BarcodeReader("");
            ReadResult result = barcodeReader.ReadSingle(qrimage.Image, Barcode.QR_CODE);
            Barcode barcode = result.Barcodes[0];
            text.Text = barcode.DisplayValue;
        }

        partial void UIButton16_TouchUpInside(UIButton sender)
        {
            text.Text = "";
        }
    }
}