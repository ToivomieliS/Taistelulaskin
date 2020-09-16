using System;
using System.Collections.Generic;
using System.Text;
using Caliburn.Micro;
using Taistelulaskin.Views;

namespace Taistelulaskin.ViewModels
{
    class LandCalculatorViewModel : Screen
    {
        public int RedRebel { get; set; }
        public int RedLightBrigade { get; set; }
        public int RedStandardBrigade { get; set; }
        public int RedEliteBrigade { get; set; }
        public int RedLightDivision { get; set; }
        public int RedStandardDivision { get; set; }
        public int RedEliteDivision { get; set; }
        public int RedLightFighter { get; set; }
        public int RedFighter { get; set; }
        public int RedLightBomber { get; set; }
        public int RedBomber { get; set; }
        public int RedDestroyer { get; set; }
        public int RedSubmarine { get; set; }
        public int RedCruiser { get; set; }
        public int RedCarrier { get; set; }
        public int RedSum { get; set; }
        public int BlueRebel { get; set; }
        public int BlueLightBrigade { get; set; }
        public int BlueStandardBrigade { get; set; }
        public int BlueEliteBrigade { get; set; }
        public int BlueLightDivision { get; set; }
        public int BlueStandardDivision { get; set; }
        public int BlueEliteDivision { get; set; }
        public int BlueLightFighter { get; set; }
        public int BlueFighter { get; set; }
        public int BlueLightBomber { get; set; }
        public int BlueBomber { get; set; }
        public int MyProperty { get; set; }
        public int BlueDestroyer { get; set; }
        public int BlueSubmarine { get; set; }
        public int BlueCruiser { get; set; }
        public int BlueCarrier { get; set; }
        public int BlueSum { get; set; }
        public int RedSumForDie { get; set; }
        public int BlueSumForDie { get; set; }
        public int DieRoll { get; set; }

        public int RedSide { get; set; }
        public int BlueSide { get; set; }

        public LandCalculatorViewModel() //Tämä olisi konstruktori
        {
            RedSide += RedRebel;
            NotifyOfPropertyChange(()=>RedSide);
            BlueSide += BlueRebel;
           /* this.RedSide.Add(RedLightBrigade);
            this.RedSide.Add(RedStandardBrigade);
            this.RedSide.Add(RedEliteBrigade);
            this.RedSide.Add(RedLightDivision);
            this.RedSide.Add(RedStandardDivision);
            this.RedSide.Add(RedEliteDivision);
            this.RedSide.Add(RedLightFighter);
            this.RedSide.Add(RedFighter);
            this.RedSide.Add(RedLightBomber);
            this.RedSide.Add(RedBomber);
            this.RedSide.Add(RedSubmarine);
            this.RedSide.Add(RedDestroyer);
            this.RedSide.Add(RedCruiser);
            this.RedSide.Add(RedCarrier);
            this.BlueSide.Add(BlueRebel);
            this.BlueSide.Add(BlueLightBrigade);
            this.BlueSide.Add(BlueStandardBrigade);
            this.BlueSide.Add(BlueEliteBrigade);
            this.BlueSide.Add(BlueLightDivision);
            this.BlueSide.Add(BlueStandardDivision);
            this.BlueSide.Add(BlueEliteDivision);
            this.BlueSide.Add(BlueLightFighter);
            this.BlueSide.Add(BlueFighter);
            this.BlueSide.Add(BlueLightBomber);
            this.BlueSide.Add(BlueBomber);
            this.BlueSide.Add(BlueSubmarine);
            this.BlueSide.Add(BlueDestroyer);
            this.BlueSide.Add(BlueCruiser);
            this.BlueSide.Add(BlueCarrier);*/

        }


        public void GenerateAResult() 
        {
            int TotalForDie = RedSumForDie + BlueSumForDie;
            Random TheDice = new Random();
            DieRoll = TheDice.Next(0,TotalForDie+1);
            NotifyOfPropertyChange(()=>DieRoll);
        }




    }
}
