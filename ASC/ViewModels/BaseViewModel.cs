using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Xml;
using ASC.Common.Interfaces;
using ASC.Converters;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Services.Abstract;
using Autofac;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Utils;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.LayoutControl;
using DevExpress.XtraGrid;

namespace ASC.ViewModels
{
	// Token: 0x0200045F RID: 1119
	public class BaseViewModel : ViewModelBase, IBaseViewModel, IViewName
	{
		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x06002C1A RID: 11290 RVA: 0x0008CD90 File Offset: 0x0008AF90
		// (set) Token: 0x06002C1B RID: 11291 RVA: 0x0008CDA4 File Offset: 0x0008AFA4
		public string ViewName
		{
			[CompilerGenerated]
			get
			{
				return this.<ViewName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<ViewName>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<ViewName>k__BackingField = value;
				this.RaisePropertyChanged("ViewName");
			}
		}

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x06002C1C RID: 11292 RVA: 0x0008CDD4 File Offset: 0x0008AFD4
		// (set) Token: 0x06002C1D RID: 11293 RVA: 0x0008CDE8 File Offset: 0x0008AFE8
		public string TabId
		{
			[CompilerGenerated]
			get
			{
				return this.<TabId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<TabId>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<TabId>k__BackingField = value;
				this.RaisePropertyChanged("TabId");
			}
		}

		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x06002C1E RID: 11294 RVA: 0x0008CE18 File Offset: 0x0008B018
		// (set) Token: 0x06002C1F RID: 11295 RVA: 0x0008CE2C File Offset: 0x0008B02C
		public bool ViewLoaded
		{
			[CompilerGenerated]
			get
			{
				return this.<ViewLoaded>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<ViewLoaded>k__BackingField == value)
				{
					return;
				}
				this.<ViewLoaded>k__BackingField = value;
				this.RaisePropertyChanged("ViewLoaded");
			}
		}

		// Token: 0x06002C20 RID: 11296 RVA: 0x0008CE58 File Offset: 0x0008B058
		protected BaseViewModel()
		{
			this._waitIndicatorService = Bootstrapper.Container.Resolve<IWaitIndicatorService>();
			this._toasterServiceTmp = Bootstrapper.Container.Resolve<IToasterService>();
			this._layoutSaveTimer = new DispatcherTimer();
			this._layoutSaveTimer.Tick += this._layoutSaveTimer_Tick;
			this._layoutSaveTimer.Interval = TimeSpan.FromMilliseconds(500.0);
		}

		// Token: 0x06002C21 RID: 11297 RVA: 0x0008CEC8 File Offset: 0x0008B0C8
		public void ShowWait()
		{
			this._waitIndicatorService.ShowWait();
		}

		// Token: 0x06002C22 RID: 11298 RVA: 0x0008CEE0 File Offset: 0x0008B0E0
		public void HideWait()
		{
			this._waitIndicatorService.HideWait();
		}

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x06002C23 RID: 11299 RVA: 0x0008CEF8 File Offset: 0x0008B0F8
		public ICommand OnViewLoadedCommand
		{
			get
			{
				if (this.onViewLoadedCommand == null)
				{
					this.onViewLoadedCommand = new DelegateCommand(new Action(this.OnViewLoaded));
				}
				return this.onViewLoadedCommand;
			}
		}

		// Token: 0x06002C24 RID: 11300 RVA: 0x00023150 File Offset: 0x00021350
		public virtual void OnViewLoaded()
		{
		}

		// Token: 0x06002C25 RID: 11301 RVA: 0x0008CF2C File Offset: 0x0008B12C
		public virtual void SetViewName(string name)
		{
			this.ViewName = (Lang.t(name) ?? "");
		}

		// Token: 0x06002C26 RID: 11302 RVA: 0x0008CF50 File Offset: 0x0008B150
		public virtual void SetViewName(string name, int id)
		{
			this.ViewName = string.Format("{0} {1:D6}", Lang.t(name), id);
		}

