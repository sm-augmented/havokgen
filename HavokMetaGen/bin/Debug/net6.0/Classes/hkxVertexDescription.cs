using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkxVertexDescription
	{
		public const string version = "1";
		public List<hkxVertexDescriptionElementDecl> m_decls { get; set; }
		public const string m_decls_Name = "decls";
		public const string m_decls_Type = "struct";
		public const string m_decls_Class = "hkxVertexDescriptionElementDecl";
		public const string m_decls_Array = "True";

	}
}
