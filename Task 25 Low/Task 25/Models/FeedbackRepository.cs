using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Task_23.Models
{
    public class FeedbackRepository : IRepository<FeedbackModel>
    {
        private TaskContext db;

        public FeedbackRepository(TaskContext context)
        {
            db = context;
            
        }
        public void Create(FeedbackModel item)
        {
            db.Feedbacks.Add(item);
        }

        public void Delete(int id)
        {
            FeedbackModel item = db.Feedbacks.Find(id);
            if(item != null)
            {
                db.Feedbacks.Remove(item);
            }
        }

        public IEnumerable<FeedbackModel> Find(Func<FeedbackModel, bool> predicate)
        {
            return db.Feedbacks.Where(predicate).ToList();
        }

        public FeedbackModel Get(int id)
        {
            return db.Feedbacks.Find(id);
        }

        public IEnumerable<FeedbackModel> GetAll()
        {
            return db.Feedbacks;
        }

        public void Update(FeedbackModel item)
        {
            db.Entry(item).State = EntityState.Modified; 
        }
    }
}