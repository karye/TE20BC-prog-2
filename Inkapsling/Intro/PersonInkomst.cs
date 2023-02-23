using System;

namespace Intro
{
    // Hantera en persons inkomstsuppgifter
    public class PersonInkomst
    {
        // 5 variabler
        private string _namn;
        //private int _inkomst;
        //private int _timmar;
        private bool _ärAnställd;
        protected bool _ärMyndig;

        // 3 egenskaper
        public string Namn
        {
            get
            {
                return _namn;
            }
            set
            {
                _namn = value;
            }
        }
        public int Inkomst { get; private set; }
        public int Timmar { get; set; }
    }

    public class PersonData : PersonInkomst
    {
        // Här ser man private _ärAnställd är osynlig
        // Medans protected _ärMyndig syns
        public PersonData()
        {
            _ärAnställd = true;
            _ärMyndig = false;
        }
    }
}