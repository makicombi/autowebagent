using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using awaDAL;

namespace awaApplication
{
    class Validator
    {
        private DAL dal;
        private static Validator instance;
        enum CONDITION_TYPE { CHECKED, EQUAL, FALSE, TRUE, VALUE, SELECTED }    
        private Validator()
        {
            dal = new DAL();
        }
        static public Validator Instance()
        {
            if (instance == null)
                instance = new Validator();
            return instance;
        }

        public bool ValidateCondition(ICondition condition, out string cause)
        {
            cause = "OK";
            return true;
        }
        public bool ValidateAction(ICondition action, out string cause)
        {
            cause = "OK";
            return true;
        }
    }
}
