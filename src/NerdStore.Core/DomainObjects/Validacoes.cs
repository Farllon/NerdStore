using System;
using System.Text.RegularExpressions;

namespace NerdStore.Core.DomainObjects
{
    public class Validacoes
    {
        public static void ValidarSeIgual(object object1, object object2, string message)
        {
            if (object1.Equals(object2))
            {
                throw new DomainException(message);
            }
        }

        public static void ValidarSeDiferente(object object1, object objetc2, string message)
        {
            if (!object1.Equals(objetc2))
            {
                throw new DomainException(message);
            }
        }

        public static void ValidarCaracteres(string valor, int maximo, string message)
        {
            var length = valor.Trim().Length;

            if (length > maximo)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidarCaracteres(string valor, int minimo, int maximo, string message)
        {
            var lenght = valor.Trim().Length;

            if (lenght < minimo || lenght > maximo)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidarExpressao(string pattern, string valor, string message)
        {
            var regex = new Regex(pattern);

            if (!regex.IsMatch(valor))
            {
                throw new DomainException(message);
            }
        }

        public static void ValidarSeVazio(string valor, string message)
        {
            if (valor == null || valor.Trim().Length == 0)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidarSeNulo(object object1, string message)
        {
            if (object1 == null)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidarMinimoMaximo(double valor, double minimo, double maximo, string message)
        {
            if (valor < minimo || valor > maximo)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidarMinimoMaximo(float valor, float minimo, float maximo, string message)
        {
            if (valor < minimo || valor > maximo)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidarMinimoMaximo(int valor, int minimo, int maximo, string message)
        {
            if (valor < minimo || valor > maximo)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidarMinimoMaximo(long valor, long minimo, long maximo, string message)
        {
            if (valor < minimo || valor > maximo)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidarMinimoMaximo(decimal valor, decimal minimo, decimal maximo, string message)
        {
            if (valor < minimo || valor > maximo)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidarSeMenorQue(double valor, double minimo, string message)
        {
            if (valor < minimo)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidarSeMenorQue(float valor, float minimo, string message)
        {
            if (valor < minimo)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidarSeMenorQue(int valor, int minimo, string message)
        {
            if (valor < minimo)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidarSeMenorQue(long valor, long minimo, string message)
        {
            if (valor < minimo)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidarSeMenorQue(decimal valor, decimal minimo, string message)
        {
            if (valor < minimo)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidarSeFalso(bool boolValue, string message)
        {
            if (!boolValue)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidarSeVerdadeiro(bool boolValue, string message)
        {
            if (boolValue)
            {
                throw new DomainException(message);
            }
        }
    }
}