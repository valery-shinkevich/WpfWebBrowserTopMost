using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace WpfBrowserTopMost.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (WpfBrowserTopMost.Properties.Resources.resourceMan == null)
          WpfBrowserTopMost.Properties.Resources.resourceMan = new ResourceManager("WpfBrowserTopMost.Properties.Resources", typeof (WpfBrowserTopMost.Properties.Resources).Assembly);
        return WpfBrowserTopMost.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return WpfBrowserTopMost.Properties.Resources.resourceCulture;
      }
      set
      {
        WpfBrowserTopMost.Properties.Resources.resourceCulture = value;
      }
    }

    internal Resources()
    {
    }
  }
}
