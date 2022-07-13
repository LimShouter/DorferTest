using Core;
using UnityEngine;

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
			_view.transform.Translate(new Vector3(_model.Direction.x,0,_model.Direction.y) * _model.PlayerDescription.Speed * deltaTime);
		}
	}
}