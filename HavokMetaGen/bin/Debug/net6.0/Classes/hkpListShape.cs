using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpListShape: hkpShapeCollection
	{
		public const string version = "0";
		public List<hkpListShapeChildInfo> m_childInfo { get; set; }
		public const string m_childInfo_Name = "childInfo";
		public const string m_childInfo_Type = "struct";
		public const string m_childInfo_Class = "hkpListShapeChildInfo";
		public const string m_childInfo_Array = "True";
		public int m_flags { get; set; }
		public const string m_flags_Name = "flags";
		public const string m_flags_Type = "int";
		public int m_numDisabledChildren { get; set; }
		public const string m_numDisabledChildren_Name = "numDisabledChildren";
		public const string m_numDisabledChildren_Type = "int";
		public List<float> m_aabbHalfExtents { get; set; }
		public const string m_aabbHalfExtents_Name = "aabbHalfExtents";
		public const string m_aabbHalfExtents_Type = "vec4";
		public List<float> m_aabbCenter { get; set; }
		public const string m_aabbCenter_Name = "aabbCenter";
		public const string m_aabbCenter_Type = "vec4";
		public List<int> m_enabledChildren { get; set; }
		public const string m_enabledChildren_Name = "enabledChildren";
		public const string m_enabledChildren_Type = "int";
		public const string m_enabledChildren_Count = "8";

	}
}
