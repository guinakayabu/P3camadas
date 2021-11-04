using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3Camadas.Code.DTO
{
    class MotorDTO
    {
        //Properiedades privadas
        private int _anoFabricacao;
        private string _marca;
        private int _codigo;
        private string _engenheiroResponsavel;

        //Métodos de encapsulamento (CTRL+R,E)
        public int anoFabricacao { get => _anoFabricacao; set => _anoFabricacao = value; }
        public string marca { get => _marca; set => _marca = value; }
        public int codigo { get => _codigo; set => _codigo = value; }
        public string engenheiroResponsavel { get => _engenheiroResponsavel; set => _engenheiroResponsavel = value; }
    }
}
