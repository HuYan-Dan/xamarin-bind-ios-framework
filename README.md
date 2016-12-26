# Xamarin Project with iOS Framework

## Download
Get the latest [Dynamsoft SDK package for iOS][0] - **DynamsoftBarcodeReader.framework**.

## What's included?
* library: convert **DynamsoftBarcodeReader.framework** to a Xamarin.iOS Bindings Library.
* app: a Xamarin iOS project for reading barcode.

## How to Run?
1. Use [sharpie][2] to generate **ApiDefinition.cs** on **macOS**.
  
    ```
    sharpie -tlm-do-not-submit bind -framework ~/Desktop/DynamsoftBarcodeReader.framework -sdk iphoneos10.2
    ```

2. Open library project with **Visual Studio 2015**.
3. Rename **DynamsoftBarcodeReader.framework\DynamsoftBarcodeReader** to **DynamsoftBarcodeReader.framework\DynamsoftBarcodeReader.a**.
4. Drag **DynamsoftBarcodeReader.framework\DynamsoftBarcodeReader.a** to **Visual Studio 2015** to generate **DynamsoftBarcodeReader.linkwith.cs**.

    ![xamarin ios framework](http://www.codepool.biz/wp-content/uploads/2016/12/xamarin-ios-bind-dbr.PNG)

5. Edit **DynamsoftBarcodeReader.linkwith.cs** to add dependent library:

    ```CSharp
    using System;
    using ObjCRuntime;

    [assembly: LinkWith ("DynamsoftBarcodeReader.a", LinkTarget.ArmV7 | LinkTarget.Simulator, ForceLoad = true, LinkerFlags = "-lc++.1")]

    ```

6. Build the library project to generate **DBRiOS.dll**.
7. Open the iOS project and add the reference in **Visual Studio 2015**.
8. Build the iOS project and run the app on your device or simulator.

    ![xamarin ios UI design](http://www.codepool.biz/wp-content/uploads/2016/12/xamarin-ios-barcode-readerPNG.PNG)

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
* [ObjCRuntime.LinkWithAttribute Class][3]
* [Binding Objective-C Libraries][4]
* [Binding Types Reference Guide][5]

[0]:http://www.dynamsoft.com/Downloads/Dynamic-Barcode-Reader-Download.aspx
[1]:https://developer.xamarin.com/guides/ios/advanced_topics/binding_objective-c/walkthrough/
[2]:https://developer.xamarin.com/guides/cross-platform/macios/binding/objective-sharpie/getting-started/
[3]:https://developer.xamarin.com/api/type/ObjCRuntime.LinkWithAttribute/
[4]:https://developer.xamarin.com/guides/cross-platform/macios/binding/objective-c-libraries/
[5]:https://developer.xamarin.com/guides/cross-platform/macios/binding/binding-types-reference/