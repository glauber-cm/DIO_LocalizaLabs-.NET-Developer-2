using CadSeriesDIO.Classes;
using CadSeriesDIO.Interfaces;
using System.Collections.Generic;

namespace CadSeriesDIO.Repositorio
{
	public class SerieRepositorio : IRepositorio<Serie>
	{
        private List<Serie> listaSerie = new List<Serie>();
		public void Atualizar(int id, Serie objeto)
		{
			listaSerie[id] = objeto;
		}

		public void Excluir(int id)
		{
			listaSerie[id].Excluir();
		}

		public void Inserir(Serie objeto)
		{
			listaSerie.Add(objeto);
		}

		public List<Serie> Listar()
		{
			return listaSerie;
		}

		public int ProximoId()
		{
			return listaSerie.Count;
		}

		public Serie RetornaPorId(int id)
		{
			return listaSerie[id];
		}
	}
}