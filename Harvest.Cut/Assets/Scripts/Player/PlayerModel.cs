using Descriptions;

namespace Player
{
	public class PlayerModel
	{
		public readonly PlayerDescriptionSO PlayerDescription;

		public PlayerModel(PlayerDescriptionSO playerDescription)
		{
			PlayerDescription = playerDescription;
		}
	}
}