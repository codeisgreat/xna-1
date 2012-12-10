using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main_XNA_Game
{
    static class Helper
    {
        public static String GetError(Exception ex)
        {
            return ex.Message.ToString() + " " + ex.InnerException.ToString() + "";
        }
    }
}
