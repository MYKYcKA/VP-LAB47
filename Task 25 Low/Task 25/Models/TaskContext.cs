using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Task_23.Models
{
    public class TaskContext : DbContext
    {
        public DbSet<ArticleModel> Articles  { get; set; }
        public DbSet<FeedbackModel> Feedbacks { get; set; }
        public DbSet<QuizAnswerModel> Answers { get; set; }
        static TaskContext()
        {
            Database.SetInitializer<TaskContext>(new TaskDbInitializer());
        }
        public TaskContext(string connectionString)
            : base(connectionString)
        {
        }
    }
}