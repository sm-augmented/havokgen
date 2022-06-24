using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpSetLocalTransformsConstraintAtom: hkpConstraintAtom
	{
		public const string version = "0";
		public List<float> m_transformA { get; set; }
		public const string m_transformA_Name = "transformA";
		public const string m_transformA_Type = "vec16";
		public List<float> m_transformB { get; set; }
		public const string m_transformB_Name = "transformB";
		public const string m_transformB_Type = "vec16";

	}
}
