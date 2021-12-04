using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.GameContent.UI.Elements;
using Terraria.ModLoader;
using Terraria.UI;

namespace PhoenixsQOLAdditions.UIElements
{
	internal class ToggleMenuUI : UIState
	{
		public static ToggleMenuUI Instance;
		public DragableUIPanel Pannel;
		private float oldScale;

		public override void OnInitialize()
		{
			Pannel = new DragableUIPanel();

			Pannel.Left.Set(603f, 0f);
			Pannel.Top.Set(86f, 0f);
			Pannel.Height.Set(100f, 0f);
			Pannel.Width.Set(475f, 0f);


			Append(Pannel);
		}

		public override void Update(GameTime gameTime)
		{
			base.Update(gameTime);
			if (oldScale != Main.inventoryScale)
			{
				oldScale = Main.inventoryScale;
				Recalculate();
			}
		}
	}
}
