using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpEntity: hkpWorldObject
	{
		public const string version = "3";
		public hkpMaterial m_material { get; set; }
		public const string m_material_Name = "material";
		public const string m_material_Type = "struct";
		public const string m_material_Class = "hkpMaterial";
		public float m_damageMultiplier { get; set; }
		public const string m_damageMultiplier_Name = "damageMultiplier";
		public const string m_damageMultiplier_Type = "real";
		public int m_solverData { get; set; }
		public const string m_solverData_Name = "solverData";
		public const string m_solverData_Type = "int";
		public int m_storageIndex { get; set; }
		public const string m_storageIndex_Name = "storageIndex";
		public const string m_storageIndex_Type = "int";
		public int m_contactPointCallbackDelay { get; set; }
		public const string m_contactPointCallbackDelay_Name = "contactPointCallbackDelay";
		public const string m_contactPointCallbackDelay_Type = "int";
		public hkpEntitySmallArraySerializeOverrideType m_constraintsMaster { get; set; }
		public const string m_constraintsMaster_Name = "constraintsMaster";
		public const string m_constraintsMaster_Type = "struct";
		public const string m_constraintsMaster_Class = "hkpEntitySmallArraySerializeOverrideType";
		public List<hkpConstraintInstance> m_constraintsSlave { get; set; }
		public const string m_constraintsSlave_Name = "constraintsSlave";
		public const string m_constraintsSlave_Type = "ref";
		public List<int> m_constraintsSlave_refId { get; set; }
		public const string m_constraintsSlave_Class = "hkpConstraintInstance";
		public const string m_constraintsSlave_Array = "True";
		public List<byte> m_constraintRuntime { get; set; }
		public const string m_constraintRuntime_Name = "constraintRuntime";
		public const string m_constraintRuntime_Type = "byte";
		public const string m_constraintRuntime_Array = "True";
		public int m_autoRemoveLevel { get; set; }
		public const string m_autoRemoveLevel_Name = "autoRemoveLevel";
		public const string m_autoRemoveLevel_Type = "int";
		public byte m_numShapeKeysInContactPointProperties { get; set; }
		public const string m_numShapeKeysInContactPointProperties_Name = "numShapeKeysInContactPointProperties";
		public const string m_numShapeKeysInContactPointProperties_Type = "byte";
		public byte m_responseModifierFlags { get; set; }
		public const string m_responseModifierFlags_Name = "responseModifierFlags";
		public const string m_responseModifierFlags_Type = "byte";
		public int m_uid { get; set; }
		public const string m_uid_Name = "uid";
		public const string m_uid_Type = "int";
		public hkpEntitySpuCollisionCallback m_spuCollisionCallback { get; set; }
		public const string m_spuCollisionCallback_Name = "spuCollisionCallback";
		public const string m_spuCollisionCallback_Type = "struct";
		public const string m_spuCollisionCallback_Class = "hkpEntitySpuCollisionCallback";
		public hkpMotion m_motion { get; set; }
		public const string m_motion_Name = "motion";
		public const string m_motion_Type = "struct";
		public const string m_motion_Class = "hkpMotion";
		public hkpEntitySmallArraySerializeOverrideType m_contactListeners { get; set; }
		public const string m_contactListeners_Name = "contactListeners";
		public const string m_contactListeners_Type = "struct";
		public const string m_contactListeners_Class = "hkpEntitySmallArraySerializeOverrideType";
		public hkpEntitySmallArraySerializeOverrideType m_actions { get; set; }
		public const string m_actions_Name = "actions";
		public const string m_actions_Type = "struct";
		public const string m_actions_Class = "hkpEntitySmallArraySerializeOverrideType";
		public hkLocalFrame m_localFrame { get; set; }
		public const string m_localFrame_Name = "localFrame";
		public const string m_localFrame_Type = "ref";
		public int m_localFrame_refId { get; set; }
		public const string m_localFrame_Class = "hkLocalFrame";
		public hkpEntityExtendedListeners m_extendedListeners { get; set; }
		public const string m_extendedListeners_Name = "extendedListeners";
		public const string m_extendedListeners_Type = "ref";
		public int m_extendedListeners_refId { get; set; }
		public const string m_extendedListeners_Class = "hkpEntityExtendedListeners";
		public int m_npData { get; set; }
		public const string m_npData_Name = "npData";
		public const string m_npData_Type = "int";

	}
}
