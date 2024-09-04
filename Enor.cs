using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFile;

namespace MidTerm_New
{
    internal class Enor
    {
        enum Status { Norm, Abnorm }


        //Attributes
        private Status _st;
        private Stat _e;
        private TextFileReader _x;
        private Data _curr;
        private bool _end;

        public Enor(string path)
        {
            _x = new TextFileReader(path);
        }

        private void read()
        {
            _st = ((_x.ReadInt(out _e.month) && _x.ReadInt(out _e.day) && _x.ReadInt(out _e.traffic)) ? Status.Norm : Status.Abnorm);
           

        }

        public void first()
        {
            read();
            next();
        }


        public void next()
        {
            _end = (_st == Status.Abnorm);
            if (!_end)
            {
                //Summation
                _curr.month = _e.month;
                _curr.count = 0;

                while (_st == Status.Norm && _e.month == _curr.month)
                {
                    _curr.count += _e.traffic;
                    read();
                }
            }
           
        }

        public Data current()
        {
            return _curr;
        }

        public bool end()
        {
            return _end;
        }
    }
}
