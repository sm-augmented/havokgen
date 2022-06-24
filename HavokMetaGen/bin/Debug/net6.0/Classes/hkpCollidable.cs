using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpCollidable: hkpCdBody
	{
		public const string version = "0";
		public int m_ownerOffset { get; set; }
		public const string m_ownerOffset_Name = "ownerOffset";
		public const string m_ownerOffset_Type = "int";
		public byte m_forceCollideOntoPpu { get; set; }
		public const string m_forceCollideOntoPpu_Name = "forceCollideOntoPpu";
		public const string m_forceCollideOntoPpu_Type = "byte";
		public int m_shapeSizeOnSpu { get; set; }
		public const string m_shapeSizeOnSpu_Name = "shapeSizeOnSpu";
		public const string m_shapeSizeOnSpu_Type = "int";
		public hkpTypedBroadPhaseHandle m_broadPhaseHandle { get; set; }
		public const string m_broadPhaseHandle_Name = "broadPhaseHandle";
		public const string m_broadPhaseHandle_Type = "struct";
		public const string m_broadPhaseHandle_Class = "hkpTypedBroadPhaseHandle";
		public hkpCollidableBoundingVolumeData m_boundingVolumeData { get; set; }
		public const string m_boundingVolumeData_Name = "boundingVolumeData";
		public const string m_boundingVolumeData_Type = "struct";
		public const string m_boundingVolumeData_Class = "hkpCollidableBoundingVolumeData";
		public float m_allowedPenetrationDepth { get; set; }
		public const string m_allowedPenetrationDepth_Name = "allowedPenetrationDepth";
		public const string m_allowedPenetrationDepth_Type = "real";

	}
}
