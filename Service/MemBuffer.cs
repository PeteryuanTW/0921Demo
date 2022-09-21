namespace _0921Demo.Service
{
    public class MemBuffer
    {
        private int currentRound = 0;
        public int GetCurrentRound()
        {
            return currentRound;
        }
        public void SetCurrentRound(int a)
        {
            currentRound = a;
            CurrentRoundChange(a);
        }
        public event Action<int>? OnCurrentRoundChange;
        public void CurrentRoundChange(int currentRound) => OnCurrentRoundChange?.Invoke(currentRound);
    }
}
