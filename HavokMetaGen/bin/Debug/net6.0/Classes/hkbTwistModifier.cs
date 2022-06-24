using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbTwistModifier: hkbModifier
	{
		public const string version = "1";
		public List<float> m_axisOfRotation { get; set; }
		public const string m_axisOfRotation_Name = "axisOfRotation";
		public const string m_axisOfRotation_Type = "vec4";
		public float m_twistAngle { get; set; }
		public const string m_twistAngle_Name = "twistAngle";
		public const string m_twistAngle_Type = "real";
		public int m_startBoneIndex { get; set; }
		public const string m_startBoneIndex_Name = "startBoneIndex";
		public const string m_startBoneIndex_Type = "int";
		public int m_endBoneIndex { get; set; }
		public const string m_endBoneIndex_Name = "endBoneIndex";
		public const string m_endBoneIndex_Type = "int";
		public int m_setAngleMethod { get; set; }
		public const string m_setAngleMethod_Name = "setAngleMethod";
		public const string m_setAngleMethod_Type = "int";
		public int m_rotationAxisCoordinates { get; set; }
		public const string m_rotationAxisCoordinates_Name = "rotationAxisCoordinates";
		public const string m_rotationAxisCoordinates_Type = "int";
		public byte m_isAdditive { get; set; }
		public const string m_isAdditive_Name = "isAdditive";
		public const string m_isAdditive_Type = "byte";

	}
}
