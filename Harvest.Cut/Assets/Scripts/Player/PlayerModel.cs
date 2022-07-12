using Descriptions;
using UnityEngine;

namespace Player
{
	public class PlayerModel
	{
		public Vector2 Direction;
		public readonly PlayerDescriptionSO PlayerDescription;

		public PlayerModel(PlayerDescriptionSO playerDescription)
		{
			PlayerDescription = playerDescription;
		}
	}
}