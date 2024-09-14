using System;
using System.Threading.Tasks;

namespace OpenExamStudio.Designer
{
    public class ManualTransferElementGenerator : IExamElementGenerator
    {

        public async Task<string> GenerateExamAsync(ExamGenerationArgs args)
        {
            return await Task.FromResult(_gptFullExamResponse);
        }

        public Task<string> GenerateExamQuestionAsync(string examTitle, Section contextSection)
        {
            return Task.FromResult(_gptQuestionResponse);
        }

        private string _gptQuestionResponse = @"";

        private string _gptFullExamResponse = @"{
  ""title"": ""History Quiz"",
  ""description"": ""Test your knowledge on historical events"",
  ""author"": ""Assistant"",
  ""duration"": 10,
  ""metadata"": {
    ""createdBy"": ""Assistant"",
    ""dateCreated"": ""2022-10-15""
  },
  ""sections"": [
    {
      ""sectionId"": 1,
      ""title"": ""Ancient Civilizations"",
      ""questions"": [
        {
          ""allowedSelections"": 1,
          ""answerOptions"": [
            {
              ""answerId"": 1,
              ""displayText"": ""Egypt"",
              ""explanation"": ""Egypt is known for the pyramids and the Nile River."",
              ""isCorrect"": true
            },
            {
              ""answerId"": 2,
              ""displayText"": ""Greece"",
              ""explanation"": ""Greece is famous for its philosophy and democracy."",
              ""isCorrect"": false
            },
            {
              ""answerId"": 3,
              ""displayText"": ""China"",
              ""explanation"": ""China has a long history of dynasties and inventions."",
              ""isCorrect"": false
            }
          ],
          ""correctAnswer"": ""Egypt"",
          ""sectionId"": 1,
          ""questionId"": 1,
          ""title"": ""Which ancient civilization built the pyramids?"",
          ""text"": ""Choose the correct civilization that built the pyramids."",
          ""type"": ""multiple-choice"",
          ""points"": 5
        },
        {
          ""allowedSelections"": 2,
          ""answerOptions"": [
            {
              ""answerId"": 1,
              ""displayText"": ""Rome"",
              ""explanation"": ""Rome was known for its vast empire and engineering feats."",
              ""isCorrect"": true
            },
            {
              ""answerId"": 2,
              ""displayText"": ""Persia"",
              ""explanation"": ""Persia was a powerful empire in ancient times."",
              ""isCorrect"": true
            },
            {
              ""answerId"": 3,
              ""displayText"": ""Maya"",
              ""explanation"": ""The Maya civilization thrived in Mesoamerica."",
              ""isCorrect"": false
            }
          ],
          ""correctAnswer"": ""Rome, Persia"",
          ""sectionId"": 1,
          ""questionId"": 2,
          ""title"": ""Name two ancient civilizations known for their empires."",
          ""text"": ""Select two civilizations that were known for their vast empires."",
          ""type"": ""multiple-select"",
          ""points"": 10
        }
      ]
    }
  ],
  ""gradingSchema"": {
    ""passingScore"": 60
  },
  ""settings"": {
    ""shuffleQuestions"": true,
    ""shuffleOptions"": true
  }
}";
    }
}