

namespace webEval.Models
{
    using System.Data.Entity;
    public class DataContext: DbContext
    {
        public DataContext() : base("DefaultConnection") { }

        public System.Data.Entity.DbSet<Evaluation.Models.Student> Students { get; set; }
    }
}