using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbWeightedRandomChooser: hkbStateChooser
	{
		public const string version = "0";
		public List<hkbWeightedRandomChooserWeightedState> m_states { get; set; }
		public const string m_states_Name = "states";
		public const string m_states_Type = "struct";
		public const string m_states_Class = "hkbWeightedRandomChooserWeightedState";
		public const string m_states_Array = "True";
		public List<hkbWeightedRandomChooserWeightedStateEntry> m_entries { get; set; }
		public const string m_entries_Name = "entries";
		public const string m_entries_Type = "ref";
		public List<int> m_entries_refId { get; set; }
		public const string m_entries_Class = "hkbWeightedRandomChooserWeightedStateEntry";
		public const string m_entries_Array = "True";

	}
}
