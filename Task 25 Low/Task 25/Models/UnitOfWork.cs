using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task_23.Models
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool disposedValue;
        private TaskContext db;
        private ArticleRepository articleRepository;
        private FeedbackRepository feedbackRepository;
        private QuizAnswerRepository answerRepository;

        public UnitOfWork(string connectionString)
        {
            db = new TaskContext(connectionString);
        }

        public IRepository<ArticleModel> Articles
        {
            get
            {
                if (articleRepository == null)
                    articleRepository = new ArticleRepository(db);
                return articleRepository;
            }
        }

        public IRepository<FeedbackModel> Feedbacks
        {
            get
            {
                if (feedbackRepository == null)
                    feedbackRepository = new FeedbackRepository(db);
                return feedbackRepository;
            }
        }

        public IRepository<QuizAnswerModel> Answers
        {
            get
            {
                if (answerRepository == null)
                    answerRepository = new QuizAnswerRepository(db);
                return answerRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}