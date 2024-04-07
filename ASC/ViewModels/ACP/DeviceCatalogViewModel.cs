using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ASC.Common.Interfaces;
using ASC.Extensions;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using Autofac;
using DevExpress.Xpf.Core;

namespace ASC.ViewModels.ACP
{
	// Token: 0x02000578 RID: 1400
	public class DeviceCatalogViewModel : RepairModel, INotifyPropertyChanged
	{
		// Token: 0x14000013 RID: 19
		// (add) Token: 0x060033B7 RID: 13239 RVA: 0x000AEEB4 File Offset: 0x000AD0B4
		// (remove) Token: 0x060033B8 RID: 13240 RVA: 0x000AEEF0 File Offset: 0x000AD0F0
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

		// Token: 0x17000FBD RID: 4029
		// (get) Token: 0x060033B9 RID: 13241 RVA: 0x000AEF2C File Offset: 0x000AD12C
		// (set) Token: 0x060033BA RID: 13242 RVA: 0x000AEF40 File Offset: 0x000AD140
		public ObservableCollection<IDevice> Devices
		{
			[CompilerGenerated]
			get
			{
				return this.<Devices>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Devices>k__BackingField, value))
				{
					return;
				}
				this.<Devices>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Devices);
			}
		}

		// Token: 0x17000FBE RID: 4030
		// (get) Token: 0x060033BB RID: 13243 RVA: 0x000AEF70 File Offset: 0x000AD170
		// (set) Token: 0x060033BC RID: 13244 RVA: 0x000AEF84 File Offset: 0x000AD184
		public ObservableCollection<IManufacturer> DeviceMakers
		{
			[CompilerGenerated]
			get
			{
				return this.<DeviceMakers>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<DeviceMakers>k__BackingField, value))
				{
					return;
				}
				this.<DeviceMakers>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.DeviceMakers);
			}
		}

		// Token: 0x17000FBF RID: 4031
		// (get) Token: 0x060033BD RID: 13245 RVA: 0x000AEFB4 File Offset: 0x000AD1B4
		// (set) Token: 0x060033BE RID: 13246 RVA: 0x000AEFC8 File Offset: 0x000AD1C8
		public string NewDeviceName
		{
			[CompilerGenerated]
			get
			{
				return this.<NewDeviceName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<NewDeviceName>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<NewDeviceName>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.NewDeviceName);
			}
		}

		// Token: 0x17000FC0 RID: 4032
		// (get) Token: 0x060033BF RID: 13247 RVA: 0x000AEFF8 File Offset: 0x000AD1F8
		// (set) Token: 0x060033C0 RID: 13248 RVA: 0x000AF00C File Offset: 0x000AD20C
		public IManufacturer NewDeviceMakers
		{
			[CompilerGenerated]
			get
			{
				return this.<NewDeviceMakers>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<NewDeviceMakers>k__BackingField, value))
				{
					return;
				}
				this.<NewDeviceMakers>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.NewDeviceMakers);
			}
		}

		// Token: 0x17000FC1 RID: 4033
		// (get) Token: 0x060033C1 RID: 13249 RVA: 0x000AF03C File Offset: 0x000AD23C
		// (set) Token: 0x060033C2 RID: 13250 RVA: 0x000AF050 File Offset: 0x000AD250
		public ObservableCollection<string> Faults
		{
			[CompilerGenerated]
			get
			{
				return this.<Faults>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Faults>k__BackingField, value))
				{
					return;
				}
				this.<Faults>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Faults);
			}
		}

		// Token: 0x17000FC2 RID: 4034
		// (get) Token: 0x060033C3 RID: 13251 RVA: 0x000AF080 File Offset: 0x000AD280
		// (set) Token: 0x060033C4 RID: 13252 RVA: 0x000AF094 File Offset: 0x000AD294
		public ObservableCollection<string> Look
		{
			[CompilerGenerated]
			get
			{
				return this.<Look>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Look>k__BackingField, value))
				{
					return;
				}
				this.<Look>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Look);
			}
		}

		// Token: 0x17000FC3 RID: 4035
		// (get) Token: 0x060033C5 RID: 13253 RVA: 0x000AF0C4 File Offset: 0x000AD2C4
		// (set) Token: 0x060033C6 RID: 13254 RVA: 0x000AF0D8 File Offset: 0x000AD2D8
		public ObservableCollection<string> Complect
		{
			[CompilerGenerated]
			get
			{
				return this.<Complect>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<Complect>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1237414829;
				IL_13:
				switch ((num ^ 1837392459) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					IL_32:
					num = 1859080808;
					goto IL_13;
				case 2:
					return;
				}
				this.<Complect>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Complect);
			}
		}

		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x060033C7 RID: 13255 RVA: 0x000AF134 File Offset: 0x000AD334
		// (set) Token: 0x060033C8 RID: 13256 RVA: 0x000AF148 File Offset: 0x000AD348
		public string NewFault
		{
			[CompilerGenerated]
			get
			{
				return this.<NewFault>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<NewFault>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<NewFault>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.NewFault);
			}
		}

		// Token: 0x17000FC5 RID: 4037
		// (get) Token: 0x060033C9 RID: 13257 RVA: 0x000AF178 File Offset: 0x000AD378
		// (set) Token: 0x060033CA RID: 13258 RVA: 0x000AF18C File Offset: 0x000AD38C
		public string NewLook
		{
			[CompilerGenerated]
			get
			{
				return this.<NewLook>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<NewLook>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<NewLook>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.NewLook);
			}
		}

		// Token: 0x17000FC6 RID: 4038
		// (get) Token: 0x060033CB RID: 13259 RVA: 0x000AF1BC File Offset: 0x000AD3BC
		// (set) Token: 0x060033CC RID: 13260 RVA: 0x000AF1D0 File Offset: 0x000AD3D0
		public string NewComplect
		{
			[CompilerGenerated]
			get
			{
				return this.<NewComplect>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<NewComplect>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<NewComplect>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.NewComplect);
			}
		}

		// Token: 0x17000FC7 RID: 4039
		// (get) Token: 0x060033CD RID: 13261 RVA: 0x000AF200 File Offset: 0x000AD400
		// (set) Token: 0x060033CE RID: 13262 RVA: 0x000AF214 File Offset: 0x000AD414
		public bool DeviceOptionsVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<DeviceOptionsVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<DeviceOptionsVisible>k__BackingField == value)
				{
					return;
				}
				this.<DeviceOptionsVisible>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.DeviceOptionsVisible);
			}
		}

		// Token: 0x17000FC8 RID: 4040
		// (get) Token: 0x060033CF RID: 13263 RVA: 0x000AF240 File Offset: 0x000AD440
		// (set) Token: 0x060033D0 RID: 13264 RVA: 0x000AF254 File Offset: 0x000AD454
		public IDevice SelectedDevice
		{
			get
			{
				return this._selectedDevice;
			}
			set
			{
				if (!object.Equals(this._selectedDevice, value))
				{
					for (;;)
					{
						IL_C5:
						this._selectedDevice = value;
						for (;;)
						{
							IL_AE:
							this.<>OnPropertyChanged(<>PropertyChangedEventArgs.SelectedDevice);
							this.SelectedMaker = null;
							if (value == null)
							{
								goto IL_E9;
							}
							for (;;)
							{
								IL_98:
								this.DeviceOptionsVisible = !this._selectedDevice.Refill;
								for (;;)
								{
									IL_90:
									this.LoadDeviceOptions();
									for (;;)
									{
										IL_82:
										this.NewDeviceName = value.Name;
										for (;;)
										{
											RelayCommand updateDeviceCommand = this.UpdateDeviceCommand;
											if (updateDeviceCommand != null)
											{
												updateDeviceCommand.RaiseCanExecuteChanged();
												uint num;
												switch ((num = (num * 1555018664U ^ 2813296044U ^ 1682846477U)) % 15U)
												{
												case 0U:
													goto IL_E9;
												case 1U:
													continue;
												case 2U:
													goto IL_AE;
												case 4U:
												case 6U:
													goto IL_C5;
												case 5U:
												case 8U:
													return;
												case 7U:
													goto IL_E1;
												case 9U:
													goto IL_98;
												case 10U:
													goto IL_D0;
												case 12U:
													goto IL_90;
												case 13U:
													goto IL_82;
												}
												goto Block_3;
											}
											goto IL_CF;
										}
									}
								}
							}
						}
					}
					Block_3:
					return;
					IL_CF:
					IL_D0:
					RelayCommand setAsCartridgeCommand = this.SetAsCartridgeCommand;
					if (setAsCartridgeCommand != null)
					{
						setAsCartridgeCommand.RaiseCanExecuteChanged();
					}
					IL_E1:
					this.ResetMaker();
					return;
					IL_E9:
					this.DeviceOptionsVisible = true;
					return;
				}
			}
		}

		// Token: 0x17000FC9 RID: 4041
		// (get) Token: 0x060033D1 RID: 13265 RVA: 0x000AF354 File Offset: 0x000AD554
		// (set) Token: 0x060033D2 RID: 13266 RVA: 0x000AF368 File Offset: 0x000AD568
		public IManufacturer SelectedMaker
		{
			get
			{
				return this._selectedMaker;
			}
			set
			{
				if (object.Equals(this._selectedMaker, value))
				{
					return;
				}
				this._selectedMaker = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.SelectedMaker);
				if (value != null)
				{
					this.NewDeviceMakers.Name = value.Name;
					this.UpdateMakerCommand.RaiseCanExecuteChanged();
				}
			}
		}

		// Token: 0x17000FCA RID: 4042
		// (get) Token: 0x060033D3 RID: 13267 RVA: 0x000AF3B8 File Offset: 0x000AD5B8
		// (set) Token: 0x060033D4 RID: 13268 RVA: 0x000AF3CC File Offset: 0x000AD5CC
		public ICommand AddNewDeviceCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<AddNewDeviceCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<AddNewDeviceCommand>k__BackingField, value))
				{
					return;
				}
				this.<AddNewDeviceCommand>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.AddNewDeviceCommand);
			}
		}

		// Token: 0x17000FCB RID: 4043
		// (get) Token: 0x060033D5 RID: 13269 RVA: 0x000AF3FC File Offset: 0x000AD5FC
		// (set) Token: 0x060033D6 RID: 13270 RVA: 0x000AF410 File Offset: 0x000AD610
		public RelayCommand UpdateDeviceCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<UpdateDeviceCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<UpdateDeviceCommand>k__BackingField, value))
				{
					return;
				}
				this.<UpdateDeviceCommand>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.UpdateDeviceCommand);
			}
		}

		// Token: 0x17000FCC RID: 4044
		// (get) Token: 0x060033D7 RID: 13271 RVA: 0x000AF440 File Offset: 0x000AD640
		// (set) Token: 0x060033D8 RID: 13272 RVA: 0x000AF454 File Offset: 0x000AD654
		public RelayCommand UpdateMakerCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<UpdateMakerCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<UpdateMakerCommand>k__BackingField, value))
				{
					return;
				}
				this.<UpdateMakerCommand>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.UpdateMakerCommand);
			}
		}

		// Token: 0x17000FCD RID: 4045
		// (get) Token: 0x060033D9 RID: 13273 RVA: 0x000AF484 File Offset: 0x000AD684
		// (set) Token: 0x060033DA RID: 13274 RVA: 0x000AF498 File Offset: 0x000AD698
		public RelayCommand SetAsCartridgeCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<SetAsCartridgeCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SetAsCartridgeCommand>k__BackingField, value))
				{
					return;
				}
				this.<SetAsCartridgeCommand>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.SetAsCartridgeCommand);
			}
		}

		// Token: 0x17000FCE RID: 4046
		// (get) Token: 0x060033DB RID: 13275 RVA: 0x000AF4C8 File Offset: 0x000AD6C8
		// (set) Token: 0x060033DC RID: 13276 RVA: 0x000AF4DC File Offset: 0x000AD6DC
		public ICommand AddNewDeviceMakerCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<AddNewDeviceMakerCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<AddNewDeviceMakerCommand>k__BackingField, value))
				{
					return;
				}
				this.<AddNewDeviceMakerCommand>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.AddNewDeviceMakerCommand);
			}
		}

		// Token: 0x17000FCF RID: 4047
		// (get) Token: 0x060033DD RID: 13277 RVA: 0x000AF50C File Offset: 0x000AD70C
		// (set) Token: 0x060033DE RID: 13278 RVA: 0x000AF520 File Offset: 0x000AD720
		public ICommand AddNewFaultCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<AddNewFaultCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<AddNewFaultCommand>k__BackingField, value))
				{
					return;
				}
				this.<AddNewFaultCommand>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.AddNewFaultCommand);
			}
		}

		// Token: 0x17000FD0 RID: 4048
		// (get) Token: 0x060033DF RID: 13279 RVA: 0x000AF550 File Offset: 0x000AD750
		// (set) Token: 0x060033E0 RID: 13280 RVA: 0x000AF564 File Offset: 0x000AD764
		public ICommand AddNewLookCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<AddNewLookCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<AddNewLookCommand>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1450817206;
				IL_13:
				switch ((num ^ -19265679) % 4)
				{
				case 0:
					goto IL_0E;
				case 2:
					IL_32:
					this.<AddNewLookCommand>k__BackingField = value;
					this.<>OnPropertyChanged(<>PropertyChangedEventArgs.AddNewLookCommand);
					num = -264243480;
					goto IL_13;
				case 3:
					return;
				}
			}
		}

		// Token: 0x17000FD1 RID: 4049
		// (get) Token: 0x060033E1 RID: 13281 RVA: 0x000AF5C0 File Offset: 0x000AD7C0
		// (set) Token: 0x060033E2 RID: 13282 RVA: 0x000AF5D4 File Offset: 0x000AD7D4
		public ICommand AddNewComplectCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<AddNewComplectCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<AddNewComplectCommand>k__BackingField, value))
				{
					return;
				}
				this.<AddNewComplectCommand>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.AddNewComplectCommand);
			}
		}

		// Token: 0x17000FD2 RID: 4050
		// (get) Token: 0x060033E3 RID: 13283 RVA: 0x000AF604 File Offset: 0x000AD804
		// (set) Token: 0x060033E4 RID: 13284 RVA: 0x000AF618 File Offset: 0x000AD818
		public ICommand DelDeviceCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<DelDeviceCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<DelDeviceCommand>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -341220335;
				IL_13:
				switch ((num ^ -361697058) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					IL_32:
					num = -696506228;
					goto IL_13;
				case 3:
					return;
				}
				this.<DelDeviceCommand>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.DelDeviceCommand);
			}
		}

		// Token: 0x17000FD3 RID: 4051
		// (get) Token: 0x060033E5 RID: 13285 RVA: 0x000AF674 File Offset: 0x000AD874
		// (set) Token: 0x060033E6 RID: 13286 RVA: 0x000AF688 File Offset: 0x000AD888
		public ICommand DelDeviceMakerCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<DelDeviceMakerCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<DelDeviceMakerCommand>k__BackingField, value))
				{
					return;
				}
				this.<DelDeviceMakerCommand>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.DelDeviceMakerCommand);
			}
		}

		// Token: 0x17000FD4 RID: 4052
		// (get) Token: 0x060033E7 RID: 13287 RVA: 0x000AF6B8 File Offset: 0x000AD8B8
		// (set) Token: 0x060033E8 RID: 13288 RVA: 0x000AF6CC File Offset: 0x000AD8CC
		public ICommand DelFaultCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<DelFaultCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<DelFaultCommand>k__BackingField, value))
				{
					return;
				}
				this.<DelFaultCommand>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.DelFaultCommand);
			}
		}

		// Token: 0x17000FD5 RID: 4053
		// (get) Token: 0x060033E9 RID: 13289 RVA: 0x000AF6FC File Offset: 0x000AD8FC
		// (set) Token: 0x060033EA RID: 13290 RVA: 0x000AF710 File Offset: 0x000AD910
		public ICommand DelLookCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<DelLookCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<DelLookCommand>k__BackingField, value))
				{
					return;
				}
				this.<DelLookCommand>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.DelLookCommand);
			}
		}

		// Token: 0x17000FD6 RID: 4054
		// (get) Token: 0x060033EB RID: 13291 RVA: 0x000AF740 File Offset: 0x000AD940
		// (set) Token: 0x060033EC RID: 13292 RVA: 0x000AF754 File Offset: 0x000AD954
		public ICommand ElementUpCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<ElementUpCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ElementUpCommand>k__BackingField, value))
				{
					return;
				}
				this.<ElementUpCommand>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.ElementUpCommand);
			}
		}

		// Token: 0x17000FD7 RID: 4055
		// (get) Token: 0x060033ED RID: 13293 RVA: 0x000AF784 File Offset: 0x000AD984
		// (set) Token: 0x060033EE RID: 13294 RVA: 0x000AF798 File Offset: 0x000AD998
		public ICommand ElementMakerUpCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<ElementMakerUpCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ElementMakerUpCommand>k__BackingField, value))
				{
					return;
				}
				this.<ElementMakerUpCommand>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.ElementMakerUpCommand);
			}
		}

		// Token: 0x17000FD8 RID: 4056
		// (get) Token: 0x060033EF RID: 13295 RVA: 0x000AF7C8 File Offset: 0x000AD9C8
		// (set) Token: 0x060033F0 RID: 13296 RVA: 0x000AF7DC File Offset: 0x000AD9DC
		public ICommand FaultUpCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<FaultUpCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<FaultUpCommand>k__BackingField, value))
				{
					return;
				}
				this.<FaultUpCommand>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.FaultUpCommand);
			}
		}

		// Token: 0x17000FD9 RID: 4057
		// (get) Token: 0x060033F1 RID: 13297 RVA: 0x000AF80C File Offset: 0x000ADA0C
		// (set) Token: 0x060033F2 RID: 13298 RVA: 0x000AF820 File Offset: 0x000ADA20
		public ICommand LookUpCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<LookUpCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<LookUpCommand>k__BackingField, value))
				{
					return;
				}
				this.<LookUpCommand>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.LookUpCommand);
			}
		}

		// Token: 0x17000FDA RID: 4058
		// (get) Token: 0x060033F3 RID: 13299 RVA: 0x000AF850 File Offset: 0x000ADA50
		// (set) Token: 0x060033F4 RID: 13300 RVA: 0x000AF864 File Offset: 0x000ADA64
		public ICommand LookDownCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<LookDownCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<LookDownCommand>k__BackingField, value))
				{
					return;
				}
				this.<LookDownCommand>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.LookDownCommand);
			}
		}

		// Token: 0x17000FDB RID: 4059
		// (get) Token: 0x060033F5 RID: 13301 RVA: 0x000AF894 File Offset: 0x000ADA94
		// (set) Token: 0x060033F6 RID: 13302 RVA: 0x000AF8A8 File Offset: 0x000ADAA8
		public ICommand FaultDownCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<FaultDownCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<FaultDownCommand>k__BackingField, value))
				{
					return;
				}
				this.<FaultDownCommand>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.FaultDownCommand);
			}
		}

		// Token: 0x17000FDC RID: 4060
		// (get) Token: 0x060033F7 RID: 13303 RVA: 0x000AF8D8 File Offset: 0x000ADAD8
		// (set) Token: 0x060033F8 RID: 13304 RVA: 0x000AF8EC File Offset: 0x000ADAEC
		public ICommand ElementDownCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<ElementDownCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ElementDownCommand>k__BackingField, value))
				{
					return;
				}
				this.<ElementDownCommand>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.ElementDownCommand);
			}
		}

		// Token: 0x17000FDD RID: 4061
		// (get) Token: 0x060033F9 RID: 13305 RVA: 0x000AF91C File Offset: 0x000ADB1C
		// (set) Token: 0x060033FA RID: 13306 RVA: 0x000AF930 File Offset: 0x000ADB30
		public ICommand ElementMakerDownCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<ElementMakerDownCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ElementMakerDownCommand>k__BackingField, value))
				{
					return;
				}
				this.<ElementMakerDownCommand>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.ElementMakerDownCommand);
			}
		}

		// Token: 0x17000FDE RID: 4062
		// (get) Token: 0x060033FB RID: 13307 RVA: 0x000AF960 File Offset: 0x000ADB60
		// (set) Token: 0x060033FC RID: 13308 RVA: 0x000AF974 File Offset: 0x000ADB74
		public ICommand ComplectDownCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<ComplectDownCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ComplectDownCommand>k__BackingField, value))
				{
					return;
				}
				this.<ComplectDownCommand>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.ComplectDownCommand);
			}
		}

		// Token: 0x17000FDF RID: 4063
		// (get) Token: 0x060033FD RID: 13309 RVA: 0x000AF9A4 File Offset: 0x000ADBA4
		// (set) Token: 0x060033FE RID: 13310 RVA: 0x000AF9B8 File Offset: 0x000ADBB8
		public ICommand ComplectUpCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<ComplectUpCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<ComplectUpCommand>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1779251812;
				IL_13:
				switch ((num ^ -1505773107) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					return;
				case 2:
					IL_32:
					this.<ComplectUpCommand>k__BackingField = value;
					num = -1882293022;
					goto IL_13;
				}
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.ComplectUpCommand);
			}
		}

		// Token: 0x17000FE0 RID: 4064
		// (get) Token: 0x060033FF RID: 13311 RVA: 0x000AFA14 File Offset: 0x000ADC14
		// (set) Token: 0x06003400 RID: 13312 RVA: 0x000AFA28 File Offset: 0x000ADC28
		public ICommand DelComplectCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<DelComplectCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<DelComplectCommand>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -829032536;
				IL_13:
				switch ((num ^ -1375774086) % 4)
				{
				case 1:
					IL_32:
					num = -126539050;
					goto IL_13;
				case 2:
					return;
				case 3:
					goto IL_0E;
				}
				this.<DelComplectCommand>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.DelComplectCommand);
			}
		}

		// Token: 0x06003401 RID: 13313 RVA: 0x000AFA84 File Offset: 0x000ADC84
		private void InitCommands()
		{
			this.AddNewDeviceCommand = new RelayCommand(new Action<object>(this.AddNewDevice));
			this.UpdateDeviceCommand = new RelayCommand(new Action<object>(this.UpdateDevice), new Func<bool>(this.CanUpdateDevice));
			this.UpdateMakerCommand = new RelayCommand(new Action<object>(this.UpdateMaker), new Func<bool>(this.CanUpdateMaker));
			this.AddNewDeviceMakerCommand = new RelayCommand(new Action<object>(this.AddNewDeviceMaker));
			this.AddNewFaultCommand = new RelayCommand(new Action<object>(this.AddNewFault));
			this.DelDeviceCommand = new RelayCommand(new Action<object>(this.DelDevice));
			this.ElementUpCommand = new RelayCommand(new Action<object>(this.DeviceUp));
			this.ElementDownCommand = new RelayCommand(new Action<object>(this.DeviceDown));
			this.ElementMakerDownCommand = new RelayCommand(new Action<object>(this.MakerDown));
			this.ElementMakerUpCommand = new RelayCommand(new Action<object>(this.MakerUp));
			this.DelDeviceMakerCommand = new RelayCommand(new Action<object>(this.DeleteMaker));
			this.FaultDownCommand = new RelayCommand(new Action<object>(this.FaultDown));
			this.FaultUpCommand = new RelayCommand(new Action<object>(this.FaultUp));
			this.DelFaultCommand = new RelayCommand(new Action<object>(this.DelFault));
			this.DelLookCommand = new RelayCommand(new Action<object>(this.DelLook));
			this.LookUpCommand = new RelayCommand(new Action<object>(this.LookUp));
			this.LookDownCommand = new RelayCommand(new Action<object>(this.LookDown));
			this.AddNewLookCommand = new RelayCommand(new Action<object>(this.AddNewLook));
			this.AddNewComplectCommand = new RelayCommand(new Action<object>(this.AddNewComplect));
			this.ComplectUpCommand = new RelayCommand(new Action<object>(this.ComplectUp));
			this.ComplectDownCommand = new RelayCommand(new Action<object>(this.ComplectDown));
			this.DelComplectCommand = new RelayCommand(new Action<object>(this.DelComplect));
			this.SetAsCartridgeCommand = new RelayCommand(new Action<object>(this.SetAsCartridge), new Func<bool>(this.CanMarkAsCartridge));
		}

		// Token: 0x06003402 RID: 13314 RVA: 0x000AFCC8 File Offset: 0x000ADEC8
		private bool CanMarkAsCartridge()
		{
			return this.SelectedDevice != null && this.SelectedDevice.Id != 0;
		}

		// Token: 0x06003403 RID: 13315 RVA: 0x000AFCF0 File Offset: 0x000ADEF0
		private bool CanUpdateMaker()
		{
			return this.SelectedMaker != null && this.SelectedMaker.Id != 0;
		}

		// Token: 0x06003404 RID: 13316 RVA: 0x000AFCC8 File Offset: 0x000ADEC8
		private bool CanUpdateDevice()
		{
			return this.SelectedDevice != null && this.SelectedDevice.Id != 0;
		}

		// Token: 0x06003405 RID: 13317 RVA: 0x000AFD18 File Offset: 0x000ADF18
		public DeviceCatalogViewModel()
		{
			this._workshopService = Bootstrapper.Container.Resolve<IWorkshopService>();
			this.Devices = new ObservableCollection<IDevice>();
			this.DeviceMakers = new ObservableCollection<IManufacturer>();
			this.NewDeviceMakers = new Manufacturer();
			this.InitCommands();
			this.LoadDevices();
		}

		// Token: 0x06003406 RID: 13318 RVA: 0x000AFD70 File Offset: 0x000ADF70
		private void DelComplect(object obj)
		{
			if (this.ConfirmDelete())
			{
				this.Complect.Remove(obj.ToString());
				this.SaveComplectPosition();
			}
		}

		// Token: 0x06003407 RID: 13319 RVA: 0x000AFDA0 File Offset: 0x000ADFA0
		private void ComplectDown(object obj)
		{
			this.Complect.MoveItemDown(obj.ToString());
			this.SaveComplectPosition();
		}

		// Token: 0x06003408 RID: 13320 RVA: 0x000AFDC4 File Offset: 0x000ADFC4
		private void ComplectUp(object obj)
		{
			this.Complect.MoveItemUp(obj.ToString());
			this.SaveComplectPosition();
		}

		// Token: 0x06003409 RID: 13321 RVA: 0x000AFDE8 File Offset: 0x000ADFE8
		private void AddNewComplect(object obj)
		{
			if (!this.CheckField(this.NewComplect))
			{
				return;
			}
			this.Complect.Add(this.NewComplect);
			this.SaveComplectPosition();
			this.NewComplect = string.Empty;
		}

		// Token: 0x0600340A RID: 13322 RVA: 0x000AFE28 File Offset: 0x000AE028
		private void SaveComplectPosition()
		{
			DeviceCatalogViewModel.<SaveComplectPosition>d__157 <SaveComplectPosition>d__;
			<SaveComplectPosition>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SaveComplectPosition>d__.<>4__this = this;
			<SaveComplectPosition>d__.<>1__state = -1;
			<SaveComplectPosition>d__.<>t__builder.Start<DeviceCatalogViewModel.<SaveComplectPosition>d__157>(ref <SaveComplectPosition>d__);
		}

		// Token: 0x0600340B RID: 13323 RVA: 0x000AFE60 File Offset: 0x000AE060
		private void AddNewLook(object obj)
		{
			if (!this.CheckField(this.NewLook))
			{
				return;
			}
			if (this.Look != null)
			{
				this.Look.Add(this.NewLook);
				this.SaveLookPosition();
				this.NewLook = string.Empty;
			}
		}

		// Token: 0x0600340C RID: 13324 RVA: 0x000AFEA8 File Offset: 0x000AE0A8
		private void LookDown(object obj)
		{
			this.Look.MoveItemDown(obj.ToString());
			this.SaveLookPosition();
		}

		// Token: 0x0600340D RID: 13325 RVA: 0x000AFECC File Offset: 0x000AE0CC
		private void LookUp(object obj)
		{
			this.Look.MoveItemUp(obj.ToString());
			this.SaveLookPosition();
		}

		// Token: 0x0600340E RID: 13326 RVA: 0x000AFEF0 File Offset: 0x000AE0F0
		private void DelLook(object obj)
		{
			if (this.ConfirmDelete())
			{
				this.Look.Remove(obj.ToString());
				this.SaveLookPosition();
			}
		}

		// Token: 0x0600340F RID: 13327 RVA: 0x000AFF20 File Offset: 0x000AE120
		private void SaveLookPosition()
		{
			DeviceCatalogViewModel.<SaveLookPosition>d__162 <SaveLookPosition>d__;
			<SaveLookPosition>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SaveLookPosition>d__.<>4__this = this;
			<SaveLookPosition>d__.<>1__state = -1;
			<SaveLookPosition>d__.<>t__builder.Start<DeviceCatalogViewModel.<SaveLookPosition>d__162>(ref <SaveLookPosition>d__);
		}

		// Token: 0x06003410 RID: 13328 RVA: 0x000AFF58 File Offset: 0x000AE158
		private string Position(ObservableCollection<string> items)
		{
			int num = 0;
			string[] array = new string[items.Count];
			foreach (string text in items)
			{
				array[num] = text;
				num++;
			}
			return string.Join(",", array);
		}

		// Token: 0x06003411 RID: 13329 RVA: 0x000AFFBC File Offset: 0x000AE1BC
		private void DelFault(object obj)
		{
			if (this.ConfirmDelete())
			{
				this.Faults.Remove(obj.ToString());
				this.SaveFaultPosition();
			}
		}

		// Token: 0x06003412 RID: 13330 RVA: 0x000AFFEC File Offset: 0x000AE1EC
		private bool ConfirmDelete()
		{
			return DXMessageBox.Show(Lang.t("Delete"), Lang.t("Delete"), MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes;
		}

		// Token: 0x06003413 RID: 13331 RVA: 0x000B0018 File Offset: 0x000AE218
		private void FaultUp(object obj)
		{
			this.Faults.MoveItemUp(obj.ToString());
			this.SaveFaultPosition();
		}

		// Token: 0x06003414 RID: 13332 RVA: 0x000B003C File Offset: 0x000AE23C
		private void FaultDown(object obj)
		{
			this.Faults.MoveItemDown(obj.ToString());
			this.SaveFaultPosition();
		}

		// Token: 0x06003415 RID: 13333 RVA: 0x000B0060 File Offset: 0x000AE260
		private void AddNewFault(object obj)
		{
			if (!this.CheckField(this.NewFault))
			{
				return;
			}
			if (this.Faults != null)
			{
				this.Faults.Add(this.NewFault);
				this.SaveFaultPosition();
				this.NewFault = string.Empty;
			}
		}

		// Token: 0x06003416 RID: 13334 RVA: 0x000B00A8 File Offset: 0x000AE2A8
		private void SaveFaultPosition()
		{
			DeviceCatalogViewModel.<SaveFaultPosition>d__169 <SaveFaultPosition>d__;
			<SaveFaultPosition>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SaveFaultPosition>d__.<>4__this = this;
			<SaveFaultPosition>d__.<>1__state = -1;
			<SaveFaultPosition>d__.<>t__builder.Start<DeviceCatalogViewModel.<SaveFaultPosition>d__169>(ref <SaveFaultPosition>d__);
		}

		// Token: 0x06003417 RID: 13335 RVA: 0x000B00E0 File Offset: 0x000AE2E0
		private void DeleteMaker(object obj)
		{
			if (this.ConfirmDelete())
			{
				int makerId = (int)obj;
				IManufacturer manufacturer = this.DeviceMakers.FirstOrDefault((IManufacturer m) => m.Id == makerId);
				if (manufacturer != null)
				{
					this.DeviceMakers.Remove(manufacturer);
				}
				this.SaveMakerPosition();
				this.ResetMaker();
			}
		}

		// Token: 0x06003418 RID: 13336 RVA: 0x000B013C File Offset: 0x000AE33C
		private void ResetMaker()
		{
			this.SelectedMaker = null;
			this.NewDeviceMakers = null;
			this.NewDeviceMakers = new Manufacturer();
			this.UpdateMakerCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x06003419 RID: 13337 RVA: 0x000B0170 File Offset: 0x000AE370
		private void MakerUp(object obj)
		{
			IManufacturer manufacturer = this.DeviceMakers.FirstOrDefault((IManufacturer d) => d.Id == (int)obj);
			if (manufacturer == null)
			{
				return;
			}
			this.DeviceMakers.MoveItemUp(manufacturer);
			this.SaveMakerPosition();
		}

		// Token: 0x0600341A RID: 13338 RVA: 0x000B01B8 File Offset: 0x000AE3B8
		private void MakerDown(object obj)
		{
			IManufacturer manufacturer = this.DeviceMakers.FirstOrDefault((IManufacturer d) => d.Id == (int)obj);
			if (manufacturer != null)
			{
				this.DeviceMakers.MoveItemDown(manufacturer);
				this.SaveMakerPosition();
				return;
			}
		}

		// Token: 0x0600341B RID: 13339 RVA: 0x000B0200 File Offset: 0x000AE400
		private void SaveMakerPosition()
		{
			int num = 0;
			int[] array = new int[this.DeviceMakers.Count];
			foreach (IManufacturer manufacturer in this.DeviceMakers)
			{
				array[num] = manufacturer.Id;
				num++;
			}
			this.SelectedDevice.CompanyList = string.Join<int>(",", array);
			base.UpdateCompanyList(this.SelectedDevice);
		}

		// Token: 0x0600341C RID: 13340 RVA: 0x000B028C File Offset: 0x000AE48C
		private void AddNewDeviceMaker(object obj)
		{
			DeviceCatalogViewModel.<AddNewDeviceMaker>d__175 <AddNewDeviceMaker>d__;
			<AddNewDeviceMaker>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<AddNewDeviceMaker>d__.<>4__this = this;
			<AddNewDeviceMaker>d__.<>1__state = -1;
			<AddNewDeviceMaker>d__.<>t__builder.Start<DeviceCatalogViewModel.<AddNewDeviceMaker>d__175>(ref <AddNewDeviceMaker>d__);
		}

		// Token: 0x0600341D RID: 13341 RVA: 0x000B02C4 File Offset: 0x000AE4C4
		private bool CheckFieldsNewMaker()
		{
			if (this.SelectedDevice == null)
			{
				DXMessageBox.Show(Lang.t("SelectDevice"));
				return false;
			}
			if (!this.CheckField(this.NewDeviceMakers.Name))
			{
				return false;
			}
			if (!base.MakerExist(this.NewDeviceMakers.Name, this.SelectedDevice.Id))
			{
				return true;
			}
			DXMessageBox.Show(Lang.t("MakerAlreadyExist"));
			return false;
		}

		// Token: 0x0600341E RID: 13342 RVA: 0x000B0334 File Offset: 0x000AE534
		private void DeviceDown(object obj)
		{
			IDevice device = this.Devices.FirstOrDefault((IDevice d) => d.Id == (int)obj);
			if (device == null)
			{
				return;
			}
			this.Devices.MoveItemDown(device);
			this.SaveDevicePosition();
		}

		// Token: 0x0600341F RID: 13343 RVA: 0x000B037C File Offset: 0x000AE57C
		private void DeviceUp(object obj)
		{
			IDevice device = this.Devices.FirstOrDefault((IDevice d) => d.Id == (int)obj);
			if (device != null)
			{
				this.Devices.MoveItemUp(device);
				this.SaveDevicePosition();
				return;
			}
		}

		// Token: 0x06003420 RID: 13344 RVA: 0x000B03C4 File Offset: 0x000AE5C4
		private void SaveDevicePosition()
		{
			try
			{
				int num = 1;
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					auseceEntities.Configuration.ValidateOnSaveEnabled = false;
					foreach (IDevice device in this.Devices)
					{
						devices devices = auseceEntities.devices.Find(new object[]
						{
							device.Id
						});
						if (devices != null)
						{
							devices.position = new int?(num);
						}
						num++;
					}
					auseceEntities.SaveChanges();
				}
			}
			catch (Exception ex)
			{
				GenericModel.Log.Error(ex, ex.Message);
			}
		}

		// Token: 0x06003421 RID: 13345 RVA: 0x000B049C File Offset: 0x000AE69C
		private void DelDevice(object obj)
		{
			if (this.ConfirmDelete())
			{
				int deviceId = (int)obj;
				devices devices = this._context.devices.FirstOrDefault((devices d) => d.id == deviceId);
				if (devices != null)
				{
					devices.enable = new bool?(false);
					base.SaveContext(false);
					IDevice item = this.Devices.FirstOrDefault((IDevice d) => d.Id == deviceId);
					this.Devices.Remove(item);
					this.SelectedDevice = null;
					this.RefreshDevices();
				}
			}
		}

		// Token: 0x06003422 RID: 13346 RVA: 0x000B0580 File Offset: 0x000AE780
		private void AddNewDevice(object obj)
		{
			if (!this.CheckNewDevice(this.NewDeviceName))
			{
				goto IL_2A;
			}
			goto IL_62;
			int num;
			for (;;)
			{
				IL_2F:
				switch ((num ^ -1414167245) % 6)
				{
				case 0:
					goto IL_2A;
				case 1:
					goto IL_62;
				case 2:
					return;
				case 4:
					return;
				case 5:
					this.RefreshDevices();
					num = -1727898070;
					continue;
				}
				break;
			}
			return;
			IL_2A:
			num = -1104549147;
			goto IL_2F;
			IL_62:
			this._context.devices.Add(new devices
			{
				enable = new bool?(true),
				name = this.NewDeviceName
			});
			num = ((!base.SaveContext(false)) ? -1572183637 : -1859213172);
			goto IL_2F;
		}

		// Token: 0x06003423 RID: 13347 RVA: 0x000B0630 File Offset: 0x000AE830
		private bool CheckNewDevice(string deviceName)
		{
			if (string.IsNullOrEmpty(this.NewDeviceName))
			{
				DXMessageBox.Show(Lang.t("ItemError"));
				return false;
			}
			if (base.DeviceExist(deviceName))
			{
				DXMessageBox.Show(Lang.t("DeviceAlreadyExist"));
				return false;
			}
			return true;
		}

		// Token: 0x06003424 RID: 13348 RVA: 0x000B0678 File Offset: 0x000AE878
		private void RefreshDevices()
		{
			this.SelectedDevice = null;
			this.SelectedMaker = null;
			for (;;)
			{
				IL_8F:
				this.NewDeviceName = "";
				for (;;)
				{
					IL_82:
					this.UpdateDeviceCommand.RaiseCanExecuteChanged();
					for (;;)
					{
						IL_7A:
						this.ResetMaker();
						for (;;)
						{
							IL_71:
							this.Look = null;
							for (;;)
							{
								IL_68:
								this.Complect = null;
								for (;;)
								{
									this.Faults = null;
									ObservableCollection<IManufacturer> deviceMakers = this.DeviceMakers;
									if (deviceMakers != null)
									{
										deviceMakers.Clear();
										uint num;
										switch ((num = (num * 3052161316U ^ 1848002841U ^ 4259221219U)) % 9U)
										{
										case 0U:
										case 7U:
											goto IL_8F;
										case 1U:
											continue;
										case 3U:
											goto IL_9D;
										case 4U:
											goto IL_7A;
										case 5U:
											goto IL_71;
										case 6U:
											goto IL_82;
										case 8U:
											goto IL_68;
										}
										goto Block_2;
									}
									goto IL_9C;
								}
							}
						}
					}
				}
			}
			Block_2:
			return;
			IL_9C:
			IL_9D:
			this.LoadDevices();
		}

		// Token: 0x06003425 RID: 13349 RVA: 0x000B0728 File Offset: 0x000AE928
		private bool CheckField(string input)
		{
			if (this.SelectedDevice != null)
			{
				goto IL_4B;
			}
			IL_17:
			int num = 677359516;
			IL_1C:
			switch ((num ^ 2131442486) % 5)
			{
			case 0:
				DXMessageBox.Show(Lang.t("ItemError"));
				return false;
			case 1:
				IL_4B:
				num = ((!string.IsNullOrEmpty(input)) ? 1034219627 : 1444941345);
				goto IL_1C;
			case 3:
				goto IL_17;
			case 4:
				DXMessageBox.Show(Lang.t("SelectDevice"));
				return false;
			}
			return true;
		}

		// Token: 0x06003426 RID: 13350 RVA: 0x000B07B0 File Offset: 0x000AE9B0
		private void LoadDeviceOptions()
		{
			DeviceCatalogViewModel.<LoadDeviceOptions>d__185 <LoadDeviceOptions>d__;
			<LoadDeviceOptions>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadDeviceOptions>d__.<>4__this = this;
			<LoadDeviceOptions>d__.<>1__state = -1;
			<LoadDeviceOptions>d__.<>t__builder.Start<DeviceCatalogViewModel.<LoadDeviceOptions>d__185>(ref <LoadDeviceOptions>d__);
		}

		// Token: 0x06003427 RID: 13351 RVA: 0x000B07E8 File Offset: 0x000AE9E8
		private ObservableCollection<string> Deserialize(string inputString)
		{
			ObservableCollection<string> observableCollection = new ObservableCollection<string>();
			if (string.IsNullOrEmpty(inputString))
			{
				return observableCollection;
			}
			foreach (string text in inputString.Split(new char[]
			{
				','
			}))
			{
				if (text.Length > 0)
				{
					observableCollection.Add(text);
				}
			}
			return observableCollection;
		}

		// Token: 0x06003428 RID: 13352 RVA: 0x000B083C File Offset: 0x000AEA3C
		private void LoadDevices()
		{
			DeviceCatalogViewModel.<LoadDevices>d__187 <LoadDevices>d__;
			<LoadDevices>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadDevices>d__.<>4__this = this;
			<LoadDevices>d__.<>1__state = -1;
			<LoadDevices>d__.<>t__builder.Start<DeviceCatalogViewModel.<LoadDevices>d__187>(ref <LoadDevices>d__);
		}

		// Token: 0x06003429 RID: 13353 RVA: 0x000B0874 File Offset: 0x000AEA74
		private void UpdateDevice(object obj)
		{
			DeviceCatalogViewModel.<UpdateDevice>d__188 <UpdateDevice>d__;
			<UpdateDevice>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<UpdateDevice>d__.<>4__this = this;
			<UpdateDevice>d__.<>1__state = -1;
			<UpdateDevice>d__.<>t__builder.Start<DeviceCatalogViewModel.<UpdateDevice>d__188>(ref <UpdateDevice>d__);
		}

		// Token: 0x0600342A RID: 13354 RVA: 0x000B08AC File Offset: 0x000AEAAC
		private void UpdateMaker(object obj)
		{
			if (this.CheckField(this.NewDeviceMakers.Name))
			{
				goto IL_37;
			}
			IL_13:
			int num = 424521009;
			IL_18:
			switch ((num ^ 1691806707) % 4)
			{
			case 1:
				IL_37:
				base.UpdateDeviceMakerName(this.SelectedMaker.Id, this.NewDeviceMakers.Name);
				this.SelectedMaker.Name = this.NewDeviceMakers.Name;
				num = 1494746831;
				goto IL_18;
			case 2:
				return;
			case 3:
				goto IL_13;
			}
		}

		// Token: 0x0600342B RID: 13355 RVA: 0x000B092C File Offset: 0x000AEB2C
		private void SetAsCartridge(object obj)
		{
			if (this.SelectedDevice != null)
			{
				goto IL_2C;
			}
			IL_08:
			int num = 1903672479;
			IL_0D:
			switch ((num ^ 1333448862) % 4)
			{
			case 1:
				return;
			case 2:
				IL_2C:
				Task.Run<bool>(() => RepairModel.MarkDeviceAsCartridgeAsync(this.SelectedDevice.Id)).ContinueWith(delegate(Task<bool> t)
				{
					DXMessageBox.Show((!t.Result) ? Lang.t("Error") : Lang.t("Saved"));
					if (t.Result)
					{
						foreach (IDevice device in this.Devices)
						{
							device.Refill = (device.Id == this.SelectedDevice.Id);
						}
					}
					this.RefreshDevices();
				}, TaskScheduler.FromCurrentSynchronizationContext());
				num = 1727842686;
				goto IL_0D;
			case 3:
				goto IL_08;
			}
		}

		// Token: 0x0600342C RID: 13356 RVA: 0x000B0998 File Offset: 0x000AEB98
		[CompilerGenerated]
		private Task<IEnumerable<IManufacturer>> <LoadDeviceOptions>b__185_0()
		{
			return this._workshopService.GetManufacturers(this.SelectedDevice.CompanyList);
		}

		// Token: 0x0600342D RID: 13357 RVA: 0x000B09BC File Offset: 0x000AEBBC
		[CompilerGenerated]
		private Task<bool> <SetAsCartridge>b__190_0()
		{
			return RepairModel.MarkDeviceAsCartridgeAsync(this.SelectedDevice.Id);
		}

		// Token: 0x0600342E RID: 13358 RVA: 0x000B09DC File Offset: 0x000AEBDC
		[CompilerGenerated]
		private void <SetAsCartridge>b__190_1(Task<bool> t)
		{
			DXMessageBox.Show((!t.Result) ? Lang.t("Error") : Lang.t("Saved"));
			if (t.Result)
			{
				foreach (IDevice device in this.Devices)
				{
					device.Refill = (device.Id == this.SelectedDevice.Id);
				}
			}
			this.RefreshDevices();
		}

		// Token: 0x0600342F RID: 13359 RVA: 0x000B0A6C File Offset: 0x000AEC6C
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

		// Token: 0x04001DCC RID: 7628
		protected IWorkshopService _workshopService;

		// Token: 0x04001DCD RID: 7629
		[CompilerGenerated]
		private PropertyChangedEventHandler PropertyChanged;

		// Token: 0x04001DCE RID: 7630
		private IDevice _selectedDevice;

		// Token: 0x04001DCF RID: 7631
		private IManufacturer _selectedMaker;

		// Token: 0x04001DD0 RID: 7632
		[CompilerGenerated]
		private ObservableCollection<IDevice> <Devices>k__BackingField;

		// Token: 0x04001DD1 RID: 7633
		[CompilerGenerated]
		private ObservableCollection<IManufacturer> <DeviceMakers>k__BackingField;

		// Token: 0x04001DD2 RID: 7634
		[CompilerGenerated]
		private string <NewDeviceName>k__BackingField;

		// Token: 0x04001DD3 RID: 7635
		[CompilerGenerated]
		private IManufacturer <NewDeviceMakers>k__BackingField;

		// Token: 0x04001DD4 RID: 7636
		[CompilerGenerated]
		private ObservableCollection<string> <Faults>k__BackingField;

		// Token: 0x04001DD5 RID: 7637
		[CompilerGenerated]
		private ObservableCollection<string> <Look>k__BackingField;

		// Token: 0x04001DD6 RID: 7638
		[CompilerGenerated]
		private ObservableCollection<string> <Complect>k__BackingField;

		// Token: 0x04001DD7 RID: 7639
		[CompilerGenerated]
		private string <NewFault>k__BackingField;

		// Token: 0x04001DD8 RID: 7640
		[CompilerGenerated]
		private string <NewLook>k__BackingField;

		// Token: 0x04001DD9 RID: 7641
		[CompilerGenerated]
		private string <NewComplect>k__BackingField;

		// Token: 0x04001DDA RID: 7642
		[CompilerGenerated]
		private bool <DeviceOptionsVisible>k__BackingField = true;

		// Token: 0x04001DDB RID: 7643
		[CompilerGenerated]
		private ICommand <AddNewDeviceCommand>k__BackingField;

		// Token: 0x04001DDC RID: 7644
		[CompilerGenerated]
		private RelayCommand <UpdateDeviceCommand>k__BackingField;

		// Token: 0x04001DDD RID: 7645
		[CompilerGenerated]
		private RelayCommand <UpdateMakerCommand>k__BackingField;

		// Token: 0x04001DDE RID: 7646
		[CompilerGenerated]
		private RelayCommand <SetAsCartridgeCommand>k__BackingField;

		// Token: 0x04001DDF RID: 7647
		[CompilerGenerated]
		private ICommand <AddNewDeviceMakerCommand>k__BackingField;

		// Token: 0x04001DE0 RID: 7648
		[CompilerGenerated]
		private ICommand <AddNewFaultCommand>k__BackingField;

		// Token: 0x04001DE1 RID: 7649
		[CompilerGenerated]
		private ICommand <AddNewLookCommand>k__BackingField;

		// Token: 0x04001DE2 RID: 7650
		[CompilerGenerated]
		private ICommand <AddNewComplectCommand>k__BackingField;

		// Token: 0x04001DE3 RID: 7651
		[CompilerGenerated]
		private ICommand <DelDeviceCommand>k__BackingField;

		// Token: 0x04001DE4 RID: 7652
		[CompilerGenerated]
		private ICommand <DelDeviceMakerCommand>k__BackingField;

		// Token: 0x04001DE5 RID: 7653
		[CompilerGenerated]
		private ICommand <DelFaultCommand>k__BackingField;

		// Token: 0x04001DE6 RID: 7654
		[CompilerGenerated]
		private ICommand <DelLookCommand>k__BackingField;

		// Token: 0x04001DE7 RID: 7655
		[CompilerGenerated]
		private ICommand <ElementUpCommand>k__BackingField;

		// Token: 0x04001DE8 RID: 7656
		[CompilerGenerated]
		private ICommand <ElementMakerUpCommand>k__BackingField;

		// Token: 0x04001DE9 RID: 7657
		[CompilerGenerated]
		private ICommand <FaultUpCommand>k__BackingField;

		// Token: 0x04001DEA RID: 7658
		[CompilerGenerated]
		private ICommand <LookUpCommand>k__BackingField;

		// Token: 0x04001DEB RID: 7659
		[CompilerGenerated]
		private ICommand <LookDownCommand>k__BackingField;

		// Token: 0x04001DEC RID: 7660
		[CompilerGenerated]
		private ICommand <FaultDownCommand>k__BackingField;

		// Token: 0x04001DED RID: 7661
		[CompilerGenerated]
		private ICommand <ElementDownCommand>k__BackingField;

		// Token: 0x04001DEE RID: 7662
		[CompilerGenerated]
		private ICommand <ElementMakerDownCommand>k__BackingField;

		// Token: 0x04001DEF RID: 7663
		[CompilerGenerated]
		private ICommand <ComplectDownCommand>k__BackingField;

		// Token: 0x04001DF0 RID: 7664
		[CompilerGenerated]
		private ICommand <ComplectUpCommand>k__BackingField;

		// Token: 0x04001DF1 RID: 7665
		[CompilerGenerated]
		private ICommand <DelComplectCommand>k__BackingField;

		// Token: 0x02000579 RID: 1401
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SaveComplectPosition>d__157 : IAsyncStateMachine
		{
			// Token: 0x06003430 RID: 13360 RVA: 0x000B0A90 File Offset: 0x000AEC90
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				DeviceCatalogViewModel deviceCatalogViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						deviceCatalogViewModel.SelectedDevice.ComplectList = deviceCatalogViewModel.Position(deviceCatalogViewModel.Complect);
						awaiter = deviceCatalogViewModel._workshopService.UpdateDevice(deviceCatalogViewModel.SelectedDevice).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, DeviceCatalogViewModel.<SaveComplectPosition>d__157>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
					}
					awaiter.GetResult();
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

			// Token: 0x06003431 RID: 13361 RVA: 0x000B0B64 File Offset: 0x000AED64
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001DF2 RID: 7666
			public int <>1__state;

			// Token: 0x04001DF3 RID: 7667
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001DF4 RID: 7668
			public DeviceCatalogViewModel <>4__this;

			// Token: 0x04001DF5 RID: 7669
			private TaskAwaiter <>u__1;
		}

		// Token: 0x0200057A RID: 1402
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SaveLookPosition>d__162 : IAsyncStateMachine
		{
			// Token: 0x06003432 RID: 13362 RVA: 0x000B0B80 File Offset: 0x000AED80
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				DeviceCatalogViewModel deviceCatalogViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						deviceCatalogViewModel.SelectedDevice.LookList = deviceCatalogViewModel.Position(deviceCatalogViewModel.Look);
						awaiter = deviceCatalogViewModel._workshopService.UpdateDevice(deviceCatalogViewModel.SelectedDevice).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, DeviceCatalogViewModel.<SaveLookPosition>d__162>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
					}
					awaiter.GetResult();
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

			// Token: 0x06003433 RID: 13363 RVA: 0x000B0C54 File Offset: 0x000AEE54
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001DF6 RID: 7670
			public int <>1__state;

			// Token: 0x04001DF7 RID: 7671
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001DF8 RID: 7672
			public DeviceCatalogViewModel <>4__this;

			// Token: 0x04001DF9 RID: 7673
			private TaskAwaiter <>u__1;
		}

		// Token: 0x0200057B RID: 1403
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SaveFaultPosition>d__169 : IAsyncStateMachine
		{
			// Token: 0x06003434 RID: 13364 RVA: 0x000B0C70 File Offset: 0x000AEE70
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				DeviceCatalogViewModel deviceCatalogViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						deviceCatalogViewModel.SelectedDevice.FaultList = deviceCatalogViewModel.Position(deviceCatalogViewModel.Faults);
						awaiter = deviceCatalogViewModel._workshopService.UpdateDevice(deviceCatalogViewModel.SelectedDevice).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, DeviceCatalogViewModel.<SaveFaultPosition>d__169>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
					}
					awaiter.GetResult();
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

			// Token: 0x06003435 RID: 13365 RVA: 0x000B0D44 File Offset: 0x000AEF44
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001DFA RID: 7674
			public int <>1__state;

			// Token: 0x04001DFB RID: 7675
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001DFC RID: 7676
			public DeviceCatalogViewModel <>4__this;

			// Token: 0x04001DFD RID: 7677
			private TaskAwaiter <>u__1;
		}

		// Token: 0x0200057C RID: 1404
		[CompilerGenerated]
		private sealed class <>c__DisplayClass170_0
		{
			// Token: 0x06003436 RID: 13366 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass170_0()
			{
			}

			// Token: 0x06003437 RID: 13367 RVA: 0x000B0D60 File Offset: 0x000AEF60
			internal bool <DeleteMaker>b__0(IManufacturer m)
			{
				return m.Id == this.makerId;
			}

			// Token: 0x04001DFE RID: 7678
			public int makerId;
		}

		// Token: 0x0200057D RID: 1405
		[CompilerGenerated]
		private sealed class <>c__DisplayClass172_0
		{
			// Token: 0x06003438 RID: 13368 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass172_0()
			{
			}

			// Token: 0x06003439 RID: 13369 RVA: 0x000B0D7C File Offset: 0x000AEF7C
			internal bool <MakerUp>b__0(IManufacturer d)
			{
				return d.Id == (int)this.obj;
			}

			// Token: 0x04001DFF RID: 7679
			public object obj;
		}

		// Token: 0x0200057E RID: 1406
		[CompilerGenerated]
		private sealed class <>c__DisplayClass173_0
		{
			// Token: 0x0600343A RID: 13370 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass173_0()
			{
			}

			// Token: 0x0600343B RID: 13371 RVA: 0x000B0D9C File Offset: 0x000AEF9C
			internal bool <MakerDown>b__0(IManufacturer d)
			{
				return d.Id == (int)this.obj;
			}

			// Token: 0x04001E00 RID: 7680
			public object obj;
		}

		// Token: 0x0200057F RID: 1407
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <AddNewDeviceMaker>d__175 : IAsyncStateMachine
		{
			// Token: 0x0600343C RID: 13372 RVA: 0x000B0DBC File Offset: 0x000AEFBC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				DeviceCatalogViewModel deviceCatalogViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IManufacturer> awaiter;
					if (num != 0)
					{
						if (!deviceCatalogViewModel.CheckFieldsNewMaker())
						{
							goto IL_115;
						}
						awaiter = deviceCatalogViewModel._workshopService.GetManufacturerByName(deviceCatalogViewModel.NewDeviceMakers.Name).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IManufacturer>, DeviceCatalogViewModel.<AddNewDeviceMaker>d__175>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IManufacturer>);
						this.<>1__state = -1;
					}
					IManufacturer manufacturer = awaiter.GetResult();
					if (manufacturer != null)
					{
						deviceCatalogViewModel.AddMakerToDevice(deviceCatalogViewModel.SelectedDevice.Id, manufacturer.Id);
					}
					else
					{
						int num2 = deviceCatalogViewModel.CreateNewMaker(deviceCatalogViewModel.SelectedDevice.Id, deviceCatalogViewModel.NewDeviceMakers.Name);
						if (num2 == 0)
						{
							DXMessageBox.Show("Create maker fail, operation aborted");
							goto IL_115;
						}
						manufacturer = new Manufacturer(num2, deviceCatalogViewModel.NewDeviceMakers.Name);
					}
					deviceCatalogViewModel.DeviceMakers.Add(manufacturer);
					deviceCatalogViewModel.ResetMaker();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_115:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x0600343D RID: 13373 RVA: 0x000B0F04 File Offset: 0x000AF104
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001E01 RID: 7681
			public int <>1__state;

			// Token: 0x04001E02 RID: 7682
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001E03 RID: 7683
			public DeviceCatalogViewModel <>4__this;

			// Token: 0x04001E04 RID: 7684
			private TaskAwaiter<IManufacturer> <>u__1;
		}

		// Token: 0x02000580 RID: 1408
		[CompilerGenerated]
		private sealed class <>c__DisplayClass177_0
		{
			// Token: 0x0600343E RID: 13374 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass177_0()
			{
			}

			// Token: 0x0600343F RID: 13375 RVA: 0x000B0F20 File Offset: 0x000AF120
			internal bool <DeviceDown>b__0(IDevice d)
			{
				return d.Id == (int)this.obj;
			}

			// Token: 0x04001E05 RID: 7685
			public object obj;
		}

		// Token: 0x02000581 RID: 1409
		[CompilerGenerated]
		private sealed class <>c__DisplayClass178_0
		{
			// Token: 0x06003440 RID: 13376 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass178_0()
			{
			}

			// Token: 0x06003441 RID: 13377 RVA: 0x000B0F40 File Offset: 0x000AF140
			internal bool <DeviceUp>b__0(IDevice d)
			{
				return d.Id == (int)this.obj;
			}

			// Token: 0x04001E06 RID: 7686
			public object obj;
		}

		// Token: 0x02000582 RID: 1410
		[CompilerGenerated]
		private sealed class <>c__DisplayClass180_0
		{
			// Token: 0x06003442 RID: 13378 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass180_0()
			{
			}

			// Token: 0x06003443 RID: 13379 RVA: 0x000B0F60 File Offset: 0x000AF160
			internal bool <DelDevice>b__1(IDevice d)
			{
				return d.Id == this.deviceId;
			}

			// Token: 0x04001E07 RID: 7687
			public int deviceId;
		}

		// Token: 0x02000583 RID: 1411
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadDeviceOptions>d__185 : IAsyncStateMachine
		{
			// Token: 0x06003444 RID: 13380 RVA: 0x000B0F7C File Offset: 0x000AF17C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				DeviceCatalogViewModel deviceCatalogViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<IManufacturer>> awaiter;
					if (num != 0)
					{
						deviceCatalogViewModel.DeviceMakers.Clear();
						if (string.IsNullOrEmpty(deviceCatalogViewModel.SelectedDevice.CompanyList))
						{
							goto IL_CD;
						}
						awaiter = Task.Run<IEnumerable<IManufacturer>>(() => deviceCatalogViewModel._workshopService.GetManufacturers(base.SelectedDevice.CompanyList)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.<>1__state = num2;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IManufacturer>>, DeviceCatalogViewModel.<LoadDeviceOptions>d__185>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<IManufacturer>>);
						int num3 = -1;
						num = -1;
						this.<>1__state = num3;
					}
					IEnumerator<IManufacturer> enumerator = awaiter.GetResult().GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							IManufacturer item = enumerator.Current;
							deviceCatalogViewModel.DeviceMakers.Add(item);
						}
					}
					finally
					{
						if (num < 0 && enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					IL_CD:
					deviceCatalogViewModel.Faults = deviceCatalogViewModel.Deserialize(deviceCatalogViewModel.SelectedDevice.FaultList);
					deviceCatalogViewModel.Look = deviceCatalogViewModel.Deserialize(deviceCatalogViewModel.SelectedDevice.LookList);
					deviceCatalogViewModel.Complect = deviceCatalogViewModel.Deserialize(deviceCatalogViewModel.SelectedDevice.ComplectList);
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

			// Token: 0x06003445 RID: 13381 RVA: 0x000B1100 File Offset: 0x000AF300
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001E08 RID: 7688
			public int <>1__state;

			// Token: 0x04001E09 RID: 7689
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001E0A RID: 7690
			public DeviceCatalogViewModel <>4__this;

			// Token: 0x04001E0B RID: 7691
			private TaskAwaiter<IEnumerable<IManufacturer>> <>u__1;
		}

		// Token: 0x02000584 RID: 1412
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadDevices>d__187 : IAsyncStateMachine
		{
			// Token: 0x06003446 RID: 13382 RVA: 0x000B111C File Offset: 0x000AF31C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				DeviceCatalogViewModel deviceCatalogViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<IDevice>> awaiter;
					if (num != 0)
					{
						awaiter = deviceCatalogViewModel._workshopService.GetActiveDevices().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.<>1__state = num2;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IDevice>>, DeviceCatalogViewModel.<LoadDevices>d__187>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<IDevice>>);
						int num3 = -1;
						num = -1;
						this.<>1__state = num3;
					}
					IEnumerable<IDevice> result = awaiter.GetResult();
					deviceCatalogViewModel.Devices.Clear();
					IEnumerator<IDevice> enumerator = result.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							IDevice item = enumerator.Current;
							deviceCatalogViewModel.Devices.Add(item);
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
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003447 RID: 13383 RVA: 0x000B1228 File Offset: 0x000AF428
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001E0C RID: 7692
			public int <>1__state;

			// Token: 0x04001E0D RID: 7693
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001E0E RID: 7694
			public DeviceCatalogViewModel <>4__this;

			// Token: 0x04001E0F RID: 7695
			private TaskAwaiter<IEnumerable<IDevice>> <>u__1;
		}

		// Token: 0x02000585 RID: 1413
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateDevice>d__188 : IAsyncStateMachine
		{
			// Token: 0x06003448 RID: 13384 RVA: 0x000B1244 File Offset: 0x000AF444
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				DeviceCatalogViewModel deviceCatalogViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (!deviceCatalogViewModel.CheckNewDevice(deviceCatalogViewModel.NewDeviceName))
						{
							goto IL_B1;
						}
						awaiter = deviceCatalogViewModel._workshopService.UpdateDevice(deviceCatalogViewModel.SelectedDevice.Id, deviceCatalogViewModel.NewDeviceName).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, DeviceCatalogViewModel.<UpdateDevice>d__188>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
					}
					awaiter.GetResult();
					deviceCatalogViewModel.RefreshDevices();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_B1:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003449 RID: 13385 RVA: 0x000B1328 File Offset: 0x000AF528
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001E10 RID: 7696
			public int <>1__state;

			// Token: 0x04001E11 RID: 7697
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001E12 RID: 7698
			public DeviceCatalogViewModel <>4__this;

			// Token: 0x04001E13 RID: 7699
			private TaskAwaiter <>u__1;
		}
	}
}
