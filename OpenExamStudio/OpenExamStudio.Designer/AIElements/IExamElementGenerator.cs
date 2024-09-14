using System.Threading.Tasks;

namespace OpenExamStudio.Designer
{
    public interface IExamElementGenerator
    {
        Task<string> GenerateExamAsync(ExamGenerationArgs examGenerationArgs);
        Task<string> GenerateExamQuestionAsync(string examTitle, Section contextSection);
    }
}