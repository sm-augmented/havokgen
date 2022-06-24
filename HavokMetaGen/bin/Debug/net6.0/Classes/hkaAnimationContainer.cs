using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkaAnimationContainer: hkReferencedObject
	{
		public const string version = "1";
		public List<hkaSkeleton> m_skeletons { get; set; }
		public const string m_skeletons_Name = "skeletons";
		public const string m_skeletons_Type = "ref";
		public List<int> m_skeletons_refId { get; set; }
		public const string m_skeletons_Class = "hkaSkeleton";
		public const string m_skeletons_Array = "True";
		public List<hkaAnimation> m_animations { get; set; }
		public const string m_animations_Name = "animations";
		public const string m_animations_Type = "ref";
		public List<int> m_animations_refId { get; set; }
		public const string m_animations_Class = "hkaAnimation";
		public const string m_animations_Array = "True";
		public List<hkaAnimationBinding> m_bindings { get; set; }
		public const string m_bindings_Name = "bindings";
		public const string m_bindings_Type = "ref";
		public List<int> m_bindings_refId { get; set; }
		public const string m_bindings_Class = "hkaAnimationBinding";
		public const string m_bindings_Array = "True";
		public List<hkaBoneAttachment> m_attachments { get; set; }
		public const string m_attachments_Name = "attachments";
		public const string m_attachments_Type = "ref";
		public List<int> m_attachments_refId { get; set; }
		public const string m_attachments_Class = "hkaBoneAttachment";
		public const string m_attachments_Array = "True";
		public List<hkaMeshBinding> m_skins { get; set; }
		public const string m_skins_Name = "skins";
		public const string m_skins_Type = "ref";
		public List<int> m_skins_refId { get; set; }
		public const string m_skins_Class = "hkaMeshBinding";
		public const string m_skins_Array = "True";

	}
}
