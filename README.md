# Xamarin Project with iOS Framework

## Download
Get the latest [Dynamsoft SDK package for iOS][0] - **DynamsoftBarcodeReader.framework**.

## What's included?
* library: convert **DynamsoftBarcodeReader.framework** to a Xamarin.iOS Bindings Library.
* app: a Xamarin iOS project for reading barcode.

## How to Run?
1. Use [sharpie][2] to generate **ApiDefinition.cs**.
  
    ```
    sharpie -tlm-do-not-submit bind -framework ~/Desktop/DynamsoftBarcodeReader.framework -sdk iphoneos10.2
    ```

2. Open library project to add **DynamsoftBarcodeReader.framework**.
3. Build the library project to generate **DBRiOS.dll** in **Mac Visual Studio**.

    ![xamarin ios framework](http://www.codepool.biz/wp-content/uploads/2016/12/xamarin-ios-bindings-library.png)

4. Open the iOS project and add the reference in **Windows Visual Studio 2015**.
5. Build the iOS project and run the app on your iPhone or iPad.

    ![xamarin ios UI design](http://www.codepool.biz/wp-content/uploads/2016/12/xamarin-ios-design.PNG)

## Code Snippet
```CSharp
using DBRiOS;

partial void Button_read_TouchUpInside(UIButton sender)
        {
            BarcodeReader barcodeReader = new BarcodeReader("");
            ReadResult result = barcodeReader.ReadSingle(qrimage.Image, Barcode.QR_CODE);
            Barcode barcode = result.Barcodes[0];
            text.Text = barcode.DisplayValue;
        }
```

## Reference
* [Walkthrough: Binding an iOS Objective-C Library][1]

[0]:http://www.dynamsoft.com/Downloads/Dynamic-Barcode-Reader-Download.aspx
[1]:https://developer.xamarin.com/guides/ios/advanced_topics/binding_objective-c/walkthrough/
[2]:https://developer.xamarin.com/guides/cross-platform/macios/binding/objective-sharpie/getting-started/