using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkaAnimationBinding: hkReferencedObject
	{
		public const string version = "1";
		public string m_originalSkeletonName { get; set; }
		public const string m_originalSkeletonName_Name = "originalSkeletonName";
		public const string m_originalSkeletonName_Type = "string";
		public hkaAnimation m_animation { get; set; }
		public const string m_animation_Name = "animation";
		public const string m_animation_Type = "ref";
		public int m_animation_refId { get; set; }
		public const string m_animation_Class = "hkaAnimation";
		public List<int> m_transformTrackToBoneIndices { get; set; }
		public const string m_transformTrackToBoneIndices_Name = "transformTrackToBoneIndices";
		public const string m_transformTrackToBoneIndices_Type = "int";
		public const string m_transformTrackToBoneIndices_Array = "True";
		public List<int> m_floatTrackToFloatSlotIndices { get; set; }
		public const string m_floatTrackToFloatSlotIndices_Name = "floatTrackToFloatSlotIndices";
		public const string m_floatTrackToFloatSlotIndices_Type = "int";
		public const string m_floatTrackToFloatSlotIndices_Array = "True";
		public int m_blendHint { get; set; }
		public const string m_blendHint_Name = "blendHint";
		public const string m_blendHint_Type = "int";

	}
}
