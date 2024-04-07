using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using ASC.Extensions;
using NLog;

namespace ASC.Models
{
	// Token: 0x020009E3 RID: 2531
	public class Boxes : GenericModel, INotifyPropertyChanged
	{
		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06004B95 RID: 19349 RVA: 0x00133A8C File Offset: 0x00131C8C
		// (remove) Token: 0x06004B96 RID: 19350 RVA: 0x00133AC4 File Offset: 0x00131CC4
		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
			add
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
		}

		// Token: 0x17001485 RID: 5253
		// (get) Token: 0x06004B97 RID: 19351 RVA: 0x00133B00 File Offset: 0x00131D00
		// (set) Token: 0x06004B98 RID: 19352 RVA: 0x00133B14 File Offset: 0x00131D14
		public List<boxes> Boxeses
		{
			[CompilerGenerated]
			get
			{
				return this.<Boxeses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<Boxeses>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -137436089;
				IL_13:
				switch ((num ^ -221478382) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					return;
				case 2:
					IL_32:
					this.<Boxeses>k__BackingField = value;
					this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Boxeses);
					num = -1807956359;
					goto IL_13;
				}
			}
		}

		// Token: 0x06004B99 RID: 19353 RVA: 0x00133B70 File Offset: 0x00131D70
		public Boxes(int storeId = 0)
		{
			this._storeId = storeId;
			this.Init();
		}

		// Token: 0x06004B9A RID: 19354 RVA: 0x00133B90 File Offset: 0x00131D90
		public Boxes(bool withDummyBox)
		{
			this.LoadNonItemBoxes();
			if (withDummyBox)
			{
				this.Boxeses.Insert(0, new boxes
				{
					name = (string)Application.Current.TryFindResource("RemoveFromBox"),
					id = 0
				});
			}
		}

		// Token: 0x06004B9B RID: 19355 RVA: 0x00133BE0 File Offset: 0x00131DE0
		public void LoadNonItemBoxes()
		{
			using (auseceEntities auseceEntities = new auseceEntities(true))
			{
				try
				{
					this.Boxeses = (from b in auseceEntities.boxes
					where b.non_items
					select b).ToList<boxes>().OrderBy((boxes x) => x.name, new NaturalComparer()).ToList<boxes>();
				}
				catch (Exception ex)
				{
					ILogger log = GenericModel.Log;
					string str = "Load boxes error ";
					Exception ex2 = ex;
					log.Error(str + ((ex2 != null) ? ex2.ToString() : null));
				}
			}
		}

		// Token: 0x06004B9C RID: 19356 RVA: 0x00133CC0 File Offset: 0x00131EC0
		private boxes SearchBox(string boxName)
		{
			boxes result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					result = auseceEntities.boxes.FirstOrDefault((boxes b) => b.name == boxName && b.store_id == (int?)this._storeId);
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Search box fail");
				result = null;
			}
			return result;
		}

		// Token: 0x06004B9D RID: 19357 RVA: 0x00133DE0 File Offset: 0x00131FE0
		public boxes CreateBoxManualHistory(string name)
		{
			boxes boxes = this.SearchBox(name);
			if (boxes != null)
			{
				return boxes;
			}
			boxes result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					boxes = new boxes
					{
						name = name,
						store_id = new int?(this._storeId)
					};
					auseceEntities.boxes.Add(boxes);
					if (this._store != null)
					{
						HistoryV2 historyV = new HistoryV2();
						historyV.Add(34, new string[]
						{
							name,
							this._store.name
						});
						historyV.Save();
					}
					auseceEntities.SaveChanges();
					result = boxes;
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Create box fail");
				result = null;
			}
			return result;
		}

		// Token: 0x06004B9E RID: 19358 RVA: 0x00133EAC File Offset: 0x001320AC
		public void SaveHistory()
		{
			this._history.Save();
		}

		// Token: 0x06004B9F RID: 19359 RVA: 0x00133EC4 File Offset: 0x001320C4
		private void Init()
		{
			this._store = this._context.stores.FirstOrDefault((stores s) => s.id == this._storeId);
			List<boxes> boxeses;
			if (this._storeId != 0)
			{
				boxeses = (from b in this._context.boxes
				where b.store_id == (int?)this._storeId && b.non_items == false
				select b).ToListSafe<boxes>().OrderBy((boxes x) => x.name, new NaturalComparer()).ToList<boxes>();
			}
			else
			{
				boxeses = (from b in this._context.boxes
				where b.non_items == false
				select b).ToListSafe<boxes>().OrderBy((boxes x) => x.name, new NaturalComparer()).ToList<boxes>();
			}
			this.Boxeses = boxeses;
		}

		// Token: 0x06004BA0 RID: 19360 RVA: 0x001340D4 File Offset: 0x001322D4
		public void Refresh()
		{
			this.Init();
		}

		// Token: 0x06004BA1 RID: 19361 RVA: 0x001340E8 File Offset: 0x001322E8
		[GeneratedCode("PropertyChanged.Fody", "3.1.3.0")]
		[DebuggerNonUserCode]
		protected void <>OnPropertyChanged(PropertyChangedEventArgs eventArgs)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, eventArgs);
			}
		}

		// Token: 0x040030C0 RID: 12480
		[CompilerGenerated]
		private PropertyChangedEventHandler PropertyChanged;

		// Token: 0x040030C1 RID: 12481
		private int _storeId;

		// Token: 0x040030C2 RID: 12482
		private stores _store;

		// Token: 0x040030C3 RID: 12483
		[CompilerGenerated]
		private List<boxes> <Boxeses>k__BackingField;

		// Token: 0x020009E4 RID: 2532
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004BA2 RID: 19362 RVA: 0x0013410C File Offset: 0x0013230C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004BA3 RID: 19363 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06004BA4 RID: 19364 RVA: 0x000D14F8 File Offset: 0x000CF6F8
			internal string <LoadNonItemBoxes>b__11_1(boxes x)
			{
				return x.name;
			}

			// Token: 0x06004BA5 RID: 19365 RVA: 0x000D14F8 File Offset: 0x000CF6F8
			internal string <Init>b__15_2(boxes x)
			{
				return x.name;
			}

			// Token: 0x06004BA6 RID: 19366 RVA: 0x000D14F8 File Offset: 0x000CF6F8
			internal string <Init>b__15_4(boxes x)
			{
				return x.name;
			}

			// Token: 0x040030C4 RID: 12484
			public static readonly Boxes.<>c <>9 = new Boxes.<>c();

			// Token: 0x040030C5 RID: 12485
			public static Func<boxes, string> <>9__11_1;

			// Token: 0x040030C6 RID: 12486
			public static Func<boxes, string> <>9__15_2;

			// Token: 0x040030C7 RID: 12487
			public static Func<boxes, string> <>9__15_4;
		}

		// Token: 0x020009E5 RID: 2533
		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x06004BA7 RID: 19367 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x040030C8 RID: 12488
			public string boxName;

			// Token: 0x040030C9 RID: 12489
			public Boxes <>4__this;
		}
	}
}
