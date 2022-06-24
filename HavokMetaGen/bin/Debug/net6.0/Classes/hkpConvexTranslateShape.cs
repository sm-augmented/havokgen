using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpConvexTranslateShape: hkpConvexTransformShapeBase
	{
		public const string version = "0";
		public List<float> m_translation { get; set; }
		public const string m_translation_Name = "translation";
		public const string m_translation_Type = "vec4";

	}
}
