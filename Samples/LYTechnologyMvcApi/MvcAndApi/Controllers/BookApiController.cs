using System.Linq;
using System.Web.Http;
using Service.Repository;

namespace MvcAndApi.Controllers
{
    public class BookApiController : ApiController
    {
        private readonly IBookService _bookService;

        #region 构造函数

        public BookApiController(IBookService bookService)
        {
            _bookService = bookService;
        }

        #endregion

        /// <summary>
        /// 调用的是系统集成的方法
        /// </summary>
        /// <returns></returns>
        public int Get()
        {
            var count = _bookService.GetBookList().Count();

            return count;
        }

        /// <summary>
        /// 调用自己定义的方法
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        public int Get(int bookId)
        {
            var count = _bookService.Find(bookId);

            return 2;
        }

    }
}
