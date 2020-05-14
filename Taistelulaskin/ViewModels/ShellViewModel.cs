using System;
using System.Collections.Generic;
using System.Text;
using Caliburn.Micro;

namespace Taistelulaskin.ViewModels
{
    public class ShellViewModel : Conductor <object>
    {

        public void ShowGround()
        {
            ActivateItemAsync(new LandCalculatorViewModel(), System.Threading.CancellationToken.None);
        }

        public void ShowAir()
        {
            ActivateItemAsync(new AirCalculatorViewModel(), System.Threading.CancellationToken.None);
        }

        public void ShowSea()
        {
            ActivateItemAsync(new SeaCalculatorViewModel(), System.Threading.CancellationToken.None);
        }

        public void ShowQuit()
        {
            ActivateItemAsync(new BlankViewModel(), System.Threading.CancellationToken.None);
        }
    }
}
