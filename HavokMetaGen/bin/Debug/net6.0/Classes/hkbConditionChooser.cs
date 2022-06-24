using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbConditionChooser: hkbStateChooser
	{
		public const string version = "0";
		public List<hkbConditionChooserConditionEntry> m_entries { get; set; }
		public const string m_entries_Name = "entries";
		public const string m_entries_Type = "ref";
		public List<int> m_entries_refId { get; set; }
		public const string m_entries_Class = "hkbConditionChooserConditionEntry";
		public const string m_entries_Array = "True";

	}
}
