using System.Collections.Generic;
using Ackbar.Models;

namespace Ackbar.Api
{
    public interface IRegressionService
    {
        void CalculateRegression(Player player, IEnumerable<Game> randomGames);
        IEnumerable<Game> OrderGameListByRegressionScore(Player player, IEnumerable<Game> notYetLikedGames);
    }
}