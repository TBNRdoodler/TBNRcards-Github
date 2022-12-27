using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;
using ClassesManagerReborn;
using RarityLib.Utils;

namespace TBNRcards.Cards.Legionary
{
    public class LegionaryClass : ClassHandler
    {
        internal static string name = "Legionary";
        internal static string subname1 = "Legionary \n Buckler";
        internal static string subname2 = "Legionary \n Scutum";

        public override System.Collections.IEnumerator Init()
        {
            UnityEngine.Debug.Log("Regestering: " + name);

            while (!(Legionary.Card && FasterParrying.Card && IronReinforcements.Card && AggressiveBlocking.Card && Buckler.Card && SlightWeightReduction.Card && LargeWeightReduction.Card && Scutum.Card && WeakShieldReinforcements.Card && StrongShieldReinforcements.Card)) yield return null;
            //Legionary
            ClassesRegistry.Register(Legionary.Card, CardType.Entry);
            ClassesRegistry.Register(FasterParrying.Card, CardType.Card, Legionary.Card);
            ClassesRegistry.Register(IronReinforcements.Card, CardType.Card, Legionary.Card);
            ClassesRegistry.Register(AggressiveBlocking.Card, CardType.Card, Legionary.Card, 2);
            //Buckler
            ClassesRegistry.Register(Buckler.Card, CardType.SubClass, new CardInfo[] {FasterParrying.Card, IronReinforcements.Card});
            ClassesRegistry.Register(SlightWeightReduction.Card, CardType.Card, Buckler.Card, 3);
            ClassesRegistry.Register(LargeWeightReduction.Card, CardType.Card, Buckler.Card, 2);
            ClassesRegistry.Register(RomanAthleticism.Card, CardType.Card, Buckler.Card, 2);
            //Scutum
            ClassesRegistry.Register(Scutum.Card, CardType.SubClass, new CardInfo[] { FasterParrying.Card, IronReinforcements.Card });
            ClassesRegistry.Register(WeakShieldReinforcements.Card, CardType.Card, Scutum.Card, 3);
            ClassesRegistry.Register(StrongShieldReinforcements.Card, CardType.Card, Scutum.Card, 2);
            ClassesRegistry.Register(RomanAthleticism.Card, CardType.Card, Scutum.Card, 2);
        }
    }
}