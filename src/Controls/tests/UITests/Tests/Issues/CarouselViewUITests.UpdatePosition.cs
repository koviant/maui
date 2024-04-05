using NUnit.Framework;
using UITest.Appium;
using UITest.Core;

namespace Microsoft.Maui.AppiumTests.Issues
{
	public class CarouselViewUpdatePosition : _IssuesUITest
	{
		public CarouselViewUpdatePosition(TestDevice device)
			: base(device)
		{
		}

		public override string Issue => "[Bug] CarouselView Position property fails to update visual while control isn't visible";

		// Issue11224 (src\ControlGallery\src\Issues.Shared\Issue11224.cs
		[Test]
		[FailsOnIOS("Android specific Test")]
		[FailsOnMac("Android specific Test")]
		[FailsOnWindows("Android specific Test")]
		public void CarouselViewPositionFromVisibilityChangeTest()
		{
			App.WaitForElement("AppearButton");
			App.Click("AppearButton");
			App.WaitForNoElement("Item 4");
			App.Screenshot("Success");
		}
	}
}