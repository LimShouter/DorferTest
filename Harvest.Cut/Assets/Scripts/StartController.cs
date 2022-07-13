using System;
using Cinemachine;
using Core;
using Descriptions;
using Player;
using Player.InputController;
using UnityEngine;

namespace DefaultNamespace
{
	public class StartController : MonoBehaviour
	{
		[SerializeField] private MainDescriptionSO _mainDescription;
		[SerializeField] private CinemachineStateDrivenCamera _cameraBrain;
		[SerializeField] private Joystick _joystick;

		private GameObject _playerGO;
		private PlayerModel _playerModel;
		private PlayerController _playerController;
		private InputController _inputController;

		private void Awake()
		{
			DontDestroyOnLoad(this.gameObject);
		}

		private void Start()
		{
			InitPlayer();
			AttachCameraToPlayer();
			AttachInputToPlayerModel();
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
			_cameraBrain.Follow = _playerGO.transform;
			_cameraBrain.LookAt = _playerGO.transform;
		}

		private void AttachInputToPlayerModel()
		{
			_inputController = new InputController(_joystick,_playerModel);
			_inputController.Attach();
		}

		private void OnApplicationQuit()
		{
			DetachAll();
		}

		private void DetachAll()
		{
			_inputController.Detach();
			_playerController.Detach();
		}
	}
}