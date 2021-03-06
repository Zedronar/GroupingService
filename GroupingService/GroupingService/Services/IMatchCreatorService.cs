﻿using GroupingService.Entities;
using System.Text;

namespace GroupingService.Services
{
    public interface IMatchCreatorService
    {
        void SetPlayersPerMatch(int playersPerMatch);

        void AddPlayer(Player player);

        StringBuilder DownloadAllMatches();

        void AssignTopPriorityPlayers();
    }
}