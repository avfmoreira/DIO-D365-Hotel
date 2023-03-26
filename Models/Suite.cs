using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_D365_Hotel.Models
{
    public class Suite
    {
        public Suite(string tipoSuite, int capacidade, decimal valorDiaria){
            TipoSuite   = tipoSuite;
            Capacidade  = capacidade;
            ValorDiaria = valorDiaria;
        }
        private string _tipoSuite;
        public string TipoSuite { 
            get {
                return TipoSuite = _tipoSuite;
            }
            set{
                if (value == null){
                    throw new Exception("O Tipo de suíte está vazio. Preencha o campo Tipo suíte");     
                }else{
                    _tipoSuite = value;
                }
            }
        }
        public int Capacidade;
        public decimal ValorDiaria;
        
    }
}