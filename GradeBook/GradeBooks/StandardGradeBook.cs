using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook //klasa dziedzicząca
    {
        public StandardGradeBook(string name, bool IsWeighted) : base(name, IsWeighted) //konstruktor
        {
            Type = Enums.GradeBookType.Standard;
        }
    }
}
