using System;
using System.Collections.Generic;
using System.Text;

namespace CS
{
 public   class CLL_StatementList: CLL_Statement
    {
        private CLL_Statement m_currentStatement;
        private CLL_Statement m_nextStatement;
        public CLL_StatementList(Morozov.Parsing.MyParserContext context, CLL_Statement currentStatement, CLL_Statement nextStatement) :base(context)
        {
            this.context = context;
            m_currentStatement = currentStatement;
            m_nextStatement = nextStatement;
        }
        public override void Execute()
        {
            m_currentStatement.Execute();
            if (m_nextStatement != null)
            {
                m_nextStatement.Execute();
            }
        }
    }
}
