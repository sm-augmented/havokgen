using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbWedgePayload: hkbShapePayload
	{
		public const string version = "0";
		public float m_originOffsetDistance { get; set; }
		public const string m_originOffsetDistance_Name = "originOffsetDistance";
		public const string m_originOffsetDistance_Type = "real";
		public float m_depth { get; set; }
		public const string m_depth_Name = "depth";
		public const string m_depth_Type = "real";
		public float m_minAngle { get; set; }
		public const string m_minAngle_Name = "minAngle";
		public const string m_minAngle_Type = "real";
		public float m_maxAngle { get; set; }
		public const string m_maxAngle_Name = "maxAngle";
		public const string m_maxAngle_Type = "real";

	}
}
