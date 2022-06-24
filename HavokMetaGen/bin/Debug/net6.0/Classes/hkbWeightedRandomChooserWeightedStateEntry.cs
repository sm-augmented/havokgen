using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbWeightedRandomChooserWeightedStateEntry: hkbStateChooserEntry
	{
		public const string version = "0";
		public float m_stateWeight { get; set; }
		public const string m_stateWeight_Name = "stateWeight";
		public const string m_stateWeight_Type = "real";

	}
}
