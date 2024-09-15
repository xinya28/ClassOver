using ClassIsland.Core.Abstractions.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClassIsland.Core.Attributes;
using MaterialDesignThemes.Wpf;
using Plugin000;

namespace Plugin000.Views.SettingsPages;

/// <summary>
/// ExampleSettingsPage.xaml 的交互逻辑
/// </summary>
[SettingsPageInfo("000.ClassOverSettingsPage", "淦!下课! 的设置页面", PackIconKind.CogOutline, PackIconKind.Cog)]
public partial class ClassOverSettingsPage : SettingsPageBase
{
    public Plugin Plugin { get; }

    public ClassOverSettingsPage(Plugin plugin)
    {
        Plugin = plugin;
        InitializeComponent();
        DataContext = this;
    }
}