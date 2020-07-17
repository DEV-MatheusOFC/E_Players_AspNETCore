using System.Collections.Generic;
using E_Players_AspNETCore.Models;

namespace E_Players_AspNETCore.Interfaces
{
    public interface IJogador
    {
         void Create(Jogador j);
        // Ler
         List<Jogador> ReadAll();
        // Alterar
         void Update(Jogador j);
        // Deletar
         void Delete(int idJogador);
    }
}