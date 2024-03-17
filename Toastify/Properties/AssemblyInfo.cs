using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using log4net.Config;

[assembly: ComVisible(false)]
[assembly: InternalsVisibleTo("Toastify.Tests")]

[assembly: ThemeInfo(ResourceDictionaryLocation.None, ResourceDictionaryLocation.SourceAssembly)]
[assembly: XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]

