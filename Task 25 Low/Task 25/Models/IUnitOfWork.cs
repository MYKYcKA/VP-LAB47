using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_23.Models
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<ArticleModel> Articles { get; }
        IRepository<FeedbackModel> Feedbacks { get; }
        IRepository<QuizAnswerModel> Answers { get; }
        void Save();
    }
}
