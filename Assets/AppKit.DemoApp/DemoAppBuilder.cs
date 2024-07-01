using AppKit.DemoApp.Views;
using Unity.AppUI.MVVM;
using UnityEngine;

namespace AppKit.DemoApp
{
  public class DemoAppBuilder : UIToolkitAppBuilder<DemoApp>
  {

    protected override void OnConfiguringApp(AppBuilder builder)
    {
      Debug.Log(">>> test!");
      base.OnConfiguringApp(builder);
      Debug.Log("<<< test!");
      builder.services.AddSingleton<MainPage>();
    }
  }
}
