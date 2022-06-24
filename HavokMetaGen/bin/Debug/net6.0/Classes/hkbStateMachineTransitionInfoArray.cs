using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbStateMachineTransitionInfoArray: hkReferencedObject
	{
		public const string version = "0";
		public List<hkbStateMachineTransitionInfo> m_transitions { get; set; }
		public const string m_transitions_Name = "transitions";
		public const string m_transitions_Type = "struct";
		public const string m_transitions_Class = "hkbStateMachineTransitionInfo";
		public const string m_transitions_Array = "True";

	}
}
