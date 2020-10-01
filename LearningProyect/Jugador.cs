using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProyect
{
    class Jugador
    {
        private int points;

        private int wins;

        public Jugador()
        {
            this.points = 0;
            this.wins = 0;
        }

        public int Points { get { return this.points; } }

        public int setPoints(int points) => this.points = points;

        public int sumPoints(Carta card) => this.points += card.getPoints();

        public int Wins { get { return this.wins; } }

        public int setWins(int wins) => this.wins = wins;

        public int sumWins() => this.wins++;
        
    }
}
