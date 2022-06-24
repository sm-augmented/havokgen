using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkaAnimation: hkReferencedObject
	{
		public const string version = "1";
		public int m_type { get; set; }
		public const string m_type_Name = "type";
		public const string m_type_Type = "int";
		public float m_duration { get; set; }
		public const string m_duration_Name = "duration";
		public const string m_duration_Type = "real";
		public int m_numberOfTransformTracks { get; set; }
		public const string m_numberOfTransformTracks_Name = "numberOfTransformTracks";
		public const string m_numberOfTransformTracks_Type = "int";
		public int m_numberOfFloatTracks { get; set; }
		public const string m_numberOfFloatTracks_Name = "numberOfFloatTracks";
		public const string m_numberOfFloatTracks_Type = "int";
		public hkaAnimatedReferenceFrame m_extractedMotion { get; set; }
		public const string m_extractedMotion_Name = "extractedMotion";
		public const string m_extractedMotion_Type = "ref";
		public int m_extractedMotion_refId { get; set; }
		public const string m_extractedMotion_Class = "hkaAnimatedReferenceFrame";
		public List<hkaAnnotationTrack> m_annotationTracks { get; set; }
		public const string m_annotationTracks_Name = "annotationTracks";
		public const string m_annotationTracks_Type = "ref";
		public List<int> m_annotationTracks_refId { get; set; }
		public const string m_annotationTracks_Class = "hkaAnnotationTrack";
		public const string m_annotationTracks_Array = "True";

	}
}
