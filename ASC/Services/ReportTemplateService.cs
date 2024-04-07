using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.SimpleClasses;

namespace ASC.Services
{
	// Token: 0x020005EF RID: 1519
	public class ReportTemplateService : IReportTemplateService
	{
		// Token: 0x0600374B RID: 14155 RVA: 0x000BF7DC File Offset: 0x000BD9DC
		public Task<int> Create(doc_templates template)
		{
			ReportTemplateService.<Create>d__0 <Create>d__;
			<Create>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<Create>d__.template = template;
			<Create>d__.<>1__state = -1;
			<Create>d__.<>t__builder.Start<ReportTemplateService.<Create>d__0>(ref <Create>d__);
			return <Create>d__.<>t__builder.Task;
		}

		// Token: 0x0600374C RID: 14156 RVA: 0x000BF820 File Offset: 0x000BDA20
		public Task<doc_templates> GetByIdAsync(int templateId)
		{
			ReportTemplateService.<GetByIdAsync>d__1 <GetByIdAsync>d__;
			<GetByIdAsync>d__.<>t__builder = AsyncTaskMethodBuilder<doc_templates>.Create();
			<GetByIdAsync>d__.templateId = templateId;
			<GetByIdAsync>d__.<>1__state = -1;
			<GetByIdAsync>d__.<>t__builder.Start<ReportTemplateService.<GetByIdAsync>d__1>(ref <GetByIdAsync>d__);
			return <GetByIdAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600374D RID: 14157 RVA: 0x000BF864 File Offset: 0x000BDA64
		public Task<doc_templates> GetByNameAsync(string templateName)
		{
			ReportTemplateService.<GetByNameAsync>d__2 <GetByNameAsync>d__;
			<GetByNameAsync>d__.<>t__builder = AsyncTaskMethodBuilder<doc_templates>.Create();
			<GetByNameAsync>d__.templateName = templateName;
			<GetByNameAsync>d__.<>1__state = -1;
			<GetByNameAsync>d__.<>t__builder.Start<ReportTemplateService.<GetByNameAsync>d__2>(ref <GetByNameAsync>d__);
			return <GetByNameAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600374E RID: 14158 RVA: 0x000BF8A8 File Offset: 0x000BDAA8
		public Task<List<DocumentTemplateInfo>> GetAllAsync()
		{
			ReportTemplateService.<GetAllAsync>d__3 <GetAllAsync>d__;
			<GetAllAsync>d__.<>t__builder = AsyncTaskMethodBuilder<List<DocumentTemplateInfo>>.Create();
			<GetAllAsync>d__.<>1__state = -1;
			<GetAllAsync>d__.<>t__builder.Start<ReportTemplateService.<GetAllAsync>d__3>(ref <GetAllAsync>d__);
			return <GetAllAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600374F RID: 14159 RVA: 0x000BF8E4 File Offset: 0x000BDAE4
		public Task UpdateTemplateDescription(int templateId, string description)
		{
			ReportTemplateService.<UpdateTemplateDescription>d__4 <UpdateTemplateDescription>d__;
			<UpdateTemplateDescription>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<UpdateTemplateDescription>d__.templateId = templateId;
			<UpdateTemplateDescription>d__.description = description;
			<UpdateTemplateDescription>d__.<>1__state = -1;
			<UpdateTemplateDescription>d__.<>t__builder.Start<ReportTemplateService.<UpdateTemplateDescription>d__4>(ref <UpdateTemplateDescription>d__);
			return <UpdateTemplateDescription>d__.<>t__builder.Task;
		}

		// Token: 0x06003750 RID: 14160 RVA: 0x000046B4 File Offset: 0x000028B4
		public ReportTemplateService()
		{
		}

		// Token: 0x020005F0 RID: 1520
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Create>d__0 : IAsyncStateMachine
		{
			// Token: 0x06003751 RID: 14161 RVA: 0x000BF930 File Offset: 0x000BDB30
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				int id;
				try
				{
					if (num != 0)
					{
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							this.<ctx>5__2.doc_templates.Add(this.template);
							awaiter = this.<ctx>5__2.SaveChangesAsync().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter, ReportTemplateService.<Create>d__0>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						awaiter.GetResult();
						id = this.template.id;
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

			// Token: 0x06003752 RID: 14162 RVA: 0x000BFA44 File Offset: 0x000BDC44
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002030 RID: 8240
			public int <>1__state;

			// Token: 0x04002031 RID: 8241
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x04002032 RID: 8242
			public doc_templates template;

			// Token: 0x04002033 RID: 8243
			private auseceEntities <ctx>5__2;

			// Token: 0x04002034 RID: 8244
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x020005F1 RID: 1521
		[CompilerGenerated]
		private sealed class <>c__DisplayClass1_0
		{
			// Token: 0x06003753 RID: 14163 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass1_0()
			{
			}

			// Token: 0x04002035 RID: 8245
			public int templateId;
		}

		// Token: 0x020005F2 RID: 1522
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetByIdAsync>d__1 : IAsyncStateMachine
		{
			// Token: 0x06003754 RID: 14164 RVA: 0x000BFA60 File Offset: 0x000BDC60
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				doc_templates result;
				try
				{
					ReportTemplateService.<>c__DisplayClass1_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new ReportTemplateService.<>c__DisplayClass1_0();
						CS$<>8__locals1.templateId = this.templateId;
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<doc_templates>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = this.<ctx>5__2.doc_templates.FirstOrDefaultAsync((doc_templates t) => t.id == CS$<>8__locals1.templateId).ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<doc_templates>.ConfiguredTaskAwaiter, ReportTemplateService.<GetByIdAsync>d__1>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<doc_templates>.ConfiguredTaskAwaiter);
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

			// Token: 0x06003755 RID: 14165 RVA: 0x000BFBE4 File Offset: 0x000BDDE4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002036 RID: 8246
			public int <>1__state;

			// Token: 0x04002037 RID: 8247
			public AsyncTaskMethodBuilder<doc_templates> <>t__builder;

			// Token: 0x04002038 RID: 8248
			public int templateId;

			// Token: 0x04002039 RID: 8249
			private auseceEntities <ctx>5__2;

			// Token: 0x0400203A RID: 8250
			private ConfiguredTaskAwaitable<doc_templates>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x020005F3 RID: 1523
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x06003756 RID: 14166 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x0400203B RID: 8251
			public string templateName;
		}

		// Token: 0x020005F4 RID: 1524
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetByNameAsync>d__2 : IAsyncStateMachine
		{
			// Token: 0x06003757 RID: 14167 RVA: 0x000BFC00 File Offset: 0x000BDE00
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				doc_templates result;
				try
				{
					ReportTemplateService.<>c__DisplayClass2_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new ReportTemplateService.<>c__DisplayClass2_0();
						CS$<>8__locals1.templateName = this.templateName;
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<doc_templates>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = this.<ctx>5__2.doc_templates.FirstOrDefaultAsync((doc_templates t) => t.name == CS$<>8__locals1.templateName).ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<doc_templates>.ConfiguredTaskAwaiter, ReportTemplateService.<GetByNameAsync>d__2>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<doc_templates>.ConfiguredTaskAwaiter);
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

			// Token: 0x06003758 RID: 14168 RVA: 0x000BFD84 File Offset: 0x000BDF84
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400203C RID: 8252
			public int <>1__state;

			// Token: 0x0400203D RID: 8253
			public AsyncTaskMethodBuilder<doc_templates> <>t__builder;

			// Token: 0x0400203E RID: 8254
			public string templateName;

			// Token: 0x0400203F RID: 8255
			private auseceEntities <ctx>5__2;

			// Token: 0x04002040 RID: 8256
			private ConfiguredTaskAwaitable<doc_templates>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x020005F5 RID: 1525
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003759 RID: 14169 RVA: 0x000BFDA0 File Offset: 0x000BDFA0
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600375A RID: 14170 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x04002041 RID: 8257
			public static readonly ReportTemplateService.<>c <>9 = new ReportTemplateService.<>c();
		}

		// Token: 0x020005F6 RID: 1526
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetAllAsync>d__3 : IAsyncStateMachine
		{
			// Token: 0x0600375B RID: 14171 RVA: 0x000BFDB8 File Offset: 0x000BDFB8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<DocumentTemplateInfo> result;
				try
				{
					if (num != 0)
					{
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<List<DocumentTemplateInfo>>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							ParameterExpression parameterExpression;
							awaiter = (from o in this.<ctx>5__2.doc_templates.AsNoTracking().Select(Expression.Lambda<Func<doc_templates, DocumentTemplateInfo>>(Expression.MemberInit(Expression.New(typeof(DocumentTemplateInfo)), new MemberBinding[]
							{
								Expression.Bind(methodof(DocumentTemplateInfo.set_Id(int)), Expression.Property(parameterExpression, methodof(doc_templates.get_id()))),
								Expression.Bind(methodof(DocumentTemplateInfo.set_Name(string)), Expression.Property(parameterExpression, methodof(doc_templates.get_name()))),
								Expression.Bind(methodof(DocumentTemplateInfo.set_Description(string)), Expression.Property(parameterExpression, methodof(doc_templates.get_description())))
							}), new ParameterExpression[]
							{
								parameterExpression
							}))
							orderby o.Description
							select o).ToListAsync<DocumentTemplateInfo>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<DocumentTemplateInfo>>.ConfiguredTaskAwaiter, ReportTemplateService.<GetAllAsync>d__3>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<List<DocumentTemplateInfo>>.ConfiguredTaskAwaiter);
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

			// Token: 0x0600375C RID: 14172 RVA: 0x000BFFD4 File Offset: 0x000BE1D4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002042 RID: 8258
			public int <>1__state;

			// Token: 0x04002043 RID: 8259
			public AsyncTaskMethodBuilder<List<DocumentTemplateInfo>> <>t__builder;

			// Token: 0x04002044 RID: 8260
			private auseceEntities <ctx>5__2;

			// Token: 0x04002045 RID: 8261
			private ConfiguredTaskAwaitable<List<DocumentTemplateInfo>>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x020005F7 RID: 1527
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateTemplateDescription>d__4 : IAsyncStateMachine
		{
			// Token: 0x0600375D RID: 14173 RVA: 0x000BFFF0 File Offset: 0x000BE1F0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					if (num > 1)
					{
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter awaiter;
						ConfiguredTaskAwaitable<doc_templates>.ConfiguredTaskAwaiter awaiter2;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.<>u__2;
								this.<>u__2 = default(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								goto IL_F4;
							}
							awaiter2 = this.<ctx>5__2.doc_templates.FindAsync(new object[]
							{
								this.templateId
							}).ConfigureAwait(false).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								this.<>1__state = num3;
								this.<>u__1 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<doc_templates>.ConfiguredTaskAwaiter, ReportTemplateService.<UpdateTemplateDescription>d__4>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<doc_templates>.ConfiguredTaskAwaiter);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
						}
						awaiter2.GetResult().description = this.description;
						awaiter = this.<ctx>5__2.SaveChangesAsync().ConfigureAwait(false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num5 = 1;
							num = 1;
							this.<>1__state = num5;
							this.<>u__2 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter, ReportTemplateService.<UpdateTemplateDescription>d__4>(ref awaiter, ref this);
							return;
						}
						IL_F4:
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

			// Token: 0x0600375E RID: 14174 RVA: 0x000C019C File Offset: 0x000BE39C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002046 RID: 8262
			public int <>1__state;

			// Token: 0x04002047 RID: 8263
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002048 RID: 8264
			public int templateId;

			// Token: 0x04002049 RID: 8265
			public string description;

			// Token: 0x0400204A RID: 8266
			private auseceEntities <ctx>5__2;

			// Token: 0x0400204B RID: 8267
			private ConfiguredTaskAwaitable<doc_templates>.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x0400204C RID: 8268
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__2;
		}
	}
}
