using System;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Input;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels
{
	// Token: 0x020003E1 RID: 993
	public class AttributeValueEditViewModel : PopupViewModel
	{
		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x060028A3 RID: 10403 RVA: 0x0007E138 File Offset: 0x0007C338
		// (set) Token: 0x060028A4 RID: 10404 RVA: 0x0007E14C File Offset: 0x0007C34C
		public field_values Item
		{
			[CompilerGenerated]
			get
			{
				return this.<Item>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Item>k__BackingField, value))
				{
					return;
				}
				this.<Item>k__BackingField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		// Token: 0x060028A5 RID: 10405 RVA: 0x0007E17C File Offset: 0x0007C37C
		public AttributeValueEditViewModel()
		{
		}

		// Token: 0x060028A6 RID: 10406 RVA: 0x0007E190 File Offset: 0x0007C390
		public AttributeValueEditViewModel(store_items row, int id)
		{
			this._row = row;
			field_values field_values = row.Attributes.FirstOrDefault((field_values a) => a.field_id == id);
			if (field_values == null)
			{
				field_values = new field_values
				{
					field_id = id,
					item_id = new int?(row.id)
				};
				this._row.field_values.Add(field_values);
			}
			this._originalValue = field_values.value;
			this.Item = field_values;
			this.LoadAttribute(id);
		}

		// Token: 0x060028A7 RID: 10407 RVA: 0x0007E228 File Offset: 0x0007C428
		private void LoadAttribute(int id)
		{
			AttributeValueEditViewModel.<LoadAttribute>d__8 <LoadAttribute>d__;
			<LoadAttribute>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadAttribute>d__.<>4__this = this;
			<LoadAttribute>d__.id = id;
			<LoadAttribute>d__.<>1__state = -1;
			<LoadAttribute>d__.<>t__builder.Start<AttributeValueEditViewModel.<LoadAttribute>d__8>(ref <LoadAttribute>d__);
		}

		// Token: 0x060028A8 RID: 10408 RVA: 0x0007E268 File Offset: 0x0007C468
		[Command]
		public override void Close()
		{
			this.Item.value = this._originalValue;
			base.Close();
		}

		// Token: 0x060028A9 RID: 10409 RVA: 0x0007E28C File Offset: 0x0007C48C
		[Command]
		public void Save()
		{
			this._row.Attributes = new ObservableCollection<field_values>(this._row.field_values);
			base.ClosePopup();
		}

		// Token: 0x060028AA RID: 10410 RVA: 0x0007E2BC File Offset: 0x0007C4BC
		[Command]
		public void KeyUp(KeyEventArgs e)
		{
			if (e.Key == Key.Return)
			{
				this.Save();
			}
		}

		// Token: 0x0400164E RID: 5710
		private string _originalValue;

		// Token: 0x0400164F RID: 5711
		[CompilerGenerated]
		private field_values <Item>k__BackingField;

		// Token: 0x04001650 RID: 5712
		private store_items _row;

		// Token: 0x020003E2 RID: 994
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x060028AB RID: 10411 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x060028AC RID: 10412 RVA: 0x0007E2D8 File Offset: 0x0007C4D8
			internal bool <.ctor>b__0(field_values a)
			{
				return a.field_id == this.id;
			}

			// Token: 0x04001651 RID: 5713
			public int id;
		}

		// Token: 0x020003E3 RID: 995
		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x060028AD RID: 10413 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x04001652 RID: 5714
			public int id;
		}

		// Token: 0x020003E4 RID: 996
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadAttribute>d__8 : IAsyncStateMachine
		{
			// Token: 0x060028AE RID: 10414 RVA: 0x0007E2F4 File Offset: 0x0007C4F4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AttributeValueEditViewModel attributeValueEditViewModel = this.<>4__this;
				try
				{
					AttributeValueEditViewModel.<>c__DisplayClass8_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new AttributeValueEditViewModel.<>c__DisplayClass8_0();
						CS$<>8__locals1.id = this.id;
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<fields> awaiter;
						if (num != 0)
						{
							awaiter = this.<ctx>5__2.fields.FirstOrDefaultAsync((fields a) => a.id == CS$<>8__locals1.id).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<fields>, AttributeValueEditViewModel.<LoadAttribute>d__8>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<fields>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						fields result = awaiter.GetResult();
						attributeValueEditViewModel.Title = ((result != null) ? result.name : null);
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
						}
					}
					this.<ctx>5__2 = null;
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

			// Token: 0x060028AF RID: 10415 RVA: 0x0007E498 File Offset: 0x0007C698
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001653 RID: 5715
			public int <>1__state;

			// Token: 0x04001654 RID: 5716
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001655 RID: 5717
			public int id;

			// Token: 0x04001656 RID: 5718
			public AttributeValueEditViewModel <>4__this;

			// Token: 0x04001657 RID: 5719
			private auseceEntities <ctx>5__2;

			// Token: 0x04001658 RID: 5720
			private TaskAwaiter<fields> <>u__1;
		}
	}
}
