using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiLaTrieuPhu.DAL
{
    internal class Respositories
    {
        // repo này chỉ để load câu hỏi ra 
        GameDBContext context;
        public Respositories()
        {
            context = new GameDBContext();
        }
        public List<Question>  GetAllQuestion()
        {
            return context.Questions.ToList();
        }
    }
}
