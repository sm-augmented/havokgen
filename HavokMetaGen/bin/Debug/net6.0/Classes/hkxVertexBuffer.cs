using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkxVertexBuffer: hkReferencedObject
	{
		public const string version = "1";
		public hkxVertexBufferVertexData m_data { get; set; }
		public const string m_data_Name = "data";
		public const string m_data_Type = "struct";
		public const string m_data_Class = "hkxVertexBufferVertexData";
		public hkxVertexDescription m_desc { get; set; }
		public const string m_desc_Name = "desc";
		public const string m_desc_Type = "struct";
		public const string m_desc_Class = "hkxVertexDescription";

	}
}
