using Descriptions;
using UnityEngine;

namespace Player
{
	public class PlayerModel
	{
		public Vector2 Direction;
		public PlayerDescriptionSO Description { get; }

		public PlayerModel(PlayerDescriptionSO playerDescription)
		{
			Description = playerDescription;
		}
	}
}