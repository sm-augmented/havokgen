using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbFootIkDriverInfo: hkReferencedObject
	{
		public const string version = "0";
		public List<hkbFootIkDriverInfoLeg> m_legs { get; set; }
		public const string m_legs_Name = "legs";
		public const string m_legs_Type = "struct";
		public const string m_legs_Class = "hkbFootIkDriverInfoLeg";
		public const string m_legs_Array = "True";
		public float m_raycastDistanceUp { get; set; }
		public const string m_raycastDistanceUp_Name = "raycastDistanceUp";
		public const string m_raycastDistanceUp_Type = "real";
		public float m_raycastDistanceDown { get; set; }
		public const string m_raycastDistanceDown_Name = "raycastDistanceDown";
		public const string m_raycastDistanceDown_Type = "real";
		public float m_originalGroundHeightMS { get; set; }
		public const string m_originalGroundHeightMS_Name = "originalGroundHeightMS";
		public const string m_originalGroundHeightMS_Type = "real";
		public float m_verticalOffset { get; set; }
		public const string m_verticalOffset_Name = "verticalOffset";
		public const string m_verticalOffset_Type = "real";
		public int m_collisionFilterInfo { get; set; }
		public const string m_collisionFilterInfo_Name = "collisionFilterInfo";
		public const string m_collisionFilterInfo_Type = "int";
		public float m_forwardAlignFraction { get; set; }
		public const string m_forwardAlignFraction_Name = "forwardAlignFraction";
		public const string m_forwardAlignFraction_Type = "real";
		public float m_sidewaysAlignFraction { get; set; }
		public const string m_sidewaysAlignFraction_Name = "sidewaysAlignFraction";
		public const string m_sidewaysAlignFraction_Type = "real";
		public float m_sidewaysSampleWidth { get; set; }
		public const string m_sidewaysSampleWidth_Name = "sidewaysSampleWidth";
		public const string m_sidewaysSampleWidth_Type = "real";
		public byte m_lockFeetWhenPlanted { get; set; }
		public const string m_lockFeetWhenPlanted_Name = "lockFeetWhenPlanted";
		public const string m_lockFeetWhenPlanted_Type = "byte";
		public byte m_useCharacterUpVector { get; set; }
		public const string m_useCharacterUpVector_Name = "useCharacterUpVector";
		public const string m_useCharacterUpVector_Type = "byte";
		public byte m_isQuadrupedNarrow { get; set; }
		public const string m_isQuadrupedNarrow_Name = "isQuadrupedNarrow";
		public const string m_isQuadrupedNarrow_Type = "byte";

	}
}
