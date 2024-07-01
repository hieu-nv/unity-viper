using AppKit.DemoApp.Views;
using Unity.AppUI.MVVM;
using Unity.AppUI.UI;
using UnityEngine;

namespace AppKit.DemoApp
{
  public class DemoApp : App
  {
    public DemoApp(MainPage mainPage)
    {
      var panel = new Panel();
      panel.Add(mainPage);
      this.mainPage = panel;
    }

    public override void Shutdown()
    {
      Debug.Log(">>> Shutdown!");
      base.Shutdown();
      Debug.Log("<<< Shutdown!");
    }
  }
}
