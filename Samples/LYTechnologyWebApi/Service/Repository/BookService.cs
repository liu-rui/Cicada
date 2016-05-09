using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cicada.Data.EntityFramework;
using Service.Models;

namespace Service.Repository
{
    /// <summary>
    /// 书本方法实现
    /// </summary>
    public class BookService : IBookService
    {
        #region 重构初始化

        private readonly IDbContext _dbcontext;

        public BookService(IDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        #endregion

        /// <summary>
        /// 获取所有书本资料
        /// </summary>
        /// <returns></returns>
        public IList<Book> GetBookList()
        {
            var bookSet = _dbcontext.Set<Book>();
            var bookList = bookSet.ToList();
            return bookList;
        }
        /// <summary>
        /// 获取一本资料
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        public Book GetBookInfo(int bookId)
        {
            var book = _dbcontext.Set<Book>().Find(bookId);
            var bookSet = _dbcontext.Set<Book>();



            return book;
        }

    }
}
