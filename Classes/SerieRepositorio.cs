using System;
using System.Collection.Generic;
using Dio.Series.interfaces;

namespace DIO.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<series>();
        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }

         public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

         public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int proximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}