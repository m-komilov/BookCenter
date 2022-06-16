using BookCenter.Domain.Commons;
using BookCenter.Domain.Configurations;
using BookCenter.Domain.Entities.Books;
using BookCenter.Service.DTOs.Books;
using System.Linq.Expressions;

#pragma warning disable
namespace BookCenter.Service.Interfaces
{
    public interface IBookService
    {
        Task<BaseResponse<Book>> CreateAsync(BookForCreationDTO bookDto);
        Task<BaseResponse<Book>> GetAsync(Expression<Func<Book, bool>> expression);
        Task<BaseResponse<IEnumerable<Book>>> GetAllAsync(PaginationParams @params, Expression<Func<Book, bool>> expression = null);
        Task<BaseResponse<bool>> DeleteAsync(Expression<Func<Book, bool>> expression);
        Task<BaseResponse<Book>> UpdateAsync(Guid id, BookForCreationDTO bookDto);
    }
}
