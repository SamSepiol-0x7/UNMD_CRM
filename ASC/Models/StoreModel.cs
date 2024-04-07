using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using ASC.Common.Extensions;
using ASC.Common.Interfaces;
using ASC.Extensions;
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.Options;
using ASC.SimpleClasses;
using NLog;

namespace ASC.Models
{
	// Token: 0x02000A74 RID: 2676
	public class StoreModel : ItemsModel
	{
		// Token: 0x06004D7A RID: 19834 RVA: 0x00145930 File Offset: 0x00143B30
		public static Expression<Func<store_items, bool>> InStockS1(int itemOption)
		{
			if (itemOption == 2)
			{
				return (store_items i) => i.count - i.reserved - i.dealer_lock > 0;
			}
			if (itemOption == 3)
			{
				return (store_items i) => i.reserved > 0;
			}
			if (itemOption == 7)
			{
				return (store_items i) => i.count == 0;
			}
			if (itemOption == 8)
			{
				return (store_items i) => i.count - i.reserved - i.dealer_lock > 0 && i.not_for_sale == false;
			}
			if (itemOption == 9)
			{
				return (store_items i) => i.count - i.reserved - i.dealer_lock > 0 || i.reserved > 0;
			}
			return (store_items i) => i.id != 0;
		}

		// Token: 0x06004D7B RID: 19835 RVA: 0x00145C58 File Offset: 0x00143E58
		public static Task<List<StoreGroup>> LoadMasterItemsV2Async(int storeId, int category, int itemOption, int boxId, string query)
		{
			StoreModel.<LoadMasterItemsV2Async>d__3 <LoadMasterItemsV2Async>d__;
			<LoadMasterItemsV2Async>d__.<>t__builder = AsyncTaskMethodBuilder<List<StoreGroup>>.Create();
			<LoadMasterItemsV2Async>d__.storeId = storeId;
			<LoadMasterItemsV2Async>d__.category = category;
			<LoadMasterItemsV2Async>d__.itemOption = itemOption;
			<LoadMasterItemsV2Async>d__.boxId = boxId;
			<LoadMasterItemsV2Async>d__.query = query;
			<LoadMasterItemsV2Async>d__.<>1__state = -1;
			<LoadMasterItemsV2Async>d__.<>t__builder.Start<StoreModel.<LoadMasterItemsV2Async>d__3>(ref <LoadMasterItemsV2Async>d__);
			return <LoadMasterItemsV2Async>d__.<>t__builder.Task;
		}

		// Token: 0x06004D7C RID: 19836 RVA: 0x00145CBC File Offset: 0x00143EBC
		private static string GetStateName(List<items_state> itemStates, IGrouping<int, store_items> g)
		{
			string result;
			try
			{
				result = (from i in itemStates
				where i.id == (from c in g
				select c.state).FirstOrDefault<int>()
				select i.name).FirstOrDefault<string>();
			}
			catch (Exception)
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06004D7D RID: 19837 RVA: 0x00145D30 File Offset: 0x00143F30
		public static List<Product> LoadDetailItemsV2(List<int> detailIds)
		{
			List<Product> result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(false))
				{
					result = (from p in (from i in (from i in auseceEntities.store_items.AsNoTracking()
					where !i.Hidden
					select i).Include((store_items i) => i.items_state).Include((store_items i) => i.boxes).Include((store_items i) => i.field_values).Include((store_items i) => from a in i.field_values
					select a.fields)
					where detailIds.Contains(i.id)
					select i).ToList<store_items>()
					select p.ToStoreItem()).ToList<Product>();
				}
			}
			catch (Exception exception)
			{
				StoreModel.Log.Error(exception, "load detail items fail");
				result = new List<Product>();
			}
			return result;
		}

		// Token: 0x06004D7E RID: 19838 RVA: 0x00146000 File Offset: 0x00144200
		public static Task<IEnumerable<store_int_reserve>> LoadMyItems(int categoryId, string query, int state = 0)
		{
			Task<IEnumerable<store_int_reserve>> allAsync;
			using (GenericRepository<store_int_reserve> genericRepository = new GenericRepository<store_int_reserve>())
			{
				List<int> categories = new List<int>();
				if (categoryId != 0)
				{
					try
					{
						ObjectResult<int?> catChildrens = genericRepository.GetContext().getCatChildrens(new int?(categoryId));
						categories = (from i in catChildrens
						where i != null
						select i.Value).ToList<int>();
					}
					catch (Exception ex)
					{
						StoreModel.Log.Error(ex, ex.Message);
					}
				}
				genericRepository.AsNoTracking();
				List<KeyValuePair<bool, Expression<Func<store_int_reserve, bool>>>> filterList = new List<KeyValuePair<bool, Expression<Func<store_int_reserve, bool>>>>
				{
					new KeyValuePair<bool, Expression<Func<store_int_reserve, bool>>>(true, (store_int_reserve i) => i.to_user == OfflineData.Instance.Employee.Id && i.state < 3),
					new KeyValuePair<bool, Expression<Func<store_int_reserve, bool>>>(categoryId > 0, (store_int_reserve i) => categories.Contains(i.store_items.category)),
					new KeyValuePair<bool, Expression<Func<store_int_reserve, bool>>>(!string.IsNullOrEmpty(query), (store_int_reserve i) => i.store_items.name.Contains(query)),
					new KeyValuePair<bool, Expression<Func<store_int_reserve, bool>>>(state != 0, (store_int_reserve i) => i.state == state)
				};
				allAsync = genericRepository.GetAllAsync(filterList, null, "store_items", false);
			}
			return allAsync;
		}

		// Token: 0x06004D7F RID: 19839 RVA: 0x001463A0 File Offset: 0x001445A0
		public Task<store_cats> LoadCategory(int category)
		{
			StoreModel.<LoadCategory>d__7 <LoadCategory>d__;
			<LoadCategory>d__.<>t__builder = AsyncTaskMethodBuilder<store_cats>.Create();
			<LoadCategory>d__.category = category;
			<LoadCategory>d__.<>1__state = -1;
			<LoadCategory>d__.<>t__builder.Start<StoreModel.<LoadCategory>d__7>(ref <LoadCategory>d__);
			return <LoadCategory>d__.<>t__builder.Task;
		}

		// Token: 0x06004D80 RID: 19840 RVA: 0x001463E4 File Offset: 0x001445E4
		public static Expression<Func<store_items, bool>> ContainsQuery(string query)
		{
			string[] queryArr = query.Split(new char[]
			{
				' '
			});
			if (queryArr.Length > 1)
			{
				return (store_items i) => queryArr.All((string q) => i.name.Contains(q)) || queryArr.All((string q) => i.articul.ToString().Contains(q)) || queryArr.All((string q) => i.int_barcode.Contains(q)) || queryArr.All((string q) => i.description.Contains(q)) || queryArr.All((string q) => i.SN.Contains(q)) || queryArr.All((string q) => i.notes.Contains(q)) || queryArr.All((string q) => i.ext_barcode.Contains(q)) || queryArr.All((string q) => i.PN.Contains(q)) || queryArr.All((string q) => i.field_values.Any((field_values a) => a.value.Contains(q)));
			}
			return (store_items i) => i.name.Contains(query) || i.articul.ToString().Contains(query) || i.int_barcode.Contains(query) || i.description.Contains(query) || i.SN.Contains(query) || i.notes.Contains(query) || i.ext_barcode.Contains(query) || i.PN.Contains(query) || i.field_values.Any((field_values a) => a.value.Contains(query));
		}

		// Token: 0x06004D81 RID: 19841 RVA: 0x00146DD4 File Offset: 0x00144FD4
		public Task<List<store_cats>> LoadRootNodes(int storeId)
		{
			StoreModel.<LoadRootNodes>d__9 <LoadRootNodes>d__;
			<LoadRootNodes>d__.<>t__builder = AsyncTaskMethodBuilder<List<store_cats>>.Create();
			<LoadRootNodes>d__.<>4__this = this;
			<LoadRootNodes>d__.storeId = storeId;
			<LoadRootNodes>d__.<>1__state = -1;
			<LoadRootNodes>d__.<>t__builder.Start<StoreModel.<LoadRootNodes>d__9>(ref <LoadRootNodes>d__);
			return <LoadRootNodes>d__.<>t__builder.Task;
		}

		// Token: 0x06004D82 RID: 19842 RVA: 0x00146E20 File Offset: 0x00145020
		public static Task<List<StoreCategory>> GetCategories(int storeId, bool showArchive)
		{
			StoreModel.<GetCategories>d__10 <GetCategories>d__;
			<GetCategories>d__.<>t__builder = AsyncTaskMethodBuilder<List<StoreCategory>>.Create();
			<GetCategories>d__.storeId = storeId;
			<GetCategories>d__.showArchive = showArchive;
			<GetCategories>d__.<>1__state = -1;
			<GetCategories>d__.<>t__builder.Start<StoreModel.<GetCategories>d__10>(ref <GetCategories>d__);
			return <GetCategories>d__.<>t__builder.Task;
		}

