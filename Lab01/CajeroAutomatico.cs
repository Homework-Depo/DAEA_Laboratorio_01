using System;
namespace Lab01
{
	public class CajeroAutomatico: CuentaBancaria
	{
		public double ConsultarSaldo()
		{
			return Balance;
		}

		public void AddBalance(double ammount)
		{
			this.Balance = this.Balance + ammount;
		}

		public void RemoveBalance(double ammount)
		{
			this.Balance = this.Balance - ammount;
		}

		public void ChangeSecurityPIN(int newPin)
		{
			this.SecurityPIN = newPin;
		}
	}
}

