using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.GameContent;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

namespace PhoenixsQOLAdditions.UIElements
{
	internal class UITextMouseFollow : UIElement
	{
		private string Text;
		private Vector2 TextSize;

		public UITextMouseFollow(string text)
		{
			InternalSetText(text);
		}

		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			base.DrawSelf(spriteBatch);
			CalculatedStyle innerDimensions = GetInnerDimensions();
			Vector2 pos = innerDimensions.Position();
			pos.Y -= 2f;

			var mousePos = Main.MouseScreen;

			pos.X += innerDimensions.Width - TextSize.X + mousePos.X;
			pos.Y += innerDimensions.Height - TextSize.Y + mousePos.Y;
			Utils.DrawBorderString(spriteBatch, Text, pos, Color.White);
		}

		private void InternalSetText(string text)
		{
			DynamicSpriteFont dynamicSpriteFont = FontAssets.MouseText.Value;
			Text = text;

			Vector2 vector = dynamicSpriteFont.MeasureString(text);
			TextSize = new Vector2(vector.X, 16f);
			MinWidth.Set(TextSize.X, 0f);
			MinHeight.Set(TextSize.Y, 0f);
		}
	}
}
