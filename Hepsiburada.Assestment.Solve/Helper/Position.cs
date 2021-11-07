using Hepsiburada.Assestment.Solve.Model;

namespace Hepsiburada.Assestment.Solve.Helper
{
    public class Position
    {
        #region Variables
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
        public Directions Direction { get; set; } = Directions.N;
        #endregion
         
        #region Move Direction Methods
        void RotateLeft()
        {
            switch (this.Direction)
            {
                case Directions.N:
                    this.Direction = Directions.W;
                    break;
                case Directions.S:
                    this.Direction = Directions.E;
                    break;
                case Directions.E:
                    this.Direction = Directions.N;
                    break;
                case Directions.W:
                    this.Direction = Directions.S;
                    break;
            }
        }

        void RotateRight()
        {
            switch (this.Direction)
            {
                case Directions.N:
                    this.Direction = Directions.E;
                    break;
                case Directions.S:
                    this.Direction = Directions.W;
                    break;
                case Directions.E:
                    this.Direction = Directions.S;
                    break;
                case Directions.W:
                    this.Direction = Directions.N;
                    break;
            }
        }

        void MoveRover()
        {
            switch (this.Direction)
            {
                case Directions.N:
                    this.Y += 1;
                    break;
                case Directions.S:
                    this.Y -= 1;
                    break;
                case Directions.E:
                    this.X += 1;
                    break;
                case Directions.W:
                    this.X -= 1;
                    break;
            }
        }
        #endregion

        #region Start Moving
        public void StartMoving(string moves)
        {
            if (string.IsNullOrEmpty(moves))
                return;

            foreach (var move in moves)
            {
                switch (move)
                {
                    case 'M':
                        MoveRover();
                        break;
                    case 'L':
                        RotateLeft();
                        break;
                    case 'R':
                        RotateRight();
                        break;
                }                
            }
        }
        #endregion
    }
}
