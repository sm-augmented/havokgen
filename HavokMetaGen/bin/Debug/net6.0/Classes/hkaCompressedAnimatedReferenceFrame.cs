using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkaCompressedAnimatedReferenceFrame: hkaAnimatedReferenceFrame
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
		public List<int> m_compressedReferenceFrameData { get; set; }
		public const string m_compressedReferenceFrameData_Name = "compressedReferenceFrameData";
		public const string m_compressedReferenceFrameData_Type = "int";
		public const string m_compressedReferenceFrameData_Array = "True";
		public List<float> m_minimums { get; set; }
		public const string m_minimums_Name = "minimums";
		public const string m_minimums_Type = "real";
		public const string m_minimums_Count = "4";
		public List<float> m_spans { get; set; }
		public const string m_spans_Name = "spans";
		public const string m_spans_Type = "real";
		public const string m_spans_Count = "4";
		public List<int> m_sizes { get; set; }
		public const string m_sizes_Name = "sizes";
		public const string m_sizes_Type = "int";
		public const string m_sizes_Count = "4";
		public List<int> m_offsets { get; set; }
		public const string m_offsets_Name = "offsets";
		public const string m_offsets_Type = "int";
		public const string m_offsets_Count = "4";

	}
}
