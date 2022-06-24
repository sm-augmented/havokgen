using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbTransitionEffect: hkbGenerator
	{
		public const string version = "1";
		public int m_selfTransitionMode { get; set; }
		public const string m_selfTransitionMode_Name = "selfTransitionMode";
		public const string m_selfTransitionMode_Type = "int";
		public int m_eventMode { get; set; }
		public const string m_eventMode_Name = "eventMode";
		public const string m_eventMode_Type = "int";
		public int m_branchInId { get; set; }
		public const string m_branchInId_Name = "branchInId";
		public const string m_branchInId_Type = "int";
		public int m_syncBranchId { get; set; }
		public const string m_syncBranchId_Name = "syncBranchId";
		public const string m_syncBranchId_Type = "int";
		public byte m_invertSyncFraction { get; set; }
		public const string m_invertSyncFraction_Name = "invertSyncFraction";
		public const string m_invertSyncFraction_Type = "byte";
		public int m_defaultEventMode { get; set; }
		public const string m_defaultEventMode_Name = "defaultEventMode";
		public const string m_defaultEventMode_Type = "int";
		public float m_interactionPortFraction { get; set; }
		public const string m_interactionPortFraction_Name = "interactionPortFraction";
		public const string m_interactionPortFraction_Type = "real";

	}
}
