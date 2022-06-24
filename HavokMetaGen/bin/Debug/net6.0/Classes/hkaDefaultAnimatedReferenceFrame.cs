using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkaDefaultAnimatedReferenceFrame: hkaAnimatedReferenceFrame
	{
		public const string version = "0";
		public List<float> m_up { get; set; }
		public const string m_up_Name = "up";
		public const string m_up_Type = "vec4";
		public List<float> m_forward { get; set; }
		public const string m_forward_Name = "forward";
		public const string m_forward_Type = "vec4";
		public float m_duration { get; set; }
		public const string m_duration_Name = "duration";
		public const string m_duration_Type = "real";
		public List<List<float>> m_referenceFrameSamples { get; set; }
		public const string m_referenceFrameSamples_Name = "referenceFrameSamples";
		public const string m_referenceFrameSamples_Type = "vec4";
		public const string m_referenceFrameSamples_Array = "True";

	}
}
