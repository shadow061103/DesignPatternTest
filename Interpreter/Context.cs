using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
   public sealed class Context
    {
        private string _statement;
        private int _data;

        public Context(string statement)
        {
            this._statement = statement;
        }

        public string Statement
        {
            get { return this._statement; }
            set { this._statement = value; }
        }

        public int Data
        {
            get { return this._data; }
            set { this._data = value; }
        }
    }
}
