using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkaMeshBinding: hkReferencedObject
	{
		public const string version = "1";
		public hkxMesh m_mesh { get; set; }
		public const string m_mesh_Name = "mesh";
		public const string m_mesh_Type = "ref";
		public int m_mesh_refId { get; set; }
		public const string m_mesh_Class = "hkxMesh";
		public string m_originalSkeletonName { get; set; }
		public const string m_originalSkeletonName_Name = "originalSkeletonName";
		public const string m_originalSkeletonName_Type = "string";
		public hkaSkeleton m_skeleton { get; set; }
		public const string m_skeleton_Name = "skeleton";
		public const string m_skeleton_Type = "ref";
		public int m_skeleton_refId { get; set; }
		public const string m_skeleton_Class = "hkaSkeleton";
		public List<hkaMeshBindingMapping> m_mappings { get; set; }
		public const string m_mappings_Name = "mappings";
		public const string m_mappings_Type = "ref";
		public List<int> m_mappings_refId { get; set; }
		public const string m_mappings_Class = "hkaMeshBindingMapping";
		public const string m_mappings_Array = "True";
		public List<List<float>> m_boneFromSkinMeshTransforms { get; set; }
		public const string m_boneFromSkinMeshTransforms_Name = "boneFromSkinMeshTransforms";
		public const string m_boneFromSkinMeshTransforms_Type = "vec16";
		public const string m_boneFromSkinMeshTransforms_Array = "True";

	}
}
