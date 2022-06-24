using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbStateMachineTransitionInfo
	{
		public const string version = "2";
		public hkbTransitionEffect m_transition { get; set; }
		public const string m_transition_Name = "transition";
		public const string m_transition_Type = "ref";
		public int m_transition_refId { get; set; }
		public const string m_transition_Class = "hkbTransitionEffect";
		public hkbCondition m_condition { get; set; }
		public const string m_condition_Name = "condition";
		public const string m_condition_Type = "ref";
		public int m_condition_refId { get; set; }
		public const string m_condition_Class = "hkbCondition";
		public int m_eventId { get; set; }
		public const string m_eventId_Name = "eventId";
		public const string m_eventId_Type = "int";
		public int m_toStateId { get; set; }
		public const string m_toStateId_Name = "toStateId";
		public const string m_toStateId_Type = "int";
		public int m_fromNestedStateId { get; set; }
		public const string m_fromNestedStateId_Name = "fromNestedStateId";
		public const string m_fromNestedStateId_Type = "int";
		public int m_toNestedStateId { get; set; }
		public const string m_toNestedStateId_Name = "toNestedStateId";
		public const string m_toNestedStateId_Type = "int";
		public int m_priority { get; set; }
		public const string m_priority_Name = "priority";
		public const string m_priority_Type = "int";
		public int m_branchId { get; set; }
		public const string m_branchId_Name = "branchId";
		public const string m_branchId_Type = "int";
		public int m_flags { get; set; }
		public const string m_flags_Name = "flags";
		public const string m_flags_Type = "int";
		public int m_startStateIdx { get; set; }
		public const string m_startStateIdx_Name = "startStateIdx";
		public const string m_startStateIdx_Type = "int";
		public int m_enableBinding { get; set; }
		public const string m_enableBinding_Name = "enableBinding";
		public const string m_enableBinding_Type = "int";

	}
}