		// Token: 0x06002C27 RID: 11303 RVA: 0x0008CF7C File Offset: 0x0008B17C
		public void SetViewName(string name, string subname, int id)
		{
			this.ViewName = string.Format("{0} {1:D6} | {2}", Lang.t(name), id, Lang.t(subname));
		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x0008CFAC File Offset: 0x0008B1AC
		public virtual void SetViewName(string name, string subname)
		{
			this.ViewName = Lang.t(name) + " : " + Lang.t(subname);
		}

		// Token: 0x06002C29 RID: 11305 RVA: 0x0008CFD8 File Offset: 0x0008B1D8
		[Command]
		public void ComboBoxClick(MouseButtonEventArgs args)
		{
			LookUpEditBase lookUpEditBase = ((args == null) ? null : args.Source) as LookUpEditBase;
			if (lookUpEditBase == null)
			{
				return;
			}
			if (!(args.OriginalSource is System.Windows.Shapes.Path) && !(args.OriginalSource is Grid))
			{
				lookUpEditBase.IsPopupOpen = true;
				return;
			}
		}

		// Token: 0x06002C2A RID: 11306 RVA: 0x0008D020 File Offset: 0x0008B220
		[Command]
		public void GroupBoxMouseClick(MouseButtonEventArgs args)
		{
			DevExpress.Xpf.LayoutControl.GroupBox groupBox = args.Source as DevExpress.Xpf.LayoutControl.GroupBox;
			if (groupBox != null)
			{
				groupBox.State = ((groupBox.State == GroupBoxState.Minimized) ? GroupBoxState.Normal : GroupBoxState.Minimized);
			}
		}

		// Token: 0x06002C2B RID: 11307 RVA: 0x0008D050 File Offset: 0x0008B250
		private void GridUserCols(GridControl grid, IList<fields> userFields)
		{
			BaseViewModel.<GridUserCols>d__27 <GridUserCols>d__;
			<GridUserCols>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<GridUserCols>d__.grid = grid;
			<GridUserCols>d__.userFields = userFields;
			<GridUserCols>d__.<>1__state = -1;
			<GridUserCols>d__.<>t__builder.Start<BaseViewModel.<GridUserCols>d__27>(ref <GridUserCols>d__);
		}

		// Token: 0x06002C2C RID: 11308 RVA: 0x0008D090 File Offset: 0x0008B290
		private void GridUserColsPE(GridControl grid, IList<fields> userFields)
		{
			BaseViewModel.<GridUserColsPE>d__28 <GridUserColsPE>d__;
			<GridUserColsPE>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<GridUserColsPE>d__.grid = grid;
			<GridUserColsPE>d__.userFields = userFields;
			<GridUserColsPE>d__.<>1__state = -1;
			<GridUserColsPE>d__.<>t__builder.Start<BaseViewModel.<GridUserColsPE>d__28>(ref <GridUserColsPE>d__);
		}

		// Token: 0x06002C2D RID: 11309 RVA: 0x0008D0D0 File Offset: 0x0008B2D0
		protected static GridColumn AttributeCol(fields field, BindingBase binding)
		{
			return new GridColumn
			{
				HorizontalHeaderContentAlignment = HorizontalAlignment.Center,
				FieldName = field.name,
				Name = "usercol_" + field.id.ToString(),
				Width = 150.0,
				Binding = binding,
				AllowMoving = DefaultBoolean.True,
				AllowSorting = DefaultBoolean.True,
				SortMode = ColumnSortMode.DisplayText
			};
		}

		// Token: 0x06002C2E RID: 11310 RVA: 0x0008D144 File Offset: 0x0008B344
		[Command]
		public void LayoutControlLoaded(object obj)
		{
			LayoutControl layoutControl = obj as LayoutControl;
			if (layoutControl == null)
			{
				return;
			}
			try
			{
				string cfgFileName = this.GetCfgFileName(layoutControl.Name);
				if (File.Exists(cfgFileName))
				{
					using (XmlReader xmlReader = XmlReader.Create(cfgFileName))
					{
						layoutControl.ReadFromXML(xmlReader);
						xmlReader.Close();
					}
				}
			}
			catch (Exception ex)
			{
				this._toasterServiceTmp.Error(ex.Message);
			}
		}

		// Token: 0x06002C2F RID: 11311 RVA: 0x0008D1C8 File Offset: 0x0008B3C8
		private static void CheckCfgFolder(string cfgFolder)
		{
			if (!Directory.Exists(cfgFolder))
			{
				Directory.CreateDirectory(cfgFolder);
			}
		}

		// Token: 0x06002C30 RID: 11312 RVA: 0x0008D1E4 File Offset: 0x0008B3E4
		private string GetCfgFolder()
		{
			string text = System.IO.Path.Combine(MediaModel.GetAppDir(), "cfg");
			BaseViewModel.CheckCfgFolder(text);
			return text;
		}

		// Token: 0x06002C31 RID: 11313 RVA: 0x0008D208 File Offset: 0x0008B408
		protected string GetCfgFileName(string name)
		{
			string cfgFolder = this.GetCfgFolder();
			if (!File.Exists(System.IO.Path.Combine(cfgFolder, name + "-" + OfflineData.Instance.Employee.Login.ToLower() + ".xml")))
			{
				return System.IO.Path.Combine(cfgFolder, name + ".xml");
			}
			return System.IO.Path.Combine(cfgFolder, name + "-" + OfflineData.Instance.Employee.Login.ToLower() + ".xml");
		}

		// Token: 0x06002C32 RID: 11314 RVA: 0x0008D28C File Offset: 0x0008B48C
		protected string SetCfgFileName(string name)
		{
			return System.IO.Path.Combine(this.GetCfgFolder(), name + "-" + OfflineData.Instance.Employee.Login.ToLower() + ".xml");
		}

		// Token: 0x06002C33 RID: 11315 RVA: 0x0008D2C8 File Offset: 0x0008B4C8
		[Command]
		public void LayoutControlCustomization(object obj)
		{
			LayoutControl layoutControl = obj as LayoutControl;
			if (layoutControl == null)
			{
				return;
			}
			try
			{
				if (!layoutControl.IsCustomization)
				{
					using (XmlWriter xmlWriter = XmlWriter.Create(this.SetCfgFileName(layoutControl.Name)))
					{
						layoutControl.WriteToXML(xmlWriter);
						xmlWriter.Close();
					}
				}
			}
			catch (Exception ex)
			{
				this._toasterServiceTmp.Error(ex.Message);
			}
		}

		// Token: 0x06002C34 RID: 11316 RVA: 0x0008D348 File Offset: 0x0008B548
		[Command]
		public void GridInit(object obj)
		{
			BaseViewModel.<GridInit>d__36 <GridInit>d__;
			<GridInit>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<GridInit>d__.<>4__this = this;
			<GridInit>d__.obj = obj;
			<GridInit>d__.<>1__state = -1;
			<GridInit>d__.<>t__builder.Start<BaseViewModel.<GridInit>d__36>(ref <GridInit>d__);
		}

		// Token: 0x06002C35 RID: 11317 RVA: 0x0008D388 File Offset: 0x0008B588
		[Command]
		public virtual void GridUnloaded(object obj)
		{
			DataControlBase dataControlBase = obj as DataControlBase;
			if (dataControlBase == null)
			{
				return;
			}
			try
			{
				string path = this.SetCfgFileName(string.Format("{0}", dataControlBase.Tag));
				dataControlBase.SaveLayoutToXml(path);
			}
			catch (Exception ex)
			{
				this._toasterServiceTmp.Error(ex.Message);
			}
		}

		// Token: 0x06002C36 RID: 11318 RVA: 0x0008D3E8 File Offset: 0x0008B5E8
		[Command]
		public void LayoutChanged(object obj)
		{
			if (!this._gridLoaded)
			{
				return;
			}
			this._layoutSaveTimer.Stop();
			this._layoutSaveTimer.Start();
			this._layoutSaveTimer.Tag = obj;
		}

		// Token: 0x06002C37 RID: 11319 RVA: 0x0008D420 File Offset: 0x0008B620
		private void _layoutSaveTimer_Tick(object sender, EventArgs e)
		{
			this._layoutSaveTimer.Stop();
			DispatcherTimer dispatcherTimer = sender as DispatcherTimer;
			if (dispatcherTimer != null)
			{
				this.GridUnloaded(dispatcherTimer.Tag);
			}
		}

		// Token: 0x06002C38 RID: 11320 RVA: 0x0008D450 File Offset: 0x0008B650
		public void ShowActionResponse(bool response, string msg = "")
		{
			if (response)
			{
				this._toasterServiceTmp.Success(msg);
				return;
			}
			this._toasterServiceTmp.Error(msg);
		}

		// Token: 0x06002C39 RID: 11321 RVA: 0x0008D47C File Offset: 0x0008B67C
		public bool CheckFields(ICheckFields doc)
		{
			string text = doc.CheckFields();
			if (!string.IsNullOrEmpty(text))
			{
				this._toasterServiceTmp.Info(Lang.t(text));
				return false;
			}
			return true;
		}

		// Token: 0x06002C3A RID: 11322 RVA: 0x0008D4AC File Offset: 0x0008B6AC
		[Command]
		public void CopyToClipboard(object obj)
		{
			if (obj == null)
			{
				return;
			}
			Clipboard.SetText(obj.ToString());
		}

		// Token: 0x06002C3B RID: 11323 RVA: 0x0008D4C8 File Offset: 0x0008B6C8
		public bool IsValid()
		{
			return Core.Instance.IsValid();
		}

		// Token: 0x06002C3C RID: 11324 RVA: 0x0008D4E0 File Offset: 0x0008B6E0
		public void SetViewLoaded(bool value)
		{
			this.ViewLoaded = value;
		}

		// Token: 0x06002C3D RID: 11325 RVA: 0x00023150 File Offset: 0x00021350
		[Command]
		public virtual void OnLoad()
		{
		}

		// Token: 0x06002C3E RID: 11326 RVA: 0x00023150 File Offset: 0x00021350
		[Command]
		public virtual void OnUnload()
		{
		}

		// Token: 0x06002C3F RID: 11327 RVA: 0x0008D4F4 File Offset: 0x0008B6F4
		public string ResourceTextOrEmpty(string textResourceName, bool returnText)
		{
			if (!returnText)
			{
				return "";
			}
			return Lang.t(textResourceName);
		}

		// Token: 0x0400188A RID: 6282
		[CompilerGenerated]
		private string <ViewName>k__BackingField;

		// Token: 0x0400188B RID: 6283
		[CompilerGenerated]
		private string <TabId>k__BackingField;

		// Token: 0x0400188C RID: 6284
		private readonly IWaitIndicatorService _waitIndicatorService;

		// Token: 0x0400188D RID: 6285
		private DispatcherTimer _layoutSaveTimer;

		// Token: 0x0400188E RID: 6286
		[CompilerGenerated]
		private bool <ViewLoaded>k__BackingField;

		// Token: 0x0400188F RID: 6287
		private ICommand onViewLoadedCommand;

		// Token: 0x04001890 RID: 6288
		protected bool _gridLoaded;

		// Token: 0x04001891 RID: 6289
		private IToasterService _toasterServiceTmp;

		// Token: 0x02000460 RID: 1120
		[CompilerGenerated]
		private sealed class <>c__DisplayClass27_0
		{
			// Token: 0x06002C40 RID: 11328 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass27_0()
			{
			}

			// Token: 0x06002C41 RID: 11329 RVA: 0x0008D510 File Offset: 0x0008B710
			internal bool <GridUserCols>b__0(GridColumn c)
			{
				return c.FieldName == this.field.name;
			}

			// Token: 0x04001892 RID: 6290
			public fields field;
		}

		// Token: 0x02000461 RID: 1121
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GridUserCols>d__27 : IAsyncStateMachine
		{
			// Token: 0x06002C42 RID: 11330 RVA: 0x0008D534 File Offset: 0x0008B734
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					if (this.userFields != null && this.userFields.Count != 0)
					{
						FieldValuesConverter converter = new FieldValuesConverter();
						this.grid.Columns.BeginUpdate();
						IEnumerator<fields> enumerator = this.userFields.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								BaseViewModel.<>c__DisplayClass27_0 CS$<>8__locals1 = new BaseViewModel.<>c__DisplayClass27_0();
								CS$<>8__locals1.field = enumerator.Current;
								if (!this.grid.Columns.Any(new Func<GridColumn, bool>(CS$<>8__locals1.<GridUserCols>b__0)))
								{
									Binding binding = new Binding("UserFields")
									{
										ConverterParameter = CS$<>8__locals1.field.id,
										Converter = converter,
										Mode = BindingMode.OneWay
									};
									GridColumn item = BaseViewModel.AttributeCol(CS$<>8__locals1.field, binding);
									try
									{
										this.grid.Columns.Add(item);
									}
									catch (Exception)
									{
									}
								}
							}
						}
						finally
						{
							if (num < 0 && enumerator != null)
							{
								enumerator.Dispose();
							}
						}
						this.grid.Columns.EndUpdate();
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

			// Token: 0x06002C43 RID: 11331 RVA: 0x0008D694 File Offset: 0x0008B894
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001893 RID: 6291
			public int <>1__state;

			// Token: 0x04001894 RID: 6292
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001895 RID: 6293
			public IList<fields> userFields;

			// Token: 0x04001896 RID: 6294
			public GridControl grid;
		}

