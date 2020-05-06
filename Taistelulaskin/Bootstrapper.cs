using System;
using System.Collections.Generic;
using System.Text;
using System.Windows
using Caliburn.Micro;
using Taistelulaskin.ViewModels;

namespace Taistelulaskin
{
    public class BootStrapper : BootstrapperBase
    {
        public BootStrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
