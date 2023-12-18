﻿using NUnit.Framework;
using UITest.Appium;
using UITest.Core;

namespace Microsoft.Maui.AppiumTests.Issues
{
	public class CarouselViewSetOrientation : _IssuesUITest
	{
		public const string HTML = "HTML";

		public CarouselViewSetOrientation(TestDevice device)
			: base(device)
		{
		}

		public override string Issue => "[Bug] CarouselView content disappears after 2 rotations if TextType=Html is used";

		// Issue12193 (src\ControlGallery\src\Issues.Shared\Issue12193.cs
		[Test]
		public async Task RotatingCarouselViewHTMLShouldNotDisappear()
		{
			this.IgnoreIfPlatforms(new TestDevice[] { TestDevice.Mac, TestDevice.Windows });

			int delay = 3000;

			App.SetOrientationPortrait();
			await Task.Delay(delay);

			App.SetOrientationLandscape();
			await Task.Delay(delay);

			App.SetOrientationPortrait();
			await Task.Delay(delay);

			App.SetOrientationLandscape();
			await Task.Delay(delay);

			App.SetOrientationPortrait();
			await Task.Delay(delay);

			App.WaitForElement(HTML);
		}
	}
}