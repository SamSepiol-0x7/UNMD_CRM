using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.DAL;
using ASC.Services.Abstract;
using ASC.ViewModel;
using ASC.ViewModels.Attributes;
using MySql.Data.MySqlClient;

namespace ASC.Services.Concrete
{
	// Token: 0x020006BD RID: 1725
	public class AdditionalFieldsService : IAdditionalFieldsService
	{
		// Token: 0x06003936 RID: 14646 RVA: 0x000D41B0 File Offset: 0x000D23B0
		public AdditionalFieldsService(IContextFactory contextFactory)
		{
			this._contextFactory = contextFactory;
		}

		// Token: 0x06003937 RID: 14647 RVA: 0x000D41CC File Offset: 0x000D23CC
		public Task<int> CreateAdditionalField(fields field)
		{
			AdditionalFieldsService.<CreateAdditionalField>d__2 <CreateAdditionalField>d__;
			<CreateAdditionalField>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<CreateAdditionalField>d__.<>4__this = this;
			<CreateAdditionalField>d__.field = field;
			<CreateAdditionalField>d__.<>1__state = -1;
			<CreateAdditionalField>d__.<>t__builder.Start<AdditionalFieldsService.<CreateAdditionalField>d__2>(ref <CreateAdditionalField>d__);
			return <CreateAdditionalField>d__.<>t__builder.Task;
		}

		// Token: 0x06003938 RID: 14648 RVA: 0x000D4218 File Offset: 0x000D2418
		public Task UpdateAdditionalField(fields field)
		{
			AdditionalFieldsService.<UpdateAdditionalField>d__3 <UpdateAdditionalField>d__;
			<UpdateAdditionalField>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<UpdateAdditionalField>d__.<>4__this = this;
			<UpdateAdditionalField>d__.field = field;
			<UpdateAdditionalField>d__.<>1__state = -1;
			<UpdateAdditionalField>d__.<>t__builder.Start<AdditionalFieldsService.<UpdateAdditionalField>d__3>(ref <UpdateAdditionalField>d__);
			return <UpdateAdditionalField>d__.<>t__builder.Task;
		}

		// Token: 0x06003939 RID: 14649 RVA: 0x000D4264 File Offset: 0x000D2464
		public Task<List<fields>> GetAdditionalFields(bool? isStoreItemField, bool showArchive = false)
		{
			AdditionalFieldsService.<GetAdditionalFields>d__4 <GetAdditionalFields>d__;
			<GetAdditionalFields>d__.<>t__builder = AsyncTaskMethodBuilder<List<fields>>.Create();
			<GetAdditionalFields>d__.<>4__this = this;
			<GetAdditionalFields>d__.isStoreItemField = isStoreItemField;
			<GetAdditionalFields>d__.showArchive = showArchive;
			<GetAdditionalFields>d__.<>1__state = -1;
			<GetAdditionalFields>d__.<>t__builder.Start<AdditionalFieldsService.<GetAdditionalFields>d__4>(ref <GetAdditionalFields>d__);
			return <GetAdditionalFields>d__.<>t__builder.Task;
		}

		// Token: 0x0600393A RID: 14650 RVA: 0x000D42B8 File Offset: 0x000D24B8
		private Task<List<fields>> GetDeviceAttributes(int deviceId)
		{
			AdditionalFieldsService.<GetDeviceAttributes>d__5 <GetDeviceAttributes>d__;
			<GetDeviceAttributes>d__.<>t__builder = AsyncTaskMethodBuilder<List<fields>>.Create();
			<GetDeviceAttributes>d__.<>4__this = this;
			<GetDeviceAttributes>d__.deviceId = deviceId;
			<GetDeviceAttributes>d__.<>1__state = -1;
			<GetDeviceAttributes>d__.<>t__builder.Start<AdditionalFieldsService.<GetDeviceAttributes>d__5>(ref <GetDeviceAttributes>d__);
			return <GetDeviceAttributes>d__.<>t__builder.Task;
		}

		// Token: 0x0600393B RID: 14651 RVA: 0x000D4304 File Offset: 0x000D2504
		private Task<IEnumerable<fields>> GetProductAttributes(int productId)
		{
			AdditionalFieldsService.<GetProductAttributes>d__6 <GetProductAttributes>d__;
			<GetProductAttributes>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<fields>>.Create();
			<GetProductAttributes>d__.productId = productId;
			<GetProductAttributes>d__.<>1__state = -1;
			<GetProductAttributes>d__.<>t__builder.Start<AdditionalFieldsService.<GetProductAttributes>d__6>(ref <GetProductAttributes>d__);
			return <GetProductAttributes>d__.<>t__builder.Task;
		}

