using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_D365_Hotel.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome){
            Nome = nome;
            Sobrenome = sobrenome;
        }
        private string _nome;
        public string Nome 
        {
            set{
                if (value == null){
                   throw new Exception("Nome está vazio. Preencha o campo nome");     
                }else{
                    _nome = value;
                }
            }
        }
        private string _sobrenome;
        public string Sobrenome 
        { 
            set{
                if (value == null){
                    throw new Exception("Sobrenome está vazio. Preencha o campo sobrenome");     
                }else{
                    _sobrenome = value;
                }
            }
        }
        public string NomeCompleto{
            get{
               return $"{_nome} {_sobrenome}".ToUpper();
            }
        }
    }
}