using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace DBRiOS {
	
	[Static]
	partial interface Constants
	{
		// extern double DynamsoftBarcodeReaderVersionNumber;
		[Field ("DynamsoftBarcodeReaderVersionNumber", "__Internal")]
		double DynamsoftBarcodeReaderVersionNumber { get; }

		// extern const unsigned char [] DynamsoftBarcodeReaderVersionString;
		[Field ("DynamsoftBarcodeReaderVersionString", "__Internal")]
		NSString DynamsoftBarcodeReaderVersionString { get; }
	}

	// @interface Barcode : NSObject
	[BaseType (typeof(NSObject))]
	interface Barcode
	{
		// @property (nonatomic) long format;
		[Export ("format")]
		nint Format { get; set; }

		// @property (copy, nonatomic) NSString * formatString;
		[Export ("formatString")]
		string FormatString { get; set; }

		// @property (copy, nonatomic) NSString * displayValue;
		[Export ("displayValue")]
		string DisplayValue { get; set; }

		// @property (copy, nonatomic) NSData * rawValue;
		[Export ("rawValue", ArgumentSemantic.Copy)]
		NSData RawValue { get; set; }

		// @property (copy, nonatomic) NSArray * cornerPoints;
		[Export ("cornerPoints", ArgumentSemantic.Copy)]
		NSObject[] CornerPoints { get; set; }

		// @property (nonatomic) CGRect boundingbox;
		[Export ("boundingbox", ArgumentSemantic.Assign)]
		CGRect Boundingbox { get; set; }

		// +(long)OneD;
		[Static]
		[Export ("OneD")]
		nint OneD { get; }

		// +(long)CODE_39;
		[Static]
		[Export ("CODE_39")]
		nint CODE_39 { get; }

		// +(long)CODE_128;
		[Static]
		[Export ("CODE_128")]
		nint CODE_128 { get; }

		// +(long)CODE_93;
		[Static]
		[Export ("CODE_93")]
		nint CODE_93 { get; }

		// +(long)CODABAR;
		[Static]
		[Export ("CODABAR")]
		nint CODABAR { get; }

		// +(long)ITF;
		[Static]
		[Export ("ITF")]
		nint ITF { get; }

		// +(long)EAN_13;
		[Static]
		[Export ("EAN_13")]
		nint EAN_13 { get; }

		// +(long)EAN_8;
		[Static]
		[Export ("EAN_8")]
		nint EAN_8 { get; }

		// +(long)UPC_A;
		[Static]
		[Export ("UPC_A")]
		nint UPC_A { get; }

		// +(long)UPC_E;
		[Static]
		[Export ("UPC_E")]
		nint UPC_E { get; }

		// +(long)INDUSTRIAL_25;
		[Static]
		[Export ("INDUSTRIAL_25")]
		nint INDUSTRIAL_25 { get; }

		// +(long)PDF417;
		[Static]
		[Export ("PDF417")]
		nint PDF417 { get; }

		// +(long)DATAMATRIX;
		[Static]
		[Export ("DATAMATRIX")]
		nint DATAMATRIX { get; }

		// +(long)QR_CODE;
		[Static]
		[Export ("QR_CODE")]
		nint QR_CODE { get; }

		// +(long)UNKNOWN;
		[Static]
		[Export ("UNKNOWN")]
		nint UNKNOWN { get; }
	}

	// @interface ReadResult : NSObject
	[BaseType (typeof(NSObject))]
	interface ReadResult
	{
		// @property (nonatomic) int errorCode;
		[Export ("errorCode")]
		int ErrorCode { get; set; }

		// @property (copy, nonatomic) NSString * errorString;
		[Export ("errorString")]
		string ErrorString { get; set; }

		// @property (nonatomic) NSArray * barcodes;
		[Export ("barcodes", ArgumentSemantic.Assign)]
		Barcode[] Barcodes { get; set; }
	}

	// @interface BarcodeReader : NSObject
	[BaseType (typeof(NSObject))]
	interface BarcodeReader
	{
		// +(int)DBRERROR_OK;
		[Static]
		[Export ("DBRERROR_OK")]
		int DBRERROR_OK { get; }

		// +(int)DBRERROR_UNKNOWN;
		[Static]
		[Export ("DBRERROR_UNKNOWN")]
		int DBRERROR_UNKNOWN { get; }

		// +(int)DBRERROR_NOMEMORY;
		[Static]
		[Export ("DBRERROR_NOMEMORY")]
		int DBRERROR_NOMEMORY { get; }

		// +(int)DBRERROR_NULL_POINTER;
		[Static]
		[Export ("DBRERROR_NULL_POINTER")]
		int DBRERROR_NULL_POINTER { get; }

		// +(int)DBRERROR_LICENSE_INVALID;
		[Static]
		[Export ("DBRERROR_LICENSE_INVALID")]
		int DBRERROR_LICENSE_INVALID { get; }

		// +(int)DBRERROR_LICENSE_EXPIRED;
		[Static]
		[Export ("DBRERROR_LICENSE_EXPIRED")]
		int DBRERROR_LICENSE_EXPIRED { get; }

		// +(int)DBRERROR_BARCODE_FORMAT_INVALID;
		[Static]
		[Export ("DBRERROR_BARCODE_FORMAT_INVALID")]
		int DBRERROR_BARCODE_FORMAT_INVALID { get; }

		// +(int)DBRERROR_PARAMETER_INVALID;
		[Static]
		[Export ("DBRERROR_PARAMETER_INVALID")]
		int DBRERROR_PARAMETER_INVALID { get; }

		// -(id)initWithLicense:(NSString *)license;
		[Export ("initWithLicense:")]
		IntPtr Constructor (string license);

		// -(ReadResult *)readSingle:(UIImage *)image barcodeFormat:(long)format;
		[Export ("readSingle:barcodeFormat:")]
		ReadResult ReadSingle (UIImage image, nint format);

		// -(void)readSingleAsync:(UIImage *)image barcodeFormat:(long)format sender:(id)sender onComplete:(SEL)callback;
		[Export ("readSingleAsync:barcodeFormat:sender:onComplete:")]
		void ReadSingleAsync (UIImage image, nint format, NSObject sender, Selector callback);

		// -(ReadResult *)readSingle:(NSData *)buffer width:(int)width height:(int)height barcodeFormat:(long)format;
		[Export ("readSingle:width:height:barcodeFormat:")]
		ReadResult ReadSingle (NSData buffer, int width, int height, nint format);

		// -(void)readSingleAsync:(NSData *)buffer width:(int)width height:(int)height barcodeFormat:(long)format sender:(id)sender onComplete:(SEL)callback;
		[Export ("readSingleAsync:width:height:barcodeFormat:sender:onComplete:")]
		void ReadSingleAsync (NSData buffer, int width, int height, nint format, NSObject sender, Selector callback);
	}
}