		// Token: 0x0600393C RID: 14652 RVA: 0x000D4348 File Offset: 0x000D2548
		private static Task<IEnumerable<fields>> GetProductAttributesByCategory(auseceEntities ctx, int categoryId)
		{
			AdditionalFieldsService.<GetProductAttributesByCategory>d__7 <GetProductAttributesByCategory>d__;
			<GetProductAttributesByCategory>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<fields>>.Create();
			<GetProductAttributesByCategory>d__.ctx = ctx;
			<GetProductAttributesByCategory>d__.categoryId = categoryId;
			<GetProductAttributesByCategory>d__.<>1__state = -1;
			<GetProductAttributesByCategory>d__.<>t__builder.Start<AdditionalFieldsService.<GetProductAttributesByCategory>d__7>(ref <GetProductAttributesByCategory>d__);
			return <GetProductAttributesByCategory>d__.<>t__builder.Task;
		}

		// Token: 0x0600393D RID: 14653 RVA: 0x000D4394 File Offset: 0x000D2594
		public Task<bool> AdditionalFieldsExist(bool isStoreItemField)
		{
			AdditionalFieldsService.<AdditionalFieldsExist>d__8 <AdditionalFieldsExist>d__;
			<AdditionalFieldsExist>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<AdditionalFieldsExist>d__.<>4__this = this;
			<AdditionalFieldsExist>d__.isStoreItemField = isStoreItemField;
			<AdditionalFieldsExist>d__.<>1__state = -1;
			<AdditionalFieldsExist>d__.<>t__builder.Start<AdditionalFieldsService.<AdditionalFieldsExist>d__8>(ref <AdditionalFieldsExist>d__);
			return <AdditionalFieldsExist>d__.<>t__builder.Task;
		}

		// Token: 0x0600393E RID: 14654 RVA: 0x000D43E0 File Offset: 0x000D25E0
		public Task<List<object>> GetDeviceFields(int deviceId)
		{
			AdditionalFieldsService.<GetDeviceFields>d__9 <GetDeviceFields>d__;
			<GetDeviceFields>d__.<>t__builder = AsyncTaskMethodBuilder<List<object>>.Create();
			<GetDeviceFields>d__.<>4__this = this;
			<GetDeviceFields>d__.deviceId = deviceId;
			<GetDeviceFields>d__.<>1__state = -1;
			<GetDeviceFields>d__.<>t__builder.Start<AdditionalFieldsService.<GetDeviceFields>d__9>(ref <GetDeviceFields>d__);
			return <GetDeviceFields>d__.<>t__builder.Task;
		}

		// Token: 0x0600393F RID: 14655 RVA: 0x000D442C File Offset: 0x000D262C
		public Task<List<IAttribute>> GetDeviceUiFields(IEnumerable<field_values> values, int deviceId)
		{
			AdditionalFieldsService.<GetDeviceUiFields>d__10 <GetDeviceUiFields>d__;
			<GetDeviceUiFields>d__.<>t__builder = AsyncTaskMethodBuilder<List<IAttribute>>.Create();
			<GetDeviceUiFields>d__.<>4__this = this;
			<GetDeviceUiFields>d__.values = values;
			<GetDeviceUiFields>d__.deviceId = deviceId;
			<GetDeviceUiFields>d__.<>1__state = -1;
			<GetDeviceUiFields>d__.<>t__builder.Start<AdditionalFieldsService.<GetDeviceUiFields>d__10>(ref <GetDeviceUiFields>d__);
			return <GetDeviceUiFields>d__.<>t__builder.Task;
		}

		// Token: 0x06003940 RID: 14656 RVA: 0x000D4480 File Offset: 0x000D2680
		private static List<IAttribute> GetUiFields(IEnumerable<field_values> values, IEnumerable<fields> fields)
		{
			List<IAttribute> list = new List<IAttribute>();
			using (IEnumerator<fields> enumerator = fields.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					fields field = enumerator.Current;
					string text = (from v in values.Where(delegate(field_values v)
					{
						if (v.fields != null)
						{
							if (v.fields.type == field.type)
							{
								return v.field_id == field.id;
							}
						}
						return false;
					})
					select v.value).DefaultIfEmpty<string>().FirstOrDefault<string>();
					if (field.type == 1)
					{
						list.Add(new PanelViewModel(field)
						{
							Text = text
						});
					}
					if (field.type == 2)
					{
						list.Add(new ComboBoxViewModel(field)
						{
							Text = text
						});
					}
					if (field.type == 3)
					{
						list.Add(new DatePickerViewModel(field)
						{
							Text = text
						});
					}
					if (field.type == 4)
					{
						list.Add(new IntegerViewModel(field)
						{
							Text = text
						});
					}
				}
			}
			return list;
		}

		// Token: 0x06003941 RID: 14657 RVA: 0x000D45C4 File Offset: 0x000D27C4
		public Task<List<IAttribute>> GetProductUiFields(int productId)
		{
			AdditionalFieldsService.<GetProductUiFields>d__12 <GetProductUiFields>d__;
			<GetProductUiFields>d__.<>t__builder = AsyncTaskMethodBuilder<List<IAttribute>>.Create();
			<GetProductUiFields>d__.<>4__this = this;
			<GetProductUiFields>d__.productId = productId;
			<GetProductUiFields>d__.<>1__state = -1;
			<GetProductUiFields>d__.<>t__builder.Start<AdditionalFieldsService.<GetProductUiFields>d__12>(ref <GetProductUiFields>d__);
			return <GetProductUiFields>d__.<>t__builder.Task;
		}

