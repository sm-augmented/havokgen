using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpConvexVerticesConnectivity: hkReferencedObject
	{
		public const string version = "0";
		public List<int> m_vertexIndices { get; set; }
		public const string m_vertexIndices_Name = "vertexIndices";
		public const string m_vertexIndices_Type = "int";
		public const string m_vertexIndices_Array = "True";
		public List<byte> m_numVerticesPerFace { get; set; }
		public const string m_numVerticesPerFace_Name = "numVerticesPerFace";
		public const string m_numVerticesPerFace_Type = "byte";
		public const string m_numVerticesPerFace_Array = "True";

	}
}
