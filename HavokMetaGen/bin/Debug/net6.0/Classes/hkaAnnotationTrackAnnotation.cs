using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkaAnnotationTrackAnnotation
	{
		public const string version = "0";
		public float m_time { get; set; }
		public const string m_time_Name = "time";
		public const string m_time_Type = "real";
		public string m_text { get; set; }
		public const string m_text_Name = "text";
		public const string m_text_Type = "string";

	}
}
