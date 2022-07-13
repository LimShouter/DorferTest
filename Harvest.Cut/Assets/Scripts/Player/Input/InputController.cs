using Core;

namespace Player.InputController
{
	public class InputController : IController,IUpdatable
	{
		private readonly Joystick _joystick;
		private readonly PlayerModel _playerModel;

		public InputController(Joystick joystick,PlayerModel playerModel)
		{
			_joystick = joystick;
			_playerModel = playerModel;
		}
		
		public void Attach()
		{
			UpdateSystem.Instance.Add(this);
		}

		public void Detach()
		{
			UpdateSystem.Instance.Remove(this);
		}

		public void Update(float deltaTime)
		{
			_playerModel.Direction = _joystick.Direction;
		}
	}
}