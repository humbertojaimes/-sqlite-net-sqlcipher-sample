using Foundation;

namespace People;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp()
	{
        //SQLitePCL.raw.SetProvider(new SQLite3Provider_e_sqlcipher());
        SQLitePCL.Batteries_V2.Init();
        return MauiProgram.CreateMauiApp();
	}
}
