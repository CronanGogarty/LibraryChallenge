using System;
using System.Collections.Generic;

namespace LibraryChallengeCore
{
    public interface ILibraryBookFineCalculator
    {
        decimal CalculateTotalFine(DateTime today, List<ILibraryBook> books);
    }
}