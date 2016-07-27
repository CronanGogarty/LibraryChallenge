using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryChallengeCore
{
    public enum CheckedOutResultStatus
    {
        Ok,
        Error
    }

    public class CheckoutResult
    {
        public CheckedOutResultStatus CheckedOutResultStatus { get; set; }
        public string Message { get; set; }
    }
}
