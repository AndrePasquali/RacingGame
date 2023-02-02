namespace OcarinaStudios.MathRacing.Game
{
    public interface IGameManager
    {
        public void Pause();
        public void Resume();
        public bool IsPaused();
    }
}