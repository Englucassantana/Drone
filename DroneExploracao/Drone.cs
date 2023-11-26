using System;
namespace DroneExploracao
{
	public class Drone
	{
		public Drone()
		{
		}
		public Decimal Altura { get; set; }
		public UInt16 Direcao { get; set; }
		public Decimal Velocidade { get; set; }
		public String StatusVelocidade { get; set; }

		public void DefinirAlturaEspecifica(Decimal alturaDefinida)
		{
			if (ValidarAlturaEspecifica(alturaDefinida))
			{
				Altura = alturaDefinida;
				Console.WriteLine($"Altura alterada de {Altura} para {alturaDefinida}");
			}
			else
			{
				Console.WriteLine("Altura inválida");
			}
		}
		public Boolean ValidarAlturaEspecifica(Decimal altura)
		{
			if (altura < 0.5m && altura > 25)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
		public void DefinirIncrementoAltura()
		{
			if (ValidarAlturaIncremento())
			{
				Altura = Altura + 0.5m;
				Console.WriteLine("Altura incrementada com sucesso");
			}
			else
			{
				Console.WriteLine("Altura não pode ser incrementada");
			}
		}
		public void DefinirDecrementoAltura()
		{
			if (ValidarAlturaDecremento())
			{
				Altura = Altura - 0.5m;
				Console.WriteLine("Altura foi decrementada com sucesso");
			}
			else
			{
				Console.WriteLine("Altura não pode incrementada");
			}
		}
		public Boolean ValidarAlturaIncremento()
		{
			if (Altura <= 24.5m)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public Boolean ValidarAlturaDecremento()
		{
			if(Altura >= 1)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public void SolitarMudancaDirecao(UInt16 direcao)
		{
			if (ValidarMudancaDirecaoExplicitada(direcao))
			{
				Direcao = direcao;
				Console.WriteLine("Mudança de direção válida");
			}
			else
			{
				Console.WriteLine("Mudança de direção inválida");
			}
		}
		public Boolean ValidarMudancaDirecaoExplicitada(UInt16 direcao)
		{
			if(direcao>0 && direcao <= 360)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public void SolicitarIncrementoDirecao()
		{
			for(int i = 0; i < 5; i++)
			{
				if (Direcao < 359)
				{
					Direcao++;
				} else
					Direcao = 0;
			}
			Console.WriteLine($"Direção mudada para {Direcao}");
		}
        public void SolicitarDecrementoDirecao()
        {
            for (int i = 5; i < 0; i--)
            {
                if (Direcao > 1)
                {
                    Direcao--;
                }
                else
                    Direcao = 359;
            }
            Console.WriteLine($"Direção mudada para {Direcao}");
        }
		public void SolicitarIncrementoVelocidade()
		{
			if (ValidarVelocidadeMáxima())
			{
				Velocidade += 0.5m;
				StatusVelocidade = "Em movimento";
			}
		}

        private bool ValidarVelocidadeMáxima()
        {
			return Velocidade <15 ?  true : false;
        }

		public void SolicitarDecrementoVelocidade()
		{
			if (VerificarVelocidadeMinima())
			{
				Velocidade -= 0.5m;
                StatusVelocidade = VerificarVelocidadeZero() == true ? "Sem Movimento" : "Em Movimento";
			}
			Console.WriteLine($"Velocidade atual: {Velocidade} e o Status da velocidade é: {StatusVelocidade}");
		}

        private bool VerificarVelocidadeZero()
        {
			return Velocidade == 0 ? true : false;
        }

        private bool VerificarVelocidadeMinima()
        {
            return Velocidade >= 0.5m ? true : false;
        }

    }
}

