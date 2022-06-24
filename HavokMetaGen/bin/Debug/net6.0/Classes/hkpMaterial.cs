using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpMaterial
	{
		public const string version = "2";
		public int m_responseType { get; set; }
		public const string m_responseType_Name = "responseType";
		public const string m_responseType_Type = "int";
		public float m_rollingFrictionMultiplier { get; set; }
		public const string m_rollingFrictionMultiplier_Name = "rollingFrictionMultiplier";
		public const string m_rollingFrictionMultiplier_Type = "real";
		public float m_friction { get; set; }
		public const string m_friction_Name = "friction";
		public const string m_friction_Type = "real";
		public float m_restitution { get; set; }
		public const string m_restitution_Name = "restitution";
		public const string m_restitution_Type = "real";

	}
}
