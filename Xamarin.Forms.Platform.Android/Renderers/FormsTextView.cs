using System;
using Android.Content;
using Android.Graphics;
using Android.Runtime;
using Android.Util;
using Android.Widget;

namespace Xamarin.Forms.Platform.Android
{
	public class FormsTextView : TextView
	{
		bool _skip;

		public FormsTextView(Context context) : base(context)
		{
		}

		public FormsTextView(Context context, IAttributeSet attrs) : base(context, attrs)
		{
		}

		public FormsTextView(Context context, IAttributeSet attrs, int defStyle) : base(context, attrs, defStyle)
		{
		}

		protected FormsTextView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		protected override void OnLayout(bool changed, int left, int top, int right, int bottom)
		{
			base.OnLayout(changed, left, top, right, bottom);
		}

		protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
		{
			base.OnMeasure(widthMeasureSpec, heightMeasureSpec);
		}

		protected override void OnDraw(Canvas canvas)
		{
			base.OnDraw(canvas);
		}

		public override void Invalidate()
		{
			if (!_skip)
				base.Invalidate();
			_skip = false;
		}

		public void SkipNextInvalidate()
		{
			_skip = true;
		}
	}
}