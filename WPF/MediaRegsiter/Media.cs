using System;

namespace MediaRegister
{
    // Klass för det som är gemensamt
    public class Media
    {
        // Intern variabel
        public string _titel;

        // Metoder
        public virtual string TillText()
        {
            return _titel;
        }
    }
}