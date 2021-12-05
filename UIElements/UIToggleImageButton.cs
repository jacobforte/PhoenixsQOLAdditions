using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

namespace PhoenixsQOLAdditions.UIElements
{
	internal delegate void ToggleEventHandler(bool value);

	internal class UIToggleImageButton : UIElement
	{
		public ToggleEventHandler OnToggle;
		public bool IsEnabled;

		private readonly Texture2D Texture;
		private readonly float VisibilityEnabled = 1f;
		private readonly float VisibilityDisabled = 0.4f;

		private UITextMouseFollow TextElement;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="texture">Texture must be loaded before being called, else width and height will be zero</param>
		/// <param name="isEnabled"></param>
		public UIToggleImageButton(Asset<Texture2D> texture, bool isEnabled, string hoverText)
		{
			Texture = texture.Value;
			Width.Set(texture.Width(), 0);
			Height.Set(texture.Height(), 0);
			IsEnabled = isEnabled;

			TextElement = new UITextMouseFollow(hoverText);
		}

		public override void Draw(SpriteBatch spriteBatch)
		{
			base.Draw(spriteBatch);

			if (IsMouseHovering)
			{
				TextElement.Draw(spriteBatch);
			}
		}

		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(Texture,
				GetDimensions().Position(),
				Color.White * (IsEnabled ? VisibilityEnabled : VisibilityDisabled));
		}

		public override void MouseOver(UIMouseEvent evt)
		{
			base.MouseOver(evt);
			SoundEngine.PlaySound(12);
		}

		public override void MouseDown(UIMouseEvent evt)
		{
			base.Click(evt);
			IsEnabled = !IsEnabled;
			OnToggle?.Invoke(IsEnabled);
		}
	}
}
