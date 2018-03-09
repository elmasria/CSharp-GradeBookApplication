
namespace GradeBook.GradeBooks
{
    public class RankedGradeBook  : BaseGradeBook 
    {
         publc RankedGradeBook (string name) : base(name)
         {
            Type = GradeBookType.Ranked;
         }
       
    }
}
