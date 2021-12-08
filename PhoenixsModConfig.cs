using System.ComponentModel;
using System.Reflection;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace PhoenixsQOLAdditions
{
	public class PhoenixsModConfig : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ClientSide;
		
		[Label("$Mods.PhoenixsQOLAdditions.Config.TipsyLabel")]
		[Tooltip("$Mods.PhoenixsQOLAdditions.Config.TipsyTooltip")]
		[DefaultValue(true)]
		public bool TipsyReducesDefense { get; set; }

		//Properties to enable/disable any possibly undesireable buff effects.
		[Header("$Mods.PhoenixsQOLAdditions.Config.Toggles")]


		[Label("$Mods.PhoenixsQOLAdditions.Config.DangerToggle")]
		[Tooltip("$Mods.PhoenixsQOLAdditions.Config.DangerTooltip")]
		[DefaultValue(true)]
		public bool DangerBuffsEnabled { get; set; }

		[Label("$Mods.PhoenixsQOLAdditions.Config.SpelunkerToggle")]
		[Tooltip("$Mods.PhoenixsQOLAdditions.Config.SpelunkerTooltip")]
		[DefaultValue(true)]
		public bool SpelunkerBuffEnabled { get; set; }

		[Label("$Mods.PhoenixsQOLAdditions.Config.FeatherfallToggle")]
		[Tooltip("$Mods.PhoenixsQOLAdditions.Config.FeatherfallTooltip")]
		[DefaultValue(true)]
		public bool FeatherfallBuffEnabled { get; set; }

		[Label("$Mods.PhoenixsQOLAdditions.Config.GravitationToggle")]
		[Tooltip("$Mods.PhoenixsQOLAdditions.Config.GravitationTooltip")]
		[DefaultValue(true)]
		public bool GravityBuffEnabled { get; set; }

		[Label("$Mods.PhoenixsQOLAdditions.Config.InvisibilityToggle")]
		[Tooltip("$Mods.PhoenixsQOLAdditions.Config.InvisibilityTooltip")]
		[DefaultValue(true)]
		public bool InvisibilityBuffEnabled { get; set; }

		[Label("$Mods.PhoenixsQOLAdditions.Config.InfernoToggle")]
		[Tooltip("$Mods.PhoenixsQOLAdditions.Config.InfernoTooltip")]
		[DefaultValue(true)]
		public bool InfernoVisualEnabled { get; set; }

		[Label("$Mods.PhoenixsQOLAdditions.Config.CrateToggle")]
		[Tooltip("$Mods.PhoenixsQOLAdditions.Config.CrateTooltip")]
		[DefaultValue(true)]
		public bool CrateBuffEnabled { get; set; }

		private bool _BattlerEnabled;
		[Label("$Mods.PhoenixsQOLAdditions.Config.BattlerToggle")]
		[Tooltip("$Mods.PhoenixsQOLAdditions.Config.BattlerTooltip")]
		[DefaultValue(false)]
		public bool BattlerEnabled
		{
			get => _BattlerEnabled;
			set
			{
				if (value == true)
				{
					PeaceEnabled = false;
				}
				_BattlerEnabled = value;
			}
		}

		private bool _PeaceEnabled = false;
		[Label("$Mods.PhoenixsQOLAdditions.Config.PeaceToggle")]
		[Tooltip("$Mods.PhoenixsQOLAdditions.Config.PeaceTooltip")]
		[DefaultValue(false)]
		public bool PeaceEnabled
		{
			get => _PeaceEnabled;
			set
			{
				if (value == true)
				{
					BattlerEnabled = false;
				}
				_PeaceEnabled = value;
			}
		}

		internal static void SaveConfig()
		{
			MethodInfo saveMethodInfo = typeof(ConfigManager).GetMethod("Save", BindingFlags.Static | BindingFlags.NonPublic);
			if (saveMethodInfo != null)
			{
				saveMethodInfo.Invoke(null, new object[] { ModContent.GetInstance<PhoenixsModConfig>() });
			}
			else
			{
				PhoenixsQOLAdditions.Instance.Logger.Warn("In-game SaveConfig failed, code update required");
			}
		}
	}
}
