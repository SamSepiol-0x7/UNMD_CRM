using System;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;
using NLog;

namespace ASC.Models
{
	// Token: 0x020009FE RID: 2558
	public class GenericModel
	{
		// Token: 0x06004BFE RID: 19454 RVA: 0x00137584 File Offset: 0x00135784
		public GenericModel()
		{
			this.OpenCnn();
		}

		// Token: 0x06004BFF RID: 19455 RVA: 0x001375A8 File Offset: 0x001357A8
		private void OpenCnn()
		{
			try
			{
				this._context = new auseceEntities(true);
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Create cnn fail ");
				this._try++;
				if (this._try < 3)
				{
					this.OpenCnn();
				}
			}
		}

		// Token: 0x06004C00 RID: 19456 RVA: 0x00137604 File Offset: 0x00135804
		public bool SaveContext(bool saveHistory = false)
		{
			bool result;
			try
			{
				this._context.SaveChanges();
				goto IL_3B;
			}
			catch (DbUpdateException ex)
			{
				if (ex.InnerException != null)
				{
					MessageBox.Show(ex.InnerException.Message);
				}
				goto IL_3B;
			}
			catch (Exception ex2)
			{
				MessageBox.Show(ex2.Message);
				result = false;
			}
			return result;
			IL_3B:
			if (saveHistory)
			{
				this._history.Save();
			}
			return true;
		}

		// Token: 0x06004C01 RID: 19457 RVA: 0x00137678 File Offset: 0x00135878
		// Note: this type is marked as 'beforefieldinit'.
		static GenericModel()
		{
		}

		// Token: 0x04003111 RID: 12561
		public static readonly ILogger Log = LogManager.GetCurrentClassLogger();

		// Token: 0x04003112 RID: 12562
		public auseceEntities _context;

		// Token: 0x04003113 RID: 12563
		private int _try;

		// Token: 0x04003114 RID: 12564
		public HistoryV2 _history = new HistoryV2();
	}
}
