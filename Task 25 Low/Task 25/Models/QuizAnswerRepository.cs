using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Task_23.Models
{
    public class QuizAnswerRepository : IRepository<QuizAnswerModel>
    {

        private TaskContext db;

        public QuizAnswerRepository(TaskContext context)
        {
            db = context;

        }
        public void Create(QuizAnswerModel item)
        {
            db.Answers.Add(item);

        }

        public void Delete(int id)
        {
            QuizAnswerModel item = db.Answers.Find(id);
            if (item != null)
            {
                db.Answers.Remove(item);
            }
        }

        public IEnumerable<QuizAnswerModel> Find(Func<QuizAnswerModel, bool> predicate)
        {
            return db.Answers.Where(predicate).ToList();
        }

        public QuizAnswerModel Get(int id)
        {
            return db.Answers.Find(id);
        }

        public IEnumerable<QuizAnswerModel> GetAll()
        {
            return db.Answers;
        }

        public void Update(QuizAnswerModel item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