		// Token: 0x06004D83 RID: 19843 RVA: 0x00146E6C File Offset: 0x0014506C
		public static List<StoreCategory> GetOnUserItemCategories()
		{
			List<StoreCategory> result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					result = (from c in (from i in auseceEntities.store_int_reserve.AsNoTracking()
					where i.to_user == OfflineData.Instance.Employee.Id && i.state < 3
					select i.store_items.store_cats).ToList<store_cats>()
					select c.ToStoreCategory() into c
					orderby c.Position
					select c).DistinctBy((StoreCategory i) => i.Id).ToList<StoreCategory>();
				}
			}
			catch (Exception ex)
			{
				StoreModel.Log.Error(ex, ex.Message);
				result = new List<StoreCategory>();
			}
			return result;
		}

		// Token: 0x06004D84 RID: 19844 RVA: 0x00147064 File Offset: 0x00145264
		public Task<List<store_cats>> LoadStoreCategories(int storeId, bool includeAll = false, bool rootNode = false)
		{
			StoreModel.<LoadStoreCategories>d__12 <LoadStoreCategories>d__;
			<LoadStoreCategories>d__.<>t__builder = AsyncTaskMethodBuilder<List<store_cats>>.Create();
			<LoadStoreCategories>d__.storeId = storeId;
			<LoadStoreCategories>d__.includeAll = includeAll;
			<LoadStoreCategories>d__.rootNode = rootNode;
			<LoadStoreCategories>d__.<>1__state = -1;
			<LoadStoreCategories>d__.<>t__builder.Start<StoreModel.<LoadStoreCategories>d__12>(ref <LoadStoreCategories>d__);
			return <LoadStoreCategories>d__.<>t__builder.Task;
		}

		// Token: 0x06004D85 RID: 19845 RVA: 0x001470B8 File Offset: 0x001452B8
		public static Task<List<stores>> LoadStores(bool includeSelect = false, bool includeAll = false)
		{
			StoreModel.<LoadStores>d__13 <LoadStores>d__;
			<LoadStores>d__.<>t__builder = AsyncTaskMethodBuilder<List<stores>>.Create();
			<LoadStores>d__.includeSelect = includeSelect;
			<LoadStores>d__.includeAll = includeAll;
			<LoadStores>d__.<>1__state = -1;
			<LoadStores>d__.<>t__builder.Start<StoreModel.<LoadStores>d__13>(ref <LoadStores>d__);
			return <LoadStores>d__.<>t__builder.Task;
		}

		// Token: 0x06004D86 RID: 19846 RVA: 0x00147104 File Offset: 0x00145304
		public stores LoadStore(int storeId)
		{
			stores result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					result = auseceEntities.stores.Find(new object[]
					{
						storeId
					});
				}
			}
			catch (Exception exception)
			{
				StoreModel.Log.Error(exception, "Load store by id fail");
				result = null;
			}
			return result;
		}

		// Token: 0x06004D87 RID: 19847 RVA: 0x00147174 File Offset: 0x00145374
		private void ItemStoreChangeLog(store_items original, store_items current)
		{
			StoreModel.<ItemStoreChangeLog>d__15 <ItemStoreChangeLog>d__;
			<ItemStoreChangeLog>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<ItemStoreChangeLog>d__.<>4__this = this;
			<ItemStoreChangeLog>d__.original = original;
			<ItemStoreChangeLog>d__.current = current;
			<ItemStoreChangeLog>d__.<>1__state = -1;
			<ItemStoreChangeLog>d__.<>t__builder.Start<StoreModel.<ItemStoreChangeLog>d__15>(ref <ItemStoreChangeLog>d__);
		}

		// Token: 0x06004D88 RID: 19848 RVA: 0x001471BC File Offset: 0x001453BC
		public List<store_types> LoadStoreTypes()
		{
			return new List<store_types>(new GenericRepository<store_types>().GetAll(null, null, ""));
		}

		// Token: 0x06004D89 RID: 19849 RVA: 0x001471E0 File Offset: 0x001453E0
		public List<store_sub_types> LoadStoreSubTypes()
		{
			return new List<store_sub_types>(new GenericRepository<store_sub_types>().GetAll((store_sub_types t) => t.enable.Value, null, ""));
		}

		// Token: 0x06004D8A RID: 19850 RVA: 0x00147254 File Offset: 0x00145454
		public static List<ItemsOptions> LoadItemsOptionses()
		{
			return new ItemsOptions().GetAllOptions();
		}

		// Token: 0x06004D8B RID: 19851 RVA: 0x0014726C File Offset: 0x0014546C
		public static Task<bool> AddCategory(ICategory c, int storeId)
		{
			StoreModel.<AddCategory>d__19 <AddCategory>d__;
			<AddCategory>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<AddCategory>d__.c = c;
			<AddCategory>d__.storeId = storeId;
			<AddCategory>d__.<>1__state = -1;
			<AddCategory>d__.<>t__builder.Start<StoreModel.<AddCategory>d__19>(ref <AddCategory>d__);
			return <AddCategory>d__.<>t__builder.Task;
		}

		// Token: 0x06004D8C RID: 19852 RVA: 0x001472B8 File Offset: 0x001454B8
		public static Task<bool> UpdateCategory(ICategory c)
		{
			StoreModel.<UpdateCategory>d__20 <UpdateCategory>d__;
			<UpdateCategory>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<UpdateCategory>d__.c = c;
			<UpdateCategory>d__.<>1__state = -1;
			<UpdateCategory>d__.<>t__builder.Start<StoreModel.<UpdateCategory>d__20>(ref <UpdateCategory>d__);
			return <UpdateCategory>d__.<>t__builder.Task;
		}

		// Token: 0x06004D8D RID: 19853 RVA: 0x001472FC File Offset: 0x001454FC
		public static bool AnyStoreExist()
		{
			bool result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					result = auseceEntities.stores.Any<stores>();
				}
			}
			catch (Exception exception)
			{
				StoreModel.Log.Error(exception, "Check is any store exist fail");
				result = false;
			}
			return result;
		}

		// Token: 0x06004D8E RID: 19854 RVA: 0x0014735C File Offset: 0x0014555C
		public List<store_cats> LoadChildrensCats(store_cats category)
		{
			List<store_cats> list = new List<store_cats>
			{
				category
			};
			try
			{
				foreach (store_cats category2 in category.store_cats1)
				{
					list.AddRange(this.LoadChildrensCats(category2));
				}
			}
			catch (Exception ex)
			{
				StoreModel.Log.Error(ex, ex.Message);
			}
			return list;
		}

		// Token: 0x06004D8F RID: 19855 RVA: 0x001473E0 File Offset: 0x001455E0
		public int CountItemsInCategories(List<int> ids)
		{
			int result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					result = (from i in auseceEntities.store_items
					where ids.Contains(i.category)
					select i.count).DefaultIfEmpty<int>().Sum();
				}
			}
			catch (Exception exception)
			{
				StoreModel.Log.Error(exception, "Count items in categories fail");
				result = 0;
			}
			return result;
		}

		// Token: 0x06004D90 RID: 19856 RVA: 0x00147510 File Offset: 0x00145710
		public List<int> LoadChildCategoriesId(int parentId)
		{
			List<int> result;
			using (auseceEntities auseceEntities = new auseceEntities(true))
			{
				try
				{
					result = (from c in auseceEntities.store_cats
					where c.parent == (int?)parentId
					orderby c.position
					select c.id).ToList<int>();
				}
				catch (Exception exception)
				{
					StoreModel.Log.Error(exception, "Load Child Categories Id fail");
					result = new List<int>();
				}
			}
			return result;
		}

		// Token: 0x06004D91 RID: 19857 RVA: 0x00147688 File Offset: 0x00145888
		public static Task<bool> SavePosition(IEnumerable<ICategory> c, int storeId)
		{
			StoreModel.<SavePosition>d__25 <SavePosition>d__;
			<SavePosition>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<SavePosition>d__.c = c;
			<SavePosition>d__.<>1__state = -1;
			<SavePosition>d__.<>t__builder.Start<StoreModel.<SavePosition>d__25>(ref <SavePosition>d__);
			return <SavePosition>d__.<>t__builder.Task;
		}

		// Token: 0x06004D92 RID: 19858 RVA: 0x001476CC File Offset: 0x001458CC
		public IEnumerable<store_cats> LoadStoreChildCategories(List<int> categoryIds)
		{
			IEnumerable<store_cats> result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					result = (from c in auseceEntities.store_cats
					where c.parent != null && categoryIds.Contains(c.parent.Value)
					select c).ToList<store_cats>();
				}
			}
			catch (Exception exception)
			{
				StoreModel.Log.Error(exception, "Load categories list error");
				result = new List<store_cats>();
			}
			return result;
		}

		// Token: 0x06004D93 RID: 19859 RVA: 0x00147814 File Offset: 0x00145A14
		public static Task<IEnumerable<store_items>> LoadItems(int articul)
		{
			StoreModel.<LoadItems>d__27 <LoadItems>d__;
			<LoadItems>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<store_items>>.Create();
			<LoadItems>d__.articul = articul;
			<LoadItems>d__.<>1__state = -1;
			<LoadItems>d__.<>t__builder.Start<StoreModel.<LoadItems>d__27>(ref <LoadItems>d__);
			return <LoadItems>d__.<>t__builder.Task;
		}

		// Token: 0x06004D94 RID: 19860 RVA: 0x00147858 File Offset: 0x00145A58
		public static Task<IEnumerable<Product>> GetItems(string query)
		{
			StoreModel.<GetItems>d__28 <GetItems>d__;
			<GetItems>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<Product>>.Create();
			<GetItems>d__.query = query;
			<GetItems>d__.<>1__state = -1;
			<GetItems>d__.<>t__builder.Start<StoreModel.<GetItems>d__28>(ref <GetItems>d__);
			return <GetItems>d__.<>t__builder.Task;
		}

		// Token: 0x06004D95 RID: 19861 RVA: 0x0014789C File Offset: 0x00145A9C
		public static Task<List<StoreIntReserveLite>> LoadItems(IPeriod period, int userId, int status, string query, int storeId = 0)
		{
			StoreModel.<LoadItems>d__29 <LoadItems>d__;
			<LoadItems>d__.<>t__builder = AsyncTaskMethodBuilder<List<StoreIntReserveLite>>.Create();
			<LoadItems>d__.period = period;
			<LoadItems>d__.userId = userId;
			<LoadItems>d__.status = status;
			<LoadItems>d__.query = query;
			<LoadItems>d__.storeId = storeId;
			<LoadItems>d__.<>1__state = -1;
			<LoadItems>d__.<>t__builder.Start<StoreModel.<LoadItems>d__29>(ref <LoadItems>d__);
			return <LoadItems>d__.<>t__builder.Task;
		}

		// Token: 0x06004D96 RID: 19862 RVA: 0x00147900 File Offset: 0x00145B00
		public List<RealizationItem> LoadDealerItemsV2(int dealerId, int selectedCategory, int itemsType, string query)
		{
			List<int> cats = new List<int>();
			if (selectedCategory != 0)
			{
				cats = this.LoadChildCategoriesId(selectedCategory);
				cats.Add(selectedCategory);
			}
			bool reserve = itemsType == 5;
			if (itemsType == 1 | reserve)
			{
				using (GenericRepository<store_items> genericRepository = new GenericRepository<store_items>())
				{
					genericRepository.AsNoTracking();
					List<KeyValuePair<bool, Expression<Func<store_items, bool>>>> filterList = new List<KeyValuePair<bool, Expression<Func<store_items, bool>>>>
					{
						new KeyValuePair<bool, Expression<Func<store_items, bool>>>(true, (store_items r) => r.dealer == dealerId && r.is_realization && r.count > 0),
						new KeyValuePair<bool, Expression<Func<store_items, bool>>>(!string.IsNullOrEmpty(query), (store_items r) => r.name.Contains(query)),
						new KeyValuePair<bool, Expression<Func<store_items, bool>>>(selectedCategory != 0, (store_items r) => cats.Contains(r.category)),
						new KeyValuePair<bool, Expression<Func<store_items, bool>>>(reserve, (store_items r) => r.reserved > 0)
					};
					return (from i in genericRepository.GetAll(filterList, delegate(IQueryable<store_items> i)
					{
						return from r in i
						orderby r.created
						select r;
					}, "")
					select i.ToRealizationItem(reserve)).ToList<RealizationItem>();
				}
			}
			List<RealizationItem> result;
			using (GenericRepository<store_sales> genericRepository2 = new GenericRepository<store_sales>())
			{
				genericRepository2.AsNoTracking();
				List<KeyValuePair<bool, Expression<Func<store_sales, bool>>>> filterList2 = new List<KeyValuePair<bool, Expression<Func<store_sales, bool>>>>
				{
					new KeyValuePair<bool, Expression<Func<store_sales, bool>>>(true, (store_sales r) => r.dealer == dealerId && r.is_realization),
					new KeyValuePair<bool, Expression<Func<store_sales, bool>>>(itemsType == 3, StoreModel.DealerItem(dealerId, DocStates.RnMaked, false)),
					new KeyValuePair<bool, Expression<Func<store_sales, bool>>>(itemsType == 4, StoreModel.DealerItem(dealerId, DocStates.RnMaked, true)),
					new KeyValuePair<bool, Expression<Func<store_sales, bool>>>(itemsType == 6, StoreModel.DealerItem(dealerId, DocStates.Cancellation))
				};
				result = (from i in genericRepository2.GetAll(filterList2, delegate(IQueryable<store_sales> i)
				{
					return from r in i
					orderby r.docs.created
					select r;
				}, "docs,store_items")
				select i.ToRealizationItem()).ToList<RealizationItem>();
			}
			return result;
		}

		// Token: 0x06004D97 RID: 19863 RVA: 0x00147D9C File Offset: 0x00145F9C
		private static Expression<Func<store_sales, bool>> DealerItem(int clientId, DocStates rnStatus)
		{
			return (store_sales i) => i.docs.state == (int?)((int)rnStatus) && i.dealer == clientId && i.is_realization;
		}

		// Token: 0x06004D98 RID: 19864 RVA: 0x00147EA4 File Offset: 0x001460A4
		private static Expression<Func<store_sales, bool>> DealerItem(int clientId, DocStates rnStatus, bool paid)
		{
			return (store_sales i) => i.docs.state == (int?)((int)rnStatus) && i.dealer == clientId && i.is_realization && i.realizator_payed == paid;
		}

		// Token: 0x06004D99 RID: 19865 RVA: 0x00147FF4 File Offset: 0x001461F4
		public static Task<List<boxes>> LoadBoxes(int storeId, bool includeAll = false)
		{
			StoreModel.<LoadBoxes>d__33 <LoadBoxes>d__;
			<LoadBoxes>d__.<>t__builder = AsyncTaskMethodBuilder<List<boxes>>.Create();
			<LoadBoxes>d__.storeId = storeId;
			<LoadBoxes>d__.includeAll = includeAll;
			<LoadBoxes>d__.<>1__state = -1;
			<LoadBoxes>d__.<>t__builder.Start<StoreModel.<LoadBoxes>d__33>(ref <LoadBoxes>d__);
			return <LoadBoxes>d__.<>t__builder.Task;
		}

		// Token: 0x06004D9A RID: 19866 RVA: 0x00148040 File Offset: 0x00146240
		public Task<List<store_items>> LoadStockTakingItems(int storeId, int categoryId, int availabilityMode, int stateId, List<int> boxIds, string query, bool searchInDescription, int stockTakingOption)
		{
			StoreModel.<LoadStockTakingItems>d__34 <LoadStockTakingItems>d__;
			<LoadStockTakingItems>d__.<>t__builder = AsyncTaskMethodBuilder<List<store_items>>.Create();
			<LoadStockTakingItems>d__.<>4__this = this;
			<LoadStockTakingItems>d__.storeId = storeId;
			<LoadStockTakingItems>d__.categoryId = categoryId;
			<LoadStockTakingItems>d__.availabilityMode = availabilityMode;
			<LoadStockTakingItems>d__.stateId = stateId;
			<LoadStockTakingItems>d__.boxIds = boxIds;
			<LoadStockTakingItems>d__.query = query;
			<LoadStockTakingItems>d__.searchInDescription = searchInDescription;
			<LoadStockTakingItems>d__.stockTakingOption = stockTakingOption;
			<LoadStockTakingItems>d__.<>1__state = -1;
			<LoadStockTakingItems>d__.<>t__builder.Start<StoreModel.<LoadStockTakingItems>d__34>(ref <LoadStockTakingItems>d__);
			return <LoadStockTakingItems>d__.<>t__builder.Task;
		}

		// Token: 0x06004D9B RID: 19867 RVA: 0x001480C8 File Offset: 0x001462C8
		public void StockTakingItemsRollBack()
		{
			try
			{
				auseceEntities ctx = this._ctx;
				if (ctx != null)
				{
					ctx.DetachAll();
				}
			}
			catch (Exception exception)
			{
				StoreModel.Log.Error(exception, "StockTakingItemsRollBack fail");
			}
		}

		// Token: 0x06004D9C RID: 19868 RVA: 0x0014810C File Offset: 0x0014630C
		public Task<bool> SaveStockTakingItems(IEnumerable<store_items> items)
		{
			StoreModel.<SaveStockTakingItems>d__36 <SaveStockTakingItems>d__;
			<SaveStockTakingItems>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<SaveStockTakingItems>d__.<>4__this = this;
			<SaveStockTakingItems>d__.items = items;
			<SaveStockTakingItems>d__.<>1__state = -1;
			<SaveStockTakingItems>d__.<>t__builder.Start<StoreModel.<SaveStockTakingItems>d__36>(ref <SaveStockTakingItems>d__);
			return <SaveStockTakingItems>d__.<>t__builder.Task;
		}

		// Token: 0x06004D9D RID: 19869 RVA: 0x00148158 File Offset: 0x00146358
		public bool LogChanges(IEnumerable<store_items> items, HistoryV2 history)
		{
			bool result;
			try
			{
				foreach (store_items store_items in items)
				{
					if (this._ctx.Entry<store_items>(store_items).State == EntityState.Modified)
					{
						DbPropertyValues originalValues = this._ctx.Entry<store_items>(store_items).OriginalValues;
						DbPropertyValues currentValues = this._ctx.Entry<store_items>(store_items).CurrentValues;
						if ((int)originalValues["category"] != (int)currentValues["category"])
						{
							this._ctx.Entry<store_items>(store_items).Reference<store_cats>((store_items i) => i.store_cats).Load();
							history.AddItemLog("changeCategory", store_items.id, store_items.store_cats.name, "");
						}
						if ((int)originalValues["state"] != (int)currentValues["state"])
						{
							this._ctx.Entry<store_items>(store_items).Reference<items_state>((store_items i) => i.items_state).Load();
							history.AddItemLog("changeState", store_items.id, store_items.items_state.name, "");
						}
						if ((int)originalValues["articul"] != (int)currentValues["articul"])
						{
							int num = Convert.ToInt32(originalValues["articul"]);
							history.AddItemLog("changeArticul", store_items.id, num.ToString("D6"), store_items.articul.ToString("D6"));
						}
						int? num2 = (int?)originalValues["box"];
						int? num3 = (int?)currentValues["box"];
						if (!(num2.GetValueOrDefault() == num3.GetValueOrDefault() & num2 != null == (num3 != null)))
						{
							this._ctx.Entry<store_items>(store_items).Reference<boxes>((store_items i) => i.boxes).Load();
							store_items.box_name = store_items.boxes.name;
							history.AddItemLog("setBox", store_items.id, store_items.boxes.name, "");
						}
					}
				}
				history.Save();
				result = true;
			}
			catch (Exception ex)
			{
				ILogger log = StoreModel.Log;
				string str = "Log items changes error ";
				Exception ex2 = ex;
				log.Error(str + ((ex2 != null) ? ex2.ToString() : null));
				result = false;
			}
			return result;
		}

		// Token: 0x06004D9E RID: 19870 RVA: 0x0014849C File Offset: 0x0014669C
		public static int? OfficeIdByStoreId(int storeId)
		{
			int? result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					result = (from s in auseceEntities.stores
					where s.id == storeId
					select s.office).FirstOrDefault<int?>();
				}
			}
			catch (Exception exception)
			{
				StoreModel.Log.Error(exception, "Get office id by store id fail");
				result = null;
			}
			return result;
		}

		// Token: 0x06004D9F RID: 19871 RVA: 0x001485B4 File Offset: 0x001467B4
		public static bool ItemInUserOffice(int productStoreId)
		{
			int? num = StoreModel.OfficeIdByStoreId(productStoreId);
			int officeId = OfflineData.Instance.Employee.OfficeId;
			return num.GetValueOrDefault() == officeId & num != null;
		}

		// Token: 0x06004DA0 RID: 19872 RVA: 0x001485EC File Offset: 0x001467EC
		public static bool HaveAnyItem(int storeId)
		{
			bool result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					result = auseceEntities.store_items.Any((store_items i) => i.store == storeId);
				}
			}
			catch (Exception exception)
			{
				StoreModel.Log.Error(exception, "Check is store contains any items fail");
				result = true;
			}
			return result;
		}

		// Token: 0x06004DA1 RID: 19873 RVA: 0x001486B8 File Offset: 0x001468B8
		public static List<KeyValuePair<int, string>> GetPriceCols()
		{
			return new List<KeyValuePair<int, string>>
			{
				new KeyValuePair<int, string>(2, (string)Application.Current.TryFindResource("Retail")),
				new KeyValuePair<int, string>(3, (string)Application.Current.TryFindResource("Opt")),
				new KeyValuePair<int, string>(4, (string)Application.Current.TryFindResource("PriceOpt2")),
				new KeyValuePair<int, string>(5, (string)Application.Current.TryFindResource("PriceOpt3"))
			};
		}

		// Token: 0x06004DA2 RID: 19874 RVA: 0x0014874C File Offset: 0x0014694C
		public static string GetPriceColName(int priceColId)
		{
			return StoreModel.GetPriceCols().FirstOrDefault((KeyValuePair<int, string> c) => c.Key == priceColId).Value;
		}

		// Token: 0x06004DA3 RID: 19875 RVA: 0x00148784 File Offset: 0x00146984
		public static Task<List<int>> GetArticuls()
		{
			StoreModel.<GetArticuls>d__43 <GetArticuls>d__;
			<GetArticuls>d__.<>t__builder = AsyncTaskMethodBuilder<List<int>>.Create();
			<GetArticuls>d__.<>1__state = -1;
			<GetArticuls>d__.<>t__builder.Start<StoreModel.<GetArticuls>d__43>(ref <GetArticuls>d__);
			return <GetArticuls>d__.<>t__builder.Task;
		}

		// Token: 0x06004DA4 RID: 19876 RVA: 0x0012F9A0 File Offset: 0x0012DBA0
		public StoreModel()
		{
		}

		// Token: 0x06004DA5 RID: 19877 RVA: 0x001487C0 File Offset: 0x001469C0
		// Note: this type is marked as 'beforefieldinit'.
		static StoreModel()
		{
		}

		// Token: 0x040032E5 RID: 13029
		private static readonly ILogger Log = LogManager.GetCurrentClassLogger();

		// Token: 0x040032E6 RID: 13030
		private auseceEntities _ctx;

		// Token: 0x02000A75 RID: 2677
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004DA6 RID: 19878 RVA: 0x001487D8 File Offset: 0x001469D8
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004DA7 RID: 19879 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06004DA8 RID: 19880 RVA: 0x0006CADC File Offset: 0x0006ACDC
			internal bool <LoadMasterItemsV2Async>b__3_5(int? i)
			{
				return i != null;
			}

			// Token: 0x06004DA9 RID: 19881 RVA: 0x0006CAF0 File Offset: 0x0006ACF0
			internal int <LoadMasterItemsV2Async>b__3_6(int? i)
			{
				return i.Value;
			}

			// Token: 0x06004DAA RID: 19882 RVA: 0x000503B4 File Offset: 0x0004E5B4
			internal int <LoadMasterItemsV2Async>b__3_9(store_items c)
			{
				return c.id;
			}

			// Token: 0x06004DAB RID: 19883 RVA: 0x001487F0 File Offset: 0x001469F0
			internal int <LoadMasterItemsV2Async>b__3_10(store_items c)
			{
				return c.category;
			}

			// Token: 0x06004DAC RID: 19884 RVA: 0x00148804 File Offset: 0x00146A04
			internal string <LoadMasterItemsV2Async>b__3_11(store_items c)
			{
				return c.name;
			}

			// Token: 0x06004DAD RID: 19885 RVA: 0x00148818 File Offset: 0x00146A18
			internal int <LoadMasterItemsV2Async>b__3_12(store_items i)
			{
				return i.count;
			}

			// Token: 0x06004DAE RID: 19886 RVA: 0x0014882C File Offset: 0x00146A2C
			internal int <LoadMasterItemsV2Async>b__3_13(store_items i)
			{
				return i.reserved;
			}

			// Token: 0x06004DAF RID: 19887 RVA: 0x00148840 File Offset: 0x00146A40
			internal decimal <LoadMasterItemsV2Async>b__3_14(store_items i)
			{
				return i.Price2Raw;
			}

			// Token: 0x06004DB0 RID: 19888 RVA: 0x00148840 File Offset: 0x00146A40
			internal decimal <LoadMasterItemsV2Async>b__3_15(store_items i)
			{
				return i.Price2Raw;
			}

			// Token: 0x06004DB1 RID: 19889 RVA: 0x00148854 File Offset: 0x00146A54
			internal int <LoadMasterItemsV2Async>b__3_16(store_items i)
			{
				return i.count - i.reserved - i.dealer_lock;
			}

			// Token: 0x06004DB2 RID: 19890 RVA: 0x00148878 File Offset: 0x00146A78
			internal int <LoadMasterItemsV2Async>b__3_17(store_items i)
			{
				return i.store;
			}

			// Token: 0x06004DB3 RID: 19891 RVA: 0x0014888C File Offset: 0x00146A8C
			internal int <LoadMasterItemsV2Async>b__3_18(store_items c)
			{
				return c.state;
			}

			// Token: 0x06004DB4 RID: 19892 RVA: 0x001488A0 File Offset: 0x00146AA0
			internal int <LoadMasterItemsV2Async>b__3_4(StoreGroup i)
			{
				return i.Articul;
			}

			// Token: 0x06004DB5 RID: 19893 RVA: 0x0014888C File Offset: 0x00146A8C
			internal int <GetStateName>b__4_2(store_items c)
			{
				return c.state;
			}

			// Token: 0x06004DB6 RID: 19894 RVA: 0x001488B4 File Offset: 0x00146AB4
			internal string <GetStateName>b__4_1(items_state i)
			{
				return i.name;
			}

			// Token: 0x06004DB7 RID: 19895 RVA: 0x0009C454 File Offset: 0x0009A654
			internal Product <LoadDetailItemsV2>b__5_6(store_items p)
			{
				return p.ToStoreItem();
			}

			// Token: 0x06004DB8 RID: 19896 RVA: 0x0006CADC File Offset: 0x0006ACDC
			internal bool <LoadMyItems>b__6_0(int? i)
			{
				return i != null;
			}

			// Token: 0x06004DB9 RID: 19897 RVA: 0x0006CAF0 File Offset: 0x0006ACF0
			internal int <LoadMyItems>b__6_1(int? i)
			{
				return i.Value;
			}

			// Token: 0x06004DBA RID: 19898 RVA: 0x001488C8 File Offset: 0x00146AC8
			internal StoreCategory <GetCategories>b__10_0(store_cats c)
			{
				return c.ToStoreCategory();
			}

			// Token: 0x06004DBB RID: 19899 RVA: 0x000C08B0 File Offset: 0x000BEAB0
			internal int? <GetCategories>b__10_1(StoreCategory c)
			{
				return c.Position;
			}

			// Token: 0x06004DBC RID: 19900 RVA: 0x001488C8 File Offset: 0x00146AC8
			internal StoreCategory <GetOnUserItemCategories>b__11_2(store_cats c)
			{
				return c.ToStoreCategory();
			}

			// Token: 0x06004DBD RID: 19901 RVA: 0x000C08B0 File Offset: 0x000BEAB0
			internal int? <GetOnUserItemCategories>b__11_3(StoreCategory c)
			{
				return c.Position;
			}

			// Token: 0x06004DBE RID: 19902 RVA: 0x001488DC File Offset: 0x00146ADC
			internal int <GetOnUserItemCategories>b__11_4(StoreCategory i)
			{
				return i.Id;
			}

			// Token: 0x06004DBF RID: 19903 RVA: 0x0009C454 File Offset: 0x0009A654
			internal Product <GetItems>b__28_0(store_items r)
			{
				return r.ToStoreItem();
			}

			// Token: 0x06004DC0 RID: 19904 RVA: 0x001488F0 File Offset: 0x00146AF0
			internal IOrderedQueryable<store_items> <LoadDealerItemsV2>b__30_0(IQueryable<store_items> i)
			{
				return from r in i
				orderby r.created
				select r;
			}

			// Token: 0x06004DC1 RID: 19905 RVA: 0x0014893C File Offset: 0x00146B3C
			internal IOrderedQueryable<store_sales> <LoadDealerItemsV2>b__30_7(IQueryable<store_sales> i)
			{
				return from r in i
				orderby r.docs.created
				select r;
			}

			// Token: 0x06004DC2 RID: 19906 RVA: 0x0014899C File Offset: 0x00146B9C
			internal RealizationItem <LoadDealerItemsV2>b__30_8(store_sales i)
			{
				return i.ToRealizationItem();
			}

			// Token: 0x06004DC3 RID: 19907 RVA: 0x000D14F8 File Offset: 0x000CF6F8
			internal string <LoadBoxes>b__33_0(boxes b)
			{
				return b.name;
			}

			// Token: 0x040032E7 RID: 13031
			public static readonly StoreModel.<>c <>9 = new StoreModel.<>c();

			// Token: 0x040032E8 RID: 13032
			public static Func<int?, bool> <>9__3_5;

			// Token: 0x040032E9 RID: 13033
			public static Func<int?, int> <>9__3_6;

			// Token: 0x040032EA RID: 13034
			public static Func<store_items, int> <>9__3_9;

			// Token: 0x040032EB RID: 13035
			public static Func<store_items, int> <>9__3_10;

			// Token: 0x040032EC RID: 13036
			public static Func<store_items, string> <>9__3_11;

			// Token: 0x040032ED RID: 13037
			public static Func<store_items, int> <>9__3_12;

			// Token: 0x040032EE RID: 13038
			public static Func<store_items, int> <>9__3_13;

			// Token: 0x040032EF RID: 13039
			public static Func<store_items, decimal> <>9__3_14;

			// Token: 0x040032F0 RID: 13040
			public static Func<store_items, decimal> <>9__3_15;

			// Token: 0x040032F1 RID: 13041
			public static Func<store_items, int> <>9__3_16;

			// Token: 0x040032F2 RID: 13042
			public static Func<store_items, int> <>9__3_17;

			// Token: 0x040032F3 RID: 13043
			public static Func<store_items, int> <>9__3_18;

			// Token: 0x040032F4 RID: 13044
			public static Func<StoreGroup, int> <>9__3_4;

			// Token: 0x040032F5 RID: 13045
			public static Func<store_items, int> <>9__4_2;

			// Token: 0x040032F6 RID: 13046
			public static Func<items_state, string> <>9__4_1;

			// Token: 0x040032F7 RID: 13047
			public static Func<store_items, Product> <>9__5_6;

			// Token: 0x040032F8 RID: 13048
			public static Func<int?, bool> <>9__6_0;

			// Token: 0x040032F9 RID: 13049
			public static Func<int?, int> <>9__6_1;

			// Token: 0x040032FA RID: 13050
			public static Func<store_cats, StoreCategory> <>9__10_0;

			// Token: 0x040032FB RID: 13051
			public static Func<StoreCategory, int?> <>9__10_1;

			// Token: 0x040032FC RID: 13052
			public static Func<store_cats, StoreCategory> <>9__11_2;

			// Token: 0x040032FD RID: 13053
			public static Func<StoreCategory, int?> <>9__11_3;

			// Token: 0x040032FE RID: 13054
			public static Func<StoreCategory, int> <>9__11_4;

			// Token: 0x040032FF RID: 13055
			public static Func<store_items, Product> <>9__28_0;

			// Token: 0x04003300 RID: 13056
			public static Func<IQueryable<store_items>, IOrderedQueryable<store_items>> <>9__30_0;

			// Token: 0x04003301 RID: 13057
			public static Func<IQueryable<store_sales>, IOrderedQueryable<store_sales>> <>9__30_7;

			// Token: 0x04003302 RID: 13058
			public static Func<store_sales, RealizationItem> <>9__30_8;

			// Token: 0x04003303 RID: 13059
			public static Func<boxes, string> <>9__33_0;
		}

		// Token: 0x02000A76 RID: 2678
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06004DC4 RID: 19908 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x04003304 RID: 13060
			public int storeId;

			// Token: 0x04003305 RID: 13061
			public int boxId;
		}

		// Token: 0x02000A77 RID: 2679
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_1
		{
			// Token: 0x06004DC5 RID: 19909 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass3_1()
			{
			}

			// Token: 0x06004DC6 RID: 19910 RVA: 0x001489B0 File Offset: 0x00146BB0
			internal StoreGroup <LoadMasterItemsV2Async>b__3(IGrouping<int, store_items> g)
			{
				StoreGroup storeGroup = new StoreGroup();
				storeGroup.Articul = g.Key;
				storeGroup.DetailIds = g.Select(new Func<store_items, int>(StoreModel.<>c.<>9.<LoadMasterItemsV2Async>b__3_9)).ToList<int>();
				storeGroup.Category = g.Select(new Func<store_items, int>(StoreModel.<>c.<>9.<LoadMasterItemsV2Async>b__3_10)).FirstOrDefault<int>();
				storeGroup.Name = g.Select(new Func<store_items, string>(StoreModel.<>c.<>9.<LoadMasterItemsV2Async>b__3_11)).FirstOrDefault<string>();
				storeGroup.Count = g.Select(new Func<store_items, int>(StoreModel.<>c.<>9.<LoadMasterItemsV2Async>b__3_12)).Sum();
				storeGroup.Reserved = g.Select(new Func<store_items, int>(StoreModel.<>c.<>9.<LoadMasterItemsV2Async>b__3_13)).Sum();
				storeGroup.PriceMin = g.Select(new Func<store_items, decimal>(StoreModel.<>c.<>9.<LoadMasterItemsV2Async>b__3_14)).Min();
				storeGroup.PriceMax = g.Select(new Func<store_items, decimal>(StoreModel.<>c.<>9.<LoadMasterItemsV2Async>b__3_15)).Max();
				storeGroup.Avaliable = g.Select(new Func<store_items, int>(StoreModel.<>c.<>9.<LoadMasterItemsV2Async>b__3_16)).Sum();
				storeGroup.Stores = g.Select(new Func<store_items, int>(StoreModel.<>c.<>9.<LoadMasterItemsV2Async>b__3_17)).ToList<int>();
				storeGroup.State = g.Select(new Func<store_items, int>(StoreModel.<>c.<>9.<LoadMasterItemsV2Async>b__3_18)).FirstOrDefault<int>();
				storeGroup.StateName = StoreModel.GetStateName(this.itemStates, g);
				return storeGroup;
			}

			// Token: 0x04003306 RID: 13062
			public List<items_state> itemStates;
		}

		// Token: 0x02000A78 RID: 2680
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_2
		{
			// Token: 0x06004DC7 RID: 19911 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass3_2()
			{
			}

			// Token: 0x04003307 RID: 13063
			public List<int> ids;
		}

		// Token: 0x02000A79 RID: 2681
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadMasterItemsV2Async>d__3 : IAsyncStateMachine
		{
			// Token: 0x06004DC8 RID: 19912 RVA: 0x00148BC0 File Offset: 0x00146DC0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<StoreGroup> result;
				try
				{
					StoreModel.<>c__DisplayClass3_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new StoreModel.<>c__DisplayClass3_0();
						CS$<>8__locals1.storeId = this.storeId;
						CS$<>8__locals1.boxId = this.boxId;
					}
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = new auseceEntities(false);
						}
						try
						{
							TaskAwaiter<List<IGrouping<int, store_items>>> awaiter;
							if (num != 0)
							{
								this.<>8__1 = new StoreModel.<>c__DisplayClass3_1();
								this.<>8__1.itemStates = this.<ctx>5__2.items_state.ToList<items_state>();
								IQueryable<store_items> source = (from i in this.<ctx>5__2.store_items.AsNoTracking()
								where !i.Hidden
								select i).Where(StoreModel.InStockS1(this.itemOption));
								if (CS$<>8__locals1.storeId != 0)
								{
									source = from i in source
									where i.store == CS$<>8__locals1.storeId
									select i;
								}
								if (CS$<>8__locals1.boxId != 0)
								{
									source = from i in source
									where i.box == (int?)CS$<>8__locals1.boxId
									select i;
								}
								if (this.category != 0)
								{
									StoreModel.<>c__DisplayClass3_2 CS$<>8__locals2 = new StoreModel.<>c__DisplayClass3_2();
									ObjectResult<int?> catChildrens = this.<ctx>5__2.getCatChildrens(new int?(this.category));
									CS$<>8__locals2.ids = catChildrens.Where(new Func<int?, bool>(StoreModel.<>c.<>9.<LoadMasterItemsV2Async>b__3_5)).Select(new Func<int?, int>(StoreModel.<>c.<>9.<LoadMasterItemsV2Async>b__3_6)).ToList<int>();
									source = from i in source
									where CS$<>8__locals2.ids.Contains(i.category)
									select i;
								}
								if (!string.IsNullOrEmpty(this.query))
								{
									source = source.Where(StoreModel.ContainsQuery(this.query));
								}
								awaiter = (from i in source
								group i by i.articul).ToListAsync<IGrouping<int, store_items>>().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<IGrouping<int, store_items>>>, StoreModel.<LoadMasterItemsV2Async>d__3>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<List<IGrouping<int, store_items>>>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							result = awaiter.GetResult().Select(new Func<IGrouping<int, store_items>, StoreGroup>(this.<>8__1.<LoadMasterItemsV2Async>b__3)).ToList<StoreGroup>().DistinctBy(new Func<StoreGroup, int>(StoreModel.<>c.<>9.<LoadMasterItemsV2Async>b__3_4)).ToList<StoreGroup>();
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
						StoreModel.Log.Error(exception, "load master items fail");
						result = new List<StoreGroup>();
					}
				}
				catch (Exception exception2)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception2);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06004DC9 RID: 19913 RVA: 0x0014903C File Offset: 0x0014723C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003308 RID: 13064
			public int <>1__state;

			// Token: 0x04003309 RID: 13065
			public AsyncTaskMethodBuilder<List<StoreGroup>> <>t__builder;

			// Token: 0x0400330A RID: 13066
			public int storeId;

			// Token: 0x0400330B RID: 13067
			public int boxId;

			// Token: 0x0400330C RID: 13068
			public int itemOption;

			// Token: 0x0400330D RID: 13069
			public int category;

			// Token: 0x0400330E RID: 13070
			public string query;

			// Token: 0x0400330F RID: 13071
			private StoreModel.<>c__DisplayClass3_1 <>8__1;

			// Token: 0x04003310 RID: 13072
			private auseceEntities <ctx>5__2;

			// Token: 0x04003311 RID: 13073
			private TaskAwaiter<List<IGrouping<int, store_items>>> <>u__1;
		}

		// Token: 0x02000A7A RID: 2682
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06004DCA RID: 19914 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x06004DCB RID: 19915 RVA: 0x00149058 File Offset: 0x00147258
			internal bool <GetStateName>b__0(items_state i)
			{
				return i.id == this.g.Select(new Func<store_items, int>(StoreModel.<>c.<>9.<GetStateName>b__4_2)).FirstOrDefault<int>();
			}

			// Token: 0x04003312 RID: 13074
			public IGrouping<int, store_items> g;
		}

		// Token: 0x02000A7B RID: 2683
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06004DCC RID: 19916 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x04003313 RID: 13075
			public List<int> detailIds;
		}

		// Token: 0x02000A7C RID: 2684
		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x06004DCD RID: 19917 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x04003314 RID: 13076
			public string query;

			// Token: 0x04003315 RID: 13077
			public int state;
		}

		// Token: 0x02000A7D RID: 2685
		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_1
		{
			// Token: 0x06004DCE RID: 19918 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass6_1()
			{
			}

			// Token: 0x04003316 RID: 13078
			public List<int> categories;
		}

		// Token: 0x02000A7E RID: 2686
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x06004DCF RID: 19919 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x04003317 RID: 13079
			public int category;
		}

		// Token: 0x02000A7F RID: 2687
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadCategory>d__7 : IAsyncStateMachine
		{
			// Token: 0x06004DD0 RID: 19920 RVA: 0x0014909C File Offset: 0x0014729C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				store_cats result;
				try
				{
					StoreModel.<>c__DisplayClass7_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new StoreModel.<>c__DisplayClass7_0();
						CS$<>8__locals1.category = this.category;
					}
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<store_cats> awaiter;
							if (num != 0)
							{
								awaiter = this.<ctx>5__2.store_cats.Include((store_cats c) => c.store_cats1).FirstOrDefaultAsync((store_cats c) => c.id == CS$<>8__locals1.category).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<store_cats>, StoreModel.<LoadCategory>d__7>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<store_cats>);
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
						StoreModel.Log.Error(exception, "Load store category fail");
						result = null;
					}
				}
				catch (Exception exception2)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception2);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06004DD1 RID: 19921 RVA: 0x00149290 File Offset: 0x00147490
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003318 RID: 13080
			public int <>1__state;

			// Token: 0x04003319 RID: 13081
			public AsyncTaskMethodBuilder<store_cats> <>t__builder;

			// Token: 0x0400331A RID: 13082
			public int category;

			// Token: 0x0400331B RID: 13083
			private auseceEntities <ctx>5__2;

			// Token: 0x0400331C RID: 13084
			private TaskAwaiter<store_cats> <>u__1;
		}

		// Token: 0x02000A80 RID: 2688
		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x06004DD2 RID: 19922 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x0400331D RID: 13085
			public string[] queryArr;

			// Token: 0x0400331E RID: 13086
			public string query;
		}

		// Token: 0x02000A81 RID: 2689
		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06004DD3 RID: 19923 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x0400331F RID: 13087
			public int storeId;
		}

		// Token: 0x02000A82 RID: 2690
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadRootNodes>d__9 : IAsyncStateMachine
		{
			// Token: 0x06004DD4 RID: 19924 RVA: 0x001492AC File Offset: 0x001474AC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				StoreModel storeModel = this.<>4__this;
				List<store_cats> result;
				try
				{
					ConfiguredTaskAwaitable<List<store_cats>>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						StoreModel.<>c__DisplayClass9_0 CS$<>8__locals1 = new StoreModel.<>c__DisplayClass9_0();
						CS$<>8__locals1.storeId = this.storeId;
						if (storeModel._ctx == null)
						{
							storeModel._ctx = new auseceEntities(true);
						}
						awaiter = (from sc in storeModel._ctx.store_cats.AsNoTracking().Include((store_cats sc) => sc.store_cats1)
						where sc.parent == null && sc.store_id == (int?)CS$<>8__locals1.storeId
						select sc into i
						orderby i.position
						select i).ToListAsync<store_cats>().ConfigureAwait(false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<store_cats>>.ConfiguredTaskAwaiter, StoreModel.<LoadRootNodes>d__9>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(ConfiguredTaskAwaitable<List<store_cats>>.ConfiguredTaskAwaiter);
						this.<>1__state = -1;
					}
					result = awaiter.GetResult();
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

			// Token: 0x06004DD5 RID: 19925 RVA: 0x001494E8 File Offset: 0x001476E8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003320 RID: 13088
			public int <>1__state;

			// Token: 0x04003321 RID: 13089
			public AsyncTaskMethodBuilder<List<store_cats>> <>t__builder;

			// Token: 0x04003322 RID: 13090
			public int storeId;

			// Token: 0x04003323 RID: 13091
			public StoreModel <>4__this;

			// Token: 0x04003324 RID: 13092
			private ConfiguredTaskAwaitable<List<store_cats>>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000A83 RID: 2691
		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x06004DD6 RID: 19926 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x04003325 RID: 13093
			public int storeId;
		}

		// Token: 0x02000A84 RID: 2692
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCategories>d__10 : IAsyncStateMachine
		{
			// Token: 0x06004DD7 RID: 19927 RVA: 0x00149504 File Offset: 0x00147704
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<StoreCategory> result2;
				try
				{
					StoreModel.<>c__DisplayClass10_0 CS$<>8__locals1;
					if (num > 1)
					{
						CS$<>8__locals1 = new StoreModel.<>c__DisplayClass10_0();
						CS$<>8__locals1.storeId = this.storeId;
						this.<repo>5__2 = new GenericRepository<store_cats>();
					}
					try
					{
						TaskAwaiter<IEnumerable<store_cats>> awaiter;
						IEnumerable<store_cats> result;
						if (num != 0)
						{
							if (num != 1)
							{
								if (!this.showArchive)
								{
									awaiter = this.<repo>5__2.GetAllAsync((store_cats c) => c.store_id == (int?)CS$<>8__locals1.storeId && c.enable == (bool?)true, null, "").GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										int num2 = 1;
										num = 1;
										this.<>1__state = num2;
										this.<>u__1 = awaiter;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<store_cats>>, StoreModel.<GetCategories>d__10>(ref awaiter, ref this);
										return;
									}
								}
								else
								{
									awaiter = this.<repo>5__2.GetAllAsync((store_cats c) => c.store_id == (int?)CS$<>8__locals1.storeId, null, "").GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										int num3 = 0;
										num = 0;
										this.<>1__state = num3;
										this.<>u__1 = awaiter;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<store_cats>>, StoreModel.<GetCategories>d__10>(ref awaiter, ref this);
										return;
									}
									goto IL_234;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<IEnumerable<store_cats>>);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
							}
							result = awaiter.GetResult();
							goto IL_23C;
						}
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<store_cats>>);
						int num5 = -1;
						num = -1;
						this.<>1__state = num5;
						IL_234:
						result = awaiter.GetResult();
						IL_23C:
						result2 = result.Select(new Func<store_cats, StoreCategory>(StoreModel.<>c.<>9.<GetCategories>b__10_0)).OrderBy(new Func<StoreCategory, int?>(StoreModel.<>c.<>9.<GetCategories>b__10_1)).ToList<StoreCategory>();
					}
					finally
					{
						if (num < 0 && this.<repo>5__2 != null)
						{
							((IDisposable)this.<repo>5__2).Dispose();
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
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06004DD8 RID: 19928 RVA: 0x00149818 File Offset: 0x00147A18
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003326 RID: 13094
			public int <>1__state;

			// Token: 0x04003327 RID: 13095
			public AsyncTaskMethodBuilder<List<StoreCategory>> <>t__builder;

			// Token: 0x04003328 RID: 13096
			public int storeId;

			// Token: 0x04003329 RID: 13097
			public bool showArchive;

			// Token: 0x0400332A RID: 13098
			private GenericRepository<store_cats> <repo>5__2;

			// Token: 0x0400332B RID: 13099
			private TaskAwaiter<IEnumerable<store_cats>> <>u__1;
		}

		// Token: 0x02000A85 RID: 2693
		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x06004DD9 RID: 19929 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x0400332C RID: 13100
			public int storeId;
		}

		// Token: 0x02000A86 RID: 2694
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadStoreCategories>d__12 : IAsyncStateMachine
		{
			// Token: 0x06004DDA RID: 19930 RVA: 0x00149834 File Offset: 0x00147A34
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<store_cats> result2;
				try
				{
					if (num != 0)
					{
						this.<>8__1 = new StoreModel.<>c__DisplayClass12_0();
						this.<>8__1.storeId = this.storeId;
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<List<store_cats>> awaiter;
						if (num != 0)
						{
							IQueryable<store_cats> source = (from c in this.<ctx>5__2.store_cats.Include((store_cats c) => c.store_cats1)
							where c.enable != (bool?)false
							select c).DefaultIfEmpty<store_cats>();
							if (this.<>8__1.storeId != 0)
							{
								source = from c in source
								where c.store_id == (int?)this.<>8__1.storeId
								select c;
							}
							if (this.rootNode)
							{
								source = from c in source
								where c.parent == null
								select c;
							}
							awaiter = (from c in source
							orderby c.position
							select c).ToListAsync<store_cats>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_cats>>, StoreModel.<LoadStoreCategories>d__12>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<store_cats>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						List<store_cats> result = awaiter.GetResult();
						if (this.includeAll)
						{
							result.Insert(0, new store_cats
							{
								id = 0,
								store_id = new int?(this.<>8__1.storeId),
								name = (string)Application.Current.TryFindResource("AllCategories")
							});
						}
						result2 = result;
					}
					catch (Exception exception)
					{
						StoreModel.Log.Error(exception, "Load categories of the store error");
						result2 = new List<store_cats>();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
						}
					}
				}
				catch (Exception exception2)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception2);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06004DDB RID: 19931 RVA: 0x00149BD8 File Offset: 0x00147DD8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400332D RID: 13101
			public int <>1__state;

			// Token: 0x0400332E RID: 13102
			public AsyncTaskMethodBuilder<List<store_cats>> <>t__builder;

			// Token: 0x0400332F RID: 13103
			public int storeId;

			// Token: 0x04003330 RID: 13104
			public bool rootNode;

			// Token: 0x04003331 RID: 13105
			public bool includeAll;

			// Token: 0x04003332 RID: 13106
			private StoreModel.<>c__DisplayClass12_0 <>8__1;

			// Token: 0x04003333 RID: 13107
			private auseceEntities <ctx>5__2;

			// Token: 0x04003334 RID: 13108
			private TaskAwaiter<List<store_cats>> <>u__1;
		}

		// Token: 0x02000A87 RID: 2695
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadStores>d__13 : IAsyncStateMachine
		{
			// Token: 0x06004DDC RID: 19932 RVA: 0x00149BF4 File Offset: 0x00147DF4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<stores> result2;
				try
				{
					if (num != 0)
					{
						this.<stores>5__2 = new List<stores>();
						if (this.includeSelect)
						{
							this.<stores>5__2.Add(new stores
							{
								id = 0,
								name = (string)Application.Current.TryFindResource("SelectStore2")
							});
						}
						if (this.includeAll)
						{
							this.<stores>5__2.Add(new stores
							{
								id = 0,
								name = (string)Application.Current.TryFindResource("All")
							});
						}
					}
					try
					{
						if (num != 0)
						{
							this.<ctx>5__3 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<List<stores>> awaiter;
							if (num != 0)
							{
								awaiter = (from s in this.<ctx>5__3.stores
								where s.active
								select s).ToListAsync<stores>().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<stores>>, StoreModel.<LoadStores>d__13>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<List<stores>>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							List<stores> result = awaiter.GetResult();
							this.<stores>5__2.AddRange(result);
						}
						finally
						{
							if (num < 0 && this.<ctx>5__3 != null)
							{
								((IDisposable)this.<ctx>5__3).Dispose();
							}
						}
						this.<ctx>5__3 = null;
					}
					catch (Exception exception)
					{
						StoreModel.Log.Error(exception, "Load stores fail");
					}
					result2 = this.<stores>5__2;
				}
				catch (Exception exception2)
				{
					this.<>1__state = -2;
					this.<stores>5__2 = null;
					this.<>t__builder.SetException(exception2);
					return;
				}
				this.<>1__state = -2;
				this.<stores>5__2 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06004DDD RID: 19933 RVA: 0x00149E1C File Offset: 0x0014801C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003335 RID: 13109
			public int <>1__state;

			// Token: 0x04003336 RID: 13110
			public AsyncTaskMethodBuilder<List<stores>> <>t__builder;

			// Token: 0x04003337 RID: 13111
			public bool includeSelect;

			// Token: 0x04003338 RID: 13112
			public bool includeAll;

			// Token: 0x04003339 RID: 13113
			private List<stores> <stores>5__2;

			// Token: 0x0400333A RID: 13114
			private auseceEntities <ctx>5__3;

			// Token: 0x0400333B RID: 13115
			private TaskAwaiter<List<stores>> <>u__1;
		}

		// Token: 0x02000A88 RID: 2696
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ItemStoreChangeLog>d__15 : IAsyncStateMachine
		{
			// Token: 0x06004DDE RID: 19934 RVA: 0x00149E38 File Offset: 0x00148038
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				StoreModel storeModel = this.<>4__this;
				try
				{
					TaskAwaiter<store_cats> awaiter;
					if (num != 0)
					{
						this.<history>5__2 = new HistoryV2();
						if (this.original.store != this.current.store)
						{
							stores stores = storeModel.LoadStore(this.current.store);
							if (stores != null)
							{
								this.<history>5__2.AddItemLog("changeStore", this.current.id, stores.name, "");
							}
						}
						if (this.original.category == this.current.category)
						{
							goto IL_120;
						}
						awaiter = storeModel.LoadCategory(this.current.category).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<store_cats>, StoreModel.<ItemStoreChangeLog>d__15>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<store_cats>);
						this.<>1__state = -1;
					}
					store_cats result = awaiter.GetResult();
					if (result != null)
					{
						this.<history>5__2.AddItemLog("changeCategory", this.current.id, result.name, "");
					}
					IL_120:
					this.<history>5__2.Save();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<history>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<history>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06004DDF RID: 19935 RVA: 0x00149FC8 File Offset: 0x001481C8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400333C RID: 13116
			public int <>1__state;

			// Token: 0x0400333D RID: 13117
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400333E RID: 13118
			public store_items original;

			// Token: 0x0400333F RID: 13119
			public store_items current;

			// Token: 0x04003340 RID: 13120
			public StoreModel <>4__this;

			// Token: 0x04003341 RID: 13121
			private HistoryV2 <history>5__2;

			// Token: 0x04003342 RID: 13122
			private TaskAwaiter<store_cats> <>u__1;
		}

		// Token: 0x02000A89 RID: 2697
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <AddCategory>d__19 : IAsyncStateMachine
		{
			// Token: 0x06004DE0 RID: 19936 RVA: 0x00149FE4 File Offset: 0x001481E4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				bool result;
				try
				{
					try
					{
						store_cats entity;
						if (num != 0)
						{
							entity = new store_cats
							{
								store_id = new int?(this.storeId),
								name = this.c.Name,
								parent = this.c.Parent,
								enable = new bool?(true),
								ico = this.c.Icon
							};
							this.<history>5__2 = new HistoryV2();
							this.<ctx>5__3 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<int> awaiter;
							if (num != 0)
							{
								this.<ctx>5__3.store_cats.Add(entity);
								awaiter = this.<ctx>5__3.SaveChangesAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, StoreModel.<AddCategory>d__19>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<int>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							awaiter.GetResult();
							this.<history>5__2.Add(55, new string[]
							{
								this.c.Name
							});
							this.<history>5__2.Save();
						}
						finally
						{
							if (num < 0 && this.<ctx>5__3 != null)
							{
								((IDisposable)this.<ctx>5__3).Dispose();
							}
						}
						this.<ctx>5__3 = null;
						this.<history>5__2 = null;
					}
					catch (Exception ex)
					{
						StoreModel.Log.Error(ex, ex.Message);
						result = false;
						goto IL_17B;
					}
					result = true;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_17B:
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06004DE1 RID: 19937 RVA: 0x0014A1CC File Offset: 0x001483CC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003343 RID: 13123
			public int <>1__state;

			// Token: 0x04003344 RID: 13124
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x04003345 RID: 13125
			public int storeId;

			// Token: 0x04003346 RID: 13126
			public ICategory c;

			// Token: 0x04003347 RID: 13127
			private HistoryV2 <history>5__2;

			// Token: 0x04003348 RID: 13128
			private auseceEntities <ctx>5__3;

			// Token: 0x04003349 RID: 13129
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x02000A8A RID: 2698
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateCategory>d__20 : IAsyncStateMachine
		{
			// Token: 0x06004DE2 RID: 19938 RVA: 0x0014A1E8 File Offset: 0x001483E8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				bool result2;
				try
				{
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<store_cats> awaiter;
							if (num != 0)
							{
								awaiter = this.<ctx>5__2.store_cats.FindAsync(new object[]
								{
									this.c.Id
								}).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<store_cats>, StoreModel.<UpdateCategory>d__20>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<store_cats>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							store_cats result = awaiter.GetResult();
							result.name = this.c.Name;
							result.parent = this.c.Parent;
							result.enable = new bool?(!this.c.Archive);
							result.ico = this.c.Icon;
							this.<ctx>5__2.SaveChanges();
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
					catch (Exception ex)
					{
						StoreModel.Log.Error(ex, ex.Message);
						result2 = false;
						goto IL_146;
					}
					result2 = true;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_146:
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06004DE3 RID: 19939 RVA: 0x0014A39C File Offset: 0x0014859C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400334A RID: 13130
			public int <>1__state;

			// Token: 0x0400334B RID: 13131
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x0400334C RID: 13132
			public ICategory c;

			// Token: 0x0400334D RID: 13133
			private auseceEntities <ctx>5__2;

			// Token: 0x0400334E RID: 13134
			private TaskAwaiter<store_cats> <>u__1;
		}

		// Token: 0x02000A8B RID: 2699
		[CompilerGenerated]
		private sealed class <>c__DisplayClass23_0
		{
			// Token: 0x06004DE4 RID: 19940 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass23_0()
			{
			}

			// Token: 0x0400334F RID: 13135
			public List<int> ids;
		}

		// Token: 0x02000A8C RID: 2700
		[CompilerGenerated]
		private sealed class <>c__DisplayClass24_0
		{
			// Token: 0x06004DE5 RID: 19941 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass24_0()
			{
			}

			// Token: 0x04003350 RID: 13136
			public int parentId;
		}

		// Token: 0x02000A8D RID: 2701
		[CompilerGenerated]
		private sealed class <>c__DisplayClass25_0
		{
			// Token: 0x06004DE6 RID: 19942 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass25_0()
			{
			}

			// Token: 0x04003351 RID: 13137
			public ICategory cc;
		}

		// Token: 0x02000A8E RID: 2702
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SavePosition>d__25 : IAsyncStateMachine
		{
			// Token: 0x06004DE7 RID: 19943 RVA: 0x0014A3B8 File Offset: 0x001485B8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				bool result2;
				try
				{
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = new auseceEntities(true);
						}
						try
						{
							if (num != 0)
							{
								this.<ctx>5__2.Configuration.ProxyCreationEnabled = false;
								this.<>7__wrap2 = this.c.GetEnumerator();
							}
							try
							{
								TaskAwaiter<store_cats> awaiter;
								if (num == 0)
								{
									awaiter = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter<store_cats>);
									int num2 = -1;
									num = -1;
									this.<>1__state = num2;
									goto IL_16A;
								}
								IL_69:
								if (!this.<>7__wrap2.MoveNext())
								{
									goto IL_1B7;
								}
								this.<>8__1 = new StoreModel.<>c__DisplayClass25_0();
								this.<>8__1.cc = this.<>7__wrap2.Current;
								awaiter = (from i in this.<ctx>5__2.store_cats
								where i.id == this.<>8__1.cc.Id
								select i).FirstOrDefaultAsync<store_cats>().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num3 = 0;
									num = 0;
									this.<>1__state = num3;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<store_cats>, StoreModel.<SavePosition>d__25>(ref awaiter, ref this);
									return;
								}
								IL_16A:
								store_cats result = awaiter.GetResult();
								if (result != null)
								{
									result.parent = this.<>8__1.cc.Parent;
									result.position = this.<>8__1.cc.Position;
								}
								this.<>8__1 = null;
								goto IL_69;
							}
							finally
							{
								if (num < 0 && this.<>7__wrap2 != null)
								{
									this.<>7__wrap2.Dispose();
								}
							}
							IL_1B7:
							this.<>7__wrap2 = null;
							this.<ctx>5__2.SaveChanges();
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
					catch (Exception ex)
					{
						StoreModel.Log.Error(ex, ex.Message);
						result2 = false;
						goto IL_223;
					}
					result2 = true;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_223:
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06004DE8 RID: 19944 RVA: 0x0014A660 File Offset: 0x00148860
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003352 RID: 13138
			public int <>1__state;

			// Token: 0x04003353 RID: 13139
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x04003354 RID: 13140
			public IEnumerable<ICategory> c;

			// Token: 0x04003355 RID: 13141
			private StoreModel.<>c__DisplayClass25_0 <>8__1;

			// Token: 0x04003356 RID: 13142
			private auseceEntities <ctx>5__2;

			// Token: 0x04003357 RID: 13143
			private IEnumerator<ICategory> <>7__wrap2;

			// Token: 0x04003358 RID: 13144
			private TaskAwaiter<store_cats> <>u__1;
		}

		// Token: 0x02000A8F RID: 2703
		[CompilerGenerated]
		private sealed class <>c__DisplayClass26_0
		{
			// Token: 0x06004DE9 RID: 19945 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass26_0()
			{
			}

			// Token: 0x04003359 RID: 13145
			public List<int> categoryIds;
		}

		// Token: 0x02000A90 RID: 2704
		[CompilerGenerated]
		private sealed class <>c__DisplayClass27_0
		{
			// Token: 0x06004DEA RID: 19946 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass27_0()
			{
			}

			// Token: 0x0400335A RID: 13146
			public int articul;
		}

		// Token: 0x02000A91 RID: 2705
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadItems>d__27 : IAsyncStateMachine
		{
			// Token: 0x06004DEB RID: 19947 RVA: 0x0014A67C File Offset: 0x0014887C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IEnumerable<store_items> result;
				try
				{
					StoreModel.<>c__DisplayClass27_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new StoreModel.<>c__DisplayClass27_0();
						CS$<>8__locals1.articul = this.articul;
						this.<repo>5__2 = new GenericRepository<store_items>();
					}
					try
					{
						TaskAwaiter<IEnumerable<store_items>> awaiter;
						if (num != 0)
						{
							this.<repo>5__2.DisableProxyCreation();
							awaiter = this.<repo>5__2.GetAllAsync((store_items i) => i.articul == CS$<>8__locals1.articul, null, "items_state").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<store_items>>, StoreModel.<LoadItems>d__27>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<store_items>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult();
					}
					finally
					{
						if (num < 0 && this.<repo>5__2 != null)
						{
							((IDisposable)this.<repo>5__2).Dispose();
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

			// Token: 0x06004DEC RID: 19948 RVA: 0x0014A804 File Offset: 0x00148A04
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400335B RID: 13147
			public int <>1__state;

			// Token: 0x0400335C RID: 13148
			public AsyncTaskMethodBuilder<IEnumerable<store_items>> <>t__builder;

			// Token: 0x0400335D RID: 13149
			public int articul;

			// Token: 0x0400335E RID: 13150
			private GenericRepository<store_items> <repo>5__2;

			// Token: 0x0400335F RID: 13151
			private TaskAwaiter<IEnumerable<store_items>> <>u__1;
		}

		// Token: 0x02000A92 RID: 2706
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetItems>d__28 : IAsyncStateMachine
		{
			// Token: 0x06004DED RID: 19949 RVA: 0x0014A820 File Offset: 0x00148A20
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IEnumerable<Product> result;
				try
				{
					if (num != 0)
					{
						this.<repo>5__2 = new GenericRepository<store_items>();
					}
					try
					{
						TaskAwaiter<IEnumerable<store_items>> awaiter;
						if (num != 0)
						{
							this.<repo>5__2.AsNoTracking();
							this.<repo>5__2.DisableProxyCreation();
							awaiter = this.<repo>5__2.GetAllAsync(StoreModel.ContainsQuery(this.query), null, "items_state").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<store_items>>, StoreModel.<GetItems>d__28>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<store_items>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult().Select(new Func<store_items, Product>(StoreModel.<>c.<>9.<GetItems>b__28_0)).ToList<Product>();
					}
					finally
					{
						if (num < 0 && this.<repo>5__2 != null)
						{
							((IDisposable)this.<repo>5__2).Dispose();
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

			// Token: 0x06004DEE RID: 19950 RVA: 0x0014A958 File Offset: 0x00148B58
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003360 RID: 13152
			public int <>1__state;

			// Token: 0x04003361 RID: 13153
			public AsyncTaskMethodBuilder<IEnumerable<Product>> <>t__builder;

			// Token: 0x04003362 RID: 13154
			public string query;

			// Token: 0x04003363 RID: 13155
			private GenericRepository<store_items> <repo>5__2;

			// Token: 0x04003364 RID: 13156
			private TaskAwaiter<IEnumerable<store_items>> <>u__1;
		}

		// Token: 0x02000A93 RID: 2707
		[CompilerGenerated]
		private sealed class <>c__DisplayClass29_0
		{
			// Token: 0x06004DEF RID: 19951 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass29_0()
			{
			}

			// Token: 0x04003365 RID: 13157
			public int status;

			// Token: 0x04003366 RID: 13158
			public string query;

			// Token: 0x04003367 RID: 13159
			public DateTime from;

			// Token: 0x04003368 RID: 13160
			public DateTime to;

			// Token: 0x04003369 RID: 13161
			public int storeId;

			// Token: 0x0400336A RID: 13162
			public int userId;
		}

		// Token: 0x02000A94 RID: 2708
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadItems>d__29 : IAsyncStateMachine
		{
			// Token: 0x06004DF0 RID: 19952 RVA: 0x0014A974 File Offset: 0x00148B74
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<StoreIntReserveLite> result;
				try
				{
					StoreModel.<>c__DisplayClass29_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new StoreModel.<>c__DisplayClass29_0();
						CS$<>8__locals1.status = this.status;
						CS$<>8__locals1.query = this.query;
						CS$<>8__locals1.storeId = this.storeId;
						CS$<>8__locals1.userId = this.userId;
						CS$<>8__locals1.from = this.period.From.Date;
						CS$<>8__locals1.to = this.period.To.Date.AddDays(1.0).AddSeconds(-1.0);
					}
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<List<StoreIntReserveLite>> awaiter;
							if (num != 0)
							{
								ParameterExpression parameterExpression;
								IQueryable<StoreIntReserveLite> source = this.<ctx>5__2.store_int_reserve.Select(System.Linq.Expressions.Expression.Lambda<Func<store_int_reserve, StoreIntReserveLite>>(System.Linq.Expressions.Expression.MemberInit(System.Linq.Expressions.Expression.New(typeof(StoreIntReserveLite)), new MemberBinding[]
								{
									System.Linq.Expressions.Expression.Bind(methodof(StoreIntReserveLite.set_Id(int)), System.Linq.Expressions.Expression.Property(parameterExpression, methodof(store_int_reserve.get_id()))),
									System.Linq.Expressions.Expression.Bind(methodof(StoreIntReserveLite.set_State(int)), System.Linq.Expressions.Expression.Property(parameterExpression, methodof(store_int_reserve.get_state()))),
									System.Linq.Expressions.Expression.Bind(methodof(StoreIntReserveLite.set_StoreId(int)), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(store_int_reserve.get_store_items())), methodof(store_items.get_store()))),
									System.Linq.Expressions.Expression.Bind(methodof(StoreIntReserveLite.set_ItemId(int)), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(store_int_reserve.get_store_items())), methodof(store_items.get_id()))),
									System.Linq.Expressions.Expression.Bind(methodof(StoreIntReserveLite.set_ItemArticul(int)), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(store_int_reserve.get_store_items())), methodof(store_items.get_articul()))),
									System.Linq.Expressions.Expression.Bind(methodof(StoreIntReserveLite.set_ItemName(string)), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(store_int_reserve.get_store_items())), methodof(store_items.get_name()))),
									System.Linq.Expressions.Expression.Bind(methodof(StoreIntReserveLite.set_ItemCount(int)), System.Linq.Expressions.Expression.Property(parameterExpression, methodof(store_int_reserve.get_count()))),
									System.Linq.Expressions.Expression.Bind(methodof(StoreIntReserveLite.set_ItemPrice(decimal)), System.Linq.Expressions.Expression.Property(parameterExpression, methodof(store_int_reserve.get_price()))),
									System.Linq.Expressions.Expression.Bind(methodof(StoreIntReserveLite.set_ItemInPrice(decimal)), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(store_int_reserve.get_store_items())), methodof(store_items.get_in_price()))),
									System.Linq.Expressions.Expression.Bind(methodof(StoreIntReserveLite.set_RepairId(int?)), System.Linq.Expressions.Expression.Property(parameterExpression, methodof(store_int_reserve.get_repair_id()))),
									System.Linq.Expressions.Expression.Bind(methodof(StoreIntReserveLite.set_ToUserFirstName(string)), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(store_int_reserve.get_users())), methodof(users.get_name()))),
									System.Linq.Expressions.Expression.Bind(methodof(StoreIntReserveLite.set_ToUserLastName(string)), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(store_int_reserve.get_users())), methodof(users.get_surname()))),
									System.Linq.Expressions.Expression.Bind(methodof(StoreIntReserveLite.set_ToUserPatronymic(string)), System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Property(parameterExpression, methodof(store_int_reserve.get_users())), methodof(users.get_patronymic()))),
									System.Linq.Expressions.Expression.Bind(methodof(StoreIntReserveLite.set_ToUser(int)), System.Linq.Expressions.Expression.Property(parameterExpression, methodof(store_int_reserve.get_to_user()))),
									System.Linq.Expressions.Expression.Bind(methodof(StoreIntReserveLite.set_Notes(string)), System.Linq.Expressions.Expression.Property(parameterExpression, methodof(store_int_reserve.get_notes()))),
									System.Linq.Expressions.Expression.Bind(methodof(StoreIntReserveLite.set_Created(DateTime?)), System.Linq.Expressions.Expression.Property(parameterExpression, methodof(store_int_reserve.get_created())))
								}), new ParameterExpression[]
								{
									parameterExpression
								}));
								if (CS$<>8__locals1.status >= 0)
								{
									source = from i in source
									where i.State == CS$<>8__locals1.status
									select i;
								}
								if (!string.IsNullOrEmpty(CS$<>8__locals1.query))
								{
									source = from i in source
									where i.ItemName.Contains(CS$<>8__locals1.query) || i.Notes.Contains(CS$<>8__locals1.query)
									select i;
								}
								if (CS$<>8__locals1.status != -2)
								{
									source = from i in source
									where i.Created >= (DateTime?)CS$<>8__locals1.@from && i.Created <= (DateTime?)CS$<>8__locals1.to
									select i;
								}
								else
								{
									source = from i in source
									where i.State < 3
									select i;
								}
								if (CS$<>8__locals1.storeId != 0)
								{
									source = from i in source
									where i.StoreId == CS$<>8__locals1.storeId
									select i;
								}
								if (CS$<>8__locals1.userId != 0)
								{
									source = from i in source
									where i.ToUser == CS$<>8__locals1.userId
									select i;
								}
								source = from i in source
								orderby i.Id
								select i;
								awaiter = source.ToListAsync<StoreIntReserveLite>().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<StoreIntReserveLite>>, StoreModel.<LoadItems>d__29>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<List<StoreIntReserveLite>>);
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
						StoreModel.Log.Error(exception, "Load store int reserve fail");
						result = new List<StoreIntReserveLite>();
					}
				}
				catch (Exception exception2)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception2);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06004DF1 RID: 19953 RVA: 0x0014B2DC File Offset: 0x001494DC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400336B RID: 13163
			public int <>1__state;

			// Token: 0x0400336C RID: 13164
			public AsyncTaskMethodBuilder<List<StoreIntReserveLite>> <>t__builder;

			// Token: 0x0400336D RID: 13165
			public int status;

			// Token: 0x0400336E RID: 13166
			public string query;

			// Token: 0x0400336F RID: 13167
			public int storeId;

			// Token: 0x04003370 RID: 13168
			public int userId;

			// Token: 0x04003371 RID: 13169
			public IPeriod period;

			// Token: 0x04003372 RID: 13170
			private auseceEntities <ctx>5__2;

			// Token: 0x04003373 RID: 13171
			private TaskAwaiter<List<StoreIntReserveLite>> <>u__1;
		}

		// Token: 0x02000A95 RID: 2709
		[CompilerGenerated]
		private sealed class <>c__DisplayClass30_0
		{
			// Token: 0x06004DF2 RID: 19954 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass30_0()
			{
			}

			// Token: 0x06004DF3 RID: 19955 RVA: 0x0014B2F8 File Offset: 0x001494F8
			internal RealizationItem <LoadDealerItemsV2>b__1(store_items i)
			{
				return i.ToRealizationItem(this.reserve);
			}

			// Token: 0x04003374 RID: 13172
			public int dealerId;

			// Token: 0x04003375 RID: 13173
			public string query;

			// Token: 0x04003376 RID: 13174
			public List<int> cats;

			// Token: 0x04003377 RID: 13175
			public bool reserve;
		}

		// Token: 0x02000A96 RID: 2710
		[CompilerGenerated]
		private sealed class <>c__DisplayClass31_0
		{
			// Token: 0x06004DF4 RID: 19956 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass31_0()
			{
			}

			// Token: 0x04003378 RID: 13176
			public DocStates rnStatus;

			// Token: 0x04003379 RID: 13177
			public int clientId;
		}

		// Token: 0x02000A97 RID: 2711
		[CompilerGenerated]
		private sealed class <>c__DisplayClass32_0
		{
			// Token: 0x06004DF5 RID: 19957 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass32_0()
			{
			}

			// Token: 0x0400337A RID: 13178
			public DocStates rnStatus;

			// Token: 0x0400337B RID: 13179
			public int clientId;

			// Token: 0x0400337C RID: 13180
			public bool paid;
		}

		// Token: 0x02000A98 RID: 2712
		[CompilerGenerated]
		private sealed class <>c__DisplayClass33_0
		{
			// Token: 0x06004DF6 RID: 19958 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass33_0()
			{
			}

			// Token: 0x0400337D RID: 13181
			public int storeId;
		}

		// Token: 0x02000A99 RID: 2713
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadBoxes>d__33 : IAsyncStateMachine
		{
			// Token: 0x06004DF7 RID: 19959 RVA: 0x0014B314 File Offset: 0x00149514
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<boxes> result;
				try
				{
					StoreModel.<>c__DisplayClass33_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new StoreModel.<>c__DisplayClass33_0();
						CS$<>8__locals1.storeId = this.storeId;
						this.<repo>5__2 = new GenericRepository<boxes>();
					}
					try
					{
						TaskAwaiter<IEnumerable<boxes>> awaiter;
						if (num != 0)
						{
							this.<repo>5__2.DisableProxyCreation();
							this.<repo>5__2.AsNoTracking();
							awaiter = this.<repo>5__2.GetAllAsync((boxes b) => b.store_id == (int?)CS$<>8__locals1.storeId && b.non_items == false, null, "").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<boxes>>, StoreModel.<LoadBoxes>d__33>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<boxes>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						List<boxes> list = awaiter.GetResult().OrderBy(new Func<boxes, string>(StoreModel.<>c.<>9.<LoadBoxes>b__33_0), new NaturalComparer()).ToList<boxes>();
						if (this.includeAll)
						{
							list.Insert(0, new boxes
							{
								id = 0,
								name = Lang.t("AllBoxes")
							});
						}
						result = list;
					}
					finally
					{
						if (num < 0 && this.<repo>5__2 != null)
						{
							((IDisposable)this.<repo>5__2).Dispose();
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

			// Token: 0x06004DF8 RID: 19960 RVA: 0x0014B54C File Offset: 0x0014974C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400337E RID: 13182
			public int <>1__state;

			// Token: 0x0400337F RID: 13183
			public AsyncTaskMethodBuilder<List<boxes>> <>t__builder;

			// Token: 0x04003380 RID: 13184
			public int storeId;

			// Token: 0x04003381 RID: 13185
			public bool includeAll;

			// Token: 0x04003382 RID: 13186
			private GenericRepository<boxes> <repo>5__2;

			// Token: 0x04003383 RID: 13187
			private TaskAwaiter<IEnumerable<boxes>> <>u__1;
		}

		// Token: 0x02000A9A RID: 2714
		[CompilerGenerated]
		private sealed class <>c__DisplayClass34_0
		{
			// Token: 0x06004DF9 RID: 19961 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass34_0()
			{
			}

			// Token: 0x04003384 RID: 13188
			public int storeId;

			// Token: 0x04003385 RID: 13189
			public int stateId;

			// Token: 0x04003386 RID: 13190
			public List<int> boxIds;

			// Token: 0x04003387 RID: 13191
			public int stockTakingOption;

			// Token: 0x04003388 RID: 13192
			public string query;
		}

		// Token: 0x02000A9B RID: 2715
		[CompilerGenerated]
		private sealed class <>c__DisplayClass34_1
		{
			// Token: 0x06004DFA RID: 19962 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass34_1()
			{
			}

			// Token: 0x04003389 RID: 13193
			public List<int> cats;
		}

		// Token: 0x02000A9C RID: 2716
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadStockTakingItems>d__34 : IAsyncStateMachine
		{
			// Token: 0x06004DFB RID: 19963 RVA: 0x0014B568 File Offset: 0x00149768
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				StoreModel storeModel = this.<>4__this;
				List<store_items> result;
				try
				{
					StoreModel.<>c__DisplayClass34_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new StoreModel.<>c__DisplayClass34_0();
						CS$<>8__locals1.storeId = this.storeId;
						CS$<>8__locals1.stateId = this.stateId;
						CS$<>8__locals1.boxIds = this.boxIds;
						CS$<>8__locals1.stockTakingOption = this.stockTakingOption;
						CS$<>8__locals1.query = this.query;
					}
					try
					{
						TaskAwaiter<List<store_items>> awaiter;
						if (num != 0)
						{
							if (storeModel._ctx == null)
							{
								storeModel._ctx = new auseceEntities(true);
							}
							IQueryable<store_items> source = storeModel._ctx.store_items.AsQueryable<store_items>();
							if (CS$<>8__locals1.storeId != 0)
							{
								source = from i in source
								where i.store == CS$<>8__locals1.storeId
								select i;
							}
							if (this.categoryId != 0)
							{
								StoreModel.<>c__DisplayClass34_1 CS$<>8__locals2 = new StoreModel.<>c__DisplayClass34_1();
								CS$<>8__locals2.cats = storeModel.LoadChildCategoriesId(this.categoryId);
								CS$<>8__locals2.cats.Add(this.categoryId);
								source = from i in source
								where CS$<>8__locals2.cats.Contains(i.category)
								select i;
							}
							if (this.availabilityMode != 0)
							{
								source = source.Where(StoreModel.InStockS1(this.availabilityMode));
							}
							if (CS$<>8__locals1.stateId != 0)
							{
								source = from i in source
								where i.state == CS$<>8__locals1.stateId
								select i;
							}
							if (CS$<>8__locals1.boxIds != null && CS$<>8__locals1.boxIds.Any<int>())
							{
								source = from i in source
								where CS$<>8__locals1.boxIds.Contains(i.box.Value)
								select i;
							}
							if (CS$<>8__locals1.stockTakingOption != -1)
							{
								source = from i in source
								where i.st_state == CS$<>8__locals1.stockTakingOption
								select i;
							}
							if (!string.IsNullOrEmpty(CS$<>8__locals1.query))
							{
								source = (this.searchInDescription ? (from i in source
								where i.name.Contains(CS$<>8__locals1.query) || i.description.Contains(CS$<>8__locals1.query)
								select i) : source.Where((store_items i) => i.name.Contains(CS$<>8__locals1.query)));
							}
							awaiter = source.ToListAsync<store_items>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_items>>, StoreModel.<LoadStockTakingItems>d__34>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<store_items>>);
							this.<>1__state = -1;
						}
						result = awaiter.GetResult();
					}
					catch (Exception exception)
					{
						StoreModel.Log.Error(exception, "Load stocktaking items fail");
						result = new List<store_items>();
					}
				}
				catch (Exception exception2)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception2);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06004DFC RID: 19964 RVA: 0x0014BB34 File Offset: 0x00149D34
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400338A RID: 13194
			public int <>1__state;

			// Token: 0x0400338B RID: 13195
			public AsyncTaskMethodBuilder<List<store_items>> <>t__builder;

			// Token: 0x0400338C RID: 13196
			public int storeId;

			// Token: 0x0400338D RID: 13197
			public int stateId;

			// Token: 0x0400338E RID: 13198
			public List<int> boxIds;

			// Token: 0x0400338F RID: 13199
			public int stockTakingOption;

			// Token: 0x04003390 RID: 13200
			public string query;

			// Token: 0x04003391 RID: 13201
			public StoreModel <>4__this;

			// Token: 0x04003392 RID: 13202
			public int categoryId;

			// Token: 0x04003393 RID: 13203
			public int availabilityMode;

			// Token: 0x04003394 RID: 13204
			public bool searchInDescription;

			// Token: 0x04003395 RID: 13205
			private TaskAwaiter<List<store_items>> <>u__1;
		}

		// Token: 0x02000A9D RID: 2717
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SaveStockTakingItems>d__36 : IAsyncStateMachine
		{
			// Token: 0x06004DFD RID: 19965 RVA: 0x0014BB50 File Offset: 0x00149D50
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				StoreModel storeModel = this.<>4__this;
				bool result;
				try
				{
					try
					{
						TaskAwaiter<int> awaiter;
						if (num != 0)
						{
							this.<history>5__2 = new HistoryV2();
							storeModel.LogChanges(this.items, this.<history>5__2);
							awaiter = storeModel._ctx.SaveChangesAsync().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, StoreModel.<SaveStockTakingItems>d__36>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<int>);
							this.<>1__state = -1;
						}
						awaiter.GetResult();
						this.<history>5__2.Save();
						result = true;
					}
					catch (Exception exception)
					{
						StoreModel.Log.Error(exception, "Save StockTakingItems fail");
						result = false;
					}
				}
				catch (Exception exception2)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception2);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06004DFE RID: 19966 RVA: 0x0014BC5C File Offset: 0x00149E5C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003396 RID: 13206
			public int <>1__state;

			// Token: 0x04003397 RID: 13207
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x04003398 RID: 13208
			public StoreModel <>4__this;

			// Token: 0x04003399 RID: 13209
			public IEnumerable<store_items> items;

			// Token: 0x0400339A RID: 13210
			private HistoryV2 <history>5__2;

			// Token: 0x0400339B RID: 13211
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x02000A9E RID: 2718
		[CompilerGenerated]
		private sealed class <>c__DisplayClass38_0
		{
			// Token: 0x06004DFF RID: 19967 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass38_0()
			{
			}

			// Token: 0x0400339C RID: 13212
			public int storeId;
		}

		// Token: 0x02000A9F RID: 2719
		[CompilerGenerated]
		private sealed class <>c__DisplayClass40_0
		{
			// Token: 0x06004E00 RID: 19968 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass40_0()
			{
			}

			// Token: 0x0400339D RID: 13213
			public int storeId;
		}

		// Token: 0x02000AA0 RID: 2720
		[CompilerGenerated]
		private sealed class <>c__DisplayClass42_0
		{
			// Token: 0x06004E01 RID: 19969 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass42_0()
			{
			}

			// Token: 0x06004E02 RID: 19970 RVA: 0x0014BC78 File Offset: 0x00149E78
			internal bool <GetPriceColName>b__0(KeyValuePair<int, string> c)
			{
				return c.Key == this.priceColId;
			}

			// Token: 0x0400339E RID: 13214
			public int priceColId;
		}

		// Token: 0x02000AA1 RID: 2721
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetArticuls>d__43 : IAsyncStateMachine
		{
			// Token: 0x06004E03 RID: 19971 RVA: 0x0014BC94 File Offset: 0x00149E94
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<int> result;
				try
				{
					if (num != 0)
					{
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<List<int>> awaiter;
						if (num != 0)
						{
							awaiter = (from i in (from i in this.<ctx>5__2.store_items.AsNoTracking()
							select i.articul).Distinct<int>()
							orderby i
							select i).ToListAsync<int>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<int>>, StoreModel.<GetArticuls>d__43>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<int>>);
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

			// Token: 0x06004E04 RID: 19972 RVA: 0x0014BE10 File Offset: 0x0014A010
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400339F RID: 13215
			public int <>1__state;

			// Token: 0x040033A0 RID: 13216
			public AsyncTaskMethodBuilder<List<int>> <>t__builder;

			// Token: 0x040033A1 RID: 13217
			private auseceEntities <ctx>5__2;

			// Token: 0x040033A2 RID: 13218
			private TaskAwaiter<List<int>> <>u__1;
		}
	}
}