		// Token: 0x02000462 RID: 1122
		[CompilerGenerated]
		private sealed class <>c__DisplayClass28_0
		{
			// Token: 0x06002C44 RID: 11332 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass28_0()
			{
			}

			// Token: 0x06002C45 RID: 11333 RVA: 0x0008D6B0 File Offset: 0x0008B8B0
			internal bool <GridUserColsPE>b__0(GridColumn c)
			{
				return c.FieldName == this.field.name;
			}

			// Token: 0x04001897 RID: 6295
			public fields field;
		}

		// Token: 0x02000463 RID: 1123
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GridUserColsPE>d__28 : IAsyncStateMachine
		{
			// Token: 0x06002C46 RID: 11334 RVA: 0x0008D6D4 File Offset: 0x0008B8D4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					if (this.userFields != null && this.userFields.Count != 0)
					{
						FieldValuesConverter converter = new FieldValuesConverter();
						IEnumerator<fields> enumerator = this.userFields.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								BaseViewModel.<>c__DisplayClass28_0 CS$<>8__locals1 = new BaseViewModel.<>c__DisplayClass28_0();
								CS$<>8__locals1.field = enumerator.Current;
								if (!this.grid.Columns.Any(new Func<GridColumn, bool>(CS$<>8__locals1.<GridUserColsPE>b__0)))
								{
									Binding binding = new Binding("Attributes")
									{
										ConverterParameter = CS$<>8__locals1.field.id,
										Converter = converter,
										Mode = BindingMode.OneWay
									};
									GridColumn gridColumn = BaseViewModel.AttributeCol(CS$<>8__locals1.field, binding);
									gridColumn.AllowFocus = false;
									try
									{
										this.grid.Columns.Add(gridColumn);
									}
									catch (Exception)
									{
									}
								}
							}
						}
						finally
						{
							if (num < 0 && enumerator != null)
							{
								enumerator.Dispose();
							}
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

			// Token: 0x06002C47 RID: 11335 RVA: 0x0008D81C File Offset: 0x0008BA1C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001898 RID: 6296
			public int <>1__state;

			// Token: 0x04001899 RID: 6297
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400189A RID: 6298
			public IList<fields> userFields;

			// Token: 0x0400189B RID: 6299
			public GridControl grid;
		}

