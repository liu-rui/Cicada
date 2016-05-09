
### 以下是在使用LinQ查询的过程中，推荐给大家使用的查询方式：

	一、查询类型：
		1、根据主键Id查询：
			var bookSet = DbContext.Set<Book>().Find(bookId);
		2、根据非主键查询：
			var model = DbContext.Set<Book>().ToList().Single(s => s.Id == Int32.Parse(id));
			var model = DbContext.Set<Book>().Where(s => s.Id == id).Select(s => new Book { Name = s.Name, Price = s.Price });
		
		3、查询分页：
			var queryable = DbContext.Set<Book>().Skip((pageIndex - 1) * pageSize).Take(pageSize).OrderBy(s => s.Id);
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
                totalCount = queryable.Count();
		4、多表级联查询问题：
			1、先查主表，主表信息查询出来之后，再根据主表信息去辅助表查询，然后组合成一个自己想要的数据集。
		

	二、删除类型：
		var model = DbContext.Set<Book>().Where(s => s.Id == id).delete();
		
	三、更新类型：
		int result = db.Book.Where(s => s.Id == id).Update(s => new Book { Name = name });
 

