using TheBlogProject.ViewModels;

namespace TheBlogProject.Services
{
    public interface IOption<T>
    {
        MailSettings Value { get; }
    }
}