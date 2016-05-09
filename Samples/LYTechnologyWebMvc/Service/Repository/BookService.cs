using System.Collections.Generic;
using System.Linq;
using Cicada.Data.EntityFramework;
using Service.Models;

namespace Service.Repository
{
    public class BookService : CommonDbOperation<Book>, IBookService
    {
        /// <summary>
        /// 示例一个框架没有集成的方法
        /// </summary>
        /// <returns></returns>
        public IList<Book> GetBookList()
        {
            DbContext.Set<Book>().Where(s => s.Id == 1).Select();
            return DbContext.Set<Book>().ToList();
            
        }
    }
}
