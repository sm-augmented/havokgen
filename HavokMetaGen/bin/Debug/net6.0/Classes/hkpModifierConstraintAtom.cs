using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpModifierConstraintAtom: hkpConstraintAtom
	{
		public const string version = "0";
		public int m_modifierAtomSize { get; set; }
		public const string m_modifierAtomSize_Name = "modifierAtomSize";
		public const string m_modifierAtomSize_Type = "int";
		public int m_childSize { get; set; }
		public const string m_childSize_Name = "childSize";
		public const string m_childSize_Type = "int";
		public hkpConstraintAtom m_child { get; set; }
		public const string m_child_Name = "child";
		public const string m_child_Type = "ref";
		public int m_child_refId { get; set; }
		public const string m_child_Class = "hkpConstraintAtom";
		public List<int> m_pad { get; set; }
		public const string m_pad_Name = "pad";
		public const string m_pad_Type = "int";
		public const string m_pad_Count = "2";

	}
}
