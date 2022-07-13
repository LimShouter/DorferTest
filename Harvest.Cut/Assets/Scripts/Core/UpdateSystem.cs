using System.Collections.Generic;

namespace Core
{
	public class UpdateSystem : IUpdatable
	{
		private static UpdateSystem _instance;
		public static UpdateSystem Instance => _instance ??= new UpdateSystem();

		private readonly List<IUpdatable> _updatables = new List<IUpdatable>();
		private readonly List<IUpdatable> _removes = new List<IUpdatable>();

		public void Add(IUpdatable updatable)
		{
			_updatables.Add(updatable);
		}

		public void Remove(IUpdatable updatable)
		{
			_removes.Add(updatable);
		}

		public void Clear()
		{
			_updatables.Clear();
		}

		public void Update(float deltaTime)
		{
			if (_removes.Count>0)
			{
				foreach (var updatable in _removes)
				{
					_updatables.Remove(updatable);
				}
			}
			_removes.Clear();
			
			
			foreach (var updatable in _updatables)
			{
				updatable.Update(deltaTime);
			}
		}
	};
}