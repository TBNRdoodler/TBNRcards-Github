using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;
using ClassesManagerReborn.Util;
using RarityLib.Utils;

namespace TBNRcards.Cards.Legionary
{
    class LargeWeightReduction : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            block.cdMultiplier = 0.7f;
            statModifiers.movementSpeed = 0.88f;

            UnityEngine.Debug.Log($"[{TBNRcards.ModInitials}][Card] {GetTitle()} has been setup.");
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //player.gameObject.GetOrAddComponent<LargeWeightReductionMono>();

            UnityEngine.Debug.Log($"[{TBNRcards.ModInitials}][Card] {GetTitle()} has been added to player {player.playerID}.");
        }
        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Destroy(player.gameObject.GetOrAddComponent<LargeWeightReductionMono>());

            UnityEngine.Debug.Log($"[{TBNRcards.ModInitials}][Card] {GetTitle()} has been removed from player {player.playerID}.");
        }

        internal static CardInfo Card = null;

        protected override string GetTitle()
        {
            return "Large Weight Reduction";
        }
        protected override string GetDescription()
        {
            return "Greatly decrease the weight of your shield making it even easier to block";
        }
        protected override GameObject GetCardArt()
        {
            return null;
        }
        protected override CardInfo.Rarity GetRarity()
        {
            return CardInfo.Rarity.Rare;
        }
        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Block cooldown",
                    amount = "-30%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Movement speed",
                    amount = "-12%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                }
                /*
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Roman Athleticism",
                    amount = "If you have",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Jumps",
                    amount = "+2",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Jump height",
                    amount = "-25%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                }
                */

            };
        }
        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.DestructiveRed;
        }
        public override void Callback()
        {
            gameObject.GetOrAddComponent<ClassNameMono>().className = LegionaryClass.subname1;
        }
        public override string GetModName()
        {
            return "TBNRC";
        }
    }
    /*
    public class LargeWeightReductionMono : MonoBehaviour
    {
        private void Start()
        {
            
        }
        private void Update(Player player, CharacterStatModifiers statModifiers)
        {
            foreach (CardInfo card in player.data.currentCards);
            bool flag = RomanAthleticism.Card;
            if (flag == true)
            {
                statModifiers.numberOfJumps = 2;
                statModifiers.jump = 0.75f;
            }
        }
    }
    */
}
