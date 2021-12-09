using PhoenixsQOLAdditions.Content.Items.AmmoWeapons;
using PhoenixsQOLAdditions.Content.Items.Buffs;
using PhoenixsQOLAdditions.Content.Items.HealingMana;
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
			On.Terraria.Player.ApplyPotionDelay += (orig, player, item) => ApplyPotionDelay(orig, player, item);
			LoadLauncherAmmoProjectiles();

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
			UnloadLauncherAmmoProjectiles();
			Instance = null;
			translations = null;
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

		private static bool HasUnityPotionOverride(On.Terraria.Player.orig_HasUnityPotion orig, Player player)
		{
			if (player.HasItem(ModContent.ItemType<InfiniteWormholePotion>()) || player.HasItem(ModContent.ItemType<InfiniteTravelBuffs>()) || player.HasItem(ModContent.ItemType<InfiniteBuffs>()))
			{
				return true;
			}
			return orig(player);
		}

		private static void TakeUnityPotionOverride(On.Terraria.Player.orig_TakeUnityPotion orig, Player player)
		{
			if (player.HasItem(ModContent.ItemType<InfiniteWormholePotion>()) || player.HasItem(ModContent.ItemType<InfiniteTravelBuffs>()) || player.HasItem(ModContent.ItemType<InfiniteBuffs>()))
			{
				return;
			}
			orig(player);
		}

		private static void ApplyPotionDelay(On.Terraria.Player.orig_ApplyPotionDelay orig, Player player, Item item)
		{
			if (item.type == ModContent.ItemType<InfiniteRestorationPotion>())
			{
				player.AddBuff(21, player.restorationDelayTime);
			}
			else if (item.type == ModContent.ItemType<InfiniteMushroom>())
			{
				player.AddBuff(21, player.mushroomDelayTime);
			}
			else
			{
				orig(player, item);
			}
		}

		private static void LoadLauncherAmmoProjectiles()
		{
			foreach (var rocket in SpecificLauncherAmmoProjectileMatches)
			{
				var launcher = AmmoID.Sets.SpecificLauncherAmmoProjectileMatches.Where(etc => etc.Key == rocket.Key);
				if (launcher.Any())
				{
					foreach (var ammo in rocket.Value)
					{
						launcher.First().Value.Add(ammo.Key, ammo.Value);
					}
				}
			}
		}

		private static void UnloadLauncherAmmoProjectiles()
		{
			foreach (var rocket in SpecificLauncherAmmoProjectileMatches)
			{
				var launcher = AmmoID.Sets.SpecificLauncherAmmoProjectileMatches.Where(etc => etc.Key == rocket.Key);
				if (launcher.Any())
				{
					foreach (var ammo in rocket.Value)
					{
						launcher.First().Value.Remove(ammo.Key);
					}
				}
			}
		}

		private static Dictionary<int, Dictionary<int, int>> SpecificLauncherAmmoProjectileMatches = new()
		{
			{
				759,
				new Dictionary<int, int> {
					{ ModContent.ItemType<InfiniteRocketI>(), 134 },
					{ ModContent.ItemType<InfiniteRocketII>(), 137 },
					{ ModContent.ItemType<InfiniteRocketIII>(), 140 },
					{ ModContent.ItemType<InfiniteRocketIV>(), 143 },
					{ ModContent.ItemType<InfiniteClusterRocketI>(), 776 },
					{ ModContent.ItemType<InfiniteClusterRocketII>(), 780 },
					{ ModContent.ItemType<InfiniteMiniNukeI>(), 793 },
					{ ModContent.ItemType<InfiniteMiniNukeII>(), 796 },
					{ ModContent.ItemType<InfiniteDryRocket>(), 799 },
					{ ModContent.ItemType<InfiniteWetRocket>(), 784 },
					{ ModContent.ItemType<InfiniteLavaRocket>(), 787 },
					{ ModContent.ItemType<InfiniteHoneyRocket>(), 790 }
				}
			},
			{
				758,
				new Dictionary<int, int> {
					{ ModContent.ItemType<InfiniteRocketI>(), 133 },
					{ ModContent.ItemType<InfiniteRocketII>(), 136 },
					{ ModContent.ItemType<InfiniteRocketIII>(), 139 },
					{ ModContent.ItemType<InfiniteRocketIV>(), 142 },
					{ ModContent.ItemType<InfiniteClusterRocketI>(), 777 },
					{ ModContent.ItemType<InfiniteClusterRocketII>(), 781 },
					{ ModContent.ItemType<InfiniteMiniNukeI>(), 794 },
					{ ModContent.ItemType<InfiniteMiniNukeII>(), 797 },
					{ ModContent.ItemType<InfiniteDryRocket>(), 800 },
					{ ModContent.ItemType<InfiniteWetRocket>(), 785 },
					{ ModContent.ItemType<InfiniteLavaRocket>(), 788 },
					{ ModContent.ItemType<InfiniteHoneyRocket>(), 791 }
				}
			},
			{
				760,
				new Dictionary<int, int> {
					{ ModContent.ItemType<InfiniteRocketI>(), 135 },
					{ ModContent.ItemType<InfiniteRocketII>(), 138 },
					{ ModContent.ItemType<InfiniteRocketIII>(), 141 },
					{ ModContent.ItemType<InfiniteRocketIV>(), 144 },
					{ ModContent.ItemType<InfiniteClusterRocketI>(), 778 },
					{ ModContent.ItemType<InfiniteClusterRocketII>(), 782 },
					{ ModContent.ItemType<InfiniteMiniNukeI>(), 795 },
					{ ModContent.ItemType<InfiniteMiniNukeII>(), 798 },
					{ ModContent.ItemType<InfiniteDryRocket>(), 801 },
					{ ModContent.ItemType<InfiniteWetRocket>(), 786 },
					{ ModContent.ItemType<InfiniteLavaRocket>(), 789 },
					{ ModContent.ItemType<InfiniteHoneyRocket>(), 792 }
				}
			},
			{
				1946,
				new Dictionary<int, int> {
					{ ModContent.ItemType<InfiniteRocketI>(), 338 },
					{ ModContent.ItemType<InfiniteRocketII>(), 339 },
					{ ModContent.ItemType<InfiniteRocketIII>(), 340 },
					{ ModContent.ItemType<InfiniteRocketIV>(), 341 },
					{ ModContent.ItemType<InfiniteClusterRocketI>(), 803 },
					{ ModContent.ItemType<InfiniteClusterRocketII>(), 804 },
					{ ModContent.ItemType<InfiniteMiniNukeI>(), 808 },
					{ ModContent.ItemType<InfiniteMiniNukeII>(), 809 },
					{ ModContent.ItemType<InfiniteDryRocket>(), 810 },
					{ ModContent.ItemType<InfiniteWetRocket>(), 805 },
					{ ModContent.ItemType<InfiniteLavaRocket>(), 806 },
					{ ModContent.ItemType<InfiniteHoneyRocket>(), 807 }
				}
			},
			{
				3930,
				new Dictionary<int, int> {
					{ ModContent.ItemType<InfiniteRocketI>(), 715 },
					{ ModContent.ItemType<InfiniteRocketII>(), 716 },
					{ ModContent.ItemType<InfiniteRocketIII>(), 717 },
					{ ModContent.ItemType<InfiniteRocketIV>(), 718 },
					{ ModContent.ItemType<InfiniteClusterRocketI>(), 717 },
					{ ModContent.ItemType<InfiniteClusterRocketII>(), 718 },
					{ ModContent.ItemType<InfiniteMiniNukeI>(), 717 },
					{ ModContent.ItemType<InfiniteMiniNukeII>(), 718 },
					{ ModContent.ItemType<InfiniteDryRocket>(), 717 },
					{ ModContent.ItemType<InfiniteWetRocket>(), 717 },
					{ ModContent.ItemType<InfiniteLavaRocket>(), 717 },
					{ ModContent.ItemType<InfiniteHoneyRocket>(), 717 }
				}
			}
		};
	}
}