using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_D365_Hotel.Models
{
    public class Reserva
    {
        public Reserva(){}
        public Reserva(int diasReservados){
            DiasReservados  = diasReservados;
        }
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }
        public void CadastrarHospedes(List<Pessoa> hospedes){
            if(hospedes.Count <= Suite.Capacidade){ 
                Hospedes = hospedes;
            }else{
                throw new Exception ("A quantidade de hóspedes excede a capacidade da suíte escolhida");
            }
        }
        public void CadastrarSuite(Suite suite){
            Suite = suite;
        }
        public int ObterQuantidadeHospedes(){
            return Hospedes.Count();
        }
        public decimal CalcularValorDiaria(){
            //TODO: Caso a reserva tenha 10 ou mais dias, deverá ser aplicado um desconto de 10%.
            decimal valorTotal = Suite.ValorDiaria * DiasReservados;
            decimal desconto = 0.1M;

            if( DiasReservados >= 10){
                valorTotal = valorTotal  * (1.00M - desconto);
            }
            return valorTotal;
        }

    }
}