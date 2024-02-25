using Application.Interfaces.Services;
using Application.Viewmodels;
using System.Text;

namespace Application.Services
{
    public class RetiroService : IRetiroService
    {
        public string Retirar(DispensingViewModel dispensingMode, int monto)
        {
            string resultado;
            switch (dispensingMode.ModoDispensacion)
            {
                case (int)Enum.DispensingMode.MODO_200Y1000:
                    resultado = Modo200y1000(monto);
                    break;
                case (int)Enum.DispensingMode.MODO_100Y500:
                    resultado = Modo100y500(monto);
                    break;
                case (int)Enum.DispensingMode.MODO_EFICIENTE:
                    resultado = ModoEficiente(monto);
                    break;
                default:
                    resultado = null;
                    break;
            }
            return resultado;
        }

        private static string Modo200y1000(int monto)
        {
            int[] billetes = { 200, 1000 };
            StringBuilder resultado = new();

            for (int i = billetes.Length - 1; i >= 0; i--)
            {
                if (monto >= billetes[i])
                {
                    int cantidadBilletes = monto / billetes[i];
                    monto %= billetes[i];
                    if (cantidadBilletes > 1)
                    {
                        resultado.Append($"{cantidadBilletes} billetes de {billetes[i]}<br>");
                    }
                    else
                    {
                        resultado.Append($"{cantidadBilletes} billete de {billetes[i]}<br>");
                    }
                }

            }

            if (monto != 0)
            {
                throw new Exception("Este cajero solo acepta montos válidos para billetes de 200 y 1000. ");
            }

            return resultado.ToString();

        }

        private static string Modo100y500(int monto)
        {
            int[] billetes = { 100, 500 };
            StringBuilder resultado = new();

            for (int i = billetes.Length - 1; i >= 0; i--)
            {
                if (monto >= billetes[i])
                {
                    int cantidadBilletes = monto / billetes[i];
                    monto %= billetes[i];
                    if (cantidadBilletes > 1)
                    {
                        resultado.Append($"{cantidadBilletes} billetes de {billetes[i]}<br>");
                    }
                    else
                    {
                        resultado.Append($"{cantidadBilletes} billete de {billetes[i]}<br>");
                    }
                }

            }

            if (monto != 0)
            {
                throw new Exception("Este cajero solo acepta montos válidos para billetes de 100 y 500. ");
            }

            return resultado.ToString();
        }

        private static string ModoEficiente(int monto)
        {
            int[] billetes = { 100, 200, 500, 1000 };
            StringBuilder resultado = new();

            for (int i = billetes.Length - 1; i >= 0; i--)
            {
                if (monto >= billetes[i])
                {
                    int cantidadBilletes = monto / billetes[i];
                    monto %= billetes[i];
                    if (cantidadBilletes > 1)
                    {
                        resultado.Append($"{cantidadBilletes} billetes de {billetes[i]}<br>");
                    }
                    else
                    {
                        resultado.Append($"{cantidadBilletes} billete de {billetes[i]}<br>");
                    }
                }
            }

            return resultado.ToString();
        }
    }
}
