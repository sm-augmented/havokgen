using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbProjectData: hkReferencedObject
	{
		public const string version = "2";
		public List<float> m_worldUpWS { get; set; }
		public const string m_worldUpWS_Name = "worldUpWS";
		public const string m_worldUpWS_Type = "vec4";
		public hkbProjectStringData m_stringData { get; set; }
		public const string m_stringData_Name = "stringData";
		public const string m_stringData_Type = "ref";
		public int m_stringData_refId { get; set; }
		public const string m_stringData_Class = "hkbProjectStringData";
		public int m_defaultEventMode { get; set; }
		public const string m_defaultEventMode_Name = "defaultEventMode";
		public const string m_defaultEventMode_Type = "int";

	}
}
