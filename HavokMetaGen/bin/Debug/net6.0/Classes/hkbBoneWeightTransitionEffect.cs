using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbBoneWeightTransitionEffect: hkbTransitionEffect
	{
		public const string version = "0";
		public float m_duration { get; set; }
		public const string m_duration_Name = "duration";
		public const string m_duration_Type = "real";
		public float m_toGeneratorStartTimeFraction { get; set; }
		public const string m_toGeneratorStartTimeFraction_Name = "toGeneratorStartTimeFraction";
		public const string m_toGeneratorStartTimeFraction_Type = "real";
		public int m_flags { get; set; }
		public const string m_flags_Name = "flags";
		public const string m_flags_Type = "int";
		public int m_endMode { get; set; }
		public const string m_endMode_Name = "endMode";
		public const string m_endMode_Type = "int";
		public int m_blendCurve { get; set; }
		public const string m_blendCurve_Name = "blendCurve";
		public const string m_blendCurve_Type = "int";
		public List<hkbBoneWeightTransitionEffectBlendSet> m_blendSets { get; set; }
		public const string m_blendSets_Name = "blendSets";
		public const string m_blendSets_Type = "ref";
		public List<int> m_blendSets_refId { get; set; }
		public const string m_blendSets_Class = "hkbBoneWeightTransitionEffectBlendSet";
		public const string m_blendSets_Array = "True";
		public float m_timeRemaining { get; set; }
		public const string m_timeRemaining_Name = "timeRemaining";
		public const string m_timeRemaining_Type = "real";
		public float m_timeInTransition { get; set; }
		public const string m_timeInTransition_Name = "timeInTransition";
		public const string m_timeInTransition_Type = "real";
		public byte m_applySelfTransition { get; set; }
		public const string m_applySelfTransition_Name = "applySelfTransition";
		public const string m_applySelfTransition_Type = "byte";

	}
}
