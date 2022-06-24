using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkxMeshSection: hkReferencedObject
	{
		public const string version = "1";
		public hkxVertexBuffer m_vertexBuffer { get; set; }
		public const string m_vertexBuffer_Name = "vertexBuffer";
		public const string m_vertexBuffer_Type = "ref";
		public int m_vertexBuffer_refId { get; set; }
		public const string m_vertexBuffer_Class = "hkxVertexBuffer";
		public List<hkxIndexBuffer> m_indexBuffers { get; set; }
		public const string m_indexBuffers_Name = "indexBuffers";
		public const string m_indexBuffers_Type = "ref";
		public List<int> m_indexBuffers_refId { get; set; }
		public const string m_indexBuffers_Class = "hkxIndexBuffer";
		public const string m_indexBuffers_Array = "True";
		public hkxMaterial m_material { get; set; }
		public const string m_material_Name = "material";
		public const string m_material_Type = "ref";
		public int m_material_refId { get; set; }
		public const string m_material_Class = "hkxMaterial";
		public List<hkReferencedObject> m_userChannels { get; set; }
		public const string m_userChannels_Name = "userChannels";
		public const string m_userChannels_Type = "ref";
		public List<int> m_userChannels_refId { get; set; }
		public const string m_userChannels_Class = "hkReferencedObject";
		public const string m_userChannels_Array = "True";

	}
}