		// Token: 0x02000464 RID: 1124
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GridInit>d__36 : IAsyncStateMachine
		{
			// Token: 0x06002C48 RID: 11336 RVA: 0x0008D838 File Offset: 0x0008BA38
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				BaseViewModel baseViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<fields>> awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<fields>>);
							this.<>1__state = -1;
							goto IL_173;
						}
						this.<grid>5__2 = (this.obj as GridControl);
						if (this.<grid>5__2 == null)
						{
							goto IL_21E;
						}
						this.<fieldsService>5__3 = Bootstrapper.Container.Resolve<IAdditionalFieldsService>();
						if (!(this.<grid>5__2.Name == "RepairsGridControl"))
						{
							goto IL_10C;
						}
						this.<>7__wrap3 = this.<grid>5__2;
						awaiter = this.<fieldsService>5__3.GetAdditionalFields(new bool?(false), false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<fields>>, BaseViewModel.<GridInit>d__36>(ref awaiter, ref this);
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
					baseViewModel.GridUserCols(this.<>7__wrap3, result);
					this.<>7__wrap3 = null;
					IL_10C:
					if (!(this.<grid>5__2.Name == "PriceEditorGrid"))
					{
						goto IL_18F;
					}
					this.<>7__wrap3 = this.<grid>5__2;
					awaiter = this.<fieldsService>5__3.GetAdditionalFields(new bool?(true), false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<fields>>, BaseViewModel.<GridInit>d__36>(ref awaiter, ref this);
						return;
					}
					IL_173:
					result = awaiter.GetResult();
					baseViewModel.GridUserColsPE(this.<>7__wrap3, result);
					this.<>7__wrap3 = null;
					IL_18F:
					try
					{
						string cfgFileName = baseViewModel.GetCfgFileName(string.Format("{0}", this.<grid>5__2.Tag));
						if (File.Exists(cfgFileName))
						{
							this.<grid>5__2.RestoreLayoutFromXml(cfgFileName);
							this.<grid>5__2.View.SearchString = null;
							baseViewModel._gridLoaded = true;
						}
					}
					catch (Exception ex)
					{
						baseViewModel._toasterServiceTmp.Error(ex.Message);
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<grid>5__2 = null;
					this.<fieldsService>5__3 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_21E:
				this.<>1__state = -2;
				this.<grid>5__2 = null;
				this.<fieldsService>5__3 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002C49 RID: 11337 RVA: 0x0008DAB8 File Offset: 0x0008BCB8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400189C RID: 6300
			public int <>1__state;

			// Token: 0x0400189D RID: 6301
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400189E RID: 6302
			public object obj;

			// Token: 0x0400189F RID: 6303
			public BaseViewModel <>4__this;

			// Token: 0x040018A0 RID: 6304
			private GridControl <grid>5__2;

			// Token: 0x040018A1 RID: 6305
			private IAdditionalFieldsService <fieldsService>5__3;

			// Token: 0x040018A2 RID: 6306
			private GridControl <>7__wrap3;

			// Token: 0x040018A3 RID: 6307
			private TaskAwaiter<List<fields>> <>u__1;
		}
	}
}
