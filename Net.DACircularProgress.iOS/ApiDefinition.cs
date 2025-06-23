using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using UIKit;
using CoreGraphics;

namespace Net.DACircularProgress.iOS
{
	// @interface DACircularProgressView : UIView
	[BaseType (typeof(UIView))]
	interface DACircularProgressView
	{
		// -(instancetype)initWithFrame:(CGRect)frame;
		[Export ("initWithFrame:")]
		NativeHandle Constructor (CGRect frame);

		// @property (nonatomic, strong) UIColor * trackTintColor __attribute__((annotate("ui_appearance_selector")));
		[Export ("trackTintColor", ArgumentSemantic.Strong)]
		UIColor TrackTintColor { get; set; }

		// @property (nonatomic, strong) UIColor * progressTintColor __attribute__((annotate("ui_appearance_selector")));
		[Export ("progressTintColor", ArgumentSemantic.Strong)]
		UIColor ProgressTintColor { get; set; }

		// @property (nonatomic, strong) UIColor * innerTintColor __attribute__((annotate("ui_appearance_selector")));
		[Export ("innerTintColor", ArgumentSemantic.Strong)]
		UIColor InnerTintColor { get; set; }

		// @property (nonatomic) NSInteger roundedCorners __attribute__((annotate("ui_appearance_selector")));
		[Export ("roundedCorners")]
		nint RoundedCorners { get; set; }

		// @property (nonatomic) CGFloat thicknessRatio __attribute__((annotate("ui_appearance_selector")));
		[Export ("thicknessRatio")]
		nfloat ThicknessRatio { get; set; }

		// @property (nonatomic) NSInteger clockwiseProgress __attribute__((annotate("ui_appearance_selector")));
		[Export ("clockwiseProgress")]
		nint ClockwiseProgress { get; set; }

		// @property (nonatomic) CGFloat progress;
		[Export ("progress")]
		nfloat Progress { get; set; }

		// @property (nonatomic) CGFloat indeterminateDuration __attribute__((annotate("ui_appearance_selector")));
		[Export ("indeterminateDuration")]
		nfloat IndeterminateDuration { get; set; }

		// @property (nonatomic) NSInteger indeterminate __attribute__((annotate("ui_appearance_selector")));
		[Export ("indeterminate")]
		nint Indeterminate { get; set; }

		// -(void)setProgress:(CGFloat)progress animated:(BOOL)animated;
		[Export ("setProgress:animated:")]
		void SetProgress (nfloat progress, bool animated);

		// -(void)setProgress:(CGFloat)progress animated:(BOOL)animated initialDelay:(CFTimeInterval)initialDelay;
		[Export ("setProgress:animated:initialDelay:")]
		void SetProgress (nfloat progress, bool animated, double initialDelay);

		// -(void)setProgress:(CGFloat)progress animated:(BOOL)animated initialDelay:(CFTimeInterval)initialDelay withDuration:(CFTimeInterval)duration;
		[Export ("setProgress:animated:initialDelay:withDuration:")]
		void SetProgress (nfloat progress, bool animated, double initialDelay, double duration);
	}

	// @interface DALabeledCircularProgressView : DACircularProgressView
	[BaseType (typeof(DACircularProgressView))]
	interface DALabeledCircularProgressView
	{
		// @property (nonatomic, strong) UILabel * progressLabel;
		[Export ("progressLabel", ArgumentSemantic.Strong)]
		UILabel ProgressLabel { get; set; }
	}
}
