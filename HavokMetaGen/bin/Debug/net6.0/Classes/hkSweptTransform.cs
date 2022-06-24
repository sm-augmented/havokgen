using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkSweptTransform
	{
		public const string version = "0";
		public List<float> m_centerOfMass0 { get; set; }
		public const string m_centerOfMass0_Name = "centerOfMass0";
		public const string m_centerOfMass0_Type = "vec4";
		public List<float> m_centerOfMass1 { get; set; }
		public const string m_centerOfMass1_Name = "centerOfMass1";
		public const string m_centerOfMass1_Type = "vec4";
		public List<float> m_rotation0 { get; set; }
		public const string m_rotation0_Name = "rotation0";
		public const string m_rotation0_Type = "vec4";
		public List<float> m_rotation1 { get; set; }
		public const string m_rotation1_Name = "rotation1";
		public const string m_rotation1_Type = "vec4";
		public List<float> m_centerOfMassLocal { get; set; }
		public const string m_centerOfMassLocal_Name = "centerOfMassLocal";
		public const string m_centerOfMassLocal_Type = "vec4";

	}
}
