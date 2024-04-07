using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using ASC.Common.Interfaces;
using ASC.Services.Abstract;
using Autofac;
using DevExpress.DataProcessing;

namespace ASC.ViewModels.ItemCard
{
	// Token: 0x020004B7 RID: 1207
	public class ProductAttributesViewModel : BaseViewModel, IProductAttributesViewModel
	{
		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x06002ED2 RID: 11986 RVA: 0x00099058 File Offset: 0x00097258
		// (set) Token: 0x06002ED3 RID: 11987 RVA: 0x0009906C File Offset: 0x0009726C
		public ObservableCollection<IAttribute> Items
		{
			[CompilerGenerated]
			get
			{
				return this.<Items>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Items>k__BackingField, value))
				{
					return;
				}
				this.<Items>k__BackingField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		// Token: 0x06002ED4 RID: 11988 RVA: 0x0009909C File Offset: 0x0009729C
		public ProductAttributesViewModel()
		{
			this._additionalFieldsService = Bootstrapper.Container.Resolve<IAdditionalFieldsService>();
			this.Items = new ObservableCollection<IAttribute>();
		}

		// Token: 0x06002ED5 RID: 11989 RVA: 0x000990CC File Offset: 0x000972CC
		public void LoadItems(int itemId, bool readOnly)
		{
			ProductAttributesViewModel.<LoadItems>d__6 <LoadItems>d__;
			<LoadItems>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadItems>d__.<>4__this = this;
			<LoadItems>d__.itemId = itemId;
			<LoadItems>d__.readOnly = readOnly;
			<LoadItems>d__.<>1__state = -1;
			<LoadItems>d__.<>t__builder.Start<ProductAttributesViewModel.<LoadItems>d__6>(ref <LoadItems>d__);
		}

		// Token: 0x06002ED6 RID: 11990 RVA: 0x00099114 File Offset: 0x00097314
		public void LoadItemsByCategory(int categoryId)
		{
			ProductAttributesViewModel.<LoadItemsByCategory>d__7 <LoadItemsByCategory>d__;
			<LoadItemsByCategory>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadItemsByCategory>d__.<>4__this = this;
			<LoadItemsByCategory>d__.categoryId = categoryId;
			<LoadItemsByCategory>d__.<>1__state = -1;
			<LoadItemsByCategory>d__.<>t__builder.Start<ProductAttributesViewModel.<LoadItemsByCategory>d__7>(ref <LoadItemsByCategory>d__);
		}

		// Token: 0x06002ED7 RID: 11991 RVA: 0x00099154 File Offset: 0x00097354
		public void SetAttributes(IEnumerable<IAttribute> a)
		{
			this.Items.Clear();
			this.Items.AddRange(a);
		}

		// Token: 0x06002ED8 RID: 11992 RVA: 0x00099178 File Offset: 0x00097378
		public void Save()
		{
			ProductAttributesViewModel.<Save>d__9 <Save>d__;
			<Save>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Save>d__.<>1__state = -1;
			<Save>d__.<>t__builder.Start<ProductAttributesViewModel.<Save>d__9>(ref <Save>d__);
		}

		// Token: 0x04001A5B RID: 6747
		private readonly IAdditionalFieldsService _additionalFieldsService;

		// Token: 0x04001A5C RID: 6748
		[CompilerGenerated]
		private ObservableCollection<IAttribute> <Items>k__BackingField;

		// Token: 0x020004B8 RID: 1208
		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x06002ED9 RID: 11993 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x06002EDA RID: 11994 RVA: 0x000991A8 File Offset: 0x000973A8
			internal void <LoadItems>b__0()
			{
				this.<>4__this.Items.Clear();
			}

			// Token: 0x06002EDB RID: 11995 RVA: 0x000991C8 File Offset: 0x000973C8
			internal void <LoadItems>b__1()
			{
				this.<>4__this.Items.AddRange(this.result);
			}

			// Token: 0x04001A5D RID: 6749
			public ProductAttributesViewModel <>4__this;

			// Token: 0x04001A5E RID: 6750
			public List<IAttribute> result;
		}

