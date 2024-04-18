﻿using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Hosting;

namespace Maui.Controls.Sample.Droid
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();

			builder
				.UseSharedMauiApp()
				.UseMauiMaps();

			return builder.Build();
		}
	}
}
