using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkMotionState
	{
		public const string version = "1";
		public List<float> m_transform { get; set; }
		public const string m_transform_Name = "transform";
		public const string m_transform_Type = "vec16";
		public hkSweptTransform m_sweptTransform { get; set; }
		public const string m_sweptTransform_Name = "sweptTransform";
		public const string m_sweptTransform_Type = "struct";
		public const string m_sweptTransform_Class = "hkSweptTransform";
		public List<float> m_deltaAngle { get; set; }
		public const string m_deltaAngle_Name = "deltaAngle";
		public const string m_deltaAngle_Type = "vec4";
		public float m_objectRadius { get; set; }
		public const string m_objectRadius_Name = "objectRadius";
		public const string m_objectRadius_Type = "real";
		public float m_linearDamping { get; set; }
		public const string m_linearDamping_Name = "linearDamping";
		public const string m_linearDamping_Type = "real";
		public float m_angularDamping { get; set; }
		public const string m_angularDamping_Name = "angularDamping";
		public const string m_angularDamping_Type = "real";
		public float m_timeFactor { get; set; }
		public const string m_timeFactor_Name = "timeFactor";
		public const string m_timeFactor_Type = "real";
		public byte m_maxLinearVelocity { get; set; }
		public const string m_maxLinearVelocity_Name = "maxLinearVelocity";
		public const string m_maxLinearVelocity_Type = "byte";
		public byte m_maxAngularVelocity { get; set; }
		public const string m_maxAngularVelocity_Name = "maxAngularVelocity";
		public const string m_maxAngularVelocity_Type = "byte";
		public byte m_deactivationClass { get; set; }
		public const string m_deactivationClass_Name = "deactivationClass";
		public const string m_deactivationClass_Type = "byte";

	}
}
