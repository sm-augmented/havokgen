using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbVariableBindingSetBinding
	{
		public const string version = "1";
		public string m_memberPath { get; set; }
		public const string m_memberPath_Name = "memberPath";
		public const string m_memberPath_Type = "string";
		public int m_offsetInObjectPlusOne { get; set; }
		public const string m_offsetInObjectPlusOne_Name = "offsetInObjectPlusOne";
		public const string m_offsetInObjectPlusOne_Type = "int";
		public int m_offsetInArrayPlusOne { get; set; }
		public const string m_offsetInArrayPlusOne_Name = "offsetInArrayPlusOne";
		public const string m_offsetInArrayPlusOne_Type = "int";
		public int m_rootVariableIndex { get; set; }
		public const string m_rootVariableIndex_Name = "rootVariableIndex";
		public const string m_rootVariableIndex_Type = "int";
		public int m_variableIndex { get; set; }
		public const string m_variableIndex_Name = "variableIndex";
		public const string m_variableIndex_Type = "int";
		public int m_bitIndex { get; set; }
		public const string m_bitIndex_Name = "bitIndex";
		public const string m_bitIndex_Type = "int";
		public int m_bindingType { get; set; }
		public const string m_bindingType_Name = "bindingType";
		public const string m_bindingType_Type = "int";
		public byte m_memberType { get; set; }
		public const string m_memberType_Name = "memberType";
		public const string m_memberType_Type = "byte";
		public int m_variableType { get; set; }
		public const string m_variableType_Name = "variableType";
		public const string m_variableType_Type = "int";
		public int m_flags { get; set; }
		public const string m_flags_Name = "flags";
		public const string m_flags_Type = "int";

	}
}