		// Token: 0x020004B9 RID: 1209
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadItems>d__6 : IAsyncStateMachine
		{
			// Token: 0x06002EDC RID: 11996 RVA: 0x000991EC File Offset: 0x000973EC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ProductAttributesViewModel productAttributesViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter<List<IAttribute>> awaiter2;
					switch (num)
					{
					case 0:
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						int num2 = -1;
						num = -1;
						this.<>1__state = num2;
						break;
					}
					case 1:
					{
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<List<IAttribute>>);
						int num3 = -1;
						num = -1;
						this.<>1__state = num3;
						goto IL_116;
					}
					case 2:
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						int num4 = -1;
						num = -1;
						this.<>1__state = num4;
						goto IL_20B;
					}
					default:
						this.<>8__1 = new ProductAttributesViewModel.<>c__DisplayClass6_0();
						this.<>8__1.<>4__this = this.<>4__this;
						awaiter = Application.Current.Dispatcher.BeginInvoke(new Action(this.<>8__1.<LoadItems>b__0), new object[0]).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num5 = 0;
							num = 0;
							this.<>1__state = num5;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ProductAttributesViewModel.<LoadItems>d__6>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					awaiter2 = productAttributesViewModel._additionalFieldsService.GetProductUiFields(this.itemId).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						int num6 = 1;
						num = 1;
						this.<>1__state = num6;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<IAttribute>>, ProductAttributesViewModel.<LoadItems>d__6>(ref awaiter2, ref this);
						return;
					}
					IL_116:
					List<IAttribute> result = awaiter2.GetResult();
					this.<>8__1.result = new List<IAttribute>();
					List<IAttribute>.Enumerator enumerator = result.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							IAttribute attribute = enumerator.Current;
							if (!this.readOnly || !string.IsNullOrEmpty(attribute.Text))
							{
								attribute.SetIsReadOnly(this.readOnly);
								attribute.SetShowCaption(true);
								this.<>8__1.result.Add(attribute);
							}
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator).Dispose();
						}
					}
					awaiter = Application.Current.Dispatcher.BeginInvoke(new Action(this.<>8__1.<LoadItems>b__1), new object[0]).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num7 = 2;
						num = 2;
						this.<>1__state = num7;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ProductAttributesViewModel.<LoadItems>d__6>(ref awaiter, ref this);
						return;
					}
					IL_20B:
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002EDD RID: 11997 RVA: 0x0009947C File Offset: 0x0009767C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001A5F RID: 6751
			public int <>1__state;

			// Token: 0x04001A60 RID: 6752
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001A61 RID: 6753
			public ProductAttributesViewModel <>4__this;

			// Token: 0x04001A62 RID: 6754
			public int itemId;

			// Token: 0x04001A63 RID: 6755
			private ProductAttributesViewModel.<>c__DisplayClass6_0 <>8__1;

			// Token: 0x04001A64 RID: 6756
			public bool readOnly;

			// Token: 0x04001A65 RID: 6757
			private TaskAwaiter <>u__1;

			// Token: 0x04001A66 RID: 6758
			private TaskAwaiter<List<IAttribute>> <>u__2;
		}

		// Token: 0x020004BA RID: 1210
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x06002EDE RID: 11998 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x06002EDF RID: 11999 RVA: 0x00099498 File Offset: 0x00097698
			internal Task<List<IAttribute>> <LoadItemsByCategory>b__0()
			{
				return this.<>4__this._additionalFieldsService.GetProductUiFieldsByCategory(this.categoryId);
			}

			// Token: 0x04001A67 RID: 6759
			public ProductAttributesViewModel <>4__this;

			// Token: 0x04001A68 RID: 6760
			public int categoryId;
		}

		// Token: 0x020004BB RID: 1211
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadItemsByCategory>d__7 : IAsyncStateMachine
		{
			// Token: 0x06002EE0 RID: 12000 RVA: 0x000994BC File Offset: 0x000976BC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ProductAttributesViewModel productAttributesViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<IAttribute>> awaiter;
					if (num != 0)
					{
						ProductAttributesViewModel.<>c__DisplayClass7_0 CS$<>8__locals1 = new ProductAttributesViewModel.<>c__DisplayClass7_0();
						CS$<>8__locals1.<>4__this = this.<>4__this;
						CS$<>8__locals1.categoryId = this.categoryId;
						productAttributesViewModel.Items.Clear();
						awaiter = Task.Run<List<IAttribute>>(new Func<Task<List<IAttribute>>>(CS$<>8__locals1.<LoadItemsByCategory>b__0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.<>1__state = num2;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<IAttribute>>, ProductAttributesViewModel.<LoadItemsByCategory>d__7>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<IAttribute>>);
						int num3 = -1;
						num = -1;
						this.<>1__state = num3;
					}
					List<IAttribute>.Enumerator enumerator = awaiter.GetResult().GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							IAttribute attribute = enumerator.Current;
							attribute.SetShowCaption(true);
							productAttributesViewModel.Items.Add(attribute);
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator).Dispose();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002EE1 RID: 12001 RVA: 0x000995F8 File Offset: 0x000977F8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001A69 RID: 6761
			public int <>1__state;

			// Token: 0x04001A6A RID: 6762
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001A6B RID: 6763
			public ProductAttributesViewModel <>4__this;

			// Token: 0x04001A6C RID: 6764
			public int categoryId;

			// Token: 0x04001A6D RID: 6765
			private TaskAwaiter<List<IAttribute>> <>u__1;
		}

		// Token: 0x020004BC RID: 1212
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Save>d__9 : IAsyncStateMachine
		{
			// Token: 0x06002EE2 RID: 12002 RVA: 0x00099614 File Offset: 0x00097814
			void IAsyncStateMachine.MoveNext()
			{
				try
				{
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002EE3 RID: 12003 RVA: 0x00099660 File Offset: 0x00097860
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001A6E RID: 6766
			public int <>1__state;

			// Token: 0x04001A6F RID: 6767
			public AsyncVoidMethodBuilder <>t__builder;
		}
	}
}
