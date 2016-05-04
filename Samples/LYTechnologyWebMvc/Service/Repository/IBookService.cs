using System.Collections.Generic;
using Service.Models;
using Cicada.Data.EntityFramework;

namespace Service.Repository
{
    public interface IBookService : ICommonDbOperation<Book>
    {
        /// <summary>
        /// 示例一个框架没有集成的方法
        /// </summary>
        /// <returns></returns>
        IList<Book> GetBookList();
    }
}
