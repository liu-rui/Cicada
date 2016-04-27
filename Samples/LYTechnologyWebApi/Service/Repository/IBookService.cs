using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Models;

namespace Service.Repository
{
    /// <summary>
    /// 书本接口
    /// </summary>
    public interface IBookService
    {
        IList<Book> GetBookList();

        Book GetBookInfo(int bookId);
    }
}
