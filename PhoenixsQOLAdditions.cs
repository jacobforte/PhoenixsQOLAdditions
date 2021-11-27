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
		}

		public override void AddRecipeGroups()
		{
			RecipeGroup wellFedGroup = new RecipeGroup(() => GetText("RecipeGroup", "WellFed"), new int[]
			{
				ItemID.CookedMarshmallow,
				ItemID.AppleJuice,
				ItemID.BloodyMoscato,
				ItemID.BunnyStew,
				ItemID.CookedFish,
				ItemID.BananaDaiquiri,
				ItemID.FruitJuice,
				ItemID.FruitSalad,
				ItemID.GrilledSquirrel,
				ItemID.Lemonade,
				ItemID.PeachSangria,
				ItemID.PinaColada,
				ItemID.RoastedBird,
				ItemID.SmoothieofDarkness,
				ItemID.TropicalSmoothie,
				ItemID.Teacup,
				ItemID.SauteedFrogLegs
			});
			RecipeGroup.RegisterGroup("PhoenixsQOLAdditions:WellFed", wellFedGroup);

			RecipeGroup plentySatisfiedGroup = new RecipeGroup(() => GetText("RecipeGroup", "PlentySatisfied"), new int[]
			{
				ItemID.BowlofSoup,
				ItemID.CookedShrimp,
				ItemID.GrubSoup,
				ItemID.PumpkinPie,
				ItemID.Sashimi,
				ItemID.Escargot,
				ItemID.LobsterTail,
				ItemID.MonsterLasagna,
				ItemID.PrismaticPunch,
				ItemID.RoastedDuck,
				ItemID.FroggleBunwich
			});
			RecipeGroup.RegisterGroup("PhoenixsQOLAdditions:PlentySatisfied", plentySatisfiedGroup);

			RecipeGroup exquisitelyStuffedGroup = new RecipeGroup(() => GetText("RecipeGroup", "ExquisitelyStuffed"), new int[]
			{
				ItemID.GoldenDelight,
				ItemID.GrapeJuice,
				ItemID.SeafoodDinner
			});
			RecipeGroup.RegisterGroup("PhoenixsQOLAdditions:ExquisitelyStuffed", exquisitelyStuffedGroup);
		}

		internal static string GetText(string category, string key, params object[] args)
		{
			return string.Format(translations[$"Mods.PhoenixsQOLAdditions.{category}.{key}"].GetTranslation(Language.ActiveCulture), args);
		}
	}
}