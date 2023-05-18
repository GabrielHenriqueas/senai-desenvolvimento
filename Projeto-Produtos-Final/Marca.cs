using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produtos_Final
{
    public class Marca
    {
        public int Codigo {get; set;}
        public string NomeMarca {get; set;}
        public DateTime DataCadastro {get; set;}

        List<Marca> marcas = new List<Marca>();

        public Marca Cadastrar()
        {
            Marca _marca = new Marca();
            return _marca;
        }   
        
        public void Listar()
        {

        }

        public void Deletar()
        {

        }

    }
}