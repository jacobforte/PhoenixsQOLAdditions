using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions
{
	public class PhoenixsQOLAdditions : Mod
	{
		//Properties to enable/disable any possibly undesireable buff effects.
		public static bool DangerBuffsEnabled { get; set; } = true;
		public static bool SpelunkerBuffEnabled { get; set; } = true;
		public static bool FeatherFallBuffEnabled { get; set; } = true;
		public static bool GravityBuffEnabled { get; set; } = true;
		public static bool InvisibilityBuffEnabled { get; set; } = true;
		public static bool InfernoVisualEnabled { get; set; } = true;
		public static bool CrateBuffEnabled { get; set; } = true;
		public static bool UltimateBattlerEnabled { get; set; } = false;
		public static bool UltimatePeaceEnabled { get; set; } = false;

		//Keybindings
		public static ModKeybind ShowToggles { get; set; }
		public static ModKeybind QuickRecall { get; set; }


		internal static Dictionary<string, ModTranslation> translations;
		public override Version Version => new Version(0, 0, 1);

		public override void Load()
		{
			if (BuildInfo.tMLVersion < new Version(0, 11, 5))
			{
				throw new Exception("\nThis mod uses functionality only present in the latest tModLoader. Please update tModLoader to use this mod\n\n");
			}

			FieldInfo translationsField = typeof(LocalizationLoader).GetField("translations", BindingFlags.Static | BindingFlags.NonPublic);
			translations = ((Dictionary<string, ModTranslation>)translationsField.GetValue(this)).Where(etc => etc.Key.StartsWith("Mods.PhoenixsQOLAdditions")).ToDictionary(mc => mc.Key, mc => mc.Value);

			ShowToggles = KeybindLoader.RegisterKeybind(this, GetText("KeyBindings", "ShowToggles"), "Y");
			QuickRecall = KeybindLoader.RegisterKeybind(this, GetText("KeyBindings", "QuickRecall"), "R");
		}

		public override void Unload()
		{
			ShowToggles = null;
			QuickRecall = null;
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
	}
}