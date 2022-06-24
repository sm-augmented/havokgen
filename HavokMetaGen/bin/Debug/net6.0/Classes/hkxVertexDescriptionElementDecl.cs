using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkxVertexDescriptionElementDecl
	{
		public const string version = "2";
		public int m_byteOffset { get; set; }
		public const string m_byteOffset_Name = "byteOffset";
		public const string m_byteOffset_Type = "int";
		public int m_type { get; set; }
		public const string m_type_Name = "type";
		public const string m_type_Type = "int";
		public int m_usage { get; set; }
		public const string m_usage_Name = "usage";
		public const string m_usage_Type = "int";
		public int m_byteStride { get; set; }
		public const string m_byteStride_Name = "byteStride";
		public const string m_byteStride_Type = "int";
		public byte m_numElements { get; set; }
		public const string m_numElements_Name = "numElements";
		public const string m_numElements_Type = "byte";

	}
}
