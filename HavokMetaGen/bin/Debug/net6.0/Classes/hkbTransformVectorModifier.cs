using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbTransformVectorModifier: hkbModifier
	{
		public const string version = "0";
		public List<float> m_rotation { get; set; }
		public const string m_rotation_Name = "rotation";
		public const string m_rotation_Type = "vec4";
		public List<float> m_translation { get; set; }
		public const string m_translation_Name = "translation";
		public const string m_translation_Type = "vec4";
		public List<float> m_vectorIn { get; set; }
		public const string m_vectorIn_Name = "vectorIn";
		public const string m_vectorIn_Type = "vec4";
		public List<float> m_vectorOut { get; set; }
		public const string m_vectorOut_Name = "vectorOut";
		public const string m_vectorOut_Type = "vec4";
		public byte m_rotateOnly { get; set; }
		public const string m_rotateOnly_Name = "rotateOnly";
		public const string m_rotateOnly_Type = "byte";
		public byte m_inverse { get; set; }
		public const string m_inverse_Name = "inverse";
		public const string m_inverse_Type = "byte";
		public byte m_computeOnActivate { get; set; }
		public const string m_computeOnActivate_Name = "computeOnActivate";
		public const string m_computeOnActivate_Type = "byte";
		public byte m_computeOnModify { get; set; }
		public const string m_computeOnModify_Name = "computeOnModify";
		public const string m_computeOnModify_Type = "byte";

	}
}
