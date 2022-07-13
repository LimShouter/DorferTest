using UnityEngine;

namespace Descriptions
{
	[CreateAssetMenu(menuName = "Descriptions/Main",fileName = "MainDescription")]
	public class MainDescriptionSO : ScriptableObject
	{
		[SerializeField] private PlayerDescriptionSO _playerDescription;

		public PlayerDescriptionSO PlayerDescription => _playerDescription;
	}
}