using System;
using Cinemachine;
using Core;
using Descriptions;
using Player;
using UnityEngine;

namespace DefaultNamespace
{
	public class StartController : MonoBehaviour
	{
		[SerializeField] private MainDescriptionSO _mainDescription;
		[SerializeField] private CinemachineStateDrivenCamera cameraBrain;

		private GameObject _playerGO;
		private PlayerModel _playerModel;
		private PlayerController _playerController;

		private void Awake()
		{
			DontDestroyOnLoad(this.gameObject);
		}

		private void Start()
		{
			InitPlayer();
			AttachCameraToPlayer();
		}

		private void Update()
		{
			UpdateSystem.Instance.Update(Time.deltaTime);
		}

		private void InitPlayer()
		{
			_playerGO = Instantiate(_mainDescription.PlayerDescription.PlayerPrefab);
			_playerModel = new PlayerModel(_mainDescription.PlayerDescription);
			_playerController = new PlayerController(_playerModel, _playerGO.GetComponent<PlayerView>());
			_playerController.Attach();
		}

		private void AttachCameraToPlayer()
		{
			cameraBrain.Follow = _playerGO.transform;
			cameraBrain.LookAt = _playerGO.transform;
		}
	}
}