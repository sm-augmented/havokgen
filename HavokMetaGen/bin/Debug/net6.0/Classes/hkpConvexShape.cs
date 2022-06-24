using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpConvexShape: hkpSphereRepShape
	{
		public const string version = "0";
		public float m_radius { get; set; }
		public const string m_radius_Name = "radius";
		public const string m_radius_Type = "real";

	}
}
