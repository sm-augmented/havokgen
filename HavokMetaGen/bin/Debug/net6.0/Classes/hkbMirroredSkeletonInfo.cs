using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbMirroredSkeletonInfo: hkReferencedObject
	{
		public const string version = "0";
		public List<float> m_mirrorAxis { get; set; }
		public const string m_mirrorAxis_Name = "mirrorAxis";
		public const string m_mirrorAxis_Type = "vec4";
		public List<int> m_bonePairMap { get; set; }
		public const string m_bonePairMap_Name = "bonePairMap";
		public const string m_bonePairMap_Type = "int";
		public const string m_bonePairMap_Array = "True";

	}
}
