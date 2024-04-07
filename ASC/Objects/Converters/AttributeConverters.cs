using System;
using ASC.Common.Interfaces;
using ASC.ViewModel;

namespace ASC.Objects.Converters
{
	// Token: 0x0200091F RID: 2335
	public static class AttributeConverters
	{
		// Token: 0x0600481D RID: 18461 RVA: 0x00119B44 File Offset: 0x00117D44
		public static IAttribute ToUserField(this field_values f)
		{
			AttributeBase attributeBase = new AttributeBase();
			attributeBase.Id = f.id;
			attributeBase.FieldId = f.field_id;
			fields fields = f.fields;
			attributeBase.FieldName = ((fields != null) ? fields.name : null);
			fields fields2 = f.fields;
			attributeBase.Required = (fields2 != null && fields2.required);
			fields fields3 = f.fields;
			attributeBase.Printable = (fields3 != null && fields3.printable);
			attributeBase.Text = f.value;
			return attributeBase;
		}
	}
}
