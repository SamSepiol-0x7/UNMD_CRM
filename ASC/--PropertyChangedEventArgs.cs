using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;

// Token: 0x02000C1B RID: 3099
[GeneratedCode("PropertyChanged.Fody", "3.1.3.0")]
[DebuggerNonUserCode]
[StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
internal static class <>PropertyChangedEventArgs
{
	// Token: 0x06005580 RID: 21888 RVA: 0x0016E898 File Offset: 0x0016CA98
	// Note: this type is marked as 'beforefieldinit'.
	static <>PropertyChangedEventArgs()
	{
	}

	// Token: 0x0400381A RID: 14362
	internal static readonly PropertyChangedEventArgs AcpModel = new PropertyChangedEventArgs("AcpModel");

	// Token: 0x0400381B RID: 14363
	internal static readonly PropertyChangedEventArgs active = new PropertyChangedEventArgs("active");

	// Token: 0x0400381C RID: 14364
	internal static readonly PropertyChangedEventArgs AdditionalFields = new PropertyChangedEventArgs("AdditionalFields");

	// Token: 0x0400381D RID: 14365
	internal static readonly PropertyChangedEventArgs AddNewComplectCommand = new PropertyChangedEventArgs("AddNewComplectCommand");

	// Token: 0x0400381E RID: 14366
	internal static readonly PropertyChangedEventArgs AddNewDeviceCommand = new PropertyChangedEventArgs("AddNewDeviceCommand");

	// Token: 0x0400381F RID: 14367
	internal static readonly PropertyChangedEventArgs AddNewDeviceMakerCommand = new PropertyChangedEventArgs("AddNewDeviceMakerCommand");

	// Token: 0x04003820 RID: 14368
	internal static readonly PropertyChangedEventArgs AddNewFaultCommand = new PropertyChangedEventArgs("AddNewFaultCommand");

	// Token: 0x04003821 RID: 14369
	internal static readonly PropertyChangedEventArgs AddNewLookCommand = new PropertyChangedEventArgs("AddNewLookCommand");

	// Token: 0x04003822 RID: 14370
	internal static readonly PropertyChangedEventArgs ApiFieldEnable = new PropertyChangedEventArgs("ApiFieldEnable");

	// Token: 0x04003823 RID: 14371
	internal static readonly PropertyChangedEventArgs Archive = new PropertyChangedEventArgs("Archive");

	// Token: 0x04003824 RID: 14372
	internal static readonly PropertyChangedEventArgs AssemblyVersion = new PropertyChangedEventArgs("AssemblyVersion");

	// Token: 0x04003825 RID: 14373
	internal static readonly PropertyChangedEventArgs AuthType = new PropertyChangedEventArgs("AuthType");

	// Token: 0x04003826 RID: 14374
	internal static readonly PropertyChangedEventArgs Background = new PropertyChangedEventArgs("Background");

	// Token: 0x04003827 RID: 14375
	internal static readonly PropertyChangedEventArgs boxes = new PropertyChangedEventArgs("boxes");

	// Token: 0x04003828 RID: 14376
	internal static readonly PropertyChangedEventArgs Boxes = new PropertyChangedEventArgs("Boxes");

	// Token: 0x04003829 RID: 14377
	internal static readonly PropertyChangedEventArgs Boxeses = new PropertyChangedEventArgs("Boxeses");

	// Token: 0x0400382A RID: 14378
	internal static readonly PropertyChangedEventArgs CancelCommand = new PropertyChangedEventArgs("CancelCommand");

	// Token: 0x0400382B RID: 14379
	internal static readonly PropertyChangedEventArgs CanCopyCategories = new PropertyChangedEventArgs("CanCopyCategories");

	// Token: 0x0400382C RID: 14380
	internal static readonly PropertyChangedEventArgs CapslockActive = new PropertyChangedEventArgs("CapslockActive");

	// Token: 0x0400382D RID: 14381
	internal static readonly PropertyChangedEventArgs CheckedPermissions = new PropertyChangedEventArgs("CheckedPermissions");

	// Token: 0x0400382E RID: 14382
	internal static readonly PropertyChangedEventArgs Close = new PropertyChangedEventArgs("Close");

	// Token: 0x0400382F RID: 14383
	internal static readonly PropertyChangedEventArgs CloseAction = new PropertyChangedEventArgs("CloseAction");

	// Token: 0x04003830 RID: 14384
	internal static readonly PropertyChangedEventArgs Complect = new PropertyChangedEventArgs("Complect");

	// Token: 0x04003831 RID: 14385
	internal static readonly PropertyChangedEventArgs ComplectDownCommand = new PropertyChangedEventArgs("ComplectDownCommand");

	// Token: 0x04003832 RID: 14386
	internal static readonly PropertyChangedEventArgs ComplectUpCommand = new PropertyChangedEventArgs("ComplectUpCommand");

	// Token: 0x04003833 RID: 14387
	internal static readonly PropertyChangedEventArgs ContinueLoginCommand = new PropertyChangedEventArgs("ContinueLoginCommand");

	// Token: 0x04003834 RID: 14388
	internal static readonly PropertyChangedEventArgs ControlLoadedCommand = new PropertyChangedEventArgs("ControlLoadedCommand");

	// Token: 0x04003835 RID: 14389
	internal static readonly PropertyChangedEventArgs CopyFromStores = new PropertyChangedEventArgs("CopyFromStores");

	// Token: 0x04003836 RID: 14390
	internal static readonly PropertyChangedEventArgs CopyStoreId = new PropertyChangedEventArgs("CopyStoreId");

	// Token: 0x04003837 RID: 14391
	internal static readonly PropertyChangedEventArgs count = new PropertyChangedEventArgs("count");

	// Token: 0x04003838 RID: 14392
	internal static readonly PropertyChangedEventArgs created = new PropertyChangedEventArgs("created");

	// Token: 0x04003839 RID: 14393
	internal static readonly PropertyChangedEventArgs CreateNewStoreCommand = new PropertyChangedEventArgs("CreateNewStoreCommand");

	// Token: 0x0400383A RID: 14394
	internal static readonly PropertyChangedEventArgs CreateStore = new PropertyChangedEventArgs("CreateStore");

	// Token: 0x0400383B RID: 14395
	internal static readonly PropertyChangedEventArgs Customer = new PropertyChangedEventArgs("Customer");

	// Token: 0x0400383C RID: 14396
	internal static readonly PropertyChangedEventArgs DayName = new PropertyChangedEventArgs("DayName");

	// Token: 0x0400383D RID: 14397
	internal static readonly PropertyChangedEventArgs dealer = new PropertyChangedEventArgs("dealer");

	// Token: 0x0400383E RID: 14398
	internal static readonly PropertyChangedEventArgs DefaultVisibility = new PropertyChangedEventArgs("DefaultVisibility");

	// Token: 0x0400383F RID: 14399
	internal static readonly PropertyChangedEventArgs DelAddFields = new PropertyChangedEventArgs("DelAddFields");

	// Token: 0x04003840 RID: 14400
	internal static readonly PropertyChangedEventArgs DelBoxes = new PropertyChangedEventArgs("DelBoxes");

	// Token: 0x04003841 RID: 14401
	internal static readonly PropertyChangedEventArgs DelComplectCommand = new PropertyChangedEventArgs("DelComplectCommand");

	// Token: 0x04003842 RID: 14402
	internal static readonly PropertyChangedEventArgs DelDeviceCommand = new PropertyChangedEventArgs("DelDeviceCommand");

	// Token: 0x04003843 RID: 14403
	internal static readonly PropertyChangedEventArgs DelDeviceMakerCommand = new PropertyChangedEventArgs("DelDeviceMakerCommand");

	// Token: 0x04003844 RID: 14404
	internal static readonly PropertyChangedEventArgs DelFaultCommand = new PropertyChangedEventArgs("DelFaultCommand");

	// Token: 0x04003845 RID: 14405
	internal static readonly PropertyChangedEventArgs DelLookCommand = new PropertyChangedEventArgs("DelLookCommand");

	// Token: 0x04003846 RID: 14406
	internal static readonly PropertyChangedEventArgs DeployDatabaseCommand = new PropertyChangedEventArgs("DeployDatabaseCommand");

	// Token: 0x04003847 RID: 14407
	internal static readonly PropertyChangedEventArgs description = new PropertyChangedEventArgs("description");

	// Token: 0x04003848 RID: 14408
	internal static readonly PropertyChangedEventArgs TargetName = new PropertyChangedEventArgs("DevExpress.Xpf.Docking.IMVVMDockingProperties.TargetName");

	// Token: 0x04003849 RID: 14409
	internal static readonly PropertyChangedEventArgs DeviceMakers = new PropertyChangedEventArgs("DeviceMakers");

	// Token: 0x0400384A RID: 14410
	internal static readonly PropertyChangedEventArgs DeviceOptionsVisible = new PropertyChangedEventArgs("DeviceOptionsVisible");

	// Token: 0x0400384B RID: 14411
	internal static readonly PropertyChangedEventArgs Devices = new PropertyChangedEventArgs("Devices");

	// Token: 0x0400384C RID: 14412
	internal static readonly PropertyChangedEventArgs docs = new PropertyChangedEventArgs("docs");

	// Token: 0x0400384D RID: 14413
	internal static readonly PropertyChangedEventArgs docs1 = new PropertyChangedEventArgs("docs1");

	// Token: 0x0400384E RID: 14414
	internal static readonly PropertyChangedEventArgs DocumentName = new PropertyChangedEventArgs("DocumentName");

	// Token: 0x0400384F RID: 14415
	internal static readonly PropertyChangedEventArgs DocumentNumber = new PropertyChangedEventArgs("DocumentNumber");

	// Token: 0x04003850 RID: 14416
	internal static readonly PropertyChangedEventArgs Documents = new PropertyChangedEventArgs("Documents");

	// Token: 0x04003851 RID: 14417
	internal static readonly PropertyChangedEventArgs ElementDownCommand = new PropertyChangedEventArgs("ElementDownCommand");

	// Token: 0x04003852 RID: 14418
	internal static readonly PropertyChangedEventArgs ElementMakerDownCommand = new PropertyChangedEventArgs("ElementMakerDownCommand");

	// Token: 0x04003853 RID: 14419
	internal static readonly PropertyChangedEventArgs ElementMakerUpCommand = new PropertyChangedEventArgs("ElementMakerUpCommand");

	// Token: 0x04003854 RID: 14420
	internal static readonly PropertyChangedEventArgs ElementUpCommand = new PropertyChangedEventArgs("ElementUpCommand");

	// Token: 0x04003855 RID: 14421
	internal static readonly PropertyChangedEventArgs FaultDownCommand = new PropertyChangedEventArgs("FaultDownCommand");

	// Token: 0x04003856 RID: 14422
	internal static readonly PropertyChangedEventArgs Faults = new PropertyChangedEventArgs("Faults");

	// Token: 0x04003857 RID: 14423
	internal static readonly PropertyChangedEventArgs FaultUpCommand = new PropertyChangedEventArgs("FaultUpCommand");

	// Token: 0x04003858 RID: 14424
	internal static readonly PropertyChangedEventArgs Fio = new PropertyChangedEventArgs("Fio");

	// Token: 0x04003859 RID: 14425
	internal static readonly PropertyChangedEventArgs FirstName = new PropertyChangedEventArgs("FirstName");

	// Token: 0x0400385A RID: 14426
	internal static readonly PropertyChangedEventArgs FirstRun = new PropertyChangedEventArgs("FirstRun");

	// Token: 0x0400385B RID: 14427
	internal static readonly PropertyChangedEventArgs Foreground = new PropertyChangedEventArgs("Foreground");

	// Token: 0x0400385C RID: 14428
	internal static readonly PropertyChangedEventArgs from_user = new PropertyChangedEventArgs("from_user");

	// Token: 0x0400385D RID: 14429
	internal static readonly PropertyChangedEventArgs HideAction = new PropertyChangedEventArgs("HideAction");

	// Token: 0x0400385E RID: 14430
	internal static readonly PropertyChangedEventArgs HideNewStoreCommand = new PropertyChangedEventArgs("HideNewStoreCommand");

	// Token: 0x0400385F RID: 14431
	internal static readonly PropertyChangedEventArgs id = new PropertyChangedEventArgs("id");

	// Token: 0x04003860 RID: 14432
	internal static readonly PropertyChangedEventArgs isPlaying = new PropertyChangedEventArgs("isPlaying");

	// Token: 0x04003861 RID: 14433
	internal static readonly PropertyChangedEventArgs IsWorkingDay = new PropertyChangedEventArgs("IsWorkingDay");

	// Token: 0x04003862 RID: 14434
	internal static readonly PropertyChangedEventArgs it_vis_barcode = new PropertyChangedEventArgs("it_vis_barcode");

	// Token: 0x04003863 RID: 14435
	internal static readonly PropertyChangedEventArgs it_vis_description = new PropertyChangedEventArgs("it_vis_description");

	// Token: 0x04003864 RID: 14436
	internal static readonly PropertyChangedEventArgs it_vis_notes = new PropertyChangedEventArgs("it_vis_notes");

	// Token: 0x04003865 RID: 14437
	internal static readonly PropertyChangedEventArgs it_vis_photo = new PropertyChangedEventArgs("it_vis_photo");

	// Token: 0x04003866 RID: 14438
	internal static readonly PropertyChangedEventArgs it_vis_pn = new PropertyChangedEventArgs("it_vis_pn");

	// Token: 0x04003867 RID: 14439
	internal static readonly PropertyChangedEventArgs it_vis_sn = new PropertyChangedEventArgs("it_vis_sn");

	// Token: 0x04003868 RID: 14440
	internal static readonly PropertyChangedEventArgs it_vis_warranty = new PropertyChangedEventArgs("it_vis_warranty");

	// Token: 0x04003869 RID: 14441
	internal static readonly PropertyChangedEventArgs it_vis_warranty_dealer = new PropertyChangedEventArgs("it_vis_warranty_dealer");

	// Token: 0x0400386A RID: 14442
	internal static readonly PropertyChangedEventArgs item_id = new PropertyChangedEventArgs("item_id");

	// Token: 0x0400386B RID: 14443
	internal static readonly PropertyChangedEventArgs Language = new PropertyChangedEventArgs("Language");

	// Token: 0x0400386C RID: 14444
	internal static readonly PropertyChangedEventArgs LastName = new PropertyChangedEventArgs("LastName");

	// Token: 0x0400386D RID: 14445
	internal static readonly PropertyChangedEventArgs LoadMsg = new PropertyChangedEventArgs("LoadMsg");

	// Token: 0x0400386E RID: 14446
	internal static readonly PropertyChangedEventArgs LoginBtnClickCommand = new PropertyChangedEventArgs("LoginBtnClickCommand");

	// Token: 0x0400386F RID: 14447
	internal static readonly PropertyChangedEventArgs LoginPasswordEnable = new PropertyChangedEventArgs("LoginPasswordEnable");

	// Token: 0x04003870 RID: 14448
	internal static readonly PropertyChangedEventArgs Look = new PropertyChangedEventArgs("Look");

	// Token: 0x04003871 RID: 14449
	internal static readonly PropertyChangedEventArgs LookDownCommand = new PropertyChangedEventArgs("LookDownCommand");

	// Token: 0x04003872 RID: 14450
	internal static readonly PropertyChangedEventArgs LookUpCommand = new PropertyChangedEventArgs("LookUpCommand");

	// Token: 0x04003873 RID: 14451
	internal static readonly PropertyChangedEventArgs ManagerPart = new PropertyChangedEventArgs("ManagerPart");

	// Token: 0x04003874 RID: 14452
	internal static readonly PropertyChangedEventArgs Message = new PropertyChangedEventArgs("Message");

	// Token: 0x04003875 RID: 14453
	internal static readonly PropertyChangedEventArgs MessageLength = new PropertyChangedEventArgs("MessageLength");

	// Token: 0x04003876 RID: 14454
	internal static readonly PropertyChangedEventArgs name = new PropertyChangedEventArgs("name");

	// Token: 0x04003877 RID: 14455
	internal static readonly PropertyChangedEventArgs NewComplect = new PropertyChangedEventArgs("NewComplect");

	// Token: 0x04003878 RID: 14456
	internal static readonly PropertyChangedEventArgs NewDeviceMakers = new PropertyChangedEventArgs("NewDeviceMakers");

	// Token: 0x04003879 RID: 14457
	internal static readonly PropertyChangedEventArgs NewDeviceName = new PropertyChangedEventArgs("NewDeviceName");

	// Token: 0x0400387A RID: 14458
	internal static readonly PropertyChangedEventArgs NewFault = new PropertyChangedEventArgs("NewFault");

	// Token: 0x0400387B RID: 14459
	internal static readonly PropertyChangedEventArgs NewLook = new PropertyChangedEventArgs("NewLook");

	// Token: 0x0400387C RID: 14460
	internal static readonly PropertyChangedEventArgs notes = new PropertyChangedEventArgs("notes");

	// Token: 0x0400387D RID: 14461
	internal static readonly PropertyChangedEventArgs notifications = new PropertyChangedEventArgs("notifications");

	// Token: 0x0400387E RID: 14462
	internal static readonly PropertyChangedEventArgs NullText = new PropertyChangedEventArgs("NullText");

	// Token: 0x0400387F RID: 14463
	internal static readonly PropertyChangedEventArgs office = new PropertyChangedEventArgs("office");

	// Token: 0x04003880 RID: 14464
	internal static readonly PropertyChangedEventArgs Office = new PropertyChangedEventArgs("Office");

	// Token: 0x04003881 RID: 14465
	internal static readonly PropertyChangedEventArgs OfficeId = new PropertyChangedEventArgs("OfficeId");

	// Token: 0x04003882 RID: 14466
	internal static readonly PropertyChangedEventArgs offices = new PropertyChangedEventArgs("offices");

	// Token: 0x04003883 RID: 14467
	internal static readonly PropertyChangedEventArgs Offices = new PropertyChangedEventArgs("Offices");

	// Token: 0x04003884 RID: 14468
	internal static readonly PropertyChangedEventArgs OfficesSelectVis = new PropertyChangedEventArgs("OfficesSelectVis");

	// Token: 0x04003885 RID: 14469
	internal static readonly PropertyChangedEventArgs OnFio = new PropertyChangedEventArgs("OnFio");

	// Token: 0x04003886 RID: 14470
	internal static readonly PropertyChangedEventArgs Open = new PropertyChangedEventArgs("Open");

	// Token: 0x04003887 RID: 14471
	internal static readonly PropertyChangedEventArgs OrderId = new PropertyChangedEventArgs("OrderId");

	// Token: 0x04003888 RID: 14472
	internal static readonly PropertyChangedEventArgs Patronymic = new PropertyChangedEventArgs("Patronymic");

	// Token: 0x04003889 RID: 14473
	internal static readonly PropertyChangedEventArgs Permissions = new PropertyChangedEventArgs("Permissions");

	// Token: 0x0400388A RID: 14474
	internal static readonly PropertyChangedEventArgs Phones = new PropertyChangedEventArgs("Phones");

	// Token: 0x0400388B RID: 14475
	internal static readonly PropertyChangedEventArgs price = new PropertyChangedEventArgs("price");

	// Token: 0x0400388C RID: 14476
	internal static readonly PropertyChangedEventArgs PriceFormatted = new PropertyChangedEventArgs("PriceFormatted");

	// Token: 0x0400388D RID: 14477
	internal static readonly PropertyChangedEventArgs PrintDocumentCommand = new PropertyChangedEventArgs("PrintDocumentCommand");

	// Token: 0x0400388E RID: 14478
	internal static readonly PropertyChangedEventArgs Profit = new PropertyChangedEventArgs("Profit");

	// Token: 0x0400388F RID: 14479
	internal static readonly PropertyChangedEventArgs Progress = new PropertyChangedEventArgs("Progress");

	// Token: 0x04003890 RID: 14480
	internal static readonly PropertyChangedEventArgs ProgressValue = new PropertyChangedEventArgs("ProgressValue");

	// Token: 0x04003891 RID: 14481
	internal static readonly PropertyChangedEventArgs ProgressVisible = new PropertyChangedEventArgs("ProgressVisible");

	// Token: 0x04003892 RID: 14482
	internal static readonly PropertyChangedEventArgs Provider = new PropertyChangedEventArgs("Provider");

	// Token: 0x04003893 RID: 14483
	internal static readonly PropertyChangedEventArgs Providers = new PropertyChangedEventArgs("Providers");

	// Token: 0x04003894 RID: 14484
	internal static readonly PropertyChangedEventArgs r_lock = new PropertyChangedEventArgs("r_lock");

	// Token: 0x04003895 RID: 14485
	internal static readonly PropertyChangedEventArgs RemoveBoxCommand = new PropertyChangedEventArgs("RemoveBoxCommand");

	// Token: 0x04003896 RID: 14486
	internal static readonly PropertyChangedEventArgs repair_id = new PropertyChangedEventArgs("repair_id");

	// Token: 0x04003897 RID: 14487
	internal static readonly PropertyChangedEventArgs Roles = new PropertyChangedEventArgs("Roles");

	// Token: 0x04003898 RID: 14488
	internal static readonly PropertyChangedEventArgs SaveExistStoreCommand = new PropertyChangedEventArgs("SaveExistStoreCommand");

	// Token: 0x04003899 RID: 14489
	internal static readonly PropertyChangedEventArgs SelectedBox = new PropertyChangedEventArgs("SelectedBox");

	// Token: 0x0400389A RID: 14490
	internal static readonly PropertyChangedEventArgs SelectedDevice = new PropertyChangedEventArgs("SelectedDevice");

	// Token: 0x0400389B RID: 14491
	internal static readonly PropertyChangedEventArgs SelectedMaker = new PropertyChangedEventArgs("SelectedMaker");

	// Token: 0x0400389C RID: 14492
	internal static readonly PropertyChangedEventArgs SelectedRole = new PropertyChangedEventArgs("SelectedRole");

	// Token: 0x0400389D RID: 14493
	internal static readonly PropertyChangedEventArgs SelectedStore = new PropertyChangedEventArgs("SelectedStore");

	// Token: 0x0400389E RID: 14494
	internal static readonly PropertyChangedEventArgs SetAsCartridgeCommand = new PropertyChangedEventArgs("SetAsCartridgeCommand");

	// Token: 0x0400389F RID: 14495
	internal static readonly PropertyChangedEventArgs SetDefaultsCommand = new PropertyChangedEventArgs("SetDefaultsCommand");

	// Token: 0x040038A0 RID: 14496
	internal static readonly PropertyChangedEventArgs SettingsVisibility = new PropertyChangedEventArgs("SettingsVisibility");

	// Token: 0x040038A1 RID: 14497
	internal static readonly PropertyChangedEventArgs ShowNewStoreCommand = new PropertyChangedEventArgs("ShowNewStoreCommand");

	// Token: 0x040038A2 RID: 14498
	internal static readonly PropertyChangedEventArgs SmsRuApiId = new PropertyChangedEventArgs("SmsRuApiId");

	// Token: 0x040038A3 RID: 14499
	internal static readonly PropertyChangedEventArgs SmsRuLogin = new PropertyChangedEventArgs("SmsRuLogin");

	// Token: 0x040038A4 RID: 14500
	internal static readonly PropertyChangedEventArgs SmsRuPassword = new PropertyChangedEventArgs("SmsRuPassword");

	// Token: 0x040038A5 RID: 14501
	internal static readonly PropertyChangedEventArgs SmsRuSender = new PropertyChangedEventArgs("SmsRuSender");

	// Token: 0x040038A6 RID: 14502
	internal static readonly PropertyChangedEventArgs sn = new PropertyChangedEventArgs("sn");

	// Token: 0x040038A7 RID: 14503
	internal static readonly PropertyChangedEventArgs state = new PropertyChangedEventArgs("state");

	// Token: 0x040038A8 RID: 14504
	internal static readonly PropertyChangedEventArgs store_cats = new PropertyChangedEventArgs("store_cats");

	// Token: 0x040038A9 RID: 14505
	internal static readonly PropertyChangedEventArgs store_items = new PropertyChangedEventArgs("store_items");

	// Token: 0x040038AA RID: 14506
	internal static readonly PropertyChangedEventArgs store_sub_types = new PropertyChangedEventArgs("store_sub_types");

	// Token: 0x040038AB RID: 14507
	internal static readonly PropertyChangedEventArgs store_types = new PropertyChangedEventArgs("store_types");

	// Token: 0x040038AC RID: 14508
	internal static readonly PropertyChangedEventArgs Stores = new PropertyChangedEventArgs("Stores");

	// Token: 0x040038AD RID: 14509
	internal static readonly PropertyChangedEventArgs StoreSubTypes = new PropertyChangedEventArgs("StoreSubTypes");

	// Token: 0x040038AE RID: 14510
	internal static readonly PropertyChangedEventArgs StoreTypes = new PropertyChangedEventArgs("StoreTypes");

	// Token: 0x040038AF RID: 14511
	internal static readonly PropertyChangedEventArgs sub_type = new PropertyChangedEventArgs("sub_type");

	// Token: 0x040038B0 RID: 14512
	internal static readonly PropertyChangedEventArgs Summ = new PropertyChangedEventArgs("Summ");

	// Token: 0x040038B1 RID: 14513
	internal static readonly PropertyChangedEventArgs TargetName = new PropertyChangedEventArgs("TargetName");

	// Token: 0x040038B2 RID: 14514
	internal static readonly PropertyChangedEventArgs tasks = new PropertyChangedEventArgs("tasks");

	// Token: 0x040038B3 RID: 14515
	internal static readonly PropertyChangedEventArgs TestConnectionCommand = new PropertyChangedEventArgs("TestConnectionCommand");

	// Token: 0x040038B4 RID: 14516
	internal static readonly PropertyChangedEventArgs to_user = new PropertyChangedEventArgs("to_user");

	// Token: 0x040038B5 RID: 14517
	internal static readonly PropertyChangedEventArgs ToggleSettingsCommand = new PropertyChangedEventArgs("ToggleSettingsCommand");

	// Token: 0x040038B6 RID: 14518
	internal static readonly PropertyChangedEventArgs total = new PropertyChangedEventArgs("total");

	// Token: 0x040038B7 RID: 14519
	internal static readonly PropertyChangedEventArgs TotalFormatted = new PropertyChangedEventArgs("TotalFormatted");

	// Token: 0x040038B8 RID: 14520
	internal static readonly PropertyChangedEventArgs type = new PropertyChangedEventArgs("type");

	// Token: 0x040038B9 RID: 14521
	internal static readonly PropertyChangedEventArgs UpdateDeviceCommand = new PropertyChangedEventArgs("UpdateDeviceCommand");

	// Token: 0x040038BA RID: 14522
	internal static readonly PropertyChangedEventArgs UpdateMakerCommand = new PropertyChangedEventArgs("UpdateMakerCommand");

	// Token: 0x040038BB RID: 14523
	internal static readonly PropertyChangedEventArgs User = new PropertyChangedEventArgs("User");

	// Token: 0x040038BC RID: 14524
	internal static readonly PropertyChangedEventArgs username = new PropertyChangedEventArgs("username");

	// Token: 0x040038BD RID: 14525
	internal static readonly PropertyChangedEventArgs Username = new PropertyChangedEventArgs("Username");

	// Token: 0x040038BE RID: 14526
	internal static readonly PropertyChangedEventArgs users = new PropertyChangedEventArgs("users");

	// Token: 0x040038BF RID: 14527
	internal static readonly PropertyChangedEventArgs users1 = new PropertyChangedEventArgs("users1");

	// Token: 0x040038C0 RID: 14528
	internal static readonly PropertyChangedEventArgs Values = new PropertyChangedEventArgs("Values");

	// Token: 0x040038C1 RID: 14529
	internal static readonly PropertyChangedEventArgs Volume = new PropertyChangedEventArgs("Volume");

	// Token: 0x040038C2 RID: 14530
	internal static readonly PropertyChangedEventArgs warranty = new PropertyChangedEventArgs("warranty");

	// Token: 0x040038C3 RID: 14531
	internal static readonly PropertyChangedEventArgs work_id = new PropertyChangedEventArgs("work_id");

	// Token: 0x040038C4 RID: 14532
	internal static readonly PropertyChangedEventArgs works = new PropertyChangedEventArgs("works");

	// Token: 0x040038C5 RID: 14533
	internal static readonly PropertyChangedEventArgs workshop = new PropertyChangedEventArgs("workshop");
}
