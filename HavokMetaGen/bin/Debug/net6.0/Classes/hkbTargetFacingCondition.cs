using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbTargetFacingCondition: hkbCondition
	{
		public const string version = "0";
		public float m_minAngle { get; set; }
		public const string m_minAngle_Name = "minAngle";
		public const string m_minAngle_Type = "real";
		public float m_maxAngle { get; set; }
		public const string m_maxAngle_Name = "maxAngle";
		public const string m_maxAngle_Type = "real";
		public int m_targetHandleIndex { get; set; }
		public const string m_targetHandleIndex_Name = "targetHandleIndex";
		public const string m_targetHandleIndex_Type = "int";

	}
}
