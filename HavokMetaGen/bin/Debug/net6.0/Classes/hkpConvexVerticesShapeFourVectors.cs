using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpConvexVerticesShapeFourVectors
	{
		public const string version = "0";
		public List<float> m_x { get; set; }
		public const string m_x_Name = "x";
		public const string m_x_Type = "vec4";
		public List<float> m_y { get; set; }
		public const string m_y_Name = "y";
		public const string m_y_Type = "vec4";
		public List<float> m_z { get; set; }
		public const string m_z_Name = "z";
		public const string m_z_Type = "vec4";

	}
}
