using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    class StandardGradeBook : BaseGradeBook //klasa dziedzicząca
    {
        public StandardGradeBook(string name) : base(name) //konstruktor
        {
            Type = Enums.GradeBookType.Standard;
        }
    }
}
