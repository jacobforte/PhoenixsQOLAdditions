using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.ModLoader;
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

			var config = ModContent.GetInstance<PhoenixsModConfig>();
			var dangerTexture = PhoenixsQOLAdditions.Instance.Assets.Request<Texture2D>("UIElements/DangerBuff", AssetRequestMode.ImmediateLoad);
			var dangerBuffsToggle = new UIToggleImageButton(dangerTexture, config.DangerBuffsEnabled, PhoenixsQOLAdditions.GetText("Config", "DangerToggle"));
			dangerBuffsToggle.OnToggle += () => { config.DangerBuffsEnabled = !config.DangerBuffsEnabled; PhoenixsModConfig.SaveConfig(); };
			dangerBuffsToggle.IsEnabled = () => config.DangerBuffsEnabled;
			//dangerBuffsToggle.Left.Set(leftOffset, 0);
			//leftOffset += leftOffsetIncrament;
			Panel.Append(dangerBuffsToggle);

			var spelunkerTexture = PhoenixsQOLAdditions.Instance.Assets.Request<Texture2D>("UIElements/SpelunkerBuff", AssetRequestMode.ImmediateLoad);
			var spelunkerBuffToggle = new UIToggleImageButton(spelunkerTexture, config.SpelunkerBuffEnabled, PhoenixsQOLAdditions.GetText("Config", "SpelunkerToggle"));
			spelunkerBuffToggle.OnToggle += () => { config.SpelunkerBuffEnabled = !config.SpelunkerBuffEnabled; PhoenixsModConfig.SaveConfig(); };
			spelunkerBuffToggle.IsEnabled = () => config.SpelunkerBuffEnabled;
			spelunkerBuffToggle.Left.Set(leftOffset, 0);
			leftOffset += leftOffsetIncrament;
			Panel.Append(spelunkerBuffToggle);

			var featherfallTexture = PhoenixsQOLAdditions.Instance.Assets.Request<Texture2D>("UIElements/FeatherfallBuff", AssetRequestMode.ImmediateLoad);
			var featherfallBuffToggle = new UIToggleImageButton(featherfallTexture, config.FeatherfallBuffEnabled, PhoenixsQOLAdditions.GetText("Config", "FeatherfallToggle"));
			featherfallBuffToggle.OnToggle += () => { config.FeatherfallBuffEnabled = !config.FeatherfallBuffEnabled; PhoenixsModConfig.SaveConfig(); };
			featherfallBuffToggle.IsEnabled = () => config.FeatherfallBuffEnabled;
			featherfallBuffToggle.Left.Set(leftOffset, 0);
			leftOffset += leftOffsetIncrament;
			Panel.Append(featherfallBuffToggle);

			var gravitationTexture = PhoenixsQOLAdditions.Instance.Assets.Request<Texture2D>("UIElements/GravitationBuff", AssetRequestMode.ImmediateLoad);
			var gravitationBuffToggle = new UIToggleImageButton(gravitationTexture, config.GravityBuffEnabled, PhoenixsQOLAdditions.GetText("Config", "GravitationToggle"));
			gravitationBuffToggle.OnToggle += () => { config.GravityBuffEnabled = !config.GravityBuffEnabled; PhoenixsModConfig.SaveConfig(); };
			gravitationBuffToggle.IsEnabled = () => config.GravityBuffEnabled;
			gravitationBuffToggle.Left.Set(leftOffset, 0);
			leftOffset += leftOffsetIncrament;
			Panel.Append(gravitationBuffToggle);

			var invisibilityTexture = PhoenixsQOLAdditions.Instance.Assets.Request<Texture2D>("UIElements/InvisibilityBuff", AssetRequestMode.ImmediateLoad);
			var invisibilityBuffToggle = new UIToggleImageButton(invisibilityTexture, config.InvisibilityBuffEnabled, PhoenixsQOLAdditions.GetText("Config", "InvisibilityToggle"));
			invisibilityBuffToggle.OnToggle += () => { config.InvisibilityBuffEnabled = !config.InvisibilityBuffEnabled; PhoenixsModConfig.SaveConfig(); };
			invisibilityBuffToggle.IsEnabled = () => config.InvisibilityBuffEnabled;
			invisibilityBuffToggle.Left.Set(leftOffset, 0);
			leftOffset += leftOffsetIncrament;
			Panel.Append(invisibilityBuffToggle);

			var infernoTexture = PhoenixsQOLAdditions.Instance.Assets.Request<Texture2D>("UIElements/InfernoBuff", AssetRequestMode.ImmediateLoad);
			var infernoBuffsToggle = new UIToggleImageButton(infernoTexture, config.InfernoVisualEnabled, PhoenixsQOLAdditions.GetText("Config", "InfernoToggle"));
			infernoBuffsToggle.OnToggle += () => { config.InfernoVisualEnabled = !config.InfernoVisualEnabled; PhoenixsModConfig.SaveConfig(); };
			infernoBuffsToggle.IsEnabled = () => config.InfernoVisualEnabled;
			infernoBuffsToggle.Left.Set(leftOffset, 0);
			leftOffset += leftOffsetIncrament;
			Panel.Append(infernoBuffsToggle);

			var crateTexture = PhoenixsQOLAdditions.Instance.Assets.Request<Texture2D>("UIElements/CrateBuff", AssetRequestMode.ImmediateLoad);
			var crateBuffsToggle = new UIToggleImageButton(crateTexture, config.CrateBuffEnabled, PhoenixsQOLAdditions.GetText("Config", "CrateToggle"));
			crateBuffsToggle.OnToggle += () => { config.CrateBuffEnabled = !config.CrateBuffEnabled; PhoenixsModConfig.SaveConfig(); };
			crateBuffsToggle.IsEnabled = () => config.CrateBuffEnabled;
			crateBuffsToggle.Left.Set(leftOffset, 0);
			leftOffset += leftOffsetIncrament;
			Panel.Append(crateBuffsToggle);

			var peaceTexture = PhoenixsQOLAdditions.Instance.Assets.Request<Texture2D>("UIElements/PeaceBuff", AssetRequestMode.ImmediateLoad);
			var peaceBuffsToggle = new UIToggleImageButton(peaceTexture, config.PeaceEnabled, PhoenixsQOLAdditions.GetText("Config", "PeaceToggle"));
			peaceBuffsToggle.OnToggle += () => { config.PeaceEnabled = !config.PeaceEnabled; PhoenixsModConfig.SaveConfig(); };
			peaceBuffsToggle.IsEnabled = () => config.PeaceEnabled;
			peaceBuffsToggle.Left.Set(leftOffset, 0);
			leftOffset += leftOffsetIncrament;
			Panel.Append(peaceBuffsToggle);

			var battleTexture = PhoenixsQOLAdditions.Instance.Assets.Request<Texture2D>("UIElements/BattleBuff", AssetRequestMode.ImmediateLoad);
			var battleBuffsToggle = new UIToggleImageButton(battleTexture, config.BattlerEnabled, PhoenixsQOLAdditions.GetText("Config", "BattlerToggle"));
			battleBuffsToggle.OnToggle += () => { config.BattlerEnabled = !config.BattlerEnabled; PhoenixsModConfig.SaveConfig(); };
			battleBuffsToggle.IsEnabled = () => config.BattlerEnabled;
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
