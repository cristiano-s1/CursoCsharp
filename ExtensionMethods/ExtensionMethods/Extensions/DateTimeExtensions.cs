using System;
using System.Globalization;

//Podemos colocar System no mesmo namespace, assim não é preciso indicar o caminho no programa principal.
//EX: namespace System
namespace ExtensionMethods.Extensions
{
    //Colocar static antes da classe
    static class DateTimeExtensions
    {
        //Método de extension do tipo date time
        public static string ElapsedTime(this DateTime thisObj)//thisObj - Esse é o objeto que vamos trabalhar
        {
            //Criar objeto TimeSpan que representa uma duração
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            //Fazer a logica para formatar o objeto em horas ou em dias
            if (duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + "hours";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + "days";
            }

        }
    }
}
