using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Terraria.GameContent.Bestiary;
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

		internal static string GetText(string category, string key, params object[] args)
		{
			return string.Format(translations[$"Mods.PhoenixsQOLAdditions.{category}.{key}"].GetTranslation(Language.ActiveCulture);, args);
		}
	}
}