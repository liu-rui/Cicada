
### 以下是在使用LinQ查询的过程中，推荐给大家使用的查询方式：

 * 一、查询类型：  
    1、根据主键Id查询：  
        var bookSet = DbContext.Set<Book>().Find(bookId);  
	2、根据非主键查询：  
	    var model = DbContext.Set<Book>().Single(s => s.Id == Int32.Parse(id));
	    var model = DbContext.Set<Book>().Where(s => s.Id == id).Select(s => new Book { Name = s.Name, Price = s.Price });
		
	3、查询分页：
	    var bookDataSet = DbContext.Set<Book>();
	    var queryable=  bookDataSet.Skip((pageIndex - 1) * pageSize).Take(pageSize).OrderBy(s => s.Id);
        if (id != 0)
        {
            queryable = queryable.Where(s => s.Id == id);
        }
        if (!string.IsNullOrEmpty(name))
        {
            queryable = queryable.Where(s => s.Name.Contains(name));
        }
        if (price != 0)
        {
            queryable = queryable.Where(s => s.Price == price);
        }
	    var list = bookDataSet.toList();
        var totalCount = bookDataSet.Count();
	4、多表级联查询问题：
	1、先查主表，主表信息查询出来之后，再根据主表信息去辅助表查询，然后组合成一个自己想要的数据集。
		

 * 二、删除类型：
	    var model = DbContext.Set<Book>().Where(s => s.Id == id).delete();
		
 *	三、更新类型：
	    int result = db.Book.Where(s => s.Id == id).Update(s => new Book { Name = name });
		
 * 四、事物操作：
    	public bool AddTwoInfo()
            {
                var book = new Book { BookAuthor = "路遥", BookTitle = "平凡的世界", BookData = DateTime.Now };
                var userInfo = new UserInfo { UserCode = "luyao001", UserName = "路遥" };
                int result = 0;
                using (var transaction = new TransactionScope())
                {
                    //新增第一条数据
                    DbContext.Set<Book>().Add(book);
                    //新增第二条数据
                    DbContext.Set<UserInfo>().Add(userInfo);
    
                    result= DbContext.SaveChanges();
                    //提交事务
                    transaction.Complete();
                }
                return result > 0 ? true : false;
            }
 * 五、EF使用注意的点：
        1、数据库的名字和数据表的名字不能用点（.）组合，不然会报错。
        2、var model = DbContext.Set<Book>().Where(s => s.Id == AAA).update(...)语句使用请注意：
            a.根据主键更新数据
            b.主键的数据类型是String类型
            c.如果a和b这两个条件都满足，使用时变量AAA就得定义在外面，否则出现异常。
 

