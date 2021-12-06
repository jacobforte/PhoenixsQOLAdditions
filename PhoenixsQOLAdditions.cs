using PhoenixsQOLAdditions.Content.Items.Buffs;
using PhoenixsQOLAdditions.UIElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace PhoenixsQOLAdditions
{
	public class PhoenixsQOLAdditions : Mod
	{
		internal static PhoenixsQOLAdditions Instance { get; set; }

		public static bool ShowToggleMenu { get; set; } = false;
		internal static UserInterface ToggleMenuInterface { get; private set; }

		//Keybindings
		public static ModKeybind QuickRecallKeybind { get; set; }
		public static ModKeybind QuickReturnKeybind { get; set; }
		public static ModKeybind ToggleMenuKeybind { get; private set; }

		internal static Dictionary<string, ModTranslation> translations;
		public override Version Version => new Version(0, 0, 1);

		public override void Load()
		{
			if (BuildInfo.tMLVersion < new Version(0, 11, 5))
			{
				throw new Exception("\nThis mod uses functionality only present in the latest tModLoader. Please update tModLoader to use this mod\n\n");
			}
			Instance = this;

			FieldInfo translationsField = typeof(LocalizationLoader).GetField("translations", BindingFlags.Static | BindingFlags.NonPublic);
			translations = ((Dictionary<string, ModTranslation>)translationsField.GetValue(this)).Where(etc => etc.Key.StartsWith("Mods.PhoenixsQOLAdditions")).ToDictionary(mc => mc.Key, mc => mc.Value);

			QuickRecallKeybind = KeybindLoader.RegisterKeybind(this, GetText("KeyBindings", "QuickRecall"), "Y");
			QuickReturnKeybind = KeybindLoader.RegisterKeybind(this, GetText("KeyBindings", "QuickReturn"), "U");
			ToggleMenuKeybind = KeybindLoader.RegisterKeybind(this, GetText("KeyBindings", "ToggleMenu"), "Z");

			On.Terraria.Player.HasUnityPotion += (orig, player) => HasUnityPotionOverride(orig, player);
			On.Terraria.Player.TakeUnityPotion += (orig, player) => TakeUnityPotionOverride(orig, player);

			if (!Main.dedServ)
			{
				ToggleMenuUI.Instance = new ToggleMenuUI();
				ToggleMenuUI.Instance.Initialize();
				ToggleMenuInterface = new UserInterface();
				ToggleMenuInterface.SetState(ToggleMenuUI.Instance);
			}
		}

		public override void Unload()
		{
			Instance = null;
			QuickRecallKeybind = null;
			QuickReturnKeybind = null;
			ToggleMenuKeybind = null;
			ToggleMenuUI.Instance = null;
			ToggleMenuInterface = null;
		}

		public override void AddRecipeGroups()
		{
			RecipeGroup exquisitelyStuffedGroup = new RecipeGroup(() => GetText("RecipeGroup", "ExquisitelyStuffed"), new int[]
			{
				ItemID.GoldenDelight,
				ItemID.GrapeJuice,
				ItemID.SeafoodDinner
			});
			RecipeGroup.RegisterGroup("PhoenixsQOLAdditions:ExquisitelyStuffed", exquisitelyStuffedGroup);

			RecipeGroup tipsyGroup = new RecipeGroup(() => GetText("RecipeGroup", "Tipsy"), new int[]
			{
				ItemID.Ale,
				ItemID.Sake
			});
			RecipeGroup.RegisterGroup("PhoenixsQOLAdditions:Tipsy", tipsyGroup);

			RecipeGroup campfireGroup = new RecipeGroup(() => GetText("RecipeGroup", "Campfire"), new int[]
			{
				ItemID.BoneCampfire,
				ItemID.Campfire,
				ItemID.CoralCampfire,
				ItemID.CorruptCampfire,
				ItemID.CrimsonCampfire,
				ItemID.CursedCampfire,
				ItemID.DemonCampfire,
				ItemID.DesertCampfire,
				ItemID.FrozenCampfire,
				ItemID.HallowedCampfire,
				ItemID.IchorCampfire,
				ItemID.JungleCampfire,
				ItemID.RainbowCampfire,
				ItemID.UltraBrightCampfire
			});
			RecipeGroup.RegisterGroup("PhoenixsQOLAdditions:Campfire", campfireGroup);
		}

		internal static string GetText(string category, string key, params object[] args)
		{
			return string.Format(translations[$"Mods.PhoenixsQOLAdditions.{category}.{key}"].GetTranslation(Language.ActiveCulture), args);
		}

		private bool HasUnityPotionOverride(On.Terraria.Player.orig_HasUnityPotion orig, Player player)
		{
			if (player.HasItem(ModContent.ItemType<InfiniteWormholePotion>()) || player.HasItem(ModContent.ItemType<InfiniteTravelBuffs>()) || player.HasItem(ModContent.ItemType<InfiniteBuffs>()))
			{
				return true;
			}
			return orig(player);
		}

		private void TakeUnityPotionOverride(On.Terraria.Player.orig_TakeUnityPotion orig, Player player)
		{
			if (player.HasItem(ModContent.ItemType<InfiniteWormholePotion>()) || player.HasItem(ModContent.ItemType<InfiniteTravelBuffs>()) || player.HasItem(ModContent.ItemType<InfiniteBuffs>()))
			{
				return;
			}
			orig(player);
		}
	}
}