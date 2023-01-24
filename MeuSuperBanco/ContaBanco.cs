using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MeuSuperBanco
{
	internal class ContaBanco
	{
		public string Numero { get; }
		public string Dono { get; set; }

		public decimal Saldo
		{
			get
			{
				decimal saldo = 0;
				foreach (var item in todasTransacoes)
				{
					saldo += item.Valor;
				}
				return saldo;
			}
		}
	 

		public static int numeroConta = 1234567890;

		private List<Transacao>todasTransacoes = new List<Transacao>();

		public ContaBanco(string nome, decimal valor)
		{
			this.Dono = nome;
			numeroConta++;

			this.Numero = numeroConta.ToString();
			Depositar(valor, DateTime.Now, "saldo inicial");
		}

			public void Depositar(decimal valor, DateTime data, string obs)
			{	
			Transacao trans = new Transacao(valor, data, obs);
			todasTransacoes.Add(trans);
			}
			public void sacar(decimal valor, DateTime data, string obs)
			{
				Transacao trans = new Transacao(-valor, data, obs);
				todasTransacoes.Add(trans);
		}

		}
	}
}
