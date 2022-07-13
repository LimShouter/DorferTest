using Core;
using DefaultNamespace.Plants;

namespace Plants
{
	public class PlantController : IController,IUpdatable
	{
		private readonly PlantModel _model;
		private readonly PlantView _view;

		public PlantController(PlantModel model,PlantView view)
		{
			_model = model;
			_view = view;
		}
		
		public void Attach()
		{
			
		}

		public void Detach()
		{
		}

		public void Update(float deltaTime)
		{
		}
	}
}