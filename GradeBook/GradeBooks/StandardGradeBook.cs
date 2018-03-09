using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook 
    {
         publc StandardGradeBook(string name) : base(name)
         {
            Type = GradeBookType.Standard;
         }
       
    }
}
