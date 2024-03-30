namespace Data.Models.Interfaces
{
    using Models;

    /// <summary>
    /// Represents the interface for accessing the blog API.
    /// Contains All the methods we need to get, save, and delete blog posts, tags, and categories 
    /// </summary>
    public interface IBlogApi
    {
        Task<int> GetBlogPostCountAsync();

        Task<List<BlogPost>?> GetBlogPostsAsync(int numberofposts, int startindex);

        Task<List<Category>?> GetCategoriesAsync();

        Task<List<Tag>?> GetTagsAsync();

        Task<BlogPost?> GetBlogPostAsync(string id);

        Task<Category?> GetCategoryAsync(string id);

        Task<Tag?> GetTagAsync(string id);

        Task<BlogPost?> SaveBlogPostAsync(BlogPost item);

        Task<Category?> SaveCategoryAsync(Category item);

        Task<Tag?> SaveTagAsync(Tag item);

        Task DeleteBlogPostAsync(string id);

        Task DeleteCategoryAsync(string id);

        Task DeleteTagAsync(string id);

        Task InvalidateCacheAsync();
    }
}