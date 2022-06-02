using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Task_23.Models
{
    public class ArticleRepository : IRepository<ArticleModel>
    {
        private TaskContext db;

        public ArticleRepository(TaskContext context)
        {
            db = context;
        }
        public void Create(ArticleModel item)
        {
            db.Articles.Add(item);
        }

        public void Delete(int id)
        {
            ArticleModel item = db.Articles.Find(id);
            if(item != null)
            {
                db.Articles.Remove(item);
            }
        }

        public IEnumerable<ArticleModel> Find(Func<ArticleModel, bool> predicate)
        {
            return db.Articles.Where(predicate).ToList();
        }

        public ArticleModel Get(int id)
        {
            return db.Articles.Find(id);
        }

        public IEnumerable<ArticleModel> GetAll()
        {
            return db.Articles;
        }

        public void Update(ArticleModel item)
        {
            db.Entry(item).State = EntityState.Modified; 
        }
    }
}