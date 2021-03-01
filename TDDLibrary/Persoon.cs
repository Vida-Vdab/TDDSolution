using System;
using System.Collections.Generic;
using System.Linq;


namespace TDDLibrary
{
    public class Persoon
    {
        private readonly List<string> voornamen;
        public Persoon(List<string> voornamen)
        {
            //throw new NotImplementedException();
            if (voornamen == null)
            {
                throw new ArgumentNullException();
            }
            if (voornamen.Count == 0)
            {
                throw new ArgumentException();
            }
            foreach (var voornaam in voornamen)
            {
                if (voornaam == string.Empty)

                    throw new ArgumentException();
            }
            if (voornamen.Count != voornamen.Distinct().Count())
            {
                throw new ArgumentException();
            }
            foreach (var voornaam in voornamen)
            {
                if (voornaam.Length == 0)
                    throw new ArgumentException();
            }

            this.voornamen = voornamen;
        }
        public override string ToString()
        {
            //throw new NotImplementedException();
            return string.Join(' ', voornamen);
        }
    }
}
