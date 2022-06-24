using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkxIndexBuffer: hkReferencedObject
	{
		public const string version = "1";
		public int m_indexType { get; set; }
		public const string m_indexType_Name = "indexType";
		public const string m_indexType_Type = "int";
		public List<int> m_indices16 { get; set; }
		public const string m_indices16_Name = "indices16";
		public const string m_indices16_Type = "int";
		public const string m_indices16_Array = "True";
		public List<int> m_indices32 { get; set; }
		public const string m_indices32_Name = "indices32";
		public const string m_indices32_Type = "int";
		public const string m_indices32_Array = "True";
		public int m_vertexBaseOffset { get; set; }
		public const string m_vertexBaseOffset_Name = "vertexBaseOffset";
		public const string m_vertexBaseOffset_Type = "int";
		public int m_length { get; set; }
		public const string m_length_Name = "length";
		public const string m_length_Type = "int";

	}
}
