using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbFootIkDriverInfoLeg
	{
		public const string version = "0";
		public List<float> m_kneeAxisLS { get; set; }
		public const string m_kneeAxisLS_Name = "kneeAxisLS";
		public const string m_kneeAxisLS_Type = "vec4";
		public List<float> m_footEndLS { get; set; }
		public const string m_footEndLS_Name = "footEndLS";
		public const string m_footEndLS_Type = "vec4";
		public float m_footPlantedAnkleHeightMS { get; set; }
		public const string m_footPlantedAnkleHeightMS_Name = "footPlantedAnkleHeightMS";
		public const string m_footPlantedAnkleHeightMS_Type = "real";
		public float m_footRaisedAnkleHeightMS { get; set; }
		public const string m_footRaisedAnkleHeightMS_Name = "footRaisedAnkleHeightMS";
		public const string m_footRaisedAnkleHeightMS_Type = "real";
		public float m_maxAnkleHeightMS { get; set; }
		public const string m_maxAnkleHeightMS_Name = "maxAnkleHeightMS";
		public const string m_maxAnkleHeightMS_Type = "real";
		public float m_minAnkleHeightMS { get; set; }
		public const string m_minAnkleHeightMS_Name = "minAnkleHeightMS";
		public const string m_minAnkleHeightMS_Type = "real";
		public float m_maxKneeAngleDegrees { get; set; }
		public const string m_maxKneeAngleDegrees_Name = "maxKneeAngleDegrees";
		public const string m_maxKneeAngleDegrees_Type = "real";
		public float m_minKneeAngleDegrees { get; set; }
		public const string m_minKneeAngleDegrees_Name = "minKneeAngleDegrees";
		public const string m_minKneeAngleDegrees_Type = "real";
		public int m_hipIndex { get; set; }
		public const string m_hipIndex_Name = "hipIndex";
		public const string m_hipIndex_Type = "int";
		public int m_kneeIndex { get; set; }
		public const string m_kneeIndex_Name = "kneeIndex";
		public const string m_kneeIndex_Type = "int";
		public int m_ankleIndex { get; set; }
		public const string m_ankleIndex_Name = "ankleIndex";
		public const string m_ankleIndex_Type = "int";

	}
}
