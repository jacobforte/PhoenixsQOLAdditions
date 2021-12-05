using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.UI;

namespace PhoenixsQOLAdditions.UIElements
{
	internal class ToggleMenuUI : UIState
	{
		public static ToggleMenuUI Instance;
		public DragableUIPanel Panel;
		private float oldScale;

		public override void OnInitialize()
		{
			Panel = new DragableUIPanel();
			Panel.Left.Set(603, 0);
			Panel.Top.Set(86, 0);
			Panel.Height.Set(58, 0);
			Panel.Width.Set(475, 0);

			int leftOffsetIncrament = 38;
			int leftOffset = 38;

			var dangerTexture = PhoenixsQOLAdditions.Instance.Assets.Request<Texture2D>("UIElements/DangerBuff", AssetRequestMode.ImmediateLoad);
			var dangerBuffsToggle = new UIToggleImageButton(dangerTexture, PhoenixsQOLAdditions.DangerBuffsEnabled, PhoenixsQOLAdditions.GetText("Config", "DangerToggle"));
			dangerBuffsToggle.OnToggle += (value) => { PhoenixsQOLAdditions.DangerBuffsEnabled = value; };
			//dangerBuffsToggle.Left.Set(leftOffset, 0);
			//leftOffset += leftOffsetIncrament;
			Panel.Append(dangerBuffsToggle);

			var spelunkerTexture = PhoenixsQOLAdditions.Instance.Assets.Request<Texture2D>("UIElements/SpelunkerBuff", AssetRequestMode.ImmediateLoad);
			var spelunkerBuffToggle = new UIToggleImageButton(spelunkerTexture, PhoenixsQOLAdditions.SpelunkerBuffEnabled, PhoenixsQOLAdditions.GetText("Config", "SpelunkerToggle"));
			spelunkerBuffToggle.OnToggle += (value) => { PhoenixsQOLAdditions.SpelunkerBuffEnabled = value; };
			spelunkerBuffToggle.Left.Set(leftOffset, 0);
			leftOffset += leftOffsetIncrament;
			Panel.Append(spelunkerBuffToggle);

			var featherfallTexture = PhoenixsQOLAdditions.Instance.Assets.Request<Texture2D>("UIElements/FeatherfallBuff", AssetRequestMode.ImmediateLoad);
			var featherfallBuffToggle = new UIToggleImageButton(featherfallTexture, PhoenixsQOLAdditions.FeatherfallBuffEnabled, PhoenixsQOLAdditions.GetText("Config", "FeatherfallToggle"));
			featherfallBuffToggle.OnToggle += (value) => { PhoenixsQOLAdditions.FeatherfallBuffEnabled = value; };
			featherfallBuffToggle.Left.Set(leftOffset, 0);
			leftOffset += leftOffsetIncrament;
			Panel.Append(featherfallBuffToggle);

			var gravitationTexture = PhoenixsQOLAdditions.Instance.Assets.Request<Texture2D>("UIElements/GravitationBuff", AssetRequestMode.ImmediateLoad);
			var gravitationBuffToggle = new UIToggleImageButton(gravitationTexture, PhoenixsQOLAdditions.GravityBuffEnabled, PhoenixsQOLAdditions.GetText("Config", "GravitationToggle"));
			gravitationBuffToggle.OnToggle += (value) => { PhoenixsQOLAdditions.GravityBuffEnabled = value; };
			gravitationBuffToggle.Left.Set(leftOffset, 0);
			leftOffset += leftOffsetIncrament;
			Panel.Append(gravitationBuffToggle);

			var invisibilityTexture = PhoenixsQOLAdditions.Instance.Assets.Request<Texture2D>("UIElements/InvisibilityBuff", AssetRequestMode.ImmediateLoad);
			var invisibilityBuffToggle = new UIToggleImageButton(invisibilityTexture, PhoenixsQOLAdditions.InvisibilityBuffEnabled, PhoenixsQOLAdditions.GetText("Config", "InvisibilityToggle"));
			invisibilityBuffToggle.OnToggle += (value) => { PhoenixsQOLAdditions.InvisibilityBuffEnabled = value; };
			invisibilityBuffToggle.Left.Set(leftOffset, 0);
			leftOffset += leftOffsetIncrament;
			Panel.Append(invisibilityBuffToggle);

			var infernoTexture = PhoenixsQOLAdditions.Instance.Assets.Request<Texture2D>("UIElements/InfernoBuff", AssetRequestMode.ImmediateLoad);
			var infernoBuffsToggle = new UIToggleImageButton(infernoTexture, PhoenixsQOLAdditions.InfernoVisualEnabled, PhoenixsQOLAdditions.GetText("Config", "InfernoToggle"));
			infernoBuffsToggle.OnToggle += (value) => { PhoenixsQOLAdditions.InfernoVisualEnabled = value; };
			infernoBuffsToggle.Left.Set(leftOffset, 0);
			leftOffset += leftOffsetIncrament;
			Panel.Append(infernoBuffsToggle);

			var crateTexture = PhoenixsQOLAdditions.Instance.Assets.Request<Texture2D>("UIElements/CrateBuff", AssetRequestMode.ImmediateLoad);
			var crateBuffsToggle = new UIToggleImageButton(crateTexture, PhoenixsQOLAdditions.CrateBuffEnabled, PhoenixsQOLAdditions.GetText("Config", "CrateToggle"));
			crateBuffsToggle.OnToggle += (value) => { PhoenixsQOLAdditions.CrateBuffEnabled = value; };
			crateBuffsToggle.Left.Set(leftOffset, 0);
			leftOffset += leftOffsetIncrament;
			Panel.Append(crateBuffsToggle);

			var peaceTexture = PhoenixsQOLAdditions.Instance.Assets.Request<Texture2D>("UIElements/PeaceBuff", AssetRequestMode.ImmediateLoad);
			var peaceBuffsToggle = new UIToggleImageButton(peaceTexture, PhoenixsQOLAdditions.PeaceEnabled, PhoenixsQOLAdditions.GetText("Config", "PeaceToggle"));
			peaceBuffsToggle.Left.Set(leftOffset, 0);
			leftOffset += leftOffsetIncrament;
			Panel.Append(peaceBuffsToggle);

			var battleTexture = PhoenixsQOLAdditions.Instance.Assets.Request<Texture2D>("UIElements/BattleBuff", AssetRequestMode.ImmediateLoad);
			var battleBuffsToggle = new UIToggleImageButton(battleTexture, PhoenixsQOLAdditions.BattlerEnabled, PhoenixsQOLAdditions.GetText("Config", "BattlerToggle"));
			battleBuffsToggle.OnToggle += (value) => { PhoenixsQOLAdditions.BattlerEnabled = value; peaceBuffsToggle.IsEnabled = !value; };
			peaceBuffsToggle.OnToggle += (value) => { PhoenixsQOLAdditions.PeaceEnabled = value; battleBuffsToggle.IsEnabled = !value; };
			battleBuffsToggle.Left.Set(leftOffset, 0);
			//leftOffset += leftOffsetIncrament;
			Panel.Append(battleBuffsToggle);

			Append(Panel);
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
