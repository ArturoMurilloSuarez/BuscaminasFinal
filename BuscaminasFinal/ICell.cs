namespace BuscaminasFinal //Cambiar el nombre del namespace
{
    public interface ICell
    {
        int GetValue();
        bool IsHidden();
        Celda.Status GetStatus();

        void LeftClick();
        void RightClick();

        void Endgame();
    }
}