		// Token: 0x06003942 RID: 14658 RVA: 0x000D4610 File Offset: 0x000D2810
		public Task<List<IAttribute>> GetProductUiFieldsByCategory(int categoryId)
		{
			AdditionalFieldsService.<GetProductUiFieldsByCategory>d__13 <GetProductUiFieldsByCategory>d__;
			<GetProductUiFieldsByCategory>d__.<>t__builder = AsyncTaskMethodBuilder<List<IAttribute>>.Create();
			<GetProductUiFieldsByCategory>d__.categoryId = categoryId;
			<GetProductUiFieldsByCategory>d__.<>1__state = -1;
			<GetProductUiFieldsByCategory>d__.<>t__builder.Start<AdditionalFieldsService.<GetProductUiFieldsByCategory>d__13>(ref <GetProductUiFieldsByCategory>d__);
			return <GetProductUiFieldsByCategory>d__.<>t__builder.Task;
		}

		// Token: 0x06003943 RID: 14659 RVA: 0x000D4654 File Offset: 0x000D2854
		public List<object> GetDeviceAttributesReadonly(IEnumerable<field_values> values)
		{
			List<object> list = new List<object>();
			foreach (field_values field_values in values)
			{
				if (field_values.fields != null)
				{
					list.Add(new AdditionalFieldAsLabelViewModel(field_values.fields, field_values));
				}
			}
			return list;
		}

		// Token: 0x06003944 RID: 14660 RVA: 0x000D46B8 File Offset: 0x000D28B8
		public Task UpdateAdditionalFields(int repairId, IEnumerable<object> fields)
		{
			AdditionalFieldsService.<UpdateAdditionalFields>d__15 <UpdateAdditionalFields>d__;
			<UpdateAdditionalFields>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<UpdateAdditionalFields>d__.<>4__this = this;
			<UpdateAdditionalFields>d__.repairId = repairId;
			<UpdateAdditionalFields>d__.fields = fields;
			<UpdateAdditionalFields>d__.<>1__state = -1;
			<UpdateAdditionalFields>d__.<>t__builder.Start<AdditionalFieldsService.<UpdateAdditionalFields>d__15>(ref <UpdateAdditionalFields>d__);
			return <UpdateAdditionalFields>d__.<>t__builder.Task;
		}

		// Token: 0x0400235E RID: 9054
		private readonly IContextFactory _contextFactory;

