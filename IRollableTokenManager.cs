using System;
using System.Collections.Generic;
using System.Text;

namespace Christian_Gonzalez_Project
{
    internal interface IRollableTokenManager
    {
            string RollTokens(List<int> tokenInfo);
            string GetStatistics();
            string SaveHistory(string filepath);
    }
}
