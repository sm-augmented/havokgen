using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbWeightedRandomChooserWeightedState
	{
		public const string version = "0";
		public float m_stateWeight { get; set; }
		public const string m_stateWeight_Name = "stateWeight";
		public const string m_stateWeight_Type = "real";
		public int m_stateId { get; set; }
		public const string m_stateId_Name = "stateId";
		public const string m_stateId_Type = "int";

	}
}
