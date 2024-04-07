using System;
using System.Reflection;

namespace Poly
{
	// Token: 0x02000016 RID: 22
	public static class Reflection
	{
		// Token: 0x06000089 RID: 137 RVA: 0x00003D70 File Offset: 0x00001F70
		public static void CopyProperties(this object source, object destination)
		{
			if (source != null && destination != null)
			{
				Type type = destination.GetType();
				foreach (PropertyInfo propertyInfo in source.GetType().GetProperties())
				{
					if (propertyInfo.CanRead)
					{
						PropertyInfo property = type.GetProperty(propertyInfo.Name);
						if (!(property == null) && property.CanWrite && (!(property.GetSetMethod(true) != null) || !property.GetSetMethod(true).IsPrivate) && (property.GetSetMethod().Attributes & MethodAttributes.Static) == MethodAttributes.PrivateScope && property.PropertyType.IsAssignableFrom(propertyInfo.PropertyType))
						{
							property.SetValue(destination, propertyInfo.GetValue(source, null), null);
						}
					}
				}
				return;
			}
			throw new Exception("Source or/and Destination Objects are null");
		}
	}
}
