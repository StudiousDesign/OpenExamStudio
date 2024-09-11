using System.Threading.Tasks;

namespace OpenExamStudio.Designer
{
    public interface IExamElementGenerator
    {
        Task<string> GenerateExamAsync();
        Task<string> GenerateExamQuestionAsync(string examTitle, Section contextSection);
    }
}