using System;
using System.Collections.ObjectModel;

namespace ASC.Extensions
{
	// Token: 0x02000B7A RID: 2938
	public static class ObservableCollectionEx
	{
		// Token: 0x06005209 RID: 21001 RVA: 0x00160800 File Offset: 0x0015EA00
		public static void MoveItemUp<T>(this ObservableCollection<T> baseCollection, int selectedIndex)
		{
			if (selectedIndex > 0)
			{
				goto IL_28;
			}
			IL_04:
			int num = -432147482;
			IL_09:
			switch ((num ^ -951158657) % 4)
			{
			case 0:
				goto IL_04;
			case 1:
				return;
			case 2:
				IL_28:
				baseCollection.Move(selectedIndex - 1, selectedIndex);
				num = -369616388;
				goto IL_09;
			}
		}

		// Token: 0x0600520A RID: 21002 RVA: 0x00160848 File Offset: 0x0015EA48
		public static void MoveItemDown<T>(this ObservableCollection<T> baseCollection, int selectedIndex)
		{
			if (selectedIndex >= 0 && selectedIndex + 1 < baseCollection.Count)
			{
				baseCollection.Move(selectedIndex + 1, selectedIndex);
				return;
			}
		}

		// Token: 0x0600520B RID: 21003 RVA: 0x00160870 File Offset: 0x0015EA70
		public static void MoveItemDown<T>(this ObservableCollection<T> baseCollection, T selectedItem)
		{
			baseCollection.MoveItemDown(baseCollection.IndexOf(selectedItem));
		}

		// Token: 0x0600520C RID: 21004 RVA: 0x0016088C File Offset: 0x0015EA8C
		public static void MoveItemUp<T>(this ObservableCollection<T> baseCollection, T selectedItem)
		{
			baseCollection.MoveItemUp(baseCollection.IndexOf(selectedItem));
		}
	}
}
