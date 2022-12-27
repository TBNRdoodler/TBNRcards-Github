using BepInEx;
using UnboundLib;
using UnboundLib.Cards;
using TBNRcards.Cards;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;
using UnityEngine;
using ClassesManagerReborn;
using TBNRcards.Cards.Legionary;

namespace TBNRcards
{
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("root.classes.manager.reborn", BepInDependency.DependencyFlags.HardDependency)]
    [BepInPlugin(ModId, ModName, Version)]
    [BepInProcess("Rounds.exe")]
    public class TBNRcards : BaseUnityPlugin
    {
        private const string ModId = "com.TBNRdoodler.rounds.TBNRcards";
        private const string ModName = "TBNRcards";
        public const string Version = "3.2.0"; // What version are we on (major.minor.patch)?
        public const string ModInitials = "TBNRC";
        public static TBNRcards instance { get; private set; }

        void Awake()
        {
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }
        void Start()
        {
            //CustomCard.BuildCard<Beelzebufo>();
            CustomCard.BuildCard<Fwog>((card) => Fwog.Card = card);
            CustomCard.BuildCard<Thickness>((card) => Thickness.Card = card);
            CustomCard.BuildCard<Shuriken>((card) => Shuriken.Card = card);
            CustomCard.BuildCard<ShoulderCannon>((card) => ShoulderCannon.Card = card);
            CustomCard.BuildCard<FabricatedSniperRifle>((card) => FabricatedSniperRifle.Card = card);
            CustomCard.BuildCard<AdvancedSniperBullets>((card) => AdvancedSniperBullets.Card = card);
            CustomCard.BuildCard<PumpActionShotgun>((card) => PumpActionShotgun.Card = card);
            CustomCard.BuildCard<ToughenedHide>((card) => ToughenedHide.Card = card);
            
            //Block Class
            CustomCard.BuildCard<Legionary>((card) => Legionary.Card = card);
            CustomCard.BuildCard<FasterParrying>((card) => FasterParrying.Card = card);
            CustomCard.BuildCard<IronReinforcements>((card) => IronReinforcements.Card = card);
            CustomCard.BuildCard<AggressiveBlocking>((card) => AggressiveBlocking.Card = card);
            CustomCard.BuildCard<Buckler>((card) => Buckler.Card = card);
            CustomCard.BuildCard<SlightWeightReduction>((card) => SlightWeightReduction.Card = card);
            CustomCard.BuildCard<LargeWeightReduction>((card) => LargeWeightReduction.Card = card);
            CustomCard.BuildCard<RomanAthleticism>((card) => RomanAthleticism.Card = card);
            CustomCard.BuildCard<Scutum>((card) => Scutum.Card = card);
            CustomCard.BuildCard<WeakShieldReinforcements>((card) => WeakShieldReinforcements.Card = card);
            CustomCard.BuildCard<StrongShieldReinforcements>((card) =>StrongShieldReinforcements.Card = card);
            CustomCard.BuildCard<RomanFortitude>((card) => RomanFortitude.Card = card);
        }
    }
}
