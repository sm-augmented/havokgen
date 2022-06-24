using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbClipGenerator: hkbGenerator
	{
		public const string version = "2";
		public string m_animationName { get; set; }
		public const string m_animationName_Name = "animationName";
		public const string m_animationName_Type = "string";
		public hkbClipTriggerArray m_triggers { get; set; }
		public const string m_triggers_Name = "triggers";
		public const string m_triggers_Type = "ref";
		public int m_triggers_refId { get; set; }
		public const string m_triggers_Class = "hkbClipTriggerArray";
		public float m_cropStartAmountLocalTime { get; set; }
		public const string m_cropStartAmountLocalTime_Name = "cropStartAmountLocalTime";
		public const string m_cropStartAmountLocalTime_Type = "real";
		public float m_cropEndAmountLocalTime { get; set; }
		public const string m_cropEndAmountLocalTime_Name = "cropEndAmountLocalTime";
		public const string m_cropEndAmountLocalTime_Type = "real";
		public float m_startTime { get; set; }
		public const string m_startTime_Name = "startTime";
		public const string m_startTime_Type = "real";
		public float m_playbackSpeed { get; set; }
		public const string m_playbackSpeed_Name = "playbackSpeed";
		public const string m_playbackSpeed_Type = "real";
		public float m_enforcedDuration { get; set; }
		public const string m_enforcedDuration_Name = "enforcedDuration";
		public const string m_enforcedDuration_Type = "real";
		public float m_userControlledTimeFraction { get; set; }
		public const string m_userControlledTimeFraction_Name = "userControlledTimeFraction";
		public const string m_userControlledTimeFraction_Type = "real";
		public int m_animationBindingIndex { get; set; }
		public const string m_animationBindingIndex_Name = "animationBindingIndex";
		public const string m_animationBindingIndex_Type = "int";
		public int m_mode { get; set; }
		public const string m_mode_Name = "mode";
		public const string m_mode_Type = "int";
		public int m_flags { get; set; }
		public const string m_flags_Name = "flags";
		public const string m_flags_Type = "int";
		public int m_animationBindingBucket { get; set; }
		public const string m_animationBindingBucket_Name = "animationBindingBucket";
		public const string m_animationBindingBucket_Type = "int";
		public List<float> m_extractedMotion { get; set; }
		public const string m_extractedMotion_Name = "extractedMotion";
		public const string m_extractedMotion_Type = "vec12";
		public float m_localTime { get; set; }
		public const string m_localTime_Name = "localTime";
		public const string m_localTime_Type = "real";
		public float m_time { get; set; }
		public const string m_time_Name = "time";
		public const string m_time_Type = "real";
		public float m_previousUserControlledTimeFraction { get; set; }
		public const string m_previousUserControlledTimeFraction_Name = "previousUserControlledTimeFraction";
		public const string m_previousUserControlledTimeFraction_Type = "real";
		public int m_bufferSize { get; set; }
		public const string m_bufferSize_Name = "bufferSize";
		public const string m_bufferSize_Type = "int";
		public int m_echoBufferSize { get; set; }
		public const string m_echoBufferSize_Name = "echoBufferSize";
		public const string m_echoBufferSize_Type = "int";
		public byte m_atEnd { get; set; }
		public const string m_atEnd_Name = "atEnd";
		public const string m_atEnd_Type = "byte";
		public byte m_ignoreStartTime { get; set; }
		public const string m_ignoreStartTime_Name = "ignoreStartTime";
		public const string m_ignoreStartTime_Type = "byte";
		public byte m_pingPongBackward { get; set; }
		public const string m_pingPongBackward_Name = "pingPongBackward";
		public const string m_pingPongBackward_Type = "byte";

	}
}
