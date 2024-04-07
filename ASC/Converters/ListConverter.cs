using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ASC.Converters
{
	// Token: 0x02000BD6 RID: 3030
	public class ListConverter<I, T> : JsonConverter
	{
		// Token: 0x170015AB RID: 5547
		// (get) Token: 0x0600548B RID: 21643 RVA: 0x000304B4 File Offset: 0x0002E6B4
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170015AC RID: 5548
		// (get) Token: 0x0600548C RID: 21644 RVA: 0x0007E5F4 File Offset: 0x0007C7F4
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600548D RID: 21645 RVA: 0x0016BC10 File Offset: 0x00169E10
		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(I);
		}

		// Token: 0x0600548E RID: 21646 RVA: 0x0016BC30 File Offset: 0x00169E30
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			throw new InvalidOperationException("Use default serialization.");
		}

		// Token: 0x0600548F RID: 21647 RVA: 0x0016BCA0 File Offset: 0x00169EA0
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			JArray jarray = JArray.Load(reader);
			List<T> list = (List<T>)Activator.CreateInstance(typeof(List<T>));
			serializer.Populate(jarray.CreateReader(), list);
			return list.OfType<I>().ToList<I>();
		}

		// Token: 0x06005490 RID: 21648 RVA: 0x0016BC8C File Offset: 0x00169E8C
		public ListConverter()
		{
		}
	}
}
