using Sharpen;

namespace android.text.style
{
	[Sharpen.Stub]
	public class RelativeSizeSpan : android.text.style.MetricAffectingSpan, android.text.ParcelableSpan
	{
		private readonly float mProportion;

		[Sharpen.Stub]
		public RelativeSizeSpan(float proportion)
		{
			throw new System.NotImplementedException();
		}

		[Sharpen.Stub]
		public RelativeSizeSpan(android.os.Parcel src)
		{
			throw new System.NotImplementedException();
		}

		[Sharpen.Stub]
		[Sharpen.ImplementsInterface(@"android.text.ParcelableSpan")]
		public virtual int getSpanTypeId()
		{
			throw new System.NotImplementedException();
		}

		[Sharpen.Stub]
		[Sharpen.ImplementsInterface(@"android.os.Parcelable")]
		public virtual int describeContents()
		{
			throw new System.NotImplementedException();
		}

		[Sharpen.Stub]
		[Sharpen.ImplementsInterface(@"android.os.Parcelable")]
		public virtual void writeToParcel(android.os.Parcel dest, int flags)
		{
			throw new System.NotImplementedException();
		}

		[Sharpen.Stub]
		public virtual float getSizeChange()
		{
			throw new System.NotImplementedException();
		}

		[Sharpen.Stub]
		[Sharpen.OverridesMethod(@"android.text.style.CharacterStyle")]
		public override void updateDrawState(android.text.TextPaint ds)
		{
			throw new System.NotImplementedException();
		}

		[Sharpen.Stub]
		[Sharpen.OverridesMethod(@"android.text.style.MetricAffectingSpan")]
		public override void updateMeasureState(android.text.TextPaint ds)
		{
			throw new System.NotImplementedException();
		}
	}
}
