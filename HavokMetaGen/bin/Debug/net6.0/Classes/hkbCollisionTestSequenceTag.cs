using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbCollisionTestSequenceTag: hkbSequenceTag
	{
		public const string version = "0";
		public float m_testDistance { get; set; }
		public const string m_testDistance_Name = "testDistance";
		public const string m_testDistance_Type = "real";
		public List<float> m_testDirection { get; set; }
		public const string m_testDirection_Name = "testDirection";
		public const string m_testDirection_Type = "vec4";
		public byte m_testDirectionIsLocalSpace { get; set; }
		public const string m_testDirectionIsLocalSpace_Name = "testDirectionIsLocalSpace";
		public const string m_testDirectionIsLocalSpace_Type = "byte";
		public byte m_alignDirectionToGround { get; set; }
		public const string m_alignDirectionToGround_Name = "alignDirectionToGround";
		public const string m_alignDirectionToGround_Type = "byte";
		public string m_contextName { get; set; }
		public const string m_contextName_Name = "contextName";
		public const string m_contextName_Type = "string";
		public int m_didCollisionHitVariableIndex { get; set; }
		public const string m_didCollisionHitVariableIndex_Name = "didCollisionHitVariableIndex";
		public const string m_didCollisionHitVariableIndex_Type = "int";
		public int m_distanceToCollisionHitVariableIndex { get; set; }
		public const string m_distanceToCollisionHitVariableIndex_Name = "distanceToCollisionHitVariableIndex";
		public const string m_distanceToCollisionHitVariableIndex_Type = "int";
		public int m_collisionEvent { get; set; }
		public const string m_collisionEvent_Name = "collisionEvent";
		public const string m_collisionEvent_Type = "int";
		public byte m_resetOnDeactivate { get; set; }
		public const string m_resetOnDeactivate_Name = "resetOnDeactivate";
		public const string m_resetOnDeactivate_Type = "byte";
		public List<hkbCollisionTestEventPayloadFilterEntryStruct> m_filter { get; set; }
		public const string m_filter_Name = "filter";
		public const string m_filter_Type = "struct";
		public const string m_filter_Class = "hkbCollisionTestEventPayloadFilterEntryStruct";
		public const string m_filter_Array = "True";

	}
}
