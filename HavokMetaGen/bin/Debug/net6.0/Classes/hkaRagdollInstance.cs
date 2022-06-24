using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkaRagdollInstance: hkReferencedObject
	{
		public const string version = "0";
		public List<hkpRigidBody> m_rigidBodies { get; set; }
		public const string m_rigidBodies_Name = "rigidBodies";
		public const string m_rigidBodies_Type = "ref";
		public List<int> m_rigidBodies_refId { get; set; }
		public const string m_rigidBodies_Class = "hkpRigidBody";
		public const string m_rigidBodies_Array = "True";
		public List<hkpConstraintInstance> m_constraints { get; set; }
		public const string m_constraints_Name = "constraints";
		public const string m_constraints_Type = "ref";
		public List<int> m_constraints_refId { get; set; }
		public const string m_constraints_Class = "hkpConstraintInstance";
		public const string m_constraints_Array = "True";
		public List<int> m_boneToRigidBodyMap { get; set; }
		public const string m_boneToRigidBodyMap_Name = "boneToRigidBodyMap";
		public const string m_boneToRigidBodyMap_Type = "int";
		public const string m_boneToRigidBodyMap_Array = "True";
		public hkaSkeleton m_skeleton { get; set; }
		public const string m_skeleton_Name = "skeleton";
		public const string m_skeleton_Type = "ref";
		public int m_skeleton_refId { get; set; }
		public const string m_skeleton_Class = "hkaSkeleton";

	}
}
