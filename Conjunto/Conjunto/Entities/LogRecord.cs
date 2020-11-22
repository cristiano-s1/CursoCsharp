using System;
using System.Collections.Generic;
using System.Text;

namespace Conjunto.Entities
{
    class LogRecord
    {
        public string Username { get; set; }
        public DateTime Instant { get; set; }

        //GetHashCode
        public override int GetHashCode()
        {
            //Retornar a igualdade do username
            return Username.GetHashCode();
        }


        //Equals
        public override bool Equals(object obj)
        {
            //Testar se o obj é do tipo object
            if (!(obj is LogRecord))
            {
                return false;
            }

            //Tipo object
            LogRecord other = obj as LogRecord;

            //LogRecord é igual a outro LogRecord quando o Username for igual
            return Username.Equals(other.Username);
        }
    }
}
