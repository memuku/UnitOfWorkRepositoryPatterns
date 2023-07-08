using Library.Domain.Entities;
using UnitOfWorkRepositoryPatterns.Dto;

namespace UnitOfWorkRepositoryPatterns.Service
{
    public interface IBookService
    {
        public Task<IEnumerable<Book>> GetAll();
        public Task AddBook(BookDto book);
    }
}
