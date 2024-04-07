using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ASC.Converters
{
	// Token: 0x02000BD5 RID: 3029
	public class ConfigConverter<I, T> : JsonConverter
	{
		// Token: 0x170015A9 RID: 5545
		// (get) Token: 0x06005485 RID: 21637 RVA: 0x000304B4 File Offset: 0x0002E6B4
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170015AA RID: 5546
		// (get) Token: 0x06005486 RID: 21638 RVA: 0x0007E5F4 File Offset: 0x0007C7F4
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06005487 RID: 21639 RVA: 0x0016BC10 File Offset: 0x00169E10
		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(I);
		}

		// Token: 0x06005488 RID: 21640 RVA: 0x0016BC30 File Offset: 0x00169E30
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			throw new InvalidOperationException("Use default serialization.");
		}

		// Token: 0x06005489 RID: 21641 RVA: 0x0016BC48 File Offset: 0x00169E48
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			JObject jobject = JObject.Load(reader);
			T t = (T)((object)Activator.CreateInstance(typeof(T)));
			serializer.Populate(jobject.CreateReader(), t);
			return t;
		}

		// Token: 0x0600548A RID: 21642 RVA: 0x0016BC8C File Offset: 0x00169E8C
		public ConfigConverter()
		{
		}
	}
}
