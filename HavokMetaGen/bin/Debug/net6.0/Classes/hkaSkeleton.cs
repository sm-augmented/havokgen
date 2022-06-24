using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkaSkeleton: hkReferencedObject
	{
		public const string version = "3";
		public string m_name { get; set; }
		public const string m_name_Name = "name";
		public const string m_name_Type = "string";
		public List<int> m_parentIndices { get; set; }
		public const string m_parentIndices_Name = "parentIndices";
		public const string m_parentIndices_Type = "int";
		public const string m_parentIndices_Array = "True";
		public List<hkaBone> m_bones { get; set; }
		public const string m_bones_Name = "bones";
		public const string m_bones_Type = "struct";
		public const string m_bones_Class = "hkaBone";
		public const string m_bones_Array = "True";
		public List<List<float>> m_referencePose { get; set; }
		public const string m_referencePose_Name = "referencePose";
		public const string m_referencePose_Type = "vec12";
		public const string m_referencePose_Array = "True";
		public List<float> m_referenceFloats { get; set; }
		public const string m_referenceFloats_Name = "referenceFloats";
		public const string m_referenceFloats_Type = "real";
		public const string m_referenceFloats_Array = "True";
		public List<string> m_floatSlots { get; set; }
		public const string m_floatSlots_Name = "floatSlots";
		public const string m_floatSlots_Type = "string";
		public const string m_floatSlots_Array = "True";
		public List<hkaSkeletonLocalFrameOnBone> m_localFrames { get; set; }
		public const string m_localFrames_Name = "localFrames";
		public const string m_localFrames_Type = "struct";
		public const string m_localFrames_Class = "hkaSkeletonLocalFrameOnBone";
		public const string m_localFrames_Array = "True";

	}
}
