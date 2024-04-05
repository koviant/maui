using NUnit.Framework;
using UITest.Appium;
using UITest.Core;

namespace Microsoft.Maui.AppiumTests
{
	public class CollectionViewItemsSourceTypesUITests : _IssuesUITest
	{
		public CollectionViewItemsSourceTypesUITests(TestDevice device)
			: base(device)
		{
		}

		public override string Issue => "CollectionView ItemsSource Types";

		// CollectionViewItemsSourceTypesDisplayAndDontCrash (src\Compatibility\ControlGallery\src\Issues.Shared\CollectionViewItemsSourceTypes.cs)
		[Test]
		[IgnoreOnIOS("This test is failing, requires research.")]
		[IgnoreOnMac("This test is failing, requires research.")]
		[IgnoreOnWindows]
		public void CollectionViewItemsSourceTypesDisplayAndDontCrash()
		{
			App.WaitForNoElement("900");
		}
	}
}