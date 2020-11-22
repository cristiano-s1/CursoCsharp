
//Indicando namespace como System
namespace System
{
   static class StringExtensions
    {
        public static string Cut(this string thisObj, int count)
        {
            //Lógica para cortar a string
            if (thisObj.Length <= count)
            {
                //String original
                return thisObj;
            }
            else
            {
                //Recortar a string
                return thisObj.Substring(0, count) + "...";

            }
        }
    }
}
