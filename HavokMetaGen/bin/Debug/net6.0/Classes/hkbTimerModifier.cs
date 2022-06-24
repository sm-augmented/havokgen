using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbTimerModifier: hkbModifier
	{
		public const string version = "1";
		public float m_alarmTimeSeconds { get; set; }
		public const string m_alarmTimeSeconds_Name = "alarmTimeSeconds";
		public const string m_alarmTimeSeconds_Type = "real";
		public hkbEventProperty m_alarmEvent { get; set; }
		public const string m_alarmEvent_Name = "alarmEvent";
		public const string m_alarmEvent_Type = "struct";
		public const string m_alarmEvent_Class = "hkbEventProperty";
		public float m_secondsElapsed { get; set; }
		public const string m_secondsElapsed_Name = "secondsElapsed";
		public const string m_secondsElapsed_Type = "real";

	}
}
