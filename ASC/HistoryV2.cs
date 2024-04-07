using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Objects;
using ASC.Options;
using NLog;

namespace ASC
{
	// Token: 0x020000AA RID: 170
	public class HistoryV2 : IDisposable, IHistoryV2
	{
		// Token: 0x060012D6 RID: 4822 RVA: 0x00024CEC File Offset: 0x00022EEC
		public static logs DefaultLog()
		{
			Localization localization = new Localization("UTC");
			return new logs
			{
				user = Auth.User.id,
				office = Auth.User.office,
				created = new DateTime?(localization.Now),
				arh = new bool?(false)
			};
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x060012D7 RID: 4823 RVA: 0x00024D48 File Offset: 0x00022F48
		// (set) Token: 0x060012D8 RID: 4824 RVA: 0x00024D5C File Offset: 0x00022F5C
		private List<logs> Actions
		{
			[CompilerGenerated]
			get
			{
				return this.<Actions>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Actions>k__BackingField = value;
			}
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x00024D70 File Offset: 0x00022F70
		public HistoryV2()
		{
			if (this.Actions == null)
			{
				this.Actions = new List<logs>();
			}
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x00024D98 File Offset: 0x00022F98
		public void Add(int actionCode, string[] prm = null)
		{
			logs item = this.Action(actionCode, prm);
			this.Actions.Add(item);
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x00024DBC File Offset: 0x00022FBC
		public void AddItemLog(string action, int itemId, string prm1, string prm2 = "")
		{
			logs logs = HistoryV2.DefaultLog();
			logs.type = new int?(6);
			logs.item = new int?(itemId);
			uint num = <PrivateImplementationDetails>.ComputeStringHash(action);
			if (num <= 1961059070U)
			{
				if (num > 680259702U)
				{
					if (num > 1194155916U)
					{
						if (num <= 1764447867U)
						{
							if (num == 1445299912U)
							{
								if (action == "ProductDispatchedOutOfTheBox")
								{
									logs.notes = string.Format("Товар в кол-ве {0}шт. изъят из ячейки {1}", prm1, prm2);
								}
							}
							else if (num == 1764447867U && action == "changePn")
							{
								logs.notes = string.Format(Lang.t("PnChanged"), prm1, prm2);
							}
						}
						else if (num != 1797344847U)
						{
							if (num == 1961059070U)
							{
								if (action == "changeState")
								{
									logs.notes = string.Format("Изменено состояние товара на: \"{0}\"", prm1);
								}
							}
						}
						else if (action == "LastItemMove")
						{
							logs.notes = string.Format("Перемещена последняя позиция, товар изъят из ячейки {0}.", prm1);
						}
					}
					else if (num <= 776952170U)
					{
						if (num != 719794462U)
						{
							if (num == 776952170U)
							{
								if (action == "changeMinInStock")
								{
									logs.notes = string.Format(Lang.t("MinInStockChanged"), prm1);
								}
							}
						}
						else if (action == "GivePart2User")
						{
							logs.notes = string.Format("Товар {0:D6} выдан сотруднику {1}", itemId, prm1);
						}
					}
					else if (num == 831396749U)
					{
						if (action == "ReserveRestored")
						{
							logs.notes = string.Format("Товар {0:D6} восстановлен после отмены выдачи устройства из ремонта {1} и поставлен в резерв", itemId, prm1);
						}
					}
					else if (num == 1194155916U)
					{
						if (action == "changeSn")
						{
							logs.notes = string.Format(Lang.t("SnChanged"), prm1, prm2);
						}
					}
				}
				else if (num > 115639554U)
				{
					if (num > 198745228U)
					{
						if (num != 304218569U)
						{
							if (num == 680259702U)
							{
								if (action == "SetAttributeValue")
								{
									logs.notes = string.Format("{0}: {1}", prm1, prm2);
								}
							}
						}
						else if (action == "changeCategory")
						{
							logs.notes = string.Format("Задана новая категория товара: \"{0}\"", prm1);
						}
					}
					else if (num == 163424912U)
					{
						if (action == "changePrice2")
						{
							logs.notes = string.Format("Изменена розничная стоимость с {0} на {1} {2}", prm1, prm2, Auth.CurrencyModel.ShortName);
						}
					}
					else if (num == 198745228U && action == "changeDealer")
					{
						logs.notes = string.Format(Lang.t("DealerChanged"), prm1);
					}
				}
				else if (num == 110107294U)
				{
					if (action == "changeName")
					{
						logs.notes = string.Format("Наименование товара изменено с {0} на {1}", prm1, prm2);
					}
				}
				else if (num == 112311808U)
				{
					if (action == "ItemSold")
					{
						logs.notes = string.Format("Продажа товара в кол-ве {0} шт.", prm1);
					}
				}
				else if (num == 115639554U)
				{
					if (action == "changePrice")
					{
						logs.notes = string.Format("Изменена стоимость для СЦ с {0} на {1} {2}", prm1, prm2, Auth.CurrencyModel.ShortName);
					}
				}
			}
			else if (num > 3568639561U)
			{
				if (num > 3805797587U)
				{
					if (num > 3967851520U)
					{
						if (num != 4117049305U)
						{
							if (num == 4288014389U && action == "changePrice34")
							{
								logs.notes = string.Format("Изменена оптовая стоимость с {0} на {1} {2}", prm1, prm2, Auth.CurrencyModel.ShortName);
							}
						}
						else if (action == "ProductDeleted")
						{
							logs.notes = Lang.t("ProductDeleted");
						}
					}
					else if (num != 3933881361U)
					{
						if (num == 3967851520U && action == "PriceLessIn")
						{
							logs.notes = "Установлена стоимость товара ниже закупочной";
						}
					}
					else if (action == "ItemCancelled")
					{
						logs.notes = string.Format("Списание товара в кол-ве {0} шт.", prm1);
					}
				}
				else if (num <= 3640800726U)
				{
					if (num == 3614174214U)
					{
						if (action == "changeStore")
						{
							logs.notes = string.Format("Товар помещён на склад: \"{0}\"", prm1);
						}
					}
					else if (num == 3640800726U && action == "ItemSoldInRepair")
					{
						logs.notes = string.Format("Товар установленный в ремонт {0} продан. Ремонт выдан", prm1);
					}
				}
				else if (num != 3717040316U)
				{
					if (num == 3805797587U && action == "ProductsMoveComplete")
					{
						logs.notes = "Товар доставлен, резерв снят.";
					}
				}
				else if (action == "QuantityChanged")
				{
					logs.notes = string.Format(Lang.t("QuantityChanged"), prm1, prm2);
				}
			}
			else if (num > 2831940925U)
			{
				if (num > 3139893185U)
				{
					if (num == 3350065124U)
					{
						if (action == "setBox")
						{
							logs.notes = string.Format("Товар помещён в ячейку {0}", prm1);
						}
					}
					else if (num == 3568639561U)
					{
						if (action == "itemDevided")
						{
							logs.notes = string.Format(Lang.t("ItemDevided"), prm1, prm2);
						}
					}
				}
				else if (num != 2896535551U)
				{
					if (num == 3139893185U)
					{
						if (action == "SaleAndCancellReserve")
						{
							logs.notes = "Товар продан, резерв снят.";
						}
					}
				}
				else if (action == "changeArticul")
				{
					logs.notes = string.Format("Изменён артикул с {0} на {1}", prm1, prm2);
				}
			}
			else if (num <= 2037561039U)
			{
				if (num == 2007221051U)
				{
					if (action == "CancellReserve")
					{
						logs.notes = string.Format("Товар {0:D6} выданный ранее сотруднику {1} возвращён на склад", itemId, prm1);
					}
				}
				else if (num == 2037561039U && action == "changeBarcode")
				{
					logs.notes = string.Format(Lang.t("BarcodeChanged"), prm1, prm2);
				}
			}
			else if (num != 2573888484U)
			{
				if (num == 2831940925U)
				{
					if (action == "InPriceChanged")
					{
						logs.notes = string.Format(Lang.t("InPriceChanged"), prm1, prm2);
					}
				}
			}
			else if (action == "LastItemSold")
			{
				logs.notes = string.Format("Продана последняя позиция, товар изъят из ячейки {0}.", prm1);
			}
			this.Actions.Add(logs);
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x00025494 File Offset: 0x00023694
		public void AddItemLog(int itemId, parts_request request)
		{
			logs logs = HistoryV2.DefaultLog();
			logs.type = new int?(6);
			logs.item = new int?(itemId);
			logs.part_request = new int?(request.id);
			logs.notes = string.Format(Lang.t("RequestPartArrival"), itemId, request.id);
			this.Actions.Add(logs);
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x00025504 File Offset: 0x00023704
		public void AddRepairItemLog(string action, int itemId, int repairId, int customerId)
		{
			logs logs = HistoryV2.DefaultLog();
			logs.type = new int?(6);
			logs.item = new int?(itemId);
			logs.repair = new int?(repairId);
			logs.client = new int?(customerId);
			if (action == "ItemSoldInRepair")
			{
				logs.notes = string.Format("Товар установленный в ремонт {0:D6} продан. Ремонт выдан", repairId);
			}
			this.Actions.Add(logs);
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x00025578 File Offset: 0x00023778
		public void AddDocumentLog(string action, int documentId, string notes = "")
		{
			logs logs = HistoryV2.DefaultLog();
			logs.type = new int?(6);
			logs.document = new int?(documentId);
			uint num = <PrivateImplementationDetails>.ComputeStringHash(action);
			if (num <= 2675022544U)
			{
				if (num <= 1592276806U)
				{
					if (num != 619783888U)
					{
						if (num != 1311639960U)
						{
							if (num == 1592276806U && action == "AdminChangeTotal")
							{
								logs.notes = string.Format("Административная смена общей суммы документа {0:D6} на {1} {2}", documentId, notes, Auth.CurrencyModel.SelectedCurrency.ShortName);
							}
						}
						else if (action == "TrackChanged")
						{
							logs.notes = string.Format(Lang.t("TrackChanged"), documentId, notes);
						}
					}
					else if (action == "printDocument1")
					{
						logs.notes = string.Format(Lang.t("printDocument1"), documentId);
					}
				}
				else if (num == 1646531998U)
				{
					if (action == "InvoicePaid")
					{
						logs.notes = string.Format("Счёт {0} к РН {1:D6} оплачен.", notes, documentId);
					}
				}
				else if (num == 2455978705U)
				{
					if (action == "CancellRn")
					{
						logs.notes = string.Format("Расходная накладная {0:D6} распроведена, примечание: {1}", documentId, notes);
					}
				}
				else if (num == 2675022544U && action == "printRko")
				{
					logs.notes = string.Format("Печать расходно-кассового ордера №{0}", documentId);
				}
			}
			else if (num > 3326869890U)
			{
				if (num <= 3489850306U)
				{
					if (num == 3455935497U)
					{
						if (action == "InvoiceItemsIssued")
						{
							logs.notes = string.Format("Товары по РН {0:D6} выданы покупателю.", documentId);
						}
					}
					else if (num == 3489850306U && action == "printRashodnayaNakladnaya")
					{
						logs.notes = Lang.t("PrintRn");
					}
				}
				else if (num != 3644815883U)
				{
					if (num == 3729765775U)
					{
						if (action == "RnCreated")
						{
							logs.notes = string.Format(Lang.t("RnCreated"), documentId);
						}
					}
				}
				else if (action == "MoveDocumentCreated")
				{
					logs.notes = string.Format(Lang.t("MoveDocumentCreated"), documentId);
				}
			}
			else if (num == 2765045532U)
			{
				if (action == "CancelledReserve")
				{
					logs.notes = Lang.t("CancelledReserve");
				}
			}
			else if (num != 3240501646U)
			{
				if (num == 3326869890U)
				{
					if (action == "printPko")
					{
						logs.notes = string.Format("Печать приходно-кассового ордера №{0}", documentId);
					}
				}
			}
			else if (action == "NotesChanged")
			{
				logs.notes = string.Format(Lang.t("NotesChanged"), notes);
			}
			this.Actions.Add(logs);
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x00025890 File Offset: 0x00023A90
		public void AddPartsRequestLog(string action, int requestId, string prm1 = "", string prm2 = "")
		{
			logs logs = HistoryV2.DefaultLog();
			logs.type = new int?(8);
			logs.part_request = new int?(requestId);
			if (action == "stateChanged")
			{
				logs.notes = string.Format(Lang.t("RequestStatusChanged"), requestId, prm1, prm2);
			}
			else if (action == "trackingChanged")
			{
				logs.notes = string.Format(Lang.t("RequestTrackingChanged"), requestId, prm1, prm2);
			}
			else if (!(action == "created"))
			{
				if (action == "addIntComment")
				{
					logs.notes = string.Format(Lang.t("AddRequestComment"), requestId);
				}
			}
			else
			{
				logs.notes = string.Format(Lang.t("PartsRequestCreated"), requestId);
			}
			this.Actions.Add(logs);
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x00025974 File Offset: 0x00023B74
		public void AddPartsRequestLog(int requestId, DateTime? prm1, DateTime? prm2)
		{
			logs logs = HistoryV2.DefaultLog();
			logs.type = new int?(8);
			logs.part_request = new int?(requestId);
			logs.notes = ((prm1 == null) ? string.Format(Lang.t("RequestDeadlineSet"), requestId, prm2) : string.Format(Lang.t("RequestDeadlineChanged"), requestId, prm1, prm2));
			this.Actions.Add(logs);
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x000259F8 File Offset: 0x00023BF8
		public void AddPartsRequestLog(int requestId, decimal? prm1, decimal? prm2)
		{
			logs logs = HistoryV2.DefaultLog();
			logs.type = new int?(8);
			logs.part_request = new int?(requestId);
			logs.notes = ((prm1 == null) ? string.Format(Lang.t("RequestSummSet"), requestId, prm2) : string.Format(Lang.t("RequestSummChanged"), requestId, prm1, prm2));
			this.Actions.Add(logs);
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x00025A7C File Offset: 0x00023C7C
		public void AddClientLog(string action, int clientId, [Optional] decimal summa = 0m, int repairId = 0)
		{
			logs logs = HistoryV2.DefaultLog();
			logs.type = new int?(2);
			logs.client = new int?(clientId);
			uint num = <PrivateImplementationDetails>.ComputeStringHash(action);
			if (num <= 1571890602U)
			{
				if (num > 1056909338U)
				{
					if (num == 1179592599U)
					{
						if (action == "RepairDebtClose")
						{
							logs.notes = string.Format("Гашение долга клиента {0:D6} за ремонт устройства {1:D6} в размере {2:N2}", clientId, repairId, summa);
						}
					}
					else if (num == 1571890602U)
					{
						if (action == "DealerPayment")
						{
							logs.notes = string.Format("Выплата денег клиенту {0:D6} за проданный товар находящийся на реализации в размере {1:N2}", clientId, summa);
						}
					}
				}
				else if (num != 11486927U)
				{
					if (num == 1056909338U && action == "clientCreated")
					{
						logs.notes = string.Format(Lang.t("CustomerCardCreated"), clientId);
					}
				}
				else if (action == "balancePlus")
				{
					logs.notes = string.Format("Зачисление средств на баланса клиента №{0:D6} на сумму {1:N2}", clientId, summa);
				}
			}
			else if (num <= 2263203895U)
			{
				if (num != 2231995623U)
				{
					if (num == 2263203895U)
					{
						if (action == "PayFromBalance")
						{
							logs.notes = string.Format("Выдача средств с баланса клиента №{0:D6} на сумму {1:N2}", clientId, summa);
						}
					}
				}
				else if (action == "filllUpBalance")
				{
					logs.notes = string.Format("Баланс клиента №{0:D6} пополнен на {1:N2}", clientId, summa);
				}
			}
			else if (num != 2291117011U)
			{
				if (num == 3566235622U && action == "balanceOn")
				{
					logs.notes = Lang.t("CustomerBalanceEnabled");
				}
			}
			else if (action == "RepairDebtOut")
			{
				logs.notes = string.Format("Выдача клиенту {0:D6} устройства {1:D6} в долг на сумму {2:N2}", clientId, repairId, summa);
			}
			this.Actions.Add(logs);
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x00025C98 File Offset: 0x00023E98
		public void AddClientCardLog(string action, int clientId, string value1, string value2)
		{
			logs logs = HistoryV2.DefaultLog();
			logs.type = new int?(2);
			logs.client = new int?(clientId);
			uint num = <PrivateImplementationDetails>.ComputeStringHash(action);
			if (num <= 2595329078U)
			{
				if (num > 761514313U)
				{
					if (num == 1088466045U)
					{
						if (action == "PhoneChanged")
						{
							logs.notes = string.Format(Lang.t("LogPhoneChanged"), clientId, value1, value2);
						}
					}
					else if (num != 2275369349U)
					{
						if (num == 2595329078U)
						{
							if (action == "CustomerWasMerged")
							{
								logs.notes = string.Format(Lang.t("CustomerWasMerged"), clientId, value1);
							}
						}
					}
					else if (action == "EmailChanged")
					{
						logs.notes = string.Format(Lang.t("LogContactChanged"), new object[]
						{
							"Email",
							clientId,
							value1,
							value2
						});
					}
				}
				else if (num != 85902441U)
				{
					if (num != 713370968U)
					{
						if (num == 761514313U)
						{
							if (action == "SmsSended")
							{
								logs.notes = string.Format("Клиенту {0:D6} отправлено SMS сообщение: {1}", clientId, value1);
							}
						}
					}
					else if (action == "IcqChanged")
					{
						logs.notes = string.Format(Lang.t("LogContactChanged"), new object[]
						{
							"ICQ",
							clientId,
							value1,
							value2
						});
					}
				}
				else if (action == "AddressChanged")
				{
					logs.notes = string.Format(Lang.t("LogAddressChanged"), clientId, value1, value2);
				}
			}
			else if (num > 3358883675U)
			{
				if (num > 3426189743U)
				{
					if (num != 3581395714U)
					{
						if (num == 3783244331U)
						{
							if (action == "SkypeChanged")
							{
								logs.notes = string.Format(Lang.t("LogContactChanged"), new object[]
								{
									"Skype",
									clientId,
									value1,
									value2
								});
							}
						}
					}
					else if (action == "SurNameChanged")
					{
						logs.notes = string.Format(Lang.t("LogLastNameChanged"), clientId, value1, value2);
					}
				}
				else if (num == 3420170341U)
				{
					if (action == "WhatsAppChanged")
					{
						logs.notes = string.Format(Lang.t("LogContactChanged"), new object[]
						{
							"WhatsApp",
							clientId,
							value1,
							value2
						});
					}
				}
				else if (num == 3426189743U && action == "ViberChanged")
				{
					logs.notes = string.Format(Lang.t("LogContactChanged"), new object[]
					{
						"Viber",
						clientId,
						value1,
						value2
					});
				}
			}
			else if (num == 3094106690U)
			{
				if (action == "NameChanged")
				{
					logs.notes = string.Format(Lang.t("LogNameChanged"), clientId, value1, value2);
				}
			}
			else if (num == 3109333065U)
			{
				if (action == "PatronymicChanged")
				{
					logs.notes = string.Format(Lang.t("LogPatronymicChanged"), clientId, value1, value2);
				}
			}
			else if (num == 3358883675U && action == "UrNameChanged")
			{
				logs.notes = string.Format(Lang.t("LogUrNameChanged"), clientId, value1, value2);
			}
			this.Actions.Add(logs);
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x00026070 File Offset: 0x00024270
		public void AddClientCardLog(string action, int customerId, IPhone tel)
		{
			logs logs = HistoryV2.DefaultLog();
			logs.type = new int?(2);
			logs.client = new int?(customerId);
			if (!(action == "TelCreated"))
			{
				if (action == "TelDeleted")
				{
					logs.notes = string.Format(Lang.t("TelDeleted"), tel.Phone);
				}
			}
			else
			{
				logs.notes = string.Format(Lang.t("TelCreated"), tel.Phone);
			}
			this.Actions.Add(logs);
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x000260FC File Offset: 0x000242FC
		public void AddClientCardLog(string action, int clientId, bool boolValue)
		{
			logs logs = HistoryV2.DefaultLog();
			logs.type = new int?(2);
			logs.client = new int?(clientId);
			if (action == "badChanged")
			{
				string resourceName = boolValue ? "LogIsBad" : "LogIsBadUnchecked";
				logs.notes = string.Format(Lang.t(resourceName), clientId);
			}
			else if (action == "regularChanged")
			{
				string resourceName = boolValue ? "LogIsRegular" : "LogIsRegularUnchecked";
				logs.notes = string.Format(Lang.t(resourceName), clientId);
			}
			else if (!(action == "TypeChanged"))
			{
				if (!(action == "DealerChanged"))
				{
					if (action == "ArchiveChanged")
					{
						string resourceName = boolValue ? "LogIsArchive" : "LogIsArchiveUnchecked";
						logs.notes = string.Format(Lang.t(resourceName), clientId);
					}
				}
				else
				{
					string resourceName = boolValue ? "LogIsDealer" : "LogIsDealerUnchecked";
					logs.notes = string.Format(Lang.t(resourceName), clientId);
				}
			}
			else
			{
				string resourceName = boolValue ? "LogIsUr" : "LogIsNormal";
				logs.notes = string.Format(Lang.t(resourceName), clientId);
			}
			this.Actions.Add(logs);
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x00026248 File Offset: 0x00024448
		public void StateChangeLog(workshop repair)
		{
			WorkshopOptions workshopOptions = new WorkshopOptions();
			logs logs = HistoryV2.DefaultLog();
			logs.type = new int?(3);
			logs.repair = new int?(repair.id);
			if (repair.new_state == 3)
			{
				logs.notes = string.Format("Смена статуса ремонта с {0} на {1} [{2:#.##} {3}]", new object[]
				{
					workshopOptions.GetOption(repair.state).Name,
					workshopOptions.GetOption(repair.new_state).Name,
					repair.repair_cost,
					Auth.CurrencyModel.SelectedCurrency.ShortName
				});
			}
			else
			{
				logs logs2 = logs;
				string format = "Смена статуса ремонта с {0} на {1}";
				WorkshopOptions option = workshopOptions.GetOption(repair.state);
				string arg;
				if (option != null)
				{
					if ((arg = option.Name) != null)
					{
						goto IL_B9;
					}
				}
				arg = "";
				IL_B9:
				WorkshopOptions option2 = workshopOptions.GetOption(repair.new_state);
				string arg2;
				if (option2 != null)
				{
					if ((arg2 = option2.Name) != null)
					{
						goto IL_DA;
					}
				}
				arg2 = "";
				IL_DA:
				logs2.notes = string.Format(format, arg, arg2);
			}
			this.Actions.Add(logs);
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x00026348 File Offset: 0x00024548
		public void AdminUpdateStatusLog(int repairId, int currentStatus, int nextStatus, decimal repairCost)
		{
			WorkshopOptions workshopOptions = new WorkshopOptions();
			logs logs = HistoryV2.DefaultLog();
			logs.type = new int?(3);
			logs.repair = new int?(repairId);
			if (nextStatus == 3)
			{
				logs.notes = string.Format("Административная Смена статуса ремонта с {0} на {1} [{2:#.##} {3}]", new object[]
				{
					workshopOptions.GetOption(currentStatus).Name,
					workshopOptions.GetOption(nextStatus).Name,
					repairCost,
					Auth.CurrencyModel.SelectedCurrency.ShortName
				});
			}
			else
			{
				logs logs2 = logs;
				string format = "Административная Смена статуса ремонта с {0} на {1}";
				WorkshopOptions option = workshopOptions.GetOption(currentStatus);
				string arg;
				if (option != null)
				{
					if ((arg = option.Name) != null)
					{
						goto IL_9C;
					}
				}
				arg = "";
				IL_9C:
				WorkshopOptions option2 = workshopOptions.GetOption(nextStatus);
				string arg2;
				if (option2 != null)
				{
					if ((arg2 = option2.Name) != null)
					{
						goto IL_B8;
					}
				}
				arg2 = "";
				IL_B8:
				logs2.notes = string.Format(format, arg, arg2);
			}
			this.Actions.Add(logs);
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x00026424 File Offset: 0x00024624
		public void AddRepairLog(string action, int repairId, users usr1 = null, users usr2 = null, offices off1 = null, offices off2 = null, works works = null, string[] prmStrings = null)
		{
			logs logs = HistoryV2.DefaultLog();
			logs.type = new int?(3);
			logs.repair = new int?(repairId);
			uint num = <PrivateImplementationDetails>.ComputeStringHash(action);
			if (num <= 1009222597U)
			{
				if (num <= 455159005U)
				{
					if (num == 281375509U)
					{
						if (action == "print_new_rep")
						{
							logs.notes = string.Format(Lang.t("print_new_rep"), repairId);
						}
					}
					else if (num == 301529110U)
					{
						if (action == "addIntComment")
						{
							logs.notes = string.Format(Lang.t("addIntComment"), repairId);
						}
					}
					else if (num == 455159005U)
					{
						if (action == "print_warranty")
						{
							logs.notes = string.Format(Lang.t("print_warranty"), repairId);
						}
					}
				}
				else if (num > 763723887U)
				{
					if (num != 959450639U)
					{
						if (num == 1009222597U && action == "print_rep_label")
						{
							logs.notes = Lang.t("PrintStickers");
						}
					}
					else if (action == "Restored")
					{
						logs.notes = string.Format("Заказ №{0:D6} восстановлен", repairId);
					}
				}
				else if (num != 680865067U)
				{
					if (num == 763723887U)
					{
						if (action == "officeChanged")
						{
							logs.notes = string.Format("Перемещение ремонта №{0:D6} в офис {1}", repairId, off1.name);
						}
					}
				}
				else if (action == "print_lost")
				{
					logs.notes = string.Format("Печать бланка утери квитанции, ремонт №{0:D6} Выдан {1}, по документу {2} номер {3}", new object[]
					{
						repairId,
						prmStrings[0],
						prmStrings[1],
						prmStrings[2]
					});
				}
			}
			else if (num <= 1643602928U)
			{
				if (num <= 1530830646U)
				{
					if (num == 1043399614U)
					{
						if (action == "print_diag")
						{
							logs.notes = string.Format(Lang.t("print_diag"), repairId);
						}
					}
					else if (num == 1530830646U && action == "print_reject")
					{
						logs.notes = string.Format(Lang.t("print_reject"), repairId);
					}
				}
				else if (num == 1628266409U)
				{
					if (action == "masterChanged")
					{
						logs.notes = string.Format("Ответственным инженером ремонта №{0:D6} назначен {1}", repairId, usr1.Fio);
					}
				}
				else if (num == 1643602928U && action == "SetWorksToZero")
				{
					logs.notes = string.Format("Перед выдачей устройства без ремонта стоимость работ установлена в 0. ремонт №{0:D6}", repairId);
				}
			}
			else if (num > 2238151784U)
			{
				if (num == 4062540810U)
				{
					if (action == "Deleted")
					{
						logs.notes = string.Format("Заказ №{0:D6} удалён", repairId);
					}
				}
				else if (num == 4093010905U)
				{
					if (action == "print_works")
					{
						logs.notes = string.Format(Lang.t("print_works"), repairId);
					}
				}
			}
			else if (num == 1927702184U)
			{
				if (action == "newRepairCreated")
				{
					logs.notes = string.Format(Lang.t("newRepairCreated"), repairId);
				}
			}
			else if (num == 2238151784U)
			{
				if (action == "managerChanged")
				{
					logs.notes = string.Format("Ответственным менеджером ремонта №{0:D6} назначен {1}", repairId, usr1.Fio);
				}
			}
			this.Actions.Add(logs);
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x000267F0 File Offset: 0x000249F0
		public void AddRepairLog(int repairId, int informOption)
		{
			KeyValuePair<int, string> keyValuePair = ClientInformOptions.GetAllOptions().FirstOrDefault((KeyValuePair<int, string> o) => o.Key == informOption);
			if (string.IsNullOrEmpty(keyValuePair.Value))
			{
				return;
			}
			logs logs = HistoryV2.DefaultLog();
			logs.type = new int?(3);
			logs.repair = new int?(repairId);
			logs.notes = string.Format(Lang.t("InformStatusChanged"), keyValuePair.Value);
			this.Actions.Add(logs);
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x00026878 File Offset: 0x00024A78
		public void AddRepairLog(int repairId, string color)
		{
			logs logs = HistoryV2.DefaultLog();
			logs.type = new int?(3);
			logs.repair = new int?(repairId);
			logs.notes = string.Format(Lang.t("CororChanged"), color);
			this.Actions.Add(logs);
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x000268C8 File Offset: 0x00024AC8
		public void AddRepairLog(int repairId, string action, bool value)
		{
			string resourceName = (!value) ? "UnCheked" : "Cheked";
			string format = Lang.t("LabelChanged");
			string arg = Lang.t(resourceName);
			logs logs = HistoryV2.DefaultLog();
			logs.type = new int?(3);
			logs.repair = new int?(repairId);
			if (action == "warranty")
			{
				logs.notes = string.Format(format, Lang.t("Warranty"), arg);
			}
			else if (action == "repeat")
			{
				logs.notes = string.Format(format, Lang.t("WasInService"), arg);
			}
			else if (!(action == "canFormat"))
			{
				if (!(action == "expressRepair"))
				{
					if (action == "quickRepair")
					{
						logs.notes = string.Format(format, Lang.t("QuickRepair"), arg);
					}
					else if (!(action == "thirsPartySc"))
					{
						logs.notes = "";
					}
					else
					{
						logs.notes = string.Format(format, Lang.t("CheckBoxThirdPartySc"), arg);
					}
				}
				else
				{
					logs.notes = string.Format(format, Lang.t("CheckBoxExpressRepair"), arg);
				}
			}
			else
			{
				logs.notes = string.Format(format, Lang.t("CheckBoxCanFormat"), arg);
			}
			this.Actions.Add(logs);
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x00026A14 File Offset: 0x00024C14
		public void AddRepairLog(int repairId, decimal summ)
		{
			logs logs = HistoryV2.DefaultLog();
			logs.type = new int?(3);
			logs.repair = new int?(repairId);
			logs.notes = string.Format(Lang.t("KkmCheckPrinted"), summ);
			this.Actions.Add(logs);
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x00026A68 File Offset: 0x00024C68
		public void AddRepairLog(string action, IWorkPartObject item)
		{
			logs logs = HistoryV2.DefaultLog();
			logs.type = new int?(3);
			logs.repair = new int?(item.RepairId);
			logs.item = item.ItemId;
			if (!(action == "workAdded"))
			{
				if (!(action == "workRemoved"))
				{
					if (action == "partAdded")
					{
						logs.notes = string.Format(Lang.t("partAdded"), item.Name, item.Summ, item.RepairId);
					}
					else if (action == "partRemoved")
					{
						logs.notes = string.Format(Lang.t("partRemoved"), item.Name, item.Summ, item.RepairId);
					}
				}
				else
				{
					logs.notes = string.Format(Lang.t("workRemoved"), item.Name, item.Price, item.RepairId);
				}
			}
			else
			{
				logs.notes = string.Format(Lang.t("workAdded"), item.Name, item.Price, item.RepairId);
			}
			this.Actions.Add(logs);
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x00026BBC File Offset: 0x00024DBC
		public void AddRepairLog(string action, int repairId, decimal amount, int paymentSystem)
		{
			logs logs = HistoryV2.DefaultLog();
			logs.type = new int?(3);
			logs.repair = new int?(repairId);
			string shortName = Auth.CurrencyModel.SelectedCurrency.ShortName;
			PaymentOptions paymentOptions = OfflineData.Instance.PaymentOptionses.Single((PaymentOptions i) => i.Id == paymentSystem);
			if (!(action == "Issued2Client"))
			{
				if (action == "RepairPrePayment")
				{
					logs.notes = string.Format("{0} {1:N2} {2}, {3}", new object[]
					{
						Lang.t("PrePaid"),
						amount,
						shortName,
						paymentOptions.Name.ToLower()
					});
				}
			}
			else
			{
				logs.notes = string.Format("Заказаз-наряд: {0:D6}, выдан клиенту. Сумма: {1:N2} {2}, оплата: {3}", new object[]
				{
					repairId,
					amount,
					shortName,
					(paymentOptions != null) ? paymentOptions.Name : null
				});
			}
			this.Actions.Add(logs);
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x00026CC4 File Offset: 0x00024EC4
		public void AddRepairLog(string action, int repairId, string prm1, string prm2 = "")
		{
			logs logs = HistoryV2.DefaultLog();
			logs.type = new int?(3);
			logs.repair = new int?(repairId);
			uint num = <PrivateImplementationDetails>.ComputeStringHash(action);
			if (num > 2027900772U)
			{
				if (num <= 2889760915U)
				{
					if (num > 2661037133U)
					{
						if (num != 2668262992U)
						{
							if (num == 2787252403U)
							{
								if (action == "InvoicePaidRepair")
								{
									logs.notes = string.Format(Lang.t("InvoicePaidRepair"), prm1, repairId);
								}
							}
							else if (num == 2889760915U && action == "PreviousRepairChanged")
							{
								logs.notes = string.Format(Lang.t("PreviousRepairChanged"), prm1, prm2);
							}
						}
						else if (action == "diagSummChanged")
						{
							logs.notes = string.Format(Lang.t("DiagSummChanged"), prm1, prm2);
						}
					}
					else if (num == 2054539454U)
					{
						if (action == "putInBox")
						{
							logs.notes = string.Format("Заказаз-наряд: {0:D6}, помещён в ячейку {1}", repairId, prm1);
						}
					}
					else if (num != 2580189720U)
					{
						if (num == 2661037133U)
						{
							if (action == "InformStatusReset")
							{
								logs.notes = string.Format("Сброшен статус информирования клиента. Предыдущий статус: {0}", prm1);
							}
						}
					}
					else if (action == "CompanyChanged")
					{
						logs.notes = string.Format(Lang.t("CompanyChanged"), prm1);
					}
				}
				else if (num <= 3032392575U)
				{
					if (num == 3012890516U)
					{
						if (action == "WorkEmployeeChanged")
						{
							logs.notes = string.Format(Lang.t("WorkEmployeeChanged"), prm1, prm2);
						}
					}
					else if (num != 3021345423U)
					{
						if (num == 3032392575U && action == "BalancePayment")
						{
							logs.notes = Lang.t("BalancePayment") + " " + prm1;
						}
					}
					else if (action == "IssueMsgChanged")
					{
						logs.notes = string.Format(Lang.t("IssueMsgChanged"), prm1);
					}
				}
				else if (num <= 3240501646U)
				{
					if (num == 3237767784U)
					{
						if (action == "removedFromBox")
						{
							logs.notes = string.Format("Заказаз-наряд: {0:D6}, изъят из ячейки {1}", repairId, prm1);
						}
					}
					else if (num == 3240501646U && action == "NotesChanged")
					{
						logs.notes = string.Format(Lang.t("NotesChanged"), prm1);
					}
				}
				else if (num == 4160081007U)
				{
					if (action == "printRejectDoc")
					{
						logs.notes = string.Format("Печать акта отказа от работ, ремонт №{0:D6} Причина отказа: {1}", repairId, prm1);
					}
				}
				else if (num == 4175490483U)
				{
					if (action == "WorkPriceChanged")
					{
						logs.notes = string.Format(Lang.t("WorkPriceChanged"), prm1, prm2);
					}
				}
			}
			else if (num <= 1037180460U)
			{
				if (num <= 897857338U)
				{
					if (num == 335316109U)
					{
						if (action == "faultChanged")
						{
							logs.notes = string.Format(Lang.t("FaultChanged"), prm1, prm2);
						}
					}
					else if (num != 850006257U)
					{
						if (num == 897857338U)
						{
							if (action == "diagChanged")
							{
								logs.notes = string.Format(Lang.t("DiagChanged"), prm1, prm2);
							}
						}
					}
					else if (action == "VendorWarrantyChanged")
					{
						logs.notes = string.Format(Lang.t("VendorWarrantyChanged"), prm1);
					}
				}
				else if (num != 985648249U)
				{
					if (num == 995554826U)
					{
						if (action == "ClientChanged")
						{
							logs.notes = string.Format(Lang.t("ClientChanged"), prm1, prm2);
						}
					}
					else if (num == 1037180460U)
					{
						if (action == "SetRepairCostToZero")
						{
							logs.notes = string.Format("Стоимость ремонта в результатах диагности изменена с {0} на 0 перед выдачей без ремонта", prm1);
						}
					}
				}
				else if (action == "WorkNameChanged")
				{
					logs.notes = string.Format(Lang.t("WorkNameChanged"), prm1, prm2);
				}
			}
			else if (num > 1277616868U)
			{
				if (num <= 1898378860U)
				{
					if (num == 1767184156U)
					{
						if (action == "WorkWarrantyChanged")
						{
							logs.notes = string.Format(Lang.t("WorkWarrantyChanged"), prm1, prm2);
						}
					}
					else if (num == 1898378860U && action == "SetUserField")
					{
						logs.notes = string.Format(Lang.t("SetUserField"), prm1, prm2);
					}
				}
				else if (num == 1929881150U)
				{
					if (action == "ModelChanged")
					{
						logs.notes = string.Format("Модель устройства изменена на: {0}", prm1);
					}
				}
				else if (num == 2027900772U && action == "InvoiceChanged")
				{
					logs.notes = string.Format(Lang.t("InvoiceChanged"), prm1);
				}
			}
			else if (num == 1097608037U)
			{
				if (action == "MakerChanged")
				{
					logs.notes = string.Format("Производитель устройства изменен на: {0}", prm1);
				}
			}
			else if (num != 1179752496U)
			{
				if (num == 1277616868U)
				{
					if (action == "paymentSystemChanged")
					{
						logs.notes = string.Format(Lang.t("PaymentSystemChanged"), prm1);
					}
				}
			}
			else if (action == "snChanged")
			{
				logs.notes = string.Format(Lang.t("SnChanged"), prm1, prm2);
			}
			this.Actions.Add(logs);
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x000272B0 File Offset: 0x000254B0
		public void AddUserLog(string action, int userId, string[] prm)
		{
			logs logs = HistoryV2.DefaultLog();
			logs.type = new int?(4);
			logs.user = userId;
			string shortName = Auth.CurrencyModel.SelectedCurrency.ShortName;
			if (!(action == "advancePay"))
			{
				if (action == "SalaryPay")
				{
					logs.notes = string.Format("Выплачена заработная плата сотруднику в размере {0} {1}", prm[0], shortName);
				}
				else if (action == "SalaryRateChanged")
				{
					logs.notes = string.Format("Ставка за месяц установлена в {0} {1}", prm[0], shortName);
				}
			}
			else
			{
				logs.notes = string.Format("Выплачен аванс в размере {0} {1}", prm[0], shortName);
			}
			this.Actions.Add(logs);
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x0002735C File Offset: 0x0002555C
		public void AddKassaLog(cash_orders order)
		{
			logs logs = HistoryV2.DefaultLog();
			logs.type = new int?(7);
			for (;;)
			{
				logs.group = new int?(4);
				switch (order.type)
				{
				case 1:
					goto IL_EB;
				case 2:
					goto IL_107;
				case 3:
					goto IL_123;
				case 4:
				case 5:
				case 6:
				case 8:
				case 9:
				case 10:
				case 16:
					return;
				case 7:
					goto IL_13F;
				case 11:
					goto IL_174;
				case 12:
					goto IL_190;
				case 13:
					goto IL_1AC;
				case 14:
					goto IL_1C8;
				case 15:
					goto IL_1EF;
				case 17:
					goto IL_20B;
				default:
				{
					uint num;
					switch ((num = (num * 76831710U ^ 576171461U ^ 1437054708U)) % 20U)
					{
					case 0U:
						goto IL_107;
					case 1U:
						return;
					case 2U:
					case 16U:
						continue;
					case 3U:
						goto IL_1EF;
					case 4U:
						goto IL_190;
					case 5U:
						return;
					case 6U:
						return;
					case 7U:
						goto IL_123;
					case 8U:
						goto IL_20B;
					case 9U:
						return;
					case 10U:
						goto IL_174;
					case 11U:
						goto IL_1C8;
					case 12U:
						return;
					case 13U:
						return;
					case 14U:
						goto IL_13F;
					case 15U:
						return;
					case 18U:
						goto IL_1AC;
					case 19U:
						goto IL_EB;
					}
					goto Block_1;
				}
				}
			}
			Block_1:
			return;
			IL_EB:
			logs.notes = string.Format("Создан РКО №{0:D6} (без привязки)", order.id);
			return;
			IL_107:
			logs.notes = string.Format("Создан РКО №{0:D6} (оплата приходной накладной)", order.id);
			return;
			IL_123:
			logs.notes = string.Format("Создан РКО №{0:D6} (Z отчёт)", order.id);
			return;
			IL_13F:
			logs.notes = string.Format((order.summa < 0m) ? "Создан виртуальный РКО №{0:D6} - выемка средств" : "Создан виртуальный ПКО №{0:D6} внесение средств", order.id);
			return;
			IL_174:
			logs.notes = string.Format("Создан ПКО №{0:D6} (без привязки)", order.id);
			return;
			IL_190:
			logs.notes = string.Format("Создан ПКО №{0:D6} (предоплата за ремонт)", order.id);
			return;
			IL_1AC:
			logs.notes = string.Format("Создан ПКО №{0:D6} (зачислением средств на баланс клиента)", order.id);
			return;
			IL_1C8:
			logs.notes = string.Format("Создан ПКО №{0:D6} продажа товаров по накладной {1:D6}", order.id, order.document);
			return;
			IL_1EF:
			logs.notes = string.Format("Создан ПКО №{0:D6} в счёт выполненого ремонта", order.id);
			return;
			IL_20B:
			logs.notes = string.Format("Создан ПКО №{0:D6} в счёт оплаченного счёта {1:D6}", order.id, order.invoice);
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x0002759C File Offset: 0x0002579C
		private logs Action(int code, string[] prm = null)
		{
			logs logs = HistoryV2.DefaultLog();
			logs.type = new int?(code);
			uint num;
			switch (code)
			{
			case 1:
				IL_190E:
				logs.group = new int?(2);
				num = 3668929737U;
				break;
			case 2:
			case 3:
			case 4:
			case 52:
			case 53:
				return logs;
			case 5:
				IL_5B0:
				logs.group = new int?(1);
				num = ((prm != null) ? 4030446983U : 4238111222U);
				break;
			case 6:
				IL_3CD:
				logs.group = new int?(1);
				num = 2853477644U;
				break;
			case 7:
				IL_13FD:
				logs.group = new int?(1);
				num = 3544325351U;
				break;
			case 8:
				IL_377:
				logs.group = new int?(1);
				num = ((prm == null) ? 4238111222U : 3125771829U);
				break;
			case 9:
				IL_12FD:
				logs.group = new int?(1);
				num = 4144104724U;
				break;
			case 10:
				IL_1A65:
				logs.group = new int?(1);
				num = ((prm != null) ? 2279018680U : 4238111222U);
				break;
			case 11:
				IL_1765:
				logs.group = new int?(1);
				num = ((prm != null) ? 3129999023U : 4238111222U);
				break;
			case 12:
				IL_C45:
				logs.group = new int?(1);
				num = 4060926101U;
				break;
			case 13:
				IL_1374:
				logs.group = new int?(1);
				num = ((prm != null) ? 3345179952U : 4238111222U);
				break;
			case 14:
				IL_75D:
				logs.group = new int?(1);
				logs.notes = "Очищен лог администратора";
				num = 3735849320U;
				break;
			case 15:
				IL_4FA:
				logs.group = new int?(1);
				num = ((prm != null) ? 2346620117U : 4238111222U);
				break;
			case 16:
				IL_C08:
				logs.group = new int?(1);
				num = 3502266886U;
				break;
			case 17:
				IL_BC7:
				logs.group = new int?(1);
				num = 2242396735U;
				break;
			case 18:
				IL_1535:
				logs.group = new int?(1);
				num = 2974774106U;
				break;
			case 19:
				IL_7BD:
				logs.group = new int?(1);
				num = ((prm != null) ? 3697509496U : 4238111222U);
				break;
			case 20:
				IL_585:
				logs.group = new int?(1);
				num = ((prm == null) ? 4238111222U : 4128395632U);
				break;
			case 21:
				IL_1278:
				logs.group = new int?(1);
				num = 3247448422U;
				break;
			case 22:
				IL_166:
				logs.group = new int?(1);
				num = ((prm != null) ? 3652561494U : 4238111222U);
				break;
			case 23:
				IL_3A2:
				logs.group = new int?(1);
				num = ((prm != null) ? 3429897108U : 4238111222U);
				break;
			case 24:
				IL_BDD:
				logs.group = new int?(1);
				num = ((prm == null) ? 4238111222U : 3794578730U);
				break;
			case 25:
				IL_20C:
				logs.group = new int?(1);
				num = 2308007661U;
				break;
			case 26:
				IL_EF8:
				logs.group = new int?(1);
				num = ((prm == null) ? 4238111222U : 3269490252U);
				break;
			case 27:
				IL_ACE:
				logs.group = new int?(1);
				num = ((prm != null) ? 4231392519U : 4238111222U);
				break;
			case 28:
				IL_1924:
				logs.group = new int?(1);
				num = ((prm == null) ? 4238111222U : 3590161758U);
				break;
			case 29:
				IL_680:
				logs.group = new int?(1);
				num = ((prm == null) ? 4238111222U : 4265959614U);
				break;
			case 30:
				IL_901:
				logs.group = new int?(1);
				num = 3189446060U;
				break;
			case 31:
				IL_1262:
				logs.group = new int?(1);
				num = 3445692655U;
				break;
			case 32:
				IL_14E3:
				logs.group = new int?(1);
				num = ((prm != null) ? 4001279968U : 4238111222U);
				break;
			case 33:
				IL_1A3D:
				logs.group = new int?(1);
				num = ((prm == null) ? 4238111222U : 3821752698U);
				break;
			case 34:
				IL_1045:
				logs.group = new int?(1);
				num = 3660409937U;
				break;
			case 35:
				IL_12BA:
				logs.group = new int?(1);
				num = 3082596278U;
				break;
			case 36:
				IL_DC1:
				logs.group = new int?(1);
				num = 3570360377U;
				break;
			case 37:
				IL_113:
				logs.group = new int?(1);
				num = ((prm != null) ? 3664193169U : 4238111222U);
				break;
			case 38:
				IL_4BF:
				logs.group = new int?(1);
				num = 4286543541U;
				break;
			case 39:
				IL_45C:
				logs.group = new int?(1);
				num = 4143036599U;
				break;
			case 40:
				IL_F35:
				logs.group = new int?(1);
				num = ((prm == null) ? 4238111222U : 3186531511U);
				break;
			case 41:
				IL_89D:
				logs.group = new int?(1);
				num = 3247528002U;
				break;
			case 42:
				IL_D47:
				logs.group = new int?(1);
				num = ((prm == null) ? 4238111222U : 3041729873U);
				break;
			case 43:
				IL_1636:
				logs.group = new int?(1);
				num = 2727561743U;
				break;
			case 44:
				IL_181A:
				logs.group = new int?(1);
				num = 2855256844U;
				break;
			case 45:
				IL_9B2:
				logs.group = new int?(1);
				num = 4042749053U;
				break;
			case 46:
				IL_3E3:
				logs.group = new int?(1);
				num = ((prm == null) ? 4238111222U : 3003602720U);
				break;
			case 47:
				IL_17EE:
				logs.group = new int?(1);
				num = 2352489143U;
				break;
			case 48:
				IL_1804:
				logs.group = new int?(4);
				num = 3823736352U;
				break;
			case 49:
				IL_B8A:
				logs.group = new int?(4);
				num = 3998840591U;
				break;
			case 50:
				IL_150:
				logs.group = new int?(5);
				num = 2859862017U;
				break;
			case 51:
				IL_D84:
				logs.group = new int?(5);
				num = ((prm == null) ? 4238111222U : 2186979195U);
				break;
			case 54:
				IL_D1C:
				logs.group = new int?(1);
				num = ((prm != null) ? 2432729513U : 4238111222U);
				break;
			case 55:
				IL_4A9:
				logs.group = new int?(1);
				num = 2326096056U;
				break;
			case 56:
				IL_19E8:
				logs.group = new int?(1);
				num = ((prm == null) ? 4238111222U : 2334609469U);
				break;
			case 57:
				IL_1D5D:
				logs.group = new int?(1);
				num = ((prm == null) ? 4238111222U : 3982982190U);
				break;
			default:
				goto IL_1683;
			}
			for (;;)
			{
				IL_1AAD:
				uint num2;
				switch ((num2 = (num ^ 3489471546U)) % 163U)
				{
				case 0U:
					logs.notes = "Удалены дополнительные поля у вида склада " + prm[0];
					num = (num2 * 4242171858U ^ 3428123155U);
					continue;
				case 1U:
					goto IL_1A65;
				case 2U:
					goto IL_1A3D;
				case 3U:
					logs.notes = "Изменено название роли " + prm[0] + " на " + prm[1];
					num = (num2 * 2759648788U ^ 1038202846U);
					continue;
				case 4U:
					goto IL_1D5D;
				case 5U:
					goto IL_19E8;
				case 6U:
					num = (((prm == null) ? 3138851942U : 3787177147U) ^ num2 * 1648520494U);
					continue;
				case 7U:
					num = (((prm == null) ? 3175139848U : 3000860420U) ^ num2 * 3542332358U);
					continue;
				case 8U:
					num = (num2 * 806989046U ^ 288963370U);
					continue;
				case 9U:
					num = (num2 * 199345067U ^ 3507017234U);
					continue;
				case 10U:
					num = (((prm != null) ? 3593274173U : 3110567130U) ^ num2 * 2604483862U);
					continue;
				case 11U:
					goto IL_1924;
				case 12U:
					goto IL_190E;
				case 13U:
					logs.notes = "Создана новая категория " + prm[0] + " в каталоге товаров";
					num = (num2 * 1954155437U ^ 4033533600U);
					continue;
				case 14U:
					num = (((prm != null) ? 178565281U : 899133886U) ^ num2 * 2340317608U);
					continue;
				case 15U:
					num = (num2 * 26963957U ^ 40796740U);
					continue;
				case 16U:
					logs.notes = string.Concat(new string[]
					{
						"Изменён номер телефона сотрудника ",
						prm[0],
						" (",
						prm[1],
						" ",
						prm[2],
						" ",
						prm[3],
						") с ",
						prm[4],
						" на ",
						prm[5]
					});
					num = (num2 * 3073410492U ^ 3615209690U);
					continue;
				case 17U:
					goto IL_181A;
				case 18U:
					goto IL_1804;
				case 19U:
					goto IL_17EE;
				case 20U:
					num = (num2 * 196240846U ^ 825543632U);
					continue;
				case 21U:
					logs.notes = "Сохранены параметры склада " + prm[0];
					num = (num2 * 138809027U ^ 2977130113U);
					continue;
				case 22U:
					num = (((prm == null) ? 3170573800U : 3353974386U) ^ num2 * 1386173402U);
					continue;
				case 23U:
					goto IL_1765;
				case 24U:
					num = (num2 * 205129099U ^ 3545259336U);
					continue;
				case 25U:
					logs.notes = "Удалён логотип офиса  " + prm[0];
					num = (num2 * 1924375044U ^ 1373181667U);
					continue;
				case 26U:
					logs.notes = string.Concat(new string[]
					{
						"Изменение процента с работ при быстрой продаже сотрудника ",
						prm[0],
						" (",
						prm[1],
						" ",
						prm[2],
						" ",
						prm[3],
						") с ",
						prm[4],
						" на ",
						prm[5],
						"%"
					});
					num = (num2 * 3646283606U ^ 1084096881U);
					continue;
				case 27U:
					logs.notes = "Сохранены параметры фона главного окна";
					num = (num2 * 285141212U ^ 3624292270U);
					continue;
				case 28U:
					goto IL_1683;
				case 29U:
					num = (num2 * 2585298118U ^ 2205823688U);
					continue;
				case 30U:
					logs.notes = "Сохранены параметры офиса " + prm[0];
					num = (num2 * 1074403127U ^ 316249519U);
					continue;
				case 31U:
					goto IL_1636;
				case 32U:
					num = (((prm == null) ? 2725525656U : 2969988506U) ^ num2 * 3454250674U);
					continue;
				case 33U:
					num = (num2 * 3209640084U ^ 3741158046U);
					continue;
				case 34U:
					logs.notes = string.Concat(new string[]
					{
						"Изменён офис сотрудника ",
						prm[0],
						" (",
						prm[1],
						" ",
						prm[2],
						" ",
						prm[3],
						")"
					});
					num = (num2 * 2965783195U ^ 674492368U);
					continue;
				case 35U:
					num = (num2 * 754611737U ^ 1043820232U);
					continue;
				case 36U:
					num = (num2 * 1569981062U ^ 1599463786U);
					continue;
				case 37U:
					logs.notes = Lang.t("CompanyCreated") + prm[0];
					num = (num2 * 1423324132U ^ 4233933118U);
					continue;
				case 38U:
					goto IL_1535;
				case 39U:
					num = (((prm != null) ? 2707449007U : 2955984753U) ^ num2 * 3561664797U);
					continue;
				case 40U:
					goto IL_14E3;
				case 41U:
					logs.notes = "Изменено наименование склада с " + prm[0] + " на " + prm[1];
					num = (num2 * 313527270U ^ 1684173580U);
					continue;
				case 42U:
					logs.notes = string.Concat(new string[]
					{
						"Сохранена карточка сотрудника ",
						prm[0],
						" (",
						prm[1],
						" ",
						prm[2],
						" ",
						prm[3],
						")"
					});
					num = (num2 * 2755193585U ^ 4013411844U);
					continue;
				case 43U:
					logs.notes = "Изменено наименование организации с " + prm[0] + " на " + prm[1];
					num = (num2 * 1862796336U ^ 3875525654U);
					continue;
				case 44U:
					num = (num2 * 1918655788U ^ 1532464706U);
					continue;
				case 45U:
					goto IL_13FD;
				case 46U:
					num = (num2 * 1597214001U ^ 3538096355U);
					continue;
				case 47U:
					num = (((prm == null) ? 2583664032U : 3119695210U) ^ num2 * 4229747338U);
					continue;
				case 48U:
					logs.document = new int?(Convert.ToInt32(prm[0]));
					num = (num2 * 2583580825U ^ 40944690U);
					continue;
				case 49U:
					goto IL_1374;
				case 50U:
					logs.notes = "Изменён вид склада " + prm[0];
					num = (num2 * 2620059337U ^ 3167502927U);
					continue;
				case 51U:
					num = (num2 * 1609752866U ^ 1984840090U);
					continue;
				case 52U:
					logs.notes = "Удалена категория " + prm[0] + " в прайс-листе услуг";
					num = (num2 * 968972919U ^ 612408483U);
					continue;
				case 53U:
					goto IL_12FD;
				case 54U:
					logs.notes = "Изменено название производителя в каталоге устройств с " + prm[0] + " на " + prm[1];
					num = (num2 * 3297340374U ^ 3514096974U);
					continue;
				case 55U:
					goto IL_12BA;
				case 56U:
				{
					string arg;
					string arg2;
					logs.notes = string.Format(Lang.t("CompanyTypeChanged"), prm[0], arg, arg2);
					num = (num2 * 3665966302U ^ 3496463912U);
					continue;
				}
				case 57U:
					goto IL_1278;
				case 58U:
					goto IL_1262;
				case 59U:
					logs.notes = Lang.t("CompanyArhivated") + prm[0];
					num = (num2 * 1224705111U ^ 2941027587U);
					continue;
				case 60U:
					logs.notes = "Создан новый офис " + prm[0];
					num = (num2 * 1384868841U ^ 2593213254U);
					continue;
				case 62U:
					logs.notes = "Сохранены параметры роли " + prm[0];
					num = (num2 * 1051019532U ^ 2901985990U);
					continue;
				case 63U:
					num = (((prm == null) ? 3376834996U : 3759506397U) ^ num2 * 3031401930U);
					continue;
				case 64U:
					logs.notes = "Организация " + prm[0] + " восстановлена из архива ";
					num = (num2 * 3967251770U ^ 542494099U);
					continue;
				case 65U:
					logs.notes = string.Concat(new string[]
					{
						"Изменено описание роли ",
						prm[0],
						" с ",
						prm[1],
						" на ",
						prm[2]
					});
					num = (num2 * 1534724681U ^ 268574603U);
					continue;
				case 66U:
					logs.notes = string.Concat(new string[]
					{
						"Изменение cтавки за месяц сотрудника ",
						prm[0],
						" (",
						prm[1],
						" ",
						prm[2],
						" ",
						prm[3],
						") с ",
						prm[4],
						" на ",
						prm[5]
					});
					num = (num2 * 862615858U ^ 2790822087U);
					continue;
				case 67U:
					logs.notes = "Изменено наименование офиса с " + prm[0] + " на " + prm[1];
					num = (num2 * 1437143007U ^ 4282497825U);
					continue;
				case 68U:
					logs.notes = string.Concat(new string[]
					{
						"Изменено описание склада ",
						prm[0],
						" с ",
						prm[1],
						" на ",
						prm[2]
					});
					num = (num2 * 421578108U ^ 1363785455U);
					continue;
				case 69U:
					goto IL_1045;
				case 70U:
					num = (num2 * 2335646441U ^ 1061144243U);
					continue;
				case 71U:
					logs.notes = "Удалена роль " + prm[0];
					num = (num2 * 1823817243U ^ 3144336704U);
					continue;
				case 72U:
					logs.notes = Lang.t("DelBanksOfCompany") + prm[0];
					num = (num2 * 1003072700U ^ 2858350246U);
					continue;
				case 73U:
					logs.notes = string.Concat(new string[]
					{
						"Изменение процента от выполнненых работ сотрудника ",
						prm[0],
						" (",
						prm[1],
						" ",
						prm[2],
						" ",
						prm[3],
						") с ",
						prm[4],
						" на ",
						prm[5],
						"%"
					});
					num = (num2 * 2442466114U ^ 285437186U);
					continue;
				case 74U:
					goto IL_F35;
				case 75U:
					num = (num2 * 3145106977U ^ 1395802415U);
					continue;
				case 76U:
					goto IL_EF8;
				case 77U:
					logs.notes = string.Concat(new string[]
					{
						"Сохранение параметров зарплаты сотрудника ",
						prm[0],
						" (",
						prm[1],
						" ",
						prm[2],
						" ",
						prm[3],
						")"
					});
					num = (num2 * 683767855U ^ 2207938871U);
					continue;
				case 78U:
					num = (num2 * 1661661579U ^ 1015952496U);
					continue;
				case 79U:
					num = (((prm != null) ? 1581871257U : 1520075494U) ^ num2 * 561475864U);
					continue;
				case 80U:
					logs.notes = string.Concat(new string[]
					{
						"Изменение процента с заправки картриджа сотрудника ",
						prm[0],
						" (",
						prm[1],
						" ",
						prm[2],
						" ",
						prm[3],
						") с ",
						prm[4],
						" на ",
						prm[5],
						"%"
					});
					num = (num2 * 3270009442U ^ 2559627385U);
					continue;
				case 81U:
					goto IL_DC1;
				case 82U:
					num = (num2 * 4004318078U ^ 3177091822U);
					continue;
				case 83U:
					goto IL_D84;
				case 84U:
					num = (num2 * 2124171832U ^ 2401409798U);
					continue;
				case 85U:
					goto IL_D47;
				case 86U:
					goto IL_D1C;
				case 87U:
					num = (num2 * 828735785U ^ 970016609U);
					continue;
				case 88U:
					logs.notes = string.Concat(new string[]
					{
						"Удалён сотрудник ",
						prm[0],
						" (",
						prm[1],
						" ",
						prm[2],
						" ",
						prm[3],
						")"
					});
					num = (num2 * 3895814648U ^ 2080788894U);
					continue;
				case 89U:
					num = (num2 * 2580826880U ^ 2093231094U);
					continue;
				case 90U:
					num = (num2 * 4087940160U ^ 3562321078U);
					continue;
				case 91U:
					num = (((prm == null) ? 428581343U : 1846691045U) ^ num2 * 74898155U);
					continue;
				case 92U:
					goto IL_C45;
				case 93U:
					num = (((prm != null) ? 2946889461U : 2940980080U) ^ num2 * 880184174U);
					continue;
				case 94U:
					goto IL_C08;
				case 95U:
					goto IL_BDD;
				case 96U:
					goto IL_BC7;
				case 97U:
					num = (((prm != null) ? 2484721965U : 3120813524U) ^ num2 * 3780977962U);
					continue;
				case 98U:
					goto IL_B8A;
				case 99U:
					logs.notes = "Добавлена новая ячейка " + prm[0] + " на склад " + prm[1];
					num = (num2 * 1031020964U ^ 3269047788U);
					continue;
				case 100U:
					logs.notes = string.Concat(new string[]
					{
						"Создан новый сотрудник ",
						prm[0],
						" (",
						prm[1],
						" ",
						prm[2],
						" ",
						prm[3],
						")"
					});
					num = (num2 * 3694214754U ^ 452903340U);
					continue;
				case 101U:
					goto IL_ACE;
				case 102U:
					logs.notes = Lang.t("CompanyParamChanged") + prm[0];
					num = (num2 * 497793698U ^ 3538561282U);
					continue;
				case 103U:
					num = (num2 * 3513221771U ^ 138227482U);
					continue;
				case 104U:
					num = (((prm != null) ? 3932605223U : 2267825050U) ^ num2 * 894953193U);
					continue;
				case 105U:
					num = (num2 * 709635193U ^ 4029899407U);
					continue;
				case 106U:
					num = (num2 * 3989697333U ^ 4282731762U);
					continue;
				case 107U:
				{
					string arg = ConvertersStack.IndexToCompanyType(Convert.ToInt32(prm[1]));
					string arg2 = ConvertersStack.IndexToCompanyType(Convert.ToInt32(prm[2]));
					num = (num2 * 2168608245U ^ 3831588699U);
					continue;
				}
				case 108U:
					logs.item = new int?(Convert.ToInt32(prm[0]));
					logs.notes = (string.IsNullOrEmpty(prm[2]) ? ("Создан товар из документа ПН №" + prm[1]) : ("Создан товар из документа ПН №" + prm[1] + " и помещён в ячейку " + prm[2]));
					num = 4238111222U;
					continue;
				case 109U:
					goto IL_9B2;
				case 110U:
					logs.notes = string.Concat(new string[]
					{
						"Изменён пароль сотрудника ",
						prm[0],
						" (",
						prm[1],
						" ",
						prm[2],
						" ",
						prm[3],
						")"
					});
					num = (num2 * 1134651752U ^ 1791970174U);
					continue;
				case 111U:
					logs.notes = "Добавлены новые ячейки на склад " + prm[0];
					num = (num2 * 172322742U ^ 3188767513U);
					continue;
				case 112U:
					num = (num2 * 2016172791U ^ 1539887042U);
					continue;
				case 113U:
					goto IL_901;
				case 114U:
					num = (((prm == null) ? 3638461950U : 2380869166U) ^ num2 * 416965276U);
					continue;
				case 115U:
					num = (((prm == null) ? 2264698904U : 4059260957U) ^ num2 * 3729625045U);
					continue;
				case 116U:
					goto IL_89D;
				case 117U:
					logs.notes = "Параметры фона главного окна восстановлены по умолчанию";
					num = (num2 * 2654960842U ^ 2559826841U);
					continue;
				case 118U:
					num = (num2 * 1284666989U ^ 1902160027U);
					continue;
				case 119U:
					num = (num2 * 1266580711U ^ 675630081U);
					continue;
				case 120U:
					num = (((prm != null) ? 1621165888U : 1982174422U) ^ num2 * 989668523U);
					continue;
				case 121U:
					logs.notes = string.Concat(new string[]
					{
						"Создана приходная накладная №",
						prm[0],
						" на сумму ",
						prm[1],
						", кол-во позиций: ",
						prm[2]
					});
					num = (num2 * 2238333714U ^ 1034176300U);
					continue;
				case 122U:
					goto IL_7BD;
				case 123U:
					logs.notes = "Изменено наименование устройства в каталоге устройств с " + prm[0] + " на " + prm[1];
					num = (num2 * 1425830541U ^ 3093728301U);
					continue;
				case 124U:
					num = (num2 * 2927490652U ^ 3909580450U);
					continue;
				case 125U:
					goto IL_75D;
				case 126U:
					logs.notes = string.Concat(new string[]
					{
						"Изменено отчество сотрудника ",
						prm[0],
						" (",
						prm[1],
						" ",
						prm[2],
						" ",
						prm[3],
						") с ",
						prm[4],
						" на ",
						prm[5]
					});
					num = (num2 * 2580369956U ^ 2634962229U);
					continue;
				case 127U:
					num = (num2 * 1730646810U ^ 3948594472U);
					continue;
				case 128U:
					logs.notes = "Создан новый склад " + prm[0];
					num = (num2 * 2122574808U ^ 1548601854U);
					continue;
				case 129U:
					goto IL_680;
				case 130U:
					logs.notes = string.Concat(new string[]
					{
						"Изменена фамилия сотрудника ",
						prm[0],
						" (",
						prm[1],
						" ",
						prm[2],
						" ",
						prm[3],
						") с ",
						prm[4],
						" на ",
						prm[5]
					});
					num = (num2 * 1012660449U ^ 3377822639U);
					continue;
				case 131U:
					logs.notes = Lang.t("DelCompanyLogo") + prm[0];
					num = (num2 * 3240785745U ^ 3679975220U);
					continue;
				case 132U:
					goto IL_5B0;
				case 133U:
					goto IL_585;
				case 134U:
					num = (num2 * 63142464U ^ 1167762678U);
					continue;
				case 135U:
					num = (((prm != null) ? 4284077336U : 3545589968U) ^ num2 * 3945883742U);
					continue;
				case 136U:
					num = (((prm == null) ? 3336472941U : 3887468366U) ^ num2 * 581593869U);
					continue;
				case 137U:
					goto IL_4FA;
				case 138U:
					logs.notes = "Изменён тип склада " + prm[0];
					num = (num2 * 4273141315U ^ 2644903070U);
					continue;
				case 139U:
					goto IL_4BF;
				case 140U:
					goto IL_4A9;
				case 141U:
					num = (num2 * 2540632001U ^ 3056645165U);
					continue;
				case 142U:
					logs.notes = "Создана новая роль " + prm[0];
					num = (num2 * 1082229685U ^ 2723890888U);
					continue;
				case 143U:
					goto IL_45C;
				case 144U:
					num = (((prm == null) ? 105127541U : 1278212301U) ^ num2 * 279619201U);
					continue;
				case 145U:
					num = (((prm == null) ? 2216591982U : 3666718882U) ^ num2 * 1606549476U);
					continue;
				case 146U:
					goto IL_3E3;
				case 147U:
					goto IL_3CD;
				case 148U:
					goto IL_3A2;
				case 149U:
					goto IL_377;
				case 150U:
					num = (((prm == null) ? 2464806858U : 2842564222U) ^ num2 * 3072913409U);
					continue;
				case 151U:
					num = (num2 * 3420405602U ^ 3449389712U);
					continue;
				case 152U:
					num = (((prm == null) ? 2696007994U : 3899019144U) ^ num2 * 1005604997U);
					continue;
				case 153U:
					num = (((prm != null) ? 1658601932U : 1504026459U) ^ num2 * 3553203739U);
					continue;
				case 154U:
					logs.notes = "Создана карточка клиента #" + prm[0];
					num = (num2 * 2399300565U ^ 599089075U);
					continue;
				case 155U:
					logs.notes = "Изменён офис склада  " + prm[0];
					num = (num2 * 4053431694U ^ 457688054U);
					continue;
				case 156U:
					logs.notes = string.Concat(new string[]
					{
						"Изменение процента от прибыли с продаж товаров сотрудника ",
						prm[0],
						" (",
						prm[1],
						" ",
						prm[2],
						" ",
						prm[3],
						") с ",
						prm[4],
						" на ",
						prm[5],
						"%"
					});
					num = (num2 * 3836555529U ^ 573839958U);
					continue;
				case 157U:
					goto IL_20C;
				case 158U:
					logs.notes = string.Concat(new string[]
					{
						"Изменено имя сотрудника ",
						prm[0],
						" (",
						prm[1],
						" ",
						prm[2],
						" ",
						prm[3],
						") с ",
						prm[4],
						" на ",
						prm[5]
					});
					num = (num2 * 3217696175U ^ 373555345U);
					continue;
				case 159U:
					goto IL_166;
				case 160U:
					goto IL_150;
				case 161U:
					num = (num2 * 2633006033U ^ 1981853475U);
					continue;
				case 162U:
					goto IL_113;
				}
				break;
			}
			return logs;
			IL_1683:
			num = 3210245839U;
			goto IL_1AAD;
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x0002931C File Offset: 0x0002751C
		public void Save()
		{
			if (this.Actions != null && this.Actions.Count > 0)
			{
				try
				{
					using (auseceEntities auseceEntities = new auseceEntities(true))
					{
						foreach (logs entity in this.Actions)
						{
							auseceEntities.logs.Add(entity);
						}
						auseceEntities.SaveChanges();
					}
				}
				catch (Exception exception)
				{
					HistoryV2.Log.Error(exception, "Save logs to DB fail");
					return;
				}
				this.ClearActions();
				return;
			}
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x000293E0 File Offset: 0x000275E0
		private void ClearActions()
		{
			this.Actions.Clear();
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x000293F8 File Offset: 0x000275F8
		public Task SaveAsync()
		{
			HistoryV2.<SaveAsync>d__36 <SaveAsync>d__;
			<SaveAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SaveAsync>d__.<>4__this = this;
			<SaveAsync>d__.<>1__state = -1;
			<SaveAsync>d__.<>t__builder.Start<HistoryV2.<SaveAsync>d__36>(ref <SaveAsync>d__);
			return <SaveAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x000293E0 File Offset: 0x000275E0
		public void Dispose()
		{
			this.Actions.Clear();
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x0002943C File Offset: 0x0002763C
		// Note: this type is marked as 'beforefieldinit'.
		static HistoryV2()
		{
		}

		// Token: 0x040008F7 RID: 2295
		public static readonly ILogger Log = LogManager.GetCurrentClassLogger();

		// Token: 0x040008F8 RID: 2296
		[CompilerGenerated]
		private List<logs> <Actions>k__BackingField;

		// Token: 0x020000AB RID: 171
		public enum Type
		{
			// Token: 0x040008FA RID: 2298
			Acp = 1,
			// Token: 0x040008FB RID: 2299
			Clients,
			// Token: 0x040008FC RID: 2300
			Repairs,
			// Token: 0x040008FD RID: 2301
			Users,
			// Token: 0x040008FE RID: 2302
			Documents,
			// Token: 0x040008FF RID: 2303
			StoreItems,
			// Token: 0x04000900 RID: 2304
			Kassa,
			// Token: 0x04000901 RID: 2305
			PartsRequest
		}

		// Token: 0x020000AC RID: 172
		public enum ActionCode
		{
			// Token: 0x04000903 RID: 2307
			OfficeEdited = 15,
			// Token: 0x04000904 RID: 2308
			OfficeCreated,
			// Token: 0x04000905 RID: 2309
			OfficeNameChanged
		}

		// Token: 0x020000AD RID: 173
		[CompilerGenerated]
		private sealed class <>c__DisplayClass24_0
		{
			// Token: 0x060012F8 RID: 4856 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass24_0()
			{
			}

			// Token: 0x060012F9 RID: 4857 RVA: 0x00029454 File Offset: 0x00027654
			internal bool <AddRepairLog>b__0(KeyValuePair<int, string> o)
			{
				return o.Key == this.informOption;
			}

			// Token: 0x04000906 RID: 2310
			public int informOption;
		}

		// Token: 0x020000AE RID: 174
		[CompilerGenerated]
		private sealed class <>c__DisplayClass29_0
		{
			// Token: 0x060012FA RID: 4858 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass29_0()
			{
			}

			// Token: 0x060012FB RID: 4859 RVA: 0x00029470 File Offset: 0x00027670
			internal bool <AddRepairLog>b__0(PaymentOptions i)
			{
				return i.Id == this.paymentSystem;
			}

			// Token: 0x04000907 RID: 2311
			public int paymentSystem;
		}

		// Token: 0x020000AF RID: 175
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SaveAsync>d__36 : IAsyncStateMachine
		{
			// Token: 0x060012FC RID: 4860 RVA: 0x0002948C File Offset: 0x0002768C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				HistoryV2 historyV = this.<>4__this;
				try
				{
					if (num == 0 || (historyV.Actions != null && historyV.Actions.Count > 0))
					{
						try
						{
							if (num != 0)
							{
								this.<ctx>5__2 = new auseceEntities(true);
							}
							try
							{
								ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter awaiter;
								if (num != 0)
								{
									List<logs>.Enumerator enumerator = historyV.Actions.GetEnumerator();
									try
									{
										while (enumerator.MoveNext())
										{
											logs entity = enumerator.Current;
											this.<ctx>5__2.logs.Add(entity);
										}
									}
									finally
									{
										if (num < 0)
										{
											((IDisposable)enumerator).Dispose();
										}
									}
									awaiter = this.<ctx>5__2.SaveChangesAsync().ConfigureAwait(false).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										int num2 = 0;
										num = 0;
										this.<>1__state = num2;
										this.<>u__1 = awaiter;
										this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter, HistoryV2.<SaveAsync>d__36>(ref awaiter, ref this);
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
							HistoryV2.Log.Error(exception, "Save logs to DB fail");
							goto IL_150;
						}
						historyV.ClearActions();
					}
				}
				catch (Exception exception2)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception2);
					return;
				}
				IL_150:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060012FD RID: 4861 RVA: 0x00029660 File Offset: 0x00027860
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000908 RID: 2312
			public int <>1__state;

			// Token: 0x04000909 RID: 2313
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400090A RID: 2314
			public HistoryV2 <>4__this;

			// Token: 0x0400090B RID: 2315
			private auseceEntities <ctx>5__2;

			// Token: 0x0400090C RID: 2316
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
