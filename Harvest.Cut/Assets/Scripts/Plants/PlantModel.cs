using Descriptions;
using UnityEngine;

namespace DefaultNamespace.Plants
{
	public class PlantModel
	{
		public PlantDescriptionSO Description { get; }

		public PlantModel(PlantDescriptionSO description)
		{
			Description = description;
		}
	}
}