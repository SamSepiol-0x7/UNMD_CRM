using System;
using System.Globalization;
using System.Windows.Data;
using ASC.Objects;

namespace ASC.Converters
{
	// Token: 0x02000BE3 RID: 3043
	public class AclBooleanConverter : IValueConverter
	{
		// Token: 0x060054B5 RID: 21685 RVA: 0x0016C308 File Offset: 0x0016A508
		public object Convert(object value, Type targetType, object param, CultureInfo culture)
		{
			if (param == null || value == null)
			{
				return false;
			}
			Employee employee = value as Employee;
			if (employee != null)
			{
				string text = param.ToString().ToUpper();
				uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
				if (num <= 1920042317U)
				{
					if (num <= 762037573U)
					{
						if (num <= 518203164U)
						{
							if (num <= 266931302U)
							{
								if (num == 240488132U)
								{
									if (text == "CAN_CLIENT_INFORM_CHANGE")
									{
										return employee.Can(55, 0);
									}
								}
								else if (num == 266931302U)
								{
									if (text == "CAN_SEND_SMS")
									{
										return employee.Can(63, 0);
									}
								}
							}
							else if (num != 375316025U)
							{
								if (num == 476696448U)
								{
									if (text == "CAN_MANUAL_VIDEO_RECORD")
									{
										return employee.Can(62, 0);
									}
								}
								else if (num == 518203164U)
								{
									if (text == "CAN_TAKE_GOODS")
									{
										return employee.Can(44, 0);
									}
								}
							}
							else if (text == "CAN_VIEW_ALL_REPAIR_CARDS")
							{
								return employee.Can(23, 0);
							}
						}
						else if (num <= 694636336U)
						{
							if (num != 676334339U)
							{
								if (num == 694636336U && text == "CAN_GIVE_GOODS2USERS")
								{
									return employee.Can(45, 0);
								}
							}
							else if (text == "CAN_VIEW_OPT_PRICE")
							{
								return Auth.Config.it_vis_opt && employee.Can(43, 0);
							}
						}
						else if (num == 736676859U)
						{
							if (text == "CAN_STORE_MANAGEMENT")
							{
								return employee.Can(46, 0);
							}
						}
						else if (num != 755468478U)
						{
							if (num == 762037573U)
							{
								if (text == "CAN_INVOICE")
								{
									return employee.Can(65, 0);
								}
							}
						}
						else if (text == "CAN_OUT_REPAIR")
						{
							return employee.Can(4, 0);
						}
					}
					else if (num <= 1311220926U)
					{
						if (num <= 1020279312U)
						{
							if (num != 824007754U)
							{
								if (num == 1020279312U && text == "CAN_CREATE_PKO_RKO")
								{
									return employee.Can(16, 0);
								}
							}
							else if (text == "VIEW_ALL_EMPLOYEES_WORK")
							{
								return employee.Can(77, 0);
							}
						}
						else if (num != 1037553445U)
						{
							if (num == 1246345745U)
							{
								if (text == "CAN_EDIT_CLIENTS")
								{
									return employee.Can(11, 0);
								}
							}
							else if (num == 1311220926U && text == "CAN_VIEW_DOCUMENTS")
							{
								return employee.Can(15, 0);
							}
						}
						else if (text == "CAN_VIEW_ROZN_PRICE")
						{
							return Auth.Config.it_vis_rozn && employee.Can(42, 0);
						}
					}
					else if (num <= 1613323187U)
					{
						if (num == 1362679817U)
						{
							if (text == "CAN_QUICK_SALE")
							{
								return employee.Can(5, 0);
							}
						}
						else if (num == 1455090233U)
						{
							if (text == "CAN_EDIT_ITEMS")
							{
								return employee.Can(21, 0);
							}
						}
						else if (num == 1613323187U && text == "CAN_EDIT_ITEMS_PRICE")
						{
							return employee.Can(10, 0);
						}
					}
					else if (num != 1622517420U)
					{
						if (num == 1831434926U)
						{
							if (text == "CAN_SET_REPAIR_COLOR")
							{
								return employee.Can(61, 0);
							}
						}
						else if (num == 1920042317U && text == "CAN_PAY_ADVANCE")
						{
							return employee.Can(48, 0);
						}
					}
					else if (text == "CAN_ITEMS_ARRIVAL")
					{
						return employee.Can(6, 0);
					}
				}
				else if (num > 3142798948U)
				{
					if (num > 3468812737U)
					{
						if (num <= 3680700897U)
						{
							if (num != 3538946573U)
							{
								if (num != 3639926107U)
								{
									if (num == 3680700897U)
									{
										if (text == "CAN_EDIT_ITEMS_CATALOG")
										{
											return employee.Can(39, 0);
										}
									}
								}
								else if (text == "CAN_EXPORT_ITEMS")
								{
									return employee.Can(40, 0);
								}
							}
							else if (text == "CAN_ADMIN")
							{
								return employee.Can(1, 0);
							}
						}
						else if (num != 3772403276U)
						{
							if (num == 4113581771U)
							{
								if (text == "CAN_REPAIR_ADMIN")
								{
									return employee.Can(25, 0);
								}
							}
							else if (num == 4170367398U)
							{
								if (text == "CAN_VIEW_FINANCE_IN_WORKSPACE")
								{
									return employee.Can(16, 0) || employee.Can(65, 0);
								}
							}
						}
						else if (text == "CAN_VIEW_SC_PRICE")
						{
							return Auth.Config.it_vis_price_for_sc && employee.Can(41, 0);
						}
					}
					else if (num <= 3176661770U)
					{
						if (num != 3146365456U)
						{
							if (num == 3176661770U)
							{
								if (text == "CAN_PRINT_STICKERS")
								{
									return employee.Can(3, 0);
								}
							}
						}
						else if (text == "CAN_REMOVE_PARTS_FROM_REPAIR")
						{
							return employee.Can(47, 0);
						}
					}
					else if (num != 3298228292U)
					{
						if (num != 3437128805U)
						{
							if (num == 3468812737U)
							{
								if (text == "CAN_CANCELL_RN")
								{
									return employee.Can(51, 0);
								}
							}
						}
						else if (text == "CAN_SET_REPAIR_MASTER")
						{
							return employee.Can(60, 0);
						}
					}
					else if (text == "CAN_VIEW_CLIENTS")
					{
						return employee.Can(7, 0);
					}
				}
				else if (num > 2250837565U)
				{
					if (num > 2896358606U)
					{
						if (num == 3018493700U)
						{
							if (text == "CAN_BACKDATE_DOC")
							{
								return employee.Can(71, 0);
							}
						}
						else if (num == 3124579348U)
						{
							if (text == "CAN_ITEMS_CANCELLATION")
							{
								return employee.Can(9, 0);
							}
						}
						else if (num == 3142798948U && text == "CAN_CREATE_NEW_CLIENTS")
						{
							return employee.Can(8, 0);
						}
					}
					else if (num != 2775588225U)
					{
						if (num == 2896358606U)
						{
							if (text == "MASTER_CAN_TAKE_FREE_REPAIRS")
							{
								return employee.Can(57, 0);
							}
						}
					}
					else if (text == "CAN_EDIT_WORKS_PRICE")
					{
						return employee.Can(38, 0);
					}
				}
				else if (num <= 2105321830U)
				{
					if (num != 2064160848U)
					{
						if (num == 2105321830U)
						{
							if (text == "CAN_CREATE_REPORTS")
							{
								return employee.Can(12, 0);
							}
						}
					}
					else if (text == "CAN_USE_VOIP")
					{
						return OfflineData.Instance.Settings.Voip != null && employee.Can(24, 0);
					}
				}
				else if (num == 2123469916U)
				{
					if (text == "CAN_DEBT_OUT")
					{
						return employee.Can(64, 0);
					}
				}
				else if (num != 2205821027U)
				{
					if (num == 2250837565U)
					{
						if (text == "CAN_VIEW_KASSA")
						{
							return employee.Can(20, 0);
						}
					}
				}
				else if (text == "CAN_ACCEPT_NEW")
				{
					return employee.Can(2, 0);
				}
				return false;
			}
			return false;
		}

		// Token: 0x060054B6 RID: 21686 RVA: 0x0007E558 File Offset: 0x0007C758
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060054B7 RID: 21687 RVA: 0x000046B4 File Offset: 0x000028B4
		public AclBooleanConverter()
		{
		}
	}
}
