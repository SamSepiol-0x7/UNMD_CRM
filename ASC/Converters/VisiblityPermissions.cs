using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using ASC.Objects;

namespace ASC.Converters
{
	// Token: 0x02000BF3 RID: 3059
	public class VisiblityPermissions : IValueConverter
	{
		// Token: 0x060054E4 RID: 21732 RVA: 0x0016D0DC File Offset: 0x0016B2DC
		public object Convert(object value, Type targetType, object param, CultureInfo culture)
		{
			if (param != null && OfflineData.Instance.Employee != null)
			{
				string text = param.ToString();
				uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
				if (num > 1920042317U)
				{
					if (num > 3176661770U)
					{
						if (num > 3639926107U)
						{
							if (num > 4005299187U)
							{
								if (num != 4113581771U)
								{
									if (num != 4170367398U)
									{
										if (num == 4239040974U)
										{
											if (text == "CAN_ACCEPT_NEW_AND_OUT_REPAIR")
											{
												return (!OfflineData.Instance.Employee.Can(2, 0) || !OfflineData.Instance.Employee.Can(4, 0)) ? Visibility.Collapsed : Visibility.Visible;
											}
										}
									}
									else if (text == "CAN_VIEW_FINANCE_IN_WORKSPACE")
									{
										return (OfflineData.Instance.Employee.Can(16, 0) || OfflineData.Instance.Employee.Can(65, 0)) ? Visibility.Visible : Visibility.Collapsed;
									}
								}
								else if (text == "CAN_REPAIR_ADMIN")
								{
									return OfflineData.Instance.Employee.Can(25, 0) ? Visibility.Visible : Visibility.Collapsed;
								}
							}
							else if (num == 3680700897U)
							{
								if (text == "CAN_EDIT_ITEMS_CATALOG")
								{
									return OfflineData.Instance.Employee.Can(39, 0) ? Visibility.Visible : Visibility.Collapsed;
								}
							}
							else if (num != 3772403276U)
							{
								if (num == 4005299187U)
								{
									if (text == "CAN_CANCELL_PN")
									{
										return OfflineData.Instance.Employee.Can(56, 0) ? Visibility.Visible : Visibility.Collapsed;
									}
								}
							}
							else if (text == "CAN_VIEW_SC_PRICE")
							{
								return (Auth.Config.it_vis_price_for_sc && OfflineData.Instance.Employee.Can(41, 0)) ? Visibility.Visible : Visibility.Collapsed;
							}
						}
						else if (num <= 3437128805U)
						{
							if (num != 3298228292U)
							{
								if (num == 3437128805U)
								{
									if (text == "CAN_SET_REPAIR_MASTER")
									{
										return OfflineData.Instance.Employee.Can(60, 0) ? Visibility.Visible : Visibility.Collapsed;
									}
								}
							}
							else if (text == "CAN_VIEW_CLIENTS")
							{
								return OfflineData.Instance.Employee.Can(7, 0) ? Visibility.Visible : Visibility.Collapsed;
							}
						}
						else if (num != 3468812737U)
						{
							if (num == 3538946573U)
							{
								if (text == "CAN_ADMIN")
								{
									return OfflineData.Instance.Employee.Can(1, 0) ? Visibility.Visible : Visibility.Collapsed;
								}
							}
							else if (num == 3639926107U && text == "CAN_EXPORT_ITEMS")
							{
								return !OfflineData.Instance.Employee.Can(40, 0);
							}
						}
						else if (text == "CAN_CANCELL_RN")
						{
							return OfflineData.Instance.Employee.Can(51, 0) ? Visibility.Visible : Visibility.Collapsed;
						}
					}
					else if (num <= 2250837565U)
					{
						if (num <= 2105321830U)
						{
							if (num != 2064160848U)
							{
								if (num == 2105321830U && text == "CAN_CREATE_REPORTS")
								{
									return OfflineData.Instance.Employee.Can(12, 0) ? Visibility.Visible : Visibility.Collapsed;
								}
							}
							else if (text == "CAN_USE_VOIP")
							{
								return (OfflineData.Instance.Settings.Voip == null || !OfflineData.Instance.Employee.Can(24, 0)) ? Visibility.Collapsed : Visibility.Visible;
							}
						}
						else if (num != 2123469916U)
						{
							if (num == 2205821027U)
							{
								if (text == "CAN_ACCEPT_NEW")
								{
									return OfflineData.Instance.Employee.Can(2, 0) ? Visibility.Visible : Visibility.Collapsed;
								}
							}
							else if (num == 2250837565U)
							{
								if (text == "CAN_VIEW_KASSA")
								{
									return OfflineData.Instance.Employee.Can(20, 0) ? Visibility.Visible : Visibility.Collapsed;
								}
							}
						}
						else if (text == "CAN_DEBT_OUT")
						{
							return OfflineData.Instance.Employee.Can(64, 0) ? Visibility.Visible : Visibility.Collapsed;
						}
					}
					else if (num <= 3124579348U)
					{
						if (num == 2775588225U)
						{
							if (text == "CAN_EDIT_WORKS_PRICE")
							{
								return OfflineData.Instance.Employee.Can(38, 0) ? Visibility.Visible : Visibility.Collapsed;
							}
						}
						else if (num == 3124579348U)
						{
							if (text == "CAN_ITEMS_CANCELLATION")
							{
								return OfflineData.Instance.Employee.Can(9, 0) ? Visibility.Visible : Visibility.Collapsed;
							}
						}
					}
					else if (num != 3142798948U)
					{
						if (num != 3146365456U)
						{
							if (num == 3176661770U && text == "CAN_PRINT_STICKERS")
							{
								return OfflineData.Instance.Employee.Can(3, 0) ? Visibility.Visible : Visibility.Collapsed;
							}
						}
						else if (text == "CAN_REMOVE_PARTS_FROM_REPAIR")
						{
							return OfflineData.Instance.Employee.Can(47, 0) ? Visibility.Visible : Visibility.Collapsed;
						}
					}
					else if (text == "CAN_CREATE_NEW_CLIENTS")
					{
						return OfflineData.Instance.Employee.Can(8, 0) ? Visibility.Visible : Visibility.Collapsed;
					}
				}
				else if (num > 762037573U)
				{
					if (num > 1311220926U)
					{
						if (num <= 1613323187U)
						{
							if (num == 1362679817U)
							{
								if (text == "CAN_QUICK_SALE")
								{
									return OfflineData.Instance.Employee.Can(5, 0) ? Visibility.Visible : Visibility.Collapsed;
								}
							}
							else if (num == 1455090233U)
							{
								if (text == "CAN_EDIT_ITEMS")
								{
									return OfflineData.Instance.Employee.Can(21, 0) ? Visibility.Visible : Visibility.Collapsed;
								}
							}
							else if (num == 1613323187U && text == "CAN_EDIT_ITEMS_PRICE")
							{
								return !OfflineData.Instance.Employee.Can(10, 0);
							}
						}
						else if (num != 1622517420U)
						{
							if (num != 1831434926U)
							{
								if (num == 1920042317U)
								{
									if (text == "CAN_PAY_ADVANCE")
									{
										return OfflineData.Instance.Employee.Can(48, 0) ? Visibility.Visible : Visibility.Collapsed;
									}
								}
							}
							else if (text == "CAN_SET_REPAIR_COLOR")
							{
								return OfflineData.Instance.Employee.Can(61, 0) ? Visibility.Visible : Visibility.Collapsed;
							}
						}
						else if (text == "CAN_ITEMS_ARRIVAL")
						{
							return OfflineData.Instance.Employee.Can(6, 0) ? Visibility.Visible : Visibility.Collapsed;
						}
					}
					else if (num <= 1037553445U)
					{
						if (num != 1020279312U)
						{
							if (num == 1037553445U)
							{
								if (text == "CAN_VIEW_ROZN_PRICE")
								{
									return (!Auth.Config.it_vis_rozn || !OfflineData.Instance.Employee.Can(42, 0)) ? Visibility.Collapsed : Visibility.Visible;
								}
							}
						}
						else if (text == "CAN_CREATE_PKO_RKO")
						{
							return OfflineData.Instance.Employee.Can(16, 0) ? Visibility.Visible : Visibility.Collapsed;
						}
					}
					else if (num != 1166504623U)
					{
						if (num != 1246345745U)
						{
							if (num == 1311220926U && text == "CAN_VIEW_DOCUMENTS")
							{
								return OfflineData.Instance.Employee.Can(15, 0) ? Visibility.Visible : Visibility.Collapsed;
							}
						}
						else if (text == "CAN_EDIT_CLIENTS")
						{
							return OfflineData.Instance.Employee.Can(11, 0) ? Visibility.Visible : Visibility.Collapsed;
						}
					}
					else if (text == "CAN_USE_REQUEST_MANAGER")
					{
						return OfflineData.Instance.Employee.Can(70, 0) ? Visibility.Visible : Visibility.Collapsed;
					}
				}
				else if (num > 518203164U)
				{
					if (num <= 694636336U)
					{
						if (num == 676334339U)
						{
							if (text == "CAN_VIEW_OPT_PRICE")
							{
								return (!Auth.Config.it_vis_opt || !OfflineData.Instance.Employee.Can(43, 0)) ? Visibility.Collapsed : Visibility.Visible;
							}
						}
						else if (num == 694636336U && text == "CAN_GIVE_GOODS2USERS")
						{
							return OfflineData.Instance.Employee.Can(45, 0) ? Visibility.Visible : Visibility.Collapsed;
						}
					}
					else if (num != 736676859U)
					{
						if (num == 755468478U)
						{
							if (text == "CAN_OUT_REPAIR")
							{
								return OfflineData.Instance.Employee.Can(4, 0) ? Visibility.Visible : Visibility.Collapsed;
							}
						}
						else if (num == 762037573U)
						{
							if (text == "CAN_INVOICE")
							{
								return OfflineData.Instance.Employee.Can(65, 0) ? Visibility.Visible : Visibility.Collapsed;
							}
						}
					}
					else if (text == "CAN_STORE_MANAGEMENT")
					{
						return OfflineData.Instance.Employee.Can(46, 0) ? Visibility.Visible : Visibility.Collapsed;
					}
				}
				else if (num <= 240488132U)
				{
					if (num == 51073204U)
					{
						if (text == "CAN_READ_SMS")
						{
							return OfflineData.Instance.Employee.Can(22, 0) ? Visibility.Visible : Visibility.Collapsed;
						}
					}
					else if (num == 240488132U && text == "CAN_CLIENT_INFORM_CHANGE")
					{
						return OfflineData.Instance.Employee.Can(55, 0) ? Visibility.Visible : Visibility.Collapsed;
					}
				}
				else if (num == 266931302U)
				{
					if (text == "CAN_SEND_SMS")
					{
						return OfflineData.Instance.Employee.Can(63, 0) ? Visibility.Visible : Visibility.Collapsed;
					}
				}
				else if (num != 476696448U)
				{
					if (num == 518203164U && text == "CAN_TAKE_GOODS")
					{
						return OfflineData.Instance.Employee.Can(44, 0) ? Visibility.Visible : Visibility.Collapsed;
					}
				}
				else if (text == "CAN_MANUAL_VIDEO_RECORD")
				{
					return OfflineData.Instance.Employee.Can(62, 0) ? Visibility.Visible : Visibility.Collapsed;
				}
				return Visibility.Collapsed;
			}
			return Visibility.Collapsed;
		}

		// Token: 0x060054E5 RID: 21733 RVA: 0x0007E558 File Offset: 0x0007C758
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060054E6 RID: 21734 RVA: 0x000046B4 File Offset: 0x000028B4
		public VisiblityPermissions()
		{
		}
	}
}
