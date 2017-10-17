namespace QueenAttack
{
    public class Queen
    {
        public bool CanAttack(int queenX, int queenY, int otherX, int otherY)
        {
            int negativeSlopeB = queenY + queenX;
            int positiveSlopeB = queenY - queenX;
            if (-otherX + negativeSlopeB == otherY || otherX + positiveSlopeB == otherY)
            {
                return true;
            }
            else if(queenX == otherX || queenY == otherY)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
