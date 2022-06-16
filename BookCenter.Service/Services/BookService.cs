using AutoMapper;
using BookCenter.Data.IRepositories;
using BookCenter.Domain.Commons;
using BookCenter.Domain.Configurations;
using BookCenter.Domain.Entities.Books;
using BookCenter.Domain.Enums;
using BookCenter.Service.DTOs.Books;
using BookCenter.Service.Extensions;
using BookCenter.Service.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System.Linq.Expressions;

namespace BookCenter.Service.Services
{
    public class BookService : IBookService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public BookService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<BaseResponse<Book>> CreateAsync(BookForCreationDTO bookDto)
        {
            var response = new BaseResponse<Book>();

            // create after checking success
            var mappedCourse = mapper.Map<Book>(bookDto);

            var result = await unitOfWork.Books.CreateAsync(mappedCourse);

            await unitOfWork.SaveChangesAsync();

            response.Data = result;

            return response;
        }

        public async Task<BaseResponse<bool>> DeleteAsync(Expression<Func<Book, bool>> expression)
        {
            var response = new BaseResponse<bool>();

            // check for exist student
            var existBook = await unitOfWork.Books.GetAsync(expression);
            if (existBook is null)
            {
                response.Error = new ErrorResponse(404, "Book not found");
                return response;
            }
            existBook.Delete();

            await unitOfWork.Books.UpdateAsync(existBook);

            await unitOfWork.SaveChangesAsync();

            response.Data = true;

            return response;
        }

        public async Task<BaseResponse<IEnumerable<Book>>> GetAllAsync(PaginationParams @params, Expression<Func<Book, bool>> expression = null)
        {
            var response = new BaseResponse<IEnumerable<Book>>();

            var books = await unitOfWork.Books.GetAllAsync(expression => expression.State != ItemState.Deleted);

            response.Data = books.ToPagedList(@params);

            if (response.Data is null)
            {
                response.Error = new ErrorResponse(404, "Books not found");
            }

            return response;
        }

        public async Task<BaseResponse<Book>> GetAsync(Expression<Func<Book, bool>> expression)
        {
            var response = new BaseResponse<Book>();

            var books = await unitOfWork.Books.GetAsync(expression);
            if (books is null)
            {
                response.Error = new ErrorResponse(404, "Book not found");
                return response;
            }

            response.Data = books;

            return response;
        }

        public async Task<BaseResponse<Book>> UpdateAsync(Guid id, BookForCreationDTO bookDto)
        {
            var response = new BaseResponse<Book>();

            // check for exist student
            var book = await unitOfWork.Books.GetAsync(p => p.Id == id && p.State != ItemState.Deleted);
            if (book is null)
            {
                response.Error = new ErrorResponse(404, "Book not found");
                return response;
            }


            book.ISBN = bookDto.ISBN;
            book.Title = bookDto.Title;
            book.Authors = bookDto.Authors;
            book.NumberOfPages = bookDto.NumberOfPages;
            book.Publisher = bookDto.Publisher;
            book.DatePublished = bookDto.DatePublished;
            
            book.Update();

            var result = await unitOfWork.Books.UpdateAsync(book);

            await unitOfWork.SaveChangesAsync();

            response.Data = result;

            return response;
        }
    }
}
