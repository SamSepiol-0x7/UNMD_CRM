using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DrvFRLib
{
	// Token: 0x02000C16 RID: 3094
	[CompilerGenerated]
	[Guid("A9BFA98D-04ED-4B1E-A874-4C6C3A91930E")]
	[TypeIdentifier]
	[ComImport]
	public interface IDrvFR48 : IDrvFR47
	{
		// Token: 0x06005534 RID: 21812
		void _VtblGap1_11();

		// Token: 0x06005535 RID: 21813
		[DispId(13)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int Connect();

		// Token: 0x06005536 RID: 21814
		void _VtblGap2_5();

		// Token: 0x06005537 RID: 21815
		[DispId(19)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int Disconnect();

		// Token: 0x06005538 RID: 21816
		void _VtblGap3_46();

		// Token: 0x06005539 RID: 21817
		[DispId(66)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int PrintReportWithCleaning();

		// Token: 0x0600553A RID: 21818
		[DispId(67)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int PrintReportWithoutCleaning();

		// Token: 0x0600553B RID: 21819
		[DispId(68)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int PrintString();

		// Token: 0x0600553C RID: 21820
		void _VtblGap4_26();

		// Token: 0x0600553D RID: 21821
		[DispId(95)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int ShowProperties();

		// Token: 0x0600553E RID: 21822
		void _VtblGap5_20();

		// Token: 0x170015B6 RID: 5558
		// (get) Token: 0x0600553F RID: 21823
		// (set) Token: 0x06005540 RID: 21824
		[DispId(113)]
		int CheckType { [DispId(113)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(113)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06005541 RID: 21825
		void _VtblGap6_14();

		// Token: 0x170015B7 RID: 5559
		// (get) Token: 0x06005542 RID: 21826
		// (set) Token: 0x06005543 RID: 21827
		[DispId(123)]
		int Department { [DispId(123)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(123)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06005544 RID: 21828
		void _VtblGap7_3();

		// Token: 0x170015B8 RID: 5560
		// (get) Token: 0x06005545 RID: 21829
		// (set) Token: 0x06005546 RID: 21830
		[DispId(126)]
		double DiscountOnCheck { [DispId(126)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(126)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06005547 RID: 21831
		void _VtblGap8_2();

		// Token: 0x170015B9 RID: 5561
		// (get) Token: 0x06005548 RID: 21832
		// (set) Token: 0x06005549 RID: 21833
		[DispId(128)]
		int DocumentNumber { [DispId(128)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(128)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x0600554A RID: 21834
		void _VtblGap9_74();

		// Token: 0x170015BA RID: 5562
		// (get) Token: 0x0600554B RID: 21835
		// (set) Token: 0x0600554C RID: 21836
		[DispId(188)]
		int Password { [DispId(188)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(188)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x0600554D RID: 21837
		void _VtblGap10_5();

		// Token: 0x170015BB RID: 5563
		// (get) Token: 0x0600554E RID: 21838
		// (set) Token: 0x0600554F RID: 21839
		[DispId(192)]
		decimal Price { [DispId(192)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Currency)] get; [DispId(192)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Currency)] [param: In] set; }

		// Token: 0x170015BC RID: 5564
		// (get) Token: 0x06005550 RID: 21840
		// (set) Token: 0x06005551 RID: 21841
		[DispId(193)]
		double Quantity { [DispId(193)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(193)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06005552 RID: 21842
		void _VtblGap11_10();

		// Token: 0x170015BD RID: 5565
		// (get) Token: 0x06005553 RID: 21843
		[DispId(201)]
		int ResultCode { [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170015BE RID: 5566
		// (get) Token: 0x06005554 RID: 21844
		[DispId(202)]
		string ResultCodeDescription { [DispId(202)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x06005555 RID: 21845
		void _VtblGap12_9();

		// Token: 0x170015BF RID: 5567
		// (get) Token: 0x06005556 RID: 21846
		// (set) Token: 0x06005557 RID: 21847
		[DispId(208)]
		string SerialNumber { [DispId(208)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(208)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06005558 RID: 21848
		void _VtblGap13_9();

		// Token: 0x170015C0 RID: 5568
		// (get) Token: 0x06005559 RID: 21849
		// (set) Token: 0x0600555A RID: 21850
		[DispId(216)]
		string StringForPrinting { [DispId(216)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(216)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x0600555B RID: 21851
		void _VtblGap14_2();

		// Token: 0x170015C1 RID: 5569
		// (get) Token: 0x0600555C RID: 21852
		// (set) Token: 0x0600555D RID: 21853
		[DispId(218)]
		decimal Summ1 { [DispId(218)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Currency)] get; [DispId(218)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Currency)] [param: In] set; }

		// Token: 0x170015C2 RID: 5570
		// (get) Token: 0x0600555E RID: 21854
		// (set) Token: 0x0600555F RID: 21855
		[DispId(219)]
		decimal Summ2 { [DispId(219)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Currency)] get; [DispId(219)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Currency)] [param: In] set; }

		// Token: 0x170015C3 RID: 5571
		// (get) Token: 0x06005560 RID: 21856
		// (set) Token: 0x06005561 RID: 21857
		[DispId(220)]
		decimal Summ3 { [DispId(220)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Currency)] get; [DispId(220)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Currency)] [param: In] set; }

		// Token: 0x170015C4 RID: 5572
		// (get) Token: 0x06005562 RID: 21858
		// (set) Token: 0x06005563 RID: 21859
		[DispId(221)]
		decimal Summ4 { [DispId(221)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Currency)] get; [DispId(221)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Currency)] [param: In] set; }

		// Token: 0x06005564 RID: 21860
		void _VtblGap15_3();

		// Token: 0x170015C5 RID: 5573
		// (get) Token: 0x06005565 RID: 21861
		// (set) Token: 0x06005566 RID: 21862
		[DispId(224)]
		int Tax1 { [DispId(224)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(224)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06005567 RID: 21863
		void _VtblGap16_749();

		// Token: 0x170015C6 RID: 5574
		// (get) Token: 0x06005568 RID: 21864
		// (set) Token: 0x06005569 RID: 21865
		[DispId(1906)]
		bool Connected { [DispId(1906)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(1906)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x0600556A RID: 21866
		void _VtblGap17_285();

		// Token: 0x170015C7 RID: 5575
		// (get) Token: 0x0600556B RID: 21867
		[DispId(2103)]
		int FNSessionState { [DispId(2103)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600556C RID: 21868
		void _VtblGap18_4();

		// Token: 0x0600556D RID: 21869
		[DispId(2107)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int FNGetStatus();

		// Token: 0x0600556E RID: 21870
		void _VtblGap19_10();

		// Token: 0x170015C8 RID: 5576
		// (get) Token: 0x0600556F RID: 21871
		// (set) Token: 0x06005570 RID: 21872
		[DispId(2116)]
		int TaxType { [DispId(2116)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2116)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06005571 RID: 21873
		void _VtblGap20_59();

		// Token: 0x06005572 RID: 21874
		[DispId(2160)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int FNCloseCheckEx();

		// Token: 0x06005573 RID: 21875
		void _VtblGap21_10();

		// Token: 0x06005574 RID: 21876
		[DispId(2166)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int FNSendCustomerEmail();

		// Token: 0x170015C9 RID: 5577
		// (get) Token: 0x06005575 RID: 21877
		// (set) Token: 0x06005576 RID: 21878
		[DispId(2167)]
		string CustomerEmail { [DispId(2167)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2167)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06005577 RID: 21879
		void _VtblGap22_29();

		// Token: 0x06005578 RID: 21880
		[DispId(2185)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int ReadSerialNumber();

		// Token: 0x06005579 RID: 21881
		void _VtblGap23_21();

		// Token: 0x0600557A RID: 21882
		[DispId(2201)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int FNOperation();

		// Token: 0x0600557B RID: 21883
		void _VtblGap24_31();

		// Token: 0x170015CA RID: 5578
		// (get) Token: 0x0600557C RID: 21884
		// (set) Token: 0x0600557D RID: 21885
		[DispId(2217)]
		int PaymentTypeSign { [DispId(2217)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2217)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170015CB RID: 5579
		// (get) Token: 0x0600557E RID: 21886
		// (set) Token: 0x0600557F RID: 21887
		[DispId(2218)]
		int PaymentItemSign { [DispId(2218)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2218)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
