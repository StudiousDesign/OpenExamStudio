using DevExpress.Mvvm.Native;
using OpenAI_API;
using OpenAI_API.Chat;
using OpenAI_API.Models;
using System;
using static DevExpress.Data.Utils.Registry.SafeRegistry;
using static DevExpress.XtraBars.Docking2010.Views.BaseRegistrator;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Security.Policy;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OpenExamStudio.Designer
{
    public class OpenAIExamElementGenerator : IExamElementGenerator
    {
        private string _apiKey;

        public OpenAIExamElementGenerator(string apiKey)
        {
            _apiKey = apiKey;
        }

        public async Task<string> GenerateExamAsync()
        {
            var prompt = GetFullExamPrompt(sectionCount: 1, questionsPerSection: 2);
            return await GenerateChatCompletionAsync(prompt);
        }

        public async Task<string> GenerateExamQuestionAsync(string examTitle, Section contextSection)
        {
            var prompt = GetQuestionPrompt(examTitle, contextSection);
            return await GenerateChatCompletionAsync(prompt);
        }

        private async Task<string> GenerateChatCompletionAsync(string prompt)
        {
            var api = new OpenAIAPI(_apiKey);
            try
            {
                ChatRequest chatRequest = CreateChatRequest(prompt);
                var result = await api.Chat.CreateChatCompletionAsync(chatRequest);
                return result.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private ChatRequest CreateChatRequest(string prompt)
        {
            return new ChatRequest()
            {
                Model = Model.ChatGPTTurbo,
                Temperature = 0.0,
                MaxTokens = 4096,
                ResponseFormat = ChatRequest.ResponseFormats.JsonObject,
                Messages = new ChatMessage[]
                {
            new ChatMessage(ChatMessageRole.System, "You are a helpful assistant designed to output JSON."),
            new ChatMessage(ChatMessageRole.User, prompt)
                }
            };
        }



        private string GetQuestionPrompt(string examTitle, Section contextSection)
        {
            string completePrompt = $"strictly using the follwoing json schema portion that represents a question in my exam simulator {_questionPromptSchema}{Environment.NewLine}{Environment.NewLine} generate me a new question that would compliment the existing questions in the following exam section. {JsonConvert.SerializeObject(contextSection)}; the exam is called {examTitle}";
            return completePrompt;
        }

        private string GetFullExamPrompt(int sectionCount, int questionsPerSection)
        {
            string completePrompt = $"strictly using the follwoing json schema; {Environment.NewLine}{Environment.NewLine}{_fullExamPromptSchema} generate me a {sectionCount} section quiz on any topic you like. each section should have {questionsPerSection} questions in it and at least one of those questions in each section should be multipart and therfore have at least allowedSelections greater than 1..";
            return completePrompt;
        }


        #region schema
        private string _questionPromptSchema = @"{
  ""type"": ""object"",
  ""properties"": {
    ""allowedSelections"": {
      ""type"": ""number""
    },
    ""answerOptions"": {
      ""type"": ""array"",
      ""items"": {
        ""type"": ""object"",
        ""properties"": {
          ""answerId"": {
            ""type"": ""number""
          },
          ""displayText"": {
            ""type"": ""string""
          },
          ""explanation"": {
            ""type"": ""string""
          },
          ""isCorrect"": {
            ""type"": ""boolean""
          }
        },
        ""required"": [""answerId"", ""displayText"", ""explanation"", ""isCorrect""]
      }
    },
    ""correctAnswer"": {
      ""type"": ""string""
    },
    ""sectionId"": {
      ""type"": ""number""
    },
    ""questionId"": {
      ""type"": ""number""
    },
    ""title"": {
      ""type"": ""string""
    },
    ""text"": {
      ""type"": ""string""
    },
    ""type"": {
      ""type"": ""string"",
      ""enum"": [""multiple-choice""]
    },
    ""points"": {
      ""type"": ""number""
    }
  },
  ""required"": [
    ""allowedSelections"",
    ""answerOptions"",
    ""correctAnswer"",
    ""sectionId"",
    ""questionId"",
    ""title"",
    ""text"",
    ""type"",
    ""points""
  ]
}
";

        private string _fullExamPromptSchema = @"{
  ""$schema"": ""http://json-schema.org/draft-07/schema#"",
  ""title"": ""Generated schema for Root"",
  ""type"": ""object"",
  ""properties"": {
    ""title"": {
      ""type"": ""string""
    },
    ""description"": {
      ""type"": ""string""
    },
    ""author"": {},
    ""duration"": {
      ""type"": ""number""
    },
    ""metadata"": {
      ""type"": ""object"",
      ""properties"": {
        ""createdBy"": {
          ""type"": ""string""
        },
        ""dateCreated"": {
          ""type"": ""string""
        }
      },
      ""required"": [
        ""createdBy"",
        ""dateCreated""
      ]
    },
    ""sections"": {
      ""type"": ""array"",
      ""items"": {
        ""type"": ""object"",
        ""properties"": {
          ""sectionId"": {
            ""type"": ""number""
          },
          ""title"": {
            ""type"": ""string""
          },
          ""questions"": {
            ""type"": ""array"",
            ""items"": {
              ""type"": ""object"",
              ""properties"": {
                ""allowedSelections"": {
                  ""type"": ""number""
                },
                ""answerOptions"": {
                  ""type"": ""array"",
                  ""items"": {
                    ""type"": ""object"",
                    ""properties"": {
                      ""answerId"": {
                        ""type"": ""number""
                      },
                      ""displayText"": {
                        ""type"": ""string""
                      },
                      ""explanation"": {
                        ""type"": ""string""
                      },
                      ""isCorrect"": {
                        ""type"": ""boolean""
                      }
                    },
                    ""required"": [
                      ""answerId"",
                      ""displayText"",
                      ""explanation"",
                      ""isCorrect""
                    ]
                  }
                },
                ""correctAnswer"": {
                  ""type"": ""string""
                },
                ""sectionId"": {
                  ""type"": ""number""
                },
                ""questionId"": {
                  ""type"": ""number""
                },
                ""title"": {
                  ""type"": ""string""
                },
                ""text"": {
                  ""type"": ""string""
                },
                ""type"": {
                  ""type"": ""string"",
                  ""enum"": [""multiple-choice""]
                },
                ""points"": {
                  ""type"": ""number""
                }
              },
              ""required"": [
                ""allowedSelections"",
                ""answerOptions"",
                ""correctAnswer"",
                ""sectionId"",
                ""questionId"",
                ""title"",
                ""text"",
                ""type"",
                ""points""
              ]
            }
          }
        },
        ""required"": [
          ""sectionId"",
          ""title"",
          ""questions""
        ]
      }
    },
    ""gradingSchema"": {
      ""type"": ""object"",
      ""properties"": {
        ""passingScore"": {
          ""type"": ""number""
        }
      },
      ""required"": [
        ""passingScore""
      ]
    },
    ""settings"": {
      ""type"": ""object"",
      ""properties"": {
        ""shuffleQuestions"": {
          ""type"": ""boolean""
        },
        ""shuffleOptions"": {
          ""type"": ""boolean""
        }
      },
      ""required"": [
        ""shuffleQuestions"",
        ""shuffleOptions""
      ]
    }
  },
  ""required"": [
    ""title"",
    ""description"",
    ""author"",
    ""duration"",
    ""metadata"",
    ""sections"",
    ""gradingSchema"",
    ""settings""
  ]
}";
        #endregion
    }
}