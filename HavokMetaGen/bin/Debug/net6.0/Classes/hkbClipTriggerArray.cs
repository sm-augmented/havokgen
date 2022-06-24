using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbClipTriggerArray: hkReferencedObject
	{
		public const string version = "0";
		public List<hkbClipTrigger> m_triggers { get; set; }
		public const string m_triggers_Name = "triggers";
		public const string m_triggers_Type = "struct";
		public const string m_triggers_Class = "hkbClipTrigger";
		public const string m_triggers_Array = "True";

	}
}
