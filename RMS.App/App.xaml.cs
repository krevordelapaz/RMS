using System;
using System.Windows;

namespace RMS.App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private bool windowMinimized;
        private DateTime? minimizedTime;
        private Bootstrapper bootstrapper;

        protected override void OnStartup(StartupEventArgs e)
        {
            //TODO: For improvement
            //var numeric = (ResourceDictionary)LoadComponent(new Uri("/Theme_001;component/Themes/Values/Numerics.xaml", UriKind.Relative));
            //var light = (ResourceDictionary)LoadComponent(new Uri("/Theme_001;component/Themes/ColorSchemes/Light.xaml", UriKind.Relative));
            //var icons = (ResourceDictionary)LoadComponent(new Uri("/Theme_001;component/Icons/Icons.xaml", UriKind.Relative));
            //var buttons = (ResourceDictionary)LoadComponent(new Uri("/Theme_001;component/Themes/Styles/Buttons.xaml", UriKind.Relative));
            //var contextView = (ResourceDictionary)LoadComponent(new Uri("/Theme_001;component/Themes/Styles/ContextMenu.xaml", UriKind.Relative));
            //var datePicker = (ResourceDictionary)LoadComponent(new Uri("/Theme_001;component/Themes/Styles/DatePicker.xaml", UriKind.Relative));
            //var form = (ResourceDictionary)LoadComponent(new Uri("/Theme_001;component/Themes/Styles/Form.xaml", UriKind.Relative));
            //var menu = (ResourceDictionary)LoadComponent(new Uri("/Theme_001;component/Themes/Styles/Menu.xaml", UriKind.Relative));
            //var notification = (ResourceDictionary)Application.LoadComponent(new Uri("/Theme_001;component/Themes/Styles/Notifications.xaml", UriKind.Relative));
            //var options = (ResourceDictionary)Application.LoadComponent(new Uri("/Theme_001;component/Themes/Styles/Options.xaml", UriKind.Relative));
            //var progress = (ResourceDictionary)Application.LoadComponent(new Uri("/Theme_001;component/Themes/Styles/ProgressBar.xaml", UriKind.Relative));
            //var scroll = (ResourceDictionary)Application.LoadComponent(new Uri("/Theme_001;component/Themes/Styles/Scroll.xaml", UriKind.Relative));
            //var slider = (ResourceDictionary)Application.LoadComponent(new Uri("/Theme_001;component/Themes/Styles/Slider.xaml", UriKind.Relative));
            //var tab = (ResourceDictionary)Application.LoadComponent(new Uri("/Theme_001;component/Themes/Styles/TabControl.xaml", UriKind.Relative));
            //var texts = (ResourceDictionary)Application.LoadComponent(new Uri("/Theme_001;component/Themes/Styles/Texts.xaml", UriKind.Relative));
            //var window = (ResourceDictionary)Application.LoadComponent(new Uri("/Theme_001;component/Themes/Styles/Window.xaml", UriKind.Relative));

            //Application.Current.Resources.MergedDictionaries.Add(numeric);
            //Application.Current.Resources.MergedDictionaries.Add(light);
            //Application.Current.Resources.MergedDictionaries.Add(icons);
            //Application.Current.Resources.MergedDictionaries.Add(buttons);
            //Application.Current.Resources.MergedDictionaries.Add(contextView);
            //Application.Current.Resources.MergedDictionaries.Add(datePicker);
            //Application.Current.Resources.MergedDictionaries.Add(form);
            //Application.Current.Resources.MergedDictionaries.Add(menu);
            //Application.Current.Resources.MergedDictionaries.Add(notification);
            //Application.Current.Resources.MergedDictionaries.Add(options);
            //Application.Current.Resources.MergedDictionaries.Add(progress);
            //Application.Current.Resources.MergedDictionaries.Add(scroll);
            //Application.Current.Resources.MergedDictionaries.Add(slider);
            //Application.Current.Resources.MergedDictionaries.Add(tab);
            //Application.Current.Resources.MergedDictionaries.Add(texts);
            //Application.Current.Resources.MergedDictionaries.Add(window);

            base.OnStartup(e);

            bootstrapper = new Bootstrapper();
            bootstrapper.Run();

            minimizedTime = null;
            windowMinimized = false;
        }

        protected override void OnActivated(EventArgs e)
        {
            minimizedTime = null;
            windowMinimized = false;

            base.OnActivated(e);
        }

        protected override void OnDeactivated(EventArgs e)
        {
            minimizedTime = DateTime.Now;
            windowMinimized = true;

            base.OnDeactivated(e);
        }
    }
}
