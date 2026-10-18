// GolBet.Repositories/Interfaces/IMatchRepository.cs
using GolBet.Entities;
using GolBet.Entities.Enums;
using GolBet.Repositories.Data;
using GolBet.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;

namespace GolBet.Repositories.Interfaces;

public interface IMatchRepository : IGenericRepository<Match>
{
    //Se agrega search para filtrar por nombre de equipo en el tablero de partidos
    Task<IEnumerable<Match>> GetAllWithTeamsAsync(MatchStatus? status = null, string? search = null);
    Task<Match?> GetByIdWithDetailsAsync(int id);
}
