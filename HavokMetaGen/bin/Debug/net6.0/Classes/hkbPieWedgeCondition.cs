using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbPieWedgeCondition: hkbCondition
	{
		public const string version = "0";
		public float m_minRadius { get; set; }
		public const string m_minRadius_Name = "minRadius";
		public const string m_minRadius_Type = "real";
		public float m_maxRadius { get; set; }
		public const string m_maxRadius_Name = "maxRadius";
		public const string m_maxRadius_Type = "real";
		public float m_minAngle { get; set; }
		public const string m_minAngle_Name = "minAngle";
		public const string m_minAngle_Type = "real";
		public float m_maxAngle { get; set; }
		public const string m_maxAngle_Name = "maxAngle";
		public const string m_maxAngle_Type = "real";
		public byte m_invertAngleCheck { get; set; }
		public const string m_invertAngleCheck_Name = "invertAngleCheck";
		public const string m_invertAngleCheck_Type = "byte";
		public float m_offsetDistance { get; set; }
		public const string m_offsetDistance_Name = "offsetDistance";
		public const string m_offsetDistance_Type = "real";
		public int m_defaultTargetPositionIndex { get; set; }
		public const string m_defaultTargetPositionIndex_Name = "defaultTargetPositionIndex";
		public const string m_defaultTargetPositionIndex_Type = "int";
		public int m_targetHandleIndex { get; set; }
		public const string m_targetHandleIndex_Name = "targetHandleIndex";
		public const string m_targetHandleIndex_Type = "int";

	}
}
