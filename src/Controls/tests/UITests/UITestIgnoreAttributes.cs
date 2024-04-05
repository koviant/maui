using NUnit.Framework;

namespace Microsoft.Maui.AppiumTests
{
	public class IgnoreOnAllPlatforms : IgnoreAttribute
	{
		public IgnoreOnAllPlatforms() : base(nameof(IgnoreOnAndroid))
		{
		}
		public IgnoreOnAllPlatforms(string reason) : base(reason)
		{
		}
	}

#if ANDROID
	public class IgnoreOnAndroid : IgnoreAttribute
	{
		public IgnoreOnAndroid() : base(nameof(IgnoreOnAndroid))
		{
		}
		public IgnoreOnAndroid(string reason) : base(reason)
		{
		}
	}
#else
	public class IgnoreOnAndroid : CategoryAttribute
	{
		public IgnoreOnAndroid() : base(nameof(IgnoreOnAndroid))
		{
		}
		public IgnoreOnAndroid(string name) : base(name)
		{
		}
	}
#endif

#if IOS
	public class IgnoreOnIOS : IgnoreAttribute
	{
		public IgnoreOnIOS() : base(nameof(IgnoreOnIOS))
		{
		}
		public IgnoreOnIOS(string reason) : base(reason)
		{
		}
	}
#else
	public class IgnoreOnIOS : CategoryAttribute
	{
		public IgnoreOnIOS() : base(nameof(IgnoreOnIOS))
		{
		}
		public IgnoreOnIOS(string name) : base(name)
		{
		}
	}
#endif

#if MACCATALYST
	public class IgnoreOnMac : IgnoreAttribute
	{
		public IgnoreOnMac() : base(nameof(IgnoreOnMac))
		{
		}
		public IgnoreOnMac(string reason) : base(reason)
		{
		}
	}
#else
	public class IgnoreOnMac : CategoryAttribute
	{
		public IgnoreOnMac() : base(nameof(IgnoreOnMac))
		{
		}
		public IgnoreOnMac(string name) : base(name)
		{
		}
	}
#endif

#if WINDOWS
	public class IgnoreOnWindows : IgnoreAttribute
	{
		public IgnoreOnWindows() : base(nameof(IgnoreOnWindows))
		{
		}
		public IgnoreOnWindows(string reason) : base(reason)
		{
		}
	}
#else
	public class IgnoreOnWindows : CategoryAttribute
	{
		public IgnoreOnWindows() : base(nameof(IgnoreOnWindows))
		{
		}
		public IgnoreOnWindows(string name) : base(name)
		{
		}
	}
#endif
}