using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkaAnnotationTrack
	{
		public const string version = "0";
		public string m_trackName { get; set; }
		public const string m_trackName_Name = "trackName";
		public const string m_trackName_Type = "string";
		public List<hkaAnnotationTrackAnnotation> m_annotations { get; set; }
		public const string m_annotations_Name = "annotations";
		public const string m_annotations_Type = "struct";
		public const string m_annotations_Class = "hkaAnnotationTrackAnnotation";
		public const string m_annotations_Array = "True";

	}
}
