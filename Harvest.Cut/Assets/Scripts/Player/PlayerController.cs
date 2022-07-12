using Core;

namespace Player
{
	public class PlayerController : IController, IUpdatable
	{
		private readonly PlayerModel _model;
		private readonly PlayerView _view;

		public PlayerController(PlayerModel model,PlayerView view)
		{
			_model = model;
			_view = view;
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
			Move(deltaTime);  
		}

		private void Move(float deltaTime)
		{
			_view.transform.Translate(_model.Direction * _model.PlayerDescription.Speed * deltaTime);
		}
	}
}