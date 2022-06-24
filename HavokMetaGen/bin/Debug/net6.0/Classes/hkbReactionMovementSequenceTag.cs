using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbReactionMovementSequenceTag: hkbSequenceTag
	{
		public const string version = "0";
		public byte m_shouldApplyVelocity { get; set; }
		public const string m_shouldApplyVelocity_Name = "shouldApplyVelocity";
		public const string m_shouldApplyVelocity_Type = "byte";
		public List<float> m_inputOffsetPerSecondMS { get; set; }
		public const string m_inputOffsetPerSecondMS_Name = "inputOffsetPerSecondMS";
		public const string m_inputOffsetPerSecondMS_Type = "vec4";
		public List<float> m_preGeneratePosition { get; set; }
		public const string m_preGeneratePosition_Name = "preGeneratePosition";
		public const string m_preGeneratePosition_Type = "vec4";
		public float m_timeSinceLastModify { get; set; }
		public const string m_timeSinceLastModify_Name = "timeSinceLastModify";
		public const string m_timeSinceLastModify_Type = "real";
		public float m_reactionTimeRemaining { get; set; }
		public const string m_reactionTimeRemaining_Name = "reactionTimeRemaining";
		public const string m_reactionTimeRemaining_Type = "real";

	}
}
