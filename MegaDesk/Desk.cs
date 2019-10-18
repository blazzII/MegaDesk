namespace MegaDesk
{
    public class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumberOfDrawers { get; set; }
        public DesktopMaterial DesktopMaterial { get; set; }

        #region Desk Contraints / Constants
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;
        #endregion
    }

    public enum DesktopMaterial
    {
        Pine = 50,
        Oak = 200,
        Laminate = 100,
        Rosewood = 300,
        Veneer = 125
    };
}