		// Token: 0x020006BE RID: 1726
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateAdditionalField>d__2 : IAsyncStateMachine
		{
			// Token: 0x06003945 RID: 14661 RVA: 0x000D470C File Offset: 0x000D290C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AdditionalFieldsService additionalFieldsService = this.<>4__this;
				int id;
				try
				{
					if (num != 0)
					{
						this.<ctx>5__2 = additionalFieldsService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<int> awaiter;
						if (num != 0)
						{
							this.<ctx>5__2.fields.Add(this.field);
							awaiter = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, AdditionalFieldsService.<CreateAdditionalField>d__2>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<int>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						awaiter.GetResult();
						id = this.field.id;
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
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
				this.<>t__builder.SetResult(id);
			}

			// Token: 0x06003946 RID: 14662 RVA: 0x000D4824 File Offset: 0x000D2A24
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400235F RID: 9055
			public int <>1__state;

			// Token: 0x04002360 RID: 9056
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x04002361 RID: 9057
			public AdditionalFieldsService <>4__this;

			// Token: 0x04002362 RID: 9058
			public fields field;

			// Token: 0x04002363 RID: 9059
			private auseceEntities <ctx>5__2;

			// Token: 0x04002364 RID: 9060
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x020006BF RID: 1727
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateAdditionalField>d__3 : IAsyncStateMachine
		{
			// Token: 0x06003947 RID: 14663 RVA: 0x000D4840 File Offset: 0x000D2A40
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AdditionalFieldsService additionalFieldsService = this.<>4__this;
				try
				{
					if (num != 0)
					{
						this.<ctx>5__2 = additionalFieldsService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<int> awaiter;
						if (num != 0)
						{
							this.<ctx>5__2.fields.Attach(this.field);
							this.<ctx>5__2.Entry<fields>(this.field).State = EntityState.Modified;
							this.field.updated_at = new DateTime?(DateTime.UtcNow);
							awaiter = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, AdditionalFieldsService.<UpdateAdditionalField>d__3>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<int>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						awaiter.GetResult();
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

			// Token: 0x06003948 RID: 14664 RVA: 0x000D4980 File Offset: 0x000D2B80
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002365 RID: 9061
			public int <>1__state;

			// Token: 0x04002366 RID: 9062
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002367 RID: 9063
			public AdditionalFieldsService <>4__this;

			// Token: 0x04002368 RID: 9064
			public fields field;

			// Token: 0x04002369 RID: 9065
			private auseceEntities <ctx>5__2;

			// Token: 0x0400236A RID: 9066
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x020006C0 RID: 1728
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06003949 RID: 14665 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x0400236B RID: 9067
			public bool? isStoreItemField;
		}

		// Token: 0x020006C1 RID: 1729
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600394A RID: 14666 RVA: 0x000D499C File Offset: 0x000D2B9C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600394B RID: 14667 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0600394C RID: 14668 RVA: 0x000D49B4 File Offset: 0x000D2BB4
			internal string <GetUiFields>b__11_1(field_values v)
			{
				return v.value;
			}

			// Token: 0x0600394D RID: 14669 RVA: 0x000D49C8 File Offset: 0x000D2BC8
			internal field_values <GetProductUiFieldsByCategory>b__13_0(fields attribute)
			{
				return new field_values
				{
					field_id = attribute.id
				};
			}

			// Token: 0x0400236C RID: 9068
			public static readonly AdditionalFieldsService.<>c <>9 = new AdditionalFieldsService.<>c();

			// Token: 0x0400236D RID: 9069
			public static Func<field_values, string> <>9__11_1;

			// Token: 0x0400236E RID: 9070
			public static Func<fields, field_values> <>9__13_0;
		}

		// Token: 0x020006C2 RID: 1730
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetAdditionalFields>d__4 : IAsyncStateMachine
		{
			// Token: 0x0600394E RID: 14670 RVA: 0x000D49E8 File Offset: 0x000D2BE8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AdditionalFieldsService additionalFieldsService = this.<>4__this;
				List<fields> result;
				try
				{
					AdditionalFieldsService.<>c__DisplayClass4_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new AdditionalFieldsService.<>c__DisplayClass4_0();
						CS$<>8__locals1.isStoreItemField = this.isStoreItemField;
						this.<ctx>5__2 = additionalFieldsService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<List<fields>> awaiter;
						if (num != 0)
						{
							IQueryable<fields> source = this.<ctx>5__2.fields.AsNoTracking().AsQueryable<fields>();
							if (CS$<>8__locals1.isStoreItemField != null)
							{
								source = from i in source
								where (bool?)i.C_f == CS$<>8__locals1.isStoreItemField
								select i;
							}
							if (!this.showArchive)
							{
								source = from f in source
								where !f.archive
								select f;
							}
							awaiter = source.ToListAsync<fields>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<fields>>, AdditionalFieldsService.<GetAdditionalFields>d__4>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<fields>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
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
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x0600394F RID: 14671 RVA: 0x000D4BF8 File Offset: 0x000D2DF8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400236F RID: 9071
			public int <>1__state;

			// Token: 0x04002370 RID: 9072
			public AsyncTaskMethodBuilder<List<fields>> <>t__builder;

			// Token: 0x04002371 RID: 9073
			public bool? isStoreItemField;

			// Token: 0x04002372 RID: 9074
			public AdditionalFieldsService <>4__this;

			// Token: 0x04002373 RID: 9075
			public bool showArchive;

			// Token: 0x04002374 RID: 9076
			private auseceEntities <ctx>5__2;

			// Token: 0x04002375 RID: 9077
			private TaskAwaiter<List<fields>> <>u__1;
		}

		// Token: 0x020006C3 RID: 1731
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetDeviceAttributes>d__5 : IAsyncStateMachine
		{
			// Token: 0x06003950 RID: 14672 RVA: 0x000D4C14 File Offset: 0x000D2E14
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AdditionalFieldsService additionalFieldsService = this.<>4__this;
				List<fields> result;
				try
				{
					if (num != 0)
					{
						this.<ctx>5__2 = additionalFieldsService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<List<fields>> awaiter;
						if (num != 0)
						{
							awaiter = this.<ctx>5__2.fields.SqlQuery("SELECT fields._f AS C_f, fields.* FROM fields WHERE fields._f = 0 AND fields.archive = 0 AND (FIND_IN_SET(@deviceId, devices) OR `devices` IS NULL)", new object[]
							{
								new MySqlParameter("deviceId", this.deviceId)
							}).ToListAsync().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<fields>>, AdditionalFieldsService.<GetDeviceAttributes>d__5>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<fields>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
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
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06003951 RID: 14673 RVA: 0x000D4D38 File Offset: 0x000D2F38
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002376 RID: 9078
			public int <>1__state;

			// Token: 0x04002377 RID: 9079
			public AsyncTaskMethodBuilder<List<fields>> <>t__builder;

			// Token: 0x04002378 RID: 9080
			public AdditionalFieldsService <>4__this;

			// Token: 0x04002379 RID: 9081
			public int deviceId;

			// Token: 0x0400237A RID: 9082
			private auseceEntities <ctx>5__2;

			// Token: 0x0400237B RID: 9083
			private TaskAwaiter<List<fields>> <>u__1;
		}

		// Token: 0x020006C4 RID: 1732
		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x06003952 RID: 14674 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x0400237C RID: 9084
			public int productId;
		}

		// Token: 0x020006C5 RID: 1733
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetProductAttributes>d__6 : IAsyncStateMachine
		{
			// Token: 0x06003953 RID: 14675 RVA: 0x000D4D54 File Offset: 0x000D2F54
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IEnumerable<fields> result;
				try
				{
					AdditionalFieldsService.<>c__DisplayClass6_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new AdditionalFieldsService.<>c__DisplayClass6_0();
						CS$<>8__locals1.productId = this.productId;
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<IEnumerable<fields>> awaiter;
						if (num != 0)
						{
							int categoryId = (from p in this.<ctx>5__2.store_items
							where p.id == CS$<>8__locals1.productId
							select p.category).FirstOrDefault<int>();
							awaiter = AdditionalFieldsService.GetProductAttributesByCategory(this.<ctx>5__2, categoryId).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<fields>>, AdditionalFieldsService.<GetProductAttributes>d__6>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<fields>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
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
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06003954 RID: 14676 RVA: 0x000D4F24 File Offset: 0x000D3124
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400237D RID: 9085
			public int <>1__state;

			// Token: 0x0400237E RID: 9086
			public AsyncTaskMethodBuilder<IEnumerable<fields>> <>t__builder;

			// Token: 0x0400237F RID: 9087
			public int productId;

			// Token: 0x04002380 RID: 9088
			private auseceEntities <ctx>5__2;

			// Token: 0x04002381 RID: 9089
			private TaskAwaiter<IEnumerable<fields>> <>u__1;
		}

		// Token: 0x020006C6 RID: 1734
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetProductAttributesByCategory>d__7 : IAsyncStateMachine
		{
			// Token: 0x06003955 RID: 14677 RVA: 0x000D4F40 File Offset: 0x000D3140
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IEnumerable<fields> result;
				try
				{
					ConfiguredTaskAwaitable<List<fields>>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = this.ctx.fields.SqlQuery("SELECT fields._f AS C_f, fields.* FROM fields WHERE fields._f = 1 AND (FIND_IN_SET(@categoryId, categories) OR `categories` IS NULL)", new object[]
						{
							new MySqlParameter("categoryId", this.categoryId)
						}).ToListAsync().ConfigureAwait(false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<fields>>.ConfiguredTaskAwaiter, AdditionalFieldsService.<GetProductAttributesByCategory>d__7>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(ConfiguredTaskAwaitable<List<fields>>.ConfiguredTaskAwaiter);
						this.<>1__state = -1;
					}
					result = awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06003956 RID: 14678 RVA: 0x000D502C File Offset: 0x000D322C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002382 RID: 9090
			public int <>1__state;

			// Token: 0x04002383 RID: 9091
			public AsyncTaskMethodBuilder<IEnumerable<fields>> <>t__builder;

			// Token: 0x04002384 RID: 9092
			public auseceEntities ctx;

			// Token: 0x04002385 RID: 9093
			public int categoryId;

			// Token: 0x04002386 RID: 9094
			private ConfiguredTaskAwaitable<List<fields>>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x020006C7 RID: 1735
		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x06003957 RID: 14679 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x04002387 RID: 9095
			public bool isStoreItemField;
		}

		// Token: 0x020006C8 RID: 1736
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <AdditionalFieldsExist>d__8 : IAsyncStateMachine
		{
			// Token: 0x06003958 RID: 14680 RVA: 0x000D5048 File Offset: 0x000D3248
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AdditionalFieldsService additionalFieldsService = this.<>4__this;
				bool result;
				try
				{
					AdditionalFieldsService.<>c__DisplayClass8_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new AdditionalFieldsService.<>c__DisplayClass8_0();
						CS$<>8__locals1.isStoreItemField = this.isStoreItemField;
						this.<ctx>5__2 = additionalFieldsService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<bool> awaiter;
						if (num != 0)
						{
							awaiter = this.<ctx>5__2.fields.AnyAsync((fields f) => f.C_f == CS$<>8__locals1.isStoreItemField).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, AdditionalFieldsService.<AdditionalFieldsExist>d__8>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<bool>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
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
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06003959 RID: 14681 RVA: 0x000D51D4 File Offset: 0x000D33D4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002388 RID: 9096
			public int <>1__state;

			// Token: 0x04002389 RID: 9097
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x0400238A RID: 9098
			public bool isStoreItemField;

			// Token: 0x0400238B RID: 9099
			public AdditionalFieldsService <>4__this;

			// Token: 0x0400238C RID: 9100
			private auseceEntities <ctx>5__2;

			// Token: 0x0400238D RID: 9101
			private TaskAwaiter<bool> <>u__1;
		}

		// Token: 0x020006C9 RID: 1737
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetDeviceFields>d__9 : IAsyncStateMachine
		{
			// Token: 0x0600395A RID: 14682 RVA: 0x000D51F0 File Offset: 0x000D33F0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AdditionalFieldsService additionalFieldsService = this.<>4__this;
				List<object> result2;
				try
				{
					TaskAwaiter<List<fields>> awaiter;
					if (num != 0)
					{
						awaiter = additionalFieldsService.GetDeviceAttributes(this.deviceId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.<>1__state = num2;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<fields>>, AdditionalFieldsService.<GetDeviceFields>d__9>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<fields>>);
						int num3 = -1;
						num = -1;
						this.<>1__state = num3;
					}
					List<fields> result = awaiter.GetResult();
					if (result != null && result.Count != 0)
					{
						List<object> list = new List<object>();
						List<fields>.Enumerator enumerator = result.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								fields fields = enumerator.Current;
								if (fields.type == 1)
								{
									list.Add(new PanelViewModel(fields));
								}
								if (fields.type == 2)
								{
									list.Add(new ComboBoxViewModel(fields));
								}
								if (fields.type == 3)
								{
									list.Add(new DatePickerViewModel(fields));
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
						result2 = list;
					}
					else
					{
						result2 = new List<object>();
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x0600395B RID: 14683 RVA: 0x000D5374 File Offset: 0x000D3574
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400238E RID: 9102
			public int <>1__state;

			// Token: 0x0400238F RID: 9103
			public AsyncTaskMethodBuilder<List<object>> <>t__builder;

			// Token: 0x04002390 RID: 9104
			public AdditionalFieldsService <>4__this;

			// Token: 0x04002391 RID: 9105
			public int deviceId;

			// Token: 0x04002392 RID: 9106
			private TaskAwaiter<List<fields>> <>u__1;
		}

		// Token: 0x020006CA RID: 1738
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetDeviceUiFields>d__10 : IAsyncStateMachine
		{
			// Token: 0x0600395C RID: 14684 RVA: 0x000D5390 File Offset: 0x000D3590
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AdditionalFieldsService additionalFieldsService = this.<>4__this;
				List<IAttribute> result2;
				try
				{
					TaskAwaiter<List<fields>> awaiter;
					if (num != 0)
					{
						awaiter = additionalFieldsService.GetDeviceAttributes(this.deviceId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<fields>>, AdditionalFieldsService.<GetDeviceUiFields>d__10>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<fields>>);
						this.<>1__state = -1;
					}
					List<fields> result = awaiter.GetResult();
					if (result != null && result.Count != 0)
					{
						result2 = AdditionalFieldsService.GetUiFields(this.values, result);
					}
					else
					{
						result2 = new List<IAttribute>();
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x0600395D RID: 14685 RVA: 0x000D5470 File Offset: 0x000D3670
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002393 RID: 9107
			public int <>1__state;

			// Token: 0x04002394 RID: 9108
			public AsyncTaskMethodBuilder<List<IAttribute>> <>t__builder;

			// Token: 0x04002395 RID: 9109
			public AdditionalFieldsService <>4__this;

			// Token: 0x04002396 RID: 9110
			public int deviceId;

			// Token: 0x04002397 RID: 9111
			public IEnumerable<field_values> values;

			// Token: 0x04002398 RID: 9112
			private TaskAwaiter<List<fields>> <>u__1;
		}

		// Token: 0x020006CB RID: 1739
		[CompilerGenerated]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x0600395E RID: 14686 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x0600395F RID: 14687 RVA: 0x000D548C File Offset: 0x000D368C
			internal bool <GetUiFields>b__0(field_values v)
			{
				if (v.fields != null)
				{
					if (v.fields.type == this.field.type)
					{
						return v.field_id == this.field.id;
					}
				}
				return false;
			}

			// Token: 0x04002399 RID: 9113
			public fields field;
		}

		// Token: 0x020006CC RID: 1740
		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x06003960 RID: 14688 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x0400239A RID: 9114
			public int productId;
		}

		// Token: 0x020006CD RID: 1741
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetProductUiFields>d__12 : IAsyncStateMachine
		{
			// Token: 0x06003961 RID: 14689 RVA: 0x000D54D0 File Offset: 0x000D36D0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AdditionalFieldsService additionalFieldsService = this.<>4__this;
				List<IAttribute> result2;
				try
				{
					if (num > 1)
					{
						this.<>8__1 = new AdditionalFieldsService.<>c__DisplayClass12_0();
						this.<>8__1.productId = this.productId;
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<List<field_values>> awaiter;
						TaskAwaiter<IEnumerable<fields>> awaiter2;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<List<field_values>>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								goto IL_1A7;
							}
							awaiter2 = additionalFieldsService.GetProductAttributes(this.<>8__1.productId).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								this.<>1__state = num3;
								this.<>u__1 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<fields>>, AdditionalFieldsService.<GetProductUiFields>d__12>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<fields>>);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
						}
						IEnumerable<fields> result = awaiter2.GetResult();
						this.<attributes>5__3 = result;
						if (!this.<attributes>5__3.Any<fields>())
						{
							result2 = new List<IAttribute>();
							goto IL_1F4;
						}
						awaiter = (from v in this.<ctx>5__2.field_values
						where v.item_id == (int?)this.<>8__1.productId
						select v).ToListAsync<field_values>().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num5 = 1;
							num = 1;
							this.<>1__state = num5;
							this.<>u__2 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<field_values>>, AdditionalFieldsService.<GetProductUiFields>d__12>(ref awaiter, ref this);
							return;
						}
						IL_1A7:
						result2 = AdditionalFieldsService.GetUiFields(awaiter.GetResult(), this.<attributes>5__3);
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_1F4:
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06003962 RID: 14690 RVA: 0x000D5720 File Offset: 0x000D3920
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400239B RID: 9115
			public int <>1__state;

			// Token: 0x0400239C RID: 9116
			public AsyncTaskMethodBuilder<List<IAttribute>> <>t__builder;

			// Token: 0x0400239D RID: 9117
			public int productId;

			// Token: 0x0400239E RID: 9118
			public AdditionalFieldsService <>4__this;

			// Token: 0x0400239F RID: 9119
			private AdditionalFieldsService.<>c__DisplayClass12_0 <>8__1;

			// Token: 0x040023A0 RID: 9120
			private auseceEntities <ctx>5__2;

			// Token: 0x040023A1 RID: 9121
			private IEnumerable<fields> <attributes>5__3;

			// Token: 0x040023A2 RID: 9122
			private TaskAwaiter<IEnumerable<fields>> <>u__1;

			// Token: 0x040023A3 RID: 9123
			private TaskAwaiter<List<field_values>> <>u__2;
		}

		// Token: 0x020006CE RID: 1742
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetProductUiFieldsByCategory>d__13 : IAsyncStateMachine
		{
			// Token: 0x06003963 RID: 14691 RVA: 0x000D573C File Offset: 0x000D393C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<IAttribute> result2;
				try
				{
					if (num != 0)
					{
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<IEnumerable<fields>> awaiter;
						if (num != 0)
						{
							awaiter = AdditionalFieldsService.GetProductAttributesByCategory(this.<ctx>5__2, this.categoryId).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<fields>>, AdditionalFieldsService.<GetProductUiFieldsByCategory>d__13>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<fields>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						IEnumerable<fields> result = awaiter.GetResult();
						if (!result.Any<fields>())
						{
							result2 = new List<IAttribute>();
						}
						else
						{
							result2 = AdditionalFieldsService.GetUiFields(result.Select(new Func<fields, field_values>(AdditionalFieldsService.<>c.<>9.<GetProductUiFieldsByCategory>b__13_0)).ToList<field_values>(), result);
						}
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
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
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06003964 RID: 14692 RVA: 0x000D5870 File Offset: 0x000D3A70
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040023A4 RID: 9124
			public int <>1__state;

			// Token: 0x040023A5 RID: 9125
			public AsyncTaskMethodBuilder<List<IAttribute>> <>t__builder;

			// Token: 0x040023A6 RID: 9126
			public int categoryId;

			// Token: 0x040023A7 RID: 9127
			private auseceEntities <ctx>5__2;

			// Token: 0x040023A8 RID: 9128
			private TaskAwaiter<IEnumerable<fields>> <>u__1;
		}

		// Token: 0x020006CF RID: 1743
		[CompilerGenerated]
		private sealed class <>c__DisplayClass15_0
		{
			// Token: 0x06003965 RID: 14693 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass15_0()
			{
			}

			// Token: 0x040023A9 RID: 9129
			public int repairId;
		}

		// Token: 0x020006D0 RID: 1744
		[CompilerGenerated]
		private sealed class <>c__DisplayClass15_1
		{
			// Token: 0x06003966 RID: 14694 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass15_1()
			{
			}

			// Token: 0x040023AA RID: 9130
			public IAttribute userField;

			// Token: 0x040023AB RID: 9131
			public AdditionalFieldsService.<>c__DisplayClass15_0 CS$<>8__locals1;
		}

		// Token: 0x020006D1 RID: 1745
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateAdditionalFields>d__15 : IAsyncStateMachine
		{
			// Token: 0x06003967 RID: 14695 RVA: 0x000D588C File Offset: 0x000D3A8C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AdditionalFieldsService additionalFieldsService = this.<>4__this;
				try
				{
					if (num > 2)
					{
						this.<>8__1 = new AdditionalFieldsService.<>c__DisplayClass15_0();
						this.<>8__1.repairId = this.repairId;
						this.<history>5__2 = new HistoryV2();
						this.<ctx>5__3 = additionalFieldsService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<int> awaiter;
						TaskAwaiter awaiter2;
						switch (num)
						{
						case 0:
							break;
						case 1:
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<int>);
							int num2 = -1;
							num = -1;
							this.<>1__state = num2;
							goto IL_3D0;
						}
						case 2:
						{
							awaiter2 = this.<>u__3;
							this.<>u__3 = default(TaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
							goto IL_434;
						}
						default:
							this.<>7__wrap3 = this.fields.GetEnumerator();
							break;
						}
						try
						{
							TaskAwaiter<field_values> awaiter3;
							if (num == 0)
							{
								awaiter3 = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<field_values>);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
								goto IL_212;
							}
							IL_31F:
							while (this.<>7__wrap3.MoveNext())
							{
								object obj = this.<>7__wrap3.Current;
								this.<>8__2 = new AdditionalFieldsService.<>c__DisplayClass15_1();
								this.<>8__2.CS$<>8__locals1 = this.<>8__1;
								this.<>8__2.userField = (obj as IAttribute);
								if (this.<>8__2.userField != null)
								{
									this.<val>5__5 = (string.IsNullOrEmpty(this.<>8__2.userField.Text) ? "" : this.<>8__2.userField.Text);
									awaiter3 = this.<ctx>5__3.field_values.FirstOrDefaultAsync((field_values f) => f.field_id == this.<>8__2.userField.FieldId && f.repair_id == (int?)this.<>8__2.CS$<>8__locals1.repairId).GetAwaiter();
									if (awaiter3.IsCompleted)
									{
										goto IL_212;
									}
									int num5 = 0;
									num = 0;
									this.<>1__state = num5;
									this.<>u__1 = awaiter3;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<field_values>, AdditionalFieldsService.<UpdateAdditionalFields>d__15>(ref awaiter3, ref this);
									return;
								}
							}
							goto IL_36D;
							IL_212:
							field_values result = awaiter3.GetResult();
							if (result == null)
							{
								if (!string.IsNullOrEmpty(this.<val>5__5))
								{
									this.<ctx>5__3.field_values.Add(new field_values
									{
										field_id = this.<>8__2.userField.FieldId,
										repair_id = new int?(this.<>8__2.CS$<>8__locals1.repairId),
										value = this.<val>5__5
									});
									this.<history>5__2.AddRepairLog("SetUserField", this.<>8__2.CS$<>8__locals1.repairId, this.<>8__2.userField.FieldName, this.<val>5__5);
								}
							}
							else
							{
								if (!string.Equals(result.value, this.<val>5__5, StringComparison.Ordinal))
								{
									this.<history>5__2.AddRepairLog("SetUserField", this.<>8__2.CS$<>8__locals1.repairId, this.<>8__2.userField.FieldName, this.<val>5__5);
								}
								result.value = this.<val>5__5;
							}
							this.<>8__2 = null;
							this.<val>5__5 = null;
							goto IL_31F;
						}
						finally
						{
							if (num < 0 && this.<>7__wrap3 != null)
							{
								this.<>7__wrap3.Dispose();
							}
						}
						IL_36D:
						this.<>7__wrap3 = null;
						awaiter = this.<ctx>5__3.SaveChangesAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num6 = 1;
							num = 1;
							this.<>1__state = num6;
							this.<>u__2 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, AdditionalFieldsService.<UpdateAdditionalFields>d__15>(ref awaiter, ref this);
							return;
						}
						IL_3D0:
						awaiter.GetResult();
						awaiter2 = this.<history>5__2.SaveAsync().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num7 = 2;
							num = 2;
							this.<>1__state = num7;
							this.<>u__3 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, AdditionalFieldsService.<UpdateAdditionalFields>d__15>(ref awaiter2, ref this);
							return;
						}
						IL_434:
						awaiter2.GetResult();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__3 != null)
						{
							((IDisposable)this.<ctx>5__3).Dispose();
						}
					}
					this.<ctx>5__3 = null;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<history>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<history>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003968 RID: 14696 RVA: 0x000D5D8C File Offset: 0x000D3F8C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040023AC RID: 9132
			public int <>1__state;

			// Token: 0x040023AD RID: 9133
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040023AE RID: 9134
			public int repairId;

			// Token: 0x040023AF RID: 9135
			public AdditionalFieldsService <>4__this;

			// Token: 0x040023B0 RID: 9136
			public IEnumerable<object> fields;

			// Token: 0x040023B1 RID: 9137
			private AdditionalFieldsService.<>c__DisplayClass15_0 <>8__1;

			// Token: 0x040023B2 RID: 9138
			private AdditionalFieldsService.<>c__DisplayClass15_1 <>8__2;

			// Token: 0x040023B3 RID: 9139
			private HistoryV2 <history>5__2;

			// Token: 0x040023B4 RID: 9140
			private auseceEntities <ctx>5__3;

			// Token: 0x040023B5 RID: 9141
			private IEnumerator<object> <>7__wrap3;

			// Token: 0x040023B6 RID: 9142
			private string <val>5__5;

			// Token: 0x040023B7 RID: 9143
			private TaskAwaiter<field_values> <>u__1;

			// Token: 0x040023B8 RID: 9144
			private TaskAwaiter<int> <>u__2;

			// Token: 0x040023B9 RID: 9145
			private TaskAwaiter <>u__3;
		}
	}
}
