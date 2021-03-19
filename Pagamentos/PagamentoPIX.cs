using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamentos
{
	public class PagamentoPix : Pagamento
	{
        public Chave Chave { get; set; }

        public override string ValidaValor()
        {
            return base.ValidaValor() + "Agora estou dentro do pagamento Pix!";
        }

        public override string ToString()
        {
            return base.ToString() + "\nChave: " + this.Chave;
        }
    }
}
