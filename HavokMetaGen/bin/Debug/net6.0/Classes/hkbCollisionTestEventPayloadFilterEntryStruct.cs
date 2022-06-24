using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbCollisionTestEventPayloadFilterEntryStruct
	{
		public const string version = "0";
		public int m_targetFilter { get; set; }
		public const string m_targetFilter_Name = "targetFilter";
		public const string m_targetFilter_Type = "int";
		public int m_entityFilter { get; set; }
		public const string m_entityFilter_Name = "entityFilter";
		public const string m_entityFilter_Type = "int";

	}
}
