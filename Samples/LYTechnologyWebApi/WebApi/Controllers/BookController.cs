using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Service.Models;
using Service.Repository;

namespace WebApi.Controllers
{
    public class BookController : ApiController
    {
        #region 重构初始化

        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        #endregion


        /// <summary>
        /// 获取所有书籍
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IList<Book> GetBookList()
        {
            return _bookService.GetBookList();
        }

        /// <summary>
        /// 获取一本书籍
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public Book GetBookInfo(int id)
        {
            return _bookService.GetBookInfo(id);
        }
    }
}
