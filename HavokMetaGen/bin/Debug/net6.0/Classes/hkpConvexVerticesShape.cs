using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpConvexVerticesShape: hkpConvexShape
	{
		public const string version = "3";
		public List<float> m_aabbHalfExtents { get; set; }
		public const string m_aabbHalfExtents_Name = "aabbHalfExtents";
		public const string m_aabbHalfExtents_Type = "vec4";
		public List<float> m_aabbCenter { get; set; }
		public const string m_aabbCenter_Name = "aabbCenter";
		public const string m_aabbCenter_Type = "vec4";
		public List<hkpConvexVerticesShapeFourVectors> m_rotatedVertices { get; set; }
		public const string m_rotatedVertices_Name = "rotatedVertices";
		public const string m_rotatedVertices_Type = "struct";
		public const string m_rotatedVertices_Class = "hkpConvexVerticesShapeFourVectors";
		public const string m_rotatedVertices_Array = "True";
		public int m_numVertices { get; set; }
		public const string m_numVertices_Name = "numVertices";
		public const string m_numVertices_Type = "int";
		public List<List<float>> m_planeEquations { get; set; }
		public const string m_planeEquations_Name = "planeEquations";
		public const string m_planeEquations_Type = "vec4";
		public const string m_planeEquations_Array = "True";
		public hkpConvexVerticesConnectivity m_connectivity { get; set; }
		public const string m_connectivity_Name = "connectivity";
		public const string m_connectivity_Type = "ref";
		public int m_connectivity_refId { get; set; }
		public const string m_connectivity_Class = "hkpConvexVerticesConnectivity";

	}
}
