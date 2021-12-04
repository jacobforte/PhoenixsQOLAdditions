using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader.Config;

namespace PhoenixsQOLAdditions
{
	public class PhoenixsModConfig : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ServerSide;

		[Label("$Mods.PhoenixsQOLAdditions.Config.TipsyLabel")]
		[Tooltip("$Mods.PhoenixsQOLAdditions.Config.TipsyTooltip")]
		[DefaultValue(true)]
		public bool TipsyReducesDefense;
	}
}
