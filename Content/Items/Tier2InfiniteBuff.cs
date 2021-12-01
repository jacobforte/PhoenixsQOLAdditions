using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;

namespace PhoenixsQOLAdditions.Content.Items
{
	public abstract class Tier2InfiniteBuff : BaseInfiniteBuffs
	{
		protected abstract Dictionary<int, Type> GetParrentItemTypes();


		private Dictionary<int, Type> _ParrentItemTypes;
		private Dictionary<int, Type> ParrentItemTypes
		{
			get
			{
				if (_ParrentItemTypes == null)
				{
					_ParrentItemTypes = GetParrentItemTypes();
				}
				return _ParrentItemTypes;
			}
		}

		public sealed override void UpdateInventory(Player player)
		{
			var localParrentItemTypes = ParrentItemTypes;
			foreach (var parrentItemType in localParrentItemTypes)
			{
				Type type = parrentItemType.Value;
				if (!player.HasItem(parrentItemType.Key))
				{
					dynamic item = Activator.CreateInstance(type);
					item.UpdateInventory(player);
				}
			}
		}

		public sealed override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			foreach (var parrentItemType in ParrentItemTypes)
			{
				recipe.AddIngredient(parrentItemType.Key);
			}
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();
		}
	}
}
