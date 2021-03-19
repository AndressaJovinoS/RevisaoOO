using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pagamentos;

namespace RevisaoOO
{
	class TestProtect : PagamentoPix
	{
		public void Main()
		{
			this.ELegal();
		}
	}
}
