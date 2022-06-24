using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbBoneWeightTransitionEffectBlendSet
	{
		public const string version = "0";
		public float m_transitionStartFraction { get; set; }
		public const string m_transitionStartFraction_Name = "transitionStartFraction";
		public const string m_transitionStartFraction_Type = "real";
		public float m_transitionEndFraction { get; set; }
		public const string m_transitionEndFraction_Name = "transitionEndFraction";
		public const string m_transitionEndFraction_Type = "real";
		public List<int> m_bones { get; set; }
		public const string m_bones_Name = "bones";
		public const string m_bones_Type = "int";
		public const string m_bones_Array = "True";

	}
}
