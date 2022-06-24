using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbSequenceTag: hkbBindable
	{
		public const string version = "0";
		public float m_bufferFraction { get; set; }
		public const string m_bufferFraction_Name = "bufferFraction";
		public const string m_bufferFraction_Type = "real";
		public float m_openFraction { get; set; }
		public const string m_openFraction_Name = "openFraction";
		public const string m_openFraction_Type = "real";
		public float m_closedFraction { get; set; }
		public const string m_closedFraction_Name = "closedFraction";
		public const string m_closedFraction_Type = "real";
		public int m_phase { get; set; }
		public const string m_phase_Name = "phase";
		public const string m_phase_Type = "int";
		public float m_lastTimeFraction { get; set; }
		public const string m_lastTimeFraction_Name = "lastTimeFraction";
		public const string m_lastTimeFraction_Type = "real";
		public byte m_startEchoNextFrame { get; set; }
		public const string m_startEchoNextFrame_Name = "startEchoNextFrame";
		public const string m_startEchoNextFrame_Type = "byte";
		public byte m_resetLastTimeFraction { get; set; }
		public const string m_resetLastTimeFraction_Name = "resetLastTimeFraction";
		public const string m_resetLastTimeFraction_Type = "byte";

	}
}
