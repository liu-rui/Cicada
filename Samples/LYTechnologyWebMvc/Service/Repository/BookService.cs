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
            var dd= DbContext.Set<Book>();
            return DbContext.Set<Book>().ToList();
            
        }
    }
}
