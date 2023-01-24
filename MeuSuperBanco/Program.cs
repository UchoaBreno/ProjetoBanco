namespace MeuSuperBanco
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MeuSuperBanco.ContaBanco contaB = new ContaBanco ("Breno", 10000);
			Console.WriteLine($"A conta {contaB.Numero} de {contaB.Dono} foi criada com {contaB.Saldo}");
		}
	}
}