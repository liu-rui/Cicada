using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Service.Repository;

namespace WebMvc.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;

        #region 构造函数

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        #endregion

        /// <summary>
        /// 测试获取一条记录（调用的是系统集成的方法）
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public int GetBook(int bookId)
        {
            var item = _bookService.Find(bookId);

            return 1;
        }

        /// <summary>
        /// 测试获取一个泛型数据（调用自己定义的方法）
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public int GetBookList()
        {
            var list = _bookService.GetBookList();

            return 2;
        }

    }
}