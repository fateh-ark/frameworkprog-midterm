using Microsoft.Extensions.Logging;
using IUP_BMI_Calculator.Repository;

namespace IUP_BMI_Calculator;


public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		// TODO
		string dbPath = FileAccessHelper.GetLocalFilePath("Rename this.db3");
        builder.Services.AddSingleton<BMIResultRepository>(s => ActivatorUtilities.CreateInstance<BMIResultRepository>(s, dbPath));

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
