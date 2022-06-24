using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbAttachmentModifier: hkbModifier
	{
		public const string version = "1";
		public hkbEventProperty m_sendToAttacherOnAttach { get; set; }
		public const string m_sendToAttacherOnAttach_Name = "sendToAttacherOnAttach";
		public const string m_sendToAttacherOnAttach_Type = "struct";
		public const string m_sendToAttacherOnAttach_Class = "hkbEventProperty";
		public hkbEventProperty m_sendToAttacheeOnAttach { get; set; }
		public const string m_sendToAttacheeOnAttach_Name = "sendToAttacheeOnAttach";
		public const string m_sendToAttacheeOnAttach_Type = "struct";
		public const string m_sendToAttacheeOnAttach_Class = "hkbEventProperty";
		public hkbEventProperty m_sendToAttacherOnDetach { get; set; }
		public const string m_sendToAttacherOnDetach_Name = "sendToAttacherOnDetach";
		public const string m_sendToAttacherOnDetach_Type = "struct";
		public const string m_sendToAttacherOnDetach_Class = "hkbEventProperty";
		public hkbEventProperty m_sendToAttacheeOnDetach { get; set; }
		public const string m_sendToAttacheeOnDetach_Name = "sendToAttacheeOnDetach";
		public const string m_sendToAttacheeOnDetach_Type = "struct";
		public const string m_sendToAttacheeOnDetach_Class = "hkbEventProperty";
		public hkbAttachmentSetup m_attachmentSetup { get; set; }
		public const string m_attachmentSetup_Name = "attachmentSetup";
		public const string m_attachmentSetup_Type = "ref";
		public int m_attachmentSetup_refId { get; set; }
		public const string m_attachmentSetup_Class = "hkbAttachmentSetup";
		public hkbHandle m_attacherHandle { get; set; }
		public const string m_attacherHandle_Name = "attacherHandle";
		public const string m_attacherHandle_Type = "ref";
		public int m_attacherHandle_refId { get; set; }
		public const string m_attacherHandle_Class = "hkbHandle";
		public hkbHandle m_attacheeHandle { get; set; }
		public const string m_attacheeHandle_Name = "attacheeHandle";
		public const string m_attacheeHandle_Type = "ref";
		public int m_attacheeHandle_refId { get; set; }
		public const string m_attacheeHandle_Class = "hkbHandle";
		public int m_attacheeLayer { get; set; }
		public const string m_attacheeLayer_Name = "attacheeLayer";
		public const string m_attacheeLayer_Type = "int";
		public byte m_oldMotionType { get; set; }
		public const string m_oldMotionType_Name = "oldMotionType";
		public const string m_oldMotionType_Type = "byte";
		public int m_oldFilterInfo { get; set; }
		public const string m_oldFilterInfo_Name = "oldFilterInfo";
		public const string m_oldFilterInfo_Type = "int";

	}
}
