using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.Audio;
using Terraria.UI;

namespace PhoenixsQOLAdditions.UIElements
{
	internal delegate void ToggleEventHandler(bool value);

	internal class UIToggleImageButton : UIElement
	{
		public ToggleEventHandler OnToggle;

		private readonly Texture2D Texture;
		private readonly float VisibilityEnabled = 1f;
		private readonly float VisibilityDisabled = 0.4f;
		private bool IsEnabled;

		public UIToggleImageButton(Asset<Texture2D> texture, bool isEnabled)
		{
			Texture = texture.Value;
			Width.Set(texture.Width(), 0);
			Height.Set(texture.Height(), 0);
			IsEnabled = isEnabled;
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
