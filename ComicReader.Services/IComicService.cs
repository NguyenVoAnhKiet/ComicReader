// ComicReader.Services/IComicService.cs
using ComicReader.Models;

namespace ComicReader.Services
{
    public interface IComicService
    {
        Task<IEnumerable<Comic>> GetAllComicsAsync();
        Task<Comic> GetComicByIdAsync(int id);
        Task<Chapter> GetChapterAsync(int comicId, int chapterId);
        Task SaveReadingProgressAsync(int comicId, int chapterId, int pageNumber);
    }
}

