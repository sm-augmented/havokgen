using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpMoppCode: hkReferencedObject
	{
		public const string version = "0";
		public hkpMoppCodeCodeInfo m_info { get; set; }
		public const string m_info_Name = "info";
		public const string m_info_Type = "struct";
		public const string m_info_Class = "hkpMoppCodeCodeInfo";
		public List<byte> m_data { get; set; }
		public const string m_data_Name = "data";
		public const string m_data_Type = "byte";
		public const string m_data_Array = "True";
		public int m_buildType { get; set; }
		public const string m_buildType_Name = "buildType";
		public const string m_buildType_Type = "int";

	}
}
