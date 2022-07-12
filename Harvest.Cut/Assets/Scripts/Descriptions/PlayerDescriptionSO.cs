using UnityEngine;

namespace Descriptions
{
	[CreateAssetMenu(menuName = "Descriptions/Player",fileName = "PlayerDescription")]
	public class PlayerDescriptionSO : ScriptableObject
	{

		[SerializeField] private GameObject _playerPrefab;
		[SerializeField] private float _speed;
		
		public float Speed => _speed;
		public GameObject PlayerPrefab => _playerPrefab;
	}
}