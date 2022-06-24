using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbFootIkGains
	{
		public const string version = "0";
		public float m_onOffGain { get; set; }
		public const string m_onOffGain_Name = "onOffGain";
		public const string m_onOffGain_Type = "real";
		public float m_groundAscendingGain { get; set; }
		public const string m_groundAscendingGain_Name = "groundAscendingGain";
		public const string m_groundAscendingGain_Type = "real";
		public float m_groundDescendingGain { get; set; }
		public const string m_groundDescendingGain_Name = "groundDescendingGain";
		public const string m_groundDescendingGain_Type = "real";
		public float m_footPlantedGain { get; set; }
		public const string m_footPlantedGain_Name = "footPlantedGain";
		public const string m_footPlantedGain_Type = "real";
		public float m_footRaisedGain { get; set; }
		public const string m_footRaisedGain_Name = "footRaisedGain";
		public const string m_footRaisedGain_Type = "real";
		public float m_footUnlockGain { get; set; }
		public const string m_footUnlockGain_Name = "footUnlockGain";
		public const string m_footUnlockGain_Type = "real";
		public float m_worldFromModelFeedbackGain { get; set; }
		public const string m_worldFromModelFeedbackGain_Name = "worldFromModelFeedbackGain";
		public const string m_worldFromModelFeedbackGain_Type = "real";
		public float m_errorUpDownBias { get; set; }
		public const string m_errorUpDownBias_Name = "errorUpDownBias";
		public const string m_errorUpDownBias_Type = "real";
		public float m_alignWorldFromModelGain { get; set; }
		public const string m_alignWorldFromModelGain_Name = "alignWorldFromModelGain";
		public const string m_alignWorldFromModelGain_Type = "real";
		public float m_hipOrientationGain { get; set; }
		public const string m_hipOrientationGain_Name = "hipOrientationGain";
		public const string m_hipOrientationGain_Type = "real";

	}
}
