using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_dotnet_desafio_poo.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Nokia Store instalou {nomeApp.ToUpper()} no dispositivo {Modelo}!");
        }
    }
}