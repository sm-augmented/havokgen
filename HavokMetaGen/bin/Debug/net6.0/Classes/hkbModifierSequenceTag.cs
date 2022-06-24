using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbModifierSequenceTag: hkbSequenceTag
	{
		public const string version = "0";
		public hkbModifier m_modifier { get; set; }
		public const string m_modifier_Name = "modifier";
		public const string m_modifier_Type = "ref";
		public int m_modifier_refId { get; set; }
		public const string m_modifier_Class = "hkbModifier";
		public int m_lastPhase { get; set; }
		public const string m_lastPhase_Name = "lastPhase";
		public const string m_lastPhase_Type = "int";

	}
}
